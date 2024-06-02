﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuestionProjectCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.ID);
            //    });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Like = table.Column<int>(type: "int", nullable: false),
                    TheQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    //userID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    //table.ForeignKey(
                    //    name: "FK_Question_Users_userID",
                    //    column: x => x.userID,
                    //    principalTable: "Users",
                    //    principalColumn: "ID",
                    //    onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                    //userID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.Id);
                    //table.ForeignKey(
                    //    name: "FK_Report_Users_userID",
                    //    column: x => x.userID,
                    //    principalTable: "Users",
                    //    principalColumn: "ID",
                    //    onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Like = table.Column<int>(type: "int", nullable: false),
                    TheAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    //UserID = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answer_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "Id");
                    //table.ForeignKey(
                    //    name: "FK_Answer_Users_UserID",
                    //    column: x => x.UserID,
                    //    principalTable: "Users",
                    //    principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionID",
                table: "Answers",
                column: "QuestionID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Answer_UserID",
            //    table: "Answer",
            //    column: "UserID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Question_userID",
            //    table: "Question",
            //    column: "userID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Report_userID",
            //    table: "Report",
            //    column: "userID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_UserName_PhoneNumber",
            //    table: "Users",
            //    columns: new[] { "UserName", "PhoneNumber" },
            //    unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Questions");

            //migrationBuilder.DropTable(
            //    name: "Users");
        }
    }
}
