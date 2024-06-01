using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AdminuserveAdminRoleinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDay",
                table: "AspNetUsers",
                newName: "BirthDate");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 1, null, "Admin", "ADMİN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, new DateOnly(1999, 1, 1), "b0940e17-7dcb-470a-9eb5-636410b00e4e", "Admin@mail.com", true, 2, false, null, "Admin", "ADMİN@MAİL.COM", "ADMİN", "AQAAAAIAAYagAAAAEP6FJP45tIf70268wwusA0La0m/HSYN+s51qY5jp6pUzHARkaMiYOeaK2uCvdSIC5g==", "-", true, null, "Admin", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "AspNetUsers",
                newName: "BirthDay");
        }
    }
}
