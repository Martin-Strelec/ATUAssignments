using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class Band : IComparable<Band>
    {
        #region Attributes
        public string Name { get; set; }
        public DateTime YearFormed { get; set; }
        public List<Album> Albums { get; set; }
        public string[] Members { get; set; }
        #endregion
        #region Constructors
        public Band()
        {

        }

        public Band(string name, string yearFormed, string[] members, List<Album> albums)
        {
            Name = name;
            YearFormed = DateTime.Parse(yearFormed);
            Members = members;
            Albums = albums;
            
            Albums.Sort(); //Sorting albums By their release date
            Albums.Reverse(); //Reversing the order so that the most recent album is on top
        }
        #endregion
        #region Public Methods
        public int CompareTo(Band other)
        {
            return this.Name.CompareTo(other.Name);
        }
        public override string ToString()
        {
            return $"{Name}";
        }
        #endregion
    }
}
