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
            // Sprawdzenie, czy zmienna _uzytkownik jest pusta
            if (_uzytkownik == null)
            {
                MessageBox.Show("Brak zalogowanego użytkownika! Przejście do formularza logowania.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Otwórz formularz logowania lub inny odpowiedni formularz
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close(); // Zamknij bieżący formularz
                return;
            }

            // Pobranie danych z pól formularza
            string licensePlate = txtLicensePlate.Text;
            string carType = cmbCarType.SelectedItem?.ToString();

            // Sprawdzenie, czy pola są wypełnione
            if (string.IsNullOrWhiteSpace(licensePlate) || string.IsNullOrWhiteSpace(carType))
            {
                MessageBox.Show("Pola muszą być wypełnione!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Utworzenie obiektu klasy Driver
            Driver driver = new Driver(
                _uzytkownik.FirstName,
                _uzytkownik.LastName,
                _uzytkownik.Username,
                _uzytkownik.Password,
                licensePlate,
                carType
            );

            // Dodanie kierowcy do bazy danych
            var dbHelper = new DatabaseHelper();
            dbHelper.AddDriver(driver.FirstName, driver.LastName, driver.Username, driver.LicensePlate, driver.CarType);

            MessageBox.Show("Dane kierowcy zostały zapisane pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Przekazanie obiektu _uzytkownik do SalaryForm
            SalaryForm salaryForm = new SalaryForm(_uzytkownik);
            salaryForm.Show();
            this.Close();
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {

        }
    }
}
