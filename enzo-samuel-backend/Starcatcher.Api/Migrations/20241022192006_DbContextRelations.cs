using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Starcatcher.Api.Migrations
{
    /// <inheritdoc />
    public partial class DbContextRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 20, 6, 128, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 20, 6, 128, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 20, 6, 128, DateTimeKind.Local).AddTicks(8663));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 22, 6, 5, 692, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 22, 6, 5, 692, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 22, 6, 5, 692, DateTimeKind.Local).AddTicks(3465));
        }
    }
}
