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
    public partial class PersonelLoginForm : Form
    {
        // veri tabani islemleri icin surekli gerekecek alanlar
        private MySqlConnection connection;
        private MySqlCommand command;
        private readonly string connectionString = "Server=localhost,3306;Database=libraryApp;Uid=root;Pwd=Fatma28438.;";


        public PersonelLoginForm()
        {
            InitializeComponent();  // form bilesenlerini cagiralim
            InitializeDatabase();   // database ile baglantiyi baslatalim
            connection.Close();     // eski baglantilari kapat
        }

        private void InitializeDatabase()
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    // baglantiyi tanimla
                    connection.Open();
                    connection = new MySqlConnection(connectionString);
                    // eger users tablosu hali hazirda yoksa olusturalim ve baglanti kuralim
                    string query = "CREATE TABLE IF NOT EXISTS personels (id INT AUTO_INCREMENT PRIMARY KEY, mail VARCHAR(50) UNIQUE, pass VARCHAR(50))";
                    // id bizim hem primary key imiz hem de autoincr. olarak artacak
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery(); // ETKİLENEN SATİR SAYİSİ
                    connection.Close(); // baglantiyi kapat
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        // Form yuklendiginde sifre * ile gosterilsin
        private void PersonelLoginForm_Load(object sender, EventArgs e) { txtPassword.PasswordChar = '*'; }

        // txtPassword kutusuna her giriste txt yerine * olsun
        private void txtPassword_TextChanged(object sender, EventArgs e) { txtPassword.PasswordChar = '*'; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            string password = txtPassword.Text;


            if (string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(password))
            {
                // Tum alanlar dolu olmali
                MessageBox.Show("Please enter both mail and password.");
                return;
            }

            try
            {
                connection.Open();
                string query = "SELECT id, mail, pass FROM personels WHERE mail = @mail";
                // mail adresi eslesiyorsa
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@mail", mail);
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // verileri alalim
                    string dbPassword = reader["pass"].ToString();
                    int userId = Convert.ToInt32(reader["id"]); // int e donusturelim
                    string dbMail = reader["mail"].ToString();
                    if (password == dbPassword)
                    {
                        // personel panele gecis yap
                        connection.Close();
                        PersonelPanel personelPanel = new PersonelPanel();
                        personelPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Yukarda veri tabaninda ilgili kullaniciya ait sifre ve mail in eslesip eslesmedigine baktik
                        MessageBox.Show("Invalid password.");
                    }
                }
                else
                {
                    // Mail veri tabaninda yoksa uyari ver
                    MessageBox.Show("Invalid mail adress.");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

