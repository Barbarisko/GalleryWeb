﻿// <auto-generated />
using System;
using GalleryDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GalleryDAL.Migrations
{
    [DbContext(typeof(GalleryDbContext))]
    partial class GalleryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //modelBuilder.Entity("GalleryDAL.Entities.Artist", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<string>("AddInfo")
            //            .HasColumnType("text");

            //        b.Property<string>("ArtDirection")
            //            .HasColumnType("text");

            //        b.Property<DateTime>("Bday")
            //            .HasColumnType("timestamp without time zone");

            //        b.Property<int?>("CityId")
            //            .HasColumnType("integer");

            //        b.Property<DateTime?>("Death")
            //            .HasColumnType("timestamp without time zone");

            //        b.Property<int?>("IdCity")
            //            .HasColumnType("integer");

            //        b.Property<string>("LastName")
            //            .HasColumnType("text");

            //        b.Property<string>("Name")
            //            .HasColumnType("text");

            //        b.Property<string>("Surname")
            //            .HasColumnType("text");

            //        b.Property<string>("Telephone")
            //            .HasColumnType("text");

            //        b.Property<string>("Url")
            //            .HasColumnType("text");

            //        b.HasKey("Id");

            //        b.HasIndex("CityId");

            //        b.ToTable("Artists");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.City", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<int?>("CountryId")
            //            .HasColumnType("integer");

            //        b.Property<int>("IdCountry")
            //            .HasColumnType("integer");

            //        b.Property<string>("Name")
            //            .HasColumnType("text");

            //        b.HasKey("Id");

            //        b.HasIndex("CountryId");

            //        b.ToTable("Cities");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.Country", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<string>("Name")
            //            .HasColumnType("text");

            //        b.HasKey("Id");

            //        b.ToTable("Countries");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.CurrentExhibition", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<DateTime?>("DateBegin")
            //            .HasColumnType("timestamp without time zone");

            //        b.Property<DateTime?>("DateEnd")
            //            .HasColumnType("timestamp without time zone");

            //        b.Property<int?>("EmployeeId")
            //            .HasColumnType("integer");

            //        b.Property<int?>("ExhId")
            //            .HasColumnType("integer");

            //        b.Property<int?>("ExhPlaceId")
            //            .HasColumnType("integer");

            //        b.Property<int>("IdEmployee")
            //            .HasColumnType("integer");

            //        b.Property<int>("IdExh")
            //            .HasColumnType("integer");

            //        b.Property<int>("IdExhPlace")
            //            .HasColumnType("integer");

            //        b.HasKey("Id");

            //        b.HasIndex("EmployeeId");

            //        b.HasIndex("ExhId");

            //        b.HasIndex("ExhPlaceId");

            //        b.ToTable("CurrentExhibitions");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.Employee", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<string>("AddInfo")
            //            .HasColumnType("text");

            //        b.Property<DateTime?>("Bday")
            //            .HasColumnType("timestamp without time zone");

            //        b.Property<int?>("CityId")
            //            .HasColumnType("integer");

            //        b.Property<int>("IdCity")
            //            .HasColumnType("integer");

            //        b.Property<string>("Job")
            //            .HasColumnType("text");

            //        b.Property<string>("LastName")
            //            .HasColumnType("text");

            //        b.Property<string>("Name")
            //            .HasColumnType("text");

            //        b.Property<string>("Surname")
            //            .HasColumnType("text");

            //        b.Property<string>("Telephone")
            //            .HasColumnType("text");

            //        b.HasKey("Id");

            //        b.HasIndex("CityId");

            //        b.ToTable("Employees");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.ExhibitPlace", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<int?>("CityId")
            //            .HasColumnType("integer");

            //        b.Property<string>("Description")
            //            .HasColumnType("text");

            //        b.Property<int>("IdCity")
            //            .HasColumnType("integer");

            //        b.Property<string>("Name")
            //            .HasColumnType("text");

            //        b.Property<int?>("Telephone")
            //            .HasColumnType("integer");

            //        b.HasKey("Id");

            //        b.HasIndex("CityId");

            //        b.ToTable("ExhibitPlaces");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.ExhibitedPicture", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<int?>("CurrExhId")
            //            .HasColumnType("integer");

            //        b.Property<int>("IdCurrExh")
            //            .HasColumnType("integer");

            //        b.Property<int>("IdPicture")
            //            .HasColumnType("integer");

            //        b.Property<int?>("PictureId")
            //            .HasColumnType("integer");

            //        b.Property<int>("Room")
            //            .HasColumnType("integer");

            //        b.HasKey("Id");

            //        b.HasIndex("CurrExhId");

            //        b.HasIndex("PictureId");

            //        b.ToTable("ExhibitedPictures");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.Exhibition", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<string>("Description")
            //            .HasColumnType("text");

            //        b.Property<string>("Name")
            //            .HasColumnType("text");

            //        b.Property<int?>("Price")
            //            .HasColumnType("integer");

            //        b.HasKey("Id");

            //        b.ToTable("Exhibitions");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.News", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<string>("Description")
            //            .HasColumnType("text");

            //        b.Property<string>("Name")
            //            .HasColumnType("text");

            //        b.HasKey("Id");

            //        b.ToTable("News");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.OwnedPicture", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<DateTime>("BuyDate")
            //            .HasColumnType("timestamp without time zone");

            //        b.Property<int?>("IdOwner")
            //            .HasColumnType("integer");

            //        b.Property<int>("IdPicture")
            //            .HasColumnType("integer");

            //        b.Property<int?>("OwnerId")
            //            .HasColumnType("integer");

            //        b.Property<int?>("PictureId")
            //            .HasColumnType("integer");

            //        b.HasKey("Id");

            //        b.HasIndex("OwnerId");

            //        b.HasIndex("PictureId");

            //        b.ToTable("OwnedPictures");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.Owner", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<string>("BankAcc")
            //            .HasColumnType("text");

            //        b.Property<string>("LastName")
            //            .HasColumnType("text");

            //        b.Property<string>("Name")
            //            .HasColumnType("text");

            //        b.Property<string>("Surname")
            //            .HasColumnType("text");

            //        b.Property<string>("Telephone")
            //            .HasColumnType("text");

            //        b.HasKey("Id");

            //        b.ToTable("Owners");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.Picture", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<string>("AddInfo")
            //            .HasColumnType("text");

            //        b.Property<int?>("ArtistId")
            //            .HasColumnType("integer");

            //        b.Property<DateTime>("CreateDate")
            //            .HasColumnType("timestamp without time zone");

            //        b.Property<string>("Genre")
            //            .HasColumnType("text");

            //        b.Property<int>("IdArtist")
            //            .HasColumnType("integer");

            //        b.Property<int>("IdTechnique")
            //            .HasColumnType("integer");

            //        b.Property<string>("Name")
            //            .HasColumnType("text");

            //        b.Property<int>("Price")
            //            .HasColumnType("integer");

            //        b.Property<int?>("TechniqueId")
            //            .HasColumnType("integer");

            //        b.Property<string>("Url")
            //            .HasColumnType("text");

            //        b.HasKey("Id");

            //        b.HasIndex("ArtistId");

            //        b.HasIndex("TechniqueId");

            //        b.ToTable("Pictures");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.Technique", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<string>("Base")
            //            .HasColumnType("text");

            //        b.Property<string>("Name")
            //            .HasColumnType("text");

            //        b.Property<string>("Paint")
            //            .HasColumnType("text");

            //        b.Property<string>("PicUrl")
            //            .HasColumnType("text");

            //        b.HasKey("Id");

            //        b.ToTable("Techniques");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.Ticket", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<DateTime>("BuyDate")
            //            .HasColumnType("timestamp without time zone");

            //        b.Property<int?>("CurExhId")
            //            .HasColumnType("integer");

            //        b.HasKey("Id");

            //        b.HasIndex("CurExhId");

            //        b.ToTable("Tickets");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.TicketsInCart", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("integer")
            //            .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //        b.Property<string>("CartId")
            //            .HasColumnType("text");

            //        b.Property<int?>("Quantity")
            //            .HasColumnType("integer");

            //        b.Property<int?>("TicketId")
            //            .HasColumnType("integer");

            //        b.Property<int?>("TotalPrice")
            //            .HasColumnType("integer");

            //        b.HasKey("Id");

            //        b.HasIndex("TicketId");

            //        b.ToTable("TicketsInCarts");
            //    });

            //modelBuilder.Entity("GalleryDAL.Entities.UserEntity", b =>
            //    {
            //        b.Property<string>("Id")
            //            .HasColumnType("text");

            //        b.Property<int>("AccessFailedCount")
            //            .HasColumnType("integer");

            //        b.Property<string>("ConcurrencyStamp")
            //            .IsConcurrencyToken()
            //            .HasColumnType("text");

            //        b.Property<string>("Email")
            //            .HasMaxLength(256)
            //            .HasColumnType("character varying(256)");

            //        b.Property<bool>("EmailConfirmed")
            //            .HasColumnType("boolean");

            //        b.Property<string>("FullName")
            //            .IsRequired()
            //            .HasColumnType("text");

            //        b.Property<bool>("LockoutEnabled")
            //            .HasColumnType("boolean");

            //        b.Property<DateTimeOffset?>("LockoutEnd")
            //            .HasColumnType("timestamp with time zone");

            //        b.Property<string>("NormalizedEmail")
            //            .HasMaxLength(256)
            //            .HasColumnType("character varying(256)");

            //        b.Property<string>("NormalizedUserName")
            //            .HasMaxLength(256)
            //            .HasColumnType("character varying(256)");

            //        b.Property<string>("PasswordHash")
            //            .HasColumnType("text");

            //        b.Property<string>("PhoneNumber")
            //            .HasColumnType("text");

            //        b.Property<bool>("PhoneNumberConfirmed")
            //            .HasColumnType("boolean");

            //        b.Property<string>("SecurityStamp")
            //            .HasColumnType("text");

            //        b.Property<bool>("TwoFactorEnabled")
            //            .HasColumnType("boolean");

            //        b.Property<string>("UserName")
            //            .HasMaxLength(256)
            //            .HasColumnType("character varying(256)");

            //        b.HasKey("Id");

            //        b.HasIndex("NormalizedEmail")
            //            .HasDatabaseName("EmailIndex");

            //        b.HasIndex("NormalizedUserName")
            //            .IsUnique()
            //            .HasDatabaseName("UserNameIndex");

            //        b.ToTable("AspNetUsers");
            //    });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GalleryDAL.Entities.Artist", b =>
                {
                    b.HasOne("GalleryDAL.Entities.City", "City")
                        .WithMany("Artists")
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("GalleryDAL.Entities.City", b =>
                {
                    b.HasOne("GalleryDAL.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("GalleryDAL.Entities.CurrentExhibition", b =>
                {
                    b.HasOne("GalleryDAL.Entities.Employee", "Employee")
                        .WithMany("CurrentExhibitions")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("GalleryDAL.Entities.Exhibition", "Exh")
                        .WithMany("CurrentExhibitions")
                        .HasForeignKey("ExhId");

                    b.HasOne("GalleryDAL.Entities.ExhibitPlace", "ExhPlace")
                        .WithMany("CurrentExhibitions")
                        .HasForeignKey("ExhPlaceId");

                    b.Navigation("Employee");

                    b.Navigation("Exh");

                    b.Navigation("ExhPlace");
                });

            modelBuilder.Entity("GalleryDAL.Entities.Employee", b =>
                {
                    b.HasOne("GalleryDAL.Entities.City", "City")
                        .WithMany("Employees")
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("GalleryDAL.Entities.ExhibitPlace", b =>
                {
                    b.HasOne("GalleryDAL.Entities.City", "City")
                        .WithMany("ExhibitPlaces")
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("GalleryDAL.Entities.ExhibitedPicture", b =>
                {
                    b.HasOne("GalleryDAL.Entities.CurrentExhibition", "CurrExh")
                        .WithMany("ExhibitedPictures")
                        .HasForeignKey("CurrExhId");

                    b.HasOne("GalleryDAL.Entities.Picture", "Picture")
                        .WithMany("ExhibitedPictures")
                        .HasForeignKey("PictureId");

                    b.Navigation("CurrExh");

                    b.Navigation("Picture");
                });

            modelBuilder.Entity("GalleryDAL.Entities.OwnedPicture", b =>
                {
                    b.HasOne("GalleryDAL.Entities.Owner", "Owner")
                        .WithMany("OwnedPictures")
                        .HasForeignKey("OwnerId");

                    b.HasOne("GalleryDAL.Entities.Picture", "Picture")
                        .WithMany("OwnedPicture")
                        .HasForeignKey("PictureId");

                    b.Navigation("Owner");

                    b.Navigation("Picture");
                });

            modelBuilder.Entity("GalleryDAL.Entities.Picture", b =>
                {
                    b.HasOne("GalleryDAL.Entities.Artist", "Artist")
                        .WithMany("Pictures")
                        .HasForeignKey("ArtistId");

                    b.HasOne("GalleryDAL.Entities.Technique", "Technique")
                        .WithMany("Pictures")
                        .HasForeignKey("TechniqueId");

                    b.Navigation("Artist");

                    b.Navigation("Technique");
                });

            modelBuilder.Entity("GalleryDAL.Entities.Ticket", b =>
                {
                    b.HasOne("GalleryDAL.Entities.CurrentExhibition", "CurExh")
                        .WithMany("Tickets")
                        .HasForeignKey("CurExhId");

                    b.Navigation("CurExh");
                });

            modelBuilder.Entity("GalleryDAL.Entities.TicketsInCart", b =>
                {
                    b.HasOne("GalleryDAL.Entities.Ticket", "Ticket")
                        .WithMany("TicketsInCarts")
                        .HasForeignKey("TicketId");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GalleryDAL.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GalleryDAL.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GalleryDAL.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GalleryDAL.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GalleryDAL.Entities.Artist", b =>
                {
                    b.Navigation("Pictures");
                });

            modelBuilder.Entity("GalleryDAL.Entities.City", b =>
                {
                    b.Navigation("Artists");

                    b.Navigation("Employees");

                    b.Navigation("ExhibitPlaces");
                });

            modelBuilder.Entity("GalleryDAL.Entities.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("GalleryDAL.Entities.CurrentExhibition", b =>
                {
                    b.Navigation("ExhibitedPictures");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("GalleryDAL.Entities.Employee", b =>
                {
                    b.Navigation("CurrentExhibitions");
                });

            modelBuilder.Entity("GalleryDAL.Entities.ExhibitPlace", b =>
                {
                    b.Navigation("CurrentExhibitions");
                });

            modelBuilder.Entity("GalleryDAL.Entities.Exhibition", b =>
                {
                    b.Navigation("CurrentExhibitions");
                });

            modelBuilder.Entity("GalleryDAL.Entities.Owner", b =>
                {
                    b.Navigation("OwnedPictures");
                });

            modelBuilder.Entity("GalleryDAL.Entities.Picture", b =>
                {
                    b.Navigation("ExhibitedPictures");

                    b.Navigation("OwnedPicture");
                });

            modelBuilder.Entity("GalleryDAL.Entities.Technique", b =>
                {
                    b.Navigation("Pictures");
                });

            modelBuilder.Entity("GalleryDAL.Entities.Ticket", b =>
                {
                    b.Navigation("TicketsInCarts");
                });
#pragma warning restore 612, 618
        }
    }
}
