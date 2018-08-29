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
        IEnumerable<Competitor> GetCompetitorFromYear(int year); 
        IEnumerable<Competitor> GetCompetitorFromTeam(string team);
    }
}
