﻿// <auto-generated />
using G6.NetITIMVCDay04.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace G6.NetITIMVCDay04.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20240907063209_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("G6.NetITIMVCDay04.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "HR"
                        },
                        new
                        {
                            Id = 2,
                            Name = "PR"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Social Media"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 5,
                            Name = "SD"
                        });
                });

            modelBuilder.Entity("G6.NetITIMVCDay04.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Ismaila",
                            Age = 20,
                            DepartmentId = 1,
                            Email = "email@mail.com",
                            Name = "Ramy",
                            Salary = 1234m
                        },
                        new
                        {
                            Id = 2,
                            Address = "Ismaila",
                            Age = 25,
                            DepartmentId = 2,
                            Email = "email@mail.com",
                            Name = "Ali",
                            Salary = 2234m
                        },
                        new
                        {
                            Id = 3,
                            Address = "Ismaila",
                            Age = 30,
                            DepartmentId = 3,
                            Email = "email@mail.com",
                            Name = "Mohamed",
                            Salary = 3234m
                        },
                        new
                        {
                            Id = 4,
                            Address = "Ismaila",
                            Age = 35,
                            DepartmentId = 4,
                            Email = "email@mail.com",
                            Name = "Ahmed",
                            Salary = 4234m
                        },
                        new
                        {
                            Id = 5,
                            Address = "Ismaila",
                            Age = 40,
                            DepartmentId = 5,
                            Email = "email@mail.com",
                            Name = "Hala",
                            Salary = 5234m
                        },
                        new
                        {
                            Id = 6,
                            Address = "Ismaila",
                            Age = 45,
                            DepartmentId = 1,
                            Email = "email@mail.com",
                            Name = "Mai",
                            Salary = 6234m
                        },
                        new
                        {
                            Id = 7,
                            Address = "Ismaila",
                            Age = 50,
                            DepartmentId = 2,
                            Email = "email@mail.com",
                            Name = "Omar",
                            Salary = 7234m
                        },
                        new
                        {
                            Id = 8,
                            Address = "Ismaila",
                            Age = 55,
                            DepartmentId = 3,
                            Email = "email@mail.com",
                            Name = "Sara",
                            Salary = 8234m
                        },
                        new
                        {
                            Id = 9,
                            Address = "Ismaila",
                            Age = 30,
                            DepartmentId = 4,
                            Email = "email@mail.com",
                            Name = "Mostafa",
                            Salary = 9234m
                        },
                        new
                        {
                            Id = 10,
                            Address = "Ismaila",
                            Age = 40,
                            DepartmentId = 5,
                            Email = "email@mail.com",
                            Name = "Nour",
                            Salary = 10234m
                        });
                });

            modelBuilder.Entity("G6.NetITIMVCDay04.Models.Employee", b =>
                {
                    b.HasOne("G6.NetITIMVCDay04.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("G6.NetITIMVCDay04.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
