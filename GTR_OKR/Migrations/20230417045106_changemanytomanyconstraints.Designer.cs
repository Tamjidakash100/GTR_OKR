﻿// <auto-generated />
using System;
using System.Collections.Generic;
using GTR_OKR.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GTR_OKR.Migrations
{
    [DbContext(typeof(OkrDbContext))]
    [Migration("20230417045106_changemanytomanyconstraints")]
    partial class changemanytomanyconstraints
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GTR_OKR.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ComId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("GTR_OKR.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ComId")
                        .HasColumnType("integer");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ComId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("GTR_OKR.Models.ProjTempRelation", b =>
                {
                    b.Property<int>("PId")
                        .HasColumnType("integer");

                    b.Property<int>("TempId")
                        .HasColumnType("integer");

                    b.HasKey("PId", "TempId");

                    b.HasIndex("TempId");

                    b.ToTable("ProjTempRelation");
                });

            modelBuilder.Entity("GTR_OKR.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ComId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DeptId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EstDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<int>("Progress")
                        .HasColumnType("integer");

                    b.Property<List<string>>("Tags")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<int>("TempId")
                        .HasColumnType("integer");

                    b.Property<int>("UndId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ComId");

                    b.HasIndex("DeptId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("UndId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("GTR_OKR.Models.Tasks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EstimatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PId")
                        .HasColumnType("integer");

                    b.Property<int>("TempId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PId");

                    b.HasIndex("TempId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("GTR_OKR.Models.Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("GTR_OKR.Models.Understanding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Understandings");
                });

            modelBuilder.Entity("GTR_OKR.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ComId")
                        .HasColumnType("integer");

                    b.Property<int>("DeptId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ComId");

                    b.HasIndex("DeptId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GTR_OKR.Models.UserProjectAssign", b =>
                {
                    b.Property<int>("PId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("PId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserProjectAssign");
                });

            modelBuilder.Entity("GTR_OKR.Models.UserTaskAssign", b =>
                {
                    b.Property<int>("TaskId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("TaskId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserTaskAssign");
                });

            modelBuilder.Entity("GTR_OKR.Models.UserTempAssign", b =>
                {
                    b.Property<int>("TempId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("TempId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserTempAssign");
                });

            modelBuilder.Entity("GTR_OKR.Models.Department", b =>
                {
                    b.HasOne("GTR_OKR.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("ComId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("GTR_OKR.Models.ProjTempRelation", b =>
                {
                    b.HasOne("GTR_OKR.Models.Template", "Template")
                        .WithMany("PTemplates")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GTR_OKR.Models.Project", "Project")
                        .WithMany("PTemplates")
                        .HasForeignKey("TempId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Template");
                });

            modelBuilder.Entity("GTR_OKR.Models.Project", b =>
                {
                    b.HasOne("GTR_OKR.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("ComId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GTR_OKR.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GTR_OKR.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GTR_OKR.Models.Understanding", "Understanding")
                        .WithMany()
                        .HasForeignKey("UndId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Department");

                    b.Navigation("Owner");

                    b.Navigation("Understanding");
                });

            modelBuilder.Entity("GTR_OKR.Models.Tasks", b =>
                {
                    b.HasOne("GTR_OKR.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GTR_OKR.Models.Template", "Template")
                        .WithMany("Tasks")
                        .HasForeignKey("TempId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Template");
                });

            modelBuilder.Entity("GTR_OKR.Models.Template", b =>
                {
                    b.HasOne("GTR_OKR.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("GTR_OKR.Models.User", b =>
                {
                    b.HasOne("GTR_OKR.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("ComId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GTR_OKR.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("GTR_OKR.Models.UserProjectAssign", b =>
                {
                    b.HasOne("GTR_OKR.Models.User", "User")
                        .WithMany("UserProjects")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GTR_OKR.Models.Project", "Project")
                        .WithMany("UserProjects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GTR_OKR.Models.UserTaskAssign", b =>
                {
                    b.HasOne("GTR_OKR.Models.User", "User")
                        .WithMany("UserTasks")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GTR_OKR.Models.Tasks", "Task")
                        .WithMany("UserTasks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GTR_OKR.Models.UserTempAssign", b =>
                {
                    b.HasOne("GTR_OKR.Models.User", "User")
                        .WithMany("UserTemps")
                        .HasForeignKey("TempId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GTR_OKR.Models.Template", "Template")
                        .WithMany("UserTemps")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Template");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GTR_OKR.Models.Project", b =>
                {
                    b.Navigation("PTemplates");

                    b.Navigation("UserProjects");
                });

            modelBuilder.Entity("GTR_OKR.Models.Tasks", b =>
                {
                    b.Navigation("UserTasks");
                });

            modelBuilder.Entity("GTR_OKR.Models.Template", b =>
                {
                    b.Navigation("PTemplates");

                    b.Navigation("Tasks");

                    b.Navigation("UserTemps");
                });

            modelBuilder.Entity("GTR_OKR.Models.User", b =>
                {
                    b.Navigation("UserProjects");

                    b.Navigation("UserTasks");

                    b.Navigation("UserTemps");
                });
#pragma warning restore 612, 618
        }
    }
}
