namespace Chinook.Entities.Base
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppDataModel : DbContext
    {
        public AppDataModel()
            : base("name=cnxAppDatModel")
        {
            // Desabilitando el LazyLoading de entity framework.
            this.Configuration.LazyLoadingEnabled = false;

            this.Configuration.ProxyCreationEnabled = false;

            this.Configuration.AutoDetectChangesEnabled = false;

            this.Configuration.ValidateOnSaveEnabled = false;
        }
        /*
         * En la generacion inversar. SALIO  QUE TABLAS
         * SE VA A CREAR
         * En App.Data.Model. No spermise asociarf acad una 
         * de mis entidades
         * al de tipo db context.
         * Nota: Si quiero agregar una TABLA mas debo de crear la identidad
         * y en este archivo debo de agregar su equivalencias.
         * 
         
             */

        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceLine> InvoiceLine { get; set; }
        public virtual DbSet<MediaType> MediaType { get; set; }
        public virtual DbSet<Playlist> Playlist { get; set; }
        public virtual DbSet<Track> Track { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .HasMany(e => e.Album)
                .WithRequired(e => e.Artist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Invoice)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Customer)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.SupportRepId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employee1)
                .WithOptional(e => e.Employee2)
                .HasForeignKey(e => e.ReportsTo);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Total)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.InvoiceLine)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceLine>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MediaType>()
                .HasMany(e => e.Track)
                .WithRequired(e => e.MediaType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Playlist>()
                .HasMany(e => e.Track)
                .WithMany(e => e.Playlist)
                .Map(m => m.ToTable("PlaylistTrack").MapLeftKey("PlaylistId").MapRightKey("TrackId"));

            modelBuilder.Entity<Track>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Track>()
                .HasMany(e => e.InvoiceLine)
                .WithRequired(e => e.Track)
                .WillCascadeOnDelete(false);
        }
    }
}