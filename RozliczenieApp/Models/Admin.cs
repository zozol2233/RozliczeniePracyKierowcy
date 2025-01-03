using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozliczenieApp.Models
{
    namespace RozliczenieApp.Models
    {
        public class Admin : User
        {
            public override string PobierzRole()
            {
                return "Administrator";
            }
        }
    }
}