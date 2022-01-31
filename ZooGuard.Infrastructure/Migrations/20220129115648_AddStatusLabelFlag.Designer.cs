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
    [Migration("20220129115648_AddStatusLabelFlag")]
    partial class AddStatusLabelFlag
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ZooGuard.Core.Entites.FormOfOccurence", b =>
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

                    b.ToTable("FormOfOccurences");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.Member", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.OwnerPosition", b =>
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

                    b.ToTable("OwnerPositions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountingNumber")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<int?>("FormOfOccurenceId")
                        .HasColumnType("int");

                    b.Property<int>("IdFormOfOccurence")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("IdOwnerPosition")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("IdStatusLabel")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("Information")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("OwnerPositionId")
                        .HasColumnType("int");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.Property<bool>("RealityFlag")
                        .HasMaxLength(1)
                        .HasColumnType("bit");

                    b.Property<string>("RegistrationDocument")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("StatusLabelId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FormOfOccurenceId");

                    b.HasIndex("OwnerPositionId");

                    b.HasIndex("PositionId");

                    b.HasIndex("StatusLabelId");

                    b.HasIndex("UserId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.StatusLabel.StatusLabelPos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AtTheUserFlag")
                        .HasMaxLength(1)
                        .HasColumnType("bit");

                    b.Property<int>("IdStorage")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("StorageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StorageId");

                    b.ToTable("StatusLabels");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.StatusLabel.Storage", b =>
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

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.Member", b =>
                {
                    b.HasOne("ZooGuard.Core.Entites.Role", "Role")
                        .WithMany("Members")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooGuard.Core.Entites.User", "User")
                        .WithMany("Members")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.Position", b =>
                {
                    b.HasOne("ZooGuard.Core.Entites.FormOfOccurence", "FormOfOccurence")
                        .WithMany("Positions")
                        .HasForeignKey("FormOfOccurenceId");

                    b.HasOne("ZooGuard.Core.Entites.OwnerPosition", "OwnerPosition")
                        .WithMany("Positions")
                        .HasForeignKey("OwnerPositionId");

                    b.HasOne("ZooGuard.Core.Entites.Position", null)
                        .WithMany("Positions")
                        .HasForeignKey("PositionId");

                    b.HasOne("ZooGuard.Core.Entites.StatusLabel.StatusLabelPos", "StatusLabel")
                        .WithMany("Positions")
                        .HasForeignKey("StatusLabelId");

                    b.HasOne("ZooGuard.Core.Entites.User", "User")
                        .WithMany("Positions")
                        .HasForeignKey("UserId");

                    b.Navigation("FormOfOccurence");

                    b.Navigation("OwnerPosition");

                    b.Navigation("StatusLabel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.StatusLabel.StatusLabelPos", b =>
                {
                    b.HasOne("ZooGuard.Core.Entites.StatusLabel.Storage", "Storage")
                        .WithMany("StatusLabels")
                        .HasForeignKey("StorageId");

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.FormOfOccurence", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.OwnerPosition", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.Position", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.Role", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.StatusLabel.StatusLabelPos", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.StatusLabel.Storage", b =>
                {
                    b.Navigation("StatusLabels");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.User", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("Positions");
                });
#pragma warning restore 612, 618
        }
    }
}
