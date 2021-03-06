// <auto-generated />
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
    [Migration("20211213090729_Changed_DataType_To_DateTime_For_Artist")]
    partial class Changed_DataType_To_DateTime_For_Artist
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
