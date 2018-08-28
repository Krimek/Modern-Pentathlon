namespace ModernPentathlon.DataBaseScheme
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UsersDetails
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public DateTime? LastSuccessfulLogin { get; set; }

        public DateTime? LastUnsuccessfulLogin { get; set; }

        public DateTime? CrationDate { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsCompetitor { get; set; }

        public bool IsDeveloper { get; set; }
    }
}
