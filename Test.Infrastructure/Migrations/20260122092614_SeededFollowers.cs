using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeededFollowers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Followers",
                columns: new[] { "Id", "CreatedAt", "FollowerId", "FollowingId" },
                values: new object[,]
                {
                    { "follow-01-a81f", new DateTime(2025, 1, 5, 10, 0, 0, 0, DateTimeKind.Utc), "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "follow-02-b19f", new DateTime(2025, 1, 5, 11, 0, 0, 0, DateTimeKind.Utc), "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "follow-03-c7fa", new DateTime(2025, 1, 6, 9, 0, 0, 0, DateTimeKind.Utc), "c91e9189-281f-48c3-b8ad-1b20f4f10104", "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902" },
                    { "follow-04-d812", new DateTime(2025, 1, 6, 10, 0, 0, 0, DateTimeKind.Utc), "da3a7cb3-5d90-45d2-83d9-9f8a2d92a105", "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903" },
                    { "follow-05-e811", new DateTime(2025, 1, 7, 11, 0, 0, 0, DateTimeKind.Utc), "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106", "e38db6c0-7b92-4f0f-b76a-d7b7f1aab107" },
                    { "follow-06-f211", new DateTime(2025, 1, 8, 12, 0, 0, 0, DateTimeKind.Utc), "17a7f919-62b3-4b1b-94bb-8cf80b8aa108", "c6fdb72c-65b1-42df-bd03-4a3ff37f6109" },
                    { "follow-07-911a", new DateTime(2025, 1, 8, 14, 0, 0, 0, DateTimeKind.Utc), "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110", "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111" },
                    { "follow-08-71ab", new DateTime(2025, 1, 9, 9, 0, 0, 0, DateTimeKind.Utc), "2df3b7c4-29c2-41b2-b2cb-51c8f20d8112", "4b46a84d-21a3-44db-9d2f-68c2f51f3113" },
                    { "follow-09-2f81", new DateTime(2025, 1, 10, 10, 0, 0, 0, DateTimeKind.Utc), "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116", "82b1e839-f782-4c16-a1c2-2f8f1a2a5115" },
                    { "follow-10-91af", new DateTime(2025, 1, 11, 11, 0, 0, 0, DateTimeKind.Utc), "bbcfb1c7-d4a6-46fa-a9cc-5c9df8d07117", "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118" },
                    { "follow-11-acde", new DateTime(2025, 1, 12, 9, 0, 0, 0, DateTimeKind.Utc), "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01", "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902" },
                    { "follow-12-acde", new DateTime(2025, 1, 12, 9, 30, 0, 0, DateTimeKind.Utc), "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01", "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903" },
                    { "follow-13-acde", new DateTime(2025, 1, 13, 10, 0, 0, 0, DateTimeKind.Utc), "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902", "da3a7cb3-5d90-45d2-83d9-9f8a2d92a105" },
                    { "follow-14-acde", new DateTime(2025, 1, 13, 11, 0, 0, 0, DateTimeKind.Utc), "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903", "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106" },
                    { "follow-15-acde", new DateTime(2025, 1, 14, 9, 0, 0, 0, DateTimeKind.Utc), "c6fdb72c-65b1-42df-bd03-4a3ff37f6109", "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110" },
                    { "follow-16-acde", new DateTime(2025, 1, 14, 10, 0, 0, 0, DateTimeKind.Utc), "82b1e839-f782-4c16-a1c2-2f8f1a2a5115", "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116" },
                    { "follow-17-acde", new DateTime(2025, 1, 15, 11, 0, 0, 0, DateTimeKind.Utc), "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "follow-18-acde", new DateTime(2025, 1, 16, 9, 0, 0, 0, DateTimeKind.Utc), "bbcfb1c7-d4a6-46fa-a9cc-5c9df8d07117", "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902" },
                    { "follow-19-acde", new DateTime(2025, 1, 17, 10, 0, 0, 0, DateTimeKind.Utc), "17a7f919-62b3-4b1b-94bb-8cf80b8aa108", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "follow-20-acde", new DateTime(2025, 1, 18, 9, 0, 0, 0, DateTimeKind.Utc), "2df3b7c4-29c2-41b2-b2cb-51c8f20d8112", "82b1e839-f782-4c16-a1c2-2f8f1a2a5115" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-01-a81f");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-02-b19f");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-03-c7fa");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-04-d812");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-05-e811");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-06-f211");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-07-911a");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-08-71ab");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-09-2f81");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-10-91af");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-11-acde");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-12-acde");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-13-acde");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-14-acde");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-15-acde");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-16-acde");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-17-acde");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-18-acde");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-19-acde");

            migrationBuilder.DeleteData(
                table: "Followers",
                keyColumn: "Id",
                keyValue: "follow-20-acde");
        }
    }
}
