using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KFTSDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class varlikEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Varlik",
                columns: table => new
                {
                    VarlikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VarlikAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VarlikFiyat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VarlikAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varlik", x => x.VarlikId);
                    table.ForeignKey(
                        name: "FK_Varlik_Turs_TurId",
                        column: x => x.TurId,
                        principalTable: "Turs",
                        principalColumn: "TurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Varlik_TurId",
                table: "Varlik",
                column: "TurId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Varlik");
        }
    }
}
