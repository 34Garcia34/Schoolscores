﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Schoolscores.Data;

#nullable disable

namespace Schoolscores.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211222051952_TestMigration")]
    partial class TestMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Schoolscores.Models.Examscores", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamId"), 1L, 1);

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TearcherId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Testscore")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ExamId");

                    b.ToTable("ExamScores");
                });

            modelBuilder.Entity("Schoolscores.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeachersTeacherId")
                        .HasColumnType("int");

                    b.Property<decimal>("examscore")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("StudentId");

                    b.HasIndex("TeachersTeacherId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Schoolscores.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Schoolscores.Models.Student", b =>
                {
                    b.HasOne("Schoolscores.Models.Teacher", "Teachers")
                        .WithMany()
                        .HasForeignKey("TeachersTeacherId");

                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
