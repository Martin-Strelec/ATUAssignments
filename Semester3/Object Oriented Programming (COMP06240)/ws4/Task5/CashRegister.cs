using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class CashRegister
    {
        public string ID { get; }
        public decimal TotalForUnit { get; private set; }
        public int NumberOfItemsUnit { get; private set; }
        public static decimal TotalForAll { get; private set; }
        public static int NumberOfItemsAll { get; private set; }

        public static int _idCount = 0;

        public CashRegister()
        {
            _idCount++;
            ID = "CR" + _idCount;
        }

        public void AddItem(decimal price)
        {
            Console.WriteLine($"Adding an item worth {price:c} to {this.ID}");

            //Adding for Unit
            TotalForUnit += price;
            NumberOfItemsUnit++;

            //Adding to Total
            TotalForAll += price;
            NumberOfItemsAll++;
        }
    }
}
