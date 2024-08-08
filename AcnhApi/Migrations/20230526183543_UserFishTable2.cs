using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcnhApi.Migrations
{
    /// <inheritdoc />
    public partial class UserFishTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FishUser_Users_UsersUserId",
                table: "FishUser");

            migrationBuilder.DropTable(
                name: "CollectedFish");

            migrationBuilder.RenameColumn(
                name: "UsersUserId",
                table: "FishUser",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FishUser_UsersUserId",
                table: "FishUser",
                newName: "IX_FishUser_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FishUser_Users_UserId",
                table: "FishUser",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FishUser_Users_UserId",
                table: "FishUser");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "FishUser",
                newName: "UsersUserId");

            migrationBuilder.RenameIndex(
                name: "IX_FishUser_UserId",
                table: "FishUser",
                newName: "IX_FishUser_UsersUserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_FishUser_Users_UsersUserId",
                table: "FishUser",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
