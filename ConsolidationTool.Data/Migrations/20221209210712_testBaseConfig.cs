using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsolidationTool.Data.Migrations
{
    public partial class testBaseConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "SubCategory",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "SYSDATETIME()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "SubCategory",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "InsertedBy",
                table: "SubCategory",
                type: "int",
                nullable: false,
                defaultValue: -99,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertedAt",
                table: "SubCategory",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Property",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "SYSDATETIME()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Property",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "InsertedBy",
                table: "Property",
                type: "int",
                nullable: false,
                defaultValue: -99,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertedAt",
                table: "Property",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "SubCategory",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "SYSDATETIME()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "SubCategory",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "InsertedBy",
                table: "SubCategory",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: -99);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertedAt",
                table: "SubCategory",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Property",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "SYSDATETIME()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Property",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "InsertedBy",
                table: "Property",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: -99);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertedAt",
                table: "Property",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETUTCDATE()");
        }
    }
}
