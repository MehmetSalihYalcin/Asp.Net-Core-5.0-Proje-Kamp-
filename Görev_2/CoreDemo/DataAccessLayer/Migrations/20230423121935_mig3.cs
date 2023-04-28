using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Writers_Cities_City_ID",
                table: "Writers");

            migrationBuilder.DropIndex(
                name: "IX_Writers_City_ID",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "City_ID",
                table: "Writers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "City_ID",
                table: "Writers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Writers_City_ID",
                table: "Writers",
                column: "City_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Writers_Cities_City_ID",
                table: "Writers",
                column: "City_ID",
                principalTable: "Cities",
                principalColumn: "City_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
