using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MDC.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserLanguagesMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "fcb6a550-1a3c-4c22-91a9-7d09a969f3e5", new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(4626), new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(4620), "26cd9289-5dad-4c2b-bb90-71a41972024d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "7e20846b-276d-4d42-80e2-b4c207fefa6a", new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(4650), new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(4649), "a280f93b-c0c7-4827-87b7-4df2f51c0a65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "7083cd54-a23b-4be4-b16d-221d0f2c24d6", new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(4846), new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(4845), "6ab382c4-bd3e-4641-81f1-d27ae4e34668" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "0ff7d494-fe3f-45ea-906c-0fc6b175d20f", new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(4858), new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(4857), "b2f9234a-3430-4697-ac51-eb107012f4a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "6b79a20d-6c49-4f99-8812-13435d0aac48", new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(4869), new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(4868), "4bde7f9d-df57-4ced-b1ff-314d2840fa48" });

            migrationBuilder.UpdateData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)5,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.InsertData(
                table: "EventAssets",
                columns: new[] { "Id", "CreatedAt", "EventId", "Image", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5213), 1L, "event-asset-image-1.jpg", null },
                    { 2L, new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5215), 2L, "event-asset-image-2.jpg", null },
                    { 3L, new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5216), 3L, "event-asset-image-3.jpg", null },
                    { 4L, new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5218), 4L, "event-asset-image-4.jpg", null },
                    { 5L, new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5219), 5L, "event-asset-image-5.jpg", null }
                });

            migrationBuilder.UpdateData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)5,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5279), new DateTime(2024, 1, 21, 12, 9, 46, 49, DateTimeKind.Utc).AddTicks(5277), new DateTime(2024, 1, 21, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5284), new DateTime(2024, 2, 22, 12, 9, 46, 49, DateTimeKind.Utc).AddTicks(5283), new DateTime(2024, 2, 22, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5288), new DateTime(2024, 3, 23, 12, 9, 46, 49, DateTimeKind.Utc).AddTicks(5287), new DateTime(2024, 3, 23, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5292), new DateTime(2024, 4, 24, 13, 9, 46, 49, DateTimeKind.Utc).AddTicks(5291), new DateTime(2024, 4, 24, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5296), new DateTime(2024, 5, 25, 12, 9, 46, 49, DateTimeKind.Utc).AddTicks(5294), new DateTime(2024, 5, 25, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5113), new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5112), new DateTime(2024, 1, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5116), new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5116), new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5119), new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5119), new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5122), new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5122), new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5125), new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5124), new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)5,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 49, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.InsertData(
                table: "UserLanguages",
                columns: new[] { "Id", "CreatedAt", "LanguageId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5505), (short)1, null, "1" },
                    { 2L, new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5507), (short)2, null, "2" },
                    { 3L, new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5509), (short)3, null, "3" },
                    { 4L, new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5511), (short)4, null, "4" },
                    { 5L, new DateTime(2023, 12, 20, 11, 9, 46, 50, DateTimeKind.Utc).AddTicks(5513), (short)5, null, "5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventAssets",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "EventAssets",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "EventAssets",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "EventAssets",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "EventAssets",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "UserLanguages",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserLanguages",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "UserLanguages",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "UserLanguages",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "UserLanguages",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "30d10cb7-0bba-4ab1-9cbb-628095904929", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6553), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6551), "3998e7b9-5810-4fe3-8537-fdf6cc251f6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "09b1b4b6-f05c-411b-9478-ae6fb5e56e2e", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6562), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6561), "fc9b09b5-1c55-45eb-a981-5fc16eb98741" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "64acbe06-7676-486f-80a2-9bd4601d7385", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6589), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6589), "7280ad3a-d542-41be-a775-ca3cc0ad0f5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "32d4d5d3-650d-46ac-ac8b-568ca308cbb8", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6596), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6595), "36389d01-1b8b-4ac8-8e59-783ee29c5716" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "77f700dd-84d3-4b9a-ae7e-894ae71a2221", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6607), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6606), "f560ae3b-99e6-486f-a285-50b00e791117" });

            migrationBuilder.UpdateData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)5,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)5,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6388), new DateTime(2024, 1, 21, 10, 4, 46, 648, DateTimeKind.Utc).AddTicks(6386), new DateTime(2024, 1, 21, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6392), new DateTime(2024, 2, 22, 10, 4, 46, 648, DateTimeKind.Utc).AddTicks(6390), new DateTime(2024, 2, 22, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6396), new DateTime(2024, 3, 23, 10, 4, 46, 648, DateTimeKind.Utc).AddTicks(6394), new DateTime(2024, 3, 23, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6399), new DateTime(2024, 4, 24, 11, 4, 46, 648, DateTimeKind.Utc).AddTicks(6398), new DateTime(2024, 4, 24, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6403), new DateTime(2024, 5, 25, 10, 4, 46, 648, DateTimeKind.Utc).AddTicks(6402), new DateTime(2024, 5, 25, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6183), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6182), new DateTime(2024, 1, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6188), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6187), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6191), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6190), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6195), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6194), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6198), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6197), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)5,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 649, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 649, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 649, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 649, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 649, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6767));
        }
    }
}
