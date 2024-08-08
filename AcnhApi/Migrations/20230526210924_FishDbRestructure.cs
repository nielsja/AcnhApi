using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcnhApi.Migrations
{
    /// <inheritdoc />
    public partial class FishDbRestructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FishUser");

            migrationBuilder.DropColumn(
                name: "FishImage",
                table: "Fishes");

            migrationBuilder.AddColumn<string>(
                name: "FishImageUri",
                table: "Fishes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FishDbUserDb",
                columns: table => new
                {
                    FishId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishDbUserDb", x => new { x.FishId, x.UserId });
                    table.ForeignKey(
                        name: "FK_FishDbUserDb_Fishes_FishId",
                        column: x => x.FishId,
                        principalTable: "Fishes",
                        principalColumn: "FishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FishDbUserDb_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FishDbUserDb_UserId",
                table: "FishDbUserDb",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FishDbUserDb");

            migrationBuilder.DropColumn(
                name: "FishImageUri",
                table: "Fishes");

            migrationBuilder.AddColumn<byte[]>(
                name: "FishImage",
                table: "Fishes",
                type: "longblob",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FishUser",
                columns: table => new
                {
                    FishId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishUser", x => new { x.FishId, x.UserId });
                    table.ForeignKey(
                        name: "FK_FishUser_Fishes_FishId",
                        column: x => x.FishId,
                        principalTable: "Fishes",
                        principalColumn: "FishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FishUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FishUser_UserId",
                table: "FishUser",
                column: "UserId");
        }
    }
}
