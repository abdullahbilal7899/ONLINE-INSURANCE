using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Insurance.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Healthinsurances",
                columns: table => new
                {
                    Policynumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNICnumber = table.Column<int>(type: "int", nullable: false),
                    BankACC = table.Column<int>(type: "int", nullable: false),
                    HolderName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Contact = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MartialStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PolicyValidity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PolicyStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Package = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Healthinsurances", x => x.Policynumber);
                });

            migrationBuilder.CreateTable(
                name: "Homeinsurances",
                columns: table => new
                {
                    Policynumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNICnumber = table.Column<int>(type: "int", nullable: false),
                    BankACC = table.Column<int>(type: "int", nullable: false),
                    HolderName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Contact = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseMembers = table.Column<int>(type: "int", nullable: false),
                    HouseOwner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Housesqyard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Houseprice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Housetype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PolicyValidity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Package = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homeinsurances", x => x.Policynumber);
                });

            migrationBuilder.CreateTable(
                name: "Lifeinsurances",
                columns: table => new
                {
                    Policynumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNICnumber = table.Column<int>(type: "int", nullable: false),
                    BankACC = table.Column<int>(type: "int", nullable: false),
                    HolderName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Contact = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MartialStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PolicyValidity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PolicyStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    NextofKIN = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    RelationshipwithKIN = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    KinContact = table.Column<int>(type: "int", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Package = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lifeinsurances", x => x.Policynumber);
                });

            migrationBuilder.CreateTable(
                name: "Motorinsurances",
                columns: table => new
                {
                    Policynumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNICnumber = table.Column<int>(type: "int", nullable: false),
                    BankACC = table.Column<int>(type: "int", nullable: false),
                    HolderName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Contact = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vehiclenubmer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purchasedate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PolicyValidity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Package = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorinsurances", x => x.Policynumber);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Healthinsurances");

            migrationBuilder.DropTable(
                name: "Homeinsurances");

            migrationBuilder.DropTable(
                name: "Lifeinsurances");

            migrationBuilder.DropTable(
                name: "Motorinsurances");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
