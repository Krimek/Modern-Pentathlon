namespace ModernPentathlon.DataBaseScheme
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFContext : DbContext
    {
        public EFContext()
            : base("name=EFContext")
        {
        }

        public virtual DbSet<AdminOfCompetition> AdminOfCompetition { get; set; }
        public virtual DbSet<CombinedEvent> CombinedEvent { get; set; }
        public virtual DbSet<Competition> Competition { get; set; }
        public virtual DbSet<CompetitionResult> CompetitionResult { get; set; }
        public virtual DbSet<Competitor> Competitor { get; set; }
        public virtual DbSet<LoginLog> LoginLog { get; set; }
        public virtual DbSet<Shooting> Shooting { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersDetails> UsersDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competition>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Competition>()
                .Property(e => e.Location)
                .IsFixedLength();

            modelBuilder.Entity<Competition>()
                .Property(e => e.Date)
                .IsFixedLength();

            modelBuilder.Entity<Competitor>()
                .Property(e => e.Team)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Competitor>()
                .Property(e => e.License)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoginLog>()
                .Property(e => e.IP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Login)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<UsersDetails>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<UsersDetails>()
                .Property(e => e.Surname)
                .IsFixedLength();

            modelBuilder.Entity<UsersDetails>()
                .Property(e => e.Email)
                .IsFixedLength();
        }
    }
}
