using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KFTSDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class gelirIslemleri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Gelirs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Gelirs_Kullanıcıs_KullaniciId",
                table: "Gelirs",
                column: "KullaniciId",
                principalTable: "Kullanıcıs",
                principalColumn: "KullaniciId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gelirs_Kullanıcıs_KullaniciId",
                table: "Gelirs");

            migrationBuilder.DropIndex(
                name: "IX_Gelirs_KullaniciId",
                table: "Gelirs");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Gelirs");
        }
    }
}
