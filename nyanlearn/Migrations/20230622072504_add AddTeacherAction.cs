using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nyanlearn.Migrations
{
    public partial class addAddTeacherAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "Teacher",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NRC",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DOB",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "NRC",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Teacher");
        }
    }
}
