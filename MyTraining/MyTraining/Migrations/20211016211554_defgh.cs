using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTraining.Migrations
{
    public partial class defgh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empreq",
                columns: table => new
                {
                    Rid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Techname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuggestedTrainer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberofPart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empreq", x => x.Rid);
                });

            migrationBuilder.CreateTable(
                name: "ReportFs",
                columns: table => new
                {
                    Rid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Techname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuggestedTrainer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberofPart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportFs", x => x.Rid);
                });

            migrationBuilder.CreateTable(
                name: "UserModels",
                columns: table => new
                {
                    Empid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModels", x => x.Empid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empreq");

            migrationBuilder.DropTable(
                name: "ReportFs");

            migrationBuilder.DropTable(
                name: "UserModels");
        }
    }
}
