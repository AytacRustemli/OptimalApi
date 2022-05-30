using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class categoryy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondParentCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParentCategories_ParentCategories_SecondParentCategoryId",
                        column: x => x.SecondParentCategoryId,
                        principalTable: "ParentCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SecondParentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondParentCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParentCategories_SecondParentCategoryId",
                table: "ParentCategories",
                column: "SecondParentCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParentCategories");

            migrationBuilder.DropTable(
                name: "SecondParentCategories");
        }
    }
}
