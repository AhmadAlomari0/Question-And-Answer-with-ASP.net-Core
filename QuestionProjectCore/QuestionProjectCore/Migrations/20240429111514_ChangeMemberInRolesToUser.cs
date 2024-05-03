using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestionProjectCore.Migrations
{
    /// <inheritdoc />
    public partial class ChangeMemberInRolesToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01bfe63a-8540-4606-96da-f1cb874b6474");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2f7cbe8-885c-476c-ad57-dce143256ce0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ffb2911-c646-4479-bf8f-4fca3b85bdc8", "6b153dd7-a3cd-477c-88c4-b646341e0ba5", "Admin", "admin" },
                    { "c92eac14-9308-4164-b162-4811631ec37a", "f9bbdc80-1af6-4621-8736-7f679c7bcd42", "User", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ffb2911-c646-4479-bf8f-4fca3b85bdc8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c92eac14-9308-4164-b162-4811631ec37a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01bfe63a-8540-4606-96da-f1cb874b6474", "9bfbf436-1e10-4036-b296-a71ae691481f", "Admin", "admin" },
                    { "d2f7cbe8-885c-476c-ad57-dce143256ce0", "6d0bc20a-4f04-447b-bdbb-eabb53d99126", "Member", "member" }
                });
        }
    }
}
