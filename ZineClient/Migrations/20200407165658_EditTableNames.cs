using Microsoft.EntityFrameworkCore.Migrations;

namespace ZineClient.Migrations
{
    public partial class EditTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationsUserOrganization_AspNetUsers_ApplicationUserId",
                table: "ApplicationsUserOrganization");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationsUserOrganization_Organizations_OrganizationId",
                table: "ApplicationsUserOrganization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationsUserOrganization",
                table: "ApplicationsUserOrganization");

            migrationBuilder.RenameTable(
                name: "ApplicationsUserOrganization",
                newName: "ApplicationUserOrganization");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationsUserOrganization_OrganizationId",
                table: "ApplicationUserOrganization",
                newName: "IX_ApplicationUserOrganization_OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationsUserOrganization_ApplicationUserId",
                table: "ApplicationUserOrganization",
                newName: "IX_ApplicationUserOrganization_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserOrganization",
                table: "ApplicationUserOrganization",
                column: "ApplicationUserOrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserOrganization_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserOrganization",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserOrganization_Organizations_OrganizationId",
                table: "ApplicationUserOrganization",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "OrganizationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserOrganization_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserOrganization");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserOrganization_Organizations_OrganizationId",
                table: "ApplicationUserOrganization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserOrganization",
                table: "ApplicationUserOrganization");

            migrationBuilder.RenameTable(
                name: "ApplicationUserOrganization",
                newName: "ApplicationsUserOrganization");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserOrganization_OrganizationId",
                table: "ApplicationsUserOrganization",
                newName: "IX_ApplicationsUserOrganization_OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserOrganization_ApplicationUserId",
                table: "ApplicationsUserOrganization",
                newName: "IX_ApplicationsUserOrganization_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationsUserOrganization",
                table: "ApplicationsUserOrganization",
                column: "ApplicationUserOrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationsUserOrganization_AspNetUsers_ApplicationUserId",
                table: "ApplicationsUserOrganization",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationsUserOrganization_Organizations_OrganizationId",
                table: "ApplicationsUserOrganization",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "OrganizationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
