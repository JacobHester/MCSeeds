using Microsoft.EntityFrameworkCore.Migrations;

namespace MCSeeds.Migrations
{
    public partial class FixColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "versionID",
                table: "Seeds",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ImageID",
                table: "Seeds",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "versionID",
                table: "Seeds",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ImageID",
                table: "Seeds",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
