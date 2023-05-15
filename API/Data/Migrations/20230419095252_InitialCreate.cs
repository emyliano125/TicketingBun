using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idTipSolicitare = table.Column<int>(type: "INTEGER", nullable: false),
                    idUserExpeditor = table.Column<int>(type: "INTEGER", nullable: false),
                    emailSolicitant = table.Column<string>(type: "TEXT", nullable: true),
                    tlfnInteriorSolicitant = table.Column<string>(type: "TEXT", nullable: true),
                    tlfMobilSolicitant = table.Column<string>(type: "TEXT", nullable: true),
                    Descriere = table.Column<string>(type: "TEXT", nullable: true),
                    idStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    MyProperty = table.Column<int>(type: "INTEGER", nullable: false),
                    idLucratorAsignat = table.Column<int>(type: "INTEGER", nullable: false),
                    idServiciuAsignat = table.Column<int>(type: "INTEGER", nullable: false),
                    Valid = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
