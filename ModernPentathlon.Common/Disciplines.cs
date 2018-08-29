using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPentathlon.Common
{
    public abstract class Discipline : IDiscipline
    {
        public static TimeSpan Time;
        public static int Penalties;
        public static int Total;

        public void AddResult(TimeSpan time, int penalties)
        {
            Time = time;
            Penalties = penalties;
            CalculateTotal();
        }

        public void AddPenalties(int penalties)
        {
            Penalties = penalties;
            CalculateTotal();
        }

        public void UpdatePenalties(int penalties)
        {
            Penalties = penalties;
            CalculateTotal();
        }

        public int GetTotal()
        {
            return Total;
        }

        public abstract void CalculateTotal();
        public abstract object GetDetailedResult();
    }

    public class Swimming : Discipline
    {
        public override void CalculateTotal()
        {
            throw new NotImplementedException();
        }

        public override object GetDetailedResult()
        {
            throw new NotImplementedException();
        }
    }

    public class Running : Discipline
    {
        public override void CalculateTotal()
        {
            throw new NotImplementedException();
        }

        public override object GetDetailedResult()
        {
            throw new NotImplementedException();
        }
    }

    public class Shooting : Discipline
    {
        private readonly int _numberOfShootingSeries;
        private readonly int _numberOfShotInSeries;
        private List<ShootingSeries> _shootingSeries;
        public Shooting(int numberOfShootingSeries, int numberOfShotInSeries)
        {
            _numberOfShootingSeries = numberOfShootingSeries;
            _numberOfShotInSeries = numberOfShotInSeries;
            _shootingSeries = new List<ShootingSeries>(_numberOfShootingSeries);
        }

        public void AddShot(int series, int numberOfShot, int value)
        {
            if (_shootingSeries[series] == null)
            {
                _shootingSeries[series] = new ShootingSeries(_numberOfShotInSeries);
            }

            _shootingSeries[series].AddShot(value, numberOfShot);
        }

        public void UpdateShot(int series, int numberOfShot, int value)
        {
            throw new NotImplementedException();
        }

        public override void CalculateTotal()
        {
            throw new NotImplementedException();
        }

        public override object GetDetailedResult()
        {
            throw new NotImplementedException();
        }
    }

    public class Fencing : Discipline
    {
        public override void CalculateTotal()
        {
            throw new NotImplementedException();
        }

        public override object GetDetailedResult()
        {
            throw new NotImplementedException();
        }
    }

    public class Riding : Discipline
    {
        public override void CalculateTotal()
        {
            throw new NotImplementedException();
        }

        public override object GetDetailedResult()
        {
            throw new NotImplementedException();
        }
    }

    public class Combination : Discipline
    {
        public override void CalculateTotal()
        {
            throw new NotImplementedException();
        }

        public override object GetDetailedResult()
        {
            throw new NotImplementedException();
        }
    }

    internal class ShootingSeries
    {
        private List<int> _shots;

        public ShootingSeries(int numberOfShots)
        {
            _shots = new List<int>(numberOfShots);
        }

        public void AddShot(int value, int numberOfShot)
        {
            if (numberOfShot < _shots.Capacity)
            {
                _shots.Add(value);
            }
        }

        public int Count()
        {
            return _shots.Count;
        }

        public List<int> GetValues()
        {
            return new List<int>(_shots);
        }

        public int GetTotal()
        {
            return _shots.Sum();
        }
    }
}
