using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> listOfTeams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                List<string> input1 = Console.ReadLine().Split("-").ToList();

                Team team = new Team();
                {
                    team.TeamCreator = input1[0];
                    team.TeamName = input1[1];
                    team.TeamMember = new List<string>();
                }
                if (listOfTeams.Any(x => x.TeamName == input1[1]))
                {
                    Console.WriteLine($"Team {input1[1]} was already created!");
                    continue;
                }
                if (listOfTeams.Any(x => x.TeamCreator == input1[0]))
                {
                    Console.WriteLine($"{input1[0]} cannot create another team!");
                    continue;
                }

                Console.WriteLine($"Team {team.TeamName} has been created by {team.TeamCreator}!");

                listOfTeams.Add(team);
            }

            string input2 = Console.ReadLine();

            while (input2 != "end of assignment")
            {
                List<string> command = input2.Split("->").ToList();

                if (!listOfTeams.Any(x => x.TeamName == command[1]))
                {
                    Console.WriteLine($"Team {command[1]} does not exist!");
                    input2 = Console.ReadLine();
                    continue;
                }
                if (listOfTeams.Any(x => x.TeamCreator == command[0]) || listOfTeams.Any(x => x.TeamMember.Any(y => y == command[0])))
                {
                    Console.WriteLine($"Member {command[0]} cannot join team {command[1]}!");
                    input2 = Console.ReadLine();
                    continue;
                }

                Team team = listOfTeams.FirstOrDefault(x => x.TeamName == command[1]);

                team.TeamMember.Add(command[0]);

                input2 = Console.ReadLine();
            }

            List<Team> disbandTeams = listOfTeams.Where(x => x.TeamMember.Count == 0).OrderBy(x => x.TeamName).ToList();
            listOfTeams = listOfTeams.Where(x => x.TeamMember.Count != 0).OrderByDescending(x => x.TeamMember.Count).ThenBy(x => x.TeamName).ToList();

            foreach (Team i in listOfTeams)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team k in disbandTeams)
            {
                Console.WriteLine(k.TeamName);
            }
        }
        public class Team
        {
            public string TeamCreator { set; get; }

            public string TeamName { set; get; }

            public List<string> TeamMember { set; get; }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(TeamName);
                sb.AppendLine($"- {TeamCreator}");

                List<string> orderedMembers = TeamMember.OrderBy(x => x).ToList();

                foreach (string i in orderedMembers)
                {
                    sb.AppendLine($"-- {i}");
                };

                return sb.ToString().TrimEnd('\n');


            }

        }
    }
}
