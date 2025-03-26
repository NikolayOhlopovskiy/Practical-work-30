using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Newspaper : PrintedProducts
    {
        private int carculation;
        private double price;
        public Newspaper() { }
        public Newspaper(string name, int carculation, double price) :
            base(name)
        { Carculation = carculation; Price = price; }

        public int Carculation { get; }
        public double Price { get; }

        public override double Cost()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}