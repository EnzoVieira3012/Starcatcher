using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AddClientToQuota : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Quotas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quotas_ClientId",
                table: "Quotas",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotas_Clients_ClientId",
                table: "Quotas",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotas_Clients_ClientId",
                table: "Quotas");

            migrationBuilder.DropIndex(
                name: "IX_Quotas_ClientId",
                table: "Quotas");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Quotas");
        }
    }
}
