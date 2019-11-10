using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WatsynDocs.Migrations
{
    public partial class ToDoEntityAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsSuperAdmin",
                table: "AspNetUsers",
                newName: "isSuperAdmin");

            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    TodoId = table.Column<string>(nullable: false),
                    TodoItem = table.Column<string>(nullable: false),
                    IsDone = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.TodoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todo");

            migrationBuilder.RenameColumn(
                name: "isSuperAdmin",
                table: "AspNetUsers",
                newName: "IsSuperAdmin");
        }
    }
}
