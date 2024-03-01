using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60f0ec2f-95a4-4d5c-9cba-3a3c68a145e0", "AQAAAAEAACcQAAAAEKo4nbLhaR1COr0fBIfn5WFYJt98RtqTKJrVTWqixzFwXQPLBK6NfIzY1oR9Sh/H+w==", "b6dcaee6-ad33-4e2b-880d-d96be2eac2ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ca76021-c147-4f9c-9345-8f90662b0b4d", "AQAAAAEAACcQAAAAEL6X8veAsMF10GMUnYqc6Y3DSxbLzLFwC2oyouRE3J85HULgfCo+0wRedktKC8tHKg==", "923d51bb-df99-428f-a824-41d2e5270d5d" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6704dd0-0d8f-4f7b-9973-4c951a4ebde8", "AQAAAAEAACcQAAAAEI/0ipzCAm4Wxd6/c0Fb2vN95KNwDxyD6AdYRjGbTSlwgWbcPaCZqqrYhH0Ap5JuCg==", "3f1852b8-2e44-4022-a629-b509b82e7ed4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d13f92cd-0d70-42ae-ab7d-4cfc094a153e", "AQAAAAEAACcQAAAAEHQVUXOrpmOOcpQY/2n7WTE+ewr3nIK6fWMRNofqt747n7Ics9K8pFW9F7NBx+L2fQ==", "5b81b062-1cb2-4fe8-8361-ac4471d9471d" });
        }
    }
}
