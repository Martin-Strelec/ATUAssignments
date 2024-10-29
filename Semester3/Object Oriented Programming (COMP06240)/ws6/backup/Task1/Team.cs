using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace task1
{
    internal class Team : IComparable<Team>
    {
        public string Name { get; private set; }
        public List<Player> Players { get; set; }
        public int NoOfWins { get; private set; }
        public int NoOfDraws { get; private set; }
        public int NoOfLosses { get; private set; }
        public int NoOfGames { get; private set; }
        private int points;
        public enum Result
        {
            Win,
            Draw,
            Loss
        }
        public int Points
        {
            get
            {
                points = (NoOfWins * 3) + NoOfDraws;
                return points;
            }
        }
        public Team(string name)
        {
            this.Name = name;
            this.Players = new List<Player>();
        }
        public int CompareTo(Team other)
        {
            if (object.ReferenceEquals(other, null)) return 1;
            return Points.CompareTo(other.Points);
        }
        public string DisplayTeamTable()
        {
            return string.Format($"{Name,-15}{Points,-7}{NoOfWins,-7}{NoOfDraws,-7}{NoOfLosses,-7}{NoOfGames,-7}");
        }
        public void AddResult(Result status)
        {
            switch (status)
            {
                case Result.Win:
                    NoOfWins++;
                    NoOfGames++;
                    break;
                case Result.Draw:
                    NoOfDraws++;
                    NoOfGames++;
                    break;
                case Result.Loss:
                    NoOfLosses++;
                    NoOfGames++;
                    break;
            }
        }
    }
}