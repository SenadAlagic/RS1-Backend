using eRezervacija.Core;
using eRezervacija.Core.Autentikacija;
using Microsoft.EntityFrameworkCore;

namespace eRezervacija.Repository
{
    public class eRezervacijaDbContext : DbContext
    {
        public eRezervacijaDbContext()
        {

        }
        public eRezervacijaDbContext(DbContextOptions<eRezervacijaDbContext> options) : base(options)
        {

        }

        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Gost> Gosti { get; set; }
        public DbSet<Vlasnik> Vlasnici { get; set; }
        public DbSet<Admin> Admini { get; set; }
        public DbSet<AutentifikacijaToken> AutentifikacijaTokeni { get; set; }
        public DbSet<Parking> Parkinzi { get; set; }
        public DbSet<ParkingMjesto> ParkingMjesta { get; set; }
        public DbSet<Hotel> Hoteli { get; set; }
        public DbSet<Soba> Sobe { get; set; }
        public DbSet<Slika> Slike { get; set; }
        public DbSet<SobaDetalji> DetaljiSoba { get; set; }
        public DbSet<HotelDetalji> DetaljiHotela { get; set; }
        public DbSet<PlanOtkazivanja> PlanoviOtkazivanja { get; set; }
        public DbSet<KreditnaKartica> KreditneKartice { get; set; }
        public DbSet<Recenzija> Recenzije { get; set; }
        public DbSet<Rezervacija> Rezervacije { get; set; }
        public DbSet<RezervacijaSoba> RezervacijaSobe { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RezervacijaSoba>().HasKey(t => new { t.RezervacijaID, t.SobaID });
        }
    }
}