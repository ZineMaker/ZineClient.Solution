using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZineClient.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    OwnerId = table.Column<string>(nullable: true),
                    MainImageUrl = table.Column<string>(nullable: true),
                    MainImageFile = table.Column<byte[]>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationId);
                    table.ForeignKey(
                        name: "FK_Organizations_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    MainImageUrl = table.Column<string>(nullable: true),
                    MainImageFile = table.Column<byte[]>(nullable: true),
                    Published = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserOrganization",
                columns: table => new
                {
                    ApplicationUserOrganizationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrganizationId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserOrganization", x => x.ApplicationUserOrganizationId);
                    table.ForeignKey(
                        name: "FK_ApplicationUserOrganization_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicationUserOrganization_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zines",
                columns: table => new
                {
                    ZineId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrganizationId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MainImageUrl = table.Column<string>(nullable: true),
                    MainImageFile = table.Column<byte[]>(nullable: true),
                    PublicationDate = table.Column<DateTime>(nullable: false),
                    IssueNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zines", x => x.ZineId);
                    table.ForeignKey(
                        name: "FK_Zines_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    PostTagId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PostId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => x.PostTagId);
                    table.ForeignKey(
                        name: "FK_PostTag_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostZine",
                columns: table => new
                {
                    PostZineId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PostId = table.Column<int>(nullable: false),
                    ZineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostZine", x => x.PostZineId);
                    table.ForeignKey(
                        name: "FK_PostZine_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostZine_Zines_ZineId",
                        column: x => x.ZineId,
                        principalTable: "Zines",
                        principalColumn: "ZineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrganizationId", "Description", "MainImageFile", "MainImageUrl", "Name", "OwnerId" },
                values: new object[] { 1, "We are a small grassroots community of creators committed to bringing you high quality content for the current era", null, "https://www.geniuscr8.com/wp-content/uploads/2018/07/Genius-Concept-Sample-Logo-2.jpg", "The Sample Org", null });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrganizationId", "Description", "MainImageFile", "MainImageUrl", "Name", "OwnerId" },
                values: new object[] { 2, "Pasting (and cutting, copying, etc.) is the name of the game for this paper-turned-digital media project", null, "https://turbologo.com/articles/wp-content/uploads/2018/03/prozrachniy-logo-1-1280x720.png", "Makers of Ctrl+V", null });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrganizationId", "Description", "MainImageFile", "MainImageUrl", "Name", "OwnerId" },
                values: new object[] { 3, "We pride ourselves on transparency and keeping the public informed. Check out our West Seattle Connection blog", null, "https://cdn.vox-cdn.com/thumbor/2KfYhzovz49NNJ5aBw9agDxWoAo=/0x0:4000x3000/1200x800/filters:focal(1541x1365:2181x2005)/cdn.vox-cdn.com/uploads/chorus_image/image/65976577/shutterstock_1386088199.0.jpg", "West Seattle Connection", null });

            migrationBuilder.InsertData(
                table: "Zines",
                columns: new[] { "ZineId", "Description", "IssueNumber", "MainImageFile", "MainImageUrl", "Name", "OrganizationId", "PublicationDate" },
                values: new object[,]
                {
                    { 5, "Asp.NET Core 101: A crash course", 1, null, "https://dispozitivbooks.com/wp-content/uploads/2020/03/8.jpg", "Devs Digest", 1, new DateTime(2020, 4, 8, 15, 18, 18, 13, DateTimeKind.Local).AddTicks(7675) },
                    { 6, "Our unfiltered opinions on group projects, late nights, and quarantine blues", 2, null, "https://pbs.twimg.com/media/ETy7wcJWsAEplrI.jpg", "Team Week in the making", 1, new DateTime(2020, 4, 8, 15, 18, 18, 13, DateTimeKind.Local).AddTicks(7683) },
                    { 1, "The zine of your dreams", 1, null, "https://cms-assets.tutsplus.com/uploads/users/114/posts/32493/image/Mockup1.jpg", "Ctrl+V", 2, new DateTime(2020, 4, 8, 15, 18, 18, 7, DateTimeKind.Local).AddTicks(5502) },
                    { 2, "The zine of your dreams, remastered", 2, null, "https://texlibris.lib.utexas.edu/wp-content/uploads/2020/02/17-01898_3600-712x1024.jpg", "Ctrl+V", 2, new DateTime(2020, 4, 8, 15, 18, 18, 13, DateTimeKind.Local).AddTicks(7616) },
                    { 3, "The zine of your dreams, trilogy edition", 4, null, "https://images.squarespace-cdn.com/content/v1/5b69d5843917eed82e6834fc/1537917947123-QPP10RP1SC469FXQXP45/ke17ZwdGBToddI8pDm48kHTjdXaoHj2XBS1xQ9Jx_M57gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z5QPOohDIaIeljMHgDF5CVlOqpeNLcJ80NK65_fV7S1Uei60Zpw-ZuEzVY2XSpngzHUNhdVwAOL_XMz32vi4iSsh9ymnU-gXScjHEMuNgenFw/The+Joy+003-Cover-spreads.jpg?format=2500w", "Ctrl+V", 2, new DateTime(2020, 4, 8, 15, 18, 18, 13, DateTimeKind.Local).AddTicks(7659) },
                    { 4, "The zine for when the zine of your dreams already existed", 1, null, "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/380a5783-bac6-4184-9776-270b1e3b6a1d/dchzmx3-4b7e18cb-02cb-41ce-a192-ccb57c77e763.png/v1/fill/w_1024,h_1453,q_80,strp/shindeku_zine_cover____by_neon_nuisance_dchzmx3-fullview.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MTQ1MyIsInBhdGgiOiJcL2ZcLzM4MGE1NzgzLWJhYzYtNDE4NC05Nzc2LTI3MGIxZTNiNmExZFwvZGNoem14My00YjdlMThjYi0wMmNiLTQxY2UtYTE5Mi1jY2I1N2M3N2U3NjMucG5nIiwid2lkdGgiOiI8PTEwMjQifV1dLCJhdWQiOlsidXJuOnNlcnZpY2U6aW1hZ2Uub3BlcmF0aW9ucyJdfQ.UfjaWa0T3nF6rngtM2Fg0mW036EwLWIC4eZKmuEH_U4", "Ctrl+C", 2, new DateTime(2020, 4, 8, 15, 18, 18, 13, DateTimeKind.Local).AddTicks(7667) },
                    { 7, "Though it's isolated from the rest of the city, West Seattle is an incredibly popular area, whether it's to live in or just to visit one of its hip neighborhoods.", 1, null, "https://cdn.vox-cdn.com/thumbor/tyONoySTF3e4Qq64-86lCk9DdZA=/0x0:2500x1295/1200x900/filters:focal(751x398:1151x798)/cdn.vox-cdn.com/uploads/chorus_image/image/54721251/west_seattle_shutterstock.0.jpg", "About West Seattle", 3, new DateTime(2020, 4, 8, 15, 18, 18, 13, DateTimeKind.Local).AddTicks(7689) },
                    { 8, "The renovated West Seattle Branch opened April 3, 2004. At this Carnegie library, tall ceilings contribute to a sense of openness. Rich detailing and use of wood throughout the interior add to the warm, historic feel.", 2, null, "https://pauldorpat.com/wp-content/uploads/2011/12/branches-color-postcard-web1.jpg?w=500&h=309", "West Seattle Library", 3, new DateTime(2020, 4, 8, 15, 18, 18, 13, DateTimeKind.Local).AddTicks(7696) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserOrganization_ApplicationUserId",
                table: "ApplicationUserOrganization",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserOrganization_OrganizationId",
                table: "ApplicationUserOrganization",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_OwnerId",
                table: "Organizations",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ApplicationUserId",
                table: "Posts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_PostId",
                table: "PostTag",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagId",
                table: "PostTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_PostZine_PostId",
                table: "PostZine",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostZine_ZineId",
                table: "PostZine",
                column: "ZineId");

            migrationBuilder.CreateIndex(
                name: "IX_Zines_OrganizationId",
                table: "Zines",
                column: "OrganizationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserOrganization");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DropTable(
                name: "PostZine");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Zines");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
