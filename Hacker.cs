using System;

namespace HeistPartII
{
    public class Hacker : IRobber 
    
    {
        public string Name  { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int SecurityScore = bank.AlarmScore - SkillLevel;

            Console.WriteLine($"{Name} is hacking the alarm system");

            if (SecurityScore <= 0)
            {
                Console.WriteLine($"{Name} has successfully disabled the alarm system!");
            }
        }

        public Hacker(string nameInput, int skillLevel, int percentageCut)
        {
            Name = nameInput;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;
        }
    }
}