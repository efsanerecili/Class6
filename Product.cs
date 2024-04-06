using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Product
    {
        private int _no;
        public int No { get; set; }
        public string Name { get; set; }

        public Product() 
        {
            _no++;
            No=_no;
        }

        private double _price;
            public double Price 
        {
            get{  return _price; }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else 
                {
                    Console.WriteLine("0 ve 0 dan boyuk beraber olmalidir");
                }


            }
        }
        public string Type { get; set; }
        public int Count { get; set; }
       
        public Product(string name, decimal price, string type, int count)
        {
            Name = name;
            Type = type;
            Count = count;
        }

        public  override string ToString()
        {
           return($"Product-No;{No}, Name:{Name}, Price:{_price}, Type:{Type},Count:{Count}");
        }
            














    }
}
