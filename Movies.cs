using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Youssef_1023073
{
    internal class Movies : Ticket
    {
        protected string Name;
       

        public void SetNameFilm(string name)
        {
            Name = name;
        }

        public string GetNameFilm()
        {
            return Name;
        }
       
    }
}
