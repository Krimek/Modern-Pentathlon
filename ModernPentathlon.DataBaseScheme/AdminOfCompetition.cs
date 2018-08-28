namespace ModernPentathlon.DataBaseScheme
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdminOfCompetition")]
    public partial class AdminOfCompetition
    {
        public int ID { get; set; }

        public int IDCompetition { get; set; }

        public int IDUser { get; set; }

        public int AddedBy { get; set; }

        public DateTime AddedDate { get; set; }
    }
}
