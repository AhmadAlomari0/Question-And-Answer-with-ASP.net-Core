using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuestionProjectCore.Migrations
{
    /// <inheritdoc />
    public partial class ModeratorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moderators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModeratorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeratorPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Moderatormail = table.Column<int>(type: "int", nullable: true),
                    ModeratorAge = table.Column<int>(type: "int", nullable: true),
                    ModeratorSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moderators", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moderators");
        }
    }
}
