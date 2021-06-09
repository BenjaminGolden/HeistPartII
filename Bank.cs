using System;
using System.Collections.Generic;
using System.Linq;


namespace HeistPartII
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public List<int> SecurityScore { get; set; }

        public bool IsSecure { get; set; }

        public Bank()
        {
            SecurityScore = new List<int>();
        }

        
    }
}