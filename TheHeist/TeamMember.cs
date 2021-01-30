using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class TeamMember
    {
        public string Name { get; set; }
        public double SkillLevel { get; set; }
        public double CourageFactor { get; set; }

        public static int Count = 0;

        public TeamMember(string name)
        {
            Name = name;
            Count++;
        }

        public void CreateTeammate(string name)
        {
            Console.Write($"Enter {name}'s skill level: ");
            try
            {
            SkillLevel = Math.Round(Convert.ToDouble(Console.ReadLine()));
            }
            catch (FormatException)
            {
                Console.Write("Please enter the skill level as a number: ");
                SkillLevel = Math.Round(Convert.ToDouble(Console.ReadLine()));
            }
            Console.Write($"Enter {name}'s courage level as a decimal between 0 and 2: ");
            try
            {
            CourageFactor = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("Please enter the Courage level as a number between 0 and 2: ");
                CourageFactor = Convert.ToDouble(Console.ReadLine());
            }
            if (CourageFactor < 0 )
            {
                CourageFactor = 0;
            }
            else if (CourageFactor > 2)
            {
                CourageFactor = 2;

            }
            Count++;
        }
        public void Display()
        {
            Console.WriteLine($"Team Member: {Name}");
            Console.WriteLine($"Skill Level: {SkillLevel}");
            Console.WriteLine($"Courage Factor: {CourageFactor}");
        }
    }
}
