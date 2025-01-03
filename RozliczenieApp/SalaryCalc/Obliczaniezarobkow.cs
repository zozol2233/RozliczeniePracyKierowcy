using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozliczenieApp.SalaryCalc
{
    public static class ObliczanieZarobkow
    {
        public static decimal ObliczKwote(int liczbaKursow, DayOfWeek dzienTygodnia)
        {
            if (liczbaKursow == 0) return 0;

            if (dzienTygodnia == DayOfWeek.Saturday)
            {
                return liczbaKursow * 100 + 80; // Każdy kurs: 100 zł, dodatek: 80 zł
            }
            else if (dzienTygodnia == DayOfWeek.Sunday)
            {
                return liczbaKursow * 100 + 100; // Każdy kurs: 100 zł, dodatek: 100 zł
            }
            else
            {
                decimal kwota = 0;
                if (liczbaKursow >= 1) kwota += 230; // Pierwsze dwa kursy: 230 zł
                if (liczbaKursow >= 3) kwota += 80;  // Trzeci kurs: +80 zł
                if (liczbaKursow > 3) kwota += (liczbaKursow - 3) * 120; // Kolejne: +120 zł
                return kwota;
            }
            
        }
    }
}
