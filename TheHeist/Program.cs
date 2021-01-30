using System;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!\n");

            double teamSkillLevel = 0;
            string name;
            int bankLevel;
            int runs;
            int i = 0;
            var team = new Team();
            Console.Write("Set bank difficulty: ");
            try
            {
                bankLevel = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.Write("Please enter the bank difficulty as a number: ");
                bankLevel = Convert.ToInt32(Console.ReadLine());
            }
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
            try
            {
                runs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.Write("Please enter the times to run scenario as a number: ");
                runs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            int successCounter = 0;
            int failCounter = 0;
            for (int j = 0; j < runs; j++)
            {
                Random rnd = new Random();
                int luckValue = rnd.Next(-10, 10);

                int difficultyAndLuck = bankLevel + luckValue;
                Console.WriteLine($"Results Scenario {j + 1}:");
                Console.WriteLine($"Bank Difficulty Level: {difficultyAndLuck}");
                Console.WriteLine($"Team Skill Level: {teamSkillLevel}");

                if (teamSkillLevel >= difficultyAndLuck)
                {
                    successCounter++;
                    Console.WriteLine("Success!!! You robbed the bank!\n");
                }
                else
                {
                    failCounter++;
                    Console.WriteLine("You're going to jail...\n");
                }
            }
            Console.WriteLine($"Successful runs {successCounter} out of {runs}");
            Console.WriteLine($"Failed runs {failCounter} out of {runs}");
        }
    }
}
