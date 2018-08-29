using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernPentathlon.Common;
using ModernPentathlon.DataAccessLayer.Interfaces;
using ModernPentathlon.DataBaseScheme;

namespace ModernPentathlon.DataAccessLayer
{
    public class CompetitorRepository : BaseRepository, ISearchCompetitor
    {
        public CompetitorRepository() : base()
        {
        }

        public IEnumerable<Competitor> GetCompetitorBasedOnSex(Enums.Sex sex)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Competitor> GetCompetitorBetweenBirthYear(int year, int finishYear)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Competitor> GetCompetitorFromTeam(string team)
        {
            throw new NotImplementedException();
        }
    }
}
