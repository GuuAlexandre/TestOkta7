using Microsoft.EntityFrameworkCore;
using TestOkta7.Authentication;

namespace TestOkta7.Data
{
    public class TestOkta7Context : DbContext
    {
        public TestOkta7Context(DbContextOptions<TestOkta7Context> options) : base(options)
        {


        }

        public TestOkta7Context()
        {


        }

        public DbSet<User> User { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Server=rubik.cqxvbrhqbcwv.us-east-1.rds.amazonaws.com;Database=Atgp;User Id=atgpdev;Password=!4TGP@WSXcde3!";

            optionsBuilder.UseSqlServer(conn);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("FK_100");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            //OnModelCreatingPartial(modelBuilder);
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
