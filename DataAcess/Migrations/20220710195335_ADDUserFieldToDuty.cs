using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcess.Migrations
{
    public partial class ADDUserFieldToDuty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignedTo",
                table: "Duties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ReminderDate" },
                values: new object[] { new DateTime(2022, 7, 10, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1035), new DateTime(2022, 7, 12, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ReminderDate" },
                values: new object[] { new DateTime(2022, 7, 10, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1048), new DateTime(2022, 7, 12, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ReminderDate" },
                values: new object[] { new DateTime(2022, 7, 10, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1056), new DateTime(2022, 7, 12, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ReminderDate" },
                values: new object[] { new DateTime(2022, 7, 10, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1065), new DateTime(2022, 7, 12, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Duties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedTo", "CreatedDate", "NextActionDate", "RequiredBy" },
                values: new object[] { 4, new DateTime(2022, 7, 10, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(975), new DateTime(2022, 7, 12, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(985), new DateTime(2022, 7, 10, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Duties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedTo", "CreatedDate", "NextActionDate", "RequiredBy" },
                values: new object[] { 2, new DateTime(2022, 7, 10, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1007), new DateTime(2022, 7, 12, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1009), new DateTime(2022, 7, 10, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "Duties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedTo", "CreatedDate", "NextActionDate", "RequiredBy" },
                values: new object[] { 6, new DateTime(2022, 7, 10, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1017), new DateTime(2022, 7, 12, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1018), new DateTime(2022, 7, 10, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Duties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedTo", "CreatedDate", "NextActionDate", "RequiredBy" },
                values: new object[] { 5, new DateTime(2022, 7, 10, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1025), new DateTime(2022, 7, 12, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1026), new DateTime(2022, 7, 10, 22, 53, 35, 15, DateTimeKind.Local).AddTicks(1026) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedTo",
                table: "Duties");

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
    }
}
