using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class IsApprovedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApprover",
                table: "Houses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is house approved by admin");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f40cacb2-a5b4-4a95-a553-d259f799bb8e", "AQAAAAEAACcQAAAAEMlgSnztbDDuL09Na0E+MHKMPphXszHRjtL4T127/bQoc6V4BmnUp+C5DihBISKSxw==", "aecff01d-d6d3-42b5-8476-759e9320f4ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90626cb8-eaa7-4af7-a201-4b315b16086e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edeb9f70-00e2-413d-9a43-b7b6917005ed", "AQAAAAEAACcQAAAAEFGs4PWYnoWV/zH48gPxqk2rhevFU3cKFC/qmCx4X32yprx8OFtUjO50DH/CkPF9SA==", "5012dcb2-e616-416c-b6e5-af50a25a04c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74889f1a-26fb-4891-80db-6523cd5f6e80", "AQAAAAEAACcQAAAAEB2+OjY/HkrsZ0Zv7SOuWmTV8mLsyPPKDmQZF9VHIHok7gXt/xbQfhe+FH2JuKIt5w==", "b4bc2a8c-97e5-46c3-a164-2acccada97d6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApprover",
                table: "Houses");

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
    }
}
