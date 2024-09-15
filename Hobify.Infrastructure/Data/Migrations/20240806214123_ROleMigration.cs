using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hobify.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class ROleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 306, DateTimeKind.Utc).AddTicks(7938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 306, DateTimeKind.Utc).AddTicks(6690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(6075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 307, DateTimeKind.Utc).AddTicks(7215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 491, DateTimeKind.Utc).AddTicks(2716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 305, DateTimeKind.Utc).AddTicks(5195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 489, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 305, DateTimeKind.Utc).AddTicks(4131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 489, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 307, DateTimeKind.Utc).AddTicks(1993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(9449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 306, DateTimeKind.Utc).AddTicks(503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "ChatRooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 307, DateTimeKind.Utc).AddTicks(5649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 491, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 306, DateTimeKind.Utc).AddTicks(5576),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(5111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 306, DateTimeKind.Utc).AddTicks(5130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    AppRoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.AppRoleID);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppRoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.AppUserId);
                    table.ForeignKey(
                        name: "FK_AppUsers_AppRoles_AppRoleID",
                        column: x => x.AppRoleID,
                        principalTable: "AppRoles",
                        principalColumn: "AppRoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_AppRoleID",
                table: "AppUsers",
                column: "AppRoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(6934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 306, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(6075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 306, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 491, DateTimeKind.Utc).AddTicks(2716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 307, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 489, DateTimeKind.Utc).AddTicks(5003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 305, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 489, DateTimeKind.Utc).AddTicks(4205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 305, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(9449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 307, DateTimeKind.Utc).AddTicks(1993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 306, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "ChatRooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 491, DateTimeKind.Utc).AddTicks(1515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 307, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(5111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 306, DateTimeKind.Utc).AddTicks(5576));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(4637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 21, 41, 22, 306, DateTimeKind.Utc).AddTicks(5130));
        }
    }
}
