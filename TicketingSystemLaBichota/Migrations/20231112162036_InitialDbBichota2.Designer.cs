﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketingSystemLaBichota.DAL;

#nullable disable

namespace TicketingSystemLaBichota.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20231112162036_InitialDbBichota2")]
    partial class InitialDbBichota2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TicketingSystemLaBichota.DAL.Entities.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EntranceGate")
                        .HasColumnType("int");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TicketId")
                        .IsUnique();

                    b.ToTable("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
