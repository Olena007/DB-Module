﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using final_db;

#nullable disable

namespace final_db.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("final_db.DbModels.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            DateOfBirth = new DateTime(1988, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adele@gmail.com",
                            InstagramURL = "www.instagram.com/adele/",
                            Name = "Adele",
                            Phone = "+3800991234576"
                        },
                        new
                        {
                            ArtistId = 2,
                            DateOfBirth = new DateTime(1988, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "avicii@gmail.com",
                            InstagramURL = "www.instagram.com/avicii/",
                            Name = "Avicii",
                            Phone = "+3800991679976"
                        },
                        new
                        {
                            ArtistId = 3,
                            DateOfBirth = new DateTime(1981, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "coldplay@gmail.com",
                            InstagramURL = "www.instagram.com/coldplay/",
                            Name = "Chris Martin",
                            Phone = "+3800951234576"
                        });
                });

            modelBuilder.Entity("final_db.DbModels.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Title = "pop"
                        },
                        new
                        {
                            GenreId = 2,
                            Title = "alternative"
                        },
                        new
                        {
                            GenreId = 3,
                            Title = "house"
                        });
                });

            modelBuilder.Entity("final_db.DbModels.Performance", b =>
                {
                    b.Property<int>("PerformanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PerformanceId"), 1L, 1);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfPerformance")
                        .HasColumnType("datetime2");

                    b.Property<string>("LocationPlatform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("PerformanceId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("SongId");

                    b.ToTable("Performances");

                    b.HasData(
                        new
                        {
                            PerformanceId = 1,
                            ArtistId = 1,
                            DateOfPerformance = new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationPlatform = "Instagram",
                            SongId = 1
                        },
                        new
                        {
                            PerformanceId = 2,
                            ArtistId = 2,
                            SongId = 2
                        },
                        new
                        {
                            PerformanceId = 3,
                            ArtistId = 3,
                            DateOfPerformance = new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationPlatform = "Instagram",
                            SongId = 3
                        });
                });

            modelBuilder.Entity("final_db.DbModels.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongId"), 1L, 1);

                    b.Property<DateTime>("Duration")
                        .HasColumnType("datetime2");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongId");

                    b.HasIndex("GenreId")
                        .IsUnique();

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongId = 1,
                            Duration = new DateTime(2022, 7, 19, 0, 4, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 1,
                            ReleasedDate = new DateTime(2011, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Rumpr has it"
                        },
                        new
                        {
                            SongId = 2,
                            Duration = new DateTime(2022, 7, 19, 0, 5, 13, 0, DateTimeKind.Unspecified),
                            GenreId = 1,
                            ReleasedDate = new DateTime(2015, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Love in the dark"
                        },
                        new
                        {
                            SongId = 3,
                            Duration = new DateTime(2022, 7, 19, 0, 4, 13, 0, DateTimeKind.Unspecified),
                            GenreId = 3,
                            ReleasedDate = new DateTime(1960, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Wake me up"
                        });
                });

            modelBuilder.Entity("final_db.DbModels.Performance", b =>
                {
                    b.HasOne("final_db.DbModels.Artist", "Artist")
                        .WithMany("Performances")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("final_db.DbModels.Song", "Song")
                        .WithMany("Performances")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("final_db.DbModels.Song", b =>
                {
                    b.HasOne("final_db.DbModels.Genre", "Genre")
                        .WithOne("Song")
                        .HasForeignKey("final_db.DbModels.Song", "GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("final_db.DbModels.Artist", b =>
                {
                    b.Navigation("Performances");
                });

            modelBuilder.Entity("final_db.DbModels.Genre", b =>
                {
                    b.Navigation("Song")
                        .IsRequired();
                });

            modelBuilder.Entity("final_db.DbModels.Song", b =>
                {
                    b.Navigation("Performances");
                });
#pragma warning restore 612, 618
        }
    }
}
