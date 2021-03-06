﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Seg.API.Data;

namespace Seg.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190612044650_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Seg.API.Models.Insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPFCNPJ");

                    b.Property<string>("IdAuto");

                    b.Property<string>("PolicyNumber");

                    b.Property<decimal>("PrizeValue");

                    b.HasKey("Id");

                    b.ToTable("Insurances");
                });
#pragma warning restore 612, 618
        }
    }
}
