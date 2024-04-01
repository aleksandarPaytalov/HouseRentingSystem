using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class AdminPasswordseededCorrectly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fb0faa5-768b-46f4-b7b8-788ab4a9927e", "AQAAAAEAACcQAAAAEL1DyYP9yozsa4sajFDfyZUIs6j1NvZReBOe92pGFn1Ygw2Kms5RMtF13wkB4NKZdA==", "52d3f8a8-1b5b-4285-9b4e-3a25a6730836" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90626cb8-eaa7-4af7-a201-4b315b16086e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08e68583-f15a-4b04-ba8b-37c5187cc74f", "AQAAAAEAACcQAAAAEGrZKhzvTOiUFQowQDfn69OsYxYzEXHVymlLAPKFRlfu9HWdnYxgiCUR3BhDEQnxtw==", "fc4189f3-f50a-4246-9978-d5f2d5b144d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7422b0a1-039a-40f5-8442-1a1e665d79a7", "AQAAAAEAACcQAAAAEHv9TZLJ77pQTI5PSJeshYhS20Zy7nxEBtMe/3Rlpr8BXMpDcCYp9nhcXnT0YTQrXg==", "98beb9cb-5f6b-4495-9180-a9459d26f443" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08255419-171a-46ca-b226-d533aa2302a0", null, "029290e3-abf6-45d3-ac1f-1dd8531dc717" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90626cb8-eaa7-4af7-a201-4b315b16086e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e101168-1827-4c9d-9bbe-2cdc9b694214", null, "b633838e-e899-457c-9fef-fe695d4933ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4b3b450-f2b7-4175-b59e-b34c8278800b", "AQAAAAEAACcQAAAAEKhLF+3qwz/9kLlMqPVayZCeyr0/BD+WM4W9ITazAZTbqtR+ZdHsm2P/kuw90uU3zA==", "93d529c8-7b3b-4f35-80ab-c63ba261ed1c" });
        }
    }
}
