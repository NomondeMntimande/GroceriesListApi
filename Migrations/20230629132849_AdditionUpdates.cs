using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceriesListApi.Migrations
{
    /// <inheritdoc />
    public partial class AdditionUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<int>(
            //    name: "listItemId",
            //    table: "GroceriesList",
            //    type: "integer",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "categoryName",
                table: "GroceriesList",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "itemName",
                table: "GroceriesList",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "categoryName",
                table: "GroceriesList");

            migrationBuilder.DropColumn(
                name: "itemName",
                table: "GroceriesList");

            migrationBuilder.AlterColumn<string>(
                name: "listItemId",
                table: "GroceriesList",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }
    }
}
