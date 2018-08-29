using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernPentathlon.DataAccessLayer.Interfaces;
using ModernPentathlon.DataBaseScheme;

namespace ModernPentathlon.DataAccessLayer
{
    class UserRepository :BaseRepository, ISearchUsers
    {
        public UserRepository() : base()
        {

        }

        public IEnumerable<UsersDetails> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsersDetails> GetUsersById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsersDetails> GetUsersByNameAndSurname(string name, string surname)
        {
            throw new NotImplementedException();
        }
    }
}
