using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozliczenieApp.Models
{
    namespace RozliczenieApp.Models
    {
        public class User
        {
            public string Nazwa { get; set; } // login
            public string Haslo { get; set; } // haslo

            public virtual string PobierzRole()
            {
                return "Użytkownik";
            }
        }
    }
}
