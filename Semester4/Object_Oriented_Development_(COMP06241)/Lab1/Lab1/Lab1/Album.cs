using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Album : IComparable<Album>
    {
        #region Attributes
        public string Name { get; set; }
        public DateTime Released { get; set; }
        public int Sales { get; set; }
        #endregion
        #region Constructors
        public Album(string name, string released, int sales)
        {
            this.Name = name;
            this.Released = DateTime.Parse(released);
            this.Sales = sales; 
        }
        #endregion
        #region Public Methods
        public int CompareTo(Album other)
        {
            return this.Released.CompareTo(other.Released);
        }
        public override string ToString()
        {
            return $"{Name} - {DateTime.Now.Year - Released.Year} years ago";
        }
        #endregion
    }
}
