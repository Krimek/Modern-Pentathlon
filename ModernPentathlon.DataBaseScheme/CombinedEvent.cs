namespace ModernPentathlon.DataBaseScheme
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CombinedEvent")]
    public partial class CombinedEvent
    {
        public int ID { get; set; }

        public int IDCompetitor { get; set; }

        public int IDCompetition { get; set; }

        public TimeSpan RunTime { get; set; }

        public TimeSpan? Shooting1 { get; set; }

        public TimeSpan? Shooting2 { get; set; }

        public TimeSpan? Shooting3 { get; set; }

        public TimeSpan? Shooting4 { get; set; }

        public TimeSpan? Shooting5 { get; set; }
    }
}
