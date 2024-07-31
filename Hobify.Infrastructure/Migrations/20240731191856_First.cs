using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hobify.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 31, 19, 18, 55, 460, DateTimeKind.Utc).AddTicks(9983)),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 31, 19, 18, 55, 461, DateTimeKind.Utc).AddTicks(469))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    profilePhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 31, 19, 18, 55, 461, DateTimeKind.Utc).AddTicks(1231)),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 31, 19, 18, 55, 461, DateTimeKind.Utc).AddTicks(1728)),
                    categoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChatRooms",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 31, 19, 18, 55, 461, DateTimeKind.Utc).AddTicks(5741)),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatRooms", x => x.id);
                    table.ForeignKey(
                        name: "FK_ChatRooms_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 31, 19, 18, 55, 461, DateTimeKind.Utc).AddTicks(3831)),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    subCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.id);
                    table.ForeignKey(
                        name: "FK_Events_SubCategories_subCategoryId",
                        column: x => x.subCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForumTopics",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    subCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumTopics", x => x.id);
                    table.ForeignKey(
                        name: "FK_ForumTopics_SubCategories_subCategoryId",
                        column: x => x.subCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumTopics_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mediaType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 31, 19, 18, 55, 460, DateTimeKind.Utc).AddTicks(1895)),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 7, 31, 19, 18, 55, 460, DateTimeKind.Utc).AddTicks(2712)),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    subCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Posts_SubCategories_subCategoryId",
                        column: x => x.subCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Posts_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    photoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 31, 19, 18, 55, 461, DateTimeKind.Utc).AddTicks(8313)),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    subCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_subCategoryId",
                        column: x => x.subCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 31, 19, 18, 55, 460, DateTimeKind.Utc).AddTicks(6344)),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    postId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_postId",
                        column: x => x.postId,
                        principalTable: "Posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatRooms_userId",
                table: "ChatRooms",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_postId",
                table: "Comments",
                column: "postId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_userId",
                table: "Comments",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_subCategoryId",
                table: "Events",
                column: "subCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopics_subCategoryId",
                table: "ForumTopics",
                column: "subCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumTopics_userId",
                table: "ForumTopics",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_subCategoryId",
                table: "Posts",
                column: "subCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_userId",
                table: "Posts",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_subCategoryId",
                table: "Products",
                column: "subCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_userId",
                table: "Products",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_categoryId",
                table: "SubCategories",
                column: "categoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatRooms");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "ForumTopics");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
