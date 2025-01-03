using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Starcatcher.Api.Migrations
{
    /// <inheritdoc />
    public partial class AllConsortiums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Consortia");

            migrationBuilder.AddColumn<int>(
                name: "AdministrationFee",
                table: "Consortia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "AssetValue",
                table: "Consortia",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "QuotaQuantity",
                table: "Consortia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Consortia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 1,
                columns: new[] { "AdministrationFee", "AssetValue", "CreatedAt", "Description", "QuotaQuantity", "Type" },
                values: new object[] { 15, 35000m, new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416), "Consórcio para carroaquisição de veículos", 36, 0 });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 2,
                columns: new[] { "AdministrationFee", "AssetValue", "CreatedAt", "Description", "QuotaQuantity", "Type" },
                values: new object[] { 12, 120000m, new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416), "Consórcio para carroluxo", 48, 1 });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 3,
                columns: new[] { "AdministrationFee", "AssetValue", "CreatedAt", "Description", "QuotaQuantity", "Type" },
                values: new object[] { 10, 12000m, new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416), "Consórcio para motoaquisição de veículos", 24, 2 });

            migrationBuilder.InsertData(
                table: "Consortia",
                columns: new[] { "ConsortiumId", "AdministrationFee", "AssetValue", "ClosedAt", "CreatedAt", "Description", "QuotaQuantity", "Type" },
                values: new object[,]
                {
                    { 4, 10, 50000m, null, new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416), "Consórcio para imoveisresidenciais", 120, 3 },
                    { 5, 14, 30000m, null, new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416), "Consórcio para viagensinternacionais", 24, 4 },
                    { 6, 10, 15000m, null, new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416), "Consórcio para viagensnacionais", 18, 5 },
                    { 7, 13, 50000m, null, new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416), "Consórcio para reformaimóvel", 36, 6 },
                    { 8, 18, 10000m, null, new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416), "Consórcio para equipamentoseletrônicos", 18, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "AdministrationFee",
                table: "Consortia");

            migrationBuilder.DropColumn(
                name: "AssetValue",
                table: "Consortia");

            migrationBuilder.DropColumn(
                name: "QuotaQuantity",
                table: "Consortia");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Consortia");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Consortia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 40, 29, 127, DateTimeKind.Local).AddTicks(8126), "Consórcio para aquisição de veículos", "Consórcio de Carros" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 40, 29, 127, DateTimeKind.Local).AddTicks(8131), "Consórcio para aquisição de imóveis", "Consórcio de Imóveis" });

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "Name" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 40, 29, 127, DateTimeKind.Local).AddTicks(8135), "Consórcio para aquisição de motocicletas", "Consórcio de Motos" });
        }
    }
}
