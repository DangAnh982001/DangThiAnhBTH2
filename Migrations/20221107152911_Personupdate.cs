using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DangThiAnhBTH2.Migrations
{
    public partial class Personupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StdName",
                table: "Person",
                newName: "PerName");

            migrationBuilder.RenameColumn(
                name: "StdID",
                table: "Person",
                newName: "PerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PerName",
                table: "Person",
                newName: "StdName");

            migrationBuilder.RenameColumn(
                name: "PerID",
                table: "Person",
                newName: "StdID");
        }
    }
}
