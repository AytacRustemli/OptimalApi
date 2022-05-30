using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class newulamaq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Basliq",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Detallıserh",
                table: "Comments",
                newName: "Review");

            migrationBuilder.AddColumn<bool>(
                name: "IsSlider",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSlider",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Review",
                table: "Comments",
                newName: "Detallıserh");

            migrationBuilder.AddColumn<string>(
                name: "Basliq",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
