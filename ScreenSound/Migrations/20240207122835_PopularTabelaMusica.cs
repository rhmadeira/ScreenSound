using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabelaMusica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Musicas",
                columns: new[] { "Id", "AnoLancamento", "Nome" },
                values: new object[] { 1, 1991, "Smells Like Teen Spirit" });
            
            migrationBuilder.InsertData(
                table: "Musicas",
                columns: new[] { "Id", "AnoLancamento", "Nome" },
                values: new object[] { 2, 1991, "Come As You Are" });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("DELETE FROM Musicas");

        }
    }
}
