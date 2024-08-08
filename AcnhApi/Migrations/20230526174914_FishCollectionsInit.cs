using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcnhApi.Migrations
{
    /// <inheritdoc />
    public partial class FishCollectionsInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours00",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours01",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours02",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours03",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours04",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours05",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours06",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours07",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours08",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours09",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours10",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours11",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours12",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours13",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours14",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours15",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours16",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours17",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours18",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours19",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours20",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours21",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours22",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityHours23",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityMonth01",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityMonth02",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityMonth03",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityMonth04",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityMonth05",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityMonth06",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityMonth07",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityMonth08",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityMonth09",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityMonth10",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityMonth11",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FishAvailabilityMonth12",
                table: "Fishes",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FishImage",
                table: "Fishes",
                type: "longblob",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CollectedFish",
                columns: table => new
                {
                    FishId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectedFish", x => new { x.FishId, x.UserId });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserPassword = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserEmail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollectedFish");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours00",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours01",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours02",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours03",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours04",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours05",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours06",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours07",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours08",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours09",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours10",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours11",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours12",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours13",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours14",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours15",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours16",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours17",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours18",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours19",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours20",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours21",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours22",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityHours23",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityMonth01",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityMonth02",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityMonth03",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityMonth04",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityMonth05",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityMonth06",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityMonth07",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityMonth08",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityMonth09",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityMonth10",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityMonth11",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishAvailabilityMonth12",
                table: "Fishes");

            migrationBuilder.DropColumn(
                name: "FishImage",
                table: "Fishes");
        }
    }
}
