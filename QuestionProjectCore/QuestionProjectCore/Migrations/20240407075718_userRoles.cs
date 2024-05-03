using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestionProjectCore.Migrations
{
    /// <inheritdoc />
    public partial class userRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e03106a-55d2-4904-bf98-116e08f7c2f5", "a2ebaed9-ab90-46a6-abc8-e56384559153", "Member", "member" },
                    { "ac2ed0c8-c16e-4844-b0e0-489366c3799e", "63645dd9-5ef5-4682-98d3-42de99ec2306", "Admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e03106a-55d2-4904-bf98-116e08f7c2f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac2ed0c8-c16e-4844-b0e0-489366c3799e");
        }
    }
}
