using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MochiSweets.Migrations
{
    public partial class MochiSweets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    accountID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    userName = table.Column<string>(nullable: true),
                    passwordAccount = table.Column<string>(nullable: true),
                    accountStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.accountID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    categoryID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    categoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customerID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    customerName = table.Column<string>(nullable: true),
                    phonenumber = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    birthDate = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    passwordCustomer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.customerID);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    newsID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(nullable: true),
                    content = table.Column<string>(nullable: true),
                    postingTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.newsID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentsMethod",
                columns: table => new
                {
                    PaymentsMethodID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PaymentsMethodName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentsMethod", x => x.PaymentsMethodID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    productID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    productName = table.Column<string>(nullable: true),
                    price = table.Column<double>(nullable: false),
                    detail = table.Column<string>(nullable: true),
                    quantity = table.Column<int>(nullable: false),
                    product_status = table.Column<string>(nullable: true),
                    categoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.productID);
                    table.ForeignKey(
                        name: "FK_Product_Category_categoryID",
                        column: x => x.categoryID,
                        principalTable: "Category",
                        principalColumn: "categoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryAddresses",
                columns: table => new
                {
                    addressID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    phonenumber = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    district = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    customerName = table.Column<string>(nullable: true),
                    addressStatus = table.Column<string>(nullable: true),
                    addressDefault = table.Column<string>(nullable: true),
                    customerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryAddresses", x => x.addressID);
                    table.ForeignKey(
                        name: "FK_DeliveryAddresses_Customer_customerID",
                        column: x => x.customerID,
                        principalTable: "Customer",
                        principalColumn: "customerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    imageID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    imageUrl = table.Column<string>(nullable: true),
                    productID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.imageID);
                    table.ForeignKey(
                        name: "FK_Image_Product_productID",
                        column: x => x.productID,
                        principalTable: "Product",
                        principalColumn: "productID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleOff",
                columns: table => new
                {
                    saleID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    sale = table.Column<double>(nullable: false),
                    startTime = table.Column<DateTime>(nullable: false),
                    endTime = table.Column<DateTime>(nullable: false),
                    productID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOff", x => x.saleID);
                    table.ForeignKey(
                        name: "FK_SaleOff_Product_productID",
                        column: x => x.productID,
                        principalTable: "Product",
                        principalColumn: "productID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    orderID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    paymentMethodID = table.Column<int>(nullable: false),
                    addressID = table.Column<int>(nullable: false),
                    orderStatus = table.Column<int>(nullable: false),
                    dateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.orderID);
                    table.ForeignKey(
                        name: "FK_Order_DeliveryAddresses_addressID",
                        column: x => x.addressID,
                        principalTable: "DeliveryAddresses",
                        principalColumn: "addressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_PaymentsMethod_paymentMethodID",
                        column: x => x.paymentMethodID,
                        principalTable: "PaymentsMethod",
                        principalColumn: "PaymentsMethodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersProduct",
                columns: table => new
                {
                    orderID = table.Column<int>(nullable: false),
                    productID = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: false),
                    price = table.Column<double>(nullable: false),
                    sale = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersProduct", x => new { x.orderID, x.productID });
                    table.ForeignKey(
                        name: "FK_OrdersProduct_Order_orderID",
                        column: x => x.orderID,
                        principalTable: "Order",
                        principalColumn: "orderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersProduct_Product_productID",
                        column: x => x.productID,
                        principalTable: "Product",
                        principalColumn: "productID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsTaste",
                columns: table => new
                {
                    tasteID = table.Column<int>(nullable: false),
                    productID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsTaste", x => new { x.tasteID, x.productID });
                    table.ForeignKey(
                        name: "FK_ProductsTaste_Product_productID",
                        column: x => x.productID,
                        principalTable: "Product",
                        principalColumn: "productID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Taste",
                columns: table => new
                {
                    tasteID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tasteName = table.Column<string>(nullable: true),
                    ProductsTasteproductID = table.Column<int>(nullable: true),
                    ProductsTastetasteID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taste", x => x.tasteID);
                    table.ForeignKey(
                        name: "FK_Taste_ProductsTaste_ProductsTastetasteID_ProductsTasteproduc~",
                        columns: x => new { x.ProductsTastetasteID, x.ProductsTasteproductID },
                        principalTable: "ProductsTaste",
                        principalColumns: new[] { "tasteID", "productID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryAddresses_customerID",
                table: "DeliveryAddresses",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_Image_productID",
                table: "Image",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_addressID",
                table: "Order",
                column: "addressID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_paymentMethodID",
                table: "Order",
                column: "paymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProduct_productID",
                table: "OrdersProduct",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_categoryID",
                table: "Product",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsTaste_productID",
                table: "ProductsTaste",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOff_productID",
                table: "SaleOff",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_Taste_ProductsTastetasteID_ProductsTasteproductID",
                table: "Taste",
                columns: new[] { "ProductsTastetasteID", "ProductsTasteproductID" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsTaste_Taste_tasteID",
                table: "ProductsTaste",
                column: "tasteID",
                principalTable: "Taste",
                principalColumn: "tasteID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsTaste_Product_productID",
                table: "ProductsTaste");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsTaste_Taste_tasteID",
                table: "ProductsTaste");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "OrdersProduct");

            migrationBuilder.DropTable(
                name: "SaleOff");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "DeliveryAddresses");

            migrationBuilder.DropTable(
                name: "PaymentsMethod");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Taste");

            migrationBuilder.DropTable(
                name: "ProductsTaste");
        }
    }
}
