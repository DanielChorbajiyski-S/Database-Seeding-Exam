using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeededUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "Bio", "CreatedAt", "Email", "UserName" },
                values: new object[,]
                {
                    { "17a7f919-62b3-4b1b-94bb-8cf80b8aa108", "/avatars/u8.png", "Computer science student", new DateTime(2024, 12, 11, 13, 0, 0, 0, DateTimeKind.Utc), "sofia@example.com", "sofia" },
                    { "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01", "/avatars/u1.png", "Backend developer • ASP.NET • Linux", new DateTime(2024, 12, 1, 9, 10, 0, 0, DateTimeKind.Utc), "bozhidar@example.com", "bozhidar" },
                    { "2df3b7c4-29c2-41b2-b2cb-51c8f20d8112", "/avatars/u12.png", "QA engineer", new DateTime(2024, 12, 16, 11, 10, 0, 0, DateTimeKind.Utc), "teodora@example.com", "teodora" },
                    { "4b46a84d-21a3-44db-9d2f-68c2f51f3113", "/avatars/u13.png", "Java developer", new DateTime(2024, 12, 17, 10, 10, 0, 0, DateTimeKind.Utc), "martin@example.com", "martin" },
                    { "5d7e09fa-b71a-44c5-9e1f-9b4e4b09f114", "/avatars/u14.png", "Blockchain enthusiast", new DateTime(2024, 12, 18, 19, 30, 0, 0, DateTimeKind.Utc), "kaloyan@example.com", "kaloyan" },
                    { "82b1e839-f782-4c16-a1c2-2f8f1a2a5115", "/avatars/u15.png", "Product manager", new DateTime(2024, 12, 19, 8, 50, 0, 0, DateTimeKind.Utc), "irina@example.com", "irina" },
                    { "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110", "/avatars/u10.png", "Marketing specialist", new DateTime(2024, 12, 14, 9, 20, 0, 0, DateTimeKind.Utc), "victoria@example.com", "victoria" },
                    { "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902", "/avatars/u2.png", "Frontend dev • React", new DateTime(2024, 12, 3, 11, 20, 0, 0, DateTimeKind.Utc), "alex@example.com", "alex" },
                    { "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116", "/avatars/u16.png", "Cloud engineer", new DateTime(2024, 12, 20, 12, 10, 0, 0, DateTimeKind.Utc), "stefan@example.com", "stefan" },
                    { "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106", "/avatars/u6.png", "DevOps • Docker • Kubernetes", new DateTime(2024, 12, 9, 8, 10, 0, 0, DateTimeKind.Utc), "ivan@example.com", "ivan" },
                    { "bbcfb1c7-d4a6-46fa-a9cc-5c9df8d07117", "/avatars/u17.png", "HR & recruiting", new DateTime(2024, 12, 21, 14, 15, 0, 0, DateTimeKind.Utc), "nadya@example.com", "nadya" },
                    { "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111", "/avatars/u11.png", "Mobile developer", new DateTime(2024, 12, 15, 14, 0, 0, 0, DateTimeKind.Utc), "daniel@example.com", "daniel" },
                    { "c6fdb72c-65b1-42df-bd03-4a3ff37f6109", "/avatars/u9.png", "Tech blogger", new DateTime(2024, 12, 12, 16, 0, 0, 0, DateTimeKind.Utc), "george@example.com", "george" },
                    { "c91e9189-281f-48c3-b8ad-1b20f4f10104", "/avatars/u4.png", "Cybersecurity student", new DateTime(2024, 12, 6, 10, 0, 0, 0, DateTimeKind.Utc), "nikola@example.com", "nikola" },
                    { "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118", "/avatars/u18.png", "Startup founder", new DateTime(2024, 12, 22, 17, 40, 0, 0, DateTimeKind.Utc), "rado@example.com", "rado" },
                    { "da3a7cb3-5d90-45d2-83d9-9f8a2d92a105", "/avatars/u5.png", "Digital artist", new DateTime(2024, 12, 7, 12, 40, 0, 0, DateTimeKind.Utc), "elena@example.com", "elena" },
                    { "e38db6c0-7b92-4f0f-b76a-d7b7f1aab107", "/avatars/u7.png", "Game developer", new DateTime(2024, 12, 10, 18, 30, 0, 0, DateTimeKind.Utc), "petar@example.com", "petar" },
                    { "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903", "/avatars/u3.png", "UI / UX designer", new DateTime(2024, 12, 5, 15, 45, 0, 0, DateTimeKind.Utc), "maria@example.com", "maria" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17a7f919-62b3-4b1b-94bb-8cf80b8aa108");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2df3b7c4-29c2-41b2-b2cb-51c8f20d8112");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4b46a84d-21a3-44db-9d2f-68c2f51f3113");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5d7e09fa-b71a-44c5-9e1f-9b4e4b09f114");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "82b1e839-f782-4c16-a1c2-2f8f1a2a5115");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bbcfb1c7-d4a6-46fa-a9cc-5c9df8d07117");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c6fdb72c-65b1-42df-bd03-4a3ff37f6109");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c91e9189-281f-48c3-b8ad-1b20f4f10104");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "da3a7cb3-5d90-45d2-83d9-9f8a2d92a105");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e38db6c0-7b92-4f0f-b76a-d7b7f1aab107");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903");
        }
    }
}
