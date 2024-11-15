using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bai4_1.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPI1n : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChuongID",
                table: "DongVat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Chuong",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuong = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chuong", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DongVat_ChuongID",
                table: "DongVat",
                column: "ChuongID");

            migrationBuilder.AddForeignKey(
                name: "FK_DongVat_Chuong_ChuongID",
                table: "DongVat",
                column: "ChuongID",
                principalTable: "Chuong",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DongVat_Chuong_ChuongID",
                table: "DongVat");

            migrationBuilder.DropTable(
                name: "Chuong");

            migrationBuilder.DropIndex(
                name: "IX_DongVat_ChuongID",
                table: "DongVat");

            migrationBuilder.DropColumn(
                name: "ChuongID",
                table: "DongVat");
        }
    }
}
