using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozliczenieApp.Models
{
    public class Driver : Uzytkownik
    {
        public string LicensePlate { get; set; }
        public string JobType { get; set; }

        public Driver(string firstName, string lastName, string username, string password, string licensePlate, string jobType)
            : base(firstName, lastName, username, password)
        {
            LicensePlate = licensePlate;
            JobType = jobType;
        }
    }
}