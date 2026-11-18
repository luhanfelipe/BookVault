using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookVault.API.Migrations
{
    /// <inheritdoc />
    public partial class AjustaPrecisaoNota : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Nota",
                table: "Livros",
                type: "decimal(2,1)",
                precision: 2,
                scale: 1,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Nota",
                table: "Livros",
                type: "decimal(65,30)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldPrecision: 2,
                oldScale: 1,
                oldNullable: true);
        }
    }
}
