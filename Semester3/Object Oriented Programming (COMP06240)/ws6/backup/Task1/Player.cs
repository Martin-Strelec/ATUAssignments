using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace task1
{
    internal class Player
    {
        public string Name { get; private set; }
        public string Position { get; private set; }
        public Player(string name, string position)
        {
            this.Name = name;
            this.Position = position;
        }
    }
}