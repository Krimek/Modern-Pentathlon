using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPentathlon.Common
{
    public class Enums
    {
        public enum UserType
        {
            Developer,
            Admin,
            Competitor,
            Guest
        }

        public enum CompetitionType
        {
            [Description("Swimming, running, shooting, fencing and riding")]
            PentathlonWithShooting,
            [Description("Swimming, combination, fencing and riding")]
            PentathlonWithCombination,
            [Description("Swimming, running, shooting and fencing")]
            QuadrathlonWithShooting,
            [Description("Swimming, combinationa and fencing")]
            QuadrathlonWithCombination,
            [Description("Swimming, running and shooting")]
            TriathlonWithShooting,
            [Description("Swimming and combination")]
            TriathlonWithCombination,
            [Description("Swimming and running")]
            Biathlon
        }
    }
}
