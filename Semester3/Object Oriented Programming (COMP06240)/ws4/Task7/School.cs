using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class School : IComparable<School>
    {
        public string SchoolName { get; private set; }
        public int NumberOfStudents { get; private set; }

        public School(string schoolName, int numberOfStudents)
        {
            this.SchoolName = schoolName;
            this.NumberOfStudents = numberOfStudents;
        }

        public int CompareTo(School other)
        {
            if (object.ReferenceEquals(other,null)) return 1;

            return NumberOfStudents.CompareTo(other.NumberOfStudents);
        }
    }
}
