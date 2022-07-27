using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcess.Migrations
{
    public partial class SetKeyForTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ReminderDate" },
                values: new object[] { new DateTime(2022, 7, 7, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2330), new DateTime(2022, 7, 9, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ReminderDate" },
                values: new object[] { new DateTime(2022, 7, 7, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2342), new DateTime(2022, 7, 9, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ReminderDate" },
                values: new object[] { new DateTime(2022, 7, 7, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2351), new DateTime(2022, 7, 9, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ReminderDate" },
                values: new object[] { new DateTime(2022, 7, 7, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2359), new DateTime(2022, 7, 9, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "Duties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "NextActionDate", "RequiredBy" },
                values: new object[] { new DateTime(2022, 7, 7, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2267), new DateTime(2022, 7, 9, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2278), new DateTime(2022, 7, 7, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Duties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "NextActionDate", "RequiredBy" },
                values: new object[] { new DateTime(2022, 7, 7, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2305), new DateTime(2022, 7, 9, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2306), new DateTime(2022, 7, 7, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Duties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "NextActionDate", "RequiredBy" },
                values: new object[] { new DateTime(2022, 7, 7, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2313), new DateTime(2022, 7, 9, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2314), new DateTime(2022, 7, 7, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Duties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "NextActionDate", "RequiredBy" },
                values: new object[] { new DateTime(2022, 7, 7, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2320), new DateTime(2022, 7, 9, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2321), new DateTime(2022, 7, 7, 21, 18, 48, 515, DateTimeKind.Local).AddTicks(2321) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ReminderDate" },
                values: new object[] { new DateTime(2022, 7, 7, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8745), new DateTime(2022, 7, 9, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ReminderDate" },
                values: new object[] { new DateTime(2022, 7, 7, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8758), new DateTime(2022, 7, 9, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ReminderDate" },
                values: new object[] { new DateTime(2022, 7, 7, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8767), new DateTime(2022, 7, 9, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ReminderDate" },
                values: new object[] { new DateTime(2022, 7, 7, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8776), new DateTime(2022, 7, 9, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Duties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "NextActionDate", "RequiredBy" },
                values: new object[] { new DateTime(2022, 7, 7, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8683), new DateTime(2022, 7, 9, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8691), new DateTime(2022, 7, 7, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Duties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "NextActionDate", "RequiredBy" },
                values: new object[] { new DateTime(2022, 7, 7, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8717), new DateTime(2022, 7, 9, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8718), new DateTime(2022, 7, 7, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Duties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "NextActionDate", "RequiredBy" },
                values: new object[] { new DateTime(2022, 7, 7, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8727), new DateTime(2022, 7, 9, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8727), new DateTime(2022, 7, 7, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Duties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "NextActionDate", "RequiredBy" },
                values: new object[] { new DateTime(2022, 7, 7, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8735), new DateTime(2022, 7, 9, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8736), new DateTime(2022, 7, 7, 16, 0, 53, 959, DateTimeKind.Local).AddTicks(8736) });
        }
    }
}
