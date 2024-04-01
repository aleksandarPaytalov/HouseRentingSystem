using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class AdminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08255419-171a-46ca-b226-d533aa2302a0", "Guest", "Guestov", null, "029290e3-abf6-45d3-ac1f-1dd8531dc717" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4b3b450-f2b7-4175-b59e-b34c8278800b", "Agent", "Agentrov", "AQAAAAEAACcQAAAAEKhLF+3qwz/9kLlMqPVayZCeyr0/BD+WM4W9ITazAZTbqtR+ZdHsm2P/kuw90uU3zA==", "93d529c8-7b3b-4f35-80ab-c63ba261ed1c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "90626cb8-eaa7-4af7-a201-4b315b16086e", 0, "2e101168-1827-4c9d-9bbe-2cdc9b694214", "admin@mail.com", false, "Great", "Admin", false, null, "ADMIN@mail.com", "ADMIN@mail.com", null, null, false, "b633838e-e899-457c-9fef-fe695d4933ee", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 3, "+359888888887", "90626cb8-eaa7-4af7-a201-4b315b16086e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90626cb8-eaa7-4af7-a201-4b315b16086e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64851df8-8a8b-4b31-b858-379f7b2f05cc", "", "", "AQAAAAEAACcQAAAAELagnudbmbEDbUmOHjcs9IOr4uW73e9N528OHMTQJXLSEF54IBSJ/mLXLTHfRVjGOg==", "1bacac70-9c69-4d2f-aa39-7014df82a092" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71954097-4f8a-42e8-bae7-b84e3628d78b", "", "", "AQAAAAEAACcQAAAAECJRJfh/qXvEpuS1vBwRVRKp62IvTLGdasb293VMwJCaUQQlg0/VnYcglh57RDMg3w==", "13beb352-6635-44e1-b6c5-e0ea7687c834" });
        }
    }
}
