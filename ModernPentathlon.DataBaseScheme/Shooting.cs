namespace ModernPentathlon.DataBaseScheme
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shooting")]
    public partial class Shooting
    {
        public int ID { get; set; }

        public int IDCompetitor { get; set; }

        public int IDCompetition { get; set; }

        public int ShootingSeries { get; set; }

        public byte? Shot1 { get; set; }

        public byte? Shot2 { get; set; }

        public byte? Shot3 { get; set; }

        public byte? Shot4 { get; set; }

        public byte? Shot5 { get; set; }

        public byte? Shot6 { get; set; }

        public byte? Shot7 { get; set; }

        public byte? Shot8 { get; set; }

        public byte? Shot9 { get; set; }

        public byte? Shot10 { get; set; }
    }
}
