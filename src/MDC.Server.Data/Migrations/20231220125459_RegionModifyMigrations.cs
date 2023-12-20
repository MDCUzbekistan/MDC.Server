using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MDC.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class RegionModifyMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Communities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Bio = table.Column<string>(type: "text", nullable: true),
                    Banner = table.Column<string>(type: "text", nullable: true),
                    Logo = table.Column<string>(type: "text", nullable: true),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Communities_Communities_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Communities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CommunityRoles",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventRoles",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Longitude = table.Column<long>(type: "bigint", nullable: false),
                    Latitude = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Country = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpeakerDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    ExperienceYear = table.Column<short>(type: "smallint", nullable: false),
                    Company = table.Column<string>(type: "text", nullable: true),
                    Position = table.Column<string>(type: "text", nullable: true),
                    SpeechImage = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeakerDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpeakerDetails_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserDatails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Resume = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDatails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDatails_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserCommunities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    CommunityId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<short>(type: "smallint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCommunities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCommunities_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserCommunities_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCommunities_CommunityRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "CommunityRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLanguages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    LanguageId = table.Column<short>(type: "smallint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLanguages_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Format = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    LiveStreamUrl = table.Column<string>(type: "text", nullable: true),
                    StartAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EventAssets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EventId = table.Column<long>(type: "bigint", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventAssets_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventSessions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EventId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    StartAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    SpeakerId = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventSessions_AspNetUsers_SpeakerId",
                        column: x => x.SpeakerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EventSessions_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEvents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    EventId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<short>(type: "smallint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEvents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEvents_EventRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "EventRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "21ac09da-439c-471d-b675-c85aa14e7c9c", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2927), new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2926), "john.doe@example.com", false, "John", "Doe", false, null, null, null, null, "123456789", false, "b42b5e47-3640-41e0-a265-708fa38e2697", false, null, null },
                    { "2", 0, "1cef9780-3448-4d14-b47e-082c69249088", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2932), new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2932), "jane.smith@example.com", false, "Jane", "Smith", false, null, null, null, null, "987654321", false, "203e1d4c-d0e2-4e1e-bbf8-485aea03b77d", false, null, null },
                    { "3", 0, "07ac8b55-a5b9-4d51-a0e0-4f88b55b8658", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2938), new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2938), "michael.johnson@example.com", false, "Michael", "Johnson", false, null, null, null, null, "555555555", false, "5f56940c-f870-411a-9af6-a4bad3c2847f", false, null, null },
                    { "4", 0, "eaca5e8b-5694-4ae0-834c-de9054dc496d", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2942), new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2942), "emily.anderson@example.com", false, "Emily", "Anderson", false, null, null, null, null, "333333333", false, "1a9c81fd-8713-4a36-b9ab-90d3c9e0a183", false, null, null },
                    { "5", 0, "35886f4e-72a9-482d-97b1-ecf1c47d3a61", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2946), new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2946), "william.taylor@example.com", false, "William", "Taylor", false, null, null, null, null, "777777777", false, "b7ffacf8-84d8-42a0-a87a-877af4673f79", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "Id", "Banner", "Bio", "CreatedAt", "Description", "Logo", "ParentId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, "tech_banner.jpg", "Explore the latest in tech trends.", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3053), "A community for technology enthusiasts.", "tech_logo.png", null, "Tech Enthusiasts", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "outdoor_banner.jpg", "Connect with nature and fellow adventurers.", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3055), "For those who love outdoor activities.", "outdoor_logo.png", null, "Outdoor Adventures", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, "books_banner.jpg", "Discuss your favorite books and discover new ones.", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3057), "A community for bookworms and literature enthusiasts.", "books_logo.png", null, "Book Lovers Club", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, "fitness_banner.jpg", "Share workout tips and stay motivated.", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3058), "For fitness enthusiasts and health-conscious individuals.", "fitness_logo.png", null, "Fitness Fanatics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, "art_banner.jpg", "Connect with fellow artists and creators.", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3059), "Explore and share your artistic side.", "art_logo.png", null, "Art and Creativity", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CommunityRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { (short)1, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3146), "Community administrator role.", "Administrator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (short)2, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3147), "Standard community member role.", "Member", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (short)3, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3148), "Community moderator role.", "Moderator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (short)4, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3149), "Guest role for limited access.", "Guest", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (short)5, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3150), "Community content editor role.", "Editor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "EventRoles",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { (short)1, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2688), "Responsible for planning and managing the event.", "Organizer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (short)2, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2689), "Presenting talks or sessions during the event.", "Speaker", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (short)3, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2690), "Attending the event without a specific role.", "Participant", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (short)4, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2690), "Assisting with various tasks during the event.", "Volunteer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (short)5, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2691), "Supporting the event financially or with resources.", "Sponsor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { (short)1, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2553), null, "English", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (short)2, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2554), null, "Uzbek", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (short)3, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2555), null, "French", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (short)4, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2556), null, "German", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { (short)5, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2577), null, "Russian", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "CreatedAt", "Latitude", "Longitude", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, "123 Main St", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2606), 789012L, 123456L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "456 Oak Ave", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2607), 210987L, 654321L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, "789 Elm St", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2608), 333444L, 111222L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, "987 Pine Ave", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2609), 777888L, 555666L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, "654 Birch Ln", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2611), 123789L, 999000L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "City", "Country", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "City1", "Country1", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2408), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "City2", "Country2", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2410), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "City3", "Country3", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2412), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "City4", "Country4", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2413), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "City5", "Country5", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2413), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CreatedAt", "Description", "EndAt", "Format", "LiveStreamUrl", "LocationId", "StartAt", "Status", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2656), "Explore the latest in technology and innovation.", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2655), 0, "https://livestream.example.com/tech-conference", 1L, new DateTime(2024, 1, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2645), 0, "Tech Conference 2023", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2660), "Join us for a fitness extravaganza.", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2659), 3, null, 2L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2659), 0, "Fitness Expo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2662), "Discuss your favorite books with fellow bookworms.", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2662), 1, null, 3L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2661), 0, "Book Club Meeting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2664), "Discover and appreciate local artistic talent.", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2664), 0, null, 4L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2663), 0, "Art Exhibition", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2667), "Join hands for a cleaner and greener community.", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2666), 0, null, 5L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2666), 4, "Community Cleanup", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SpeakerDetails",
                columns: new[] { "Id", "Company", "CreatedAt", "ExperienceYear", "Position", "SpeechImage", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, "Tech Innovators", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3021), (short)5, "Senior Software Engineer", "john_doe_speech_image.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 2L, "Health & Wellness Solutions", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3023), (short)8, "Lead Nutritionist", "jane_smith_speech_image.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2" },
                    { 3L, "Artistic Creations", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3024), (short)10, "Chief Creative Officer", "michael_johnson_speech_image.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3" },
                    { 4L, "GreenTech Solutions", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3025), (short)7, "Environmental Scientist", "emily_anderson_speech_image.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4" },
                    { 5L, "Innovative Designs", new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3027), (short)12, "Lead Architect", "william_taylor_speech_image.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5" }
                });

            migrationBuilder.InsertData(
                table: "UserCommunities",
                columns: new[] { "Id", "CommunityId", "CreatedAt", "RoleId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3232), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 2L, 2L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3233), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2" },
                    { 3L, 3L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3234), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3" },
                    { 4L, 4L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3236), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4" },
                    { 5L, 5L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3237), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5" }
                });

            migrationBuilder.InsertData(
                table: "UserDatails",
                columns: new[] { "Id", "CreatedAt", "Image", "Resume", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john-doe-image-url", "John Doe's resume details", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane-smith-image-url", "Jane Smith's resume details", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2" },
                    { 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael-johnson-image-url", "Michael Johnson's resume details", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3" },
                    { 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily-anderson-image-url", "Emily Anderson's resume details", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4" },
                    { 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "william-taylor-image-url", "William Taylor's resume details", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5" }
                });

            migrationBuilder.InsertData(
                table: "UserLanguages",
                columns: new[] { "Id", "CreatedAt", "LanguageId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3207), (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 2L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3208), (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2" },
                    { 3L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3209), (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3" },
                    { 4L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3209), (short)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4" },
                    { 5L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3210), (short)5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5" }
                });

            migrationBuilder.InsertData(
                table: "EventAssets",
                columns: new[] { "Id", "CreatedAt", "EventId", "Image", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2717), 1L, "event-asset-image-1.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2718), 2L, "event-asset-image-2.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2719), 3L, "event-asset-image-3.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2720), 4L, "event-asset-image-4.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2721), 5L, "event-asset-image-5.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "EventSessions",
                columns: new[] { "Id", "CreatedAt", "Description", "EndAt", "EventId", "Name", "SpeakerId", "StartAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2750), "An inspiring keynote to kick off the event.", new DateTime(2024, 1, 21, 13, 54, 58, 563, DateTimeKind.Utc).AddTicks(2748), 1L, "Keynote Address", "1", new DateTime(2024, 1, 21, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2743), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2753), "A panel discussion on the future of technology.", new DateTime(2024, 2, 22, 13, 54, 58, 563, DateTimeKind.Utc).AddTicks(2752), 2L, "Panel Discussion", "2", new DateTime(2024, 2, 22, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2751), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2755), "A discussion on the latest book club selection.", new DateTime(2024, 3, 23, 13, 54, 58, 563, DateTimeKind.Utc).AddTicks(2754), 3L, "Book Club Discussion", "3", new DateTime(2024, 3, 23, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2753), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2758), "Hands-on workshop for aspiring artists.", new DateTime(2024, 4, 24, 14, 54, 58, 563, DateTimeKind.Utc).AddTicks(2757), 4L, "Art Workshop", "4", new DateTime(2024, 4, 24, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2756), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2761), "Collaborative session to plan community initiatives.", new DateTime(2024, 5, 25, 13, 54, 58, 563, DateTimeKind.Utc).AddTicks(2760), 5L, "Community Planning Session", "5", new DateTime(2024, 5, 25, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(2759), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "UserEvents",
                columns: new[] { "Id", "CreatedAt", "EventId", "RoleId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3180), 1L, (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1" },
                    { 2L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3181), 2L, (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2" },
                    { 3L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3182), 3L, (short)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3" },
                    { 4L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3183), 4L, (short)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4" },
                    { 5L, new DateTime(2023, 12, 20, 12, 54, 58, 563, DateTimeKind.Utc).AddTicks(3184), 5L, (short)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Communities_ParentId",
                table: "Communities",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAssets_EventId",
                table: "EventAssets",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSessions_EventId",
                table: "EventSessions",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSessions_SpeakerId",
                table: "EventSessions",
                column: "SpeakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_LocationId",
                table: "Events",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeakerDetails_UserId",
                table: "SpeakerDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCommunities_CommunityId",
                table: "UserCommunities",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCommunities_RoleId",
                table: "UserCommunities",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCommunities_UserId",
                table: "UserCommunities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDatails_UserId",
                table: "UserDatails",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_EventId",
                table: "UserEvents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_RoleId",
                table: "UserEvents",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_UserId",
                table: "UserEvents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguages_LanguageId",
                table: "UserLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguages_UserId",
                table: "UserLanguages",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EventAssets");

            migrationBuilder.DropTable(
                name: "EventSessions");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "SpeakerDetails");

            migrationBuilder.DropTable(
                name: "UserCommunities");

            migrationBuilder.DropTable(
                name: "UserDatails");

            migrationBuilder.DropTable(
                name: "UserEvents");

            migrationBuilder.DropTable(
                name: "UserLanguages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Communities");

            migrationBuilder.DropTable(
                name: "CommunityRoles");

            migrationBuilder.DropTable(
                name: "EventRoles");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
