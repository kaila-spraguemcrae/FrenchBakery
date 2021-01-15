using Microsoft.EntityFrameworkCore.Migrations;

namespace FrenchBakery.Solution.Migrations
{
    public partial class FlavorDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Flavors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Flavors");
        }
    }
}
