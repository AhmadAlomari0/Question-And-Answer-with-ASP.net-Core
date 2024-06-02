using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestionProjectCore.Migrations
{
    /// <inheritdoc />
    public partial class MoreInfoForUserTableAndChangingTablesNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Answers_Members_MemberID",
            //    table: "Answers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Questions_Members_MemberId",
            //    table: "Questions");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Reports_Members_memberID",
            //    table: "Reports");

            //migrationBuilder.DropTable(
            //    name: "Members");

            //migrationBuilder.DropTable(
            //    name: "Moderators");

            //migrationBuilder.DropIndex(
            //    name: "IX_Reports_memberID",
            //    table: "Reports");

            //migrationBuilder.DropIndex(
            //    name: "IX_Questions_MemberId",
            //    table: "Questions");

            //migrationBuilder.DropIndex(
            //    name: "IX_Answers_MemberID",
            //    table: "Answers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ffb2911-c646-4479-bf8f-4fca3b85bdc8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c92eac14-9308-4164-b162-4811631ec37a");

            //migrationBuilder.DropColumn(
            //    name: "memberID",
            //    table: "Reports");

            //migrationBuilder.DropColumn(
            //    name: "MemberId",
            //    table: "Questions");

            //migrationBuilder.DropColumn(
            //    name: "MemberID",
            //    table: "Answers");

            migrationBuilder.RenameColumn(
                name: "subject",
                table: "Reports",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Questions",
                newName: "UserId");

            //migrationBuilder.AddColumn<string>(
            //    name: "UserId",
            //    table: "Reports",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            //migrationBuilder.AddColumn<string>(
            //    name: "UserId",
            //    table: "Answers",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b10ee5d-bf6b-422b-ad41-8c1be2a794e7", "196a86e4-cc5b-4797-bff1-9bd97be3bf9c", "Manager", "manager" },
                    { "4b70151a-0bf5-44ad-b6ef-9b64a65b4dfa", "041bb6df-ea6a-4d5a-9e99-83ff18c55891", "User", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b10ee5d-bf6b-422b-ad41-8c1be2a794e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b70151a-0bf5-44ad-b6ef-9b64a65b4dfa");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Reports",
                newName: "subject");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Questions",
                newName: "UserID");

            //migrationBuilder.AddColumn<int>(
            //    name: "memberID",
            //    table: "Reports",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddColumn<int>(
            //    name: "MemberId",
            //    table: "Questions",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "MemberID",
            //    table: "Answers",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateTable(
            //    name: "Members",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        UserName = table.Column<string>(type: "nvarchar(450)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Members", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Moderators",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ModeratorAge = table.Column<int>(type: "int", nullable: true),
            //        ModeratorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ModeratorPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ModeratorSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        Moderatormail = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Moderators", x => x.Id);
            //    });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ffb2911-c646-4479-bf8f-4fca3b85bdc8", "6b153dd7-a3cd-477c-88c4-b646341e0ba5", "Admin", "admin" },
                    { "c92eac14-9308-4164-b162-4811631ec37a", "f9bbdc80-1af6-4621-8736-7f679c7bcd42", "Member", "member" }
                });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Reports_memberID",
            //    table: "Reports",
            //    column: "memberID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Questions_MemberId",
            //    table: "Questions",
            //    column: "MemberId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Answers_MemberID",
            //    table: "Answers",
            //    column: "MemberID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Members_UserName_PhoneNumber",
            //    table: "Members",
            //    columns: new[] { "UserName", "PhoneNumber" },
            //    unique: true);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Answers_Members_MemberID",
            //    table: "Answers",
            //    column: "MemberID",
            //    principalTable: "Members",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Questions_Members_MemberId",
            //    table: "Questions",
            //    column: "MemberId",
            //    principalTable: "Members",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Reports_Members_memberID",
            //    table: "Reports",
            //    column: "memberID",
            //    principalTable: "Members",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
