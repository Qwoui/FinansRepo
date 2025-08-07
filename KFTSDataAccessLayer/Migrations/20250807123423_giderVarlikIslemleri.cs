using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KFTSDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class giderVarlikIslemleri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Varlik",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Giders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Varlik");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Giders");
        }
    }
}
