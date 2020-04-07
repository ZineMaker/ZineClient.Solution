using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZineClient.Migrations
{
    public partial class ImageProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "MainImageFile",
                table: "Zines",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainImageUrl",
                table: "Zines",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "MainImageFile",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainImageUrl",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "MainImageFile",
                table: "Organizations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainImageUrl",
                table: "Organizations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainImageFile",
                table: "Zines");

            migrationBuilder.DropColumn(
                name: "MainImageUrl",
                table: "Zines");

            migrationBuilder.DropColumn(
                name: "MainImageFile",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "MainImageUrl",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "MainImageFile",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "MainImageUrl",
                table: "Organizations");
        }
    }
}
