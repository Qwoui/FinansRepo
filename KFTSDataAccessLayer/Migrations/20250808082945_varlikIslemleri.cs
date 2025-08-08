using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KFTSDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class varlikIslemleri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Varlik_Turs_TurId",
                table: "Varlik");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Varlik",
                table: "Varlik");

            migrationBuilder.RenameTable(
                name: "Varlik",
                newName: "Varliks");

            migrationBuilder.RenameIndex(
                name: "IX_Varlik_TurId",
                table: "Varliks",
                newName: "IX_Varliks_TurId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Varliks",
                table: "Varliks",
                column: "VarlikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Varliks_Turs_TurId",
                table: "Varliks",
                column: "TurId",
                principalTable: "Turs",
                principalColumn: "TurId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Varliks_Turs_TurId",
                table: "Varliks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Varliks",
                table: "Varliks");

            migrationBuilder.RenameTable(
                name: "Varliks",
                newName: "Varlik");

            migrationBuilder.RenameIndex(
                name: "IX_Varliks_TurId",
                table: "Varlik",
                newName: "IX_Varlik_TurId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Varlik",
                table: "Varlik",
                column: "VarlikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Varlik_Turs_TurId",
                table: "Varlik",
                column: "TurId",
                principalTable: "Turs",
                principalColumn: "TurId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
