﻿// <auto-generated />
using System;
using EmployeeManagementSystemDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagementSystemDbContext.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagementSystem.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Contact")
                        .HasMaxLength(50);

                    b.Property<int>("Department");

                    b.Property<int>("Designation");

                    b.Property<int>("EManagerId")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("JoinDate");

                    b.Property<decimal>("WageRate");

                    b.HasKey("EmpId")
                        .HasName("PK_DbEmployees");

                    b.ToTable("DbEmployees");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("EmpId");

                    b.Property<DateTime>("TransactionDate");

                    b.Property<int>("TypeOfTransaction");

                    b.HasKey("TransactionId")
                        .HasName("PK_DbTransactions");

                    b.HasIndex("EmpId");

                    b.ToTable("DbTransactions");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Transaction", b =>
                {
                    b.HasOne("EmployeeManagementSystem.Employee", "Employee")
                        .WithMany("Transactions")
                        .HasForeignKey("EmpId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
