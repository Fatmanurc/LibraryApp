using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class UserPanel : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private string connectionString = "Server=localhost,3306;Database=libraryApp;Uid=root;Pwd=Fatma28438.;";
        private string email;   // burada da mail karsilama ekrani icin gerekiyor

        public UserPanel(string mail)
        {
            InitializeComponent();
            InitializeDatabase();
            email = mail;
            lblUsername.Text = mail;
            lblWelcome.Text = "Welcome " + mail;    // kullaniciyi mail adresiyle karsila
            btnSearch.Click += BtnSearch_Click; // event ekliyoruz arama butonu
            btnRevise.Click += BtnRevise_Click; // // event ekliyoruz revize butonu
            btnSeeMyBooks.Click += BtnSeeMyBooks_Click; // // event ekliyoruz revize ettigimiz kitaplari gorme butonu
            connection.Close();
        }

        private void InitializeDatabase()
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // revize edilmemis kitaplari ekranda goster
                    string query = "SELECT * FROM books WHERE revise = false";
                    adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBooks.DataSource = dt;
                    SortByTitle();  // sorting algoritmasi kullanarak kitap ismine gore siralama
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string searchQuery = txtSearch.Text;
                    // kitap veya yazar ismi, arama bolumune yazilan txt yi icreiyorsa siralar
                    string query = $"SELECT * FROM books WHERE revise = false AND (bookName LIKE '%{searchQuery}%' OR author LIKE '%{searchQuery}%')";
                    // adapter ile doldurur
                    adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBooks.DataSource = dt;
                    SortByTitle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close(); // tum islemler bittiginde baglantiyi kapatir
            }
        }

        private void BtnRevise_Click(object sender, EventArgs e)
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    int bookID = int.Parse(txtID.Text);
                    string revisedBy = email;
                    // update ile veri tabanindaki katdin revize alanini guncelliyotuz
                    string query = "UPDATE books SET revise = true, revisedBy = @revisedBy WHERE ID = @bookID AND revise = false";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@bookID", bookID); // alana doldurma islemi
                    command.Parameters.AddWithValue("@revisedBy", revisedBy);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)   // islem sonunda etkilenen satir sayisi 0 dan fazlaysa basarili
                    {
                        MessageBox.Show("Book revised successfully.");
                    }
                    else // kucukse basarisiz
                    {
                        MessageBox.Show("Book not found or already revised.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            InitializeDatabase(); // tekrar ekranda tum revize olmayan verileri gosterir
        }

        private void BtnSeeMyBooks_Click(object sender, EventArgs e)
        {
            // kendi kitaplarinizi gorebileceginiz ekrana yonlendirme
            connection.Close();
            RevisedBooks myBook = new RevisedBooks(email);
            myBook.Show();
            this.Hide();
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

                // Sdatagriedview in datasource unu buna gore ayarlamaliyiz yoksa default olarak id ye gore siralar
                dgvBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while sorting: {ex.Message}");
            }
        }
    }
}
