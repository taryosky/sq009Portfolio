﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQ009Portfolio.Data;

namespace SQ009Portfolio.Data.Migrations
{
    [DbContext(typeof(PortfolioContext))]
    [Migration("20211015002523_addProjectUrlToProjectTable")]
    partial class addProjectUrlToProjectTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("SQ009Portfolio.Data.Models.ApiKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("APIKeys");
                });

            modelBuilder.Entity("SQ009Portfolio.Data.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SQ009Portfolio.Data.Models.EducationHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DegreeOptained")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("InstitutionName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("EducationHistories");
                });

            modelBuilder.Entity("SQ009Portfolio.Data.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateSent")
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("SQ009Portfolio.Data.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("SQ009Portfolio.Data.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("SQ009Portfolio.Data.Models.WorkHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Organization")
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("WorkHistories");
                });

            modelBuilder.Entity("SQ009Portfolio.Data.Models.ApiKey", b =>
                {
                    b.HasOne("SQ009Portfolio.Data.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("SQ009Portfolio.Data.Models.EducationHistory", b =>
                {
                    b.HasOne("SQ009Portfolio.Data.Models.AppUser", "AppUser")
                        .WithMany("EducationHistory")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("SQ009Portfolio.Data.Models.Message", b =>
                {
                    b.HasOne("SQ009Portfolio.Data.Models.AppUser", "AppUser")
                        .WithMany("Messages")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("SQ009Portfolio.Data.Models.Project", b =>
                {
                    b.HasOne("SQ009Portfolio.Data.Models.AppUser", "AppUser")
                        .WithMany("Projects")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("SQ009Portfolio.Data.Models.Skill", b =>
                {
                    b.HasOne("SQ009Portfolio.Data.Models.AppUser", "AppUser")
                        .WithMany("Skills")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("SQ009Portfolio.Data.Models.WorkHistory", b =>
                {
                    b.HasOne("SQ009Portfolio.Data.Models.AppUser", "AppUser")
                        .WithMany("WorkHistory")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("SQ009Portfolio.Data.Models.AppUser", b =>
                {
                    b.Navigation("EducationHistory");

                    b.Navigation("Messages");

                    b.Navigation("Projects");

                    b.Navigation("Skills");

                    b.Navigation("WorkHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
