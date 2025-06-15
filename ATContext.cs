using AT.Models;
using Microsoft.EntityFrameworkCore;

namespace AT.Data
{
    public class ATContext : DbContext
    {
        public ATContext(DbContextOptions<ATContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<PacoteTuristico> PacotesTuristicos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<PacoteDestino> PacoteDestinos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<PacoteDestino>()
                .HasKey(pd => new { pd.PacoteTuristicoId, pd.DestinoId });


            modelBuilder.Entity<PacoteDestino>()
                .HasOne(pd => pd.PacoteTuristico)
                .WithMany(p => p.PacoteDestinos)
                .HasForeignKey(pd => pd.PacoteTuristicoId);


            modelBuilder.Entity<PacoteDestino>()
                .HasOne(pd => pd.Destino)
                .WithMany(d => d.PacoteDestinos)
                .HasForeignKey(pd => pd.DestinoId);


            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Cliente)
                .WithMany(c => c.Reservas)
                .HasForeignKey(r => r.ClienteId);

            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.PacoteTuristico)
                .WithMany(p => p.Reservas)
                .HasForeignKey(r => r.PacoteTuristicoId);

            modelBuilder.Entity<Reserva>()
                .HasIndex(r => new { r.ClienteId, r.PacoteTuristicoId, r.DataReserva })
                .IsUnique();
        }
    }
}
