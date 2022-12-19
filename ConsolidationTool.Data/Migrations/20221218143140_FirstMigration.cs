using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsolidationTool.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserArName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserLoginName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveUserYn = table.Column<bool>(type: "bit", nullable: true),
                    DeletedYn = table.Column<bool>(type: "bit", nullable: true),
                    PropertyIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastPasswordChanged = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PropertyIdLogChanges = table.Column<long>(type: "bigint", nullable: true),
                    InsertUserId = table.Column<long>(type: "bigint", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<long>(type: "bigint", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MachineId = table.Column<long>(type: "bigint", nullable: true),
                    FormId = table.Column<long>(type: "bigint", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorization_Tbl",
                columns: table => new
                {
                    Categorization_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categorization_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Categorization_En_Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Categorization_Ar_name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Insert_User_ID = table.Column<long>(type: "bigint", nullable: true),
                    Insert_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Update_User_ID = table.Column<long>(type: "bigint", nullable: true),
                    Update_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Machine_ID = table.Column<long>(type: "bigint", nullable: true),
                    Form_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Categorization_Tbl", x => x.Categorization_ID);
                });

            migrationBuilder.CreateTable(
                name: "Organization_Tbl",
                columns: table => new
                {
                    Organization_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Organization_En_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Organization_Ar_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Customer_Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Properties_Names = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expiry_Date = table.Column<DateTime>(type: "date", nullable: true),
                    No_Of_Products = table.Column<int>(type: "int", nullable: true),
                    Sys_License_Type_IDs = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Multi_Property_YN = table.Column<bool>(type: "bit", nullable: true),
                    Unlimited_YN = table.Column<bool>(type: "bit", nullable: true),
                    License_Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Insert_User_ID = table.Column<long>(type: "bigint", nullable: true),
                    Insert_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Update_User_ID = table.Column<long>(type: "bigint", nullable: true),
                    Update_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Machine_ID = table.Column<long>(type: "bigint", nullable: true),
                    Form_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization_Tbl", x => x.Organization_ID);
                });

            migrationBuilder.CreateTable(
                name: "Property_Tbl",
                columns: table => new
                {
                    Property_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Organization_ID = table.Column<long>(type: "bigint", nullable: true),
                    Property_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, collation: "Arabic_CI_AS"),
                    Property_En_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AS"),
                    Property_Ar_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AS"),
                    API_Link = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    API_Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Arabic_CI_AS"),
                    API_Password = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Insert_User_ID = table.Column<long>(type: "bigint", nullable: true),
                    Insert_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Update_User_ID = table.Column<long>(type: "bigint", nullable: true),
                    Update_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Machine_ID = table.Column<long>(type: "bigint", nullable: true),
                    Form_ID = table.Column<long>(type: "bigint", nullable: true),
                    FormID = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    InsertedBy = table.Column<int>(type: "int", nullable: false, defaultValue: -99),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Tbl", x => x.Property_ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categorization_Details_Tbl",
                columns: table => new
                {
                    Categorization_Details_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categorization_ID = table.Column<long>(type: "bigint", nullable: true),
                    Categorization_Details_Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Categorization_Details_En_Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Categorization_Details_Ar_Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Insert_User_ID = table.Column<long>(type: "bigint", nullable: true),
                    Insert_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Update_User_ID = table.Column<long>(type: "bigint", nullable: true),
                    Update_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Machine_ID = table.Column<long>(type: "bigint", nullable: true),
                    Form_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Categorization_Details_Tbl", x => x.Categorization_Details_ID);
                    table.ForeignKey(
                        name: "FK_Categorization_Details_Tbl_Categorization_Tbl",
                        column: x => x.Categorization_ID,
                        principalTable: "Categorization_Tbl",
                        principalColumn: "Categorization_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Property_Categorization_Tbl",
                columns: table => new
                {
                    Property_Categorization_ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Property_ID = table.Column<long>(type: "bigint", nullable: true),
                    Categorization_ID = table.Column<long>(type: "bigint", nullable: true),
                    Categorization_Details_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property_Categorization_Tbl_1", x => x.Property_Categorization_ID);
                    table.ForeignKey(
                        name: "FK_Property_Categorization_Tbl_Categorization_Details_Tbl",
                        column: x => x.Categorization_Details_ID,
                        principalTable: "Categorization_Details_Tbl",
                        principalColumn: "Categorization_Details_ID");
                    table.ForeignKey(
                        name: "FK_Property_Categorization_Tbl_Categorization_Tbl",
                        column: x => x.Categorization_ID,
                        principalTable: "Categorization_Tbl",
                        principalColumn: "Categorization_ID");
                    table.ForeignKey(
                        name: "FK_Property_Categorization_Tbl_Property_Tbl",
                        column: x => x.Property_ID,
                        principalTable: "Property_Tbl",
                        principalColumn: "Property_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Categorization_Details_Tbl_Categorization_ID",
                table: "Categorization_Details_Tbl",
                column: "Categorization_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Categorization_Tbl_Categorization_Details_ID",
                table: "Property_Categorization_Tbl",
                column: "Categorization_Details_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Categorization_Tbl_Categorization_ID",
                table: "Property_Categorization_Tbl",
                column: "Categorization_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Property_Categorization_Tbl_Property_ID",
                table: "Property_Categorization_Tbl",
                column: "Property_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Organization_Tbl");

            migrationBuilder.DropTable(
                name: "Property_Categorization_Tbl");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categorization_Details_Tbl");

            migrationBuilder.DropTable(
                name: "Property_Tbl");

            migrationBuilder.DropTable(
                name: "Categorization_Tbl");
        }
    }
}
