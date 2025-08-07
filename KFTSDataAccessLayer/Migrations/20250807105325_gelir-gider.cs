using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KFTSDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class gelirgider : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Giders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KullanıcıKullaniciId",
                table: "Giders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Gelirs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KullanıcıKullaniciId",
                table: "Gelirs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Giders_KullanıcıKullaniciId",
                table: "Giders",
                column: "KullanıcıKullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Gelirs_KullanıcıKullaniciId",
                table: "Gelirs",
                column: "KullanıcıKullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gelirs_Kullanıcıs_KullanıcıKullaniciId",
                table: "Gelirs",
                column: "KullanıcıKullaniciId",
                principalTable: "Kullanıcıs",
                principalColumn: "KullaniciId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Giders_Kullanıcıs_KullanıcıKullaniciId",
                table: "Giders",
                column: "KullanıcıKullaniciId",
                principalTable: "Kullanıcıs",
                principalColumn: "KullaniciId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gelirs_Kullanıcıs_KullanıcıKullaniciId",
                table: "Gelirs");

            migrationBuilder.DropForeignKey(
                name: "FK_Giders_Kullanıcıs_KullanıcıKullaniciId",
                table: "Giders");

            migrationBuilder.DropIndex(
                name: "IX_Giders_KullanıcıKullaniciId",
                table: "Giders");

            migrationBuilder.DropIndex(
                name: "IX_Gelirs_KullanıcıKullaniciId",
                table: "Gelirs");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Giders");

            migrationBuilder.DropColumn(
                name: "KullanıcıKullaniciId",
                table: "Giders");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Gelirs");

            migrationBuilder.DropColumn(
                name: "KullanıcıKullaniciId",
                table: "Gelirs");
        }
    }
}
