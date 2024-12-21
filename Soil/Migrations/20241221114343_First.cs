using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soil.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SoilDatas",
                columns: table => new
                {
                    SceneId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ViewId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cloud = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Q1 = table.Column<double>(type: "float", nullable: false),
                    Q3 = table.Column<double>(type: "float", nullable: false),
                    Max = table.Column<double>(type: "float", nullable: false),
                    Min = table.Column<double>(type: "float", nullable: false),
                    P10 = table.Column<double>(type: "float", nullable: false),
                    P90 = table.Column<double>(type: "float", nullable: false),
                    Std = table.Column<double>(type: "float", nullable: false),
                    Median = table.Column<double>(type: "float", nullable: false),
                    Average = table.Column<double>(type: "float", nullable: false),
                    Variance = table.Column<double>(type: "float", nullable: false),
                    Ctime10 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoilDatas", x => x.SceneId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoilDatas");
        }
    }
}
