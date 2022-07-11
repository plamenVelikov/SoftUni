using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
                string creator = input[0];
                string teamName = input[1];

                if (teams.Any(team => team.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team();
                    team.Name = teamName;
                    team.Creator = creator;
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string[] inputJoining = Console.ReadLine().Split("->",StringSplitOptions.RemoveEmptyEntries);

            while (inputJoining[0] != "end of assignment")
            {
                string user = inputJoining[0];
                string teamToJoin = inputJoining[1];
                if (teams.Any(team => team.Members.Contains(user)) || teams.Any(creator => creator.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                }
                else if (teams.All(team => team.Name != teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else
                {
                    var currTeam = teams.Find(team => team.Name == teamToJoin);
                    currTeam.Members.Add(user);
                }
                inputJoining = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);
            }
            List<Team> teamsToDisband = teams.Where(x => x.Members.Count == 0).ToList();
            List<Team> orderedTeams = teams.Where(x => x.Members.Count > 0).ToList();

            foreach (var item in orderedTeams.OrderByDescending(team => team.Members.Count).ThenBy(team => team.Name))
            {
                Console.WriteLine(item.Name);
                Console.WriteLine($"- {item.Creator}");
                item.Members.Sort();
                foreach (string v in item.Members)
                {
                    Console.WriteLine($"-- {v}");
                }

            }
            Console.WriteLine("Teams to disband:");
            
                foreach (var item in teamsToDisband.OrderBy(x => x.Name))
                {
                    Console.WriteLine(item.Name);
                }
        }
    }
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
