using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestionProjectCore.Migrations
{
    /// <inheritdoc />
    public partial class makingProfilePictureNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b10ee5d-bf6b-422b-ad41-8c1be2a794e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b70151a-0bf5-44ad-b6ef-9b64a65b4dfa");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "547d40cb-a087-497f-aa0e-9e59138e1415", "0d92f100-44a0-41dc-addd-cbf1e36df95e", "User", "user" },
                    { "6a9004c0-08a7-4de9-aede-3405c4b12963", "b61f374a-5d78-4c3d-af21-4a54f2baff06", "Manager", "manager" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "547d40cb-a087-497f-aa0e-9e59138e1415");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a9004c0-08a7-4de9-aede-3405c4b12963");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b10ee5d-bf6b-422b-ad41-8c1be2a794e7", "196a86e4-cc5b-4797-bff1-9bd97be3bf9c", "Member", "member" },
                    { "4b70151a-0bf5-44ad-b6ef-9b64a65b4dfa", "041bb6df-ea6a-4d5a-9e99-83ff18c55891", "Admin", "admin" }
                });
        }
    }
}
