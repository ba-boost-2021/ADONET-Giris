﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tratel.Data;

#nullable disable

namespace Tratel.Data.Migrations
{
    [DbContext(typeof(TratelDbContext))]
    [Migration("20220326085709_PersonAndForeignKeys")]
    partial class PersonAndForeignKeys
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Tratel.Entities.Auth.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Phone")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("VerificationCode")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Users", "Auth");
                });

            modelBuilder.Entity("Tratel.Entities.Customer.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PartNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("Payments", "Customer");
                });

            modelBuilder.Entity("Tratel.Entities.Customer.Place", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Phone")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid>("TownId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TownId");

                    b.ToTable("Places", "Customer");
                });

            modelBuilder.Entity("Tratel.Entities.Customer.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AmountOfPople")
                        .HasColumnType("int");

                    b.Property<int>("ChildrenCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PlaceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Until")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations", "Customer");
                });

            modelBuilder.Entity("Tratel.Entities.Main.LookUp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("TypeId");

                    b.ToTable("LookUps", "Main");
                });

            modelBuilder.Entity("Tratel.Entities.Main.LookUpType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("LookUpTypes", "Main");
                });

            modelBuilder.Entity("Tratel.Entities.Customer.Payment", b =>
                {
                    b.HasOne("Tratel.Entities.Customer.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Tratel.Entities.Customer.Place", b =>
                {
                    b.HasOne("Tratel.Entities.Main.LookUp", "Town")
                        .WithMany()
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Town");
                });

            modelBuilder.Entity("Tratel.Entities.Customer.Reservation", b =>
                {
                    b.HasOne("Tratel.Entities.Customer.Place", "Place")
                        .WithMany()
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tratel.Entities.Auth.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Place");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Tratel.Entities.Main.LookUp", b =>
                {
                    b.HasOne("Tratel.Entities.Main.LookUp", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.HasOne("Tratel.Entities.Main.LookUpType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}
