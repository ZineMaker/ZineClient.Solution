using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZineClient.Migrations
{
    public partial class PostSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "ApplicationUserId", "Body", "MainImageFile", "MainImageUrl", "Published", "Source", "Title" },
                values: new object[] { 1, null, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", null, "https://media.npr.org/assets/bakertaylor/covers/t/the-new-me/9780143133605_custom-032ec0143cbe2b6613d2f46cb11228fc7fa84521-s300-c85.jpg", new DateTime(2020, 4, 8, 15, 21, 8, 109, DateTimeKind.Local).AddTicks(59), "https://www.npr.org/2019/03/19/704428358/the-new-me-is-meh-about-ambition-and-adulthood", "Sample Post" });

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 101, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 107, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 107, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 107, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 5,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 107, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 6,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 107, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 7,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 107, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 8,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 21, 8, 107, DateTimeKind.Local).AddTicks(9963));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 18, 18, 7, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 18, 18, 13, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 18, 18, 13, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 18, 18, 13, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 5,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 18, 18, 13, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 6,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 18, 18, 13, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 7,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 18, 18, 13, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 8,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 18, 18, 13, DateTimeKind.Local).AddTicks(7696));
        }
    }
}
