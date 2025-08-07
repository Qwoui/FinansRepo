using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KFTSDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class gelirIslemleri3 : Migration
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Gelirs");
        }
    }
}
