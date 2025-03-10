﻿// <auto-generated />
using System;
using Assignment03_EF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment_EF.Migrations
{
    [DbContext(typeof(ITI_Context))]
    [Migration("20250310004147_Relations")]
    partial class Relations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment03_EF.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<int>("Top_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Top_Id");

                    b.ToTable("Courses", (string)null);
                });

            modelBuilder.Entity("Assignment03_EF.Course_Inst", b =>
                {
                    b.Property<int>("inst_ID")
                        .HasColumnType("int");

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("evaluate")
                        .HasColumnType("int");

                    b.HasKey("inst_ID", "Course_ID");

                    b.HasIndex("Course_ID");

                    b.ToTable("course_Insts");
                });

            modelBuilder.Entity("Assignment03_EF.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2")
                        .HasAnnotation("DataType", "DateTime");

                    b.Property<int>("Ins_Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("DepartmentName");

                    b.HasKey("Id");

                    b.HasIndex("Ins_Id");

                    b.ToTable("Departments", (string)null);
                });

            modelBuilder.Entity("Assignment03_EF.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<double>("Bouns")
                        .HasColumnType("float");

                    b.Property<int>("Dept_Id")
                        .HasColumnType("int");

                    b.Property<double>("HourRate")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Instructors", (string)null);
                });

            modelBuilder.Entity("Assignment03_EF.Stud_Course", b =>
                {
                    b.Property<int>("stud_ID")
                        .HasColumnType("int");

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("stud_ID", "Course_ID");

                    b.HasIndex("Course_ID");

                    b.ToTable("stud_Courses");
                });

            modelBuilder.Entity("Assignment03_EF.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 100L);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Dept_Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.HasIndex("Dept_Id");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("Assignment03_EF.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Topics", (string)null);
                });

            modelBuilder.Entity("Assignment03_EF.Course", b =>
                {
                    b.HasOne("Assignment03_EF.Topic", "topic")
                        .WithMany("courses")
                        .HasForeignKey("Top_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("topic");
                });

            modelBuilder.Entity("Assignment03_EF.Course_Inst", b =>
                {
                    b.HasOne("Assignment03_EF.Course", "course")
                        .WithMany("course_Insts")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment03_EF.Instructor", "instructor")
                        .WithMany("course_Insts")
                        .HasForeignKey("inst_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");

                    b.Navigation("instructor");
                });

            modelBuilder.Entity("Assignment03_EF.Department", b =>
                {
                    b.HasOne("Assignment03_EF.Instructor", "instructor")
                        .WithMany("departments")
                        .HasForeignKey("Ins_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("instructor");
                });

            modelBuilder.Entity("Assignment03_EF.Stud_Course", b =>
                {
                    b.HasOne("Assignment03_EF.Course", "Course")
                        .WithMany("stud_Courses")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment03_EF.Student", "Student")
                        .WithMany("stud_Courses")
                        .HasForeignKey("stud_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Assignment03_EF.Student", b =>
                {
                    b.HasOne("Assignment03_EF.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("Dept_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Assignment03_EF.Course", b =>
                {
                    b.Navigation("course_Insts");

                    b.Navigation("stud_Courses");
                });

            modelBuilder.Entity("Assignment03_EF.Department", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Assignment03_EF.Instructor", b =>
                {
                    b.Navigation("course_Insts");

                    b.Navigation("departments");
                });

            modelBuilder.Entity("Assignment03_EF.Student", b =>
                {
                    b.Navigation("stud_Courses");
                });

            modelBuilder.Entity("Assignment03_EF.Topic", b =>
                {
                    b.Navigation("courses");
                });
#pragma warning restore 612, 618
        }
    }
}
