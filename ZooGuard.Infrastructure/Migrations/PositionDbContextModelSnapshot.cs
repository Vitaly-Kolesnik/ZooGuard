﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZooGuard.Infrastructure;

namespace ZooGuard.Infrastructure.Migrations
{
    [DbContext(typeof(PositionDbContext))]
    partial class PositionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ZooGuard.Core.Entits.FormOfOccurence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("FormOfOccurences");
                });

            modelBuilder.Entity("ZooGuard.Core.Entits.Member", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("ZooGuard.Core.Entits.OwnerPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("OwnerPositions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entits.Position", b =>
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

                    b.Property<string>("NameFormOfOccurence")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NameOwnerPosition")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NameStatusLabel")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("NameUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.Property<bool>("RealityFlag")
                        .HasMaxLength(1)
                        .HasColumnType("bit");

                    b.Property<string>("RegistrationDocument")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("UserId");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entits.Role", b =>
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

            modelBuilder.Entity("ZooGuard.Core.Entits.StatusLabel.StatusLabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdStorage")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NameStorage")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("StatusLabels");
                });

            modelBuilder.Entity("ZooGuard.Core.Entits.StatusLabel.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("StatusLabelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StatusLabelId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("ZooGuard.Core.Entits.User", b =>
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

            modelBuilder.Entity("ZooGuard.Core.Entits.FormOfOccurence", b =>
                {
                    b.HasOne("ZooGuard.Core.Entits.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("ZooGuard.Core.Entits.Member", b =>
                {
                    b.HasOne("ZooGuard.Core.Entits.Role", "Role")
                        .WithMany("Members")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooGuard.Core.Entits.User", "User")
                        .WithMany("Members")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ZooGuard.Core.Entits.OwnerPosition", b =>
                {
                    b.HasOne("ZooGuard.Core.Entits.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("ZooGuard.Core.Entits.Position", b =>
                {
                    b.HasOne("ZooGuard.Core.Entits.Position", null)
                        .WithMany("Positions")
                        .HasForeignKey("PositionId");

                    b.HasOne("ZooGuard.Core.Entits.User", null)
                        .WithMany("Positions")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ZooGuard.Core.Entits.StatusLabel.StatusLabel", b =>
                {
                    b.HasOne("ZooGuard.Core.Entits.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("ZooGuard.Core.Entits.StatusLabel.Storage", b =>
                {
                    b.HasOne("ZooGuard.Core.Entits.StatusLabel.StatusLabel", "StatusLabel")
                        .WithMany()
                        .HasForeignKey("StatusLabelId");

                    b.Navigation("StatusLabel");
                });

            modelBuilder.Entity("ZooGuard.Core.Entits.Position", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entits.Role", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("ZooGuard.Core.Entits.User", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("Positions");
                });
#pragma warning restore 612, 618
        }
    }
}
