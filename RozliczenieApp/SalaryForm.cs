using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RozliczenieApp.Data;
using RozliczenieApp.Models;
using RozliczenieApp.SalaryCalc;

namespace RozliczenieApp
{
    public partial class SalaryForm : Form
    {
        private Uzytkownik _uzytkownik;

        public SalaryForm()
        {
            InitializeComponent();
        }

        public SalaryForm(Uzytkownik uzytkownik)
        {
            InitializeComponent();
            _uzytkownik = uzytkownik;

            // Pobierz dane kierowcy z bazy
            var dbHelper = new DatabaseHelper();
            var driver = dbHelper.GetDriverByUsername(_uzytkownik.Username);

            if (driver != null)
            {
                DisplayUserData(driver);
                DisplayCourses();
            }
            else
            {
                MessageBox.Show("Brak danych kierowcy w bazie.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DisplayUserData(Driver driver)
        {
            lblName.Text = $"Imię i nazwisko: {driver.FirstName} {driver.LastName}";
            lblLicensePlate.Text = $"Numer rejestracyjny: {driver.LicensePlate}";
            lblCarBrand.Text = $"Marka samochodu: {driver.CarType}";
        }

        private void DisplayCourses()
        {
            var dbHelper = new DatabaseHelper();
            var courses = dbHelper.GetCoursesByDriverUsername(_uzytkownik.Username);

            Kursy.Items.Clear(); // Wyczyść listę kursów przed dodaniem nowych

            foreach (var course in courses)
            {
                Kursy.Items.Add($"Data: {course.Data.ToShortDateString()}, Opis: {course.Opis}, Liczba kursów: {course.LiczbaKursow}, Kwota: {course.Kwota:C}");
            }
        }

        private void btnDodajkurs_Click(object sender, EventArgs e)
        {
            var dbHelper = new DatabaseHelper();

            // Pobierz dane z formularza
            DateTime date = dateTimePicker1.Value;
            string description = Opisbox.Text;

            if (!int.TryParse(Liczbabox.Text, out int tripsCount))
            {
                MessageBox.Show("Proszę podać poprawną liczbę kursów.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Automatyczne obliczanie kwoty
            decimal amount = ObliczanieZarobkow.ObliczKwote(tripsCount, date.DayOfWeek);

            // Dodaj kurs do bazy danych
            dbHelper.AddCourse(_uzytkownik.Username, date, description, tripsCount, amount);

            // Odśwież listę kursów
            DisplayCourses();

            // Wyświetl komunikat potwierdzający
            MessageBox.Show("Kurs został dodany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lstKursy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Opcjonalna logika po wybraniu kursu z listy
        }
    }
}
