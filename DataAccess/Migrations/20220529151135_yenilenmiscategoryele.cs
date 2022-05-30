using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class yenilenmiscategoryele : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParentCategories_ParentCategories_CategoryId",
                table: "ParentCategories");

            migrationBuilder.AddForeignKey(
                name: "FK_ParentCategories_Categories_CategoryId",
                table: "ParentCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParentCategories_Categories_CategoryId",
                table: "ParentCategories");

            migrationBuilder.AddForeignKey(
                name: "FK_ParentCategories_ParentCategories_CategoryId",
                table: "ParentCategories",
                column: "CategoryId",
                principalTable: "ParentCategories",
                principalColumn: "Id");
        }
    }
}
