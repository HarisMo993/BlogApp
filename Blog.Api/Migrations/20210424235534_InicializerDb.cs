using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Api.Migrations
{
    public partial class InicializerDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slug = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: false),
                    tags = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Body", "CreatedAt", "Description", "Slug", "Title", "UpdateAt", "tags" },
                values: new object[] { 1, "The app is simple to use, and will help you decide on your best furniture fit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.", "augmented-reality-ios-application", "Augmented Reality iOS Application", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"iOS\",\"AR\"]" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Body", "CreatedAt", "Description", "Slug", "Title", "UpdateAt", "tags" },
                values: new object[] { 2, "The app is simple to use, and will help you decide on your best furniture fit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.", "augmented-reality-ios-application-2", "Augmented Reality iOS Application 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"iOS\",\"AR\"]" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Body", "CreatedAt", "Description", "Slug", "Title", "UpdateAt", "tags" },
                values: new object[] { 3, "The app is simple to use, and will help you decide on your best furniture fit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.", "augmented-reality-ios-application-3", "Augmented Reality iOS Application 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"iOS\",\"AR\",\"Gazzda\"]" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
