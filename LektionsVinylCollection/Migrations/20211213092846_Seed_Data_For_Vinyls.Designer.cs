﻿// <auto-generated />
using System;
using LektionsVinylCollection.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LektionsVinylCollection.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211213092846_Seed_Data_For_Vinyls")]
    partial class Seed_Data_For_Vinyls
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LektionsVinylCollection.Entities.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FavoriteCar")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4402),
                            FavoriteCar = "Car 1",
                            Name = "Artist 1"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4444),
                            FavoriteCar = "Car 2",
                            Name = "Artist 2"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4446),
                            FavoriteCar = "Car 3",
                            Name = "Artist 3"
                        });
                });

            modelBuilder.Entity("LektionsVinylCollection.Entities.Vinyl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ArtistID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ArtistID");

                    b.ToTable("Vinyls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistID = 1,
                            Created = new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4571),
                            Title = "Title 1"
                        },
                        new
                        {
                            Id = 2,
                            ArtistID = 2,
                            Created = new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4574),
                            Title = "Title 2"
                        },
                        new
                        {
                            Id = 3,
                            ArtistID = 2,
                            Created = new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4576),
                            Title = "Title 3"
                        },
                        new
                        {
                            Id = 4,
                            ArtistID = 3,
                            Created = new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4577),
                            Title = "Title 4"
                        },
                        new
                        {
                            Id = 5,
                            ArtistID = 3,
                            Created = new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4578),
                            Title = "Title 5"
                        },
                        new
                        {
                            Id = 6,
                            ArtistID = 3,
                            Created = new DateTime(2021, 12, 13, 10, 28, 46, 528, DateTimeKind.Local).AddTicks(4580),
                            Title = "Title 6"
                        });
                });

            modelBuilder.Entity("LektionsVinylCollection.Entities.Vinyl", b =>
                {
                    b.HasOne("LektionsVinylCollection.Entities.Artist", "Artist")
                        .WithMany("Vinyls")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("LektionsVinylCollection.Entities.Artist", b =>
                {
                    b.Navigation("Vinyls");
                });
#pragma warning restore 612, 618
        }
    }
}