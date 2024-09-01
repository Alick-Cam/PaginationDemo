using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pagination.Demo.Data.Migrations
{
    /// <inheritdoc />
    public partial class Car : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Condition = table.Column<string>(type: "TEXT", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSold = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateSold = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Condition", "DatePurchased", "DateSold", "IsSold", "Name" },
                values: new object[,]
                {
                    { new Guid("1a23c4f6-7a4e-4f7b-83f4-6c4b8e7d9f1c"), "Mazda", "Like New", new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "CX-5" },
                    { new Guid("1a33c712-3c52-40d5-9c11-24f9bcf52f62"), "Toyota", "Mint", new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "RAV4" },
                    { new Guid("1a4e5c7b-9f3d-2f8a-6b7e-3c1f9d2a4f7b"), "Porsche", "Mint", new DateTime(2020, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "718 Boxster" },
                    { new Guid("1b2c9a8f-3d5e-7f4a-6b1e-9c2f3a7d5e6b"), "Honda", "Like New", new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Accord" },
                    { new Guid("1b2f3c7e-6a4d-4e5f-8b9c-7d2a9f4b6e3a"), "Subaru", "Mint", new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Crosstrek" },
                    { new Guid("1b5f3a7d-2c4e-9b6a-8f3e-7d2e5c9a4f7b"), "Audi", "Like New", new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "SQ5" },
                    { new Guid("1b9e6f2d-7c3a-4f5b-2e8a-5d9a3f7e4b1c"), "Ford", "Like New", new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Mustang Mach-E" },
                    { new Guid("1c2f3d9b-4a5e-7f8a-6b1d-9e3a7b5c2e4f"), "Toyota", "Mint", new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Corolla" },
                    { new Guid("1c3a7e5b-2d4f-9a6b-5e2c-3f4d9b7a1e6f"), "Volkswagen", "Mint", new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Passat" },
                    { new Guid("1d2f4b3d-9e5f-4a7e-b4c3-2f4b6e7a1d9c"), "Nissan", "Used", new DateTime(2018, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Leaf" },
                    { new Guid("1d9b4e5a-2f7c-6b3e-9f1a-8c5f3d2a7e6b"), "Toyota", "Like New", new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Tundra" },
                    { new Guid("2a5d8e7b-4c3f-4a9f-6e7c-5b2d9f4a3e7c"), "Audi", "New", new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Q5" },
                    { new Guid("2b3f5d4a-9e1c-8a7e-6f2b-4d1e7a9c3f5e"), "Honda", "Like New", new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Ridgeline" },
                    { new Guid("2b4e7f3a-5c1d-8f6a-9e2a-4d9c7b3e1f5a"), "Audi", "New", new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Q7" },
                    { new Guid("2c4f7e5d-8b9a-3a1e-4d2c-5f6b7a8e9f1b"), "Land Rover", "Like New", new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Range Rover Evoque" },
                    { new Guid("2c5e9f7a-3b1d-4a6f-8e2c-1b3f7a9d5e4b"), "Toyota", "Mint", new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Tacoma" },
                    { new Guid("2e1b9c7d-4a6f-5b8e-9d2c-3f7a5e4d1c3a"), "Lucid", "Like New", new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Lucid Air" },
                    { new Guid("2e5c9f7b-3a4d-4b6a-8e2f-1c3f9d7a5b6e"), "Audi", "Mint", new DateTime(2020, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Q8" },
                    { new Guid("2e75f8a7-8a62-4e45-bf71-07c1a1b8b8a4"), "Hyundai", "Mint", new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Kona" },
                    { new Guid("2f1b8c3d-7a4e-6f9b-9e2a-4d5c3f7a6e1b"), "Tesla", "Like New", new DateTime(2020, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Model S" },
                    { new Guid("2f5a4e3b-9d1c-7f6a-8b3e-4d9f2c7a5e1b"), "Volkswagen", "Used", new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Arteon" },
                    { new Guid("2fda1b26-3650-4a8f-936d-730a2b89efc4"), "Toyota", "Used", new DateTime(2018, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sequoia" },
                    { new Guid("319ad4d2-9e43-46e1-950d-1e5a679bc693"), "Toyota", "Like New", new DateTime(2022, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "4Runner" },
                    { new Guid("3a2e5f7c-9d4b-8b1f-6a7e-2c4f3b9d5a7e"), "Audi", "Mint", new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "A4" },
                    { new Guid("3a4d5e7c-8f1b-9c2a-6f3e-7b1e9f2d4c5b"), "Honda", "Mint", new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Civic" },
                    { new Guid("3a7b6e5c-1d2f-9c4b-7f3a-2b5e9d4a6c1e"), "Volkswagen", "New", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Tiguan" },
                    { new Guid("3b2f5c7d-4e9a-8f1e-6c3a-7d9f2b4e5c1f"), "Porsche", "Like New", new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Macan" },
                    { new Guid("3b54c6a2-7f62-4b3a-8d2e-4b5c8a7e9f4e"), "Mazda", "New", new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "CX-9" },
                    { new Guid("3c5e7d2a-4b1f-9f6b-7c8a-2e3d1a5f7b4e"), "Audi", "New", new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "E-Tron" },
                    { new Guid("3d2b7f8a-4e5c-9b1f-6a7d-3e9f2a4b5c1e"), "Subaru", "New", new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Forester" },
                    { new Guid("3e4d7a5c-2b1f-6f9e-8c2a-7f3d5b6a9e4b"), "Audi", "Like New", new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "A4" },
                    { new Guid("3e4f2b1a-7c5d-9e8f-6b7a-1c2d3f4a5b6c"), "Land Rover", "Used", new DateTime(2019, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Velar" },
                    { new Guid("3f2e7d6a-1c4b-5f8a-9b7e-2d9f4c3a5e6b"), "Volkswagen", "Used", new DateTime(2019, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Jetta" },
                    { new Guid("3f7e1b9c-5a2d-4f6b-8c1e-7d2a4e5c9f3b"), "Toyota", "Used", new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "4Runner" },
                    { new Guid("4a2c9f7d-5e3b-8f1e-6b7c-3d4a9e1b2f6a"), "Ford", "New", new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "F-150 Lightning" },
                    { new Guid("4b7e9a5d-1f3c-4e2f-9b6a-2c7d5f8a3e1c"), "Audi", "New", new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "A6" },
                    { new Guid("4c7d9b2a-1f3e-5a6f-8e7b-9d3a5c2f1b4e"), "Audi", "Used", new DateTime(2018, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "A3" },
                    { new Guid("4d7c2f9e-1a3b-5e8f-9a6c-3b5f7e4d2c1a"), "Audi", "Mint", new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Q8" },
                    { new Guid("4e1b7c9f-2a3f-6b5e-9d7e-3c4a8f2b1d5e"), "Tesla", "New", new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Model X" },
                    { new Guid("4e7b9a5c-3d1f-6b4e-8c2a-9d5f3a2b7e1c"), "Volkswagen", "Mint", new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Atlas" },
                    { new Guid("4f6a7e8b-1c2d-4b5e-8f3a-7d9c5b6a3e1c"), "Subaru", "Like New", new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Outback" },
                    { new Guid("55e3a9b2-4b6e-48e3-9f27-1c4f9a4b3e6a"), "Nissan", "Mint", new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Altima" },
                    { new Guid("5a3f7b4d-2e1c-9f8a-6b7e-3c4d9e2a5f1b"), "Volkswagen", "Like New", new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Jetta" },
                    { new Guid("5c1f7e4b-3a2d-9f6a-7e5b-2c4a9d3b7f2e"), "Porsche", "New", new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Panamera" },
                    { new Guid("5c6a8e9f-2b3d-4f5e-b8a7-9c1e3f2b7a4d"), "Mazda", "Used", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "CX-3" },
                    { new Guid("5d4e7a2c-3b9f-4f1e-6c8a-9b7d2f3a4e1b"), "Volkswagen", "Like New", new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "T-Roc" },
                    { new Guid("5d9a8e7c-3f1b-4c2f-6b7a-8d5f2a9e3c4b"), "Audi", "Used", new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "A8" },
                    { new Guid("5e3a7b6c-2d4f-9a1f-8e7b-6c3d2a5f1e9b"), "Tesla", "Used", new DateTime(2018, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Model Y" },
                    { new Guid("5e7b8a6c-2d3f-4b4a-9f3c-1e2d7a8f5c4b"), "Subaru", "Used", new DateTime(2018, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Impreza" },
                    { new Guid("5e9c7d4a-3f1b-2b8a-6c7e-1f5d4a7b2e9f"), "Audi", "Like New", new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "A6" },
                    { new Guid("5f1c8e3b-4a7d-9f2e-6b3a-8c7f9d4b1e2a"), "Rivian", "Mint", new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Rivian R1S" },
                    { new Guid("5f7a9c2e-1b4d-8f3a-6e2b-7d9f4a1c3e5b"), "Honda", "Used", new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Pilot" },
                    { new Guid("6b9e7c1f-4a3d-2e5f-8b7a-3f4c9d2e1a5f"), "Toyota", "New", new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Highlander" },
                    { new Guid("6d2b9a7f-4e1c-5b8e-3c2f-7a9d5c3f1b7e"), "Porsche", "Like New", new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Taycan" },
                    { new Guid("6d4b7e5f-3a2c-4f9e-8a6d-1c3b9f7a2e5c"), "Subaru", "Like New", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Legacy" },
                    { new Guid("6d8f9b2c-3e4a-5f1d-7c6b-9a1f2b7e3c4a"), "Porsche", "New", new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Cayman" },
                    { new Guid("6e7b9f2a-3c1d-4f8a-5e2b-7f6c4a3d9b5e"), "Tesla", "Mint", new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Roadster" },
                    { new Guid("74269c56-c022-4b9e-90d3-eccd9e5f6873"), "Toyota", "New", new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Camry" },
                    { new Guid("7a4b5c6d-8e9f-1a2b-3c4d-5f6e7b8a9d1f"), "Land Rover", "New", new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Discovery" },
                    { new Guid("7a4e5b6c-2f3d-4b9a-8f1e-6c5f9d2a3b7e"), "Volkswagen", "Like New", new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Tiguan" },
                    { new Guid("7a9d5b3c-4f1e-2d6a-8c7f-3b2a9e1c5d7e"), "Tesla", "Mint", new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Model 3" },
                    { new Guid("7b3f5c2d-4e1a-8a7e-9f6b-2c3a9e4d7b5f"), "Audi", "New", new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "A8" },
                    { new Guid("7d2e9f4a-1b3c-4f8a-9b5e-6a7f3c1d2b5e"), "Volkswagen", "New", new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Golf R" },
                    { new Guid("7d9e4b3a-1f6c-8f5e-9b2a-3c7f2d5e1a4b"), "Rivian", "Used", new DateTime(2018, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Rivian R1T" },
                    { new Guid("7e3a9d2b-4c1f-6f8a-7b5e-2a4f5d6c9b1e"), "Jaguar", "Mint", new DateTime(2020, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "I-Pace" },
                    { new Guid("7e4f3b5e-9c1d-4a7b-8f4e-5b6c9a7e1d2f"), "Nissan", "Like New", new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Sentra" },
                    { new Guid("7e5a2c3d-9f1b-4b7e-6a3f-8d9f4a6c2b7e"), "Volkswagen", "Used", new DateTime(2019, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Touareg" },
                    { new Guid("7f3c2b5e-9a4d-8b6f-1e3a-5c7d9f2a6e1b"), "Volkswagen", "Mint", new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Passat" },
                    { new Guid("7f6b8e9a-1c4d-3a5e-9f2b-7e3a1b2c9f4d"), "Toyota", "Like New", new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Camry" },
                    { new Guid("846e6b3d-39f4-4a2d-b29e-b4d294de4e34"), "Toyota", "Like New", new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Sienna" },
                    { new Guid("8a3c6b4e-2d1f-7f9a-3e5b-1c4f7a9d5b2e"), "Porsche", "Mint", new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Cayenne" },
                    { new Guid("8c3b5a7e-4d2f-9e1a-7f6b-2a4e9d3c5f7a"), "Audi", "Like New", new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Q5" },
                    { new Guid("8e7a6f5c-3d2b-4a4e-b9f3-1c7d5b8a2f4c"), "Mazda", "Mint", new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "MX-5" },
                    { new Guid("8e7f2d3a-4b5c-1e9a-7c6b-2f4a3d9e1f6b"), "Honda", "Mint", new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Odyssey" },
                    { new Guid("8f4a3c7e-2d9b-6f1e-3b5a-9c7f1e2d4b5e"), "Audi", "Mint", new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "E-Tron GT" },
                    { new Guid("9b7f3a5c-1e4d-6c2a-7f9b-8d1e3c4a5f7b"), "Land Rover", "Mint", new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Range Rover Sport" },
                    { new Guid("9c3a8f2b-1d4e-5b7f-6a9e-4c2d7f1b3a6e"), "Volkswagen", "New", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Atlas" },
                    { new Guid("9c4b3a7e-1f5d-6b2e-8c9a-3e2d7f1a5b4e"), "Lucid", "New", new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Lucid Gravity" },
                    { new Guid("9c8a7b5f-2d4e-3f6a-1c7b-4d9e5a2c3f1b"), "Honda", "New", new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "CR-V" },
                    { new Guid("9d3a6f2b-5e1c-8b7e-4a2f-3c7f1a9d4e5b"), "Porsche", "Used", new DateTime(2019, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "911" },
                    { new Guid("9d4a7c5e-2f1b-3e9f-8a6b-1c5f7b2d3e4a"), "Honda", "New", new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Passport" },
                    { new Guid("9e5c7f3a-2b4e-8d1a-6f9b-3c2d7a4e5f1b"), "Audi", "Mint", new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Q3" },
                    { new Guid("9f3a6e5c-2d4b-7a1f-5c8e-3b2f7d9a4e1c"), "Audi", "Mint", new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Q7" },
                    { new Guid("a1e4d6f7-8b9c-4d2f-9e3a-5c6b7f8a1d2e"), "Land Rover", "Mint", new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Defender" },
                    { new Guid("a9d3e013-6e5b-4b28-9fa4-5dcdf4f3f9a9"), "Toyota", "Mint", new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Avalon" },
                    { new Guid("b6f7c4e9-4d1b-4e2f-9e8d-1f2a4b7e6c9d"), "Nissan", "New", new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Maxima" },
                    { new Guid("b7f2c4e8-3a9b-4d1e-7c5f-8a9d2e6f3b4c"), "Volkswagen", "Like New", new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beetle" },
                    { new Guid("b85e847f-3b67-4d6b-8b4c-74e8b2b3c7f2"), "Nissan", "Mint", new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Armada" },
                    { new Guid("bb5467d3-4d65-4f3a-bc4e-8e8e4a7f4c42"), "Toyota", "Used", new DateTime(2019, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Highlander" },
                    { new Guid("c7a9b4d2-1d2e-4b6f-9a3d-6e7f2b9a5c4e"), "Nissan", "Mint", new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Rogue" },
                    { new Guid("c8a3b7e4-9d6f-4b1a-2e5c-7f4d3a2e9b6a"), "Volkswagen", "New", new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Polo" },
                    { new Guid("d5f2a4d6-3f6b-43b6-bcfa-991fad3b9e1c"), "Hyundai", "Mint", new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Santa Fe" },
                    { new Guid("e0f6a687-8948-4d60-967b-ecad47a9b6d8"), "Hyundai", "Like New", new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Palisade" },
                    { new Guid("e2c7b5e1-7e9e-4c1b-939b-c5e6b3b4f9a7"), "Nissan", "Used", new DateTime(2019, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Murano" },
                    { new Guid("f0d3a2e9-1c6b-4b8f-9e7d-3a4f2c5e7b6a"), "Volkswagen", "Mint", new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Golf" },
                    { new Guid("f2b3c5d6-7e8a-4f9b-6c1d-9e4a3f7b2c8d"), "Land Rover", "Like New", new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Range Rover" },
                    { new Guid("f4b2d3e1-4a6b-9e5d-3f2c-7e9a1d6c8b4f"), "Nissan", "New", new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Frontier" },
                    { new Guid("f9e87458-1c1c-4e5b-93db-4b4f9a4a2e8a"), "Nissan", "New", new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Pathfinder" },
                    { new Guid("fa3e7fd1-4b7e-4f68-a8c6-85e8b9a6de69"), "Hyundai", "New", new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Tucson" },
                    { new Guid("ffb1a6b8-0b4d-42d8-9e4d-f7e7a5d2b8c4"), "Nissan", "Like New", new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "X-Terra" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
