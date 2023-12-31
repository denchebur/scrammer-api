﻿// <auto-generated />
using DAL.DatabaseContextDir;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20231012023420_try_to_fix2")]
    partial class try_to_fix2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Models.Board", b =>
                {
                    b.Property<int>("BoardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BoardId"));

                    b.Property<string>("BoardName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BoardId");

                    b.HasIndex("UserId");

                    b.ToTable("Boards");
                });

            modelBuilder.Entity("DAL.Models.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskId"));

                    b.Property<string>("TaskAddingDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskListId")
                        .HasColumnType("int");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskPriority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskId");

                    b.HasIndex("TaskListId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("DAL.Models.TaskList", b =>
                {
                    b.Property<int>("TaskListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskListId"));

                    b.Property<int>("BoardId")
                        .HasColumnType("int");

                    b.Property<string>("TaskListName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskListId");

                    b.HasIndex("BoardId");

                    b.ToTable("TaskLists");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAL.Models.Board", b =>
                {
                    b.HasOne("DAL.Models.User", "User")
                        .WithMany("Boards")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Boards_Users");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Models.Task", b =>
                {
                    b.HasOne("DAL.Models.TaskList", "TaskList")
                        .WithMany("Tasks")
                        .HasForeignKey("TaskListId")
                        .IsRequired()
                        .HasConstraintName("FK_Tasks_TaskLists");

                    b.Navigation("TaskList");
                });

            modelBuilder.Entity("DAL.Models.TaskList", b =>
                {
                    b.HasOne("DAL.Models.Board", "Board")
                        .WithMany("TaskLists")
                        .HasForeignKey("BoardId")
                        .IsRequired()
                        .HasConstraintName("FK_TaskLists_Boards");

                    b.Navigation("Board");
                });

            modelBuilder.Entity("DAL.Models.Board", b =>
                {
                    b.Navigation("TaskLists");
                });

            modelBuilder.Entity("DAL.Models.TaskList", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Navigation("Boards");
                });
#pragma warning restore 612, 618
        }
    }
}
