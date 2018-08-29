using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernPentathlon.DataBaseScheme;

namespace ModernPentathlon.DataAccessLayer
{
    public abstract class BaseRepository
    {
        protected EFContext _context;

        protected BaseRepository()
        {
            _context = new EFContext();
            _context.Database.Log = Console.Write;
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }
    }
}
