using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hobify.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatRooms_Users_userId",
                table: "ChatRooms");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "ChatRooms",
                newName: "Userid");

            migrationBuilder.RenameIndex(
                name: "IX_ChatRooms_userId",
                table: "ChatRooms",
                newName: "IX_ChatRooms_Userid");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(6934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 4, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(6075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 3, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 491, DateTimeKind.Utc).AddTicks(2716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 4, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 489, DateTimeKind.Utc).AddTicks(5003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 2, DateTimeKind.Utc).AddTicks(9176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 489, DateTimeKind.Utc).AddTicks(4205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 2, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(9449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 4, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 3, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.AlterColumn<Guid>(
                name: "Userid",
                table: "ChatRooms",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "ChatRooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 491, DateTimeKind.Utc).AddTicks(1515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 4, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(5111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 3, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(4637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 3, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.AddForeignKey(
                name: "FK_ChatRooms_Users_Userid",
                table: "ChatRooms",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatRooms_Users_Userid",
                table: "ChatRooms");

            migrationBuilder.RenameColumn(
                name: "Userid",
                table: "ChatRooms",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatRooms_Userid",
                table: "ChatRooms",
                newName: "IX_ChatRooms_userId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 4, DateTimeKind.Utc).AddTicks(519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 3, DateTimeKind.Utc).AddTicks(9915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(6075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 4, DateTimeKind.Utc).AddTicks(7624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 491, DateTimeKind.Utc).AddTicks(2716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 2, DateTimeKind.Utc).AddTicks(9176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 489, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 2, DateTimeKind.Utc).AddTicks(8354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 489, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 4, DateTimeKind.Utc).AddTicks(3173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(9449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 3, DateTimeKind.Utc).AddTicks(4138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "ChatRooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 4, DateTimeKind.Utc).AddTicks(5357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 491, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.AlterColumn<Guid>(
                name: "userId",
                table: "ChatRooms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 3, DateTimeKind.Utc).AddTicks(9164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(5111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 2, 15, 56, 59, 3, DateTimeKind.Utc).AddTicks(8613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 6, 9, 16, 33, 490, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.AddForeignKey(
                name: "FK_ChatRooms_Users_userId",
                table: "ChatRooms",
                column: "userId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
