﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Module4HW5;

namespace Module4HW5.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210910070121_AddTable")]
    partial class AddTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Module4HW5.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            Country = "USA",
                            DateOfBirth = new DateTime(1943, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ivan",
                            LastName = "Kardan"
                        },
                        new
                        {
                            ClientId = 2,
                            Country = "USSR",
                            DateOfBirth = new DateTime(1993, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Yan",
                            LastName = "Gus"
                        },
                        new
                        {
                            ClientId = 3,
                            Country = "Italy",
                            DateOfBirth = new DateTime(1977, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Roberto",
                            LastName = "Ravioly"
                        },
                        new
                        {
                            ClientId = 4,
                            Country = "France",
                            DateOfBirth = new DateTime(2000, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Daniel",
                            LastName = "Taxi"
                        },
                        new
                        {
                            ClientId = 5,
                            Country = "England",
                            DateOfBirth = new DateTime(1934, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Tom",
                            LastName = "Dom"
                        });
                });

            modelBuilder.Entity("Module4HW5.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("HiredDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DateOfBirth = new DateTime(1961, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Tom",
                            HiredDate = new DateTime(1985, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Soyer",
                            OfficeId = 1,
                            TitleId = 1
                        },
                        new
                        {
                            EmployeeId = 2,
                            DateOfBirth = new DateTime(1993, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Avram",
                            HiredDate = new DateTime(2015, 8, 1, 11, 22, 1, 0, DateTimeKind.Unspecified),
                            LastName = "Linkoln",
                            OfficeId = 2,
                            TitleId = 2
                        });
                });

            modelBuilder.Entity("Module4HW5.EmployeeProject", b =>
                {
                    b.Property<int>("EmployeeProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartedDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeProjectId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeeProject");

                    b.HasData(
                        new
                        {
                            EmployeeProjectId = 1,
                            EmployeeId = 1,
                            ProjectId = 1,
                            Rate = 1000m,
                            StartedDate = new DateTime(1999, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeProjectId = 2,
                            EmployeeId = 2,
                            ProjectId = 2,
                            Rate = 2000m,
                            StartedDate = new DateTime(1777, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Module4HW5.Office", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("OfficeId");

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            OfficeId = 1,
                            Location = "USA",
                            Title = "USAOffice"
                        },
                        new
                        {
                            OfficeId = 2,
                            Location = "Russia",
                            Title = "RussiaOffice"
                        });
                });

            modelBuilder.Entity("Module4HW5.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartedDate")
                        .HasMaxLength(7)
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectId");

                    b.HasIndex("ClientId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Budget = 1234m,
                            ClientId = 1,
                            Name = "SomeProject1",
                            StartedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 2,
                            Budget = 412312m,
                            ClientId = 2,
                            Name = "SomeProject2",
                            StartedDate = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 3,
                            Budget = 123124m,
                            ClientId = 3,
                            Name = "SomeProject3",
                            StartedDate = new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 4,
                            Budget = 122231m,
                            ClientId = 4,
                            Name = "SomeProject4",
                            StartedDate = new DateTime(1991, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 5,
                            Budget = 131415m,
                            ClientId = 5,
                            Name = "SomeProject5",
                            StartedDate = new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Module4HW5.Title", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TitleId");

                    b.ToTable("Titles");

                    b.HasData(
                        new
                        {
                            TitleId = 1,
                            Name = "Developer"
                        },
                        new
                        {
                            TitleId = 2,
                            Name = "QA"
                        });
                });

            modelBuilder.Entity("Module4HW5.Employee", b =>
                {
                    b.HasOne("Module4HW5.Office", "Office")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Module4HW5.Title", "Title")
                        .WithMany("Employees")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Module4HW5.EmployeeProject", b =>
                {
                    b.HasOne("Module4HW5.Employee", "Employee")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Module4HW5.Project", "Project")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Module4HW5.Project", b =>
                {
                    b.HasOne("Module4HW5.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Module4HW5.Client", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Module4HW5.Employee", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("Module4HW5.Office", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Module4HW5.Project", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("Module4HW5.Title", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
