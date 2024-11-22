using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorAppointment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Specialization = table.Column<int>(type: "int", nullable: false),
                    YearsOfExperience = table.Column<int>(type: "int", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "Patient", "PATIENT" },
                    { 3, null, "Doctor", "DOCTOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarUrl", "City", "ConcurrencyStamp", "Country", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "Admin Address", null, null, "94007c83-3024-4d4a-8a77-b35f71fb4417", null, null, "admin@gmail.com", true, "Admin", null, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEORc7bGC+deVrsYiA1NszXLyzBlDv1KeupCuEMern6cmI7E1G3ZN/SHPoZu5zFa5Ng==", "123456789", false, "5bb30bd9-b786-4313-9a47-bfab9f334493", null, false, "admin" },
                    { 2, 0, "237 Rau Valley", null, null, "05c9eb30-22b9-4207-9755-64f31c4449a8", null, null, "Nelda.Beatty21@hotmail.com", true, "Tess Hagenes", null, false, null, "NELDA.BEATTY21@HOTMAIL.COM", "NELDA.BEATTY21@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBeE6n2GABc2uTpdrBrQ7IGddZ5yFkHS2Rk71UpSLP47AfXpz2wBuVIDQA/qZCp9oA==", "386.292.5786", false, "99bb14d0-1ff6-4325-8097-ee33d8dd6aff", null, false, "Nelda.Beatty21@hotmail.com" },
                    { 3, 0, "934 Murl Cape", null, null, "06677116-b98b-497f-bd46-ccaa32ec42d4", null, null, "Wilfrid12@hotmail.com", true, "Bertha Funk", null, false, null, "WILFRID12@HOTMAIL.COM", "WILFRID12@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEv0qiLpkBOEtR82TfRoa4BXLVsbYsWXo1Zf5ctB9dE/UCgPPTi7EiMPSXnQuOyh7Q==", "1-693-489-3139 x9981", false, "394f41f6-97eb-4798-96cb-a75d64d5dc87", null, false, "Wilfrid12@hotmail.com" },
                    { 4, 0, "3154 Gusikowski Shoals", null, null, "0ab179a2-b9b9-4a65-af31-16a7315859f0", null, null, "Tatyana.Beatty75@yahoo.com", true, "Nellie Ruecker", null, false, null, "TATYANA.BEATTY75@YAHOO.COM", "TATYANA.BEATTY75@YAHOO.COM", "AQAAAAIAAYagAAAAEKOvsW6jYy4LBJkxNtJTel0x6UId7+uIS+8Xl/g4hRVztjFbO2/eug7jxvFrQQdD9g==", "1-805-915-5337", false, "7bd866b3-40ca-4a75-8dc8-d1239f198485", null, false, "Tatyana.Beatty75@yahoo.com" },
                    { 5, 0, "12957 Raoul Gateway", null, null, "23c7edf8-2993-4f51-8739-5e7a594c6a9e", null, null, "Kelton19@hotmail.com", true, "Rosalinda Hayes", null, false, null, "KELTON19@HOTMAIL.COM", "KELTON19@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKyB4GcfkthZ/JqVyLN9oQT2K54owCTsTunzWQEBktLQm6LT8vHpkmuXkOsTR/M2zw==", "(372) 249-1632 x741", false, "ce6fd451-61a9-47a5-9d58-93fb3e9edf41", null, false, "Kelton19@hotmail.com" },
                    { 6, 0, "0391 Wuckert Drive", null, null, "f55de45d-506d-4247-8dce-ee2ee1bb3cc8", null, null, "Bonita_Maggio@yahoo.com", true, "Vernie Gleason", null, false, null, "BONITA_MAGGIO@YAHOO.COM", "BONITA_MAGGIO@YAHOO.COM", "AQAAAAIAAYagAAAAEGFwK9Q7VmlsudWEixK2VOwW0rqFYiwZCD6y4lQAaTzGHNyuy7PpR4mDxCFVb+Nu7Q==", "(550) 433-6983", false, "5717103d-223f-493a-bfc9-e42f7c71dbe5", null, false, "Bonita_Maggio@yahoo.com" },
                    { 7, 0, "48260 Jackeline Port", null, null, "e6276069-237d-4f38-a926-f5d058b72d51", null, null, "Frank_Langosh@gmail.com", true, "Marianne Denesik", null, false, null, "FRANK_LANGOSH@GMAIL.COM", "FRANK_LANGOSH@GMAIL.COM", "AQAAAAIAAYagAAAAEJR0GXwv/dCjtDSIVMb9OCYv0etxfGvAChyQik90szkSsFr2TsSutT0/NLqzcSdIlw==", "265-729-1434 x8989", false, "8b99890f-b51e-4fa7-a4d0-92ad21c9b795", null, false, "Frank_Langosh@gmail.com" },
                    { 8, 0, "2307 Karianne Stravenue", null, null, "18b39181-fbd0-4fa9-8cd5-d470ecb91ea0", null, null, "Frederic.Keeling49@yahoo.com", true, "Myrtle Littel", null, false, null, "FREDERIC.KEELING49@YAHOO.COM", "FREDERIC.KEELING49@YAHOO.COM", "AQAAAAIAAYagAAAAEBcb+175HvjmeZWNi6wy/vp0QUY49GsfRsEPNBxkQBB/pza4UEdFL6q5O+LOCa8tqg==", "881.728.2385 x564", false, "7fbb0492-60fb-4d3e-9359-8fe7a7331a43", null, false, "Frederic.Keeling49@yahoo.com" },
                    { 9, 0, "451 Smitham Drive", null, null, "1a94c557-bb10-4421-a7bf-593235b90609", null, null, "Miguel.Stark24@yahoo.com", true, "Emil Hegmann", null, false, null, "MIGUEL.STARK24@YAHOO.COM", "MIGUEL.STARK24@YAHOO.COM", "AQAAAAIAAYagAAAAEPW84hwRmQCFg/uHURXJfE9ShATbPwrnuKet0N0jQ7xI/T4SUtd6PtVIdxg5TgMzPw==", "798-424-2955 x399", false, "f47a416a-196c-43ab-b808-8ddb6eabdacf", null, false, "Miguel.Stark24@yahoo.com" },
                    { 10, 0, "4840 Leuschke Plains", null, null, "008be66e-ba61-4e7f-991e-3f1f2391326a", null, null, "Darrell.Lakin@yahoo.com", true, "Alyson Larson", null, false, null, "DARRELL.LAKIN@YAHOO.COM", "DARRELL.LAKIN@YAHOO.COM", "AQAAAAIAAYagAAAAEJUrhL29ueW7ILqY6hFy0cbzTydCSbq1q2Jr/RWguB4ZyhBHun6/IBbqap7z8aRYhg==", "(267) 887-1121", false, "92d9d3ac-d912-44a0-ab21-d98c87a7f235", null, false, "Darrell.Lakin@yahoo.com" },
                    { 11, 0, "471 Santino Turnpike", null, null, "c06ade12-cec7-46b6-ae35-442aa4b2d81c", null, null, "Fidel74@yahoo.com", true, "Troy Koch", null, false, null, "FIDEL74@YAHOO.COM", "FIDEL74@YAHOO.COM", "AQAAAAIAAYagAAAAEH4boPPNx9Pwq98QiFbRSVW3R3XicVSivOAdMJRi1fy39Z8Rh416yyENM6ecw8UyRw==", "(271) 515-9499", false, "b13dd230-ab0d-4219-aa8e-d660eff9be35", null, false, "Fidel74@yahoo.com" },
                    { 12, 0, "7622 Collier Forge", null, null, "68b6963f-7200-4869-a9d7-53daaf43b9ee", null, null, "Gracie_Gleichner34@gmail.com", true, "Randal Waelchi", null, false, null, "GRACIE_GLEICHNER34@GMAIL.COM", "GRACIE_GLEICHNER34@GMAIL.COM", "AQAAAAIAAYagAAAAEGW6hPHoYEfpxltXbT6pUuqPZHulAmmeGTslC0HxQSflDx1y44fNbuydSRMq9dK6+Q==", "671.963.6357", false, "1c4fb973-203f-45ae-87c0-1a1b1bd03c9a", null, false, "Gracie_Gleichner34@gmail.com" },
                    { 13, 0, "30364 Sawayn Brooks", null, null, "c31440f6-2f57-403d-b4a1-80cc118da61e", null, null, "Cassandra.Langosh39@hotmail.com", true, "Luz Wilderman", null, false, null, "CASSANDRA.LANGOSH39@HOTMAIL.COM", "CASSANDRA.LANGOSH39@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPE3AMI9wCwVQVT7Olh4tTjtGn9Mhv3eaVpyoM75JwacAeBtBFeRa1w8iyw0+XLdgg==", "376-258-9676", false, "0f0ee7a9-852d-4ad4-a300-67cb80c92f27", null, false, "Cassandra.Langosh39@hotmail.com" },
                    { 14, 0, "88971 Antonina Forks", null, null, "0ef99e28-c599-4d14-977b-d8821e767e6b", null, null, "Terrill.McKenzie@yahoo.com", true, "Paolo Runolfsdottir", null, false, null, "TERRILL.MCKENZIE@YAHOO.COM", "TERRILL.MCKENZIE@YAHOO.COM", "AQAAAAIAAYagAAAAEPEKhGLBVuRue4+DEzC5IdTaRi9zA1Sv3w+3k5VpmGbxK5hixgYfdPUdjOT+zb9W8A==", "1-533-202-7814 x0682", false, "540d4ff3-a251-4207-9503-7c3c8e5a6877", null, false, "Terrill.McKenzie@yahoo.com" },
                    { 15, 0, "379 Jones Junction", null, null, "c8574b3d-eb0c-4d10-9b34-7d904b1f686a", null, null, "Leilani_Medhurst87@yahoo.com", true, "Xander Kerluke", null, false, null, "LEILANI_MEDHURST87@YAHOO.COM", "LEILANI_MEDHURST87@YAHOO.COM", "AQAAAAIAAYagAAAAEDdfgnnvuwEtGQ+le3HK6c4jqLCaLHfLg4kvm4pOicDGm+ivewp/jIvKugWSxRsWzg==", "477-354-1196 x024", false, "6caedc93-20ad-4517-8ebf-ccff36a482d4", null, false, "Leilani_Medhurst87@yahoo.com" },
                    { 16, 0, "87381 Beier Mountain", null, null, "f1577a5c-827f-411b-8b1b-a6549c544ccb", null, null, "Sadye.Reynolds@hotmail.com", true, "Esmeralda Welch", null, false, null, "SADYE.REYNOLDS@HOTMAIL.COM", "SADYE.REYNOLDS@HOTMAIL.COM", "AQAAAAIAAYagAAAAEA3Uau8f4VlVrHOdLeKheBodNxXOq9W0etls4c4f9ZfMPSFL46q5YechOu5eOHiRaQ==", "(425) 384-6812 x2371", false, "356012c0-973d-4055-aea1-59ef8947785c", null, false, "Sadye.Reynolds@hotmail.com" },
                    { 17, 0, "38100 Sporer Motorway", null, null, "3937a063-0d91-4981-85c3-7bbd4a6ea0f5", null, null, "Ethel13@hotmail.com", true, "Marcelino Macejkovic", null, false, null, "ETHEL13@HOTMAIL.COM", "ETHEL13@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIe6NGz1YTENY2K5T7gpoxenneSrvneYkk/wtz3eUyoUi38hA06rKMeFhA1SqUr/+A==", "232.589.7860 x291", false, "68e0d4a0-ff5d-4acc-93b5-5f2b525c6739", null, false, "Ethel13@hotmail.com" },
                    { 18, 0, "633 Whitney Plaza", null, null, "c5f56100-df6c-4890-bfab-4bf7aae0d7e4", null, null, "Maya.Jacobs@gmail.com", true, "Daphne Schulist", null, false, null, "MAYA.JACOBS@GMAIL.COM", "MAYA.JACOBS@GMAIL.COM", "AQAAAAIAAYagAAAAEKKKgzIH8FBMSAOuVn+doOXsMnOtwLOf1IgSwWIaTwlsdfvTuCUAH24c3DX/j+/G7g==", "1-700-267-5843 x34253", false, "9a59aad5-3fe5-4e5e-8525-a2a15ac322b2", null, false, "Maya.Jacobs@gmail.com" },
                    { 19, 0, "3707 Strosin Villages", null, null, "c92416e5-1f12-4019-8176-313947e71fc2", null, null, "Issac.Halvorson38@gmail.com", true, "Roberta Walsh", null, false, null, "ISSAC.HALVORSON38@GMAIL.COM", "ISSAC.HALVORSON38@GMAIL.COM", "AQAAAAIAAYagAAAAEKrnPGUdWsnyFBN/DfFv/wQefSGdTgh6Seqz+/ghlUciNYAvvNPlVdIFGV1FgoyxVg==", "673.721.4367", false, "dd0269c1-eb02-4501-8d80-032e4e30ced3", null, false, "Issac.Halvorson38@gmail.com" },
                    { 20, 0, "09793 Melissa Centers", null, null, "f79f9cbf-f057-4559-ba58-9587700a912d", null, null, "Noemi.Koch83@yahoo.com", true, "Electa Will", null, false, null, "NOEMI.KOCH83@YAHOO.COM", "NOEMI.KOCH83@YAHOO.COM", "AQAAAAIAAYagAAAAEBsPwTlT6Ge3F4wtxbHgSCIepvlfojbSs0ZqZb3ILoDhCI0BtM2E+wjv+YL7OkR5jw==", "1-208-846-1429", false, "f24ce1df-3d5f-4b48-b25d-bc1041f42e25", null, false, "Noemi.Koch83@yahoo.com" },
                    { 21, 0, "958 Padberg Dam", null, null, "29ba0cc0-974a-49af-b158-53530dbdda4f", null, null, "Jaden.Mraz46@gmail.com", true, "Rocio Koch", null, false, null, "JADEN.MRAZ46@GMAIL.COM", "JADEN.MRAZ46@GMAIL.COM", "AQAAAAIAAYagAAAAEOnzJhV0SwxUKFTThOqL7pKoVRynmVzc59nQFQGTYIoDkIsndkZ12f64OMr4d+Vgdg==", "429.780.3939 x016", false, "e323c78c-0bdb-428d-9551-62177d3aee52", null, false, "Jaden.Mraz46@gmail.com" },
                    { 22, 0, "4116 Kuvalis Skyway", null, null, "2ffc08ac-76b1-45a1-a54c-6ce3c0c0278c", null, null, "Trevion.Schuster55@yahoo.com", true, "Heather Terry", null, false, null, "TREVION.SCHUSTER55@YAHOO.COM", "TREVION.SCHUSTER55@YAHOO.COM", "AQAAAAIAAYagAAAAENwDuPCyH2tTBp0FEu1Jwxb1JrPYJ+2euDuBOUwRd1nJT9DWoZtDcn/tl8okyW86Tg==", "681.803.0040 x5351", false, "2c8dabaa-b2e3-4d93-8c53-c6e7f3eb9bef", null, false, "Trevion.Schuster55@yahoo.com" },
                    { 23, 0, "00861 Elvie Mission", null, null, "73a8017a-b49a-4b87-a522-820de44bcb7d", null, null, "Lera_Batz@yahoo.com", true, "Bennie Koepp", null, false, null, "LERA_BATZ@YAHOO.COM", "LERA_BATZ@YAHOO.COM", "AQAAAAIAAYagAAAAEMsYi+Qu0wKfMbuBcpVV87Qflwrb4ErNgL1L6NALV2LQJD5n8xb2MS7GfFplfo9/MA==", "(265) 239-5938", false, "30a2786e-f01a-4765-8e72-0983222969fe", null, false, "Lera_Batz@yahoo.com" },
                    { 24, 0, "199 Brook Stream", null, null, "f784bf99-f26c-47b9-8ba0-e1f3808a6366", null, null, "Assunta69@hotmail.com", true, "Mina Brakus", null, false, null, "ASSUNTA69@HOTMAIL.COM", "ASSUNTA69@HOTMAIL.COM", "AQAAAAIAAYagAAAAELkwBdpdG+zhCfhREFK+mvtnM2C87RWIlBXLVhXrbtroMNG5o4oEwaMvxhig/49QHA==", "345.970.8297 x669", false, "a2f3e2f7-b425-4dfa-af6a-3a5b0c2a98e7", null, false, "Assunta69@hotmail.com" },
                    { 25, 0, "5028 Quinn Street", null, null, "5a3a60ed-482c-4940-bed6-db00d3217505", null, null, "Deja86@yahoo.com", true, "Krystina Dibbert", null, false, null, "DEJA86@YAHOO.COM", "DEJA86@YAHOO.COM", "AQAAAAIAAYagAAAAECFyRugoz4dgVhdwvKMjiy47/LCHroBtke+iZajgaqKBVpLQd2AAPRRD+9YH+Tql+Q==", "379.595.0326", false, "0bddd0e2-5c64-49c6-b043-8976b4e45b3b", null, false, "Deja86@yahoo.com" },
                    { 26, 0, "4978 Kunze Harbor", null, null, "9fe051eb-d304-4995-8f2e-4b7c5d540ba1", null, null, "Corbin0@hotmail.com", true, "Daren Strosin", null, false, null, "CORBIN0@HOTMAIL.COM", "CORBIN0@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIK0WrJ2Igq22nyyyxjemqn8v8C8uWa77ZJVx/DOmlDMeCeQU/oaL2PPJzL45XxWGQ==", "947.492.1521 x082", false, "b3900445-92c1-4cbf-b638-9ffc7668c848", null, false, "Corbin0@hotmail.com" },
                    { 27, 0, "08779 Baumbach Plaza", null, null, "de33fdd5-d4f1-4c14-bbac-e74fca0a3dd3", null, null, "Leonie80@gmail.com", true, "Fiona Crona", null, false, null, "LEONIE80@GMAIL.COM", "LEONIE80@GMAIL.COM", "AQAAAAIAAYagAAAAEAC/1T+tohDwN5sFH35Alnbl8fkez2FZlStXl5LJiXL2GwsycrJ+apM9CLjLKKpc0A==", "1-715-785-5841 x290", false, "3168f25a-8e31-4dad-922d-fd529777303a", null, false, "Leonie80@gmail.com" },
                    { 28, 0, "3570 Ernser Ports", null, null, "09e8a6cf-9e80-49bd-9a54-050fbe6720bc", null, null, "Penelope.Fisher25@gmail.com", true, "Dayne Berge", null, false, null, "PENELOPE.FISHER25@GMAIL.COM", "PENELOPE.FISHER25@GMAIL.COM", "AQAAAAIAAYagAAAAEOoL35pF+/bbFHYWgw2L0eP5p9W+MMxDF5icrYQ3uNnrKFEbwoRabns9a73P2XbwiQ==", "(454) 512-5946", false, "f6fb71cf-35ef-4f8e-ae46-31d59459aa5d", null, false, "Penelope.Fisher25@gmail.com" },
                    { 29, 0, "7071 Ritchie Heights", null, null, "1c992531-2a63-4516-9637-5d896fd687ef", null, null, "Arlo_Schumm@hotmail.com", true, "Gordon Douglas", null, false, null, "ARLO_SCHUMM@HOTMAIL.COM", "ARLO_SCHUMM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEafqGk1BOM/V4Mnh8kt7bQK6PTargqiYnphj2D01d7esMHyWr5bOkvSXDDzI8iURw==", "974-579-9035 x483", false, "0d4b9040-4237-4fdf-9f58-60d52dfcf304", null, false, "Arlo_Schumm@hotmail.com" },
                    { 30, 0, "259 Kertzmann Road", null, null, "da6b86b8-cc7e-4982-acc2-982cfbcad489", null, null, "Arlo_Ernser79@yahoo.com", true, "Heather Roberts", null, false, null, "ARLO_ERNSER79@YAHOO.COM", "ARLO_ERNSER79@YAHOO.COM", "AQAAAAIAAYagAAAAEDjALJN6sya63e0YNFLmBNAJHaEaKQLx5EaNB6e8cVHTniotQFuElbdTgcp3Yc+oKg==", "(932) 838-0968 x08962", false, "fa17438c-fb1a-4840-94df-1217bcebbf6e", null, false, "Arlo_Ernser79@yahoo.com" },
                    { 31, 0, "0089 Retta Lodge", null, null, "e6ce76c6-6d88-472d-969b-086233760f32", null, null, "Creola_Steuber@gmail.com", true, "Christy Harber", null, false, null, "CREOLA_STEUBER@GMAIL.COM", "CREOLA_STEUBER@GMAIL.COM", "AQAAAAIAAYagAAAAEA3Pm4zE2BM1PdGnYttRjtmA4wWOx9volwGQifwQwRAuxjOXxqWmTEUI/FV3octA1w==", "770.205.4429 x646", false, "74070d76-d119-4e51-8ab7-f280144f4a98", null, false, "Creola_Steuber@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "About", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "Specialization", "UserId", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1, "Aliquam vero repellat debitis tempore.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 4, 2, 19 },
                    { 2, "Nulla tempore similique et architecto sunt saepe vel est.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2, 3, 6 },
                    { 3, "Ducimus magni dolores est aut ducimus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 5, 4, 13 },
                    { 4, "Aliquid facere accusamus rem et consequuntur.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2, 5, 14 },
                    { 5, "Est voluptates omnis eum vel fugiat excepturi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 3, 6, 4 },
                    { 6, "Nisi est quia veritatis voluptatibus accusantium blanditiis facere velit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1, 7, 14 },
                    { 7, "Quasi facere rerum autem illo possimus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2, 8, 8 },
                    { 8, "Minus soluta vero corporis qui sit et voluptas.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1, 9, 12 },
                    { 9, "Dicta vel recusandae nesciunt doloremque excepturi explicabo voluptas totam aut.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1, 10, 8 },
                    { 10, "Voluptatem est at molestias nisi facere et ab et.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2, 11, 18 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 12 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 13 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 14 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 15 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 16 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 17 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 18 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 19 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 20 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 21 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 22 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 23 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 24 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 25 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 26 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 27 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 28 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 29 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 30 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 31 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 2, 19 },
                    { 2, 20 },
                    { 2, 21 },
                    { 2, 22 },
                    { 2, 23 },
                    { 2, 24 },
                    { 2, 25 },
                    { 2, 26 },
                    { 2, 27 },
                    { 2, 28 },
                    { 2, 29 },
                    { 2, 30 },
                    { 2, 31 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "CreatedAt", "CreatedBy", "DoctorId", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "PatientId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2012, 8, 19, 15, 19, 38, 285, DateTimeKind.Local).AddTicks(9774), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, null, null, 7, 3 },
                    { 2, new DateTime(2004, 10, 5, 0, 8, 49, 260, DateTimeKind.Local).AddTicks(4550), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, null, null, 19, 1 },
                    { 3, new DateTime(2007, 8, 13, 18, 40, 8, 883, DateTimeKind.Local).AddTicks(97), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, null, null, 20, 1 },
                    { 4, new DateTime(2005, 5, 29, 18, 18, 28, 737, DateTimeKind.Local).AddTicks(7724), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, null, null, 18, 1 },
                    { 5, new DateTime(2008, 8, 18, 20, 14, 3, 232, DateTimeKind.Local).AddTicks(982), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, null, null, 13, 2 },
                    { 6, new DateTime(2020, 2, 26, 22, 9, 8, 887, DateTimeKind.Local).AddTicks(2866), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, null, null, 3, 3 },
                    { 7, new DateTime(2006, 4, 26, 3, 24, 14, 488, DateTimeKind.Local).AddTicks(8410), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, null, null, 19, 2 },
                    { 8, new DateTime(2012, 10, 15, 3, 13, 10, 776, DateTimeKind.Local).AddTicks(4000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, null, null, 20, 2 },
                    { 9, new DateTime(2003, 6, 19, 18, 57, 58, 881, DateTimeKind.Local).AddTicks(7219), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, null, null, 5, 3 },
                    { 10, new DateTime(2022, 7, 24, 19, 3, 1, 90, DateTimeKind.Local).AddTicks(7914), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, false, null, null, 2, 3 },
                    { 11, new DateTime(2004, 8, 11, 16, 36, 5, 663, DateTimeKind.Local).AddTicks(4515), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, null, null, 13, 2 },
                    { 12, new DateTime(2024, 5, 7, 15, 6, 8, 985, DateTimeKind.Local).AddTicks(9594), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, null, null, 10, 2 },
                    { 13, new DateTime(2022, 1, 17, 7, 17, 29, 723, DateTimeKind.Local).AddTicks(1479), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, null, null, 2, 3 },
                    { 14, new DateTime(1999, 12, 8, 6, 30, 27, 483, DateTimeKind.Local).AddTicks(8883), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, null, null, 13, 1 },
                    { 15, new DateTime(1996, 5, 13, 3, 4, 9, 357, DateTimeKind.Local).AddTicks(7462), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, null, null, 13, 1 },
                    { 16, new DateTime(2016, 7, 1, 10, 42, 34, 451, DateTimeKind.Local).AddTicks(4279), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, null, null, 14, 3 },
                    { 17, new DateTime(2000, 1, 24, 22, 53, 45, 690, DateTimeKind.Local).AddTicks(8785), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, null, null, 15, 3 },
                    { 18, new DateTime(1997, 9, 16, 18, 57, 35, 32, DateTimeKind.Local).AddTicks(4421), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, null, null, 2, 1 },
                    { 19, new DateTime(1994, 12, 1, 7, 37, 3, 78, DateTimeKind.Local).AddTicks(4451), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, null, null, 12, 1 },
                    { 20, new DateTime(2003, 2, 12, 21, 33, 18, 701, DateTimeKind.Local).AddTicks(7820), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, null, null, 9, 3 },
                    { 21, new DateTime(2006, 7, 10, 23, 37, 27, 258, DateTimeKind.Local).AddTicks(3429), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, null, null, 18, 3 },
                    { 22, new DateTime(1997, 9, 30, 2, 37, 23, 752, DateTimeKind.Local).AddTicks(1069), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, null, null, 2, 2 },
                    { 23, new DateTime(2012, 12, 1, 15, 41, 2, 763, DateTimeKind.Local).AddTicks(2720), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, null, null, 13, 3 },
                    { 24, new DateTime(1996, 1, 23, 2, 29, 13, 310, DateTimeKind.Local).AddTicks(5557), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, null, null, 9, 3 },
                    { 25, new DateTime(2010, 3, 28, 22, 42, 4, 638, DateTimeKind.Local).AddTicks(4952), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, null, null, 15, 3 },
                    { 26, new DateTime(2020, 3, 24, 8, 52, 7, 150, DateTimeKind.Local).AddTicks(6628), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, null, null, 3, 1 },
                    { 27, new DateTime(2008, 2, 11, 6, 38, 17, 315, DateTimeKind.Local).AddTicks(6517), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, null, null, 15, 3 },
                    { 28, new DateTime(2014, 8, 24, 21, 30, 0, 56, DateTimeKind.Local).AddTicks(945), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, null, null, 5, 3 },
                    { 29, new DateTime(1999, 1, 11, 19, 22, 39, 398, DateTimeKind.Local).AddTicks(2903), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, null, null, 18, 1 },
                    { 30, new DateTime(2020, 12, 8, 22, 18, 38, 53, DateTimeKind.Local).AddTicks(5963), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, null, null, 14, 2 },
                    { 31, new DateTime(2016, 10, 18, 21, 52, 30, 856, DateTimeKind.Local).AddTicks(361), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, null, null, 14, 3 },
                    { 32, new DateTime(2001, 5, 25, 8, 58, 36, 403, DateTimeKind.Local).AddTicks(4922), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, null, null, 14, 2 },
                    { 33, new DateTime(2003, 1, 31, 8, 37, 37, 701, DateTimeKind.Local).AddTicks(856), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, null, null, 4, 2 },
                    { 34, new DateTime(2015, 12, 3, 14, 31, 48, 223, DateTimeKind.Local).AddTicks(547), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, null, null, 8, 1 },
                    { 35, new DateTime(2006, 5, 13, 19, 8, 25, 370, DateTimeKind.Local).AddTicks(1692), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, null, null, 7, 1 },
                    { 36, new DateTime(2013, 6, 27, 3, 23, 16, 314, DateTimeKind.Local).AddTicks(4665), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, null, null, 6, 2 },
                    { 37, new DateTime(2009, 5, 18, 0, 18, 26, 684, DateTimeKind.Local).AddTicks(641), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, null, null, 2, 3 },
                    { 38, new DateTime(2024, 11, 3, 15, 4, 0, 935, DateTimeKind.Local).AddTicks(2181), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, null, null, 16, 1 },
                    { 39, new DateTime(2005, 9, 14, 14, 4, 1, 840, DateTimeKind.Local).AddTicks(7309), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, null, null, 16, 1 },
                    { 40, new DateTime(1997, 2, 7, 6, 17, 16, 752, DateTimeKind.Local).AddTicks(5201), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, null, null, 8, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UserId",
                table: "Patients",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
