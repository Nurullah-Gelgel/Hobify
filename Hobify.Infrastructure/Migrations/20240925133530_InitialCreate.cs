using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hobify.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 699, DateTimeKind.Utc).AddTicks(2669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 670, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 699, DateTimeKind.Utc).AddTicks(2098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 670, DateTimeKind.Utc).AddTicks(2260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 700, DateTimeKind.Utc).AddTicks(3707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 671, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 700, DateTimeKind.Utc).AddTicks(3118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 671, DateTimeKind.Utc).AddTicks(2275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 700, DateTimeKind.Utc).AddTicks(8955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 671, DateTimeKind.Utc).AddTicks(9975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 699, DateTimeKind.Utc).AddTicks(4570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 670, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 699, DateTimeKind.Utc).AddTicks(4021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 670, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 700, DateTimeKind.Utc).AddTicks(5867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 671, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 699, DateTimeKind.Utc).AddTicks(8236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 670, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "ChatRooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 700, DateTimeKind.Utc).AddTicks(7970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 671, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 700, DateTimeKind.Utc).AddTicks(2362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 671, DateTimeKind.Utc).AddTicks(1678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 700, DateTimeKind.Utc).AddTicks(1922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 671, DateTimeKind.Utc).AddTicks(1253));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 670, DateTimeKind.Utc).AddTicks(2767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 699, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 670, DateTimeKind.Utc).AddTicks(2260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 699, DateTimeKind.Utc).AddTicks(2098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 671, DateTimeKind.Utc).AddTicks(2662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 700, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 671, DateTimeKind.Utc).AddTicks(2275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 700, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 671, DateTimeKind.Utc).AddTicks(9975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 700, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 670, DateTimeKind.Utc).AddTicks(4090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 699, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 670, DateTimeKind.Utc).AddTicks(3629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 699, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 671, DateTimeKind.Utc).AddTicks(5481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 700, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 670, DateTimeKind.Utc).AddTicks(6911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 699, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "ChatRooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 671, DateTimeKind.Utc).AddTicks(8678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 700, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 671, DateTimeKind.Utc).AddTicks(1678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 700, DateTimeKind.Utc).AddTicks(2362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 24, 22, 19, 36, 671, DateTimeKind.Utc).AddTicks(1253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 25, 13, 35, 29, 700, DateTimeKind.Utc).AddTicks(1922));
        }
    }
}
