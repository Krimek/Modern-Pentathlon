using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPentathlon.Common
{
    public class ExcelFinalResultStructure
    {
        private readonly int _amountOfCompetition;
        public string Name;
        public string Surname;
        public string Team;
        public Swimming Swimming;
        public Running Running;
        public Shooting Shooting;
        public Fencing Fencing;
        public Riding Riding;
        public Combination Combination;

        public ExcelFinalResultStructure()
        {
        }
        public ExcelFinalResultStructure(int amountOfCompetition)
        {
            _amountOfCompetition = amountOfCompetition;
        }

        public int GetAmountOfCompetition()
        {
            return _amountOfCompetition;
        }
    }
}
