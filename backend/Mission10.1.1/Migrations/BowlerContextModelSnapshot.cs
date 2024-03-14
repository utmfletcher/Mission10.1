﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission10._1._1.Data;

#nullable disable

namespace Mission10._1._1.Migrations
{
    [DbContext(typeof(BowlerContext))]
    partial class BowlerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Mission10._1._1.Data.Bowlers", b =>
                {
                    b.Property<int>("BowlerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BowlerAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerCity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerFirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerLastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerMiddleInit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerPhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerState")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerZip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BowlerID");

                    b.ToTable("Bowlers");
                });
#pragma warning restore 612, 618
        }
    }
}
