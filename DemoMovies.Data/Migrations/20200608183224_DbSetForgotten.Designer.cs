﻿// <auto-generated />
using System;
using DemoMovies.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoMovies.Data.Migrations
{
    [DbContext(typeof(DemoMoviesContext))]
    [Migration("20200608183224_DbSetForgotten")]
    partial class DbSetForgotten
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoMovies.Data.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cast")
                        .IsRequired();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Genre")
                        .IsRequired();

                    b.Property<string>("ImageUrl")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("Views");

                    b.Property<int>("YearReleased");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("DemoMovies.Data.MovieComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired();

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("MovieId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("MovieComments");
                });

            modelBuilder.Entity("DemoMovies.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DemoMovies.Data.MovieComment", b =>
                {
                    b.HasOne("DemoMovies.Data.Movie", "Movie")
                        .WithMany("MovieComment")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoMovies.Data.User", "User")
                        .WithMany("UserComment")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
