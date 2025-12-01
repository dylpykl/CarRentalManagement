using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "29dbbeb9-d81d-4c71-aa71-fa6128bbc619", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMBIrKyocQfU8HSaaTg/HTtTDhZRsnp76TvvL/3TtB6a3NRHVs39RqDqrIya0BRKXg==", null, false, "d74c5d6b-fb25-4b7c-afa7-d107b5eb7e14", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3025), new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3044), new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3704), new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3708), new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3905), new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3909), new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3913), new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3916), new DateTime(2025, 11, 24, 12, 28, 58, 501, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(662), new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(716), new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(953), new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(956), new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(1040), new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(1044), new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(1046), new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(1048), new DateTime(2025, 11, 24, 11, 38, 14, 717, DateTimeKind.Local).AddTicks(1049) });
        }
    }
}
