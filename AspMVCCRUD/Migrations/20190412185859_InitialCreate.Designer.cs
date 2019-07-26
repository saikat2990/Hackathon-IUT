﻿// <auto-generated />
using System;
using AspMVCCRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspMVCCRUD.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20190412185859_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspMVCCRUD.Models.CourseTable", b =>
                {
                    b.Property<int>("courseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("coursename")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("coursetype")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("courseId");

                    b.ToTable("CourseTables");
                });

            modelBuilder.Entity("AspMVCCRUD.Models.runningCourse", b =>
                {
                    b.Property<int>("runningCourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TrainerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("numberOfClasses");

                    b.Property<string>("numberOfStudents");

                    b.Property<int>("price");

                    b.HasKey("runningCourseId");

                    b.ToTable("runningCourses");
                });

            modelBuilder.Entity("AspMVCCRUD.Models.RunningCoursesList", b =>
                {
                    b.Property<int>("RunningCoursesListId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<string>("TrainerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("trainerId");

                    b.HasKey("RunningCoursesListId");

                    b.ToTable("RunningCoursesLists");
                });

            modelBuilder.Entity("AspMVCCRUD.Models.StudentsList", b =>
                {
                    b.Property<int>("StudentsListId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DuePoints");

                    b.Property<int?>("RunningCoursesListId");

                    b.Property<int>("completeCourse");

                    b.Property<int>("courseId");

                    b.HasKey("StudentsListId");

                    b.HasIndex("RunningCoursesListId");

                    b.ToTable("StudentsLists");
                });

            modelBuilder.Entity("AspMVCCRUD.Models.TeachersList", b =>
                {
                    b.Property<int>("TeachersListId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RemainPoints");

                    b.Property<int>("completeCourse");

                    b.Property<int>("courseId");

                    b.HasKey("TeachersListId");

                    b.ToTable("TeachersLists");
                });

            modelBuilder.Entity("AspMVCCRUD.Models.TeachersOwnList", b =>
                {
                    b.Property<int>("TeachersOwnListId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberofClassPerCourses");

                    b.Property<int>("NumberofDoneClassPerCourses");

                    b.Property<int>("PickUpAmmount");

                    b.Property<int>("PointPerCourses");

                    b.Property<int>("completeCourse");

                    b.Property<int>("courseId");

                    b.HasKey("TeachersOwnListId");

                    b.ToTable("TeachersOwnLists");
                });

            modelBuilder.Entity("AspMVCCRUD.Models.TrainerReg", b =>
                {
                    b.Property<int>("trainerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardNum")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("c_Id");

                    b.Property<string>("courseName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("trainerId");

                    b.ToTable("TrainerRegs");
                });

            modelBuilder.Entity("AspMVCCRUD.Models.UserDoneCoursesInfo", b =>
                {
                    b.Property<int>("UserDoneCoursesInfoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DoneCourses")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TrainerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("courseId");

                    b.HasKey("UserDoneCoursesInfoId");

                    b.ToTable("UserDoneCoursesInfos");
                });

            modelBuilder.Entity("AspMVCCRUD.Models.UserLogIn", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("phnNumber")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("userId");

                    b.ToTable("UserLogIns");
                });

            modelBuilder.Entity("AspMVCCRUD.Models.UserRunningCoursesInfo", b =>
                {
                    b.Property<int>("UserRunningCoursesInfoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompleteClasses");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TrainerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("courseId");

                    b.Property<int>("remainingPoints");

                    b.HasKey("UserRunningCoursesInfoId");

                    b.ToTable("UserRunningCoursesInfos");
                });

            modelBuilder.Entity("AspMVCCRUD.Models.VideoList", b =>
                {
                    b.Property<int>("VideoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VideoField")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("VideoId");

                    b.ToTable("VideoLists");
                });

            modelBuilder.Entity("AspMVCCRUD.Models.StudentsList", b =>
                {
                    b.HasOne("AspMVCCRUD.Models.RunningCoursesList")
                        .WithMany("CurrentStudentsList")
                        .HasForeignKey("RunningCoursesListId");
                });
#pragma warning restore 612, 618
        }
    }
}
