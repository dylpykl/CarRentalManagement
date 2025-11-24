using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Model",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7519), new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7534), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7536), new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7537), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7710), new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7710), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7712), new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7713), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "ModelId", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7783), new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7783), 1, "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7786), new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7786), 2, "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7788), new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7789), 3, "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7790), new DateTime(2025, 11, 24, 10, 43, 43, 11, DateTimeKind.Local).AddTicks(7791), 4, "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Model");
        }
    }
}
