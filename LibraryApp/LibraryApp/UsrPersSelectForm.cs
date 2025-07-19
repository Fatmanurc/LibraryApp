using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class UsrPersSelectForm : Form
    {
        public UsrPersSelectForm()
        {
            InitializeComponent();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            // Personel Login formuna gonder
            PersonelLoginForm personelLoginForm = new PersonelLoginForm();
            personelLoginForm.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
            // user login formuna gönder
        }
    }
}
