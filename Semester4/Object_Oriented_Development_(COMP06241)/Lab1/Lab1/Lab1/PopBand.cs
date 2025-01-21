using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class PopBand : Band
    {
        #region Constructors
        public PopBand(string name, string yearFormed, string[] members, List<Album> albums) : base(name, yearFormed, members, albums) { }
        #endregion
        #region Public Methods
        public override string ToString()
        {
            return $"Pop - {Name}";
        }
        #endregion
    }
}
