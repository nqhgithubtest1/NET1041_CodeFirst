using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bai4_1.Migrations
{
    /// <inheritdoc />
    public partial class setnull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DongVat_Chuong_ChuongID",
                table: "DongVat");

            migrationBuilder.AlterColumn<int>(
                name: "ChuongID",
                table: "DongVat",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_DongVat_Chuong_ChuongID",
                table: "DongVat",
                column: "ChuongID",
                principalTable: "Chuong",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DongVat_Chuong_ChuongID",
                table: "DongVat");

            migrationBuilder.AlterColumn<int>(
                name: "ChuongID",
                table: "DongVat",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DongVat_Chuong_ChuongID",
                table: "DongVat",
                column: "ChuongID",
                principalTable: "Chuong",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
