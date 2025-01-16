using System;
using System.Windows.Forms;
using RozliczenieApp.Models;
using RozliczenieApp.Data;

namespace RozliczenieApp
{
    public partial class SalaryForm : Form
    {
        private readonly DatabaseHelper _dbHelper;
        private readonly Uzytkownik _zalogowanyUzytkownik;

        public SalaryForm(Uzytkownik zalogowanyUzytkownik)
        {
            InitializeComponent();
            _dbHelper = new DatabaseHelper();
            _zalogowanyUzytkownik = zalogowanyUzytkownik;

            WyswietlImieNazwisko();
            OdczytajDane();
        }

        private void WyswietlImieNazwisko()
        {
            if (_zalogowanyUzytkownik != null)
            {
                lblZalogowany.Text = $"Zalogowany: {_zalogowanyUzytkownik.FirstName} {_zalogowanyUzytkownik.LastName}";
            }
        }

        private void OdczytajDane()
        {
            var kursy = _dbHelper.GetKursy();
            foreach (var kurs in kursy)
            {
                lstKursy.Items.Add($"Data: {kurs.Data.ToShortDateString()}, Opis: {kurs.Opis}, Liczba kursów: {kurs.LiczbaKursow}, Kwota: {kurs.Kwota} zł");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Liczbabox.Text) || !int.TryParse(Liczbabox.Text, out int liczbaKursow))
            {
                MessageBox.Show("Wprowadź poprawną liczbę kursów.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(Opisbox.Text))
            {
                MessageBox.Show("Opis kursu nie może być pusty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime data = dateTimePicker1.Value;
            string opis = Opisbox.Text;
            decimal kwota = ObliczanieZarobkow.ObliczKwote(liczbaKursow, data.DayOfWeek);

            Wyniklbl.Text = $"Kwota: {kwota} zł";

            var kurs = new Kurs
            {
                Data = data,
                LiczbaKursow = liczbaKursow,
                Opis = opis,
                Kwota = kwota
            };

            _dbHelper.AddKurs(kurs);
            lstKursy.Items.Add($"Data: {kurs.Data.ToShortDateString()}, Opis: {kurs.Opis}, Liczba kursów: {kurs.LiczbaKursow}, Kwota: {kurs.Kwota} zł");
        }

        private void SalaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Dane zostały zapisane przed zamknięciem aplikacji.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
