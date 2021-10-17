using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTraining.Migrations
{
    public partial class defghi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "ReportFs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Enddate",
                table: "ReportFs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TrainingMode",
                table: "ReportFs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "ReportFs");

            migrationBuilder.DropColumn(
                name: "Enddate",
                table: "ReportFs");

            migrationBuilder.DropColumn(
                name: "TrainingMode",
                table: "ReportFs");
        }
    }
}
