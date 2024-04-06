using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Person
    {
        public int Id { get; set; }
        public int _id;
        public Person()
        {
            _id++;
            Id = _id;
        }
        public string Fullname { get; set; }

        public sbyte _age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0 || value < 125)
                    _age = value;
            }
        }
        public double Cash { get; set; }
        public Person(string fullname, sbyte age, double cash)
        {
            Fullname = fullname;
            _age = age;
            Cash = cash;
        }
        public override string ToString()
        {
            return($"Person-Id;{Id}, Fullname:{Fullname}, Cash:{Cash}, _age:{_age}");
        }
    }
}
