namespace ModernPentathlon.DataBaseScheme
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompetitionResult")]
    public partial class CompetitionResult
    {
        public int ID { get; set; }

        public int IDCompetitor { get; set; }

        public int IDCompetition { get; set; }

        public TimeSpan Time { get; set; }

        public int Penalties { get; set; }

        public int Score { get; set; }

        public int TypeOfCompetition { get; set; }
    }
}
