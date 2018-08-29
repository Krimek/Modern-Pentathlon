using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernPentathlon.DataBaseScheme;

namespace ModernPentathlon.DataAccessLayer.Interfaces
{
    interface IAdminRepository
    {
        IEnumerable<UsersDetails> GetUserWithUnsuccessfulLogin();
        IEnumerable<UsersDetails> GetUserWithUnsuccessfulLoginFrom(int year, int month, int week, int day, int hours, int minutes);
        int GetNumberOfUnsuccessfulLogin(int userId);
        UsersDetails GetUserById(int userId);
        UsersDetails GetUserByNameAndSurname(int userId);

    }
}
