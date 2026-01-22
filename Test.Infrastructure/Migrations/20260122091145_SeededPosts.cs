using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeededPosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedAt", "Image", "UserId" },
                values: new object[,]
                {
                    { "post-01-9f1b4d8a-21c0-4f5c-b102-a001", "Started rebuilding my backend architecture today.", new DateTime(2026, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), "", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "post-02-7c2a5d11-2e90-4bcb-a901-a002", "React hooks finally make sense.", new DateTime(2026, 1, 1, 9, 15, 0, 0, DateTimeKind.Utc), "", "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902" },
                    { "post-03-b81a7a29-0b8c-4a3b-b621-a003", "Designing a fresh dark theme UI 🌙", new DateTime(2026, 1, 1, 10, 40, 0, 0, DateTimeKind.Utc), "/posts/3.jpg", "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903" },
                    { "post-04-21f7ac19-91c2-48bb-b812-a004", "Learning penetration testing basics.", new DateTime(2026, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), "", "c91e9189-281f-48c3-b8ad-1b20f4f10104" },
                    { "post-05-3d71a8b4-7731-4b42-93b2-a005", "New illustration finished today 🎨", new DateTime(2026, 1, 1, 13, 25, 0, 0, DateTimeKind.Utc), "/posts/5.jpg", "da3a7cb3-5d90-45d2-83d9-9f8a2d92a105" },
                    { "post-06-41bc8c90-d241-4aa4-9921-a006", "Docker containers saved my sanity.", new DateTime(2026, 1, 1, 15, 0, 0, 0, DateTimeKind.Utc), "", "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106" },
                    { "post-07-19f7d901-8f62-4b98-8211-a007", "Experimenting with game physics today.", new DateTime(2026, 1, 2, 9, 30, 0, 0, DateTimeKind.Utc), "/posts/7.jpg", "e38db6c0-7b92-4f0f-b76a-d7b7f1aab107" },
                    { "post-08-771a9d44-6f11-4d55-b341-a008", "Exams week again 😭", new DateTime(2026, 1, 2, 11, 0, 0, 0, DateTimeKind.Utc), "", "17a7f919-62b3-4b1b-94bb-8cf80b8aa108" },
                    { "post-09-5a6a7b28-3810-4d6a-9c81-a009", "Publishing my next tech article soon.", new DateTime(2026, 1, 2, 13, 45, 0, 0, DateTimeKind.Utc), "/posts/9.jpg", "c6fdb72c-65b1-42df-bd03-4a3ff37f6109" },
                    { "post-10-9912a83a-2489-4f7b-9a31-a010", "Analytics dashboards are addictive.", new DateTime(2026, 1, 2, 16, 0, 0, 0, DateTimeKind.Utc), "", "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110" },
                    { "post-11-84b7d312-fb20-41ad-9012-a011", "Mobile app memory usage finally optimized.", new DateTime(2026, 1, 3, 9, 0, 0, 0, DateTimeKind.Utc), "", "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111" },
                    { "post-12-27b7f981-21a0-4db6-81f1-a012", "QA automation saves weeks of work.", new DateTime(2026, 1, 3, 10, 10, 0, 0, DateTimeKind.Utc), "", "2df3b7c4-29c2-41b2-b2cb-51c8f20d8112" },
                    { "post-13-fbc38d22-7b2a-4c51-a819-a013", "Java memory tuning is underrated.", new DateTime(2026, 1, 3, 11, 40, 0, 0, DateTimeKind.Utc), "", "4b46a84d-21a3-44db-9d2f-68c2f51f3113" },
                    { "post-14-91d72d19-2ab0-4e18-9f10-a014", "Reading about smart contracts today.", new DateTime(2026, 1, 3, 13, 20, 0, 0, DateTimeKind.Utc), "", "5d7e09fa-b71a-44c5-9e1f-9b4e4b09f114" },
                    { "post-15-31aa20fa-1e0c-4a4f-902a-a015", "Sprint planning done ✔️", new DateTime(2026, 1, 3, 15, 0, 0, 0, DateTimeKind.Utc), "", "82b1e839-f782-4c16-a1c2-2f8f1a2a5115" },
                    { "post-16-ff2b91d0-7e42-46ad-a0f9-a016", "Cloud cost optimization is painful.", new DateTime(2026, 1, 4, 9, 0, 0, 0, DateTimeKind.Utc), "", "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116" },
                    { "post-17-62cbd91a-f61e-4ef7-93fa-a017", "Hiring developers is harder than coding.", new DateTime(2026, 1, 4, 10, 30, 0, 0, DateTimeKind.Utc), "", "bbcfb1c7-d4a6-46fa-a9cc-5c9df8d07117" },
                    { "post-18-1187a1df-4f42-4b02-b1f2-a018", "Pitch deck is almost ready 🚀", new DateTime(2026, 1, 4, 12, 0, 0, 0, DateTimeKind.Utc), "", "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118" },
                    { "post-19-bc72fa01-3b22-4a83-9b41-a019", "JWT refresh tokens implemented.", new DateTime(2026, 1, 5, 9, 10, 0, 0, DateTimeKind.Utc), "", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "post-20-8c29f21a-5b81-47f2-a90c-a020", "Finally mastered CSS grid.", new DateTime(2026, 1, 5, 10, 45, 0, 0, DateTimeKind.Utc), "", "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902" },
                    { "post-21-37c29fa1-6e41-4012-a2b2-a021", "Minimal UI beats flashy UI.", new DateTime(2026, 1, 5, 12, 20, 0, 0, DateTimeKind.Utc), "", "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903" },
                    { "post-22-d31a8a41-ef02-42f7-8c3a-a022", "Sketching ideas for next artwork.", new DateTime(2026, 1, 5, 14, 0, 0, 0, DateTimeKind.Utc), "/posts/22.jpg", "da3a7cb3-5d90-45d2-83d9-9f8a2d92a105" },
                    { "post-23-51c9b122-19fa-48e3-8db1-a023", "CI/CD pipelines should be boring.", new DateTime(2026, 1, 5, 16, 10, 0, 0, DateTimeKind.Utc), "", "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106" },
                    { "post-24-1a8f7e21-d22b-4c4e-a190-a024", "Procedural terrain generation test.", new DateTime(2026, 1, 6, 9, 0, 0, 0, DateTimeKind.Utc), "/posts/24.jpg", "e38db6c0-7b92-4f0f-b76a-d7b7f1aab107" },
                    { "post-25-91c2df11-cc81-41fa-94b2-a025", "Coffee count today: 5 ☕", new DateTime(2026, 1, 6, 11, 0, 0, 0, DateTimeKind.Utc), "", "17a7f919-62b3-4b1b-94bb-8cf80b8aa108" },
                    { "post-26-62adf91b-421a-421f-b912-a026", "Tech blogging consistency is hard.", new DateTime(2026, 1, 6, 13, 0, 0, 0, DateTimeKind.Utc), "", "c6fdb72c-65b1-42df-bd03-4a3ff37f6109" },
                    { "post-27-9a81df21-1910-4d41-a401-a027", "Conversion metrics improved by 12%.", new DateTime(2026, 1, 6, 15, 0, 0, 0, DateTimeKind.Utc), "", "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110" },
                    { "post-28-2bc81df9-81fa-4f10-bd91-a028", "Flutter vs React Native debate continues.", new DateTime(2026, 1, 6, 17, 0, 0, 0, DateTimeKind.Utc), "", "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111" },
                    { "post-29-44bd9a01-2f10-4b72-b910-a029", "Regression tests passed ✅", new DateTime(2026, 1, 6, 18, 30, 0, 0, DateTimeKind.Utc), "", "2df3b7c4-29c2-41b2-b2cb-51c8f20d8112" },
                    { "post-30-2f8a91c2-18b4-4db9-b120-a030", "Refactoring legacy code feels great.", new DateTime(2026, 1, 7, 9, 0, 0, 0, DateTimeKind.Utc), "", "4b46a84d-21a3-44db-9d2f-68c2f51f3113" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-01-9f1b4d8a-21c0-4f5c-b102-a001");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-02-7c2a5d11-2e90-4bcb-a901-a002");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-03-b81a7a29-0b8c-4a3b-b621-a003");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-04-21f7ac19-91c2-48bb-b812-a004");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-05-3d71a8b4-7731-4b42-93b2-a005");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-06-41bc8c90-d241-4aa4-9921-a006");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-07-19f7d901-8f62-4b98-8211-a007");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-08-771a9d44-6f11-4d55-b341-a008");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-09-5a6a7b28-3810-4d6a-9c81-a009");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-10-9912a83a-2489-4f7b-9a31-a010");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-11-84b7d312-fb20-41ad-9012-a011");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-12-27b7f981-21a0-4db6-81f1-a012");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-13-fbc38d22-7b2a-4c51-a819-a013");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-14-91d72d19-2ab0-4e18-9f10-a014");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-15-31aa20fa-1e0c-4a4f-902a-a015");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-16-ff2b91d0-7e42-46ad-a0f9-a016");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-17-62cbd91a-f61e-4ef7-93fa-a017");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-18-1187a1df-4f42-4b02-b1f2-a018");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-19-bc72fa01-3b22-4a83-9b41-a019");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-20-8c29f21a-5b81-47f2-a90c-a020");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-21-37c29fa1-6e41-4012-a2b2-a021");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-22-d31a8a41-ef02-42f7-8c3a-a022");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-23-51c9b122-19fa-48e3-8db1-a023");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-24-1a8f7e21-d22b-4c4e-a190-a024");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-25-91c2df11-cc81-41fa-94b2-a025");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-26-62adf91b-421a-421f-b912-a026");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-27-9a81df21-1910-4d41-a401-a027");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-28-2bc81df9-81fa-4f10-bd91-a028");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-29-44bd9a01-2f10-4b72-b910-a029");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: "post-30-2f8a91c2-18b4-4db9-b120-a030");
        }
    }
}
