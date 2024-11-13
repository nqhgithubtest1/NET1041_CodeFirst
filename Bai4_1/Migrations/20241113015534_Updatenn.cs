using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bai4_1.Migrations
{
    /// <inheritdoc />
    public partial class Updatenn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    LopHocID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLopHoc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.LopHocID);
                });

            migrationBuilder.CreateTable(
                name: "LopHocSinhVien",
                columns: table => new
                {
                    LopHocsLopHocID = table.Column<int>(type: "int", nullable: false),
                    SinhViensSinhVienID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHocSinhVien", x => new { x.LopHocsLopHocID, x.SinhViensSinhVienID });
                    table.ForeignKey(
                        name: "FK_LopHocSinhVien_LopHoc_LopHocsLopHocID",
                        column: x => x.LopHocsLopHocID,
                        principalTable: "LopHoc",
                        principalColumn: "LopHocID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LopHocSinhVien_SinhViens_SinhViensSinhVienID",
                        column: x => x.SinhViensSinhVienID,
                        principalTable: "SinhViens",
                        principalColumn: "SinhVienID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LopHocSinhVien_SinhViensSinhVienID",
                table: "LopHocSinhVien",
                column: "SinhViensSinhVienID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LopHocSinhVien");

            migrationBuilder.DropTable(
                name: "LopHoc");
        }
    }
}
