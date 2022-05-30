using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class parentlercategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_SecondParentCategoryId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentCategories_ParentCategories_SecondParentCategoryId",
                table: "ParentCategories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_SecondParentCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SecondParentCategoryId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "SecondParentCategoryId",
                table: "ParentCategories",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ParentCategories_SecondParentCategoryId",
                table: "ParentCategories",
                newName: "IX_ParentCategories_CategoryId");

            migrationBuilder.AddColumn<int>(
                name: "ParentCategoryId",
                table: "SecondParentCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SecondParentCategories_ParentCategoryId",
                table: "SecondParentCategories",
                column: "ParentCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParentCategories_ParentCategories_CategoryId",
                table: "ParentCategories",
                column: "CategoryId",
                principalTable: "ParentCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SecondParentCategories_SecondParentCategories_ParentCategoryId",
                table: "SecondParentCategories",
                column: "ParentCategoryId",
                principalTable: "SecondParentCategories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParentCategories_ParentCategories_CategoryId",
                table: "ParentCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondParentCategories_SecondParentCategories_ParentCategoryId",
                table: "SecondParentCategories");

            migrationBuilder.DropIndex(
                name: "IX_SecondParentCategories_ParentCategoryId",
                table: "SecondParentCategories");

            migrationBuilder.DropColumn(
                name: "ParentCategoryId",
                table: "SecondParentCategories");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "ParentCategories",
                newName: "SecondParentCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ParentCategories_CategoryId",
                table: "ParentCategories",
                newName: "IX_ParentCategories_SecondParentCategoryId");

            migrationBuilder.AddColumn<int>(
                name: "SecondParentCategoryId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SecondParentCategoryId",
                table: "Categories",
                column: "SecondParentCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_SecondParentCategoryId",
                table: "Categories",
                column: "SecondParentCategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParentCategories_ParentCategories_SecondParentCategoryId",
                table: "ParentCategories",
                column: "SecondParentCategoryId",
                principalTable: "ParentCategories",
                principalColumn: "Id");
        }
    }
}
