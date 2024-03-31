﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectE.Music.Data;

#nullable disable

namespace ProjectE.Music.Data.Migrations
{
    [DbContext(typeof(MusicDbContext))]
    partial class MusicDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Music")
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectE.Music.Music", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Music", "Music");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9268891c-3aa8-4aff-ac5a-4454fa6aa672"),
                            Artist = "Lady Gaga",
                            Genre = "Genre",
                            SongName = "Bad Romace"
                        },
                        new
                        {
                            Id = new Guid("14311560-98e1-4ca4-bfa6-4cb022501b2f"),
                            Artist = "Lady Gaga",
                            Genre = "Genre",
                            SongName = "Poker Face"
                        },
                        new
                        {
                            Id = new Guid("f25c986b-fc36-439e-bc29-9616ff2d7e95"),
                            Artist = "Rihanna",
                            Genre = "Genre",
                            SongName = "Don’t Stop the Music"
                        },
                        new
                        {
                            Id = new Guid("850111d5-6409-4196-a362-c53f007ed4dd"),
                            Artist = "Rihanna",
                            Genre = "Genre",
                            SongName = "Where Have You Been"
                        },
                        new
                        {
                            Id = new Guid("10ea0c9a-d776-4d66-a383-dc6a00880d76"),
                            Artist = "The Weeknd",
                            Genre = "Genre",
                            SongName = "Die For You"
                        },
                        new
                        {
                            Id = new Guid("d469ca99-8520-4f03-ad64-324dda4b0d78"),
                            Artist = "The Weeknd",
                            Genre = "Genre",
                            SongName = "Blinding Lights"
                        },
                        new
                        {
                            Id = new Guid("2a31f0f1-e815-4590-885c-6c03de9c7ba2"),
                            Artist = "Abba",
                            Genre = "Genre",
                            SongName = "Angel Eyes"
                        },
                        new
                        {
                            Id = new Guid("0a4a2648-a7f6-41c6-b3e6-d9329b2a345d"),
                            Artist = "Abba",
                            Genre = "Genre",
                            SongName = "Dancing Queen"
                        },
                        new
                        {
                            Id = new Guid("59fdc46f-8528-44c3-8095-ebbc6e5785ea"),
                            Artist = "Avicii",
                            Genre = "Genre",
                            SongName = "Levels"
                        },
                        new
                        {
                            Id = new Guid("444521eb-fc20-4cf5-b935-fd6008b928bf"),
                            Artist = "Avicii",
                            Genre = "Genre",
                            SongName = "Addicted To You"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
