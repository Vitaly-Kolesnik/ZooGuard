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

            modelBuilder.Entity("ZooGuard.Core.Entites.InfoAboutPos.InformationAboutPosition", b =>
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
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("InformationAboutPositions");

                    b.HasDiscriminator<string>("Discriminator").HasValue("InformationAboutPosition");
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

                    b.Property<int>("IdInformationAboutPosition")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
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

                    b.Property<int?>("StorageId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FormOfOccurenceId");

                    b.HasIndex("OwnerPositionId");

                    b.HasIndex("PositionId");

                    b.HasIndex("StatusLabelId");

                    b.HasIndex("StorageId");

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

            modelBuilder.Entity("ZooGuard.Core.Entites.InfoAboutPos.FormOfOccurence", b =>
                {
                    b.HasBaseType("ZooGuard.Core.Entites.InfoAboutPos.InformationAboutPosition");

                    b.HasDiscriminator().HasValue("FormOfOccurence");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.InfoAboutPos.OwnerPosition", b =>
                {
                    b.HasBaseType("ZooGuard.Core.Entites.InfoAboutPos.InformationAboutPosition");

                    b.HasDiscriminator().HasValue("OwnerPosition");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.InfoAboutPos.StatusLabelPos", b =>
                {
                    b.HasBaseType("ZooGuard.Core.Entites.InfoAboutPos.InformationAboutPosition");

                    b.HasDiscriminator().HasValue("StatusLabelPos");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.InfoAboutPos.Storage", b =>
                {
                    b.HasBaseType("ZooGuard.Core.Entites.InfoAboutPos.InformationAboutPosition");

                    b.HasDiscriminator().HasValue("Storage");
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
                    b.HasOne("ZooGuard.Core.Entites.InfoAboutPos.FormOfOccurence", "FormOfOccurence")
                        .WithMany("Positions")
                        .HasForeignKey("FormOfOccurenceId");

                    b.HasOne("ZooGuard.Core.Entites.InfoAboutPos.OwnerPosition", "OwnerPosition")
                        .WithMany("Positions")
                        .HasForeignKey("OwnerPositionId");

                    b.HasOne("ZooGuard.Core.Entites.Position", null)
                        .WithMany("Positions")
                        .HasForeignKey("PositionId");

                    b.HasOne("ZooGuard.Core.Entites.InfoAboutPos.StatusLabelPos", "StatusLabel")
                        .WithMany("Positions")
                        .HasForeignKey("StatusLabelId");

                    b.HasOne("ZooGuard.Core.Entites.InfoAboutPos.Storage", "Storage")
                        .WithMany("Positions")
                        .HasForeignKey("StorageId");

                    b.HasOne("ZooGuard.Core.Entites.User", "User")
                        .WithMany("Positions")
                        .HasForeignKey("UserId");

                    b.Navigation("FormOfOccurence");

                    b.Navigation("OwnerPosition");

                    b.Navigation("StatusLabel");

                    b.Navigation("Storage");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.Position", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.Role", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.User", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.InfoAboutPos.FormOfOccurence", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.InfoAboutPos.OwnerPosition", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.InfoAboutPos.StatusLabelPos", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("ZooGuard.Core.Entites.InfoAboutPos.Storage", b =>
                {
                    b.Navigation("Positions");
                });
#pragma warning restore 612, 618
        }
    }
}
