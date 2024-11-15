using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bai4_1.Migrations
{
    /// <inheritdoc />
    public partial class restrict : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DongVat_Chuong_ChuongID",
                table: "DongVat");

            migrationBuilder.AddForeignKey(
                name: "FK_DongVat_Chuong_ChuongID",
                table: "DongVat",
                column: "ChuongID",
                principalTable: "Chuong",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DongVat_Chuong_ChuongID",
                table: "DongVat");

            migrationBuilder.AddForeignKey(
                name: "FK_DongVat_Chuong_ChuongID",
                table: "DongVat",
                column: "ChuongID",
                principalTable: "Chuong",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
