﻿// <auto-generated />
using System;
using Education.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Education.DataLayer.Migrations
{
    [DbContext(typeof(EducationContext))]
    [Migration("20211020170602_RenameStudentTable")]
    partial class RenameStudentTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Education.DataLayer.Entities.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Caption")
                        .HasColumnType("text")
                        .HasColumnName("caption");

                    b.Property<Guid>("SpecialityId")
                        .HasColumnType("uuid")
                        .HasColumnName("speciality_id");

                    b.HasKey("Id");

                    b.HasIndex("SpecialityId");

                    b.ToTable("groups");
                });

            modelBuilder.Entity("Education.DataLayer.Entities.GroupRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Comment")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("comment");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uuid")
                        .HasColumnName("group_id");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("group_requests");
                });

            modelBuilder.Entity("Education.DataLayer.Entities.Speciality", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Caption")
                        .HasColumnType("text")
                        .HasColumnName("caption");

                    b.Property<short>("MonthsToStudy")
                        .HasColumnType("smallint")
                        .HasColumnName("months_to_study");

                    b.Property<string>("ShortCaption")
                        .HasColumnType("text")
                        .HasColumnName("short_caption");

                    b.Property<short>("YearsToStudy")
                        .HasColumnType("smallint")
                        .HasColumnName("years_to_study");

                    b.HasKey("Id");

                    b.ToTable("specialities");
                });

            modelBuilder.Entity("Education.DataLayer.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Firstname")
                        .HasColumnType("text")
                        .HasColumnName("firstname");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uuid")
                        .HasColumnName("group_id");

                    b.Property<bool>("IsGroupLeader")
                        .HasColumnType("boolean")
                        .HasColumnName("is_group_leader");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text")
                        .HasColumnName("patronymic");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uuid")
                        .HasColumnName("person_id");

                    b.Property<string>("Surname")
                        .HasColumnType("text")
                        .HasColumnName("surname");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("Education.DataLayer.Entities.Group", b =>
                {
                    b.HasOne("Education.DataLayer.Entities.Speciality", "Speciality")
                        .WithMany("Groups")
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("Education.DataLayer.Entities.GroupRequest", b =>
                {
                    b.HasOne("Education.DataLayer.Entities.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Education.DataLayer.Entities.Student", b =>
                {
                    b.HasOne("Education.DataLayer.Entities.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Education.DataLayer.Entities.Speciality", b =>
                {
                    b.Navigation("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
