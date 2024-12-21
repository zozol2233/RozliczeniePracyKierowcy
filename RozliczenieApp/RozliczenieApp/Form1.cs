using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // Pobieranie danych
            DateTime data = dateTimePicker1.Value;
            int liczbaKursow = int.Parse(Liczbabox.Text);
            string opis = Opisbox.Text;

            //Obliczanie wyniku
            decimal kwota = ObliczanieZarobkow.ObliczKwote(liczbaKursow, data.DayOfWeek);

            //WYnik
            Wyniklbl.Text = $"Kwota: {kwota} zł";
        }
    }
}
