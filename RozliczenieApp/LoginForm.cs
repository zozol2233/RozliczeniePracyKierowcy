using RozliczenieApp.Data;
using RozliczenieApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozliczenieApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var dbHelper = new DatabaseHelper();

            if (dbHelper.ValidateUser(username, password))
            {
                MessageBox.Show("Zalogowano pomyślnie!");

                // dane użytkownika z bazy
                Uzytkownik uzytkownik = dbHelper.GetUserByUsername(username);

                SalaryForm salaryForm = new SalaryForm(uzytkownik);
                salaryForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}