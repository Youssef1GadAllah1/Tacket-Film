using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youssef_1023073
{
    internal class Ticket
    {
        protected double PriceNormal = 100;

        protected double PriceVIP = 200;

        public double GetPriceFilm()
        {
            return PriceNormal;
        }
        public double GetPriceFilmV()
        {
            return PriceVIP;
        }
    }
}
