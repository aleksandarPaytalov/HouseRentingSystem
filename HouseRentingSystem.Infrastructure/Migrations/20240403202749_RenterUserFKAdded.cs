using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class RenterUserFKAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_UserId",
                table: "Agents");

            migrationBuilder.AlterColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(450)",
                nullable: true,
                comment: "User id of the renterer",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "User id of the renterer");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2686cde7-9250-4cd3-8060-6fa8b17f9672", "AQAAAAEAACcQAAAAEIaDFFfc0+6vH7EBUFj09FnjF3nLl+HOgSZYC5s12B/nZkBoO3dB8tFBODZt5xoR9w==", "bed3245b-2b89-44a0-ae9f-fbabb9776341" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90626cb8-eaa7-4af7-a201-4b315b16086e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d2b91af-9b46-4df2-8329-8ed0e845c46e", "AQAAAAEAACcQAAAAELrUnR34UNRAis4j4h72G9IN7ObZUrVUNfRPRLbDduCO51YoafAzpbgwsRzhFKiHSg==", "38abd993-fe17-431e-a936-33b39e18e4d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f329645-6d65-4bce-90f8-c9bd0f8d93cd", "AQAAAAEAACcQAAAAEOCpdoIUnXw7E3za9F+LrEWEGnS42z4KwarxKOm8yMl554O14ygHk+oOf8oAyrO1UA==", "cb2b931d-3809-42c3-ac9a-84091918758d" });

            migrationBuilder.CreateIndex(
                name: "IX_Houses_RenterId",
                table: "Houses",
                column: "RenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Agents_UserId",
                table: "Agents",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_AspNetUsers_RenterId",
                table: "Houses",
                column: "RenterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_AspNetUsers_RenterId",
                table: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_Houses_RenterId",
                table: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_Agents_UserId",
                table: "Agents");

            migrationBuilder.AlterColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true,
                comment: "User id of the renterer",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true,
                oldComment: "User id of the renterer");

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

            migrationBuilder.CreateIndex(
                name: "IX_Agents_UserId",
                table: "Agents",
                column: "UserId");
        }
    }
}
