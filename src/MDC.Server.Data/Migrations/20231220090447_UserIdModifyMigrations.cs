using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MDC.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserIdModifyMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guid",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "30d10cb7-0bba-4ab1-9cbb-628095904929", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6553), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6551), "john.doe@example.com", false, "John", "Doe", false, null, null, null, null, "123456789", false, "3998e7b9-5810-4fe3-8537-fdf6cc251f6e", false, null, null },
                    { "2", 0, "09b1b4b6-f05c-411b-9478-ae6fb5e56e2e", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6562), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6561), "jane.smith@example.com", false, "Jane", "Smith", false, null, null, null, null, "987654321", false, "fc9b09b5-1c55-45eb-a981-5fc16eb98741", false, null, null },
                    { "3", 0, "64acbe06-7676-486f-80a2-9bd4601d7385", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6589), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6589), "michael.johnson@example.com", false, "Michael", "Johnson", false, null, null, null, null, "555555555", false, "7280ad3a-d542-41be-a775-ca3cc0ad0f5c", false, null, null },
                    { "4", 0, "32d4d5d3-650d-46ac-ac8b-568ca308cbb8", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6596), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6595), "emily.anderson@example.com", false, "Emily", "Anderson", false, null, null, null, null, "333333333", false, "36389d01-1b8b-4ac8-8e59-783ee29c5716", false, null, null },
                    { "5", 0, "77f700dd-84d3-4b9a-ae7e-894ae71a2221", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6607), new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6606), "william.taylor@example.com", false, "William", "Taylor", false, null, null, null, null, "777777777", false, "f560ae3b-99e6-486f-a285-50b00e791117", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "Id", "Banner", "Bio", "CreatedAt", "Description", "Logo", "ParentId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, "tech_banner.jpg", "Explore the latest in tech trends.", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6867), "A community for technology enthusiasts.", "tech_logo.png", null, "Tech Enthusiasts", null },
                    { 2L, "outdoor_banner.jpg", "Connect with nature and fellow adventurers.", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6869), "For those who love outdoor activities.", "outdoor_logo.png", null, "Outdoor Adventures", null },
                    { 3L, "books_banner.jpg", "Discuss your favorite books and discover new ones.", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6871), "A community for bookworms and literature enthusiasts.", "books_logo.png", null, "Book Lovers Club", null },
                    { 4L, "fitness_banner.jpg", "Share workout tips and stay motivated.", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6927), "For fitness enthusiasts and health-conscious individuals.", "fitness_logo.png", null, "Fitness Fanatics", null },
                    { 5L, "art_banner.jpg", "Connect with fellow artists and creators.", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6929), "Explore and share your artistic side.", "art_logo.png", null, "Art and Creativity", null }
                });

            migrationBuilder.InsertData(
                table: "CommunityRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { (short)1, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6969), "Community administrator role.", "Administrator", null },
                    { (short)2, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6971), "Standard community member role.", "Member", null },
                    { (short)3, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6972), "Community moderator role.", "Moderator", null },
                    { (short)4, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6974), "Guest role for limited access.", "Guest", null },
                    { (short)5, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6975), "Community content editor role.", "Editor", null }
                });

            migrationBuilder.InsertData(
                table: "EventRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { (short)1, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6244), "Responsible for planning and managing the event.", "Organizer", null },
                    { (short)2, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6247), "Presenting talks or sessions during the event.", "Speaker", null },
                    { (short)3, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6248), "Attending the event without a specific role.", "Participant", null },
                    { (short)4, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6250), "Assisting with various tasks during the event.", "Volunteer", null },
                    { (short)5, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6251), "Supporting the event financially or with resources.", "Sponsor", null }
                });

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

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { (short)1, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(7018), null, "English", null },
                    { (short)2, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(7020), null, "Uzbek", null },
                    { (short)3, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(7022), null, "French", null },
                    { (short)4, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(7023), null, "German", null },
                    { (short)5, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(7025), null, "Russian", null }
                });

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

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 20, 9, 4, 46, 649, DateTimeKind.Utc).AddTicks(8278), "Northern part of the country", "North Region", null },
                    { 2, new DateTime(2023, 12, 20, 9, 4, 46, 649, DateTimeKind.Utc).AddTicks(8282), "Southern part of the country", "South Region", null },
                    { 3, new DateTime(2023, 12, 20, 9, 4, 46, 649, DateTimeKind.Utc).AddTicks(8283), "Eastern part of the country", "East Region", null },
                    { 4, new DateTime(2023, 12, 20, 9, 4, 46, 649, DateTimeKind.Utc).AddTicks(8284), "Western part of the country", "West Region", null },
                    { 5, new DateTime(2023, 12, 20, 9, 4, 46, 649, DateTimeKind.Utc).AddTicks(8285), "Central part of the country", "Central Region", null }
                });

            migrationBuilder.InsertData(
                table: "EventSessions",
                columns: new[] { "Id", "CreatedAt", "Description", "EndAt", "EventId", "Name", "SpeakerId", "StartAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6388), "An inspiring keynote to kick off the event.", new DateTime(2024, 1, 21, 10, 4, 46, 648, DateTimeKind.Utc).AddTicks(6386), 1L, "Keynote Address", "1", new DateTime(2024, 1, 21, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6373), null },
                    { 2L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6392), "A panel discussion on the future of technology.", new DateTime(2024, 2, 22, 10, 4, 46, 648, DateTimeKind.Utc).AddTicks(6390), 2L, "Panel Discussion", "2", new DateTime(2024, 2, 22, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6389), null },
                    { 3L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6396), "A discussion on the latest book club selection.", new DateTime(2024, 3, 23, 10, 4, 46, 648, DateTimeKind.Utc).AddTicks(6394), 3L, "Book Club Discussion", "3", new DateTime(2024, 3, 23, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6393), null },
                    { 4L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6399), "Hands-on workshop for aspiring artists.", new DateTime(2024, 4, 24, 11, 4, 46, 648, DateTimeKind.Utc).AddTicks(6398), 4L, "Art Workshop", "4", new DateTime(2024, 4, 24, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6397), null },
                    { 5L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6403), "Collaborative session to plan community initiatives.", new DateTime(2024, 5, 25, 10, 4, 46, 648, DateTimeKind.Utc).AddTicks(6402), 5L, "Community Planning Session", "5", new DateTime(2024, 5, 25, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6401), null }
                });

            migrationBuilder.InsertData(
                table: "SpeakerDetails",
                columns: new[] { "Id", "Company", "CreatedAt", "ExperienceYear", "Position", "SpeechImage", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, "Tech Innovators", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6809), (short)5, "Senior Software Engineer", "john_doe_speech_image.jpg", null, "1" },
                    { 2L, "Health & Wellness Solutions", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6812), (short)8, "Lead Nutritionist", "jane_smith_speech_image.jpg", null, "2" },
                    { 3L, "Artistic Creations", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6814), (short)10, "Chief Creative Officer", "michael_johnson_speech_image.jpg", null, "3" },
                    { 4L, "GreenTech Solutions", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6815), (short)7, "Environmental Scientist", "emily_anderson_speech_image.jpg", null, "4" },
                    { 5L, "Innovative Designs", new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6817), (short)12, "Lead Architect", "william_taylor_speech_image.jpg", null, "5" }
                });

            migrationBuilder.InsertData(
                table: "UserCommunities",
                columns: new[] { "Id", "CommunityId", "CreatedAt", "RoleId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6713), (short)1, null, "1" },
                    { 2L, 2L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6715), (short)2, null, "2" },
                    { 3L, 3L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6716), (short)1, null, "3" },
                    { 4L, 4L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6718), (short)3, null, "4" },
                    { 5L, 5L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6719), (short)2, null, "5" }
                });

            migrationBuilder.InsertData(
                table: "UserDatails",
                columns: new[] { "Id", "CreatedAt", "Image", "Resume", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john-doe-image-url", "John Doe's resume details", null, "1" },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane-smith-image-url", "Jane Smith's resume details", null, "2" },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael-johnson-image-url", "Michael Johnson's resume details", null, "3" },
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily-anderson-image-url", "Emily Anderson's resume details", null, "4" },
                    { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "william-taylor-image-url", "William Taylor's resume details", null, "5" }
                });

            migrationBuilder.InsertData(
                table: "UserEvents",
                columns: new[] { "Id", "CreatedAt", "EventId", "RoleId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6761), 1L, (short)1, null, "1" },
                    { 2L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6763), 2L, (short)2, null, "2" },
                    { 3L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6764), 3L, (short)1, null, "3" },
                    { 4L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6766), 4L, (short)3, null, "4" },
                    { 5L, new DateTime(2023, 12, 20, 9, 4, 46, 648, DateTimeKind.Utc).AddTicks(6767), 5L, (short)2, null, "5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DeleteData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)4);

            migrationBuilder.DeleteData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)5);

            migrationBuilder.DeleteData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)4);

            migrationBuilder.DeleteData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)5);

            migrationBuilder.DeleteData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "EventSessions",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)4);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: (short)5);

            migrationBuilder.DeleteData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "SpeakerDetails",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "UserCommunities",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "UserDatails",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserDatails",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "UserDatails",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "UserDatails",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "UserDatails",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "UserEvents",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "CommunityRoles",
                keyColumn: "Id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "EventRoles",
                keyColumn: "Id",
                keyValue: (short)3);

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "AspNetUsers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9054), new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9053), new DateTime(2024, 1, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9057), new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9056), new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9060), new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9059), new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9062), new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9062), new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9066), new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9064), new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 20, 7, 9, 10, 343, DateTimeKind.Utc).AddTicks(8881));
        }
    }
}
