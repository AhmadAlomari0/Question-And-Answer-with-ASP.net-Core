using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestionProjectCore.Migrations
{
    /// <inheritdoc />
    public partial class ChangeMemberIDToUserIDInQuestionsModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Questions_Categories_CategoryID",
            //    table: "Questions");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Questions_Members_MemberID",
            //    table: "Questions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e03106a-55d2-4904-bf98-116e08f7c2f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac2ed0c8-c16e-4844-b0e0-489366c3799e");

            //migrationBuilder.RenameColumn(
            //    name: "MemberID",
            //    table: "Questions",
            //    newName: "MemberId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Questions_MemberID",
            //    table: "Questions",
            //    newName: "IX_Questions_MemberId");

            //migrationBuilder.AlterColumn<int>(
            //    name: "MemberId",
            //    table: "Questions",
            //    type: "int",
            //    nullable: true,
            //    oldClrType: typeof(int),
            //    oldType: "int");

            //migrationBuilder.AlterColumn<int>(
            //    name: "CategoryID",
            //    table: "Questions",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0,
            //    oldClrType: typeof(int),
            //    oldType: "int",
            //    oldNullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "UserID",
            //    table: "Questions",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01bfe63a-8540-4606-96da-f1cb874b6474", "9bfbf436-1e10-4036-b296-a71ae691481f", "Admin", "admin" },
                    { "d2f7cbe8-885c-476c-ad57-dce143256ce0", "6d0bc20a-4f04-447b-bdbb-eabb53d99126", "Member", "member" }
                });

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Questions_Categories_CategoryID",
            //    table: "Questions",
            //    column: "CategoryID",
            //    principalTable: "Categories",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Questions_Members_MemberId",
            //    table: "Questions",
            //    column: "MemberId",
            //    principalTable: "Members",
            //    principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Questions_Categories_CategoryID",
            //    table: "Questions");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Questions_Members_MemberId",
            //    table: "Questions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01bfe63a-8540-4606-96da-f1cb874b6474");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2f7cbe8-885c-476c-ad57-dce143256ce0");

            //migrationBuilder.DropColumn(
            //    name: "UserID",
            //    table: "Questions");

            //migrationBuilder.RenameColumn(
            //    name: "MemberId",
            //    table: "Questions",
            //    newName: "MemberID");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Questions_MemberId",
            //    table: "Questions",
            //    newName: "IX_Questions_MemberID");

            //migrationBuilder.AlterColumn<int>(
            //    name: "MemberID",
            //    table: "Questions",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0,
            //    oldClrType: typeof(int),
            //    oldType: "int",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "CategoryID",
            //    table: "Questions",
            //    type: "int",
            //    nullable: true,
            //    oldClrType: typeof(int),
            //    oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e03106a-55d2-4904-bf98-116e08f7c2f5", "a2ebaed9-ab90-46a6-abc8-e56384559153", "Member", "member" },
                    { "ac2ed0c8-c16e-4844-b0e0-489366c3799e", "63645dd9-5ef5-4682-98d3-42de99ec2306", "Admin", "admin" }
                });

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Questions_Categories_CategoryID",
            //    table: "Questions",
            //    column: "CategoryID",
            //    principalTable: "Categories",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Questions_Members_MemberID",
            //    table: "Questions",
            //    column: "MemberID",
            //    principalTable: "Members",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
