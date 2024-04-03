using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UserClaimsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "user:fullname", "Agent Agentov", "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 2, "user:fullname", "Guest Guestov", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { 3, "user:fullname", "Great Admin", "90626cb8-eaa7-4af7-a201-4b315b16086e" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6829051-a900-49d4-a5f1-e6c6914d6c5d", "AQAAAAEAACcQAAAAEBylW0nPqm/bVykEfbcDiEVxri7gAdoYAlgziBPd0xGJHB2//r6EFdEP6y/wn0VYmg==", "932eca97-4d44-487a-9d89-61448b8683c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90626cb8-eaa7-4af7-a201-4b315b16086e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e14ec7b8-a6ac-4614-9486-e34480c72914", "AQAAAAEAACcQAAAAEKjSxHYW8ltM3u3Td6Nzdazo3NfhPTBXEdGdyhZOW/h52pMdZMCb+TVcPWbnH9AhqA==", "5e4caf39-017b-4131-ad43-069e9f7600ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4db6634-8a5d-4f8b-965d-fe952f1ce4b1", "AQAAAAEAACcQAAAAEP8eeCh4QVuufDdZy/ZQxPCgsF/cgHsaVK5J3Elwql2mfv54U+RGElWUlrZCjtX9Nw==", "d20797d5-7c18-4457-b03f-10b9cf26be4c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

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
    }
}
