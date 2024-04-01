using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class ApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Houses",
                comment: "House to rent",
                oldComment: "House");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Houses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Title",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true,
                comment: "User id of the renterer",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "User id of the rent agent");

            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerMonth",
                table: "Houses",
                type: "decimal(18,2)",
                nullable: false,
                comment: "Monthly price",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "House price per month");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Houses",
                type: "int",
                nullable: false,
                comment: "House Identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "House identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Categories",
                type: "int",
                nullable: false,
                comment: "Category Identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Category identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Agents",
                type: "nvarchar(450)",
                nullable: false,
                comment: "User Identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "User identifier");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Agents",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                comment: "Agent's phone",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldComment: "Agent phone number");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Agents",
                type: "int",
                nullable: false,
                comment: "Agent identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Agent Identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterTable(
                name: "Houses",
                comment: "House",
                oldComment: "House to rent");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Houses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Title");

            migrationBuilder.AlterColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true,
                comment: "User id of the rent agent",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "User id of the renterer");

            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerMonth",
                table: "Houses",
                type: "decimal(18,2)",
                nullable: false,
                comment: "House price per month",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "Monthly price");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Houses",
                type: "int",
                nullable: false,
                comment: "House identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "House Identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Categories",
                type: "int",
                nullable: false,
                comment: "Category identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Category Identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Agents",
                type: "nvarchar(450)",
                nullable: false,
                comment: "User identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "User Identifier");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Agents",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                comment: "Agent phone number",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldComment: "Agent's phone");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Agents",
                type: "int",
                nullable: false,
                comment: "Agent Identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Agent identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
        }
    }
}
