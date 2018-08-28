namespace ModernPentathlon.DataBaseScheme
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Competitor")]
    public partial class Competitor
    {
        public int ID { get; set; }

        public int IDUser { get; set; }

        public bool Sex { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Team { get; set; }

        [Required]
        [StringLength(20)]
        public string License { get; set; }

        public bool HasAccount { get; set; }
    }
}
