namespace ModernPentathlon.DataBaseScheme
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoginLog")]
    public partial class LoginLog
    {
        public int ID { get; set; }

        public int IDUser { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(15)]
        public string IP { get; set; }

        public bool IsSuccessful { get; set; }
    }
}
