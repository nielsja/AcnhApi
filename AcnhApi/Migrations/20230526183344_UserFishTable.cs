using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcnhApi.Migrations
{
    /// <inheritdoc />
    public partial class UserFishTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FishUser",
                columns: table => new
                {
                    FishId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsersUserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishUser", x => new { x.FishId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_FishUser_Fishes_FishId",
                        column: x => x.FishId,
                        principalTable: "Fishes",
                        principalColumn: "FishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FishUser_Users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FishUser_UsersUserId",
                table: "FishUser",
                column: "UsersUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FishUser");
        }
    }
}
