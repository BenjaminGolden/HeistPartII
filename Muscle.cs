using System;

namespace HeistPartII
{
    public class Muscle : IRobber 
    {
        
        public string Name  { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int SecurityScore = bank.SecurityGuardScore - SkillLevel;

            Console.WriteLine($"{Name} is fighting the security guard");

            if (SecurityScore <= 0)
            {
                Console.WriteLine($"{Name} has successfully beat up the security guard!");
            }
        }
        public Muscle(string nameInput, int skillLevel, int percentageCut)
        {
            Name = nameInput;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;
        }
    }
}