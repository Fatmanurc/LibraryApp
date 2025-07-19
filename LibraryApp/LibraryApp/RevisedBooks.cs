using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryApp
{
    public partial class RevisedBooks : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private string connectionString = "Server=localhost,3306;Database=libraryApp;Uid=root;Pwd=Fatma28438.;";
        private string email;

        public RevisedBooks(string mail)
        {
            this.email = mail;  // mail adresi kisinin kendi kitaplarini gorebilmemiz icin gerekli
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase2()
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    
                    string query = $"SELECT * FROM books WHERE revise = true AND revisedBy = '%{email}%'";

                    adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvRevisedBooks.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            finally { connection.Close(); }
        }

        private void InitializeDatabase()
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // datagriedview e kullanici tarafindan revize edilmis kitaplari al
                    string query = "SELECT * FROM books WHERE revise = true AND revisedBy = @Email";
                    // MySqlCommand olustur ve parametreyi ekle
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    // mail kullanici mailiyle ayni olmali ve boolean revizemiz true olmali
                    // adapter kullanarak datagriedviewi veri tabanindaki bilgilerle dolduruyoruz
                    adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    // DataGridView e verileri bagliyoruz
                    dgvRevisedBooks.DataSource = dt;
                    SortByTitle(); // kitaplari selection sort ile basliga gore sirala
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
        }


        private void SortByTitle()
        {
            // selection sort algoritmasini kullandik
            try
            {
                DataTable dt = (DataTable)dgvRevisedBooks.DataSource;
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
                dgvRevisedBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while sorting: {ex.Message}");
            }
        }
    }


}

