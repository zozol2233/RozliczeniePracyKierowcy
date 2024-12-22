using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RozliczenieApp.Models;
using RozliczenieApp.SalaryCalc;


namespace RozliczenieApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dane
            DateTime data = dateTimePicker1.Value;
            int liczbaKursow = int.Parse(Liczbabox.Text);
            string opis = Opisbox.Text;

            //Obliczanie wyniku
            decimal kwota = ObliczanieZarobkow.ObliczKwote(liczbaKursow, data.DayOfWeek);

            //WYnik
            Wyniklbl.Text = $"Kwota: {kwota} zł";


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajkurs_Click(object sender, EventArgs e)
        {
            string data = dateTimePicker1.Value.ToShortDateString(); // pobranie daty
            string opis = Opisbox.Text; // pobranie opisu kursu
            string liczbaKursow = Liczbabox.Text; // pobranie liczby kursów
            string kwota = txtKwota.Text; // pobranie zarobkow

            // dodanie danych do listboxa
            lstKursy.Items.Add($"Data: {data}, Opis: {opis}, Liczba kursów: {liczbaKursow}, Kwota {kwota}");
        }

        private void lstKursy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}