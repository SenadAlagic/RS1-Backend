using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eRezervacija.Repository.Migrations
{
    /// <inheritdoc />
    public partial class hotelzahtjev : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZahtjeviZaHotele",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vlasnik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailHotela = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UkupanBrojSoba = table.Column<int>(type: "int", nullable: false),
                    BrojJednokrevetnihSoba = table.Column<int>(type: "int", nullable: false),
                    BrojDvokrevetnihSoba = table.Column<int>(type: "int", nullable: false),
                    BrojTrokrevetnihSoba = table.Column<int>(type: "int", nullable: false),
                    BrojSpratova = table.Column<int>(type: "int", nullable: false),
                    VrijemeCheckIna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VrijemeCheckOuta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZahtjeviZaHotele", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZahtjeviZaHotele");
        }
    }
}
