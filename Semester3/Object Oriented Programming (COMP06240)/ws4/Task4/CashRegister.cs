using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class CashRegister
    {
        private string _ID;
        private decimal _total;
        private int _numberOfItems;
        static int idCount = 0;

        public decimal Total
        {
            get { return _total; }
        }
        public decimal NumberOfItems
        {
            get { return _numberOfItems; }
        }
        public string ID
        {
            get { return _ID; }
        }

        public CashRegister()
        {
            idCount++;
            _ID = "CR"+idCount;
        }

        public void AddItem(decimal price)
        {
            Console.WriteLine($"Adding an item worth {price:c} to {this._ID}");
            this._total += price;
            this._numberOfItems++;
        }
    }
}
