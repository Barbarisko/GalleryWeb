using System;
using GalleryBLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GalleryBLL
{
    public partial class postgresContext : DbContext
    {
        public postgresContext()
        {
        }

        public postgresContext(DbContextOptions<postgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CmdExec> CmdExecs { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CurrentExhibition> CurrentExhibitions { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ExhibitPlace> ExhibitPlaces { get; set; }
        public virtual DbSet<ExhibitedPicture> ExhibitedPictures { get; set; }
        public virtual DbSet<Exhibition> Exhibitions { get; set; }
        public virtual DbSet<OwnedPicture> OwnedPictures { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Technique> Techniques { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=165.232.107.123;Database=postgres;Username=postgres;Password=1;Persist Security Info=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "C.UTF-8");

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasKey(e => e.IdArtist)
                    .HasName("artists_pkey");

                entity.ToTable("artists");

                entity.HasIndex(e => e.Telephone, "artists_telephone_key")
                    .IsUnique();

                entity.Property(e => e.IdArtist).HasColumnName("id_artist");

                entity.Property(e => e.ArtDirection)
                    .HasMaxLength(15)
                    .HasColumnName("art_direction");

                entity.Property(e => e.Bday)
                    .HasColumnType("date")
                    .HasColumnName("bday");

                entity.Property(e => e.Death)
                    .HasColumnType("date")
                    .HasColumnName("death");

                entity.Property(e => e.IdCity).HasColumnName("id_city");

                entity.Property(e => e.LastName)
                    .HasMaxLength(200)
                    .HasColumnName("last_name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Surname)
                    .HasMaxLength(200)
                    .HasColumnName("surname");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(10)
                    .HasColumnName("telephone");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Artists)
                    .HasForeignKey(d => d.IdCity)
                    .HasConstraintName("artists_id_city_fkey");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.IdCity)
                    .HasName("cities_pkey");

                entity.ToTable("cities");

                entity.Property(e => e.IdCity).HasColumnName("id_city");

                entity.Property(e => e.IdCountry).HasColumnName("id_country");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.IdCountry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cities_id_country_fkey");
            });

            modelBuilder.Entity<CmdExec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cmd_exec");

                entity.Property(e => e.CmdOutput).HasColumnName("cmd_output");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.IdCountry)
                    .HasName("countries_pkey");

                entity.ToTable("countries");

                entity.HasIndex(e => e.Name, "countries_name_key")
                    .IsUnique();

                entity.Property(e => e.IdCountry).HasColumnName("id_country");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CurrentExhibition>(entity =>
            {
                entity.HasKey(e => e.IdCurrExh)
                    .HasName("current_exhibitions_pkey");

                entity.ToTable("current_exhibitions");

                entity.Property(e => e.IdCurrExh).HasColumnName("id_curr_exh");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.IdExh).HasColumnName("id_exh");

                entity.Property(e => e.IdExhPlace).HasColumnName("id_exh_place");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.CurrentExhibitions)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("current_exhibitions_id_employee_fkey");

                entity.HasOne(d => d.IdExhNavigation)
                    .WithMany(p => p.CurrentExhibitions)
                    .HasForeignKey(d => d.IdExh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("current_exhibitions_id_exh_fkey");

                entity.HasOne(d => d.IdExhPlaceNavigation)
                    .WithMany(p => p.CurrentExhibitions)
                    .HasForeignKey(d => d.IdExhPlace)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("current_exhibitions_id_exh_place_fkey");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("employees_pkey");

                entity.ToTable("employees");

                entity.HasIndex(e => e.Telephone, "employees_telephone_key")
                    .IsUnique();

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.AddInfo).HasColumnName("add_info");

                entity.Property(e => e.Bday)
                    .HasColumnType("date")
                    .HasColumnName("bday");

                entity.Property(e => e.IdCity).HasColumnName("id_city");

                entity.Property(e => e.Job)
                    .HasMaxLength(10)
                    .HasColumnName("job");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("last_name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("surname");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(10)
                    .HasColumnName("telephone");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employees_id_city_fkey");
            });

            modelBuilder.Entity<ExhibitPlace>(entity =>
            {
                entity.HasKey(e => e.IdExhPlace)
                    .HasName("exhibit_places_pkey");

                entity.ToTable("exhibit_places");

                entity.Property(e => e.IdExhPlace).HasColumnName("id_exh_place");

                entity.Property(e => e.IdCity).HasColumnName("id_city");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Telephone).HasColumnName("telephone");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.ExhibitPlaces)
                    .HasForeignKey(d => d.IdCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("exhibit_places_id_city_fkey");
            });

            modelBuilder.Entity<ExhibitedPicture>(entity =>
            {
                entity.HasKey(e => e.IdExhPic)
                    .HasName("exhibited_pictures_pkey");

                entity.ToTable("exhibited_pictures");

                entity.Property(e => e.IdExhPic).HasColumnName("id_exh_pic");

                entity.Property(e => e.IdCurrExh).HasColumnName("id_curr_exh");

                entity.Property(e => e.IdPicture).HasColumnName("id_picture");

                entity.Property(e => e.Room).HasColumnName("room");

                entity.HasOne(d => d.IdCurrExhNavigation)
                    .WithMany(p => p.ExhibitedPictures)
                    .HasForeignKey(d => d.IdCurrExh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("exhibited_pictures_id_curr_exh_fkey");

                entity.HasOne(d => d.IdPictureNavigation)
                    .WithMany(p => p.ExhibitedPictures)
                    .HasForeignKey(d => d.IdPicture)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("exhibited_pictures_id_picture_fkey");
            });

            modelBuilder.Entity<Exhibition>(entity =>
            {
                entity.HasKey(e => e.IdExh)
                    .HasName("exhibitions_pkey");

                entity.ToTable("exhibitions");

                entity.Property(e => e.IdExh).HasColumnName("id_exh");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<OwnedPicture>(entity =>
            {
                entity.HasKey(e => e.IdOwnedPicture)
                    .HasName("owned_pictures_pkey");

                entity.ToTable("owned_pictures");

                entity.HasIndex(e => e.IdPicture, "owned_pictures_id_picture_key")
                    .IsUnique();

                entity.Property(e => e.IdOwnedPicture).HasColumnName("id_owned_picture");

                entity.Property(e => e.BuyDate)
                    .HasColumnType("date")
                    .HasColumnName("buy_date");

                entity.Property(e => e.IdOwner).HasColumnName("id_owner");

                entity.Property(e => e.IdPicture).HasColumnName("id_picture");

                entity.HasOne(d => d.IdOwnerNavigation)
                    .WithMany(p => p.OwnedPictures)
                    .HasForeignKey(d => d.IdOwner)
                    .HasConstraintName("owned_pictures_id_owner_fkey");

                entity.HasOne(d => d.IdPictureNavigation)
                    .WithOne(p => p.OwnedPicture)
                    .HasForeignKey<OwnedPicture>(d => d.IdPicture)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("owned_pictures_id_picture_fkey");
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.HasKey(e => e.IdOwner)
                    .HasName("owners_pkey");

                entity.ToTable("owners");

                entity.HasIndex(e => e.BankAcc, "owners_bank_acc_key")
                    .IsUnique();

                entity.HasIndex(e => e.Telephone, "owners_telephone_key")
                    .IsUnique();

                entity.Property(e => e.IdOwner).HasColumnName("id_owner");

                entity.Property(e => e.BankAcc)
                    .HasMaxLength(100)
                    .HasColumnName("bank_acc");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("last_name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("surname");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(100)
                    .HasColumnName("telephone");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.HasKey(e => e.IdPicture)
                    .HasName("pictures_pkey");

                entity.ToTable("pictures");

                entity.Property(e => e.IdPicture).HasColumnName("id_picture");

                entity.Property(e => e.AddInfo).HasColumnName("add_info");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasColumnName("create_date");

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("genre");

                entity.Property(e => e.IdArtist).HasColumnName("id_artist");

                entity.Property(e => e.IdTechnique).HasColumnName("id_technique");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.IdArtistNavigation)
                    .WithMany(p => p.Pictures)
                    .HasForeignKey(d => d.IdArtist)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pictures_id_artist_fkey");

                entity.HasOne(d => d.IdTechniqueNavigation)
                    .WithMany(p => p.Pictures)
                    .HasForeignKey(d => d.IdTechnique)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pictures_id_technique_fkey");
            });

            modelBuilder.Entity<Technique>(entity =>
            {
                entity.HasKey(e => e.IdTechnique)
                    .HasName("techniques_pkey");

                entity.ToTable("techniques");

                entity.HasIndex(e => e.Name, "techniques_name_key")
                    .IsUnique();

                entity.Property(e => e.IdTechnique).HasColumnName("id_technique");

                entity.Property(e => e.Base)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("base");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("name");

                entity.Property(e => e.Paint)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("paint");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.IdTicket)
                    .HasName("tickets_pkey");

                entity.ToTable("tickets");

                entity.Property(e => e.IdTicket).HasColumnName("id_ticket");

                entity.Property(e => e.BuyDate)
                    .HasColumnType("date")
                    .HasColumnName("buy_date");

                entity.Property(e => e.IdCurrExh).HasColumnName("id_curr_exh");

                entity.HasOne(d => d.IdCurrExhNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.IdCurrExh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tickets_id_curr_exh_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
