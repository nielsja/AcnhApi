using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcnhApi.Migrations
{
    /// <inheritdoc />
    public partial class FishLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FishLocation",
                table: "Fishes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FishLocation",
                table: "Fishes");
        }
    }
}
