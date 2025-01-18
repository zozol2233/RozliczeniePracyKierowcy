using RozliczenieApp.Data;
using RozliczenieApp.Models;
using System;
using System.Net;
using System.Windows.Forms;

namespace RozliczenieApp
{
    public partial class DriverForm : Form
    {
        private Uzytkownik _uzytkownik;

        public DriverForm()
        {
            InitializeComponent();
        }
        public DriverForm(Uzytkownik uzytkownik)
        {
            InitializeComponent();
            _uzytkownik = uzytkownik;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
        

            string licensePlate = txtLicensePlate.Text;
            string carType = cmbCarType.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(licensePlate) || string.IsNullOrWhiteSpace(carType))
            {
                MessageBox.Show("Pola muszą być wypełnione!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dbHelper = new DatabaseHelper();
            dbHelper.AddDriver(_uzytkownik.FirstName, _uzytkownik.LastName, _uzytkownik.Username, _uzytkownik.Password, licensePlate, carType);

            MessageBox.Show("Dane kierowcy zostały zapisane pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }


    }
}
