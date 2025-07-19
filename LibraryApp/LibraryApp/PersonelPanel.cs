using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryApp
{
    public partial class PersonelPanel : Form
    {
        // her zaman kullanilacak veri tabani elemanlari
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private string connectionString = "Server=localhost,3306;Database=libraryApp;Uid=root;Pwd=Fatma28438.;";

        public PersonelPanel()
        {
            InitializeComponent();  // bilesenleri ekrana getir
            InitializeDatabase();   // veri tabanini baslat
            connection.Close(); // hali hazirda baglanti varsa kapat yenisini acalim
        }
        private void InitializeDatabase()
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // ilk kayitlar icin eger tablo yoksa olusturalim
                    string createTableQuery = "CREATE TABLE IF NOT EXISTS books (id INT AUTO_INCREMENT PRIMARY KEY, bookName VARCHAR(50), author VARCHAR(50), publishYear YEAR, revise BOOL, revisedBy VARCHAR(50))";
                    MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection);
                    createTableCommand.ExecuteNonQuery();

                    // Yeni bir adapter acip komutla eslestirelim
                    string selectQuery = "SELECT * FROM books";
                    adapter = new MySqlDataAdapter(selectQuery, connection);

                    // Adapteri kullanarak datatable i dolduralim
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBooks.DataSource = dt;
                    SortByTitle(); // kitaplari basliga gore sirala
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Baglantiyi using blogu icinde kuralim
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string bookName = txtBookName.Text;
                    string author = txtAuthor.Text;
                    int year = dateTimePicker1.Value.Year;
                    bool revise = chkRevise.Checked;
                    string revisedBy = cmbRevisedBy.Text;

                    // Eger revize kutusu isaretli degilse kim tarafindan revize edilecegi alani null olacak
                    if (!revise) { revisedBy = null; }

                    // verileri veri tabanina yerlestirelim
                    string query = "INSERT INTO books (bookName, author, publishYear, revise, revisedBy) VALUES (@bookName, @author, @year, @revise, @revisedBy)";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@bookName", bookName);
                    command.Parameters.AddWithValue("@author", author);
                    command.Parameters.AddWithValue("@year", year);
                    command.Parameters.AddWithValue("@revise", revise);
                    command.Parameters.AddWithValue("@revisedBy", revisedBy);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Book added successfully.");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            InitializeDatabase(); // veri tabanindaki bilgiler tablomuza islem sonunda kendiliginden gelsin
        }



        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Burada da using blogu icinde baglantiyi olusturalimn
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string bookNameToRemove = txtBookName.Text;
                    string query = "DELETE FROM books WHERE bookName = @bookNameToRemove";
                    // kitap ismi silinecek kitap ismi ile ayniysa siler
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@bookNameToRemove", bookNameToRemove);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // etkilenen satir sayisi 0 dan fazlaysa yani varsa kitap silinmistir
                        MessageBox.Show("Book removed successfully.");
                    }
                    else
                    {
                        // 0 satir etkilendiyse silinecke kitap ismi veri tabaninda mevcut degildir
                        MessageBox.Show("Book not found.");
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            InitializeDatabase(); // veri tabanindaki bilgiler tablomuza islem sonunda kendiliginden gelsin
        }


        private void PersonelPanel_Load(object sender, EventArgs e)
        {
            // Panel acildigi anda combobox secekeleri user listesi olarak gelecek
            LoadRevisedByData();
        }

        private void LoadRevisedByData()
        {
            // yeni veri girisi oncesi cmbRevisedBy daki mevcut ogeyi temizler
            cmbRevisedBy.Items.Clear();

            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT mail FROM users;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // her bir mailin comboboxa alinmasi icin dongu acalim
                        while (reader.Read())
                        {
                            string userName = reader["mail"].ToString();
                            cmbRevisedBy.Items.Add(userName);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void SortByTitle()
        {
            // selection sort algoritmasini kullandik
            try
            {
                DataTable dt = (DataTable)dgvBooks.DataSource;
                int n = dt.Rows.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (string.Compare(dt.Rows[j]["bookName"].ToString(), dt.Rows[minIndex]["bookName"].ToString(), StringComparison.OrdinalIgnoreCase) < 0)
                        {
                            minIndex = j;
                        }
                    }

                    if (minIndex != i)
                    {
                        DataRow row1 = dt.Rows[i];
                        DataRow row2 = dt.Rows[minIndex];

                        object[] tempArray = row1.ItemArray;
                        row1.ItemArray = row2.ItemArray;
                        row2.ItemArray = tempArray;
                    }
                }

                // datagriedview in datasource unu buna gore ayarlamaliyiz yoksa default olarak id ye gore siralar
                dgvBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while sorting: {ex.Message}");
            }
        }
    }
}
