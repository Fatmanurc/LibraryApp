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
    public partial class LoginForm : Form
    {
        // veri tabani islemleri icin surekli gerekecek alanlar
        private MySqlConnection connection;
        private MySqlCommand command;
        private readonly string connectionString = "Server=localhost,3306;Database=libraryApp;Uid=root;Pwd=Fatma28438.;";


        public LoginForm()
        {
            InitializeComponent();  // form bilesenlerini cagiralim
            InitializeDatabase();   // database ile baglantiyi baslatalim
            connection.Close();     // form acildiginde yeni baglantilarin dogru calismasi icin
                                    // eski baglantinin kapandigina emin olalim
        }

        private void InitializeDatabase()
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                using (connection = new MySqlConnection(connectionString)) {
                    // baglantiyi tanimla
                    connection.Open();
                    connection = new MySqlConnection(connectionString);
                    // eger tablo hali hazirda yoksa olusturalim ve baglanti kuralim
                    string query = "CREATE TABLE IF NOT EXISTS users (id INT AUTO_INCREMENT PRIMARY KEY, mail VARCHAR(50) UNIQUE, password VARCHAR(50))";
                    // id bizim hem primary key imiz hem de autoincr. olarak artacak
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();  // etkilenen satir sayisini dondurur
                    connection.Close();
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Form yuklendiginde sifrenin * lar ile gosterilmesini saglar yoksa txt olarak acik gozukurdu
        private void LoginForm_Load(object sender, EventArgs e) { txtPassword.PasswordChar = '*'; }

        // txtPassword kutusuna oodaklandiginda * lari arttir
        private void txtPassword_TextChanged_1(object sender, EventArgs e) { txtPassword.PasswordChar = '*'; }

        private void btnLogin_Click_1(object sender, EventArgs e)
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
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, mail, pass FROM users WHERE mail = @mail";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@mail", mail);
                    var reader = command.ExecuteReader();   // etkilenen satir sayisini dondurur
                    // veri tabanindaki user maili ve sifresi eslesiyor mu kontrol edecegiz

                    if (reader.Read())  // etkilenen satir sayisi 0 dan fazla yani boyle bir mail adresi var
                    {
                        string dbPassword = reader["pass"].ToString();
                        int userId = Convert.ToInt32(reader["id"]);
                        string dbMail = reader["mail"].ToString();
                        if (password == dbPassword)
                        {
                            // user panele giris yap cunku mail ve sifre eslesiyor
                            UserPanel usPanel = new UserPanel(dbMail);
                            connection.Close();
                            usPanel.Show();
                            this.Hide();
                        }
                        else
                        {
                            // sifre yanlissa uyari ver
                            MessageBox.Show("Invalid password.");
                        }
                    }
                    else    // etkilenen satir sayisi 0 dan kucuk yani boyle bir mail adresi yok
                    {
                        // Mail veri tabaninda yoksa uyari ver
                        MessageBox.Show("Invalid mail adress.");
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Register formuna gecis yap
            connection.Close();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();

        }
    }
}

