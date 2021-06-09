using System;
using System.Collections.Generic;
using System.Linq;

namespace HeistPartII
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker hacker1 = new Hacker("Mr. Bob", 50, 30);
            
            Muscle muscle1 = new Muscle("Mr. John", 20, 10);
            
            LockSpecialist picker1 = new LockSpecialist("Mr. Jerry", 25, 25);
            
            Hacker hacker2 = new Hacker("Mrs. Brittany", 70, 40);    

            Muscle muscle2 = new Muscle("Mr. Matt", 30, 20);
        
            LockSpecialist picker2 = new LockSpecialist("Mrs. Libby", 51, 33);

            List<IRobber> rolodex = new List<IRobber>()
            {
                hacker1, hacker2, picker1, picker2, muscle1, muscle2
            };

            // foreach (IRobber robber in rolodex)
            // {
            // Console.WriteLine(robber.Name);
            // }
            Console.WriteLine(rolodex.Count());

            bool hasName = true;
            while (hasName)
            {
            
                Console.Write("Enter crew member name. > ");
                string nameInput = Console.ReadLine();

                if(nameInput == "")
                {
                    hasName = false;
                }
                else
                {
                    Console.Write("Please select a speciality: Hacker (Disables alarms). Muscle (Disarms guards). Lock Specialist (cracks vault). > ");
                    string speciality = Console.ReadLine();

                    Console.Write("Please enter a skill level number between 1 and 100. > ");
                    string robberSkill  = Console.ReadLine();
                    int skillLevel = int.Parse(robberSkill);

                    Console.Write("What percentage of the cut does this crew member receive? > ");
                    string cut = Console.ReadLine();
                    int percentageCut = int.Parse(cut);

                    if (speciality.ToLower() == "hacker")
                    {
                        Hacker Hacker3 = new Hacker(nameInput, skillLevel, percentageCut);
                        rolodex.Add(Hacker3);
                    }
                    if (speciality.ToLower() == "muscle")
                    {
                        Muscle Muscle3 = new Muscle(nameInput, skillLevel, percentageCut);
                        rolodex.Add(Muscle3);
                    }
                    if (speciality.ToLower() == "lock specialist")
                    {
                        LockSpecialist LockSpecialist3 = new LockSpecialist(nameInput, skillLevel, percentageCut);
                        rolodex.Add(LockSpecialist3);
                    }
                }
            }



            







        }
    }
}
