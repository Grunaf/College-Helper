﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using app;

#nullable disable

namespace app.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240511190155_ChangeAttendanceFields")]
    partial class ChangeAttendanceFields
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("app.Models.SheduleDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<short>("CountWeek")
                        .HasColumnType("smallint");

                    b.Property<int?>("FirstSubjectId")
                        .HasColumnType("int");

                    b.Property<int?>("FourthSubjectId")
                        .HasColumnType("int");

                    b.Property<int?>("SecondSubjectId")
                        .HasColumnType("int");

                    b.Property<int?>("ThirdSubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FirstSubjectId");

                    b.HasIndex("FourthSubjectId");

                    b.HasIndex("SecondSubjectId");

                    b.HasIndex("ThirdSubjectId");

                    b.ToTable("Shedule");
                });

            modelBuilder.Entity("app.Models.StudentAttendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<byte>("NumberLesson")
                        .HasColumnType("tinyint unsigned");

                    b.Property<long>("StudentId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("StudentAttendances");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            NumberLesson = (byte)1,
                            StudentId = 1L
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            NumberLesson = (byte)2,
                            StudentId = 2L
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            NumberLesson = (byte)2,
                            StudentId = 3L
                        });
                });

            modelBuilder.Entity("app.Models.StudentGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CuratorId")
                        .HasColumnType("int");

                    b.Property<string>("Field")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("HeadBoyId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CuratorId");

                    b.HasIndex("HeadBoyId");

                    b.ToTable("StudentGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Field = "ИСП",
                            Number = 20
                        });
                });

            modelBuilder.Entity("app.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TypeSubject")
                        .HasColumnType("int");

                    b.Property<bool>("isExpired")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "МДК 01.01",
                            TypeSubject = 0,
                            isExpired = false
                        },
                        new
                        {
                            Id = 2,
                            Name = "МДК 01.03",
                            TypeSubject = 0,
                            isExpired = false
                        },
                        new
                        {
                            Id = 3,
                            Name = "МДК 01.04",
                            TypeSubject = 0,
                            isExpired = false
                        },
                        new
                        {
                            Id = 4,
                            Name = "МДК 01.05",
                            TypeSubject = 0,
                            isExpired = false
                        },
                        new
                        {
                            Id = 5,
                            Name = "МДК 11.01",
                            TypeSubject = 0,
                            isExpired = false
                        },
                        new
                        {
                            Id = 6,
                            Name = "МДК 01.01",
                            TypeSubject = 2,
                            isExpired = false
                        },
                        new
                        {
                            Id = 7,
                            Name = "МДК 01.03",
                            TypeSubject = 2,
                            isExpired = false
                        },
                        new
                        {
                            Id = 8,
                            Name = "МДК 01.04",
                            TypeSubject = 2,
                            isExpired = false
                        },
                        new
                        {
                            Id = 9,
                            Name = "МДК 01.05",
                            TypeSubject = 2,
                            isExpired = false
                        },
                        new
                        {
                            Id = 10,
                            Name = "МДК 11.01",
                            TypeSubject = 2,
                            isExpired = false
                        },
                        new
                        {
                            Id = 11,
                            Name = "Физ-ра",
                            TypeSubject = 0,
                            isExpired = false
                        },
                        new
                        {
                            Id = 12,
                            Name = "Иностранный язык",
                            TypeSubject = 0,
                            isExpired = false
                        },
                        new
                        {
                            Id = 13,
                            Name = "Безопасность Жизндеятельности",
                            TypeSubject = 0,
                            isExpired = false
                        },
                        new
                        {
                            Id = 14,
                            Name = "Экономика отросли",
                            TypeSubject = 0,
                            isExpired = false
                        });
                });

            modelBuilder.Entity("app.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("IdChat")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Patronymic")
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("StudentGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdChat")
                        .IsUnique();

                    b.HasIndex("StudentGroupId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdChat = 597239235L,
                            Name = "Микаил",
                            Patronymic = "Микаилович",
                            Role = "student",
                            StudentGroupId = 1,
                            Surname = "Микаилов"
                        },
                        new
                        {
                            Id = 2,
                            IdChat = 597239236L,
                            Name = "Алдан",
                            Patronymic = "Алданович",
                            Role = "student",
                            StudentGroupId = 1,
                            Surname = "Омардибиров"
                        },
                        new
                        {
                            Id = 3,
                            IdChat = 597239238L,
                            Name = "Магомед",
                            Patronymic = "Магомедович",
                            Role = "student",
                            StudentGroupId = 1,
                            Surname = "Магомедов"
                        },
                        new
                        {
                            Id = 4,
                            IdChat = 597239239L,
                            Name = "Дер",
                            Patronymic = "Дерович",
                            Role = "curator",
                            StudentGroupId = 1,
                            Surname = "Деров"
                        },
                        new
                        {
                            Id = 5,
                            IdChat = 597239240L,
                            Name = "Кер",
                            Patronymic = "Керович",
                            Role = "headboy",
                            StudentGroupId = 1,
                            Surname = "Керов"
                        });
                });

            modelBuilder.Entity("app.Models.SheduleDay", b =>
                {
                    b.HasOne("app.Models.Subject", "FirstSubject")
                        .WithMany()
                        .HasForeignKey("FirstSubjectId");

                    b.HasOne("app.Models.Subject", "FourthSubject")
                        .WithMany()
                        .HasForeignKey("FourthSubjectId");

                    b.HasOne("app.Models.Subject", "SecondSubject")
                        .WithMany()
                        .HasForeignKey("SecondSubjectId");

                    b.HasOne("app.Models.Subject", "ThirdSubject")
                        .WithMany()
                        .HasForeignKey("ThirdSubjectId");

                    b.Navigation("FirstSubject");

                    b.Navigation("FourthSubject");

                    b.Navigation("SecondSubject");

                    b.Navigation("ThirdSubject");
                });

            modelBuilder.Entity("app.Models.StudentGroup", b =>
                {
                    b.HasOne("app.Models.User", "Curator")
                        .WithMany()
                        .HasForeignKey("CuratorId");

                    b.HasOne("app.Models.User", "HeadBoy")
                        .WithMany()
                        .HasForeignKey("HeadBoyId");

                    b.Navigation("Curator");

                    b.Navigation("HeadBoy");
                });

            modelBuilder.Entity("app.Models.User", b =>
                {
                    b.HasOne("app.Models.StudentGroup", "StudentGroup")
                        .WithMany("Students")
                        .HasForeignKey("StudentGroupId");

                    b.Navigation("StudentGroup");
                });

            modelBuilder.Entity("app.Models.StudentGroup", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}