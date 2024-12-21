using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozliczenieApp.Models
{
    public class Kurs
    {
        public DateTime Data { get; set; } // Data kursu
        public string Opis { get; set; }   // Opis lokalizacji
        public int LiczbaKursow { get; set; } // Liczba kursów
        public decimal Kwota { get; set; } // Zarobiona kwota
    }
}
