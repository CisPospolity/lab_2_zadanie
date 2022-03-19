using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie
{
    class Product : IThing
    {
        private string name;

        public string Name
        {
            get => name;
            set { name = value; }
        }

        public Product(string name)
        {
            Name = name;
        }

        public string Print(string prefix)
        {
            return prefix + "Product's name: " + Name;
        }
    }

}
