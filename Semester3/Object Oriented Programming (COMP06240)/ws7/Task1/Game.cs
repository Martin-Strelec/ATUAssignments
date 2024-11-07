using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Game
    {
        //Task2
        public readonly string Name;
        //Task4
        private protected decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        
        //Task1
        public Game (string name, decimal price, DateTime releaseDate)
        {
            this.Name = name;
            this.ReleaseDate = releaseDate;
            this.Price = price;
        }
        public Game(string name, decimal price) : this(name, price, DateTime.Now)
        {

        }
        public Game() : this("", 0)
        {

        }
        //Task 6,8
        public abstract void UpdatePrice(decimal percentageIncrease);
        public override string ToString()
        {
            return $"Name: {Name}"+$" Price: {Price:c}"+$" ReleaseDate: {ReleaseDate}";
        }

    }
}
