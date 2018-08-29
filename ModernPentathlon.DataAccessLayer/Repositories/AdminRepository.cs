using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernPentathlon.DataAccessLayer.Interfaces;
using ModernPentathlon.DataBaseScheme;

namespace ModernPentathlon.DataAccessLayer
{
    class AdminRepository : BaseRepository, IAdminRepository
    {
        public AdminRepository() : base()
        {
            
        }

        public IEnumerable<UsersDetails> GetUserWithUnsuccessfulLogin()
        {
            var result = _context.UsersDetails.Where(x => x.LastUnsuccessfulLogin != null).ToList();
            return result;
        }

        public IEnumerable<UsersDetails> GetUserWithUnsuccessfulLoginFrom(int year, int month, int week, int day, int hours, int minutes)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfUnsuccessfulLogin(int userId)
        {
            throw new NotImplementedException();
        }

        public UsersDetails GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public UsersDetails GetUserByNameAndSurname(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
