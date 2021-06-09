using System;

namespace HeistPartII
{
    public class LockSpecialist : IRobber 
    {
        
        public string Name  { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {

            int SecurityScore = bank.VaultScore - SkillLevel;

            Console.WriteLine($"{Name} is picking the lock");

            if (SecurityScore <= 0)
            {
                Console.WriteLine($"{Name} has successfully entered the vault!");
            }
        }
        public LockSpecialist(string nameInput, int skillLevel, int percentageCut)
        {
            Name = nameInput;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;
        }
    }
}