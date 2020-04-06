using Microsoft.EntityFrameworkCore.Migrations;

namespace ZineClient.Migrations
{
    public partial class EditApplicationUserOrganizationId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationsUserOrganization_AspNetUsers_ApplicationUserId1",
                table: "ApplicationsUserOrganization");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationsUserOrganization_ApplicationUserId1",
                table: "ApplicationsUserOrganization");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "ApplicationsUserOrganization");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "ApplicationsUserOrganization",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationsUserOrganization_ApplicationUserId",
                table: "ApplicationsUserOrganization",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationsUserOrganization_AspNetUsers_ApplicationUserId",
                table: "ApplicationsUserOrganization",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationsUserOrganization_AspNetUsers_ApplicationUserId",
                table: "ApplicationsUserOrganization");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationsUserOrganization_ApplicationUserId",
                table: "ApplicationsUserOrganization");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "ApplicationsUserOrganization",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "ApplicationsUserOrganization",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationsUserOrganization_ApplicationUserId1",
                table: "ApplicationsUserOrganization",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationsUserOrganization_AspNetUsers_ApplicationUserId1",
                table: "ApplicationsUserOrganization",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
