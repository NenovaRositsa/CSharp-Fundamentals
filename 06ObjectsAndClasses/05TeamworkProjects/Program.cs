using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> listOfTeams = new List<Team>();

            int countTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < countTeams; i++)
            {
                string[] inputArr = Console.ReadLine()
                    .Split('-');
                string userCreator = inputArr[0];
                string nameTeam = inputArr[1];

                Team user = new Team(userCreator, nameTeam);


                if (listOfTeams.Any(x => x.MemberTeam.ContainsValue(nameTeam)))
                {
                    Console.WriteLine($"Team {nameTeam} was already created!");
                }
                else if (listOfTeams.Any(x => x.MemberTeam.ContainsKey(userCreator)))
                {
                    Console.WriteLine($"{userCreator} cannot create another team!");
                }
                else
                {
                    listOfTeams.Add(user);

                    Console.WriteLine($"Team {nameTeam} has been created by {userCreator}!");
                }

            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] splittedInput = input.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string userToJoin = splittedInput[0];
                string teamToJoin = splittedInput[1];

                if (!listOfTeams.Any(x => x.MemberTeam.ContainsValue(teamToJoin)))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exis");
                }
                else if (listOfTeams.Any(x => x.MemberTeam.ContainsKey(userToJoin)))
                {
                    Console.WriteLine($"Member {userToJoin} cannot join team {teamToJoin}!");
                }
                else
                {
                    Team joinedUser = new Team(userToJoin, teamToJoin);
                    listOfTeams.Add(joinedUser);
                }

                input = Console.ReadLine();
            }

            foreach (var item in listOfTeams)
            {
                Console.WriteLine($"{item.MemberTeam.Keys} {item.MemberTeam.Values}");
            }

            
        }
    }

    class Team
    {
        public SortedDictionary<string, string> MemberTeam { get; set; }

        public Team(string user, string nameTeam)
        {
            this.MemberTeam[user] = nameTeam;
        }
    }

}

//using System;
//using System.Collections.Generic;
//using System.Linq;
 
//namespace TeamworkProjects
//{
//    class Team
//    {
//        public string TeamName { get; set; }
//        public string CreatorName { get; set; }
//        public List<string> Members { get; set; }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int teamsCount = int.Parse(Console.ReadLine());
//            List<Team> teams = new List<Team>();
//            for (int i = 0; i < teamsCount; i++)
//            {
//                string[] newTeam = Console.ReadLine().Split('-').ToArray();
//                List<string> membersList = new List<string>();
//                Team team = new Team();
//                team.TeamName = newTeam[1];
//                team.CreatorName = newTeam[0];
//                team.Members = membersList;
//                if (!teams.Select(x => x.TeamName).Contains(team.TeamName))
//                {
//                    if (!teams.Select(x => x.CreatorName).Contains(team.CreatorName))
//                    {
//                        teams.Add(team);
//                        Console.WriteLine("Team {0} has been created by {1}!", newTeam[1], newTeam[0]);
//                    }
//                    else
//                    {
//                        Console.WriteLine("{0} cannot create another team!", team.CreatorName);
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Team {0} was already created!", team.TeamName);
//                }
//            }

//            string teamRegistration = Console.ReadLine();

//            while (!teamRegistration.Equals("end of assignment"))
//            {
//                var split = teamRegistration.Split(new char[] { '-', '>' }).ToArray();
//                string newUser = split[0];
//                string teamName = split[2];
//                if (!teams.Select(x => x.TeamName).Contains(teamName))
//                {
//                    Console.WriteLine("Team {0} does not exist!", teamName);
//                }
//                else if (teams.Select(x => x.Members).Any(x => x.Contains(newUser)) || teams.Select(x => x.CreatorName).Contains(newUser))
//                {
//                    Console.WriteLine("Member {0} cannot join team {1}!", newUser, teamName);
//                }
//                else
//                {
//                    int teamToJoinIndex = teams.FindIndex(x => x.TeamName == teamName);
//                    teams[teamToJoinIndex].Members.Add(newUser);
//                }

//                teamRegistration = Console.ReadLine();
//            }

//            var teamsToDisband = teams.OrderBy(x => x.TeamName).Where(x => x.Members.Count == 0);
//            var fullTeams = teams.
//            OrderByDescending(x => x.Members.Count).
//            ThenBy(x => x.TeamName).
//            Where(x => x.Members.Count > 0);

//            foreach (var team in fullTeams)
//            {
//                Console.WriteLine($"{team.TeamName}");
//                Console.WriteLine($"- {team.CreatorName}");
//                foreach (var member in team.Members.OrderBy(x => x))
//                {
//                    Console.WriteLine($"-- {member}");
//                }
//            }

//            Console.WriteLine("Teams to disband:");
//            foreach (var item in teamsToDisband)
//            {
//                Console.WriteLine(item.TeamName);
//            }

//        }
//    }

//}