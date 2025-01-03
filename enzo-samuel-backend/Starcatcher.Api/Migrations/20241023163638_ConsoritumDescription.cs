using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Starcatcher.Api.Migrations
{
    /// <inheritdoc />
    public partial class ConsoritumDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), "Consórcio para Carros Populares" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), "Consórcio para Carros Luxuosos" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), "Consórcio para Motos Populares" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), "Consórcio para Imóveis Residenciais" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), "Consórcio para Viagens Internacionais" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), "Consórcio para Viagens Nacionais" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), "Consórcio para Reforma de Imóveis" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), "Consórcio para Equipamentos Eletrônicos" });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 429, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 13, 36, 37, 428, DateTimeKind.Local).AddTicks(6476), new DateTime(2024, 10, 23, 13, 36, 37, 430, DateTimeKind.Local).AddTicks(2169) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), "Consórcio para carroaquisição de veículos" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), "Consórcio para carroluxo" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), "Consórcio para motoaquisição de veículos" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), "Consórcio para imoveisresidenciais" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), "Consórcio para viagensinternacionais" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), "Consórcio para viagensnacionais" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), "Consórcio para reformaimóvel" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), "Consórcio para equipamentoseletrônicos" });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7264) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 421, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 52, 25, 420, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 10, 23, 11, 52, 25, 422, DateTimeKind.Local).AddTicks(975) });
        }
    }
}
