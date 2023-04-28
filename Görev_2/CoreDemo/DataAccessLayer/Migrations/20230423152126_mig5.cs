using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Writer_ID",
                table: "Blogs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Writer_ID",
                table: "Blogs",
                column: "Writer_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Writerrs_Writer_ID",
                table: "Blogs",
                column: "Writer_ID",
                principalTable: "Writerrs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Writerrs_Writer_ID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_Writer_ID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Writer_ID",
                table: "Blogs");
        }
    }
}
