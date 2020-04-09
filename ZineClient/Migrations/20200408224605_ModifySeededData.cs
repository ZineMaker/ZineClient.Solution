using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZineClient.Migrations
{
    public partial class ModifySeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0061f5ab-7a7d-467b-bff9-ad3abf81a694");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "35c1a1cf-4780-4df4-97c9-9dff35eeecf9", 0, "0d679cc8-a934-4dfa-a33c-649b05bfc16b", null, false, "Foo", "Bar", false, null, null, null, null, null, false, null, false, "user@developer" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Published",
                value: new DateTime(2020, 4, 8, 15, 46, 4, 356, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "MainImageUrl", "Published" },
                values: new object[] { "https://www.westsideseattle.com/sites/default/files/images/%5Bdomain-url%5D/%5Bnode-yyyy%5D/%5Bnode-mm%5D/252a9949_copy.jpg", new DateTime(2020, 4, 8, 15, 46, 4, 356, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "MainImageUrl", "Published" },
                values: new object[] { "https://d3h6k4kfl8m9p0.cloudfront.net/uploads/2014/04/1920-washington-DC-shorpy.jpg", new DateTime(2020, 4, 8, 15, 46, 4, 356, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                columns: new[] { "MainImageUrl", "Published" },
                values: new object[] { "https://static1.squarespace.com/static/53dd6676e4b0fedfbc26ea91/54b6c509e4b062126976d942/5a57a1d7c8302558ef0605cc/1516298184024/bike_girl_panning_bicycle_cycle_cyclist_outdoor_ride-1168194.jpg?format=2500w", new DateTime(2020, 4, 8, 15, 46, 4, 356, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                columns: new[] { "MainImageUrl", "Published" },
                values: new object[] { "https://media-cdn.tripadvisor.com/media/photo-m/1280/14/ff/61/25/getlstd-property-photo.jpg", new DateTime(2020, 4, 8, 15, 46, 4, 356, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                columns: new[] { "MainImageUrl", "Published" },
                values: new object[] { "https://static.seattletimes.com/wp-content/uploads/2020/03/03242020_bridge_134121-1560x1040.jpg", new DateTime(2020, 4, 8, 15, 46, 4, 356, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 1,
                columns: new[] { "Name", "PublicationDate" },
                values: new object[] { "Ctrl+V I", new DateTime(2020, 4, 8, 15, 46, 4, 352, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 2,
                columns: new[] { "Name", "PublicationDate" },
                values: new object[] { "Ctrl+V II", new DateTime(2020, 4, 8, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 3,
                columns: new[] { "Name", "PublicationDate" },
                values: new object[] { "Ctrl+V III", new DateTime(2020, 4, 8, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 5,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 6,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 7,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 8,
                column: "PublicationDate",
                value: new DateTime(2020, 4, 8, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(6394));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35c1a1cf-4780-4df4-97c9-9dff35eeecf9");

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
                columns: new[] { "MainImageUrl", "Published" },
                values: new object[] { "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/s960x960/92598824_10222383695444196_8978529166924185600_o.jpg?_nc_cat=105&_nc_sid=ca434c&_nc_oc=AQkbCoY2oCStEgnkHqeWuosOfw0dvbp3s3chQk5rzZ4Fzju5FzY5JwWcRndOnNy8PFbcv0AsljHNVgA1igwYzzhI&_nc_ht=scontent-sea1-1.xx&_nc_tp=7&oh=750b576c6a65f531de6ea44952a0b945&oe=5EB40642", new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "MainImageUrl", "Published" },
                values: new object[] { "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/92122080_3663086160399133_3531716169725640704_n.jpg?_nc_cat=108&_nc_sid=07e735&_nc_oc=AQl8p8W4In9MyKp78AZFWqbw9xOcEwKREc_6h852TyfizBZ3hUytBT0Ry8hKUqd4Ly6n9unf_2mFdwxHf9kVSY91&_nc_ht=scontent-sea1-1.xx&oh=5f2b1e72c1e7395fa239ec80d8529160&oe=5EB2EBC9", new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                columns: new[] { "MainImageUrl", "Published" },
                values: new object[] { "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/91850808_10218951980923965_7620497844079689728_n.jpg?_nc_cat=111&_nc_sid=ca434c&_nc_oc=AQnF1Hi8Gp2zOzX3mslL2f7Ni4toCHkAcbL0tuoHqy3DQ_cKgjnZeod8vZMKhSOgTe1Qbw-M-ZT_zoYu2wX8l7rx&_nc_ht=scontent-sea1-1.xx&oh=ab0167a841a066036d87af341e27f5c8&oe=5EB32C1C", new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 8,
                columns: new[] { "MainImageUrl", "Published" },
                values: new object[] { "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/92678252_10158280722022417_8621941719081943040_n.jpg?_nc_cat=101&_nc_sid=ca434c&_nc_oc=AQmidwsOmbAFIvfNQ5Jy5uNfaNXM6HDM57L2Q8iM5-_zt2Xf06xvibM86Uxe1PwJzDYPjRb3pYGWXy0Jwe2gdlIp&_nc_ht=scontent-sea1-1.xx&oh=64aa052c2c292b33fbf25e5c0875ed43&oe=5EB3027C", new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 9,
                columns: new[] { "MainImageUrl", "Published" },
                values: new object[] { "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/92531837_10221747110850778_7079577568193544192_n.jpg?_nc_cat=103&_nc_sid=ca434c&_nc_oc=AQnJfUCl5n_sEO61IK8JF1RsYkYdHURtBNbUrjd7PQig0PS7FYpF0A3r_2TK7ZrlGx2Dpg0NfOTiB_0Di6y1plYc&_nc_ht=scontent-sea1-1.xx&oh=041d6eb8b2b6608b92bea2c1515d80d8&oe=5EB3DD39", new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 1,
                columns: new[] { "Name", "PublicationDate" },
                values: new object[] { "Ctrl+V", new DateTime(2020, 4, 8, 15, 25, 37, 67, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 2,
                columns: new[] { "Name", "PublicationDate" },
                values: new object[] { "Ctrl+V", new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Zines",
                keyColumn: "ZineId",
                keyValue: 3,
                columns: new[] { "Name", "PublicationDate" },
                values: new object[] { "Ctrl+V", new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(3000) });

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
    }
}
