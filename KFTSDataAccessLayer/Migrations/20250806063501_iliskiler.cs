using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KFTSDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class iliskiler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Miktar",
                table: "Giders",
                newName: "GiderMiktar");

            migrationBuilder.RenameColumn(
                name: "Miktar",
                table: "Gelirs",
                newName: "GelirMiktar");

            migrationBuilder.AddColumn<int>(
                name: "RolId",
                table: "Kullanıcıs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TurId",
                table: "Giders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TurId",
                table: "Gelirs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Kullanıcıs_RolId",
                table: "Kullanıcıs",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_Giders_TurId",
                table: "Giders",
                column: "TurId");

            migrationBuilder.CreateIndex(
                name: "IX_Gelirs_TurId",
                table: "Gelirs",
                column: "TurId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gelirs_Turs_TurId",
                table: "Gelirs",
                column: "TurId",
                principalTable: "Turs",
                principalColumn: "TurId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Giders_Turs_TurId",
                table: "Giders",
                column: "TurId",
                principalTable: "Turs",
                principalColumn: "TurId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanıcıs_Rols_RolId",
                table: "Kullanıcıs",
                column: "RolId",
                principalTable: "Rols",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gelirs_Turs_TurId",
                table: "Gelirs");

            migrationBuilder.DropForeignKey(
                name: "FK_Giders_Turs_TurId",
                table: "Giders");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanıcıs_Rols_RolId",
                table: "Kullanıcıs");

            migrationBuilder.DropIndex(
                name: "IX_Kullanıcıs_RolId",
                table: "Kullanıcıs");

            migrationBuilder.DropIndex(
                name: "IX_Giders_TurId",
                table: "Giders");

            migrationBuilder.DropIndex(
                name: "IX_Gelirs_TurId",
                table: "Gelirs");

            migrationBuilder.DropColumn(
                name: "RolId",
                table: "Kullanıcıs");

            migrationBuilder.DropColumn(
                name: "TurId",
                table: "Giders");

            migrationBuilder.DropColumn(
                name: "TurId",
                table: "Gelirs");

            migrationBuilder.RenameColumn(
                name: "GiderMiktar",
                table: "Giders",
                newName: "Miktar");

            migrationBuilder.RenameColumn(
                name: "GelirMiktar",
                table: "Gelirs",
                newName: "Miktar");
        }
    }
}
