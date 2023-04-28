using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Writers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Writer_About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writer_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writer_Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writer_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writer_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writer_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.ID);
                });
        }
    }
}
