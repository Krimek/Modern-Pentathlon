using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernPentathlon.DataBaseScheme;

namespace ModernPentathlon.DataAccessLayer.Interfaces
{
    interface ISearchUsers
    {
        IEnumerable<UsersDetails> GetAllUsers();
        IEnumerable<UsersDetails> GetUsersById(int id);
        IEnumerable<UsersDetails> GetUsersByNameAndSurname(string name, string surname);
        
    }
}
