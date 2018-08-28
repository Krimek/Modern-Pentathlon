namespace ModernPentathlon.DataBaseScheme
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Competition")]
    public partial class Competition
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        [Required]
        [StringLength(21)]
        public string Date { get; set; }

        public bool Swimming { get; set; }

        public bool Running { get; set; }

        public bool Shooting { get; set; }

        public bool Fencing { get; set; }

        public bool Riding { get; set; }

        public bool CombinationEvent { get; set; }

        public int NumberOfSwimmingTracks { get; set; }

        public int NumberOfRunningTracks { get; set; }

        public int NumberOfShootingPositions { get; set; }

        public int OwnerID { get; set; }
    }
}
