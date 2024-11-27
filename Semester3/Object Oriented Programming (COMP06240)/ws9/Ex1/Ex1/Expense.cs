using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Expense
    {
        public CategoryAllowedTypes Category { get; set; }
        public decimal Cost { get; set; }
        public DateTime DateIncurred { get; set; }
        public enum CategoryAllowedTypes
        {
            Travel, 
            Office, 
            Entertainment
        };

        private static readonly Random rng = new Random();

        public Expense()
        {
            DateTime now = DateTime.Now;
            this.DateIncurred = now;
            RandomizeDate();
            RandomizeCost();
            RandomizeCategory();
        }

        public override string ToString()
        {
            return $"{Category} {Cost:c} on {DateIncurred}";
        }

        public void RandomizeDate()
        {
            this.DateIncurred = this.DateIncurred
                .AddHours(rng.Next(-48, 1))
                .AddDays(rng.Next(-30, 1))
                .AddMinutes(rng.Next(-120, 1));
        }

        public void RandomizeCost()
        {
            this.Cost = rng.Next(100, 251);
        }
        public void RandomizeCategory()
        {
            var categories = Enum.GetValues(typeof(CategoryAllowedTypes));
            this.Category = (CategoryAllowedTypes)categories.GetValue(rng.Next(categories.Length));
        }
    }
}
