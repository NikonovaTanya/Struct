using System;
using System.Collections.Generic;
using System.Text;

namespace Struct
{
    struct Notebook
    {
        private string model;
        private string manufacture;
        private int price;

        public string Model
        { get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string Manufacture
        {
            get
            {
                return manufacture;
            }
            set
            {
                manufacture = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public Notebook(string m, string manuf, int p)
        {
            this.model = m;
            this.manufacture = manuf;
            this.price = p;
        }
        public void print()
        {
            Console.WriteLine("Модель: "+Model);
            Console.WriteLine("Производитель: " + Manufacture);
            Console.WriteLine("Цена: " + Price);
        }
    }
}
