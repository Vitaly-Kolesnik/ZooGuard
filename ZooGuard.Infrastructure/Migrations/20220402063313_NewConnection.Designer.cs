﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZooGuard.Infrastructure;

namespace ZooGuard.Infrastructure.Migrations
{
    [DbContext(typeof(PositionDbContext))]
    [Migration("20220402063313_NewConnection")]
    partial class NewConnection
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                            ConcurrencyStamp = "40518b04-1512-40a8-aee1-021911c94dac",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f634ab6c-f96f-49fc-b720-88d3b3fd07ab",
                            Email = "my@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MY@EMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAELZrB8zJ9P2cyf4OexIvWhW5IJ5CuGSuonTfXgAFO8AHLtVDJxf9PqTYQQWGNsnY1g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                            RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab"
                        });
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.InfoAboutPos.InformationAboutPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("InformationAboutPosition");

                    b.HasDiscriminator<string>("Discriminator").HasValue("InformationAboutPosition");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.MultipleConnections.SpecialitiesOfWorkers", b =>
                {
                    b.Property<int>("SpecialityWorkerId")
                        .HasColumnType("int");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("SpecialityWorkerId", "WorkerId");

                    b.HasIndex("WorkerId");

                    b.ToTable("SpecialitiesOfWorkers");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.MultipleConnections.WorkersInOrganisation", b =>
                {
                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.Property<int>("OrganisationId")
                        .HasColumnType("int");

                    b.HasKey("WorkerId", "OrganisationId");

                    b.HasIndex("OrganisationId");

                    b.ToTable("WorkersInOrganisations");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.MultipleConnections.WorkersInProject", b =>
                {
                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("WorkerId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("WorkersInProjects");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Organisation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Organisations");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkerId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganisationId");

                    b.HasIndex("WorkerId")
                        .IsUnique();

                    b.ToTable("Places");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountingNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("Date")
                        .HasMaxLength(15)
                        .HasColumnType("datetime2");

                    b.Property<int?>("FormOfOccurenceId")
                        .HasColumnType("int");

                    b.Property<string>("Information")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationDocument")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("ServerRoomId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusLabelId")
                        .HasColumnType("int");

                    b.Property<int?>("StorageId")
                        .HasColumnType("int");

                    b.Property<int>("VenderId")
                        .HasColumnType("int");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FormOfOccurenceId");

                    b.HasIndex("OrganisationId");

                    b.HasIndex("ServerRoomId");

                    b.HasIndex("StatusLabelId");

                    b.HasIndex("StorageId");

                    b.HasIndex("VenderId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("OrganisationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganisationId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.ServerRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActualAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Characteristic")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganisationId");

                    b.HasIndex("WorkerId");

                    b.ToTable("ServerRooms");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.SpecialityWorker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("SpecialityWorkers");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActualAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Characteristic")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganisationId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Vender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EmailRepresentative")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstNameRepresentative")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastNameRepresentative")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MailingAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneRepresentative")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Venders");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsResponsibilityServerRoom")
                        .HasColumnType("bit");

                    b.Property<bool>("IsResponsibilityStorage")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Patronymic")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.InfoAboutPos.FormOfOccurence", b =>
                {
                    b.HasBaseType("ZooGuard.Core.Entities.InfoAboutPos.InformationAboutPosition");

                    b.HasDiscriminator().HasValue("FormOfOccurence");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.InfoAboutPos.StatusLabel", b =>
                {
                    b.HasBaseType("ZooGuard.Core.Entities.InfoAboutPos.InformationAboutPosition");

                    b.HasDiscriminator().HasValue("StatusLabel");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.MultipleConnections.SpecialitiesOfWorkers", b =>
                {
                    b.HasOne("ZooGuard.Core.Entities.SpecialityWorker", "SpecialityWorker")
                        .WithMany("SpecialitiesOfWorkers")
                        .HasForeignKey("SpecialityWorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooGuard.Core.Entities.Worker", "Worker")
                        .WithMany("SpecialitiesOfWorkers")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SpecialityWorker");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.MultipleConnections.WorkersInOrganisation", b =>
                {
                    b.HasOne("ZooGuard.Core.Entities.Organisation", "Organisation")
                        .WithMany("WorkersInOrganisations")
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooGuard.Core.Entities.Worker", "Worker")
                        .WithMany("WorkersInOrganisations")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organisation");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.MultipleConnections.WorkersInProject", b =>
                {
                    b.HasOne("ZooGuard.Core.Entities.Project", "Project")
                        .WithMany("WorkersInProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooGuard.Core.Entities.Worker", "Worker")
                        .WithMany("WorkersInProjects")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Place", b =>
                {
                    b.HasOne("ZooGuard.Core.Entities.Organisation", "Organisation")
                        .WithMany("Places")
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooGuard.Core.Entities.Worker", "Worker")
                        .WithOne("Place")
                        .HasForeignKey("ZooGuard.Core.Entities.Place", "WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organisation");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Position", b =>
                {
                    b.HasOne("ZooGuard.Core.Entities.InfoAboutPos.FormOfOccurence", "FormOfOccurence")
                        .WithMany("Positions")
                        .HasForeignKey("FormOfOccurenceId");

                    b.HasOne("ZooGuard.Core.Entities.Organisation", "Organisation")
                        .WithMany("Positions")
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooGuard.Core.Entities.ServerRoom", "ServerRoom")
                        .WithMany("Positions")
                        .HasForeignKey("ServerRoomId");

                    b.HasOne("ZooGuard.Core.Entities.InfoAboutPos.StatusLabel", "StatusLabel")
                        .WithMany("Positions")
                        .HasForeignKey("StatusLabelId");

                    b.HasOne("ZooGuard.Core.Entities.Storage", "Storage")
                        .WithMany("Positions")
                        .HasForeignKey("StorageId");

                    b.HasOne("ZooGuard.Core.Entities.Vender", "Vender")
                        .WithMany("Positions")
                        .HasForeignKey("VenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooGuard.Core.Entities.Worker", "Worker")
                        .WithMany("Positions")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormOfOccurence");

                    b.Navigation("Organisation");

                    b.Navigation("ServerRoom");

                    b.Navigation("StatusLabel");

                    b.Navigation("Storage");

                    b.Navigation("Vender");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Project", b =>
                {
                    b.HasOne("ZooGuard.Core.Entities.Organisation", "Organisation")
                        .WithMany("Projects")
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organisation");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.ServerRoom", b =>
                {
                    b.HasOne("ZooGuard.Core.Entities.Organisation", "Organisation")
                        .WithMany("ServerRooms")
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooGuard.Core.Entities.Worker", "Worker")
                        .WithMany("ServerRooms")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organisation");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Storage", b =>
                {
                    b.HasOne("ZooGuard.Core.Entities.Organisation", "Organisation")
                        .WithMany("Storages")
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooGuard.Core.Entities.Worker", "Worker")
                        .WithMany("Storages")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organisation");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Organisation", b =>
                {
                    b.Navigation("Places");

                    b.Navigation("Positions");

                    b.Navigation("Projects");

                    b.Navigation("ServerRooms");

                    b.Navigation("Storages");

                    b.Navigation("WorkersInOrganisations");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Project", b =>
                {
                    b.Navigation("WorkersInProjects");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.ServerRoom", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.SpecialityWorker", b =>
                {
                    b.Navigation("SpecialitiesOfWorkers");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Storage", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Vender", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.Worker", b =>
                {
                    b.Navigation("Place");

                    b.Navigation("Positions");

                    b.Navigation("ServerRooms");

                    b.Navigation("SpecialitiesOfWorkers");

                    b.Navigation("Storages");

                    b.Navigation("WorkersInOrganisations");

                    b.Navigation("WorkersInProjects");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.InfoAboutPos.FormOfOccurence", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entities.InfoAboutPos.StatusLabel", b =>
                {
                    b.Navigation("Positions");
                });
#pragma warning restore 612, 618
        }
    }
}
