using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace Ex2
{
    internal class Member
    {
        public string MemberName { get; set; }
        public enum MemberShipTypeE
        {
            Full,
            Student,
            OffPeak,
            OAP,
            None
        }
        public MemberShipTypeE Membership { get; set; }
        public string DateJoined { get; set; }
        private static readonly Random rng = new Random();
        public Member()
        {
            RandomizeDate();
        }

        public override string ToString()
        {
            return $"{MemberName}, {Membership}, {DateJoined}";
        }

        public void RandomizeDate()
        {
            DateTime temp = DateTime.Now;
            temp = temp.AddYears(rng.Next(-24, -10))
                       .AddDays(rng.Next(-31,1))
                       .AddMonths(rng.Next(-12,1));
            DateJoined = temp.ToString("dd/MM/yyyy");
        }
    }
}
