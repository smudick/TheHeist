using System;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            double teamSkillLevel = 0;
            string name;
            int i = 0;
            var team = new Team();
            Console.Write("Set bank difficulty: ");
            int bankLevel = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Enter a team member's name: ");
                name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                else
                {
                    var teamMember = new TeamMember(name);
                    team.AddTeamMembers(teamMember);
                    teamMember.CreateTeammate(name);
                    teamSkillLevel += teamMember.SkillLevel;
                    i++;

                }

            } while (name != "");

            Console.Write("How many times would you like to run this scenario? ");
            int runs = Convert.ToInt32(Console.ReadLine());
            int successCounter = 0;
            int failCounter = 0;
            for (int j = 0; j < runs; j++)
            {
                Random rnd = new Random();
                int luckValue = rnd.Next(-10, 10);

                int difficultyAndLuck = bankLevel + luckValue;

                if (teamSkillLevel >= difficultyAndLuck)
                {
                    successCounter++;
                }
                else
                {
                    failCounter++;
                }
            }
            Console.WriteLine($"Successful runs {successCounter} out of {runs}");
            Console.WriteLine($"Failed runs {failCounter} out of {runs}");
        }
    }
}
