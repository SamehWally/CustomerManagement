using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerManagement.Data.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountingDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branchs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moderators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moderators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientTypeId = table.Column<int>(type: "int", nullable: false),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    NationalIdentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEmployee = table.Column<bool>(type: "bit", nullable: false),
                    IsOperatingClient = table.Column<bool>(type: "bit", nullable: false),
                    NoCommissionOnFriday = table.Column<bool>(type: "bit", nullable: false),
                    BusinessDayCommissionOnly = table.Column<bool>(type: "bit", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerTaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeratorId = table.Column<int>(type: "int", nullable: false),
                    AddressAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordApp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMEI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumberStcPay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarRental = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfReceiptCar = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mailbox = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IqamaExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LicenseExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commission = table.Column<int>(type: "int", nullable: false),
                    Bonus = table.Column<int>(type: "int", nullable: false),
                    IsMonthlyCommission = table.Column<bool>(type: "bit", nullable: false),
                    CommissionByValueOrPercentage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommissionAfterOrderNumber = table.Column<int>(type: "int", nullable: false),
                    OrderCommission = table.Column<int>(type: "int", nullable: false),
                    AllOrders = table.Column<bool>(type: "bit", nullable: false),
                    OpeningBalance = table.Column<int>(type: "int", nullable: false),
                    Creditlimit = table.Column<int>(type: "int", nullable: false),
                    NationalityId = table.Column<int>(type: "int", nullable: false),
                    StartWorkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountingDayId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    ShiftId = table.Column<int>(type: "int", nullable: false),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IBAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsStop = table.Column<bool>(type: "bit", nullable: false),
                    StopDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StopReason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_AccountingDays_AccountingDayId",
                        column: x => x.AccountingDayId,
                        principalTable: "AccountingDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Branchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_ClientTypes_ClientTypeId",
                        column: x => x.ClientTypeId,
                        principalTable: "ClientTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Moderators_ModeratorId",
                        column: x => x.ModeratorId,
                        principalTable: "Moderators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccountingDays",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "يوم المحاسبة 1" },
                    { 2, "يوم المحاسبة 2" },
                    { 3, "يوم المحاسبة 3" }
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Facebook" },
                    { 2, "WhatsApp" },
                    { 3, "Instagram" }
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "المنطقة الاولي" },
                    { 2, "المنطقة الثالثة" },
                    { 3, "المنطقة الرابعة" }
                });

            migrationBuilder.InsertData(
                table: "Branchs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "الفرع الاولي" },
                    { 2, "الفرع الثالثة" },
                    { 3, "الفرع الرابعة" }
                });

            migrationBuilder.InsertData(
                table: "ClientTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "مندوب" },
                    { 2, "عميل" },
                    { 3, "مورد" },
                    { 4, "اخري" },
                    { 5, "منسق" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "الجنية" },
                    { 2, "الريال" },
                    { 3, "الدولار" }
                });

            migrationBuilder.InsertData(
                table: "Moderators",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "أشرف" },
                    { 2, "أيمن" },
                    { 3, "محمود" }
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "مصري" },
                    { 2, "سعودي" },
                    { 3, "امريكي" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AccountingDayId",
                table: "Clients",
                column: "AccountingDayId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ApplicationId",
                table: "Clients",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AreaId",
                table: "Clients",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_BranchId",
                table: "Clients",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ClientTypeId",
                table: "Clients",
                column: "ClientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CurrencyId",
                table: "Clients",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ModeratorId",
                table: "Clients",
                column: "ModeratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_NationalityId",
                table: "Clients",
                column: "NationalityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "AccountingDays");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Branchs");

            migrationBuilder.DropTable(
                name: "ClientTypes");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Moderators");

            migrationBuilder.DropTable(
                name: "Nationalities");
        }
    }
}
