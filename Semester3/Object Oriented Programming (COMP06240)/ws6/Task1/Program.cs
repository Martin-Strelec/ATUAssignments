/*
 * SligoRovers.Players.Add(new Player("Ed Mcgity", "Goalkeeper"));
 * Name: task1,2,3
 * Author: M.Strelec
 * Date: 10/28/24
 * Purpose: Creating a class - Team
 */

using static task1.Team;
using System.Linq;
using task1;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command
            //Declaration
            List<Team> teams = new List<Team>(); //List of Team objects
            string[] NamesOfTeams = { "Sligo Rovers", "Finn Harps", "Galway United", "Derry City", "Dundalk" }; //Names of the teams

            //Creating Team objetcs based on their name
            foreach (string name in NamesOfTeams)
            {
                teams.Add(new Team(name));
            }
            //Input
            Console.WriteLine("Teams");
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Using a jagged array for writing down the resuts of the matches
            string[][] results = {
                new string[] {NamesOfTeams[0], "Win" },
                new string[] {NamesOfTeams[1], "Loss","Draw",},
                new string[] {NamesOfTeams[2], "Win"},
                new string[] {NamesOfTeams[3], "Draw"},
                new string[] {NamesOfTeams[4], "Loss"},
            };
            // Passing enum values to the Team object
            for (int i = 0; i < NamesOfTeams.Length; i++)
            {
                int identifier = teams.FindIndex(a => a.Name.Contains(NamesOfTeams[i]));
                for (int j = 1; j < results[i].GetLength(0); j++)
                {
                    if (Enum.TryParse(results[i][j], out Result status))
                    {
                        teams[identifier].AddResult(status);
                    }
                }
            }
            //Adding players to SligoRovers
            int index = teams.FindIndex(a => a.Name.Contains("Sligo Rovers")); //Find the index of an team object with this exact name property
            teams[index].Players.Add(new Player("Ed Mcgity", "Goalkeeper"));
            teams[index].Players.Add(new Player("John Mahon", "Defender"));
            teams[index].Players.Add(new Player("Ronan Coughlan", "Forward"));
            teams.Sort(); //Sorting List           
            teams.Reverse();  //Reversing List 
            
            //Output

            DisplayTeams(teams); //Display Teams
            index = teams.FindIndex(a => a.Name.Contains("Sligo Rovers")); //Find the index of an team object with this exact name property *Used again because the reverse function was used

            DisplayTeamMembers(teams[index], teams[index].Players);
            Console.WriteLine("\n******End of program******\n");
        }
        static void DisplayTeams(List<Team> teams)
        {
            const string OUTPUT_TAB = "{0,-15}{1,-7}{2,-7}{3,-7}{4,-7}{5,-7}";
            Console.WriteLine(OUTPUT_TAB, "NAME", "POINTS", "WINS", "DRAWS", "LOSSES", "PLAYED");
            foreach (Team team in teams)
            {
                Console.WriteLine(team.DisplayTeamTable());
            }
        }
        static void DisplayTeamMembers(Team team, List<Player> players)
        {
            Console.WriteLine($"\n{team.Name} Teamsheet");
            foreach (Player player in players)
            {
                Console.WriteLine($"{player.Name} - {player.Position}");
            }
        }
    }
}