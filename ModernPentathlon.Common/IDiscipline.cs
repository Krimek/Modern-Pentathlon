using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModernPentathlon.Common
{
    public interface IDiscipline
    {
        void AddResult(TimeSpan time, int penalties);
        void AddPenalties(int penalties);
        void UpdatePenalties(int penalties);
        int GetTotal();
        void CalculateTotal();
        object GetDetailedResult();
    }
}
