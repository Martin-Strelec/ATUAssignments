﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureEx1
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }

        public Student()
        {

        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Year: {Year}";
        }

    }
}
