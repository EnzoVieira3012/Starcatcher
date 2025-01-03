using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Starcatcher.Api.Migrations
{
    /// <inheritdoc />
    public partial class DbContextRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 40, 22, 301, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 40, 22, 301, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 40, 22, 301, DateTimeKind.Local).AddTicks(8170));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
