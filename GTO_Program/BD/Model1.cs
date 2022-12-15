using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GTO_Program.BD
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model13")
        {
        }

        public virtual DbSet<Auth> Auth { get; set; }
        public virtual DbSet<StydentsData> StydentsData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auth>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Auth>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<Auth>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Auth>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.NumberGroup)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.Подтягивания)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.Брусья)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.Бег30М)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.Бег60М)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.Бег100М)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.Бег2000М)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.Отжимания)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.Прыжок_с_места)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.Прыжок_С_Разбега)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.Пресс)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.Гиря)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.Наклоны_на_гибкость)
                .IsUnicode(false);

            modelBuilder.Entity<StydentsData>()
                .Property(e => e.YearGroup)
                .IsUnicode(false);
        }
    }
}
