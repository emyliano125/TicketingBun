using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class Nomenclatoare : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idUnitateExpeditoare",
                table: "Tickets",
                newName: "UnitateExpeditoareId");

            migrationBuilder.RenameColumn(
                name: "idTipSolicitare",
                table: "Tickets",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "idStatus",
                table: "Tickets",
                newName: "SolicitareId");

            migrationBuilder.RenameColumn(
                name: "idServiciuAsignat",
                table: "Tickets",
                newName: "ServiciuId");

            migrationBuilder.AddColumn<int>(
                name: "UnitaeId",
                table: "Tickets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Servicii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Denumire = table.Column<string>(type: "TEXT", nullable: true),
                    Prescurtare = table.Column<string>(type: "TEXT", nullable: true),
                    Valid = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statusuri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Denumire = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statusuri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unitati",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Denumire = table.Column<string>(type: "TEXT", nullable: true),
                    Prescurtare = table.Column<string>(type: "TEXT", nullable: true),
                    Valid = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unitati", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Solicitari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Denumire = table.Column<string>(type: "TEXT", nullable: true),
                    ServiciuAsignatId = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiciuId = table.Column<int>(type: "INTEGER", nullable: true),
                    Valid = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Solicitari_Servicii_ServiciuId",
                        column: x => x.ServiciuId,
                        principalTable: "Servicii",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ServiciuId",
                table: "Tickets",
                column: "ServiciuId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SolicitareId",
                table: "Tickets",
                column: "SolicitareId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UnitaeId",
                table: "Tickets",
                column: "UnitaeId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitari_ServiciuId",
                table: "Solicitari",
                column: "ServiciuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Servicii_ServiciuId",
                table: "Tickets",
                column: "ServiciuId",
                principalTable: "Servicii",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Solicitari_SolicitareId",
                table: "Tickets",
                column: "SolicitareId",
                principalTable: "Solicitari",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Statusuri_StatusId",
                table: "Tickets",
                column: "StatusId",
                principalTable: "Statusuri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Unitati_UnitaeId",
                table: "Tickets",
                column: "UnitateId",
                principalTable: "Unitati",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Servicii_ServiciuId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Solicitari_SolicitareId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Statusuri_StatusId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Unitati_UnitaeId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Solicitari");

            migrationBuilder.DropTable(
                name: "Statusuri");

            migrationBuilder.DropTable(
                name: "Unitati");

            migrationBuilder.DropTable(
                name: "Servicii");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ServiciuId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_SolicitareId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_UnitaeId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "UnitaeId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "UnitateExpeditoareId",
                table: "Tickets",
                newName: "idUnitateExpeditoare");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Tickets",
                newName: "idTipSolicitare");

            migrationBuilder.RenameColumn(
                name: "SolicitareId",
                table: "Tickets",
                newName: "idStatus");

            migrationBuilder.RenameColumn(
                name: "ServiciuId",
                table: "Tickets",
                newName: "idServiciuAsignat");
        }
    }
}
