using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    /// <inheritdoc />
    public partial class init18042023v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Supplier_SupplierID",
                schema: "EShopDb",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierID",
                schema: "EShopDb",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8444));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8460));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8484));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8486));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8495));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8497));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8506));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8515));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8524));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8529));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8531));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8544));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "ClassRoom",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "ClassRoom",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8302));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8309));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 5 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 6 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 7 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 10 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 11 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 7 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 8 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 9 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 5, 7 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 6, 6 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 6, 7 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 6, 9 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 7, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 8, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 9, 2 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8425));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Prerequisite",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Prerequisite",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8740));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductUnit",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductUnit",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8640));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductUnit",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 541, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 541, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 541, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 541, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 541, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.InsertData(
                schema: "SchoolApi",
                table: "Role",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Description", "IPAddress", "ModifiedDate", "Name", "UpdatedBy" },
                values: new object[] { 6, "", new DateTime(2023, 4, 18, 22, 14, 12, 541, DateTimeKind.Utc).AddTicks(9990), "Seller role", "", null, "Seller", "" });

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "School",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "School",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "School",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "School",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9634));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8372));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8628));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8629));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Term",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Term",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9603));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Term",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Term",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 18, 22, 14, 12, 679, DateTimeKind.Utc).AddTicks(3314), "$2a$11$O6fJQlVSzLJ3mpBkk67EMOF.1mg1p8Zn8SXiPITDFTih9UOB/JIGy" });

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 18, 22, 14, 12, 819, DateTimeKind.Utc).AddTicks(5626), "$2a$11$5DuvqPm1U2p6RmRYkyXbf.Of3OC6wpxnfE8gG0qgML5RBjo1XDRBy" });

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9332), "$2a$11$fTOqqpv/CQABAHoJ02.xSeLSbULdS4waUuWjuDuGXKd67JJiset36" });

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 962, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2023, 4, 18, 22, 14, 12, 542, DateTimeKind.Utc), "Type is user", "User" });

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2023, 4, 18, 22, 14, 12, 542, DateTimeKind.Utc).AddTicks(2), "Type is seller", "Seller" });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Supplier_SupplierID",
                schema: "EShopDb",
                table: "Product",
                column: "SupplierID",
                principalSchema: "EShopDb",
                principalTable: "Supplier",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Supplier_SupplierID",
                schema: "EShopDb",
                table: "Product");

            migrationBuilder.DeleteData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierID",
                schema: "EShopDb",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7174));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7178));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7194));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7205));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7237));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7239));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7271));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7277));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7284));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7286));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7289));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7378));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7380));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7391));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7399));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7404));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7407));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7482));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "ClassRoom",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "ClassRoom",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 5 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 6 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 7 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 10 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 11 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 7 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 8 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 9 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 5, 7 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 6, 6 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 6, 7 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 6, 9 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 7, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 8, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 9, 2 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Prerequisite",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Prerequisite",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7589));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7593));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7600));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7607));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7642));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7658));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7664));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7670));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7674));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7702));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7706));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7717));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductUnit",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductUnit",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductUnit",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 55, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 55, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 55, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 55, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 55, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "School",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "School",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "School",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "School",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 602, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Term",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Term",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Term",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Term",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 18, 16, 28, 25, 252, DateTimeKind.Utc).AddTicks(4421), "$2a$11$HWSxV5WkAA0syvFcJgoqQu1gjhrSshw6KFcB9JNo3nwVsYzlwPaVa" });

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 18, 16, 28, 25, 422, DateTimeKind.Utc).AddTicks(3006), "$2a$11$GZUEvo301liXQYI1OaRIde6tVLzy6RLTAaGdCSyEzkfEOPXoi4556" });

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(3738), "$2a$11$LzaTdlKxnz6rZeS8X4xhAeVTOp5D0ekIjMnnt7txzd7GFCE63N9b6" });

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 16, 28, 25, 600, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2023, 4, 18, 16, 28, 25, 55, DateTimeKind.Utc).AddTicks(5816), "This student", "Student" });

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2023, 4, 18, 16, 28, 25, 55, DateTimeKind.Utc).AddTicks(5819), "This staff", "Staff" });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Supplier_SupplierID",
                schema: "EShopDb",
                table: "Product",
                column: "SupplierID",
                principalSchema: "EShopDb",
                principalTable: "Supplier",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
