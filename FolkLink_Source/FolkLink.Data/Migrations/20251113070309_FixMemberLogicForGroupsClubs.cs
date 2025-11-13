using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FolkLink.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixMemberLogicForGroupsClubs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Clubs_ClubId",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Groups_GroupId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_ClubId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "ClubId",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Groups_GroupId",
                table: "Members",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Groups_GroupId",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Members",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ClubId",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Members_ClubId",
                table: "Members",
                column: "ClubId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Clubs_ClubId",
                table: "Members",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Groups_GroupId",
                table: "Members",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");
        }
    }
}
