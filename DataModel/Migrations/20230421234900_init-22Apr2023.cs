using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataModel.Migrations
{
    /// <inheritdoc />
    public partial class init22Apr2023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "EShopDb",
                table: "Product",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(319));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(322));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(327));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(328));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(329));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(332));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(334));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(349));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(356));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(359));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(362));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(364));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(366));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(368));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(370));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(371));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(376));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(386));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(387));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(391));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(393));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(395));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(396));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(401));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(404));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(405));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(406));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(408));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(438));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(456));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(457));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(463));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(472));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Assessment",
                keyColumn: "ID",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(522));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Category",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "ClassRoom",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 480, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "ClassRoom",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 480, DateTimeKind.Utc).AddTicks(9949));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(77));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(79));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(114));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Course",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(251));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 5 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 6 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(257));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 7 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(258));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 10 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 3, 11 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(260));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(262));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 7 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(262));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 8 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 4, 9 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(264));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(266));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 5, 7 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(267));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 6, 6 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 6, 7 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(270));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 6, 9 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(271));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 7, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(272));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 8, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(273));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "CourseSubject",
                keyColumns: new[] { "CourseId", "SubjectId" },
                keyValues: new object[] { 9, 2 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Prerequisite",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Prerequisite",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(691), "Moissanite Necklace Sterling Silver" });

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(693), "White & Golden Pearl Pendant Necklaces" });

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(726));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(790));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductImage",
                keyColumn: "ID",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductUnit",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(647));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductUnit",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "ProductUnit",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(650));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 70, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 70, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 70, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 70, DateTimeKind.Utc).AddTicks(5096));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 70, DateTimeKind.Utc).AddTicks(5103));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 70, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "School",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "School",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "School",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "School",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7789));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "SchoolYear",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(211));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(221));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(223));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(227));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Subject",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Supplier",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 481, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Term",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Term",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Term",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Term",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "User",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 22, 11, 49, 0, 200, DateTimeKind.Utc).AddTicks(3208), "$2a$11$UAjdH4DeCs23Si0YfNTZaOUB7B2Muy9O/oi57qACTVxHPKwQi/EDW" });

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "User",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 22, 11, 49, 0, 336, DateTimeKind.Utc).AddTicks(977), "$2a$11$R/UPi23NUsNtgOuf9SOlu.wTZ8oJFD5W0TYT0CmB6e2keJIkbEpH." });

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "User",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(6928), "$2a$11$MvR.QyvoTJOfXo0Pcfbk/uWSzUqJtsQ5s4EXBdfzLlrLHF3gg0VAC" });

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 477, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 70, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 22, 11, 49, 0, 70, DateTimeKind.Utc).AddTicks(5124));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "EShopDb",
                table: "Product",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

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
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8672), "Moissanite Necklace Pendant In Sterling Silver" });

            migrationBuilder.UpdateData(
                schema: "EShopDb",
                table: "Product",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 4, 18, 22, 14, 12, 964, DateTimeKind.Utc).AddTicks(8673), "White and Golden Pearl Pendant Necklaces" });

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

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "Role",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 541, DateTimeKind.Utc).AddTicks(9990));

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
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 542, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "SchoolApi",
                table: "UserType",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 18, 22, 14, 12, 542, DateTimeKind.Utc).AddTicks(2));
        }
    }
}
