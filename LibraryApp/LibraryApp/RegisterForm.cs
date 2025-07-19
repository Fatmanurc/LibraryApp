using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class RegisterForm : Form
    {
        // Baglanti icin her yerde kullanacagimiz alanlar
        private MySqlConnection connection;
        private MySqlCommand command;
        private string connectionString = "Server=localhost,3306;Database=libraryApp;Uid=root;Pwd=Fatma28438.;";

        public RegisterForm()
        {
            InitializeComponent();
            InitializeDatabase();
            connection.Close();
        }

        // Veri tabani baglantisi acalim
        private void InitializeDatabase()
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    connection = new MySqlConnection(connectionString);
                    // ilk kayitlar icin eger tablo yoksa olusturalim
                    string query = "CREATE TABLE IF NOT EXISTS users (id INT AUTO_INCREMENT PRIMARY KEY, mail VARCHAR(50) UNIQUE, pass VARCHAR(50))";
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                // Tum alanlar dolu olmak zorunda
                MessageBox.Show("Please enter all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                // sifre ve dogrulama ayni olmalidir
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO users (mail, pass) VALUES (@mail, @pass)";
                    // sorun yoksa bilgileri veri tabanina kaydederiz
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@pass", password);
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Registration successful. You can now log in.");
                    connection.Close();
                    // Login sayfasina gecis yap
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // txtPassword kutusuna tiklandiginda
        private void txtPassword_TextChanged(object sender, EventArgs e) { txtPassword.PasswordChar = '*'; }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e) { txtPassword.PasswordChar = '*'; }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*'; // Maskeleme karakteri olarak * aldik
            txtConfirmPassword.PasswordChar = '*';
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Login formuna gecis yap
            connection.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
