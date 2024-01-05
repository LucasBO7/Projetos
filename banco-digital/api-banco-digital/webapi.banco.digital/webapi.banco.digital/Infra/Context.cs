using Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using webapi.banco.digital.Domains;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace webapi.banco.digital.Infra
{
    public class Context : DbContext
    {
        public Context() { }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-84UMQCT\\SQLEXPRESS; initial catalog = digital_bank; User Id=sa; Password=Senai@134; TrustServerCertificate=True");
            }
        }

        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
    }
}