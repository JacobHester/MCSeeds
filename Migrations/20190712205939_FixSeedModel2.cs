using Microsoft.EntityFrameworkCore.Migrations;

namespace MCSeeds.Migrations
{
    public partial class FixSeedModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SeedText",
                table: "Seeds",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeedText",
                table: "Seeds");
        }
    }
}
