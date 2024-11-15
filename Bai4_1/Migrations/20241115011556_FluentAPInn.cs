using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bai4_1.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPInn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThucAn",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThucAn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThucAn", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DongVatThucAn",
                columns: table => new
                {
                    DongVatsID = table.Column<int>(type: "int", nullable: false),
                    ThucAnsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongVatThucAn", x => new { x.DongVatsID, x.ThucAnsID });
                    table.ForeignKey(
                        name: "FK_DongVatThucAn_DongVat_DongVatsID",
                        column: x => x.DongVatsID,
                        principalTable: "DongVat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DongVatThucAn_ThucAn_ThucAnsID",
                        column: x => x.ThucAnsID,
                        principalTable: "ThucAn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DongVatThucAn_ThucAnsID",
                table: "DongVatThucAn",
                column: "ThucAnsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DongVatThucAn");

            migrationBuilder.DropTable(
                name: "ThucAn");
        }
    }
}
