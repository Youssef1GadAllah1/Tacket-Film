using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Youssef_1023073
{
    internal class VIPUser : Person
    {
        public override void SetName(string name)
        {
            Name = name;
        }
        public override string GetName()
        {
            return Name;
        }
        public override void SetNameFilm(string name)
        {
            NameFilm = name;
        }
        public override string GetNameFilm()
        {
            return NameFilm;
        }

    }
}
