namespace GTO_Program.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Auth")]
    public partial class Auth
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FIO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Role { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Login { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
