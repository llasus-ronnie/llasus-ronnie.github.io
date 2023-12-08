﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PurrfectPair.Data;

#nullable disable

namespace PurrfectPair.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PurrfectPair.Models.PetAdopting", b =>
                {
                    b.Property<int>("pet_adopting_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pet_adopting_id"));

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("pet_submission_id")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pet_adopting_id");

                    b.ToTable("PetAdoptingFormTable");
                });

            modelBuilder.Entity("PurrfectPair.Models.PetSubmission", b =>
                {
                    b.Property<int>("pet_submission_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pet_submission_id"));

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("pet_age")
                        .HasColumnType("int");

                    b.Property<string>("pet_breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("pet_is_adopting")
                        .HasColumnType("bit");

                    b.Property<string>("pet_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_photos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pet_submission_id");

                    b.ToTable("PetSubmitAdoptionTable");
                });

            modelBuilder.Entity("PurrfectPair.Models.Pets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PetAdoption", (string)null);
                });

            modelBuilder.Entity("PurrfectPair.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ContactNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
