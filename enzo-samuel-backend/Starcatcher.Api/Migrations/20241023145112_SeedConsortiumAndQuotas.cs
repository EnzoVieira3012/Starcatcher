using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Starcatcher.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedConsortiumAndQuotas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.InsertData(
                table: "Quotas",
                columns: new[] { "QuotaId", "ConsortiumId", "CreatedAt", "DeletedAt", "QuotaNumber", "Status", "UpdatedAt", "UserId", "Value" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-1", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2971), null, 1118.0555555555555555555555555m },
                    { 2, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-2", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3024), null, 1118.0555555555555555555555555m },
                    { 3, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-3", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3044), null, 1118.0555555555555555555555555m },
                    { 4, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-4", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3063), null, 1118.0555555555555555555555555m },
                    { 5, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-5", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3083), null, 1118.0555555555555555555555555m },
                    { 6, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-6", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3105), null, 1118.0555555555555555555555555m },
                    { 7, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-7", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3124), null, 1118.0555555555555555555555555m },
                    { 8, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-8", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3142), null, 1118.0555555555555555555555555m },
                    { 9, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-9", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3162), null, 1118.0555555555555555555555555m },
                    { 10, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-10", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3182), null, 1118.0555555555555555555555555m },
                    { 11, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-11", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3203), null, 1118.0555555555555555555555555m },
                    { 12, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-12", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3222), null, 1118.0555555555555555555555555m },
                    { 13, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-13", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3240), null, 1118.0555555555555555555555555m },
                    { 14, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-14", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3259), null, 1118.0555555555555555555555555m },
                    { 15, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-15", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3278), null, 1118.0555555555555555555555555m },
                    { 16, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-16", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3297), null, 1118.0555555555555555555555555m },
                    { 17, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-17", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3316), null, 1118.0555555555555555555555555m },
                    { 18, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-18", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3400), null, 1118.0555555555555555555555555m },
                    { 19, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-19", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3419), null, 1118.0555555555555555555555555m },
                    { 20, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-20", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3438), null, 1118.0555555555555555555555555m },
                    { 21, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-21", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3456), null, 1118.0555555555555555555555555m },
                    { 22, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-22", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3475), null, 1118.0555555555555555555555555m },
                    { 23, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-23", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3493), null, 1118.0555555555555555555555555m },
                    { 24, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-24", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3512), null, 1118.0555555555555555555555555m },
                    { 25, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-25", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3531), null, 1118.0555555555555555555555555m },
                    { 26, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-26", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3550), null, 1118.0555555555555555555555555m },
                    { 27, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-27", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3569), null, 1118.0555555555555555555555555m },
                    { 28, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-28", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3587), null, 1118.0555555555555555555555555m },
                    { 29, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-29", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3606), null, 1118.0555555555555555555555555m },
                    { 30, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-30", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3624), null, 1118.0555555555555555555555555m },
                    { 31, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-31", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3643), null, 1118.0555555555555555555555555m },
                    { 32, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-32", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3661), null, 1118.0555555555555555555555555m },
                    { 33, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-33", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3679), null, 1118.0555555555555555555555555m },
                    { 34, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-34", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3700), null, 1118.0555555555555555555555555m },
                    { 35, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-35", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3718), null, 1118.0555555555555555555555555m },
                    { 36, 1, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "1-36", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(3737), null, 1118.0555555555555555555555555m },
                    { 37, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-1", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(4317), null, 2800m },
                    { 38, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-2", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(4339), null, 2800m },
                    { 39, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-3", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(4357), null, 2800m },
                    { 40, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-4", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(4375), null, 2800m },
                    { 41, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-5", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(4393), null, 2800m },
                    { 42, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-6", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(4459), null, 2800m },
                    { 43, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-7", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(4478), null, 2800m },
                    { 44, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-8", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(4495), null, 2800m },
                    { 45, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-9", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(4513), null, 2800m },
                    { 46, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-10", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(4531), null, 2800m },
                    { 47, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-11", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5270), null, 2800m },
                    { 48, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-12", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5307), null, 2800m },
                    { 49, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-13", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5325), null, 2800m },
                    { 50, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-14", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5342), null, 2800m },
                    { 51, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-15", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5360), null, 2800m },
                    { 52, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-16", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5377), null, 2800m },
                    { 53, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-17", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5395), null, 2800m },
                    { 54, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-18", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5412), null, 2800m },
                    { 55, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-19", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5429), null, 2800m },
                    { 56, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-20", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5447), null, 2800m },
                    { 57, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-21", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5464), null, 2800m },
                    { 58, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-22", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5481), null, 2800m },
                    { 59, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-23", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5498), null, 2800m },
                    { 60, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-24", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5515), null, 2800m },
                    { 61, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-25", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5533), null, 2800m },
                    { 62, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-26", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5550), null, 2800m },
                    { 63, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-27", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5567), null, 2800m },
                    { 64, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-28", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5722), null, 2800m },
                    { 65, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-29", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5783), null, 2800m },
                    { 66, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-30", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5819), null, 2800m },
                    { 67, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-31", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5844), null, 2800m },
                    { 68, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-32", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5869), null, 2800m },
                    { 69, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-33", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(5940), null, 2800m },
                    { 70, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-34", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6036), null, 2800m },
                    { 71, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-35", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6115), null, 2800m },
                    { 72, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-36", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6196), null, 2800m },
                    { 73, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-37", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6273), null, 2800m },
                    { 74, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-38", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6349), null, 2800m },
                    { 75, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-39", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6427), null, 2800m },
                    { 76, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-40", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6458), null, 2800m },
                    { 77, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-41", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6486), null, 2800m },
                    { 78, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-42", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6528), null, 2800m },
                    { 79, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-43", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6551), null, 2800m },
                    { 80, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-44", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6574), null, 2800m },
                    { 81, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-45", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6598), null, 2800m },
                    { 82, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-46", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6620), null, 2800m },
                    { 83, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-47", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6647), null, 2800m },
                    { 84, 2, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "2-48", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(6752), null, 2800m },
                    { 85, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-1", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7506), null, 550m },
                    { 86, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-2", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7527), null, 550m },
                    { 87, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-3", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7544), null, 550m },
                    { 88, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-4", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7561), null, 550m },
                    { 89, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-5", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7579), null, 550m },
                    { 90, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-6", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7596), null, 550m },
                    { 91, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-7", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7612), null, 550m },
                    { 92, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-8", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7629), null, 550m },
                    { 93, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-9", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7646), null, 550m },
                    { 94, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-10", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7663), null, 550m },
                    { 95, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-11", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7680), null, 550m },
                    { 96, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-12", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7745), null, 550m },
                    { 97, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-13", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7765), null, 550m },
                    { 98, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-14", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7783), null, 550m },
                    { 99, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-15", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7800), null, 550m },
                    { 100, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-16", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7817), null, 550m },
                    { 101, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-17", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7834), null, 550m },
                    { 102, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-18", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7851), null, 550m },
                    { 103, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-19", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7869), null, 550m },
                    { 104, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-20", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7885), null, 550m },
                    { 105, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-21", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7903), null, 550m },
                    { 106, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-22", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7920), null, 550m },
                    { 107, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-23", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7937), null, 550m },
                    { 108, 3, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "3-24", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(7954), null, 550m },
                    { 109, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-1", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(8945), null, 458.33333333333333333333333334m },
                    { 110, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-2", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(8969), null, 458.33333333333333333333333334m },
                    { 111, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-3", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(8988), null, 458.33333333333333333333333334m },
                    { 112, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-4", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9007), null, 458.33333333333333333333333334m },
                    { 113, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-5", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9026), null, 458.33333333333333333333333334m },
                    { 114, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-6", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9044), null, 458.33333333333333333333333334m },
                    { 115, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-7", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9063), null, 458.33333333333333333333333334m },
                    { 116, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-8", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9148), null, 458.33333333333333333333333334m },
                    { 117, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-9", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9166), null, 458.33333333333333333333333334m },
                    { 118, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-10", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9185), null, 458.33333333333333333333333334m },
                    { 119, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-11", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9204), null, 458.33333333333333333333333334m },
                    { 120, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-12", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9222), null, 458.33333333333333333333333334m },
                    { 121, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-13", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9241), null, 458.33333333333333333333333334m },
                    { 122, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-14", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9259), null, 458.33333333333333333333333334m },
                    { 123, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-15", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9277), null, 458.33333333333333333333333334m },
                    { 124, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-16", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9295), null, 458.33333333333333333333333334m },
                    { 125, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-17", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9314), null, 458.33333333333333333333333334m },
                    { 126, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-18", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9333), null, 458.33333333333333333333333334m },
                    { 127, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-19", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9352), null, 458.33333333333333333333333334m },
                    { 128, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-20", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9370), null, 458.33333333333333333333333334m },
                    { 129, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-21", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9389), null, 458.33333333333333333333333334m },
                    { 130, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-22", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9412), null, 458.33333333333333333333333334m },
                    { 131, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-23", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9432), null, 458.33333333333333333333333334m },
                    { 132, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-24", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9491), null, 458.33333333333333333333333334m },
                    { 133, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-25", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9513), null, 458.33333333333333333333333334m },
                    { 134, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-26", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9532), null, 458.33333333333333333333333334m },
                    { 135, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-27", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9551), null, 458.33333333333333333333333334m },
                    { 136, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-28", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9570), null, 458.33333333333333333333333334m },
                    { 137, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-29", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9588), null, 458.33333333333333333333333334m },
                    { 138, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-30", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9606), null, 458.33333333333333333333333334m },
                    { 139, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-31", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9624), null, 458.33333333333333333333333334m },
                    { 140, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-32", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9643), null, 458.33333333333333333333333334m },
                    { 141, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-33", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9662), null, 458.33333333333333333333333334m },
                    { 142, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-34", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9680), null, 458.33333333333333333333333334m },
                    { 143, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-35", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9698), null, 458.33333333333333333333333334m },
                    { 144, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-36", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9717), null, 458.33333333333333333333333334m },
                    { 145, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-37", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9736), null, 458.33333333333333333333333334m },
                    { 146, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-38", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9754), null, 458.33333333333333333333333334m },
                    { 147, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-39", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9773), null, 458.33333333333333333333333334m },
                    { 148, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-40", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9791), null, 458.33333333333333333333333334m },
                    { 149, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-41", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9810), null, 458.33333333333333333333333334m },
                    { 150, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-42", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9829), null, 458.33333333333333333333333334m },
                    { 151, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-43", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9848), null, 458.33333333333333333333333334m },
                    { 152, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-44", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9867), null, 458.33333333333333333333333334m },
                    { 153, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-45", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9886), null, 458.33333333333333333333333334m },
                    { 154, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-46", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9904), null, 458.33333333333333333333333334m },
                    { 155, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-47", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9971), null, 458.33333333333333333333333334m },
                    { 156, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-48", 0, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(9990), null, 458.33333333333333333333333334m },
                    { 157, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-49", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(8), null, 458.33333333333333333333333334m },
                    { 158, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-50", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(27), null, 458.33333333333333333333333334m },
                    { 159, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-51", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(45), null, 458.33333333333333333333333334m },
                    { 160, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-52", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(64), null, 458.33333333333333333333333334m },
                    { 161, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-53", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(83), null, 458.33333333333333333333333334m },
                    { 162, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-54", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(102), null, 458.33333333333333333333333334m },
                    { 163, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-55", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(121), null, 458.33333333333333333333333334m },
                    { 164, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-56", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(140), null, 458.33333333333333333333333334m },
                    { 165, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-57", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(159), null, 458.33333333333333333333333334m },
                    { 166, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-58", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(178), null, 458.33333333333333333333333334m },
                    { 167, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-59", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(196), null, 458.33333333333333333333333334m },
                    { 168, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-60", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(215), null, 458.33333333333333333333333334m },
                    { 169, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-61", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(234), null, 458.33333333333333333333333334m },
                    { 170, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-62", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(252), null, 458.33333333333333333333333334m },
                    { 171, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-63", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(271), null, 458.33333333333333333333333334m },
                    { 172, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-64", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(289), null, 458.33333333333333333333333334m },
                    { 173, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-65", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(308), null, 458.33333333333333333333333334m },
                    { 174, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-66", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(326), null, 458.33333333333333333333333334m },
                    { 175, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-67", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(344), null, 458.33333333333333333333333334m },
                    { 176, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-68", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(363), null, 458.33333333333333333333333334m },
                    { 177, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-69", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(456), null, 458.33333333333333333333333334m },
                    { 178, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-70", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(476), null, 458.33333333333333333333333334m },
                    { 179, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-71", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(495), null, 458.33333333333333333333333334m },
                    { 180, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-72", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(514), null, 458.33333333333333333333333334m },
                    { 181, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-73", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(533), null, 458.33333333333333333333333334m },
                    { 182, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-74", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(551), null, 458.33333333333333333333333334m },
                    { 183, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-75", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(570), null, 458.33333333333333333333333334m },
                    { 184, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-76", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(588), null, 458.33333333333333333333333334m },
                    { 185, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-77", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(606), null, 458.33333333333333333333333334m },
                    { 186, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-78", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(624), null, 458.33333333333333333333333334m },
                    { 187, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-79", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(643), null, 458.33333333333333333333333334m },
                    { 188, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-80", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(662), null, 458.33333333333333333333333334m },
                    { 189, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-81", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(681), null, 458.33333333333333333333333334m },
                    { 190, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-82", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(700), null, 458.33333333333333333333333334m },
                    { 191, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-83", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(718), null, 458.33333333333333333333333334m },
                    { 192, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-84", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(736), null, 458.33333333333333333333333334m },
                    { 193, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-85", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(754), null, 458.33333333333333333333333334m },
                    { 194, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-86", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(773), null, 458.33333333333333333333333334m },
                    { 195, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-87", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(791), null, 458.33333333333333333333333334m },
                    { 196, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-88", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(810), null, 458.33333333333333333333333334m },
                    { 197, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-89", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(828), null, 458.33333333333333333333333334m },
                    { 198, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-90", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(847), null, 458.33333333333333333333333334m },
                    { 199, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-91", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(906), null, 458.33333333333333333333333334m },
                    { 200, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-92", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(928), null, 458.33333333333333333333333334m },
                    { 201, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-93", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(946), null, 458.33333333333333333333333334m },
                    { 202, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-94", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(965), null, 458.33333333333333333333333334m },
                    { 203, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-95", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(983), null, 458.33333333333333333333333334m },
                    { 204, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-96", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1003), null, 458.33333333333333333333333334m },
                    { 205, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-97", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1021), null, 458.33333333333333333333333334m },
                    { 206, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-98", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1040), null, 458.33333333333333333333333334m },
                    { 207, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-99", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1059), null, 458.33333333333333333333333334m },
                    { 208, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-100", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1078), null, 458.33333333333333333333333334m },
                    { 209, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-101", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1098), null, 458.33333333333333333333333334m },
                    { 210, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-102", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1116), null, 458.33333333333333333333333334m },
                    { 211, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-103", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1135), null, 458.33333333333333333333333334m },
                    { 212, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-104", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1154), null, 458.33333333333333333333333334m },
                    { 213, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-105", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1173), null, 458.33333333333333333333333334m },
                    { 214, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-106", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1192), null, 458.33333333333333333333333334m },
                    { 215, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-107", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1211), null, 458.33333333333333333333333334m },
                    { 216, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-108", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1230), null, 458.33333333333333333333333334m },
                    { 217, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-109", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1249), null, 458.33333333333333333333333334m },
                    { 218, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-110", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1269), null, 458.33333333333333333333333334m },
                    { 219, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-111", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1288), null, 458.33333333333333333333333334m },
                    { 220, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-112", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1307), null, 458.33333333333333333333333334m },
                    { 221, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-113", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1368), null, 458.33333333333333333333333334m },
                    { 222, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-114", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1389), null, 458.33333333333333333333333334m },
                    { 223, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-115", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1409), null, 458.33333333333333333333333334m },
                    { 224, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-116", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1427), null, 458.33333333333333333333333334m },
                    { 225, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-117", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1446), null, 458.33333333333333333333333334m },
                    { 226, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-118", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1465), null, 458.33333333333333333333333334m },
                    { 227, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-119", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1483), null, 458.33333333333333333333333334m },
                    { 228, 4, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "4-120", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(1502), null, 458.33333333333333333333333334m },
                    { 229, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-1", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2751), null, 1425m },
                    { 230, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-2", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2772), null, 1425m },
                    { 231, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-3", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2791), null, 1425m },
                    { 232, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-4", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2808), null, 1425m },
                    { 233, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-5", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2825), null, 1425m },
                    { 234, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-6", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2843), null, 1425m },
                    { 235, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-7", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2860), null, 1425m },
                    { 236, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-8", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2877), null, 1425m },
                    { 237, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-9", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2894), null, 1425m },
                    { 238, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-10", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2911), null, 1425m },
                    { 239, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-11", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2929), null, 1425m },
                    { 240, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-12", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2947), null, 1425m },
                    { 241, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-13", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2964), null, 1425m },
                    { 242, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-14", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2981), null, 1425m },
                    { 243, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-15", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(2998), null, 1425m },
                    { 244, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-16", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(3015), null, 1425m },
                    { 245, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-17", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(3033), null, 1425m },
                    { 246, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-18", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(3050), null, 1425m },
                    { 247, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-19", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(3067), null, 1425m },
                    { 248, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-20", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(3084), null, 1425m },
                    { 249, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-21", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(3143), null, 1425m },
                    { 250, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-22", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(3162), null, 1425m },
                    { 251, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-23", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(3180), null, 1425m },
                    { 252, 5, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "5-24", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(3198), null, 1425m },
                    { 253, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-1", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4656), null, 916.6666666666666666666666666m },
                    { 254, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-2", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4679), null, 916.6666666666666666666666666m },
                    { 255, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-3", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4699), null, 916.6666666666666666666666666m },
                    { 256, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-4", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4718), null, 916.6666666666666666666666666m },
                    { 257, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-5", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4737), null, 916.6666666666666666666666666m },
                    { 258, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-6", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4822), null, 916.6666666666666666666666666m },
                    { 259, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-7", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4843), null, 916.6666666666666666666666666m },
                    { 260, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-8", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4861), null, 916.6666666666666666666666666m },
                    { 261, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-9", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4880), null, 916.6666666666666666666666666m },
                    { 262, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-10", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4898), null, 916.6666666666666666666666666m },
                    { 263, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-11", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4917), null, 916.6666666666666666666666666m },
                    { 264, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-12", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4936), null, 916.6666666666666666666666666m },
                    { 265, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-13", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4954), null, 916.6666666666666666666666666m },
                    { 266, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-14", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4973), null, 916.6666666666666666666666666m },
                    { 267, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-15", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(4992), null, 916.6666666666666666666666666m },
                    { 268, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-16", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(5010), null, 916.6666666666666666666666666m },
                    { 269, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-17", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(5029), null, 916.6666666666666666666666666m },
                    { 270, 6, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "6-18", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(5047), null, 916.6666666666666666666666666m },
                    { 271, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-1", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7154), null, 1569.4444444444444444444444445m },
                    { 272, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-2", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7181), null, 1569.4444444444444444444444445m },
                    { 273, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-3", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7201), null, 1569.4444444444444444444444445m },
                    { 274, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-4", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7220), null, 1569.4444444444444444444444445m },
                    { 275, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-5", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7324), null, 1569.4444444444444444444444445m },
                    { 276, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-6", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7348), null, 1569.4444444444444444444444445m },
                    { 277, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-7", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7367), null, 1569.4444444444444444444444445m },
                    { 278, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-8", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7386), null, 1569.4444444444444444444444445m },
                    { 279, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-9", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7405), null, 1569.4444444444444444444444445m },
                    { 280, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-10", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7424), null, 1569.4444444444444444444444445m },
                    { 281, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-11", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7443), null, 1569.4444444444444444444444445m },
                    { 282, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-12", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7462), null, 1569.4444444444444444444444445m },
                    { 283, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-13", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7481), null, 1569.4444444444444444444444445m },
                    { 284, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-14", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7500), null, 1569.4444444444444444444444445m },
                    { 285, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-15", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7519), null, 1569.4444444444444444444444445m },
                    { 286, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-16", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7539), null, 1569.4444444444444444444444445m },
                    { 287, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-17", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7558), null, 1569.4444444444444444444444445m },
                    { 288, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-18", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7577), null, 1569.4444444444444444444444445m },
                    { 289, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-19", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7596), null, 1569.4444444444444444444444445m },
                    { 290, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-20", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7615), null, 1569.4444444444444444444444445m },
                    { 291, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-21", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7634), null, 1569.4444444444444444444444445m },
                    { 292, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-22", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7653), null, 1569.4444444444444444444444445m },
                    { 293, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-23", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7672), null, 1569.4444444444444444444444445m },
                    { 294, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-24", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7691), null, 1569.4444444444444444444444445m },
                    { 295, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-25", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7710), null, 1569.4444444444444444444444445m },
                    { 296, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-26", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7729), null, 1569.4444444444444444444444445m },
                    { 297, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-27", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7773), null, 1569.4444444444444444444444445m },
                    { 298, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-28", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7795), null, 1569.4444444444444444444444445m },
                    { 299, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-29", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7814), null, 1569.4444444444444444444444445m },
                    { 300, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-30", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7833), null, 1569.4444444444444444444444445m },
                    { 301, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-31", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7852), null, 1569.4444444444444444444444445m },
                    { 302, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-32", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7871), null, 1569.4444444444444444444444445m },
                    { 303, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-33", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7889), null, 1569.4444444444444444444444445m },
                    { 304, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-34", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7908), null, 1569.4444444444444444444444445m },
                    { 305, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-35", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7927), null, 1569.4444444444444444444444445m },
                    { 306, 7, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "7-36", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(7946), null, 1569.4444444444444444444444445m },
                    { 307, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-1", 0, new DateTime(2024, 10, 23, 11, 51, 11, 968, DateTimeKind.Local).AddTicks(9999), null, 655.55555555555555555555555556m },
                    { 308, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-2", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(24), null, 655.55555555555555555555555556m },
                    { 309, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-3", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(43), null, 655.55555555555555555555555556m },
                    { 310, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-4", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(61), null, 655.55555555555555555555555556m },
                    { 311, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-5", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(81), null, 655.55555555555555555555555556m },
                    { 312, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-6", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(99), null, 655.55555555555555555555555556m },
                    { 313, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-7", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(118), null, 655.55555555555555555555555556m },
                    { 314, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-8", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(136), null, 655.55555555555555555555555556m },
                    { 315, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-9", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(155), null, 655.55555555555555555555555556m },
                    { 316, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-10", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(173), null, 655.55555555555555555555555556m },
                    { 317, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-11", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(192), null, 655.55555555555555555555555556m },
                    { 318, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-12", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(210), null, 655.55555555555555555555555556m },
                    { 319, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-13", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(229), null, 655.55555555555555555555555556m },
                    { 320, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-14", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(247), null, 655.55555555555555555555555556m },
                    { 321, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-15", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(265), null, 655.55555555555555555555555556m },
                    { 322, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-16", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(284), null, 655.55555555555555555555555556m },
                    { 323, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-17", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(302), null, 655.55555555555555555555555556m },
                    { 324, 8, new DateTime(2024, 10, 23, 11, 51, 11, 967, DateTimeKind.Local).AddTicks(2517), null, "8-18", 0, new DateTime(2024, 10, 23, 11, 51, 11, 969, DateTimeKind.Local).AddTicks(320), null, 655.55555555555555555555555556m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaId",
                keyValue: 324);

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Consortia",
                keyColumn: "ConsortiumId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 11, 22, 18, 938, DateTimeKind.Local).AddTicks(4416));
        }
    }
}
