using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RozliczenieApp.Models;

namespace RozliczenieApp.Serwis
{
    public static class Menago
    {
        private static List<Kurs> kursy = new List<Kurs>();
        public static void DodajKurs(Kurs kurs)
        {
            kurs.Id = kursy.Count + 1; 
            kursy.Add(kurs);
        }
        public static List<Kurs> Pobierz()
        {
            return kursy;
        }
        public static void UsunKurs(int id)
        {
            var kurs = kursy.Find(k => k.Id == id);
            if (kurs != null)
            {
                kursy.Remove(kurs);
            }
        }
    }
}
