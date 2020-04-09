using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZineClient.Migrations
{
    public partial class DummyAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0061f5ab-7a7d-467b-bff9-ad3abf81a694", 0, "f6bbfe83-4995-44ce-95d9-75bb321baff0", null, false, "Foo", "Bar", false, null, null, null, null, null, false, null, false, "user@developer" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 25, 37, 67, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 5,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 6,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 7,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 8,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(3022));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0061f5ab-7a7d-467b-bff9-ad3abf81a694");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 650, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 650, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 650, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 650, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 650, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 650, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 642, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 648, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 648, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 648, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 5,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 648, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 6,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 648, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 7,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 648, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 8,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 22, 37, 648, DateTimeKind.Local).AddTicks(7757));
        }
    }
}
