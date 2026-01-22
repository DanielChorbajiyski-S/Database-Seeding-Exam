using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeededMessages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "CreatedAt", "Read", "ReceiverId", "SenderId" },
                values: new object[,]
                {
                    { "msg-001-4a8f1b01", "Hey, did you finish the API changes?", new DateTime(2026, 1, 1, 9, 0, 0, 0, DateTimeKind.Utc), true, "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "msg-002-92bc1102", "Almost, just fixing validation.", new DateTime(2026, 1, 1, 9, 2, 0, 0, DateTimeKind.Utc), true, "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01", "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902" },
                    { "msg-003-ff21ac03", "Nice, ping me when ready.", new DateTime(2026, 1, 1, 9, 3, 0, 0, DateTimeKind.Utc), true, "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "msg-004-bac91204", "Can you review my UI mockups?", new DateTime(2026, 1, 1, 11, 10, 0, 0, DateTimeKind.Utc), true, "da3a7cb3-5d90-45d2-83d9-9f8a2d92a105", "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903" },
                    { "msg-005-acde3305", "Sure, send them.", new DateTime(2026, 1, 1, 11, 12, 0, 0, DateTimeKind.Utc), true, "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903", "da3a7cb3-5d90-45d2-83d9-9f8a2d92a105" },
                    { "msg-006-219fa006", "Using Docker Compose?", new DateTime(2026, 1, 2, 8, 30, 0, 0, DateTimeKind.Utc), true, "e38db6c0-7b92-4f0f-b76a-d7b7f1aab107", "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106" },
                    { "msg-007-77cbe007", "Yes, makes networking easier.", new DateTime(2026, 1, 2, 8, 33, 0, 0, DateTimeKind.Utc), true, "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106", "e38db6c0-7b92-4f0f-b76a-d7b7f1aab107" },
                    { "msg-008-19aa2008", "Loved your last blog post.", new DateTime(2026, 1, 2, 12, 0, 0, 0, DateTimeKind.Utc), true, "c6fdb72c-65b1-42df-bd03-4a3ff37f6109", "17a7f919-62b3-4b1b-94bb-8cf80b8aa108" },
                    { "msg-009-b211c009", "Thanks a lot!", new DateTime(2026, 1, 2, 12, 2, 0, 0, DateTimeKind.Utc), true, "17a7f919-62b3-4b1b-94bb-8cf80b8aa108", "c6fdb72c-65b1-42df-bd03-4a3ff37f6109" },
                    { "msg-010-a88cc010", "How do you track analytics?", new DateTime(2026, 1, 3, 9, 30, 0, 0, DateTimeKind.Utc), false, "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111", "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110" },
                    { "msg-011-acde1011", "Mostly Firebase and custom events.", new DateTime(2026, 1, 3, 9, 32, 0, 0, DateTimeKind.Utc), false, "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110", "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111" },
                    { "msg-012-acde1012", "QA found a bug in checkout.", new DateTime(2026, 1, 3, 11, 10, 0, 0, DateTimeKind.Utc), true, "4b46a84d-21a3-44db-9d2f-68c2f51f3113", "2df3b7c4-29c2-41b2-b2cb-51c8f20d8112" },
                    { "msg-013-acde1013", "Thanks, I’ll fix it today.", new DateTime(2026, 1, 3, 11, 12, 0, 0, DateTimeKind.Utc), true, "2df3b7c4-29c2-41b2-b2cb-51c8f20d8112", "4b46a84d-21a3-44db-9d2f-68c2f51f3113" },
                    { "msg-014-acde1014", "Any cloud provider recommendations?", new DateTime(2026, 1, 4, 8, 0, 0, 0, DateTimeKind.Utc), true, "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116", "5d7e09fa-b71a-44c5-9e1f-9b4e4b09f114" },
                    { "msg-015-acde1015", "Azure is solid for .NET.", new DateTime(2026, 1, 4, 8, 2, 0, 0, DateTimeKind.Utc), true, "5d7e09fa-b71a-44c5-9e1f-9b4e4b09f114", "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116" },
                    { "msg-016-acde1016", "Meeting moved to tomorrow.", new DateTime(2026, 1, 4, 15, 20, 0, 0, DateTimeKind.Utc), true, "bbcfb1c7-d4a6-46fa-a9cc-5c9df8d07117", "82b1e839-f782-4c16-a1c2-2f8f1a2a5115" },
                    { "msg-017-acde1017", "Got it, thanks.", new DateTime(2026, 1, 4, 15, 22, 0, 0, DateTimeKind.Utc), true, "82b1e839-f782-4c16-a1c2-2f8f1a2a5115", "bbcfb1c7-d4a6-46fa-a9cc-5c9df8d07117" },
                    { "msg-018-acde1018", "Want to discuss the startup idea?", new DateTime(2026, 1, 5, 10, 0, 0, 0, DateTimeKind.Utc), false, "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01", "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118" },
                    { "msg-019-acde1019", "Yes, let’s do it later today.", new DateTime(2026, 1, 5, 10, 5, 0, 0, DateTimeKind.Utc), false, "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "msg-020-acde1020", "Can you help me with React hooks?", new DateTime(2026, 1, 6, 9, 0, 0, 0, DateTimeKind.Utc), true, "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902", "17a7f919-62b3-4b1b-94bb-8cf80b8aa108" },
                    { "msg-021-acde1021", "Sure, what part?", new DateTime(2026, 1, 6, 9, 1, 0, 0, DateTimeKind.Utc), true, "17a7f919-62b3-4b1b-94bb-8cf80b8aa108", "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902" },
                    { "msg-022-acde1022", "useEffect dependencies confuse me.", new DateTime(2026, 1, 6, 9, 3, 0, 0, DateTimeKind.Utc), true, "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902", "17a7f919-62b3-4b1b-94bb-8cf80b8aa108" },
                    { "msg-023-acde1023", "They control when the effect runs.", new DateTime(2026, 1, 6, 9, 5, 0, 0, DateTimeKind.Utc), true, "17a7f919-62b3-4b1b-94bb-8cf80b8aa108", "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902" },
                    { "msg-024-acde1024", "Ahh that helps a lot.", new DateTime(2026, 1, 6, 9, 6, 0, 0, DateTimeKind.Utc), true, "a6a7d7a9-43e5-4ad1-9c89-41287b4d3902", "17a7f919-62b3-4b1b-94bb-8cf80b8aa108" },
                    { "msg-025-acde1025", "Security scan passed.", new DateTime(2026, 1, 7, 10, 0, 0, 0, DateTimeKind.Utc), true, "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106", "c91e9189-281f-48c3-b8ad-1b20f4f10104" },
                    { "msg-026-acde1026", "Great news!", new DateTime(2026, 1, 7, 10, 1, 0, 0, DateTimeKind.Utc), true, "c91e9189-281f-48c3-b8ad-1b20f4f10104", "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106" },
                    { "msg-027-acde1027", "Want to test the beta build?", new DateTime(2026, 1, 8, 14, 0, 0, 0, DateTimeKind.Utc), true, "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111", "e38db6c0-7b92-4f0f-b76a-d7b7f1aab107" },
                    { "msg-028-acde1028", "Sure, send the link.", new DateTime(2026, 1, 8, 14, 1, 0, 0, DateTimeKind.Utc), true, "e38db6c0-7b92-4f0f-b76a-d7b7f1aab107", "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111" },
                    { "msg-029-acde1029", "Presentation slides ready.", new DateTime(2026, 1, 9, 9, 0, 0, 0, DateTimeKind.Utc), true, "82b1e839-f782-4c16-a1c2-2f8f1a2a5115", "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110" },
                    { "msg-030-acde1030", "Perfect, thanks.", new DateTime(2026, 1, 9, 9, 2, 0, 0, DateTimeKind.Utc), true, "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110", "82b1e839-f782-4c16-a1c2-2f8f1a2a5115" },
                    { "msg-031-acde1031", "Java service deployed.", new DateTime(2026, 1, 10, 11, 0, 0, 0, DateTimeKind.Utc), true, "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116", "4b46a84d-21a3-44db-9d2f-68c2f51f3113" },
                    { "msg-032-acde1032", "Monitoring looks good.", new DateTime(2026, 1, 10, 11, 5, 0, 0, DateTimeKind.Utc), true, "4b46a84d-21a3-44db-9d2f-68c2f51f3113", "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116" },
                    { "msg-033-acde1033", "Smart contract deployed.", new DateTime(2026, 1, 11, 13, 0, 0, 0, DateTimeKind.Utc), true, "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118", "5d7e09fa-b71a-44c5-9e1f-9b4e4b09f114" },
                    { "msg-034-acde1034", "Awesome work.", new DateTime(2026, 1, 11, 13, 2, 0, 0, DateTimeKind.Utc), true, "5d7e09fa-b71a-44c5-9e1f-9b4e4b09f114", "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118" },
                    { "msg-035-acde1035", "Interviews scheduled.", new DateTime(2026, 1, 12, 10, 0, 0, 0, DateTimeKind.Utc), true, "82b1e839-f782-4c16-a1c2-2f8f1a2a5115", "bbcfb1c7-d4a6-46fa-a9cc-5c9df8d07117" },
                    { "msg-036-acde1036", "Thanks for the update.", new DateTime(2026, 1, 12, 10, 1, 0, 0, DateTimeKind.Utc), true, "bbcfb1c7-d4a6-46fa-a9cc-5c9df8d07117", "82b1e839-f782-4c16-a1c2-2f8f1a2a5115" },
                    { "msg-037-acde1037", "Want to co-author an article?", new DateTime(2026, 1, 13, 15, 0, 0, 0, DateTimeKind.Utc), false, "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01", "c6fdb72c-65b1-42df-bd03-4a3ff37f6109" },
                    { "msg-038-acde1038", "Yes, sounds great.", new DateTime(2026, 1, 13, 15, 5, 0, 0, DateTimeKind.Utc), false, "c6fdb72c-65b1-42df-bd03-4a3ff37f6109", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "msg-039-acde1039", "Your design tips helped!", new DateTime(2026, 1, 14, 9, 0, 0, 0, DateTimeKind.Utc), true, "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903", "17a7f919-62b3-4b1b-94bb-8cf80b8aa108" },
                    { "msg-040-acde1040", "Happy to hear that 😊", new DateTime(2026, 1, 14, 9, 2, 0, 0, DateTimeKind.Utc), true, "17a7f919-62b3-4b1b-94bb-8cf80b8aa108", "f52b5f4d-8c4e-4b3a-91fd-3c79cdb1c903" },
                    { "msg-041-acde1041", "Artwork campaign looks great.", new DateTime(2026, 1, 15, 11, 0, 0, 0, DateTimeKind.Utc), true, "da3a7cb3-5d90-45d2-83d9-9f8a2d92a105", "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110" },
                    { "msg-042-acde1042", "Thanks! Glad you liked it.", new DateTime(2026, 1, 15, 11, 2, 0, 0, DateTimeKind.Utc), true, "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110", "da3a7cb3-5d90-45d2-83d9-9f8a2d92a105" },
                    { "msg-043-acde1043", "Mobile build ready for testing.", new DateTime(2026, 1, 16, 16, 0, 0, 0, DateTimeKind.Utc), true, "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01", "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111" },
                    { "msg-044-acde1044", "I’ll test it tonight.", new DateTime(2026, 1, 16, 16, 5, 0, 0, DateTimeKind.Utc), true, "bf8ad623-ff4a-44b3-b2b2-109cbe8a2111", "1c7a44e8-6c82-4a51-8e77-15bdfd5b8a01" },
                    { "msg-045-acde1045", "Logs look clean.", new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Utc), true, "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106", "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116" },
                    { "msg-046-acde1046", "Great 👍", new DateTime(2026, 1, 17, 10, 1, 0, 0, DateTimeKind.Utc), true, "aa9aef99-4d6f-4b7a-b3a7-0b2b8d731116", "b9f4c2d1-4d94-4ff6-87aa-0ccf933bf106" },
                    { "msg-047-acde1047", "Roadmap approved.", new DateTime(2026, 1, 18, 9, 0, 0, 0, DateTimeKind.Utc), true, "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118", "82b1e839-f782-4c16-a1c2-2f8f1a2a5115" },
                    { "msg-048-acde1048", "Perfect, let’s move forward.", new DateTime(2026, 1, 18, 9, 2, 0, 0, DateTimeKind.Utc), true, "82b1e839-f782-4c16-a1c2-2f8f1a2a5115", "d14dc8ad-3b9f-4f1a-b50a-82d0c3e71118" },
                    { "msg-049-acde1049", "Publishing tomorrow.", new DateTime(2026, 1, 19, 14, 0, 0, 0, DateTimeKind.Utc), false, "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110", "c6fdb72c-65b1-42df-bd03-4a3ff37f6109" },
                    { "msg-050-acde1050", "Great timing.", new DateTime(2026, 1, 19, 14, 1, 0, 0, DateTimeKind.Utc), false, "c6fdb72c-65b1-42df-bd03-4a3ff37f6109", "88dfb5b0-12c2-42d6-bb0d-9eaa9e9a3110" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-001-4a8f1b01");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-002-92bc1102");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-003-ff21ac03");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-004-bac91204");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-005-acde3305");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-006-219fa006");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-007-77cbe007");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-008-19aa2008");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-009-b211c009");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-010-a88cc010");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-011-acde1011");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-012-acde1012");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-013-acde1013");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-014-acde1014");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-015-acde1015");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-016-acde1016");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-017-acde1017");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-018-acde1018");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-019-acde1019");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-020-acde1020");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-021-acde1021");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-022-acde1022");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-023-acde1023");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-024-acde1024");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-025-acde1025");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-026-acde1026");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-027-acde1027");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-028-acde1028");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-029-acde1029");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-030-acde1030");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-031-acde1031");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-032-acde1032");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-033-acde1033");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-034-acde1034");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-035-acde1035");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-036-acde1036");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-037-acde1037");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-038-acde1038");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-039-acde1039");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-040-acde1040");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-041-acde1041");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-042-acde1042");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-043-acde1043");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-044-acde1044");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-045-acde1045");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-046-acde1046");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-047-acde1047");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-048-acde1048");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-049-acde1049");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: "msg-050-acde1050");
        }
    }
}
