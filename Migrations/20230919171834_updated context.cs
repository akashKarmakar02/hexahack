using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hexahack.Migrations
{
    /// <inheritdoc />
    public partial class updatedcontext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeacherName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "college_code",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "d_code",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "College",
                columns: table => new
                {
                    college_code = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    college_name = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    state = table.Column<string>(type: "TEXT", nullable: false),
                    hashed_password = table.Column<int>(type: "INTEGER", nullable: false),
                    city = table.Column<string>(type: "TEXT", nullable: false),
                    is_verified = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_College", x => x.college_code);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    d_code = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.d_code);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_college_code",
                table: "AspNetUsers",
                column: "college_code");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_d_code",
                table: "AspNetUsers",
                column: "d_code");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_College_college_code",
                table: "AspNetUsers",
                column: "college_code",
                principalTable: "College",
                principalColumn: "college_code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Department_d_code",
                table: "AspNetUsers",
                column: "d_code",
                principalTable: "Department",
                principalColumn: "d_code",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_College_college_code",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Department_d_code",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "College");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_college_code",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_d_code",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TeacherName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "college_code",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "d_code",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "subject",
                table: "AspNetUsers");
        }
    }
}
