using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class ComputerGames : Game
    {
        private protected decimal Price;

        //Task5
        public ComputerGames(string name, decimal price, DateTime releaseDate) : base(name, price, releaseDate) 
        {

        }
        public ComputerGames(string name, decimal price) : base(name, price, DateTime.Now)
        {

        }
        public ComputerGames() : base("", 0)
        {

        }
        public decimal GetDiscountPrice()
        {
            return Price * 9m;
        }
        public override void UpdatePrice(decimal percentageIncrease)
        {
            Price *= (1 + percentageIncrease);
            Console.WriteLine("Updating from the ComputerGames class!");
        }
    }
}
