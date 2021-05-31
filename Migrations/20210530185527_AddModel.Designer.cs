﻿// <auto-generated />
using System;
using ApiDisney.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiDisney.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210530185527_AddModel")]
    partial class AddModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiDisney.Models.Character", b =>
                {
                    b.Property<int>("Id_Character")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("History")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id_Character");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("ApiDisney.Models.CharacterMovie", b =>
                {
                    b.Property<int>("Id_Movie")
                        .HasColumnType("int");

                    b.Property<int>("Id_Character")
                        .HasColumnType("int");

                    b.HasKey("Id_Movie", "Id_Character");

                    b.HasIndex("Id_Character");

                    b.ToTable("CharacterMovies");
                });

            modelBuilder.Entity("ApiDisney.Models.Genre", b =>
                {
                    b.Property<int>("Id_Genre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Genre");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("ApiDisney.Models.Movie", b =>
                {
                    b.Property<int>("Id_Movie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Genre")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Movie");

                    b.HasIndex("Id_Genre");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("ApiDisney.Models.CharacterMovie", b =>
                {
                    b.HasOne("ApiDisney.Models.Character", "Character")
                        .WithMany("CharacterMovies")
                        .HasForeignKey("Id_Character")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiDisney.Models.Movie", "Movie")
                        .WithMany("CharacterMovies")
                        .HasForeignKey("Id_Movie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ApiDisney.Models.Movie", b =>
                {
                    b.HasOne("ApiDisney.Models.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("Id_Genre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("ApiDisney.Models.Character", b =>
                {
                    b.Navigation("CharacterMovies");
                });

            modelBuilder.Entity("ApiDisney.Models.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("ApiDisney.Models.Movie", b =>
                {
                    b.Navigation("CharacterMovies");
                });
#pragma warning restore 612, 618
        }
    }
}