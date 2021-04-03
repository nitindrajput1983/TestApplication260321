using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CreditCardPayment.Migrations
{
    public partial class CreatePaymentDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "paymentdetails",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CerditcardNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardHold = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecurityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentdetails", x => x.PaymentId);
                });

            migrationBuilder.CreateTable(
                name: "paymentstatus",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusDesp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentstatus", x => x.StatusId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "paymentdetails");

            migrationBuilder.DropTable(
                name: "paymentstatus");
        }
    }
}
