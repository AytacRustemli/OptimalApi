using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class secondparenttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SecondParentCategories_SecondParentCategories_ParentCategoryId",
                table: "SecondParentCategories");

            migrationBuilder.AddForeignKey(
                name: "FK_SecondParentCategories_ParentCategories_ParentCategoryId",
                table: "SecondParentCategories",
                column: "ParentCategoryId",
                principalTable: "ParentCategories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SecondParentCategories_ParentCategories_ParentCategoryId",
                table: "SecondParentCategories");

            migrationBuilder.AddForeignKey(
                name: "FK_SecondParentCategories_SecondParentCategories_ParentCategoryId",
                table: "SecondParentCategories",
                column: "ParentCategoryId",
                principalTable: "SecondParentCategories",
                principalColumn: "Id");
        }
    }
}
