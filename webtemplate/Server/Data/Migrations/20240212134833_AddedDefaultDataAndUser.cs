using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webtemplate.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "UpdatedBy" },
                values: new object[] { 1, "123 Lady Road", "System", new DateTime(2024, 2, 12, 21, 48, 33, 774, DateTimeKind.Local).AddTicks(5536), new DateTime(2024, 2, 12, 21, 48, 33, 774, DateTimeKind.Local).AddTicks(5563), "stacyiscool@gmail.com", "Stacy", "System" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
