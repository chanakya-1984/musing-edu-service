﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Musing.Edu.Hostel.DataBase;

namespace Musing.Edu.Hostel.DataBase.Migrations
{
    [DbContext(typeof(HostelDbContext))]
    [Migration("20200420162623_updated rooms and bed domin objects")]
    partial class updatedroomsandbeddominobjects
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Musing.Edu.Hostel.Domain.Bed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Charge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ChargeOccurencePeriod")
                        .HasColumnType("int");

                    b.Property<int>("ChargeOccurencePeriodType")
                        .HasColumnType("int");

                    b.Property<bool>("IsOOccupantStaff")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOccupied")
                        .HasColumnType("bit");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Beds");
                });

            modelBuilder.Entity("Musing.Edu.Hostel.Domain.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BuildingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HostelSetupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HostelSetupId");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("Musing.Edu.Hostel.Domain.Floor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<string>("FloorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Floors");
                });

            modelBuilder.Entity("Musing.Edu.Hostel.Domain.HostelAndWardenRelations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HostelSetupId")
                        .HasColumnType("int");

                    b.Property<DateTime>("WardenAssignedEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WardenAssignedStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WardenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HostelSetupId");

                    b.HasIndex("WardenId");

                    b.ToTable("HostelAndWardenRelations");
                });

            modelBuilder.Entity("Musing.Edu.Hostel.Domain.HostelSetup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AllowedGender")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hostels");
                });

            modelBuilder.Entity("Musing.Edu.Hostel.Domain.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FloorId")
                        .HasColumnType("int");

                    b.Property<bool>("HasEmptyBeds")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfBeds")
                        .HasColumnType("int");

                    b.Property<string>("RoomName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FloorId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Musing.Edu.Hostel.Domain.Warden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CurrentStatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Wardens");
                });

            modelBuilder.Entity("Musing.Edu.Hostel.Domain.Bed", b =>
                {
                    b.HasOne("Musing.Edu.Hostel.Domain.Room", null)
                        .WithMany("BedCollection")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Musing.Edu.Hostel.Domain.Building", b =>
                {
                    b.HasOne("Musing.Edu.Hostel.Domain.HostelSetup", null)
                        .WithMany("BuildingCollection")
                        .HasForeignKey("HostelSetupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Musing.Edu.Hostel.Domain.Floor", b =>
                {
                    b.HasOne("Musing.Edu.Hostel.Domain.Building", null)
                        .WithMany("FloorCollection")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Musing.Edu.Hostel.Domain.HostelAndWardenRelations", b =>
                {
                    b.HasOne("Musing.Edu.Hostel.Domain.HostelSetup", null)
                        .WithMany("HostelAndWarden")
                        .HasForeignKey("HostelSetupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Musing.Edu.Hostel.Domain.Warden", null)
                        .WithMany("WardenAndHostelRelations")
                        .HasForeignKey("WardenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Musing.Edu.Hostel.Domain.Room", b =>
                {
                    b.HasOne("Musing.Edu.Hostel.Domain.Floor", null)
                        .WithMany("RoomCollection")
                        .HasForeignKey("FloorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
