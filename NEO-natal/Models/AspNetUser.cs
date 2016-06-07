namespace NEO_natal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetUser
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string Password { get; set; }
    }
}
