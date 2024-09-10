using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothStoreApplication.Migrations
{
    /// <inheritdoc />
    public partial class ClothStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_RegisterUserEntity_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_RegisterUserEntity_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_RegisterUserEntity_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_RegisterUserEntity_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderItemEntity");

            migrationBuilder.DropTable(
                name: "RegisterUserEntity");

            migrationBuilder.DropTable(
                name: "OrderEntity");

            migrationBuilder.DropTable(
                name: "ProductsEntity");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrderItemEntities_tblOrderEntities_OrderId",
                table: "tblOrderItemEntities",
                column: "OrderId",
                principalTable: "tblOrderEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrderItemEntities_tblProducts_ProductId",
                table: "tblOrderItemEntities",
                column: "ProductId",
                principalTable: "tblProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOrderItemEntities_tblOrderEntities_OrderId",
                table: "tblOrderItemEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_tblOrderItemEntities_tblProducts_ProductId",
                table: "tblOrderItemEntities");

            migrationBuilder.CreateTable(
                name: "OrderEntity",
                columns: table => new
                {
                    TempId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.UniqueConstraint("AK_OrderEntity_TempId", x => x.TempId);
                });

            migrationBuilder.CreateTable(
                name: "ProductsEntity",
                columns: table => new
                {
                    TempId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.UniqueConstraint("AK_ProductsEntity_TempId", x => x.TempId);
                });

            migrationBuilder.CreateTable(
                name: "RegisterUserEntity",
                columns: table => new
                {
                    TempId1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TempId2 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TempId3 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TempId4 = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.UniqueConstraint("AK_RegisterUserEntity_TempId1", x => x.TempId1);
                    table.UniqueConstraint("AK_RegisterUserEntity_TempId2", x => x.TempId2);
                    table.UniqueConstraint("AK_RegisterUserEntity_TempId3", x => x.TempId3);
                    table.UniqueConstraint("AK_RegisterUserEntity_TempId4", x => x.TempId4);
                });

            migrationBuilder.CreateTable(
                name: "OrderItemEntity",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_OrderItemEntity_OrderEntity_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderEntity",
                        principalColumn: "TempId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItemEntity_ProductsEntity_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductsEntity",
                        principalColumn: "TempId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_RegisterUserEntity_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "RegisterUserEntity",
                principalColumn: "TempId1",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_RegisterUserEntity_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "RegisterUserEntity",
                principalColumn: "TempId2",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_RegisterUserEntity_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "RegisterUserEntity",
                principalColumn: "TempId3",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_RegisterUserEntity_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "RegisterUserEntity",
                principalColumn: "TempId4",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
