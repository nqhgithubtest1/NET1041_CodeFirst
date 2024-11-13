using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bai4_1.Migrations
{
    /// <inheritdoc />
    public partial class Update1n : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Laptop",
                columns: table => new
                {
                    LaptopID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLaptop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SinhVienID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptop", x => x.LaptopID);
                    table.ForeignKey(
                        name: "FK_Laptop_SinhViens_SinhVienID",
                        column: x => x.SinhVienID,
                        principalTable: "SinhViens",
                        principalColumn: "SinhVienID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Laptop_SinhVienID",
                table: "Laptop",
                column: "SinhVienID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laptop");
        }
    }
}
