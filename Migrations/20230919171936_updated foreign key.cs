using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hexahack.Migrations
{
    /// <inheritdoc />
    public partial class updatedforeignkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Department_d_code",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_d_code",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Departmentd_code",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Departmentd_code",
                table: "AspNetUsers",
                column: "Departmentd_code");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Department_Departmentd_code",
                table: "AspNetUsers",
                column: "Departmentd_code",
                principalTable: "Department",
                principalColumn: "d_code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Department_Departmentd_code",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Departmentd_code",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Departmentd_code",
                table: "AspNetUsers");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_d_code",
                table: "AspNetUsers",
                column: "d_code");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Department_d_code",
                table: "AspNetUsers",
                column: "d_code",
                principalTable: "Department",
                principalColumn: "d_code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
