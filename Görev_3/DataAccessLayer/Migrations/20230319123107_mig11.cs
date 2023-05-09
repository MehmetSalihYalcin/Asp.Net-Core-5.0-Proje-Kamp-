using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    About_Details1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About_Details2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About_Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About_Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About_MapLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_ID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact_UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contact_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Writer_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writer_About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writer_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writer_Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writer_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writer_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Blog_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Blog_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blog_Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blog_ThumbNailImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blog_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blog_CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Blog_Status = table.Column<bool>(type: "bit", nullable: false),
                    Category_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Blog_ID);
                    table.ForeignKey(
                        name: "FK_Blogs_Categories_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "Categories",
                        principalColumn: "Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment_UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment_Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment_Status = table.Column<bool>(type: "bit", nullable: false),
                    Blog_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comments_Blogs_Blog_ID",
                        column: x => x.Blog_ID,
                        principalTable: "Blogs",
                        principalColumn: "Blog_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Category_ID",
                table: "Blogs",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Blog_ID",
                table: "Comments",
                column: "Blog_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Writers");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
