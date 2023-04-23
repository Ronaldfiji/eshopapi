﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataModel.Migrations
{
    /// <inheritdoc />
    public partial class init23042023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SchoolApi");

            migrationBuilder.EnsureSchema(
                name: "EShopDb");

            migrationBuilder.CreateTable(
                name: "CartItem",
                schema: "EShopDb",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "EShopDb",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "EShopDb",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    State = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                schema: "EShopDb",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentsType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalDue = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    TotalReceived = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    CashOut = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    PaymentRef = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSuccess = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductUnit",
                schema: "EShopDb",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUnit", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Promotion",
                schema: "EShopDb",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    DiscountValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Staus = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "SchoolApi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "School",
                schema: "SchoolApi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    District = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SchoolYear",
                schema: "SchoolApi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolYear", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                schema: "SchoolApi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReferenceBook = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                schema: "EShopDb",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Term",
                schema: "SchoolApi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchTerm = table.Column<int>(type: "int", nullable: false),
                    TermName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Term", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                schema: "SchoolApi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClassRoom",
                schema: "SchoolApi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    SchoolYearId = table.Column<int>(type: "int", nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRoom", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClassRoom_SchoolYear_SchoolYearId",
                        column: x => x.SchoolYearId,
                        principalSchema: "SchoolApi",
                        principalTable: "SchoolYear",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassRoom_School_SchoolId",
                        column: x => x.SchoolId,
                        principalSchema: "SchoolApi",
                        principalTable: "School",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                schema: "SchoolApi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SchoolYearId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Course_SchoolYear_SchoolYearId",
                        column: x => x.SchoolYearId,
                        principalSchema: "SchoolApi",
                        principalTable: "SchoolYear",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "SchoolApi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    State = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserTypeID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_UserType_UserTypeID",
                        column: x => x.UserTypeID,
                        principalSchema: "SchoolApi",
                        principalTable: "UserType",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CourseSubject",
                schema: "SchoolApi",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSubject", x => new { x.CourseId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_CourseSubject_Course_CourseId",
                        column: x => x.CourseId,
                        principalSchema: "SchoolApi",
                        principalTable: "Course",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseSubject_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalSchema: "SchoolApi",
                        principalTable: "Subject",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prerequisite",
                schema: "SchoolApi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    PrerequisiteCourseId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prerequisite", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Prerequisite_Course_CourseID",
                        column: x => x.CourseID,
                        principalSchema: "SchoolApi",
                        principalTable: "Course",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assessment",
                schema: "SchoolApi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    TermID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Assessment_Subject_SubjectID",
                        column: x => x.SubjectID,
                        principalSchema: "SchoolApi",
                        principalTable: "Subject",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assessment_Term_TermID",
                        column: x => x.TermID,
                        principalSchema: "SchoolApi",
                        principalTable: "Term",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Assessment_User_UserID",
                        column: x => x.UserID,
                        principalSchema: "SchoolApi",
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Enroll",
                schema: "SchoolApi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateEnrolment = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCompleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateWithdrawal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Passed = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enroll", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Enroll_Course_CourseId",
                        column: x => x.CourseId,
                        principalSchema: "SchoolApi",
                        principalTable: "Course",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enroll_School_SchoolId",
                        column: x => x.SchoolId,
                        principalSchema: "SchoolApi",
                        principalTable: "School",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enroll_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "SchoolApi",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "EShopDb",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: true),
                    ProductUnitID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    IsOnPromotion = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalSchema: "EShopDb",
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ProductUnit_ProductUnitID",
                        column: x => x.ProductUnitID,
                        principalSchema: "EShopDb",
                        principalTable: "ProductUnit",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Product_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalSchema: "EShopDb",
                        principalTable: "Supplier",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Product_User_UserID",
                        column: x => x.UserID,
                        principalSchema: "SchoolApi",
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                schema: "SchoolApi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JwtId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    IsRevorked = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "SchoolApi",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPictures",
                schema: "SchoolApi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPictures", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserPictures_User_AppUserID",
                        column: x => x.AppUserID,
                        principalSchema: "SchoolApi",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                schema: "SchoolApi",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "SchoolApi",
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "SchoolApi",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Score",
                schema: "SchoolApi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnrollmentID = table.Column<int>(type: "int", nullable: false),
                    AssessmentID = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    Grade = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: true),
                    AssessmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssessedBy = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Score_Assessment_AssessmentID",
                        column: x => x.AssessmentID,
                        principalSchema: "SchoolApi",
                        principalTable: "Assessment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Score_Enroll_EnrollmentID",
                        column: x => x.EnrollmentID,
                        principalSchema: "SchoolApi",
                        principalTable: "Enroll",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                schema: "EShopDb",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductImage_Product_ProductID",
                        column: x => x.ProductID,
                        principalSchema: "EShopDb",
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPromotion",
                schema: "EShopDb",
                columns: table => new
                {
                    productID = table.Column<int>(type: "int", nullable: false),
                    promotionsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPromotion", x => new { x.productID, x.promotionsID });
                    table.ForeignKey(
                        name: "FK_ProductPromotion_Product_productID",
                        column: x => x.productID,
                        principalSchema: "EShopDb",
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPromotion_Promotion_promotionsID",
                        column: x => x.promotionsID,
                        principalSchema: "EShopDb",
                        principalTable: "Promotion",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "EShopDb",
                table: "Category",
                columns: new[] { "ID", "Code", "CreatedBy", "CreatedDate", "Description", "IPAddress", "Icon", "ModifiedDate", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "CAT0001", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5739), "Head Phones Category", "255.255.255.1", "fa fa-headphones", null, "Head Phones and Ear Phones", "" },
                    { 2, "CAT0002", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5741), "Computers & Tablets Category", "255.255.255.1", "fa fa-desktop", null, "Computers & Tablets", "" },
                    { 3, "CAT0003", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5742), "Phones & Wearables Category", "255.255.255.1", "fa fa-desktop", null, "Phones & Wearables", "" },
                    { 4, "CAT0004", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5743), "TV, Blu-ray & Home Theatre Category", "255.255.255.1", "fa fa-desktop", null, "TV, Blu-ray & Home Theatre", "" },
                    { 5, "CAT0005", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5744), "Kitchen appliance Category", "255.255.255.1", "fa fa-desktop", null, "Kitchen Appliance", "" },
                    { 6, "CAT0006", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5745), "Cattle & Sheep Category", "255.255.255.1", "fa fa-desktop", null, "Cattle & Sheep", "" },
                    { 7, "CAT0007", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5746), "Items under fashion and jewelry", "255.255.255.1", "fa fa-desktop", null, "Fashion & Jewelry", "" }
                });

            migrationBuilder.InsertData(
                schema: "EShopDb",
                table: "ProductUnit",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "IPAddress", "ModifiedDate", "Name", "Unit", "UpdatedBy", "Weight" },
                values: new object[,]
                {
                    { 1, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5786), "255.255.255.1", null, "Kilogram", "Kilogram", "", 100f },
                    { 2, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5787), "255.255.255.1", null, "Liter", "Litre", "", 1000f },
                    { 3, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5788), "255.255.255.1", null, "Meter", "Meter", "", 5.5f }
                });

            migrationBuilder.InsertData(
                schema: "SchoolApi",
                table: "Role",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Description", "IPAddress", "ModifiedDate", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 4, 23, 20, 40, 16, 156, DateTimeKind.Utc).AddTicks(7355), "User role", "", null, "User", "" },
                    { 2, "", new DateTime(2023, 4, 23, 20, 40, 16, 156, DateTimeKind.Utc).AddTicks(7386), "Admin role", "", null, "Admin", "" },
                    { 3, "", new DateTime(2023, 4, 23, 20, 40, 16, 156, DateTimeKind.Utc).AddTicks(7393), "HOD role", "", null, "HOD", "" },
                    { 4, "", new DateTime(2023, 4, 23, 20, 40, 16, 156, DateTimeKind.Utc).AddTicks(7398), "Manager role", "", null, "Manager", "" },
                    { 5, "", new DateTime(2023, 4, 23, 20, 40, 16, 156, DateTimeKind.Utc).AddTicks(7403), "Director role", "", null, "Director", "" },
                    { 6, "", new DateTime(2023, 4, 23, 20, 40, 16, 156, DateTimeKind.Utc).AddTicks(7409), "Seller role", "", null, "Seller", "" }
                });

            migrationBuilder.InsertData(
                schema: "SchoolApi",
                table: "School",
                columns: new[] { "ID", "Address", "City", "Code", "CreatedBy", "CreatedDate", "Description", "District", "Email", "IPAddress", "ModifiedDate", "Name", "Phone", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Kings Road", "Tavua", "SS1230", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5078), "School details", "Ba", "tc@mail.com", "255.255.255.1", null, "Tavua College", "9988998", "" },
                    { 2, "Kings Road", "Tavua", "SS1231", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5081), "School details", "Vatukoula", "nh@mail.com", "255.255.255.1", null, "Nelson High", "7458785", "" },
                    { 3, "Drasas Avenue", "Lautoka", "SS1232", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5082), "School details", "Ba", "cc@mail.com", "255.255.255.1", null, "Central College", "8458785", "" },
                    { 4, "Yaralevu", "Ba", "SS1235", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5084), "School details", "Ba", "xc@mail.com", "255.255.255.89", null, "Xavier College", "7788990", "" }
                });

            migrationBuilder.InsertData(
                schema: "SchoolApi",
                table: "SchoolYear",
                columns: new[] { "ID", "Code", "CreatedBy", "CreatedDate", "Description", "IPAddress", "ModifiedDate", "UpdatedBy", "Year" },
                values: new object[,]
                {
                    { 1, "Y01", "RonaldAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5125), "This is year 1 student", "20.36.323.366", null, "", 1 },
                    { 2, "Y02", "RonaldAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5126), "This is year 2 student", "20.36.323.366", null, "", 2 },
                    { 3, "Y03", "RonaldAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5127), "This is year 3 student", "20.36.323.366", null, "", 3 },
                    { 4, "Y04", "RonaldAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5128), "This is year 4 student", "20.36.323.366", null, "", 4 },
                    { 5, "Y05", "RonaldAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5149), "This is year 5 student", "20.36.323.366", null, "", 5 },
                    { 6, "Y06", "RonaldAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5150), "This is year 6 student", "20.36.323.366", null, "", 6 },
                    { 7, "Y07", "RonaldAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5151), "This is year 7 student", "20.36.323.366", null, "", 7 },
                    { 8, "Y08", "RonaldAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5152), "This is year 8 student", "20.36.323.366", null, "", 8 },
                    { 9, "Y09", "RonaldAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5153), "This is year 9 student", "20.36.323.366", null, "", 9 },
                    { 10, "Y10", "RonaldAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5154), "This is year 10 student", "20.36.323.366", null, "", 10 },
                    { 11, "Y11", "RonaldAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5155), "This is year 11 student", "20.36.323.366", null, "", 11 },
                    { 12, "Y12", "RonaldAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5156), "This is year 12 student", "20.36.323.366", null, "", 12 },
                    { 13, "Y13", "RonaldAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5157), "This is year 13 student", "20.36.323.366", null, "", 13 }
                });

            migrationBuilder.InsertData(
                schema: "SchoolApi",
                table: "Subject",
                columns: new[] { "ID", "Code", "CreatedBy", "CreatedDate", "Description", "IPAddress", "ModifiedDate", "Name", "ReferenceBook", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Y11BIO", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5499), "Year 11 Biology", "255.255.255.1", null, "Biology, Year 11", "Molecular Biology", "RonAdmin" },
                    { 2, "Y12ENG", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5502), "English for Year 12", "255.255.255.1", null, "English, Year 12", "Peoples English 1", "RonAdmin" },
                    { 3, "Y11MAT", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5503), "Year 11 Mathmatics", "255.255.255.1", null, "Mathmatics, Year 11", "Calculus 1", "RonAdmin" },
                    { 4, "Y11CHM", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5505), "Year 11 Chemistry", "255.255.255.1", null, "Chemistry, Year 11", "Atmosphere and Reaction", "RonAdmin" },
                    { 5, "Y09MAT", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5506), "Year 09 Mathmatics", "255.255.255.1", null, "Mathmatics, Year 09", "Linear Algebra", "RonAdmin" },
                    { 6, "Y09ENG", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5508), "Year 09 English", "255.255.255.1", null, "English, Year 09", "Peoples English", "RonAdmin" },
                    { 7, "Y09BSC", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5509), "Year 09 Basic Science", "255.255.255.1", null, "Basic Science, Year 09", "Air and Water density", "RonAdmin" },
                    { 8, "Y09TD", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5514), "Year 09 Technical Drawing", "255.255.255.1", null, "Technical Drawing, Year 09", "Basic Auto cad by Ron Fiji", "RonAdmin" },
                    { 9, "Y09AGS", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5516), "Year 09 Agriculture Science", "255.255.255.1", null, "Agriculture Science, Year 09", "Plant hoticulture", "RonAdmin" },
                    { 10, "Y09ACC", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5517), "Year 09 Accounting", "255.255.255.1", null, "Accounting, Year 09", "Ledger and balance sheet", "RonAdmin" },
                    { 11, "Y09ECO", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5519), "Year 09 Economics", "255.255.255.1", null, "Economic, Year 09", "Capital and Investment by Ronald Fiji", "RonAdmin" }
                });

            migrationBuilder.InsertData(
                schema: "EShopDb",
                table: "Supplier",
                columns: new[] { "ID", "Address", "City", "Code", "CreatedBy", "CreatedDate", "Email", "IPAddress", "ModifiedDate", "Name", "Phone", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Vitogo Prade Lautoka", "Lautoka", "SUP001", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5770), "info@punjas.com", "255.255.255.1", null, "Punjas Fiji", "9966331", "" },
                    { 2, "Vitogo Prade Lautoka", "Lautoka", "SUP002", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5772), "info@lautokaeng.com", "255.255.255.1", null, "Lautoka Engineering", "9996663", "" },
                    { 3, "Vitogo Prade Lautoka", "Lautoka", "SUP003", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5773), "request@asco.com.fj", "255.255.255.1", null, "Asco Motors", "9996343", "" },
                    { 4, "Main street", "Tavua", "SUP004", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5774), "info@payaljewel.com", "255.255.255.1", null, "Payal Jewelers, Tavua", "9996343", "" }
                });

            migrationBuilder.InsertData(
                schema: "SchoolApi",
                table: "Term",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "IPAddress", "ModifiedDate", "SchTerm", "TermName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5106), "255.255.255.1", null, 1, "Term one", "" },
                    { 2, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5107), "255.255.255.1", null, 2, "Term two", "" },
                    { 3, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5108), "255.255.255.1", null, 3, "Term three", "" },
                    { 4, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5109), "255.255.255.1", null, 4, "Term four", "" }
                });

            migrationBuilder.InsertData(
                schema: "SchoolApi",
                table: "UserType",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Description", "IPAddress", "ModifiedDate", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 4, 23, 20, 40, 16, 156, DateTimeKind.Utc).AddTicks(7423), "Type is user", "", null, "User", "" },
                    { 2, "", new DateTime(2023, 4, 23, 20, 40, 16, 156, DateTimeKind.Utc).AddTicks(7425), "Type is seller", "", null, "Seller", "" }
                });

            migrationBuilder.InsertData(
                schema: "SchoolApi",
                table: "Assessment",
                columns: new[] { "ID", "Code", "CreatedBy", "CreatedDate", "IPAddress", "ModifiedDate", "Name", "SubjectID", "TermID", "UpdatedBy", "UserID", "Weight" },
                values: new object[,]
                {
                    { 1, "Y11BIOST1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5576), "230.145.124.210", null, "Short Test 1, Year 11 Biology", 1, 1, "", null, 10 },
                    { 2, "Y11BIOST2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5578), "230.145.124.210", null, "Short Test 2, Year 11 Biology", 1, 1, "", null, 10 },
                    { 3, "Y11BIOST3", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5579), "230.145.124.210", null, "Short Test 3, Year 11 Biology", 1, 2, "", null, 10 },
                    { 4, "Y11BIOST4", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5580), "230.145.124.210", null, "Short Test 4, Year 11 Biology", 1, 2, "", null, 10 },
                    { 5, "Y11BIOST5", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5581), "230.145.124.210", null, "Short Test 5, Year 11 Biology", 1, 3, "", null, 10 },
                    { 6, "Y11BIOST6", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5582), "230.145.124.210", null, "Short Test 6, Year 11 Biology", 1, 3, "", null, 10 },
                    { 7, "Y11BIOPR1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5583), "230.145.124.210", null, "Project 1, Year 11 Biology", 1, 2, "", null, 20 },
                    { 8, "Y11BIOPR2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5584), "230.145.124.210", null, "Project 2, Year 11 Biology", 1, 3, "", null, 20 },
                    { 9, "Y12ENGST1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5585), "230.145.124.210", null, "Short Test 1, Year 12 English", 2, 1, "", null, 10 },
                    { 10, "Y12ENGST2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5586), "230.145.124.210", null, "Short Test 2, Year 12 English", 2, 1, "", null, 10 },
                    { 11, "Y12ENGST3", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5588), "230.145.124.210", null, "Short Test 3, Year 12 English", 2, 1, "", null, 10 },
                    { 12, "Y12ENGST4", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5589), "230.145.124.210", null, "Short Test 4, Year 12 English", 2, 2, "", null, 10 },
                    { 13, "Y12ENGST5", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5590), "230.145.124.210", null, "Short Test 5, Year 12 English", 2, 2, "", null, 10 },
                    { 14, "Y12ENGST6", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5592), "230.145.124.210", null, "Short Test 6, Year 12 English", 2, 2, "", null, 10 },
                    { 15, "Y12ENGST7", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5593), "230.145.124.210", null, "Short Test 7, Year 12 English", 2, 3, "", null, 10 },
                    { 16, "Y12ENGST8", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5594), "230.145.124.210", null, "Short Test 8, Year 12 English", 2, 3, "", null, 15 },
                    { 17, "Y12ENGST9", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5595), "230.145.124.210", null, "Short Test 9, Year 12 English", 2, 3, "", null, 15 },
                    { 18, "Y11MATST1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5596), "230.145.124.210", null, "Short Test 1, Year 11 Mathmatics", 3, 1, "", null, 10 },
                    { 19, "Y11MATST2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5597), "230.145.124.210", null, "Short Test 2, Year 11 Mathmatics", 3, 1, "", null, 15 },
                    { 20, "Y11MATST3", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5599), "230.145.124.210", null, "Short Test 3, Year 11 Mathmatics", 3, 2, "", null, 20 },
                    { 21, "Y11MATST4", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5603), "230.145.124.210", null, "Short Test 4, Year 11 Mathmatics", 3, 2, "", null, 15 },
                    { 22, "Y11MATST5", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5604), "230.145.124.210", null, "Short Test 5, Year 11 Mathmatics", 3, 3, "", null, 20 },
                    { 23, "Y11MATST6", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5608), "230.145.124.210", null, "Short Test 6, Year 11 Mathmatics", 3, 3, "", null, 20 },
                    { 24, "Y11CHMST1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5609), "230.145.124.210", null, "Short Test 1, Year 11 Chemistry", 4, 1, "", null, 10 },
                    { 25, "Y11CHMST2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5610), "230.145.124.210", null, "Short Test 2, Year 11 Chemistry", 4, 1, "", null, 20 },
                    { 26, "Y11CHMST3", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5611), "230.145.124.210", null, "Short Test 3, Year 11 Chemistry", 4, 2, "", null, 10 },
                    { 27, "Y11CHMST4", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5612), "230.145.124.210", null, "Short Test 4, Year 11 Chemistry", 4, 2, "", null, 20 },
                    { 28, "Y11CHMST5", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5613), "230.145.124.210", null, "Short Test 5, Year 11 Chemistry", 4, 3, "", null, 20 },
                    { 29, "Y11CHMST6", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5614), "230.145.124.210", null, "Short Test 6, Year 11 Chemistry", 4, 3, "", null, 20 },
                    { 30, "Y09MATST1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5616), "230.145.124.210", null, "Short Test 1, Year 09 Mathmatics", 5, 1, "", null, 10 },
                    { 31, "Y09MATST2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5617), "230.145.124.210", null, "Short Test 2, Year 09 Mathmatics", 5, 1, "", null, 10 },
                    { 32, "Y09MATST3", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5618), "230.145.124.210", null, "Short Test 3, Year 09 Mathmatics", 5, 1, "", null, 10 },
                    { 33, "Y09MATST4", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5619), "230.145.124.210", null, "Short Test 4, Year 09 Mathmatics", 5, 2, "", null, 10 },
                    { 34, "Y09MATST5", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5620), "230.145.124.210", null, "Short Test 5, Year 09 Mathmatics", 5, 2, "", null, 10 },
                    { 35, "Y09MATST6", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5621), "230.145.124.210", null, "Short Test 6, Year 09 Mathmatics", 5, 2, "", null, 10 },
                    { 36, "Y09MATST7", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5622), "230.145.124.210", null, "Short Test 7, Year 09 Mathmatics", 5, 3, "", null, 10 },
                    { 37, "Y09MATPR1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5623), "230.145.124.210", null, "Project 1, Year 09 Mathmatics", 5, 3, "", null, 15 },
                    { 38, "Y09MATPR2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5624), "230.145.124.210", null, "Project 2, Year 09 Mathmatics", 5, 3, "", null, 15 },
                    { 39, "Y09ENGST1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5625), "230.145.124.210", null, "Short Test 1, Year 09 English", 6, 1, "", null, 10 },
                    { 40, "Y09ENGST2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5627), "230.145.124.210", null, "Short Test 2, Year 09 English", 6, 1, "", null, 10 },
                    { 41, "Y09ENGST3", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5628), "230.145.124.210", null, "Short Test 3, Year 09 English", 6, 1, "", null, 10 },
                    { 42, "Y09ENGST4", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5629), "230.145.124.210", null, "Short Test 4, Year 09 English", 6, 2, "", null, 10 },
                    { 43, "Y09ENGST5", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5630), "230.145.124.210", null, "Short Test 5, Year 09 English", 6, 2, "", null, 10 },
                    { 44, "Y09ENGPR1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5631), "230.145.124.210", null, "Project 1, Year 09 English", 6, 2, "", null, 20 },
                    { 45, "Y09ENGST6", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5632), "230.145.124.210", null, "Short Test 6, Year 09 English", 6, 3, "", null, 10 },
                    { 46, "Y09ENGST7", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5633), "230.145.124.210", null, "Short Test 7, Year 09 English", 6, 3, "", null, 10 },
                    { 47, "Y09ENGPR2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5634), "230.145.124.210", null, "Project 2, Year 09 English", 6, 3, "", null, 20 },
                    { 48, "Y09BSCST1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5635), "230.145.124.210", null, "Short Test 1, Year 09 Basic Science", 7, 1, "", null, 10 },
                    { 49, "Y09BSCST2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5637), "230.145.124.210", null, "Short Test 2, Year 09 Basic Science", 7, 1, "", null, 10 },
                    { 50, "Y09BSCRT1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5639), "230.145.124.210", null, "Report 1, Year 09 Basic Science", 7, 1, "", null, 10 },
                    { 51, "Y09BSCST3", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5640), "230.145.124.210", null, "Short Test 3, Year 09 Basic Science", 7, 2, "", null, 10 },
                    { 52, "Y09BSCST4", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5641), "230.145.124.210", null, "Short Test 4, Year 09 Basic Science", 7, 2, "", null, 10 },
                    { 53, "Y09BSCRT2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5642), "230.145.124.210", null, "Report 2, Year 09 Basic Science", 7, 2, "", null, 10 },
                    { 54, "Y09BSCST5", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5643), "230.145.124.210", null, "Short Test 5, Year 09 Basic Science", 7, 3, "", null, 10 },
                    { 55, "Y09BSCST6", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5644), "230.145.124.210", null, "Short Test 6, Year 09 Basic Science", 7, 3, "", null, 10 },
                    { 56, "Y09BSCRT3", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5645), "230.145.124.210", null, "Report 3, Year 09 Basic Science", 7, 3, "", null, 20 },
                    { 57, "Y09TDST1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5646), "230.145.124.210", null, "Short Test 7, Year 09 Technical Drawing", 8, 1, "", null, 10 },
                    { 58, "Y09TDST2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5647), "230.145.124.210", null, "Short Test 2, Year 09 Technical Drawing", 8, 1, "", null, 10 },
                    { 59, "Y09TDST3", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5648), "230.145.124.210", null, "Short Test 3, Year 09 Technical Drawing", 8, 1, "", null, 10 },
                    { 60, "Y09TDST4", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5650), "230.145.124.210", null, "Short Test 4, Year 09 Technical Drawing", 8, 1, "", null, 10 },
                    { 61, "Y09TDST5", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5651), "230.145.124.210", null, "Short Test 5, Year 09 Technical Drawing", 8, 2, "", null, 10 },
                    { 62, "Y09TDST6", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5652), "230.145.124.210", null, "Short Test 6, Year 09 Technical Drawing", 8, 2, "", null, 10 },
                    { 63, "Y09TDST7", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5653), "230.145.124.210", null, "Short Test 7, Year 09 Technical Drawing", 8, 2, "", null, 10 },
                    { 64, "Y09TDST8", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5654), "230.145.124.210", null, "Short Test 8, Year 09 Technical Drawing", 8, 2, "", null, 10 },
                    { 65, "Y09TDPR1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5655), "230.145.124.210", null, "Project 1, Year 09 Technical Drawing", 8, 3, "", null, 10 },
                    { 66, "Y09TDPR2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5656), "230.145.124.210", null, "Project 2, Year 09 Technical Drawing", 8, 3, "", null, 10 },
                    { 67, "Y09AGSST1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5657), "230.145.124.210", null, "Short Test 1, Year 09 Agriculture Science", 9, 1, "", null, 10 },
                    { 68, "Y09AGSST2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5658), "230.145.124.210", null, "Short Test 2, Year 09 Agriculture Science", 9, 1, "", null, 10 },
                    { 69, "Y09AGSST3", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5660), "230.145.124.210", null, "Short Test 3, Year 09 Agriculture Science", 9, 1, "", null, 10 },
                    { 70, "Y09AGSST4", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5661), "230.145.124.210", null, "Short Test 4, Year 09 Agriculture Science", 9, 2, "", null, 10 },
                    { 71, "Y09AGSST5", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5663), "230.145.124.210", null, "Short Test 5, Year 09 Agriculture Science", 9, 2, "", null, 10 },
                    { 72, "Y09AGSST6", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5665), "230.145.124.210", null, "Short Test 6, Year 09 Agriculture Science", 9, 2, "", null, 10 },
                    { 73, "Y09AGSPR1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5666), "230.145.124.210", null, "Project 1, Year 09 Agriculture Science", 9, 3, "", null, 20 },
                    { 74, "Y09AGSPR2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5667), "230.145.124.210", null, "Project 2, Year 09 Agriculture Science", 9, 3, "", null, 20 },
                    { 75, "Y09ACCST1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5668), "230.145.124.210", null, "Short Test 1, Year 09 Accounting", 10, 1, "", null, 10 },
                    { 76, "Y09ACCST2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5669), "230.145.124.210", null, "Short Test 2, Year 09 Accounting", 10, 1, "", null, 10 },
                    { 77, "Y09ACCST3", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5670), "230.145.124.210", null, "Short Test 3, Year 09 Accounting", 10, 1, "", null, 10 },
                    { 78, "Y09ACCST4", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5671), "230.145.124.210", null, "Short Test 4, Year 09 Accounting", 10, 1, "", null, 10 },
                    { 79, "Y09ACCST5", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5677), "230.145.124.210", null, "Short Test 5, Year 09 Accounting", 10, 2, "", null, 10 },
                    { 80, "Y09ACCST6", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5678), "230.145.124.210", null, "Short Test 6, Year 09 Accounting", 10, 2, "", null, 10 },
                    { 81, "Y09ACCST7", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5680), "230.145.124.210", null, "Short Test 7, Year 09 Accounting", 10, 2, "", null, 10 },
                    { 82, "Y09ACCST8", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5681), "230.145.124.210", null, "Short Test 8, Year 09 Accounting", 10, 3, "", null, 10 },
                    { 83, "Y09ACCST9", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5682), "230.145.124.210", null, "Short Test 9, Year 09 Accounting", 10, 3, "", null, 10 },
                    { 84, "Y09ACCST10", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5683), "230.145.124.210", null, "Short Test 10, Year 09 Accounting", 10, 3, "", null, 10 },
                    { 85, "Y09ECOST1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5684), "230.145.124.210", null, "Short Test 1, Year 09 Economics", 11, 1, "", null, 10 },
                    { 86, "Y09ECOST2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5685), "230.145.124.210", null, "Short Test 2, Year 09 Economics", 11, 1, "", null, 10 },
                    { 87, "Y09ECOST3", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5689), "230.145.124.210", null, "Short Test 3, Year 09 Economics", 11, 1, "", null, 10 },
                    { 88, "Y09ECOST4", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5690), "230.145.124.210", null, "Short Test 4, Year 09 Economics", 11, 1, "", null, 10 },
                    { 89, "Y09ECOST5", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5691), "230.145.124.210", null, "Short Test 5, Year 09 Economics", 11, 2, "", null, 10 },
                    { 90, "Y09ECOST6", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5692), "230.145.124.210", null, "Short Test 6, Year 09 Economics", 11, 2, "", null, 10 },
                    { 91, "Y09ECOPR1", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5693), "230.145.124.210", null, "Project 1, Year 09 Economics", 11, 2, "", null, 10 },
                    { 92, "Y09ECOST6", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5694), "230.145.124.210", null, "Short Test 6, Year 09 Economics", 11, 3, "", null, 10 },
                    { 93, "Y09ECOST7", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5695), "230.145.124.210", null, "Short Test 7, Year 09 Economics", 11, 3, "", null, 10 },
                    { 94, "Y09ECOPR2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5696), "230.145.124.210", null, "Project 2, Year 09 Economics", 11, 3, "", null, 10 }
                });

            migrationBuilder.InsertData(
                schema: "SchoolApi",
                table: "ClassRoom",
                columns: new[] { "ID", "Code", "CreatedBy", "CreatedDate", "Description", "IPAddress", "ModifiedDate", "Name", "SchoolId", "SchoolYearId", "SeatingCapacity", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "3A", "", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5329), "Form 3 A block info", "", null, "Form 3 A", 1, 1, 52, "" },
                    { 2, "4B", "", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5330), "Form 4 B block info", "", null, "Form 4 B", 1, 1, 52, "" }
                });

            migrationBuilder.InsertData(
                schema: "SchoolApi",
                table: "Course",
                columns: new[] { "ID", "Code", "CreatedBy", "CreatedDate", "Description", "IPAddress", "ModifiedDate", "Name", "SchoolYearId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Y11SC", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5412), "Year 11 Science", "255.255.255.1", null, "Y11Science", 11, "RonAdmin" },
                    { 2, "Y12SC", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5415), "Year 12 Science", "255.255.255.1", null, "Y12Science", 12, "RonAdmin" },
                    { 3, "Y09CO", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5416), "Year 09 Commercial", "255.255.255.1", null, "Y09Commercial", 9, "RonAdmin" },
                    { 4, "Y09EN", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5418), "Year 09 Engineering", "255.255.255.1", null, "Y09Engineering", 9, "RonAdmin" },
                    { 5, "Y09SC", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5419), "Year 09 Science", "255.255.255.1", null, "Y09Science", 9, "RonAdmin" },
                    { 6, "Y09SC2", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5420), "Year 09 Science II", "255.255.255.1", null, "Y09Science II", 9, "RonAdmin" },
                    { 7, "Y11CO", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5422), "Year 11 Commercial", "255.255.255.1", null, "Y11Commercial", 11, "RonAdmin" },
                    { 8, "Y11EN", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5423), "Year 11 Engineering", "255.255.255.1", null, "Y11Engineering", 11, "RonAdmin" },
                    { 9, "Y12CO", "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5424), "Year 12 Commercial", "255.255.255.1", null, "Y12Commercial", 12, "RonAdmin" }
                });

            migrationBuilder.InsertData(
                schema: "EShopDb",
                table: "Product",
                columns: new[] { "ID", "CategoryID", "Code", "CreatedBy", "CreatedDate", "Description", "IPAddress", "ImageURL", "IsOnPromotion", "ModifiedDate", "Name", "ProductUnitID", "Quantity", "Rating", "SupplierID", "UnitPrice", "UpdatedBy", "UserID" },
                values: new object[,]
                {
                    { 1, 1, "PR0001", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5808), "Head phone for professionals", "255.255.255.1", "", true, null, "Professional Head Phone", null, 320, 4, 2, 49.99m, "", null },
                    { 2, 1, "PR0002", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5812), "Great gear for professionals, ultra sound quality", "255.255.255.1", "", false, null, "Head Phone", null, 76, 2, 2, 36.49m, "", null },
                    { 3, 3, "PR0003", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5813), "Phone and time on your wrist", "255.255.255.1", "", false, null, "Wrist Watch", null, 60, 5, 1, 89.99m, "", null },
                    { 4, 5, "PR0004", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5818), "With its spacious capacity and convenient design, the Electrolux 609L UltimateTaste 900 French Door Fridge with Ice & Water Dispenser - Natural Stainless is a practical storage space option for busy kitchens.", "255.255.255.1", "", false, null, "French Door Fridge", null, 40, 5, 3, 2999m, "", null },
                    { 5, 5, "PR0005", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5821), "Samsung 40L Microwave Oven - Stainless Steel\r\nThis stylish Samsung Solo microwave features 40L capacity, auto defrost function, one minute plus, sensor technology and more.\r\n", "255.255.255.1", "", false, null, "Microwave Oven", null, 1056, 3, 3, 499m, "", null },
                    { 6, 4, "PR0006", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5823), "Experience lifelike visuals and enveloping sound as you watch your favourite movies and TV series with the Sony 83-inch XR MASTER series A90J 4K UHD OLED Google TV. It features a frameless design to minimise distractions and blend seamlessly with the rest of your room's décor scheme.", "255.255.255.1", "", false, null, "Sony Smart TV MASTER", null, 106, 3, 3, 2499m, "", null },
                    { 7, 4, "PR0007", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5824), "The JBL BAR 1300 11.1.4 Channel Dolby Atmos Soundbar with Detachable Speaker delivers an immersive sound experience that brings your movies, TV shows, and music to life. Featuring Dolby Atmos and DTS:X technology, this soundbar creates a 3D soundstage that surrounds you with sound from every angle. The powerful 10-inch wireless subwoofer delivers deep, punchy bass, while 4K pass-through with HDR 10 and Dolby Vision support ensures stunning picture quality. With its 6 up-firing speakers with Multibeam technology, multiple HDMI inputs, and Bluetooth and WiFi connectivity, this soundbar is the perfect addition to your home entertainment system.", "255.255.255.1", "", false, null, "Sound Bar", null, 10, 5, 3, 1995m, "", null },
                    { 8, 7, "PR0008", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5826), "Maximise your sparkle with our Pandora Timeless Pavé Double-row Ring. With warm 14k rose gold plating, this hand-finished ring features two rows of clear cubic zirconia around the centre and one row facing outwards around each side, creating a slightly rounded square profile that sparkles from every angle. Wear it on its own or stacked with other Timeless Pavé rings to create as bold of a look as you want.", "255.255.255.1", "", false, null, "Pandora Timeless Pavé Double-row Ring", null, 10, 5, 4, 2995m, "", null },
                    { 9, 7, "PR0009", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5827), "Maximise your sparkle with our Pandora Timeless Pavé Double-row Ring. With warm 14k rose gold plating, this hand-finished ring features two rows of clear cubic zirconia around the centre and one row facing outwards around each side, creating a slightly rounded square profile that sparkles from every angle. Wear it on its own or stacked with other Timeless Pavé rings to create as bold of a look as you want.", "255.255.255.1", "", false, null, "Moissanite Necklace Sterling Silver", null, 10, 5, 4, 2995m, "", null },
                    { 10, 7, "PR0010", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5828), "Crafted with most peculiar pearls of south pacific", "255.255.255.1", "", false, null, "White & Golden Pearl Pendant Necklaces", null, 10, 5, 4, 5995m, "", null },
                    { 11, 7, "PR0011", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5830), "London Collection 18k diamond and pink sapphire dangle necklace. 18k rose gold round diamond necklace with heart shaped pink sapphire dangles. Total diamond weight 1.17cts, total sapphire weight 3.05cts.", "255.255.255.1", "", false, null, "18k diamond and pink sapphire necklace", null, 2, 3, 4, 1995m, "", null },
                    { 12, 7, "PR0012", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5831), "<p>True magic is capturing a moment, freezing it in time to cherish forever. The locket is the keeper of those moments, with you always those feelings will remain. We designed the locket to bring all of life's precious moments close to your heart.  Wrap your memory in the metal of your choice for a truly special piece unique to you.</p><p>Select from solid sterling silver, 14k rose or gold plated 2 microns on silver </br>Charm quote - With you always </br>Oval locket is 16mm x 12mm in size </br>Upload up to two images, one for each side of the locket + 1 image for the box </br>Locket's image dimensions are 13mm x 8 mm </p>", "255.255.255.1", "", false, null, "Oval locket medium siler", null, 5, 4, 4, 4285.75m, "", null },
                    { 13, 7, "PR0013", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5835), "<table><tr><td>Detail Information:</td><td></td></tr><tr><td style={{width:\"300px\"}}>Material:</td><td style={{width:\"300px\"}}>925 Sterling Silver;</td></tr><tr><td>Center Stone_Carat Weight:</td><td>1.0 Carat;</td></tr><tr><td>Center Stone Shape:</td><td>Round Cut(6.4mm);</td></tr><tr><td>Chain Length:</td><td>400mm (+50mm);</td></tr><tr><td>Plating Color:</td><td>White Gold;</td></tr><tr><td>Stone:</td><td>Moissanite;</td></tr></table>", "255.255.255.1", "", false, null, "Vintage ruby set - Sterling Silver", null, 150, 4, 4, 1285.99m, "", null },
                    { 14, 6, "PR0014", "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5836), "One only female sheep for sale. Price is FJD$320.00. Located in Tavua and only pickup during working hours.", "255.255.255.1", "", false, null, "Female sheep", null, 1, 1, 4, 320m, "", null }
                });

            migrationBuilder.InsertData(
                schema: "SchoolApi",
                table: "User",
                columns: new[] { "ID", "AddressLine1", "AddressLine2", "City", "Country", "CreatedBy", "CreatedDate", "DOB", "Email", "FirstName", "Gender", "IPAddress", "LastName", "ModifiedDate", "Password", "Phone", "PostalCode", "State", "UpdatedBy", "UserTypeID" },
                values: new object[,]
                {
                    { 1, "First Road X road", "10 , Fox Street", "Levuka", "Fiji", "Admin-cr", new DateTime(2023, 4, 23, 20, 40, 16, 290, DateTimeKind.Utc).AddTicks(1390), new DateTime(1956, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", "Admin", 3, "107.23.365.369", "Limited", null, "$2a$11$zO67ffjJeBkAcC8r/cz0XODe0tt1ufp/M3II9XtD.XQjN3Mv.u7Y.", "9090337", "0123", "BlackWater", "Manager-up", 1 },
                    { 2, "Fula Fula Road", "10, Black street", "Apia", "Samoa", "Admin-cr", new DateTime(2023, 4, 23, 20, 40, 16, 422, DateTimeKind.Utc).AddTicks(3809), new DateTime(1979, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@mail.com", "John-User", 1, "107.23.365.369", "Smith", null, "$2a$11$XEhZS03bODuUtligo9Pot.Kj3YRAWywK2zvwjGTnKbqkrEck3UftS", "74789699", "458", "North", "Admin-up", 1 },
                    { 3, "Rock line Island", "29, Bush mount road", "Port Vila", "Vanuatu", "Admin-cr", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(4744), new DateTime(2001, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "peter@mail.com", "Peter-Admin", 3, "107.23.365.369", "Gates", null, "$2a$11$LAEBYnn9fFnSQDA52Oc65.ZaeWrmbKHfHRE4Ak9YauG2YgG2KMnqS", "8890337", "889", "Ocean", "Admin-up", 1 }
                });

            migrationBuilder.InsertData(
                schema: "SchoolApi",
                table: "CourseSubject",
                columns: new[] { "CourseId", "SubjectId", "CreatedBy", "CreatedDate", "IPAddress", "ModifiedDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5541), "245.36.210.199", null, "" },
                    { 1, 3, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5544), "245.36.210.199", null, "" },
                    { 1, 4, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5544), "245.36.210.199", null, "" },
                    { 2, 2, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5545), "245.36.210.199", null, "" },
                    { 3, 5, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5546), "245.36.210.199", null, "" },
                    { 3, 6, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5547), "245.36.210.199", null, "" },
                    { 3, 7, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5548), "245.36.210.199", null, "" },
                    { 3, 10, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5548), "245.36.210.199", null, "" },
                    { 3, 11, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5549), "245.36.210.199", null, "" },
                    { 4, 5, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5550), "245.36.210.199", null, "" },
                    { 4, 6, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5551), "245.36.210.199", null, "" },
                    { 4, 7, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5552), "245.36.210.199", null, "" },
                    { 4, 8, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5552), "245.36.210.199", null, "" },
                    { 4, 9, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5553), "245.36.210.199", null, "" },
                    { 5, 5, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5554), "245.36.210.199", null, "" },
                    { 5, 6, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5555), "245.36.210.199", null, "" },
                    { 5, 7, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5555), "245.36.210.199", null, "" },
                    { 6, 5, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5556), "245.36.210.199", null, "" },
                    { 6, 6, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5557), "245.36.210.199", null, "" },
                    { 6, 7, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5558), "245.36.210.199", null, "" },
                    { 6, 9, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5559), "245.36.210.199", null, "" },
                    { 7, 3, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5559), "245.36.210.199", null, "" },
                    { 8, 3, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5560), "245.36.210.199", null, "" },
                    { 9, 2, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5561), "245.36.210.199", null, "" }
                });

            migrationBuilder.InsertData(
                schema: "SchoolApi",
                table: "Prerequisite",
                columns: new[] { "ID", "CourseID", "CreatedBy", "CreatedDate", "IPAddress", "ModifiedDate", "PrerequisiteCourseId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 2, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5722), "230.145.124.210", null, 1, "" },
                    { 2, 9, "RonAdmin", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5723), "230.145.124.210", null, 7, "" }
                });

            migrationBuilder.InsertData(
                schema: "EShopDb",
                table: "ProductImage",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Description", "IPAddress", "ModifiedDate", "Name", "Path", "ProductID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5855), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0001", "45.241.250.15", null, "Headphone-a-1.webp", "Static/Products/PR0001/PR0001Headphone-a-1.webp", 1, "" },
                    { 2, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5857), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0001", "45.241.250.15", null, "Headphone-a-2.webp", "Static/Products/PR0001/PR0001Headphone-a-2.webp", 1, "" },
                    { 3, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5858), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0001", "45.241.250.15", null, "Headphone-a-3.webp", "Static/Products/PR0001/PR0001Headphone-a-3.webp", 1, "" },
                    { 4, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5859), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0001", "45.241.250.15", null, "Headphone-a-4.webp", "Static/Products/PR0001/PR0001Headphone-a-4.webp", 1, "" },
                    { 5, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5860), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0001", "45.241.250.15", null, "Headphone-a-5.webp", "Static/Products/PR0001/PR0001Headphone-a-5.webp", 1, "" },
                    { 6, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5861), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0002", "45.241.250.15", null, "Headphone-b-1.webp", "Static/Products/PR0002/PR0002Headphone-b-1.webp", 2, "" },
                    { 7, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5862), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0002", "45.241.250.15", null, "Headphone-b-2.webp", "Static/Products/PR0002/PR0002Headphone-b-2.webp", 2, "" },
                    { 8, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5863), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0002", "45.241.250.15", null, "Headphone-b-3.webp", "Static/Products/PR0002/PR0002Headphone-b-3.webp", 2, "" },
                    { 9, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5864), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0002", "45.241.250.15", null, "Headphone-b-4.webp", "Static/Products/PR0002/PR0002Headphone-b-4.webp", 2, "" },
                    { 10, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5865), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0003", "45.241.250.15", null, "WristWatch-a-1.webp", "Static/Products/PR0003/PR0003WristWatch-a-1.webp", 3, "" },
                    { 11, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5866), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0003", "45.241.250.15", null, "WristWatch-a-2.webp", "Static/Products/PR0003/PR0003WristWatch-a-2.webp", 3, "" },
                    { 12, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5867), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0003", "45.241.250.15", null, "WristWatch-a-3.webp", "Static/Products/PR0003/PR0003WristWatch-a-3.webp", 3, "" },
                    { 13, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5868), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0003", "45.241.250.15", null, "WristWatch-a-4.webp", "Static/Products/PR0003/PR0003WristWatch-a-4.webp", 3, "" },
                    { 14, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5869), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0004", "45.241.250.15", null, "PR0004Freeze1.webp", "Static/Products/PR0004/PR0004Freeze1.webp", 4, "" },
                    { 15, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5870), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0004", "45.241.250.15", null, "PR0004Freeze2.jpg", "Static/Products/PR0004/PR0004Freeze2.jpg", 4, "" },
                    { 16, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5871), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0004", "45.241.250.15", null, "PR0004Freeze3.jpg", "Static/Products/PR0004/PR0004Freeze3.jpg", 4, "" },
                    { 17, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5872), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0004", "45.241.250.15", null, "PR0004Freeze4.jpg", "Static/Products/PR0004/PR0004Freeze4.jpg", 4, "" },
                    { 18, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5873), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0004", "45.241.250.15", null, "PR0004Freeze5.jpg", "Static/Products/PR0004/PR0004Freeze5.jpg", 4, "" },
                    { 19, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5875), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0004", "45.241.250.15", null, "PR0004Freeze6.jpg", "Static/Products/PR0004/PR0004Freeze6.jpg", 4, "" },
                    { 20, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5876), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0005", "45.241.250.15", null, "PR0005Micowave1.jpg", "Static/Products/PR0005/PR0005Micowave1.jpg", 5, "" },
                    { 21, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5877), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0005", "45.241.250.15", null, "PR0005Micowave2.jpg", "Static/Products/PR0005/PR0005Micowave2.jpg", 5, "" },
                    { 22, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5878), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0005", "45.241.250.15", null, "PR0005Micowave3.jpg", "Static/Products/PR0005/PR0005Micowave3.jpg", 5, "" },
                    { 23, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5879), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0005", "45.241.250.15", null, "PR0005Micowave4.jpg", "Static/Products/PR0005/PR0005Micowave4.jpg", 5, "" },
                    { 24, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5880), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006", "45.241.250.15", null, "PR0006SonySmartTV_1.jpg", "Static/Products/PR0006/PR0006SonySmartTV_1.webp", 6, "" },
                    { 25, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5881), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006", "45.241.250.15", null, "PR0006SonySmartTV_2.jpg", "Static/Products/PR0006/PR0006SonySmartTV_2.jpg", 6, "" },
                    { 26, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5882), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006", "45.241.250.15", null, "PR0006SonySmartTV_3.jpg", "Static/Products/PR0006/PR0006SonySmartTV_3.jpg", 6, "" },
                    { 27, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5883), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006", "45.241.250.15", null, "PR0006SonySmartTV_4.jpg", "Static/Products/PR0006/PR0006SonySmartTV_4.jpg", 6, "" },
                    { 28, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5884), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006", "45.241.250.15", null, "PR0006SonySmartTV_5.jpg", "Static/Products/PR0006/PR0006SonySmartTV_5.jpg", 6, "" },
                    { 29, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5885), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006", "45.241.250.15", null, "PR0006SonySmartTV_6.jpg", "Static/Products/PR0006/PR0006SonySmartTV_6.jpg", 6, "" },
                    { 30, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5887), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006", "45.241.250.15", null, "PR0006SonySmartTV_7.jpg", "Static/Products/PR0006/PR0006SonySmartTV_7.jpg", 6, "" },
                    { 31, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5888), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0006", "45.241.250.15", null, "PR0006SonySmartTV_8.jpg", "Static/Products/PR0006/PR0006SonySmartTV_8.jpg", 6, "" },
                    { 32, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5889), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0007", "45.241.250.15", null, "PR0007SoundBar_1.jpg", "Static/Products/PR0007/PR0007SoundBar_1.jpg", 7, "" },
                    { 33, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5890), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0007", "45.241.250.15", null, "PR0007SoundBar_2.jpg", "Static/Products/PR0007/PR0007SoundBar_2.jpg", 7, "" },
                    { 34, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5891), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0007", "45.241.250.15", null, "PR0007SoundBar_3.jpg", "Static/Products/PR0007/PR0007SoundBar_3.jpg", 7, "" },
                    { 35, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5892), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0007", "45.241.250.15", null, "PR0007SoundBar_4.jpg", "Static/Products/PR0007/PR0007SoundBar_4.jpg", 7, "" },
                    { 36, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5893), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0007", "45.241.250.15", null, "PR0007SoundBar_5.jpg", "Static/Products/PR0007/PR0007SoundBar_5.jpg", 7, "" },
                    { 37, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5894), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0008", "45.241.250.15", null, "PR0008diamondring8ck_1.webp", "Static/Products/PR0008/PR0008diamondring8ck_1.webp", 8, "" },
                    { 38, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5895), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0008", "45.241.250.15", null, "PR0008diamondring8ck_2.webp", "Static/Products/PR0008/PR0008diamondring8ck_2.webp", 8, "" },
                    { 39, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5898), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0008", "45.241.250.15", null, "PR0008diamondring8ck_3.gif", "Static/Products/PR0008/PR0008diamondring8ck_3.gif", 8, "" },
                    { 40, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5899), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0008", "45.241.250.15", null, "PR0008diamondring8ck_4.webp", "Static/Products/PR0008/PR0008diamondring8ck_4.webp", 8, "" },
                    { 41, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5900), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0009", "45.241.250.15", null, "PR0009moissanite-necklace_1.webp", "Static/Products/PR0009/PR0009moissanite-necklace_1.webp", 9, "" },
                    { 42, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5902), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0009", "45.241.250.15", null, "PR0009moissanite-necklace_2.webp", "Static/Products/PR0009/PR0009moissanite-necklace_2.webp", 9, "" },
                    { 43, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5903), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0009", "45.241.250.15", null, "PR0009moissanite-necklace_3.webp", "Static/Products/PR0009/PR0009moissanite-necklace_3.webp", 9, "" },
                    { 44, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5903), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0009", "45.241.250.15", null, "PR0009moissanite-necklace_4.webp", "Static/Products/PR0009/PR0009moissanite-necklace_4.webp", 9, "" },
                    { 45, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5904), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0009", "45.241.250.15", null, "PR0009moissanite-necklace_5.webp", "Static/Products/PR0009/PR0009moissanite-necklace_5.webp", 9, "" },
                    { 46, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5905), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0010", "45.241.250.15", null, "PR0010Pearls-natrualstone_1.jpg", "Static/Products/PR0010/PR0010Pearls-natrualstone_1.jpg", 10, "" },
                    { 47, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5906), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0010", "45.241.250.15", null, "PR0010Pearls-natrualstone_2.jpg", "Static/Products/PR0010/PR0010Pearls-natrualstone_2.jpg", 10, "" },
                    { 48, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5907), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0010", "45.241.250.15", null, "PR0010Pearls-natrualstone_3.jpg", "Static/Products/PR0010/PR0010Pearls-natrualstone_3.jpg", 10, "" },
                    { 49, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5908), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0010", "45.241.250.15", null, "PR0010Pearls-natrualstone_4.jpg", "Static/Products/PR0010/PR0010Pearls-natrualstone_4.jpg", 10, "" },
                    { 50, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5912), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0010", "45.241.250.15", null, "PR0010Pearls-natrualstone_5.jpg", "Static/Products/PR0010/PR0010Pearls-natrualstone_5.jpg", 10, "" },
                    { 51, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5913), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0011", "45.241.250.15", null, "PR0011diamond-pink-sapphire_1.webp", "Static/Products/PR0011/PR0011diamond-pink-sapphire_1.webp", 11, "" },
                    { 52, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5915), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0012", "45.241.250.15", null, "PR0012oval_locket_siler_1.webp", "Static/Products/PR0012/PR0012oval_locket_siler_1.webp", 12, "" },
                    { 53, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5916), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0012", "45.241.250.15", null, "PR0012oval_locket_siler_2.webp", "Static/Products/PR0012/PR0012oval_locket_siler_2.webp", 12, "" },
                    { 54, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5917), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0012", "45.241.250.15", null, "PR0012oval_locket_siler_3.webp", "Static/Products/PR0012/PR0012oval_locket_siler_3.webp", 12, "" },
                    { 55, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5918), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0012", "45.241.250.15", null, "PR0012oval_locket_siler_4.webp", "Static/Products/PR0012/PR0012oval_locket_siler_4.webp", 12, "" },
                    { 56, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5919), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0012", "45.241.250.15", null, "PR0012oval_locket_siler_5.webp", "Static/Products/PR0012/PR0012oval_locket_siler_5.webp", 12, "" },
                    { 57, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5920), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0013", "45.241.250.15", null, "PR0013vintagerubyset_1.webp", "Static/Products/PR0013/PR0013vintagerubyset_1.webp", 13, "" },
                    { 58, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5921), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0013", "45.241.250.15", null, "PR0013vintagerubyset_2.webp", "Static/Products/PR0013/PR0013vintagerubyset_2.webp", 13, "" },
                    { 59, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5922), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0013", "45.241.250.15", null, "PR0013vintagerubyset_3.webp", "Static/Products/PR0013/PR0013vintagerubyset_3.webp", 13, "" },
                    { 60, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5923), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0013", "45.241.250.15", null, "PR0013vintagerubyset_4.webp", "Static/Products/PR0013/PR0013vintagerubyset_4.webp", 13, "" },
                    { 61, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5924), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0013", "45.241.250.15", null, "PR0013vintagerubyset_5.webp", "Static/Products/PR0013/PR0013vintagerubyset_5.webp", 13, "" },
                    { 62, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5925), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0014", "45.241.250.15", null, "PR0014sheep_1.jpg", "Static/Products/PR0014/PR0014sheep_1.jpg", 14, "" },
                    { 63, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5926), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0014", "45.241.250.15", null, "PR0014sheep_2.jpg", "Static/Products/PR0014/PR0014sheep_2.jpg", 14, "" },
                    { 64, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5927), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0014", "45.241.250.15", null, "PR0014sheep_3.jpg", "Static/Products/PR0014/PR0014sheep_3.jpg", 14, "" },
                    { 65, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5928), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0014", "45.241.250.15", null, "PR0014sheep_4.jpg", "Static/Products/PR0014/PR0014sheep_4.jpg", 14, "" },
                    { 66, "Ronald", new DateTime(2023, 4, 23, 20, 40, 16, 561, DateTimeKind.Utc).AddTicks(5929), "Full path of imageC:\\Projects\\Dev\\SchoolApiv2\\SchoolApiv2\\Resource\\Static\\Products\\PR0014", "45.241.250.15", null, "PR0014sheep_5.jpg", "Static/Products/PR0014/PR0014sheep_5.jpg", 14, "" }
                });

            migrationBuilder.InsertData(
                schema: "SchoolApi",
                table: "UserRole",
                columns: new[] { "RoleId", "UserId", "CreatedBy", "CreatedDate", "IPAddress", "ModifiedDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "Admin-cr", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5029), "107.23.365.369", null, "Admin-up" },
                    { 2, 1, "Admin-cr", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5033), "107.23.365.369", null, "Admin-up" },
                    { 1, 2, "Admin-cr", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5034), "107.23.365.369", null, "Admin-up" },
                    { 1, 3, "Admin-cr", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5035), "107.23.365.369", null, "Admin-up" },
                    { 2, 3, "Admin-cr", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5036), "107.23.365.369", null, "Admin-up" },
                    { 5, 3, "Admin-cr", new DateTime(2023, 4, 23, 20, 40, 16, 559, DateTimeKind.Utc).AddTicks(5037), "107.23.365.369", null, "Admin-up" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_SubjectID",
                schema: "SchoolApi",
                table: "Assessment",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_TermID",
                schema: "SchoolApi",
                table: "Assessment",
                column: "TermID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_UserID",
                schema: "SchoolApi",
                table: "Assessment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_Code",
                schema: "EShopDb",
                table: "Category",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoom_SchoolId",
                schema: "SchoolApi",
                table: "ClassRoom",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoom_SchoolYearId",
                schema: "SchoolApi",
                table: "ClassRoom",
                column: "SchoolYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_SchoolYearId",
                schema: "SchoolApi",
                table: "Course",
                column: "SchoolYearId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSubject_SubjectId",
                schema: "SchoolApi",
                table: "CourseSubject",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Enroll_CourseId",
                schema: "SchoolApi",
                table: "Enroll",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enroll_SchoolId",
                schema: "SchoolApi",
                table: "Enroll",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Enroll_UserId_CourseId",
                schema: "SchoolApi",
                table: "Enroll",
                columns: new[] { "UserId", "CourseId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prerequisite_CourseID_PrerequisiteCourseId",
                schema: "SchoolApi",
                table: "Prerequisite",
                columns: new[] { "CourseID", "PrerequisiteCourseId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                schema: "EShopDb",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Code",
                schema: "EShopDb",
                table: "Product",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductUnitID",
                schema: "EShopDb",
                table: "Product",
                column: "ProductUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SupplierID",
                schema: "EShopDb",
                table: "Product",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UserID",
                schema: "EShopDb",
                table: "Product",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductID",
                schema: "EShopDb",
                table: "ProductImage",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPromotion_promotionsID",
                schema: "EShopDb",
                table: "ProductPromotion",
                column: "promotionsID");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_Code",
                schema: "EShopDb",
                table: "Promotion",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                schema: "SchoolApi",
                table: "RefreshToken",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_School_Code",
                schema: "SchoolApi",
                table: "School",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SchoolYear_Year",
                schema: "SchoolApi",
                table: "SchoolYear",
                column: "Year",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Score_AssessmentID",
                schema: "SchoolApi",
                table: "Score",
                column: "AssessmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Score_EnrollmentID_AssessmentID",
                schema: "SchoolApi",
                table: "Score",
                columns: new[] { "EnrollmentID", "AssessmentID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                schema: "SchoolApi",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeID",
                schema: "SchoolApi",
                table: "User",
                column: "UserTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPictures_AppUserID",
                schema: "SchoolApi",
                table: "UserPictures",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                schema: "SchoolApi",
                table: "UserRole",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem",
                schema: "EShopDb");

            migrationBuilder.DropTable(
                name: "ClassRoom",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "CourseSubject",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "EShopDb");

            migrationBuilder.DropTable(
                name: "Payment",
                schema: "EShopDb");

            migrationBuilder.DropTable(
                name: "Prerequisite",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "ProductImage",
                schema: "EShopDb");

            migrationBuilder.DropTable(
                name: "ProductPromotion",
                schema: "EShopDb");

            migrationBuilder.DropTable(
                name: "RefreshToken",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "Score",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "UserPictures",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "UserRole",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "EShopDb");

            migrationBuilder.DropTable(
                name: "Promotion",
                schema: "EShopDb");

            migrationBuilder.DropTable(
                name: "Assessment",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "Enroll",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "EShopDb");

            migrationBuilder.DropTable(
                name: "ProductUnit",
                schema: "EShopDb");

            migrationBuilder.DropTable(
                name: "Supplier",
                schema: "EShopDb");

            migrationBuilder.DropTable(
                name: "Subject",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "Term",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "Course",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "School",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "User",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "SchoolYear",
                schema: "SchoolApi");

            migrationBuilder.DropTable(
                name: "UserType",
                schema: "SchoolApi");
        }
    }
}