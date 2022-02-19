﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchedulerWebApi.Data;

#nullable disable

namespace SchedulerWebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220218144201_EmployeeTableCreate")]
    partial class EmployeeTableCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchedulerWebApi.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SchedulerWebApi.Models.EmployeeDefaultWeek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Friday")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Monday")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Saturday")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sunday")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thursday")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tuesday")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wednesday")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeesDefaultWeeks");
                });

            modelBuilder.Entity("SchedulerWebApi.Models.EmployeeMonth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Day_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_17")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_18")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_19")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_20")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_21")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_22")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_23")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_24")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_25")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_26")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_27")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_28")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_29")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_30")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_31")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeesMonths");
                });

            modelBuilder.Entity("SchedulerWebApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SchedulerWebApi.Models.EmployeeDefaultWeek", b =>
                {
                    b.HasOne("SchedulerWebApi.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("SchedulerWebApi.Models.EmployeeMonth", b =>
                {
                    b.HasOne("SchedulerWebApi.Models.Employee", "Employee")
                        .WithMany("Months")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("SchedulerWebApi.Models.Employee", b =>
                {
                    b.Navigation("Months");
                });
#pragma warning restore 612, 618
        }
    }
}
