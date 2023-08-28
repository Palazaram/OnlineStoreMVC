using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineStore.Data.Migrations
{
    public partial class AddedOrderStatuses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "CartDetails",
                type: "MONEY",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "OrderStatusId", "OrderStatusName" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Completed" },
                    { 3, "Shipped" },
                    { 4, "Cancelled" },
                    { 5, "Declined" },
                    { 6, "Refunded" },
                    { 7, "Disputed" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ProductImageName",
                value: "vegetables/cucumber/sm_ogurec-akter.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ProductImageName",
                value: "vegetables/cabbage/sm_agressor.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ProductImageName",
                value: "vegetables/eggplant/sm_almaz.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ProductImageName",
                value: "vegetables/sugarbeet/sm_egipetskaya-ploskaya.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ProductImageName",
                value: "fruits/melon/sm_ineya.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductImageName",
                value: "fruits/watermelon/sm_arbuz-imperator.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ProductImageName",
                value: "flowers/sm_amerikanskaya-krasavica.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "ProductImageName",
                value: "flowers/sm_imperiya.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "ProductImageName",
                value: "flowers/sm_ivenus.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "CartDetails");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ProductImageName",
                value: "~/img/vegetables/cucumber/sm_ogurec-akter.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ProductImageName",
                value: "~/img/vegetables/cabbage/sm_agressor.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ProductImageName",
                value: "~/img/vegetables/eggplant/sm_almaz.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ProductImageName",
                value: "~/img/vegetables/sugarbeet/sm_egipetskaya-ploskaya.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ProductImageName",
                value: "~/img/fruits/melon/sm_ineya.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ProductImageName",
                value: "~/img/fruits/watermelon/sm_arbuz-imperator.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ProductImageName",
                value: "~/img/flowers/sm_amerikanskaya-krasavica.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "ProductImageName",
                value: "~/img/flowers/sm_imperiya.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "ProductImageName",
                value: "~/img/flowers/sm_ivenus.jpg");
        }
    }
}
