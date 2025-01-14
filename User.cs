using System;

namespace RozliczenieApp.Models
{
    public class Uzytkownik
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Uzytkownik(string firstName, string lastName, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
                 }
        /// <summary>
        /// Wyświetla podstawowe menu dla użytkownika.
        /// </summary>
        public virtual void WyswietlMenu()
        {
            Console.WriteLine("Dostępne funkcje:");
            Console.WriteLine("1. Wyloguj");
        }
    }
}
