using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Starcatcher.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddWalletId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Wallets_WalletId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_WalletId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WalletId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 10, 40, 29, 127, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 10, 40, 29, 127, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 10, 40, 29, 127, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_UserId",
                table: "Wallets",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_Users_UserId",
                table: "Wallets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_Users_UserId",
                table: "Wallets");

            migrationBuilder.DropIndex(
                name: "IX_Wallets_UserId",
                table: "Wallets");

            migrationBuilder.AddColumn<int>(
                name: "WalletId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 17, 13, 23, 242, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 17, 13, 23, 242, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 17, 13, 23, 242, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.CreateIndex(
                name: "IX_Users_WalletId",
                table: "Users",
                column: "WalletId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Wallets_WalletId",
                table: "Users",
                column: "WalletId",
                principalTable: "Wallets",
                principalColumn: "WalletId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
