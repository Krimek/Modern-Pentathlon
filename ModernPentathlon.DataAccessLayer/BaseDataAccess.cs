using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernPentathlon.DataBaseScheme;

namespace ModernPentathlon.DataAccessLayer
{
    class BaseDataAccess
    {
        private EFContext _context;
        public BaseDataAccess()
        {
            _context = new EFContext();
        }
    }
}
