﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Context.Migrations
{
    [DbContext(typeof(PhoneBookAppDbContext))]
    [Migration("20240830125309_update-seeddata")]
    partial class updateseeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Concrete.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("Id");

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Contact");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Yasin",
                            IsActive = true,
                            LastName = "Bol",
                            PhoneNumber = "+905326944521"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Hasan",
                            IsActive = true,
                            LastName = "Sarı",
                            PhoneNumber = "+905627588456"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Mehmet",
                            IsActive = true,
                            LastName = "Ak",
                            PhoneNumber = "+905627588457"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Fatma",
                            IsActive = true,
                            LastName = "Gül",
                            PhoneNumber = "+905326944523"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Ali",
                            IsActive = true,
                            LastName = "Yeşil",
                            PhoneNumber = "+905627588458"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Emine",
                            IsActive = true,
                            LastName = "Mavi",
                            PhoneNumber = "+905326944524"
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "Veli",
                            IsActive = true,
                            LastName = "Kırmızı",
                            PhoneNumber = "+905627588459"
                        },
                        new
                        {
                            Id = 9,
                            FirstName = "Ahmet",
                            IsActive = true,
                            LastName = "Turuncu",
                            PhoneNumber = "+905326944525"
                        },
                        new
                        {
                            Id = 10,
                            FirstName = "Zeynep",
                            IsActive = true,
                            LastName = "Pembe",
                            PhoneNumber = "+905627588460"
                        },
                        new
                        {
                            Id = 11,
                            FirstName = "Mustafa",
                            IsActive = true,
                            LastName = "Mor",
                            PhoneNumber = "+905326944526"
                        },
                        new
                        {
                            Id = 12,
                            FirstName = "Rabia",
                            IsActive = true,
                            LastName = "Kahverengi",
                            PhoneNumber = "+905627588461"
                        },
                        new
                        {
                            Id = 13,
                            FirstName = "İsmail",
                            IsActive = true,
                            LastName = "Beyaz",
                            PhoneNumber = "+905326944527"
                        },
                        new
                        {
                            Id = 14,
                            FirstName = "Ayhan",
                            IsActive = true,
                            LastName = "Gri",
                            PhoneNumber = "+905627588462"
                        },
                        new
                        {
                            Id = 15,
                            FirstName = "Serpil",
                            IsActive = true,
                            LastName = "Sarı",
                            PhoneNumber = "+905326944528"
                        },
                        new
                        {
                            Id = 16,
                            FirstName = "Gülten",
                            IsActive = true,
                            LastName = "Turkuaz",
                            PhoneNumber = "+905627588463"
                        },
                        new
                        {
                            Id = 17,
                            FirstName = "Hakan",
                            IsActive = true,
                            LastName = "Kum",
                            PhoneNumber = "+905326944529"
                        },
                        new
                        {
                            Id = 18,
                            FirstName = "Merve",
                            IsActive = true,
                            LastName = "Gökyüzü",
                            PhoneNumber = "+905627588464"
                        },
                        new
                        {
                            Id = 19,
                            FirstName = "Can",
                            IsActive = true,
                            LastName = "Deniz",
                            PhoneNumber = "+905326944530"
                        },
                        new
                        {
                            Id = 20,
                            FirstName = "Ceren",
                            IsActive = true,
                            LastName = "Yeşim",
                            PhoneNumber = "+905627588465"
                        },
                        new
                        {
                            Id = 21,
                            FirstName = "Bora",
                            IsActive = true,
                            LastName = "Tuna",
                            PhoneNumber = "+905326944531"
                        },
                        new
                        {
                            Id = 22,
                            FirstName = "Duygu",
                            IsActive = true,
                            LastName = "Güneş",
                            PhoneNumber = "+905627588466"
                        },
                        new
                        {
                            Id = 23,
                            FirstName = "Barış",
                            IsActive = true,
                            LastName = "Ay",
                            PhoneNumber = "+905326944532"
                        },
                        new
                        {
                            Id = 24,
                            FirstName = "Selin",
                            IsActive = true,
                            LastName = "Yıldız",
                            PhoneNumber = "+905627588467"
                        },
                        new
                        {
                            Id = 25,
                            FirstName = "Onur",
                            IsActive = true,
                            LastName = "Kuzey",
                            PhoneNumber = "+905326944533"
                        },
                        new
                        {
                            Id = 26,
                            FirstName = "Nazan",
                            IsActive = true,
                            LastName = "Güney",
                            PhoneNumber = "+905627588468"
                        },
                        new
                        {
                            Id = 27,
                            FirstName = "Kerem",
                            IsActive = true,
                            LastName = "Doğu",
                            PhoneNumber = "+905326944534"
                        },
                        new
                        {
                            Id = 28,
                            FirstName = "Deniz",
                            IsActive = true,
                            LastName = "Batı",
                            PhoneNumber = "+905627588469"
                        },
                        new
                        {
                            Id = 29,
                            FirstName = "Ceyda",
                            IsActive = true,
                            LastName = "Gül",
                            PhoneNumber = "+905326944535"
                        },
                        new
                        {
                            Id = 30,
                            FirstName = "Fırat",
                            IsActive = true,
                            LastName = "Savaş",
                            PhoneNumber = "+905627588470"
                        },
                        new
                        {
                            Id = 31,
                            FirstName = "Aylin",
                            IsActive = true,
                            LastName = "Derya",
                            PhoneNumber = "+905326944536"
                        },
                        new
                        {
                            Id = 32,
                            FirstName = "Arda",
                            IsActive = true,
                            LastName = "Deniz",
                            PhoneNumber = "+905627588471"
                        },
                        new
                        {
                            Id = 33,
                            FirstName = "Sinem",
                            IsActive = true,
                            LastName = "Ege",
                            PhoneNumber = "+905326944537"
                        },
                        new
                        {
                            Id = 34,
                            FirstName = "Oğuz",
                            IsActive = true,
                            LastName = "Koray",
                            PhoneNumber = "+905627588472"
                        },
                        new
                        {
                            Id = 35,
                            FirstName = "Seda",
                            IsActive = true,
                            LastName = "Nil",
                            PhoneNumber = "+905326944538"
                        },
                        new
                        {
                            Id = 36,
                            FirstName = "Hüseyin",
                            IsActive = true,
                            LastName = "Rüzgar",
                            PhoneNumber = "+905627588473"
                        },
                        new
                        {
                            Id = 37,
                            FirstName = "Nilgün",
                            IsActive = true,
                            LastName = "Duman",
                            PhoneNumber = "+905326944539"
                        },
                        new
                        {
                            Id = 38,
                            FirstName = "Metin",
                            IsActive = true,
                            LastName = "Işık",
                            PhoneNumber = "+905627588474"
                        },
                        new
                        {
                            Id = 39,
                            FirstName = "Pelin",
                            IsActive = true,
                            LastName = "Ateş",
                            PhoneNumber = "+905326944540"
                        },
                        new
                        {
                            Id = 40,
                            FirstName = "Erhan",
                            IsActive = true,
                            LastName = "Toprak",
                            PhoneNumber = "+905627588475"
                        },
                        new
                        {
                            Id = 41,
                            FirstName = "Yasemin",
                            IsActive = true,
                            LastName = "Dağ",
                            PhoneNumber = "+905326944541"
                        },
                        new
                        {
                            Id = 42,
                            FirstName = "Gökhan",
                            IsActive = true,
                            LastName = "Çimen",
                            PhoneNumber = "+905627588476"
                        },
                        new
                        {
                            Id = 43,
                            FirstName = "Şebnem",
                            IsActive = true,
                            LastName = "Bahar",
                            PhoneNumber = "+905326944542"
                        },
                        new
                        {
                            Id = 44,
                            FirstName = "Eren",
                            IsActive = true,
                            LastName = "Orman",
                            PhoneNumber = "+905627588477"
                        },
                        new
                        {
                            Id = 45,
                            FirstName = "Nihan",
                            IsActive = true,
                            LastName = "Küçük",
                            PhoneNumber = "+905326944543"
                        },
                        new
                        {
                            Id = 46,
                            FirstName = "Kemal",
                            IsActive = true,
                            LastName = "Büyük",
                            PhoneNumber = "+905627588478"
                        },
                        new
                        {
                            Id = 47,
                            FirstName = "Burcu",
                            IsActive = true,
                            LastName = "Kaya",
                            PhoneNumber = "+905326944544"
                        },
                        new
                        {
                            Id = 48,
                            FirstName = "Cem",
                            IsActive = true,
                            LastName = "Göl",
                            PhoneNumber = "+905627588479"
                        },
                        new
                        {
                            Id = 49,
                            FirstName = "Murat",
                            IsActive = true,
                            LastName = "Arslan",
                            PhoneNumber = "+905326944545"
                        },
                        new
                        {
                            Id = 50,
                            FirstName = "Sibel",
                            IsActive = true,
                            LastName = "Kartal",
                            PhoneNumber = "+905627588480"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "bb90dc29-c9cd-49e5-9f45-532b3c066b87",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6a267429-5988-456e-9ddb-a3ae99c9bd9d",
                            Email = "ahmet.yilmaz@yba.com",
                            EmailConfirmed = false,
                            IsActive = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "AHMET.YILMAZ@YBA.COM",
                            NormalizedUserName = "AHMET.YILMAZ",
                            PasswordHash = "AQAAAAEAACcQAAAAECILXtxUOlwi8z2ZlbDJlByYOE3NzuERPrC9Al39HQ4lIx/rE8X1hddt1Wmb+9n1fQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f048462e-24cc-4654-859e-142102e1fc85",
                            TwoFactorEnabled = false,
                            UserName = "Ahmet.Yılmaz"
                        },
                        new
                        {
                            Id = "db2fa01f-4054-4439-84d1-58020cb7bfe1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d9532655-5e2b-4bf5-886a-56e3fed34b82",
                            Email = "necdet.dol@yba.com",
                            EmailConfirmed = false,
                            IsActive = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "NECDET.DOL@YBA.COM",
                            NormalizedUserName = "NECDET.DOL",
                            PasswordHash = "AQAAAAEAACcQAAAAEPkweM9ML8VFBz9/8QCAQhvRb+47qBgrjt1mOslOikpSjg408w9wFD/958XYYdd4xw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7b66209f-89ac-4a47-b5b6-5d04dd82e608",
                            TwoFactorEnabled = false,
                            UserName = "Necdet.Dol"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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
                    b.HasOne("Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Entities.Concrete.User", null)
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

                    b.HasOne("Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
