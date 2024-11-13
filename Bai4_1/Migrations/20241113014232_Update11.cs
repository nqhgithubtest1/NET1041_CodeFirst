using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bai4_1.Migrations
{
    /// <inheritdoc />
    public partial class Update11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaChis",
                columns: table => new
                {
                    DiaChiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThanhPho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuanHuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XaPhuong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoNha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SinhVienID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaChis", x => x.DiaChiID);
                });

            migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    SinhVienID = table.Column<int>(type: "int", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.SinhVienID);
                    table.ForeignKey(
                        name: "FK_SinhViens_DiaChis_SinhVienID",
                        column: x => x.SinhVienID,
                        principalTable: "DiaChis",
                        principalColumn: "DiaChiID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhViens");

            migrationBuilder.DropTable(
                name: "DiaChis");
        }
    }
}
