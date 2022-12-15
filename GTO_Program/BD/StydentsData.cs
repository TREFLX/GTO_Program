namespace GTO_Program.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StydentsData")]
    public partial class StydentsData
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NumberGroup { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string FIO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Подтягивания { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Брусья { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Бег30М { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Бег60М { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Бег100М { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string Бег2000М { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string Отжимания { get; set; }

        [Key]
        [Column("Прыжок с места", Order = 10)]
        [StringLength(50)]
        public string Прыжок_с_места { get; set; }

        [Key]
        [Column("Прыжок С Разбега", Order = 11)]
        [StringLength(50)]
        public string Прыжок_С_Разбега { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string Пресс { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string Гиря { get; set; }

        [Key]
        [Column("Наклоны на гибкость", Order = 14)]
        [StringLength(50)]
        public string Наклоны_на_гибкость { get; set; }

        [StringLength(50)]
        public string YearGroup { get; set; }
    }
}
