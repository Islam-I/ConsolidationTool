using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsolidationTool.Data.Migrations
{
    public partial class defaultValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormID",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "IsDeleted_YN",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "FormID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsDeleted_YN",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "FormID",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "IsDeleted_YN",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "FormID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "IsDeleted_YN",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "FormID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "InsertedBy",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "IsDeleted_YN",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormID",
                table: "Supplier",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertedAt",
                table: "Supplier",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsertedBy",
                table: "Supplier",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted_YN",
                table: "Supplier",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedAt",
                table: "Supplier",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Supplier",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormID",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertedAt",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsertedBy",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted_YN",
                table: "Product",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedAt",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormID",
                table: "OrderItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertedAt",
                table: "OrderItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsertedBy",
                table: "OrderItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted_YN",
                table: "OrderItem",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedAt",
                table: "OrderItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "OrderItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormID",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertedAt",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsertedBy",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted_YN",
                table: "Order",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedAt",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormID",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsertedAt",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsertedBy",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted_YN",
                table: "Customer",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedAt",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Customer",
                type: "int",
                nullable: true);
        }
    }
}
