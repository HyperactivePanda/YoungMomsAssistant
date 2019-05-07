﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YoungMomsAssistant.Core.DbContexts;

namespace YoungMomsAssistant.WebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190507165821_BabyGrowthAndWeight")]
    partial class BabyGrowthAndWeight
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.Allergy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.Baby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Babies");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.BabyAllergy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Allery_Id");

                    b.Property<int>("Baby_Id");

                    b.HasKey("Id");

                    b.HasIndex("Allery_Id");

                    b.HasIndex("Baby_Id");

                    b.ToTable("BabyAllergies");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.BabyDisease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Baby_Id");

                    b.Property<DateTime>("Begin");

                    b.Property<int>("Disease_Id");

                    b.Property<DateTime?>("End");

                    b.HasKey("Id");

                    b.HasIndex("Baby_Id");

                    b.HasIndex("Disease_Id");

                    b.ToTable("BabyDiseases");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.BabyGrowth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Baby_Id");

                    b.Property<DateTime>("Date");

                    b.Property<double>("Growth");

                    b.HasKey("Id");

                    b.HasIndex("Baby_Id");

                    b.ToTable("BabyGrowths");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.BabyInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Baby_Id");

                    b.Property<string>("BloodType")
                        .IsRequired();

                    b.Property<string>("Sex");

                    b.HasKey("Id");

                    b.HasIndex("Baby_Id");

                    b.ToTable("BabyInfos");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.BabyVaccination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Baby_Id");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Vaccination_Id");

                    b.HasKey("Id");

                    b.HasIndex("Baby_Id");

                    b.HasIndex("Vaccination_Id");

                    b.ToTable("BabyVaccinations");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.BabyWeight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Baby_Id");

                    b.Property<DateTime>("Date");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("Baby_Id");

                    b.ToTable("BabyWeights");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Source");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.LifeEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Image_Id");

                    b.Property<string>("Summary")
                        .HasMaxLength(1000);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("User_Id");

                    b.HasKey("Id");

                    b.HasIndex("Image_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("LifeEvents");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.OralCavity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Baby_Id");

                    b.Property<long>("TeethsBitField");

                    b.HasKey("Id");

                    b.HasIndex("Baby_Id");

                    b.ToTable("OralCavities");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Login")
                        .HasMaxLength(255);

                    b.Property<string>("PasswordHash");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.UserBaby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Baby_Id");

                    b.Property<int>("User_Id");

                    b.HasKey("Id");

                    b.HasIndex("Baby_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("UserBabies");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.Vaccination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Vaccinations");
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.BabyAllergy", b =>
                {
                    b.HasOne("YoungMomsAssistant.Core.Models.DbModels.Allergy", "Allergy")
                        .WithMany("BabyAllergies")
                        .HasForeignKey("Allery_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("YoungMomsAssistant.Core.Models.DbModels.Baby", "Baby")
                        .WithMany("BabyAllergies")
                        .HasForeignKey("Baby_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.BabyDisease", b =>
                {
                    b.HasOne("YoungMomsAssistant.Core.Models.DbModels.Baby", "Baby")
                        .WithMany()
                        .HasForeignKey("Baby_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("YoungMomsAssistant.Core.Models.DbModels.Disease", "Disease")
                        .WithMany()
                        .HasForeignKey("Disease_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.BabyGrowth", b =>
                {
                    b.HasOne("YoungMomsAssistant.Core.Models.DbModels.Baby", "Baby")
                        .WithMany()
                        .HasForeignKey("Baby_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.BabyInfo", b =>
                {
                    b.HasOne("YoungMomsAssistant.Core.Models.DbModels.Baby", "Baby")
                        .WithMany()
                        .HasForeignKey("Baby_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.BabyVaccination", b =>
                {
                    b.HasOne("YoungMomsAssistant.Core.Models.DbModels.Baby", "Baby")
                        .WithMany()
                        .HasForeignKey("Baby_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("YoungMomsAssistant.Core.Models.DbModels.Vaccination", "Vaccination")
                        .WithMany()
                        .HasForeignKey("Vaccination_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.BabyWeight", b =>
                {
                    b.HasOne("YoungMomsAssistant.Core.Models.DbModels.Baby", "Baby")
                        .WithMany()
                        .HasForeignKey("Baby_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.LifeEvent", b =>
                {
                    b.HasOne("YoungMomsAssistant.Core.Models.DbModels.Image", "Image")
                        .WithMany()
                        .HasForeignKey("Image_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("YoungMomsAssistant.Core.Models.DbModels.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.OralCavity", b =>
                {
                    b.HasOne("YoungMomsAssistant.Core.Models.DbModels.Baby", "Baby")
                        .WithMany()
                        .HasForeignKey("Baby_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YoungMomsAssistant.Core.Models.DbModels.UserBaby", b =>
                {
                    b.HasOne("YoungMomsAssistant.Core.Models.DbModels.Baby", "Baby")
                        .WithMany("Users")
                        .HasForeignKey("Baby_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("YoungMomsAssistant.Core.Models.DbModels.User", "User")
                        .WithMany("Babies")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
