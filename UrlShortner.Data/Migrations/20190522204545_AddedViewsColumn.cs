using Microsoft.EntityFrameworkCore.Migrations;

namespace UrlShortner.Data.Migrations
{
    public partial class AddedViewsColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Views",
                table: "Urls",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Views",
                table: "Urls");
        }
    }
}
