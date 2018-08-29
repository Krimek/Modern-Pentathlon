using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernPentathlon.DataBaseScheme;

namespace ModernPentathlon.DataAccessLayer.Interfaces
{
    interface ISearchCompetitor
    {
        IEnumerable<Competitor> GetCompetitorBasedOnSex(Common.Enums.Sex sex);
        IEnumerable<Competitor> GetCompetitorBetweenBirthYear(int startYear, int finishYear); 
        IEnumerable<Competitor> GetCompetitorFromTeam(string team);
    }
}
