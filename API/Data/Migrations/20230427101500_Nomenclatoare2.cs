using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class Nomenclatoare2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Unitati_UnitaeId",
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
                newName: "UnitateId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UnitateId",
                table: "Tickets",
                column: "UnitateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Unitati_UnitateId",
                table: "Tickets",
                column: "UnitateId",
                principalTable: "Unitati",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Unitati_UnitateId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_UnitateId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "UnitateId",
                table: "Tickets",
                newName: "UnitateExpeditoareId");

            migrationBuilder.AddColumn<int>(
                name: "UnitaeId",
                table: "Tickets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UnitaeId",
                table: "Tickets",
                column: "UnitaeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Unitati_UnitaeId",
                table: "Tickets",
                column: "UnitaeId",
                principalTable: "Unitati",
                principalColumn: "Id");
        }
    }
}
