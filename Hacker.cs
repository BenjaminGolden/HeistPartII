using System;

namespace HeistPartII
{
    public class Hacker : Bank, IRobber 
    
    {
        public string Name  { get; set; }
        public int SkillLevel { get; set; }
        public int Percentagecut { get; set; }

        public void PerformSkill(Bank bank)
        {
            Console.WriteLine($"{Name} is hacking the {action}");

            if (SecurityScore == 0)
            {
                Console.WriteLine($"{Name} has successfully disabled the alarm system!");
            }
        }
    }
}