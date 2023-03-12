using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eRezervacija.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Leonkompjuter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetaljiHotela",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KonferencijskaSala = table.Column<bool>(type: "bit", nullable: false),
                    Bazen = table.Column<bool>(type: "bit", nullable: false),
                    Spa = table.Column<bool>(type: "bit", nullable: false),
                    Sauna = table.Column<bool>(type: "bit", nullable: false),
                    Teretana = table.Column<bool>(type: "bit", nullable: false),
                    Restoran = table.Column<bool>(type: "bit", nullable: false),
                    Kafic = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetaljiHotela", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetaljiSoba",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tv = table.Column<bool>(type: "bit", nullable: false),
                    WiFi = table.Column<bool>(type: "bit", nullable: false),
                    Kuhinja = table.Column<bool>(type: "bit", nullable: false),
                    DozvoljenoPusenje = table.Column<bool>(type: "bit", nullable: false),
                    KucniLjubimci = table.Column<bool>(type: "bit", nullable: false),
                    PrilagodjenoZaDjecu = table.Column<bool>(type: "bit", nullable: false),
                    Fen = table.Column<bool>(type: "bit", nullable: false),
                    Pegla = table.Column<bool>(type: "bit", nullable: false),
                    DodatniJastuci = table.Column<bool>(type: "bit", nullable: false),
                    Mikrovalna = table.Column<bool>(type: "bit", nullable: false),
                    KafeAparat = table.Column<bool>(type: "bit", nullable: false),
                    Kuhalo = table.Column<bool>(type: "bit", nullable: false),
                    OcistitiPrijeOdlaska = table.Column<bool>(type: "bit", nullable: false),
                    Kupatilo = table.Column<bool>(type: "bit", nullable: false),
                    Klima = table.Column<bool>(type: "bit", nullable: false),
                    Grijanje = table.Column<bool>(type: "bit", nullable: false),
                    Balkon = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetaljiSoba", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uloga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Spol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datumrodjenja = table.Column<DateTime>(name: "Datum_rodjenja", type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brojtelefona = table.Column<string>(name: "Broj_telefona", type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumPromjene = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KreditneKartice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojKartice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSV = table.Column<int>(type: "int", nullable: false),
                    DatumIsteka = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KreditneKartice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostanskiBroj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrzavaID = table.Column<int>(type: "int", nullable: false),
                    slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    BrojHotelaUGradu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gradovi_Drzave_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "Drzave",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Admini",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admini", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admini_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AutentifikacijaTokeni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vrijednost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    ipAdresa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutentifikacijaTokeni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutentifikacijaTokeni_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Vlasnici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    BrojBankovnogRacuna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojLicneKarte = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vlasnici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vlasnici_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Gosti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    KreditnaKarticaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gosti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gosti_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Gosti_KreditneKartice_KreditnaKarticaID",
                        column: x => x.KreditnaKarticaID,
                        principalTable: "KreditneKartice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Hoteli",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VlasnikID = table.Column<int>(type: "int", nullable: false),
                    HotelDetaljiID = table.Column<int>(type: "int", nullable: false),
                    EmailHotela = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Hoteli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hoteli_DetaljiHotela_HotelDetaljiID",
                        column: x => x.HotelDetaljiID,
                        principalTable: "DetaljiHotela",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Hoteli_Gradovi_GradID",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Hoteli_Vlasnici_VlasnikID",
                        column: x => x.VlasnikID,
                        principalTable: "Vlasnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Recenzije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    GostId = table.Column<int>(type: "int", nullable: false),
                    Ocjena = table.Column<int>(type: "int", nullable: false),
                    Komentar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzije", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recenzije_Gosti_GostId",
                        column: x => x.GostId,
                        principalTable: "Gosti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GostId = table.Column<int>(type: "int", nullable: false),
                    DatumRezervacije = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumCheckIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumCheckOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrojGostiju = table.Column<int>(type: "int", nullable: false),
                    BrojOdraslih = table.Column<int>(type: "int", nullable: false),
                    BrojDjece = table.Column<int>(type: "int", nullable: false),
                    NacinPlacanja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cijena = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacije", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rezervacije_Gosti_GostId",
                        column: x => x.GostId,
                        principalTable: "Gosti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Parkinzi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelID = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parkinzi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parkinzi_Hoteli_HotelID",
                        column: x => x.HotelID,
                        principalTable: "Hoteli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PlanoviOtkazivanja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelID = table.Column<int>(type: "int", nullable: false),
                    OtkazivanjeBesplatnoDo = table.Column<int>(type: "int", nullable: false),
                    PostotakCijene = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoviOtkazivanja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanoviOtkazivanja_Hoteli_HotelID",
                        column: x => x.HotelID,
                        principalTable: "Hoteli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Sobe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelID = table.Column<int>(type: "int", nullable: false),
                    SobaDetaljiID = table.Column<int>(type: "int", nullable: false),
                    Kapacitet = table.Column<int>(type: "int", nullable: false),
                    Sprat = table.Column<int>(type: "int", nullable: false),
                    BrojKreveta = table.Column<int>(type: "int", nullable: false),
                    BrojKrevetaZaJednuOsobu = table.Column<int>(type: "int", nullable: false),
                    BrojKrevetaNaSprat = table.Column<int>(type: "int", nullable: false),
                    BrojBracnihKreveta = table.Column<int>(type: "int", nullable: false),
                    MogucnostDodavanjaDjecijegKreveta = table.Column<bool>(type: "bit", nullable: false),
                    UkupnaCijena = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sobe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sobe_DetaljiSoba_SobaDetaljiID",
                        column: x => x.SobaDetaljiID,
                        principalTable: "DetaljiSoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Sobe_Hoteli_HotelID",
                        column: x => x.HotelID,
                        principalTable: "Hoteli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ParkingMjesta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParkingID = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sprat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingMjesta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParkingMjesta_Parkinzi_ParkingID",
                        column: x => x.ParkingID,
                        principalTable: "Parkinzi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RezervacijaSobe",
                columns: table => new
                {
                    RezervacijaID = table.Column<int>(type: "int", nullable: false),
                    SobaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervacijaSobe", x => new { x.RezervacijaID, x.SobaID });
                    table.ForeignKey(
                        name: "FK_RezervacijaSobe_Rezervacije_RezervacijaID",
                        column: x => x.RezervacijaID,
                        principalTable: "Rezervacije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RezervacijaSobe_Sobe_SobaID",
                        column: x => x.SobaID,
                        principalTable: "Sobe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Slike",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SobaID = table.Column<int>(type: "int", nullable: false),
                    SlikaByteArray = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slike", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slike_Sobe_SobaID",
                        column: x => x.SobaID,
                        principalTable: "Sobe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admini_KorisnikID",
                table: "Admini",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_AutentifikacijaTokeni_KorisnikID",
                table: "AutentifikacijaTokeni",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Gosti_KorisnikID",
                table: "Gosti",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Gosti_KreditnaKarticaID",
                table: "Gosti",
                column: "KreditnaKarticaID");

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_DrzavaID",
                table: "Gradovi",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Hoteli_GradID",
                table: "Hoteli",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Hoteli_HotelDetaljiID",
                table: "Hoteli",
                column: "HotelDetaljiID");

            migrationBuilder.CreateIndex(
                name: "IX_Hoteli_VlasnikID",
                table: "Hoteli",
                column: "VlasnikID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingMjesta_ParkingID",
                table: "ParkingMjesta",
                column: "ParkingID");

            migrationBuilder.CreateIndex(
                name: "IX_Parkinzi_HotelID",
                table: "Parkinzi",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_PlanoviOtkazivanja_HotelID",
                table: "PlanoviOtkazivanja",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzije_GostId",
                table: "Recenzije",
                column: "GostId");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaSobe_SobaID",
                table: "RezervacijaSobe",
                column: "SobaID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_GostId",
                table: "Rezervacije",
                column: "GostId");

            migrationBuilder.CreateIndex(
                name: "IX_Slike_SobaID",
                table: "Slike",
                column: "SobaID");

            migrationBuilder.CreateIndex(
                name: "IX_Sobe_HotelID",
                table: "Sobe",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_Sobe_SobaDetaljiID",
                table: "Sobe",
                column: "SobaDetaljiID");

            migrationBuilder.CreateIndex(
                name: "IX_Vlasnici_KorisnikID",
                table: "Vlasnici",
                column: "KorisnikID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admini");

            migrationBuilder.DropTable(
                name: "AutentifikacijaTokeni");

            migrationBuilder.DropTable(
                name: "ParkingMjesta");

            migrationBuilder.DropTable(
                name: "PlanoviOtkazivanja");

            migrationBuilder.DropTable(
                name: "Recenzije");

            migrationBuilder.DropTable(
                name: "RezervacijaSobe");

            migrationBuilder.DropTable(
                name: "Slike");

            migrationBuilder.DropTable(
                name: "Parkinzi");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "Sobe");

            migrationBuilder.DropTable(
                name: "Gosti");

            migrationBuilder.DropTable(
                name: "DetaljiSoba");

            migrationBuilder.DropTable(
                name: "Hoteli");

            migrationBuilder.DropTable(
                name: "KreditneKartice");

            migrationBuilder.DropTable(
                name: "DetaljiHotela");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Vlasnici");

            migrationBuilder.DropTable(
                name: "Drzave");

            migrationBuilder.DropTable(
                name: "Korisnici");
        }
    }
}
