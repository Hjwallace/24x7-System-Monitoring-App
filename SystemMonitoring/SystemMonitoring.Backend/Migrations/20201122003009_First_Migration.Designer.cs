﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SystemMonitoring.Backend.Data;

namespace SystemMonitoring.Backend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201122003009_First_Migration")]
    partial class First_Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SystemMonitoring.Backend.Models.TestForHangfire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Job")
                        .HasColumnType("text");

                    b.Property<string>("RunTime")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TestForHangfire");
                });
#pragma warning restore 612, 618
        }
    }
}
