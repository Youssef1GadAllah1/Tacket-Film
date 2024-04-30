using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youssef_1023073
{
    abstract internal class Person
    {
        protected string Name;
        protected string NameFilm;
        public virtual void SetName(string name)
        {
            Name = name;
        }
        public abstract string GetName();
        public virtual void SetNameFilm(string name)
        {
            Name = name;
        }
        public abstract string GetNameFilm();

    }
}
