namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Diagnostics.Metrics;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            InitializeTeams(teams);

            JoinTeams(teams);

            PrintValidTeams(teams);

            PrintDisbandTeams(teams);
        }
        static void PrintDisbandTeams(List<Team> teams)
        {
            List<Team> teamsToDisband = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.Name)
                .ToList();
            Console.WriteLine($"Teams to disband:");
            foreach (Team disbandTeam in teamsToDisband)
            {
                Console.WriteLine($"{disbandTeam.Name}");
            }
        }
        static void PrintValidTeams(List<Team> teams)
        {
            List<Team> teamsWithMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name)
                .ToList();

            foreach (Team team in teamsWithMembers)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                foreach (string member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
        static void JoinTeams (List<Team> teams)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] cmdArgs = command
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string user = cmdArgs[0];
                string teamName = cmdArgs[1];

                if (!TeamExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (AlreadyAMemberOfATeam(teams, user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team teamToJoin = teams
                        .First(x => x.Name == teamName);
                    teamToJoin.AddMember(user);

                }
            }
        }
        static bool AlreadyAMemberOfATeam (List<Team> teams, string user)
        {
            return teams.Any(x => x.Members.Contains(user)) ||
                teams.Any(x => x.Creator == user);
        }
        static void InitializeTeams(List<Team> teams)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] teamArgs = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                string creator = teamArgs[0];
                string teamName = teamArgs[1];

                if (TeamExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (AlreadyCreatorATeam(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team newTeam = new Team(teamName, creator);
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
        }
        static bool TeamExists(List<Team> teams, string teamName)
        {
            return teams.Any(x => x.Name == teamName);
        }
        static bool AlreadyCreatorATeam(List<Team> teams, string creator)
        {
            return teams.Any(x => x.Creator == creator);
        }
    }
    public class Team
    {
        private readonly List<string> members;

        public Team(string name, string creator)
        {
            this.members = new List<string>();
            Name = name;
            Creator = creator;
        }

        public string Name { get; private set; }
        public string Creator { get; private set; }
        public List<string> Members
            => this.members;
        public void AddMember(string memberName)
        {
            this.members.Add(memberName);
        }
    }
}