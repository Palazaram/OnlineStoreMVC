using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineStore.Data.Migrations
{
    public partial class addedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "NVARCHAR(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "ProductImageName",
                table: "Products",
                type: "NVARCHAR(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(30)");

            migrationBuilder.AlterColumn<string>(
                name: "ProductDescription",
                table: "Products",
                type: "NVARCHAR(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ProductDescription", "ProductImageName", "ProductName", "ProductPrice", "SupplierId" },
                values: new object[,]
                {
                    { 1, 1, "Середньоранній (50-54 дні) гібрид корніншонного типу.", "vegetables/cucumber/sm_ogurec-akter.jpg", "ОГІРОК АКТОР F1", 9.00m, 1 },
                    { 2, 1, "Пізній сорт селекції голландської фірми Syngenta. Термін дозрівання 115-120 днів.", "vegetables/cabbage/sm_agressor.jpg", "КАПУСТА АГРЕСОР F1", 18.00m, 2 },
                    { 3, 1, "Середньостиглий, технічна стиглість плодів настає через 118-120 днів після сходів.", "vegetables/eggplant/sm_almaz.jpg", "БАКЛАЖАН АЛМАЗ", 6.20m, 3 },
                    { 4, 1, "Середньоранній високоврожайний сорт. Період вегетації становить 80-110 днів.", "vegetables/sugarbeet/sm_egipetskaya-ploskaya.jpg", "БУРЯК ЄГИПЕТСЬКИЙ ПЛОСКИЙ", 6.00m, 1 },
                    { 5, 2, "Новий середньостиглий сорт селекції Дніпропетровської дослідної станції.", "fruits/melon/sm_ineya.jpg", "ДИНЯ ІНЕЯ", 6.20m, 1 },
                    { 6, 2, "Середньоранній (80-90 днів) італійський гібрид кавуна для відкритого ґрунту і плівкових укриттів.", "fruits/watermelon/sm_arbuz-imperator.jpg", "КАВУН ІМПЕРАТОР F1", 14.00m, 3 },
                    { 7, 3, "Сортотип американських кущових айстр.", "flowers/sm_amerikanskaya-krasavica.jpg", "АЙСТРА АМЕРИКАНСЬКА КРАСУНЯ", 6.00m, 3 },
                    { 8, 3, "Кущ компактний, висотою 50-55 см.", "flowers/sm_imperiya.jpg", "АЙСТРА ІМПЕРІЯ", 6.00m, 2 },
                    { 9, 3, "Сортотип півонієвидних айстр. Кущ напіврозлогий, висотою 55-60 см.", "flowers/sm_ivenus.jpg", "АЙСТРА ІВЕНУС", 6.00m, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "NVARCHAR(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ProductImageName",
                table: "Products",
                type: "NVARCHAR(30)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductDescription",
                table: "Products",
                type: "NVARCHAR(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
