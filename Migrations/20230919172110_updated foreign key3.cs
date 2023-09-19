using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hexahack.Migrations
{
    /// <inheritdoc />
    public partial class updatedforeignkey3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_College_college_code",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_college_code",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "college_code1",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_college_code1",
                table: "AspNetUsers",
                column: "college_code1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_College_college_code1",
                table: "AspNetUsers",
                column: "college_code1",
                principalTable: "College",
                principalColumn: "college_code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_College_college_code1",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_college_code1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "college_code1",
                table: "AspNetUsers");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_college_code",
                table: "AspNetUsers",
                column: "college_code");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_College_college_code",
                table: "AspNetUsers",
                column: "college_code",
                principalTable: "College",
                principalColumn: "college_code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
