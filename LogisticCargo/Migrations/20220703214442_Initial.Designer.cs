﻿// <auto-generated />
using System;
using LogisticСargo.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LogisticCargo.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220703214442_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LogisticСargo.Entities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DriverTable");
                });

            modelBuilder.Entity("LogisticСargo.Entities.DriverLicense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Engine")
                        .HasColumnType("float");

                    b.Property<string>("Mark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("No")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LicenseTable");
                });

            modelBuilder.Entity("LogisticСargo.Entities.MainCargoInfo", b =>
                {
                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<int>("LicenseId")
                        .HasColumnType("int");

                    b.HasKey("DriverId", "LicenseId");

                    b.HasIndex("LicenseId");

                    b.ToTable("Main", (string)null);
                });

            modelBuilder.Entity("LogisticСargo.Entities.MainCargoInfo", b =>
                {
                    b.HasOne("LogisticСargo.Entities.Driver", "Drivers")
                        .WithMany("MainCargo")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LogisticСargo.Entities.DriverLicense", "Licenses")
                        .WithMany("MainCargo")
                        .HasForeignKey("LicenseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drivers");

                    b.Navigation("Licenses");
                });

            modelBuilder.Entity("LogisticСargo.Entities.Driver", b =>
                {
                    b.Navigation("MainCargo");
                });

            modelBuilder.Entity("LogisticСargo.Entities.DriverLicense", b =>
                {
                    b.Navigation("MainCargo");
                });
#pragma warning restore 612, 618
        }
    }
}