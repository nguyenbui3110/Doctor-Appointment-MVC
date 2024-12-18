using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorAppointment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
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
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
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
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
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
                    { 2, null, "Doctor", "DOCTOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AvatarUrl", "City", "ConcurrencyStamp", "Country", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "Admin Address", null, null, "f2d5a603-fdf8-4482-ab36-c4dbbde43074", null, null, "admin@gmail.com", true, "Admin", null, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEEejT/8JFFw95bPViyCbrdhqlwnG+Pxb81+5U4XFAf4zwHjNDbVWqjhS64+n+2p/GQ==", "123456789", false, "f86da275-5f52-4c45-a026-1c54b8395de7", null, false, "admin" },
                    { 2, 0, "473 Đinh Orchard", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Kh%C3%A1nh%20Huy%20Ph%E1%BA%A1m", null, "58e42801-9c9c-48ee-b687-02b479874024", null, new DateTime(2017, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "DucBinh27@yahoo.com", true, "Khánh Huy Phạm", 1, false, null, "DUCBINH27@YAHOO.COM", "DUCBINH27@YAHOO.COM", "AQAAAAIAAYagAAAAEOpel+T1GNyoxZqskr4m6mg0w6E1Za13znkaD5CwCoYysy3WwBLe8NrvtrWHlM4F6A==", "028 5077 6849", false, "f9232cb9-ade1-4996-99d7-21e265a94a78", null, false, "DucBinh27@yahoo.com" },
                    { 3, 0, "2430 Tô Lodge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Qu%C3%A2n%20%C4%90%E1%BA%B7ng", null, "b5cd3a22-ae71-470a-8697-cc06b696aff6", null, new DateTime(1997, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "ThanhViet_Phung@gmail.com", true, "Hoàng Quân Đặng", 3, false, null, "THANHVIET_PHUNG@GMAIL.COM", "THANHVIET_PHUNG@GMAIL.COM", "AQAAAAIAAYagAAAAEJKEqOeQ9dGpO1yy7snz99dy3HoNTI1SHdWYCrnQkdQgvljXURMHxc+pmXyI8Q16Ug==", "028 2650 5498", false, "8bad7c25-e073-4439-b18e-39a978d57cdb", null, false, "ThanhViet_Phung@gmail.com" },
                    { 4, 0, "1414 Minh Cảnh Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thu%E1%BA%ADn%20To%C3%A0n%20%C4%90inh", null, "bb27be52-9a95-4c8d-bc32-c020d78112ee", null, new DateTime(2015, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "BaoHa60@yahoo.com", true, "Thuận Toàn Đinh", 1, false, null, "BAOHA60@YAHOO.COM", "BAOHA60@YAHOO.COM", "AQAAAAIAAYagAAAAEPse6KJyMiWyZtL/5SCxycl4LM4HZOBtLi+iiG+6gwYZ8Alm4u3dCVVoFfv+JYa/Og==", "028 0067 7051", false, "71f91967-21f0-407a-af8a-b6de7fb830b5", null, false, "BaoHa60@yahoo.com" },
                    { 5, 0, "83624 Hà Trail", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%E1%BB%A5c%20Trang%20%C4%90%E1%BA%B7ng", null, "ec55828e-fcf2-4594-8cd0-a7d38d691a50", null, new DateTime(2016, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "HungDung_Hoang@hotmail.com", true, "Thục Trang Đặng", 3, false, null, "HUNGDUNG_HOANG@HOTMAIL.COM", "HUNGDUNG_HOANG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDBi0osczoMACWa6Se8K5ktkeDrM5RbyAfY/venpCviVdq22b8d9cEzytqxfbMDZtQ==", "022 7204 2706", false, "9cd75536-0c3e-45f6-ade5-9ab433bd142d", null, false, "HungDung_Hoang@hotmail.com" },
                    { 6, 0, "6674 Đỗ Prairie", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thu%20Huy%E1%BB%81n%20Tr%E1%BA%A7n", null, "01929f14-12e9-42dd-8931-374988c535e3", null, new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), "TriHuu_To69@gmail.com", true, "Thu Huyền Trần", 2, false, null, "TRIHUU_TO69@GMAIL.COM", "TRIHUU_TO69@GMAIL.COM", "AQAAAAIAAYagAAAAEG6gmIWaRiGqkeR2q2UuYT0sDWzayWa+kzjZAKrjezAG5e4BGe4MG9if5shBrbD1rw==", "026 9715 7509", false, "1f4237c0-cfd1-4269-bb63-7daf68148498", null, false, "TriHuu_To69@gmail.com" },
                    { 7, 0, "45341 Quang Thạch Common", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C3%AD%20Li%C3%AAn%20Mai", null, "30930fd9-3910-4fd7-b6e8-dbded0a552e7", null, new DateTime(1995, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "ThienThanh_Do@hotmail.com", true, "Trí Liên Mai", 3, false, null, "THIENTHANH_DO@HOTMAIL.COM", "THIENTHANH_DO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMBcuRkNvLBWoTQpeJtcS3W5Mfm5j31BgokjFe06HeWCorsETnUUW4PD+BiNYxzbGQ==", "0283 1761 5530", false, "b67b151b-74a8-4931-862d-a785aeb8cf28", null, false, "ThienThanh_Do@hotmail.com" },
                    { 8, 0, "428 Ðoan Thanh Coves", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Qu%E1%BB%91c%20Trung%20T%C3%B4", null, "b69d9014-b59a-4145-9dd5-3f07127be61b", null, new DateTime(2019, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "AiVan.Ngo@yahoo.com", true, "Quốc Trung Tô", 2, false, null, "AIVAN.NGO@YAHOO.COM", "AIVAN.NGO@YAHOO.COM", "AQAAAAIAAYagAAAAEC/u+6RweTCE9pVFm4AAL1xf0yIhr8iXJIt79gpilwoJYA16yALwOm1x+f85eLa65Q==", "023 0956 3364", false, "4437c944-e2ca-4f32-bb7b-fb2315d9431e", null, false, "AiVan.Ngo@yahoo.com" },
                    { 9, 0, "0716 Thúy Vân Lake", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ch%C3%AD%20Hi%E1%BA%BFu%20Ph%C3%B9ng", null, "38db17f5-681a-4cb2-b353-300291130e26", null, new DateTime(1995, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "TrucLy16@yahoo.com", true, "Chí Hiếu Phùng", 1, false, null, "TRUCLY16@YAHOO.COM", "TRUCLY16@YAHOO.COM", "AQAAAAIAAYagAAAAED+8D3pQpV60ZerqVh5VRBPpOXk3jutciMTrs6CcibshfJhr4CVWWp/kueqaKlV4eQ==", "021 4280 5913", false, "dadc50c7-25cc-4ef0-8edf-d2189ce9241c", null, false, "TrucLy16@yahoo.com" },
                    { 10, 0, "7625 An Nhiên Port", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%E1%BA%BF%20Ph%C3%BAc%20Ph%E1%BA%A1m", null, "90b825c7-3ca0-4141-b1d9-c14efed58298", null, new DateTime(2010, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "HongChau.Le@gmail.com", true, "Thế Phúc Phạm", 2, false, null, "HONGCHAU.LE@GMAIL.COM", "HONGCHAU.LE@GMAIL.COM", "AQAAAAIAAYagAAAAEHSeTJYHXI/mlSIogRAjOb6Y2lL7UGEKaGqiI6ovBxsf7v8/HAFQCMYVYwLBt6xWvw==", "022 8001 2952", false, "5250d917-0b37-4803-9963-df25a70fab7a", null, false, "HongChau.Le@gmail.com" },
                    { 11, 0, "881 Đinh Land", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%E1%BB%9Dng%20Giang%20Ng%C3%B4", null, "7f92914b-5d39-421f-90e6-a3996d2dd977", null, new DateTime(2015, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "HongAnh.Vuong7@yahoo.com", true, "Trường Giang Ngô", 3, false, null, "HONGANH.VUONG7@YAHOO.COM", "HONGANH.VUONG7@YAHOO.COM", "AQAAAAIAAYagAAAAEB/uCZBidhs5qBfM5sjbHZYi4Gg82Qpkn542aAdnuUh85ECf8FFWA1fJxQpflS2Yrw==", "029 3255 6130", false, "209e3f59-461c-46c4-af65-c0946286d751", null, false, "HongAnh.Vuong7@yahoo.com" },
                    { 12, 0, "2806 Tô Coves", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%C3%A1i%20Th%E1%BA%A3o%20L%C3%BD", null, "0aed4b5c-2ac8-4fce-9b12-ef94a23170e0", null, new DateTime(2002, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "VyLan17@hotmail.com", true, "Thái Thảo Lý", 3, false, null, "VYLAN17@HOTMAIL.COM", "VYLAN17@HOTMAIL.COM", "AQAAAAIAAYagAAAAELaxrafOilhCG9a0LPmjwN/H/YgZcd++voerfzeWPTmUgFW2amKXvDtZo7gD1YI+WQ==", "0243 3783 2654", false, "cef8a3cf-d8a4-43fd-97af-2f2ccbac0d8d", null, false, "VyLan17@hotmail.com" },
                    { 13, 0, "114 Ngô Ford", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Vi%E1%BB%87t%20Tuy%E1%BA%BFt%20T%C4%83ng", null, "d89d7f46-b9cb-49fe-bbc7-0101d3fa3528", null, new DateTime(2005, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "ThanhThuy.Phung2@yahoo.com", true, "Việt Tuyết Tăng", 2, false, null, "THANHTHUY.PHUNG2@YAHOO.COM", "THANHTHUY.PHUNG2@YAHOO.COM", "AQAAAAIAAYagAAAAEG77BeHFtmF+lN8aKOLiWdKO8TCOp0+LkRpzbvdNIMWCtz2xZh0NWbZlSlheDn7fPA==", "0261 9543 1333", false, "67ad70a4-758d-47ba-b899-aaab63e17ee7", null, false, "ThanhThuy.Phung2@yahoo.com" },
                    { 14, 0, "282 Vương Port", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=M%E1%BB%99ng%20Nhi%20V%C6%B0%C6%A1ng", null, "0c580f91-1743-40ac-9191-96c1ccdd71c0", null, new DateTime(2009, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "ThuThuy.Tang@yahoo.com", true, "Mộng Nhi Vương", 3, false, null, "THUTHUY.TANG@YAHOO.COM", "THUTHUY.TANG@YAHOO.COM", "AQAAAAIAAYagAAAAEOeMk3DhcEd+qSv9tZGNouTk47IAeSi/r26OAJIp5o3EU0BAHUnRw55fJ/OxLuaGmw==", "0289 8218 2142", false, "c747ef7c-58fc-411d-a724-395152692fdc", null, false, "ThuThuy.Tang@yahoo.com" },
                    { 15, 0, "9928 Đoàn Hollow", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%E1%BA%A1ch%20V%C3%A2n%20L%C3%A2m", null, "64eb86e8-7273-426a-94e0-38161c0232f8", null, new DateTime(2005, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "AnhHong.Phung@hotmail.com", true, "Bạch Vân Lâm", 1, false, null, "ANHHONG.PHUNG@HOTMAIL.COM", "ANHHONG.PHUNG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBG6JfGMyztrrtb73s5NhSzyL8sSzPUNVXHM2RYQrA+lcXUaI1eS7P8CDejE7STgww==", "0237 9493 0324", false, "137e079f-545c-4552-b75c-e4605ff94e14", null, false, "AnhHong.Phung@hotmail.com" },
                    { 16, 0, "8517 Thành Tín Isle", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C3%90%E1%BB%A9c%20Th%C3%A0nh%20%C4%90%C3%A0o", null, "921cd16b-6da1-4af5-b02c-9f74720b1d43", null, new DateTime(2006, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "KienDuc10@gmail.com", true, "Ðức Thành Đào", 1, false, null, "KIENDUC10@GMAIL.COM", "KIENDUC10@GMAIL.COM", "AQAAAAIAAYagAAAAEDF1Qy3/hmXxt+/ScMmjObMsbv8I5dfCfDliigm5OBtJ0a5+D4RWk2QLfRaReEW5UQ==", "0224 3618 1808", false, "97d02c24-b4ec-4d66-a301-a9322eb5c45c", null, false, "KienDuc10@gmail.com" },
                    { 17, 0, "690 Lâm Plaza", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%E1%BA%A3o%20Ch%E1%BA%A5n%20L%C3%AA", null, "8017289f-5488-4d83-a4c1-7e088a6ce584", null, new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "TuanTrung_Pham5@hotmail.com", true, "Bảo Chấn Lê", 1, false, null, "TUANTRUNG_PHAM5@HOTMAIL.COM", "TUANTRUNG_PHAM5@HOTMAIL.COM", "AQAAAAIAAYagAAAAELJTLRncU8U9qK9dVXZKHOVD9qtVhiZ8SmOYoAF0LUEFyybmIKPckH399uKuuQPxHw==", "0242 7271 3194", false, "fb8c4761-019c-44cd-9a1f-0c4898bb2956", null, false, "TuanTrung_Pham5@hotmail.com" },
                    { 18, 0, "93753 Đào Estate", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=M%E1%BA%A1nh%20T%E1%BA%A5n%20Nguy%E1%BB%85n", null, "a1d7037f-9735-46f4-aeeb-2ccc986f323f", null, new DateTime(2017, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), "BichHue_Doan24@hotmail.com", true, "Mạnh Tấn Nguyễn", 3, false, null, "BICHHUE_DOAN24@HOTMAIL.COM", "BICHHUE_DOAN24@HOTMAIL.COM", "AQAAAAIAAYagAAAAED1jvWarQ+/bhOORHHX2Ryui5VzWignaCHLyZSetGdZVFpQVDXunfwUu3eafRZdAZA==", "020 4944 5637", false, "022cd7ea-57b6-41d4-8a27-dbfd43d84cb3", null, false, "BichHue_Doan24@hotmail.com" },
                    { 19, 0, "2567 Lê Hills", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=M%E1%BB%B9%20Tr%C3%A2m%20%C4%90%E1%BA%B7ng", null, "9a617aee-396a-48b6-92a1-84da473bf70d", null, new DateTime(2003, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "NgocDoan87@yahoo.com", true, "Mỹ Trâm Đặng", 2, false, null, "NGOCDOAN87@YAHOO.COM", "NGOCDOAN87@YAHOO.COM", "AQAAAAIAAYagAAAAEEtU9sYAz/RQ49xLYOZPvXuN/hll53PaddBynDil3ror+HE9nbFfxyJSn5AjDY+ifw==", "0289 8030 3395", false, "43036263-45d3-43ce-a7c8-e3aa1742ec90", null, false, "NgocDoan87@yahoo.com" },
                    { 20, 0, "687 Hạnh My Plains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thi%C3%AAn%20M%E1%BA%A1nh%20Ph%C3%B9ng", null, "568fca23-07a1-4a45-843d-06bef8908f31", null, new DateTime(2010, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "BaThinh76@hotmail.com", true, "Thiên Mạnh Phùng", 1, false, null, "BATHINH76@HOTMAIL.COM", "BATHINH76@HOTMAIL.COM", "AQAAAAIAAYagAAAAED5PUBWEJZG37vPaMvw18NFDidg6bThMKS3GKdlGYLL22iPQGj7aB1fMidOThGPfkQ==", "0201 4849 6235", false, "d497e652-c6a9-4054-898b-4b8d10d5047b", null, false, "BaThinh76@hotmail.com" },
                    { 21, 0, "16203 Phan Cape", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Nhi%20%C4%90%E1%BB%97", null, "4a57bceb-d1d6-4b78-af94-bbe37884060d", null, new DateTime(1998, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "DucPhong_Vu97@yahoo.com", true, "Mai Nhi Đỗ", 1, false, null, "DUCPHONG_VU97@YAHOO.COM", "DUCPHONG_VU97@YAHOO.COM", "AQAAAAIAAYagAAAAEByrnhZooy4mMnYQGxPA81DTt7bIPPqezsnoCFJccgHh4IiwDC/F1akJlwWc0vHv7w==", "0288 4070 1645", false, "3206be4a-7660-4c94-9ec6-369810af4b5f", null, false, "DucPhong_Vu97@yahoo.com" },
                    { 22, 0, "26571 Hoàng Khang Pine", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%E1%BA%BF%20H%C3%B9ng%20%C4%90%C3%A0o", null, "9e3b3a15-c9df-4b3e-b6d8-91144ea077b2", null, new DateTime(1997, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), "DongTuyen_Truong47@gmail.com", true, "Thế Hùng Đào", 1, false, null, "DONGTUYEN_TRUONG47@GMAIL.COM", "DONGTUYEN_TRUONG47@GMAIL.COM", "AQAAAAIAAYagAAAAEOY5PJwxHmAIbmliBWss1LJoRY3WL1uWYagoxw0+DT1UJ1qIlOUuEBfC7F12b9GsOQ==", "025 2159 5733", false, "1c885690-d2f9-4609-99b1-4637dd62ef4e", null, false, "DongTuyen_Truong47@gmail.com" },
                    { 23, 0, "981 Duy Tuyền River", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Danh%20Nh%C3%A2n%20H%E1%BB%93", null, "5a49dc10-6426-47de-8520-2549663ec32f", null, new DateTime(2018, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "DuyLuan_Bui91@hotmail.com", true, "Danh Nhân Hồ", 2, false, null, "DUYLUAN_BUI91@HOTMAIL.COM", "DUYLUAN_BUI91@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBDYqBbgFYcIB5BZg/+cg3r/bz0FTwMBqAzWteKtZE9i/GxZKOWVimUCLptMtDS0qA==", "020 4118 5183", false, "5a1e17f1-f6af-4645-8ec4-222597cc4198", null, false, "DuyLuan_Bui91@hotmail.com" },
                    { 24, 0, "54876 Trịnh Route", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%A2n%20Tr%C3%BAc%20T%C3%B4", null, "b5d65ec0-03b8-4663-a805-b2144e7678ba", null, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "KhaiTam.Ho66@gmail.com", true, "Ngân Trúc Tô", 1, false, null, "KHAITAM.HO66@GMAIL.COM", "KHAITAM.HO66@GMAIL.COM", "AQAAAAIAAYagAAAAEMoHN91sZnkA8PPdWQDuglXptLRZcosylQ8JL2wlL5Pnh7y3C3avTcJjXmGnGUM23w==", "026 6308 7948", false, "0357da13-4237-4afb-bf63-3f5d601befa9", null, false, "KhaiTam.Ho66@gmail.com" },
                    { 25, 0, "615 Việt Quyết Drive", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C6%B0%E1%BB%A3ng%20Uy%C3%AAn%20Mai", null, "06c84b2d-2ce1-4fd2-a055-f9d7aee6fb7a", null, new DateTime(2017, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), "ThienGiang_Doan@hotmail.com", true, "Phượng Uyên Mai", 3, false, null, "THIENGIANG_DOAN@HOTMAIL.COM", "THIENGIANG_DOAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJe0iRz/lTV+r3VuvxHHJQ+CjwzmbSSvZtZ05yNobhqeYksj2zXk9IlTYC18cLn3WQ==", "021 6065 8166", false, "a2ddd15a-92bc-44e2-a07f-1566eb2f6991", null, false, "ThienGiang_Doan@hotmail.com" },
                    { 26, 0, "28559 Vũ Stream", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nh%C6%B0%20Khang%20Ph%C3%B9ng", null, "da024a62-fd9b-424c-be80-6c90bdc68778", null, new DateTime(2017, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "QuePhuong.Duong52@gmail.com", true, "Như Khang Phùng", 3, false, null, "QUEPHUONG.DUONG52@GMAIL.COM", "QUEPHUONG.DUONG52@GMAIL.COM", "AQAAAAIAAYagAAAAEJVLen53GhpN4nkrz3+hBqY4OeXbsMyOqe1bbj2GrJdymDAVJcp8rxqc9fwSz+Zl1w==", "0268 3838 2702", false, "38dae0f7-73df-467c-b4cc-c828cf2261ed", null, false, "QuePhuong.Duong52@gmail.com" },
                    { 27, 0, "545 Hồng Giang Trace", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%A1%20Ph%C6%B0%E1%BB%9Bc%20Mai", null, "38e9bf93-24b5-421f-9273-37a961375ef7", null, new DateTime(2003, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "XuanTrung_Nguyen41@gmail.com", true, "Bá Phước Mai", 3, false, null, "XUANTRUNG_NGUYEN41@GMAIL.COM", "XUANTRUNG_NGUYEN41@GMAIL.COM", "AQAAAAIAAYagAAAAECdgz/XZt1xdvbRqjB8eTd9EMtJGbByEISyfJB7P0QHWKiT7mVRd4YVSjClkhL0eIw==", "0284 8047 4661", false, "08c0c260-fd86-47b5-b817-454ab1562ccc", null, false, "XuanTrung_Nguyen41@gmail.com" },
                    { 28, 0, "504 Giáng Tiên Row", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thi%E1%BB%87n%20Ph%C6%B0%E1%BB%9Bc%20L%C3%AA", null, "12352276-1cc8-4e4e-894e-f48db37f6a48", null, new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "HuuTho.Duong@hotmail.com", true, "Thiện Phước Lê", 3, false, null, "HUUTHO.DUONG@HOTMAIL.COM", "HUUTHO.DUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFWIaKx3vpooaJFk8f6xbiTU125z5CJEyA3fOlsL8udE8xyvcobwxzJwasJF/vlztQ==", "021 0857 8371", false, "5c346e71-aace-4e7f-9295-265c63e01eab", null, false, "HuuTho.Duong@hotmail.com" },
                    { 29, 0, "5302 Lê Inlet", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Gia%20Ph%C6%B0%E1%BB%9Bc%20Ph%E1%BA%A1m", null, "493744f0-d65f-4cee-88a6-491a2280f41b", null, new DateTime(2009, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "QuynhGiao23@gmail.com", true, "Gia Phước Phạm", 1, false, null, "QUYNHGIAO23@GMAIL.COM", "QUYNHGIAO23@GMAIL.COM", "AQAAAAIAAYagAAAAEEKqrFI6Pc23Kp+TAzczDeEXxQTgHLMrojVL5huzxh/LE1eeA2tjcK8g4di1fZKMHQ==", "028 9515 7091", false, "9bcb9a42-5099-434e-8951-3b4a0cdab895", null, false, "QuynhGiao23@gmail.com" },
                    { 30, 0, "7484 Phan Pine", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C3%AD%20Th%E1%BA%AFng%20T%C4%83ng", null, "52e06a66-0533-4f00-a9bb-e152684c1d66", null, new DateTime(1999, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "HuyHa39@hotmail.com", true, "Trí Thắng Tăng", 1, false, null, "HUYHA39@HOTMAIL.COM", "HUYHA39@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPjD93Wzzl6sWjhZEhGUIPX8Wq/HS2soEBbCrCoz29CKmCAXCz4O3Q/FxK8DxMkzIw==", "0254 5517 1984", false, "da325261-b506-48e8-b1df-057e50e2475c", null, false, "HuyHa39@hotmail.com" },
                    { 31, 0, "42345 Nguyễn Walks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%E1%BB%87%20Qu%C3%A2n%20Tr%E1%BA%A7n", null, "0f77a303-dc2f-403b-ac64-4329ca6f07cc", null, new DateTime(2010, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "LamDung_Vuong@hotmail.com", true, "Lệ Quân Trần", 3, false, null, "LAMDUNG_VUONG@HOTMAIL.COM", "LAMDUNG_VUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPwEqHx+aGDjuXL04G2trARUyVb9jDZY1M/D3jyXTC6e21+/xFom+FZW1PKMBanyRQ==", "0200 7375 4052", false, "42e162a9-2771-4033-840b-ef19027a9b0d", null, false, "LamDung_Vuong@hotmail.com" },
                    { 32, 0, "02587 Trang Tâm Loaf", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%C3%B9y%20Dung%20Phan", null, "e0d5e1af-596f-4e4c-91dd-8ab6bcabfdb5", null, new DateTime(2009, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "MyKieu_Tran@gmail.com", true, "Thùy Dung Phan", 1, false, null, "MYKIEU_TRAN@GMAIL.COM", "MYKIEU_TRAN@GMAIL.COM", "AQAAAAIAAYagAAAAEFsPTBwbqZz1vxhfbJGiTcwP628pNEkJEI8ncyZNh+Dnz/KALuYHPJ3VkzxH8sQQ8g==", "0269 7757 2901", false, "1f79a23c-332c-4e3b-850f-d3a5f014bb77", null, false, "MyKieu_Tran@gmail.com" },
                    { 33, 0, "00660 Diệu Ngà Drives", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Vi%E1%BB%87t%20C%C6%B0%E1%BB%9Dng%20%C4%90inh", null, "f64e4b19-4f3b-4769-bd58-d3a32396e3f6", null, new DateTime(1996, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), "KimCuong.Tran59@hotmail.com", true, "Việt Cường Đinh", 2, false, null, "KIMCUONG.TRAN59@HOTMAIL.COM", "KIMCUONG.TRAN59@HOTMAIL.COM", "AQAAAAIAAYagAAAAEINGsmbOfKP00ChhPtfaHOn4oQWrHNNfz6DfkEC9xtaCopxWhQgy4kELGnG3PiFRpg==", "025 5783 9352", false, "e9d529af-fc72-4442-ae9f-7a3cba43653c", null, false, "KimCuong.Tran59@hotmail.com" },
                    { 34, 0, "0057 Dương Summit", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nh%E1%BA%ADt%20Mai%20%C4%90o%C3%A0n", null, "70e525d9-d198-46d6-adc6-1925e7ba06da", null, new DateTime(2004, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "TheLuc90@hotmail.com", true, "Nhật Mai Đoàn", 3, false, null, "THELUC90@HOTMAIL.COM", "THELUC90@HOTMAIL.COM", "AQAAAAIAAYagAAAAEOJILEkAJYyz0BryDI8y4icKmEYklxMDvlxynZ3vOnnBKaUzqMwxcoMCiF84YhhkiA==", "023 2883 3788", false, "66e70e03-2399-4d64-a27d-8b7497468d3b", null, false, "TheLuc90@hotmail.com" },
                    { 35, 0, "17665 Quốc Trụ Heights", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=An%20Khang%20%C4%90%C3%A0o", null, "04e3e9be-c1b0-4610-a2f4-f672bcd5e961", null, new DateTime(2012, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "LeThuy.Ngo@yahoo.com", true, "An Khang Đào", 3, false, null, "LETHUY.NGO@YAHOO.COM", "LETHUY.NGO@YAHOO.COM", "AQAAAAIAAYagAAAAEHQJcn5ty94lW/9LfVMpq5CJidcoWT5NnBmCe/T146pKWRNVZBh8EG1jtOJSwqCyNA==", "029 0295 7294", false, "b659292f-5fcc-4987-9f00-24b2aa66bea1", null, false, "LeThuy.Ngo@yahoo.com" },
                    { 36, 0, "01284 Bá Thịnh Estates", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C3%81nh%20Nguy%E1%BB%87t%20T%C3%B4", null, "989ad431-6cfc-4a22-9e10-713015f45b0e", null, new DateTime(1995, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "NguyenSu_Bui@hotmail.com", true, "Ánh Nguyệt Tô", 1, false, null, "NGUYENSU_BUI@HOTMAIL.COM", "NGUYENSU_BUI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEH0iDIAxInTjnTGbGDpaQpVt9i3lPlLVdrcr0hc5gZ7wHo0jqPXC7Fe+x9fDAOMvHw==", "021 0100 5900", false, "7854da05-691c-4da0-aed0-89da24a041f3", null, false, "NguyenSu_Bui@hotmail.com" },
                    { 37, 0, "06220 Nguyễn Neck", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%ADch%20Nh%C3%A3%20%C4%90%E1%BB%97", null, "1c9dfbfa-19fc-4eb4-bd06-961ebcebb466", null, new DateTime(2009, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), "HaiYen.Vuong@hotmail.com", true, "Bích Nhã Đỗ", 1, false, null, "HAIYEN.VUONG@HOTMAIL.COM", "HAIYEN.VUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMuetvpMG7VX+zuRyYWLn/WNiLLjuHgxHr/+G7P0noCRgh5ySDirztnRVrlT28cGcg==", "0263 6204 8358", false, "a18af42f-2e6c-4ffd-a1f0-49c6e9317cac", null, false, "HaiYen.Vuong@hotmail.com" },
                    { 38, 0, "6095 Phùng Landing", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Hoa%20Tranh%20D%C6%B0%C6%A1ng", null, "d8e4a4a3-989f-4a2d-863b-b738fa587fdb", null, new DateTime(2004, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "DongPhuong_Dinh62@hotmail.com", true, "Hoa Tranh Dương", 2, false, null, "DONGPHUONG_DINH62@HOTMAIL.COM", "DONGPHUONG_DINH62@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEWjNPOYZDuTkSDB1Sdp+0wyCYETelPa/K2YuTZeaxt2La2czrHrndDZ/aXm9CgqIA==", "0255 6190 5267", false, "ecda134f-2192-45bf-8008-fa8263fb110c", null, false, "DongPhuong_Dinh62@hotmail.com" },
                    { 39, 0, "763 Khắc Minh Lodge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C3%90%C3%ACnh%20Thi%E1%BB%87n%20Mai", null, "4044771a-29aa-4208-9435-f4a46877e238", null, new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "VietCuong.Phung3@gmail.com", true, "Ðình Thiện Mai", 3, false, null, "VIETCUONG.PHUNG3@GMAIL.COM", "VIETCUONG.PHUNG3@GMAIL.COM", "AQAAAAIAAYagAAAAEIwU/KsT8o/UnNVc5CE5dERSpE22Eof7npcLYv2d2xjCQtJxl89Ot0NCOitcqJQ/zw==", "0209 9863 5340", false, "091fe986-8686-4f9b-95cc-9382bb50e5ef", null, false, "VietCuong.Phung3@gmail.com" },
                    { 40, 0, "54297 Tô Spur", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%E1%BB%9Dng%20Hi%E1%BB%87p%20T%C3%B4", null, "ce8a369d-5789-4b88-9982-e44eb20c33e2", null, new DateTime(2015, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "ThuyKieu.Truong@yahoo.com", true, "Trường Hiệp Tô", 2, false, null, "THUYKIEU.TRUONG@YAHOO.COM", "THUYKIEU.TRUONG@YAHOO.COM", "AQAAAAIAAYagAAAAEHjW2PwILmmh7gymrLdVCfiaY3dfyu+BVE6/ivAErqr8DaytgQfM3msRpkIHvnl5uw==", "029 3048 4935", false, "d6acb039-9cb5-465e-9c6b-9bb85d307a0b", null, false, "ThuyKieu.Truong@yahoo.com" },
                    { 41, 0, "33127 Phan Club", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=C%C3%B4ng%20L%C3%BD%20V%C5%A9", null, "1e0b03fa-6ec1-4df8-8792-4f3b151e1af1", null, new DateTime(2006, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "NamPhuong4@gmail.com", true, "Công Lý Vũ", 3, false, null, "NAMPHUONG4@GMAIL.COM", "NAMPHUONG4@GMAIL.COM", "AQAAAAIAAYagAAAAEJjM+4Ld06/jr034t4P1V05i4Q3h8s/gO5ppTYsj62hnr7pJYtZeOq7eqxpiZE+zKA==", "023 3357 9356", false, "2dd09467-4a7e-4eda-9c21-4f066b9866e4", null, false, "NamPhuong4@gmail.com" },
                    { 42, 0, "0966 Hải Uyên Causeway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%E1%BB%9Dng%20Hi%E1%BB%87p%20T%C3%B4", null, "c457e402-8c6f-4f6b-9b80-0b414fe7f846", null, new DateTime(1995, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "QuocHien_Ly8@gmail.com", true, "Trường Hiệp Tô", 2, false, null, "QUOCHIEN_LY8@GMAIL.COM", "QUOCHIEN_LY8@GMAIL.COM", "AQAAAAIAAYagAAAAEHOqQx9Yr26ma1bhKswe+qQilGm3Qdt9VnCnAFWFG22ZHUF1Loaib2fSv8GUF7MvIA==", "0202 2672 5742", false, "58b681f6-78b3-40d7-84ff-9750fa9cff96", null, false, "QuocHien_Ly8@gmail.com" },
                    { 43, 0, "84859 Trúc Quỳnh Crossing", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tuy%E1%BA%BFt%20Tr%E1%BA%A7m%20L%C3%AA", null, "4834e7a2-17fc-41c1-92f7-6720904e2734", null, new DateTime(2000, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "HanhTuong.Lam@hotmail.com", true, "Tuyết Trầm Lê", 2, false, null, "HANHTUONG.LAM@HOTMAIL.COM", "HANHTUONG.LAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPV0JREJrW14QAR2+CGKih8k9AnNhT72U6TIhI7+Rc0CQEXxgSUpMtyFe67k60GQCQ==", "026 2090 9393", false, "ba86920c-8601-4f36-b8b4-005331b48031", null, false, "HanhTuong.Lam@hotmail.com" },
                    { 44, 0, "3546 Phạm Port", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Quang%20T%C3%BA%20%C4%90%E1%BB%97", null, "8edd3937-c8e7-408d-acdc-eb18473fea1a", null, new DateTime(2016, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "YenThanh_Doan30@gmail.com", true, "Quang Tú Đỗ", 1, false, null, "YENTHANH_DOAN30@GMAIL.COM", "YENTHANH_DOAN30@GMAIL.COM", "AQAAAAIAAYagAAAAEOTw7DME7bfdNvGg10rAdXr2y65933k4GiIOQgYdPJjWBX79GfzVSosAHcn7pjv2qg==", "029 8109 1004", false, "b97510ab-9505-4796-a514-b5614b08a8a2", null, false, "YenThanh_Doan30@gmail.com" },
                    { 45, 0, "9878 Mai Place", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%E1%BA%A3o%20Ng%E1%BB%8Dc%20Tr%C6%B0%C6%A1ng", null, "6c3ec578-3696-453a-a4bd-ec439bc75db1", null, new DateTime(1998, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "PhuongYen_Bui@yahoo.com", true, "Bảo Ngọc Trương", 3, false, null, "PHUONGYEN_BUI@YAHOO.COM", "PHUONGYEN_BUI@YAHOO.COM", "AQAAAAIAAYagAAAAEHHI9VO2FbCvT1CSEHHn+bYTOR8fM1ZzdlN8IxdZKJDSDDoeDA1DCU8T46sLZOeE/A==", "0268 1627 8136", false, "b6f43c10-e1e9-4667-aeeb-2332f87faa17", null, false, "PhuongYen_Bui@yahoo.com" },
                    { 46, 0, "17262 Đặng Springs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C6%B0%E1%BB%9Dng%20Nguy%C3%AAn%20D%C6%B0%C6%A1ng", null, "a4113b80-11b9-47c7-aad1-37ae22038b5b", null, new DateTime(2010, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "TuanSy_Nguyen38@yahoo.com", true, "Tường Nguyên Dương", 1, false, null, "TUANSY_NGUYEN38@YAHOO.COM", "TUANSY_NGUYEN38@YAHOO.COM", "AQAAAAIAAYagAAAAEKRGqXOOyfFB04sWkTW3vXQ+a2pHGWKDuXt1jHDjNOw1vPJMUsSym+81e6Bl6HU2ig==", "025 9142 7593", false, "13c4b448-3a8a-4a79-8ce5-562ad97137fb", null, false, "TuanSy_Nguyen38@yahoo.com" },
                    { 47, 0, "6041 Ngô Plaza", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Giang%20Thanh%20Tr%E1%BB%8Bnh", null, "37f13d17-c018-414f-9fa5-b6fe047c2647", null, new DateTime(2002, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "ThatCuong_Hoang@yahoo.com", true, "Giang Thanh Trịnh", 3, false, null, "THATCUONG_HOANG@YAHOO.COM", "THATCUONG_HOANG@YAHOO.COM", "AQAAAAIAAYagAAAAEEQuMBPHrPGylJYEsKZUtj+zNbSKIMY6ZC/4J+W4at8CPQOpm7n5y9s4vPo50XJLfg==", "029 7085 8905", false, "434fb55d-05d0-465c-83e1-f7a668dda567", null, false, "ThatCuong_Hoang@yahoo.com" },
                    { 48, 0, "06724 Hồ Rest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Duy%C3%AAn%20N%C6%B0%C6%A1ng%20V%C6%B0%C6%A1ng", null, "ceae58c1-bd00-4879-9f91-14e287d75bad", null, new DateTime(2000, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), "DinhLuan_To2@hotmail.com", true, "Duyên Nương Vương", 2, false, null, "DINHLUAN_TO2@HOTMAIL.COM", "DINHLUAN_TO2@HOTMAIL.COM", "AQAAAAIAAYagAAAAEF/s2PDJklZr7kLjYFps+mgpyW9ux2qM2QdXNz9COIxbF1vFDt08i819WGFzwPHTnw==", "0262 1259 4359", false, "797bd511-613b-49fb-aa33-e299dceac26f", null, false, "DinhLuan_To2@hotmail.com" },
                    { 49, 0, "62606 Vũ Brooks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Loan%20Ch%C3%A2u%20T%C4%83ng", null, "b9b85818-9581-4f80-947b-cc587f7cc76a", null, new DateTime(2016, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "MinhVy.Ly@gmail.com", true, "Loan Châu Tăng", 1, false, null, "MINHVY.LY@GMAIL.COM", "MINHVY.LY@GMAIL.COM", "AQAAAAIAAYagAAAAEKequIumZnoyK4Um3d9++bdlbAo6Oq2iTwy/PoQlyysyVCOveXPAgN/16tKJRIDRGA==", "020 6217 0416", false, "39d7f45f-2f0a-47b2-9460-6d04e5d391aa", null, false, "MinhVy.Ly@gmail.com" },
                    { 50, 0, "66300 Quang Thuận Harbors", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C6%B0%C6%A1ng%20Trinh%20Ng%C3%B4", null, "eb5565cd-faa4-48d8-a900-a791d1afc58e", null, new DateTime(2006, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "SongKe62@yahoo.com", true, "Phương Trinh Ngô", 3, false, null, "SONGKE62@YAHOO.COM", "SONGKE62@YAHOO.COM", "AQAAAAIAAYagAAAAEHaiPlnidKp5ONLTcE0Vq+k+3xI+fxi0bXxVtJi5WCnEaEVvbvAucfbVDGR/77w5oQ==", "0213 9729 9431", false, "89753f23-8421-49a8-bc02-c7337daf7116", null, false, "SongKe62@yahoo.com" },
                    { 51, 0, "2735 Vũ Mill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%ADch%20Tr%C3%A2m%20V%C6%B0%C6%A1ng", null, "86b7370d-ce5b-476d-a04d-fbbbd3d5dd61", null, new DateTime(2016, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "DongDuong_Dao6@hotmail.com", true, "Bích Trâm Vương", 1, false, null, "DONGDUONG_DAO6@HOTMAIL.COM", "DONGDUONG_DAO6@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBcRKIR4U7JPyUsFBovkkxK/gIId5ReT5Rdckz7290dHKXVOd2bVwohVFcyw81lv3A==", "0271 2196 8909", false, "e7b0c7db-7afc-461f-9e64-a09a21b558bd", null, false, "DongDuong_Dao6@hotmail.com" },
                    { 52, 0, "39522 Trịnh Underpass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Di%E1%BB%85m%20Quy%C3%AAn%20D%C6%B0%C6%A1ng", null, "3c2d7b8c-7b85-4505-b010-224bdaf7658d", null, new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "NguyenGiap_Vu99@yahoo.com", true, "Diễm Quyên Dương", 2, false, null, "NGUYENGIAP_VU99@YAHOO.COM", "NGUYENGIAP_VU99@YAHOO.COM", "AQAAAAIAAYagAAAAEG7jc45rOGi8QrM8FuTqSPbfogpL20KHIWlxfpCQnYLVs3G16L3nYjQ+Smmgo1vYWw==", "0297 8876 3706", false, "694ad6a0-7f9d-483d-aed8-356dbd266bfd", null, false, "NguyenGiap_Vu99@yahoo.com" },
                    { 53, 0, "6688 Mạnh Thiện Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C3%AD%20Minh%20Tr%E1%BB%8Bnh", null, "e191b558-9e80-47bd-9fe7-b8e370b18ee2", null, new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "ThuyDiem_Phan@yahoo.com", true, "Trí Minh Trịnh", 1, false, null, "THUYDIEM_PHAN@YAHOO.COM", "THUYDIEM_PHAN@YAHOO.COM", "AQAAAAIAAYagAAAAENwT2kdWvyl90eBtMfqB5LczOpCEmdF7iF5E33SYIRqwaZ2gSzctUd7K0jW0qqe0FQ==", "020 2438 6767", false, "20f2f80b-1837-4b35-a07d-313984bfbf04", null, false, "ThuyDiem_Phan@yahoo.com" },
                    { 54, 0, "98695 Trương Garden", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90an%20Thu%20Tr%C6%B0%C6%A1ng", null, "e164e440-de63-428f-bd43-92164be3bbdd", null, new DateTime(2010, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "HaiUyen.Pham@hotmail.com", true, "Đan Thu Trương", 1, false, null, "HAIUYEN.PHAM@HOTMAIL.COM", "HAIUYEN.PHAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEP2c0MkI5IaVX+JTNdlXUzEuHqs2W5TL/yc3zoIgfkcOZD2bB7WgPQ6Xo8K7zPvXFw==", "023 6513 7900", false, "8580d0b6-e840-480d-a700-7f024ad76784", null, false, "HaiUyen.Pham@hotmail.com" },
                    { 55, 0, "50577 Trần Corner", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Cao%20Minh%20V%C6%B0%C6%A1ng", null, "525ad8aa-264a-4812-a79e-113872430612", null, new DateTime(2006, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "NguyetQue19@yahoo.com", true, "Cao Minh Vương", 1, false, null, "NGUYETQUE19@YAHOO.COM", "NGUYETQUE19@YAHOO.COM", "AQAAAAIAAYagAAAAEN4KEd0yGk5Q3R1RtHeauUoObayqGgxsRGdeZxG6vf0mL5x8W3P1oWllBUcxhI4sUQ==", "0298 2150 6036", false, "fdd2f0c6-8f50-4e51-8a14-3a852221331d", null, false, "NguyetQue19@yahoo.com" },
                    { 56, 0, "85719 Phùng Shores", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0n%20Ki%E1%BA%BFm%20%C4%90o%C3%A0n", null, "f5642e9c-7a13-4c59-9d76-326bf00a4ddd", null, new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "VienPhuong60@gmail.com", true, "Hoàn Kiếm Đoàn", 3, false, null, "VIENPHUONG60@GMAIL.COM", "VIENPHUONG60@GMAIL.COM", "AQAAAAIAAYagAAAAEAd+Pt6Xv3Plv/mYtfBEVeJPqBeck1WTjD/nFFxkqKah3efFg3iFpVkl3FaFGQGKDQ==", "0223 6286 8479", false, "77308216-dead-4649-b9f5-2d03af0ada17", null, false, "VienPhuong60@gmail.com" },
                    { 57, 0, "43619 Đỗ Canyon", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C3%90inh%20H%C6%B0%C6%A1ng%20Ng%C3%B4", null, "02d02bf3-30d9-464b-8650-e8e85288927d", null, new DateTime(1998, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "PhuongLien_Le40@gmail.com", true, "Ðinh Hương Ngô", 2, false, null, "PHUONGLIEN_LE40@GMAIL.COM", "PHUONGLIEN_LE40@GMAIL.COM", "AQAAAAIAAYagAAAAEFjN8jc/PD/Hry2TdTeE1+568hHnDAifukpC1vY8iJh4iBeSj4SSgothrQRu8/qPUA==", "0220 6663 3514", false, "d0ca865b-b39f-4e94-a18f-df9773ae3c27", null, false, "PhuongLien_Le40@gmail.com" },
                    { 58, 0, "09010 Đan Linh Mountain", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Hoa%20Tranh%20L%C3%BD", null, "73bfcfdb-ccf4-4c9e-a897-2b3a126b55ff", null, new DateTime(2003, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "LeBang_Mai@hotmail.com", true, "Hoa Tranh Lý", 3, false, null, "LEBANG_MAI@HOTMAIL.COM", "LEBANG_MAI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHarZgl7pUMThX93ug2Suuix6wtxG5ylC3d9Nl//xrJVw536Bd8yTo5MBvPz/vNuQw==", "026 1717 6488", false, "83318fbc-35d2-41dd-93bf-d7eca76a0f99", null, false, "LeBang_Mai@hotmail.com" },
                    { 59, 0, "8538 Trung Ðức Way", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Kh%C3%A1nh%20Nam%20T%C4%83ng", null, "91d76419-276a-4282-a9b6-97755f2491a7", null, new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "MinhDan_Pham41@hotmail.com", true, "Khánh Nam Tăng", 2, false, null, "MINHDAN_PHAM41@HOTMAIL.COM", "MINHDAN_PHAM41@HOTMAIL.COM", "AQAAAAIAAYagAAAAEF/MyhOSeNWAzGdmftuTd8gjr2UXTg0UKD7et6QDYVHEtMG4A+bSztFeN6ZLrAa6Mg==", "0252 8121 4181", false, "4672306e-470f-4709-ae5f-d25575640eaa", null, false, "MinhDan_Pham41@hotmail.com" },
                    { 60, 0, "6074 Thiện Minh Drive", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=C%C3%B4ng%20Lu%E1%BA%ADn%20Tr%C6%B0%C6%A1ng", null, "609251fc-abb7-426c-b1cb-331ce969f2f4", null, new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "UyenPhuong.Tran@hotmail.com", true, "Công Luận Trương", 3, false, null, "UYENPHUONG.TRAN@HOTMAIL.COM", "UYENPHUONG.TRAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPCmFbka7recrXY2JAmiHPlKh4itVRC+U5dSU8cE4edjIP8aLhAX8CZjYTnES2kYaQ==", "022 5817 0820", false, "67189a0f-616d-4497-b717-ce0a501c3f76", null, false, "UyenPhuong.Tran@hotmail.com" },
                    { 61, 0, "183 Thu Oanh Loop", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Kim%20Th%C6%B0%20T%C3%B4", null, "7e22d4cc-0145-48ff-a78a-51d91d65df30", null, new DateTime(2000, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "TruongAn_Phung@hotmail.com", true, "Kim Thư Tô", 2, false, null, "TRUONGAN_PHUNG@HOTMAIL.COM", "TRUONGAN_PHUNG@HOTMAIL.COM", "AQAAAAIAAYagAAAAENR3MyYdpoCAamGpjHEUA63u83CQ1FEfY597eiTBUUcERsd+F2thSi5mCVHq7rg8FA==", "0252 7630 8372", false, "f57a79c4-cef9-4e72-abe4-6cdaf2a075dc", null, false, "TruongAn_Phung@hotmail.com" },
                    { 62, 0, "86084 Đỗ Brook", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Hi%E1%BB%81n%20Chung%20Tr%C6%B0%C6%A1ng", null, "0fa80425-3acc-43cb-91ac-b5711ffe564f", null, new DateTime(2014, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), "TanTrinh5@gmail.com", true, "Hiền Chung Trương", 2, false, null, "TANTRINH5@GMAIL.COM", "TANTRINH5@GMAIL.COM", "AQAAAAIAAYagAAAAEHSmwbFOSDkyoDdVfZNbVWCJ3qwxZE1Jl3guCvW3/kR0v0zIWH9SNvAsdAlBkGquQw==", "024 5051 4999", false, "d38097b2-f084-4924-a55d-59104b8d43bd", null, false, "TanTrinh5@gmail.com" },
                    { 63, 0, "8735 Ngô Parkway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C6%B0%C6%A1ng%20Linh%20H%C3%A0", null, "e3efa44c-dbaa-4164-960a-8ec1796cf9b1", null, new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "ThienLam_Lam89@yahoo.com", true, "Phương Linh Hà", 2, false, null, "THIENLAM_LAM89@YAHOO.COM", "THIENLAM_LAM89@YAHOO.COM", "AQAAAAIAAYagAAAAEJ+MUMIzsARhWzxMj04NzU2lY+3IRNkHY7AawB1kEj1vKJbmnE4fMHHtwNzpbwwi+w==", "027 0072 1123", false, "6f55d800-a1d3-4a93-901c-7bb1488d9883", null, false, "ThienLam_Lam89@yahoo.com" },
                    { 64, 0, "3136 Đỗ Corners", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C3%BAc%20Vy%20H%C3%A0", null, "7a2efe00-dde4-49ea-b96c-aa62ad8f3e1d", null, new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "TuanLinh31@yahoo.com", true, "Trúc Vy Hà", 1, false, null, "TUANLINH31@YAHOO.COM", "TUANLINH31@YAHOO.COM", "AQAAAAIAAYagAAAAEJoZcfN+igtFeF9zXQ/YCDMeTNfmZpk0w5GTUAhOull9xLR7Oalr58uujyV2bDE7kQ==", "0232 2373 5211", false, "89f81096-f012-4fee-a176-a7c656cc7941", null, false, "TuanLinh31@yahoo.com" },
                    { 65, 0, "104 Nguyễn Brook", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%E1%BA%A3o%20H%C3%A2n%20Tr%E1%BA%A7n", null, "245ec13d-1adc-4997-aa78-0f6e47a0e283", null, new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "KhacThanh_Trinh@yahoo.com", true, "Bảo Hân Trần", 3, false, null, "KHACTHANH_TRINH@YAHOO.COM", "KHACTHANH_TRINH@YAHOO.COM", "AQAAAAIAAYagAAAAELiApixpuhqCz0+Qjce3ZzwMxSqwi3hd9oiP9Z3toLffZM3YW3Zss/CJtydl8Mcp0A==", "0213 2572 2842", false, "57fb25be-42e2-49ca-9dec-18271001aefb", null, false, "KhacThanh_Trinh@yahoo.com" },
                    { 66, 0, "34116 Lệ Băng Village", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C3%A3%20Th%E1%BA%A3o%20H%C3%A0", null, "9d8af353-9196-4d31-92b0-cd7eb38a3238", null, new DateTime(2012, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "KhacTrong.Bui@hotmail.com", true, "Dã Thảo Hà", 3, false, null, "KHACTRONG.BUI@HOTMAIL.COM", "KHACTRONG.BUI@HOTMAIL.COM", "AQAAAAIAAYagAAAAELMMxUPctHcF0PwUAx0Z+4JGrPyV+jLd/D+/EnmpHg/qbOPH0a303fmZqowwyRd3xw==", "0296 7610 6067", false, "979ca585-efd8-46a1-afdb-30cc074a8898", null, false, "KhacTrong.Bui@hotmail.com" },
                    { 67, 0, "287 Ngọc Hạ Hills", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Nam%20Tr%E1%BB%8Bnh", null, "3afabaab-df3b-4e23-998f-b82b5fd2e58e", null, new DateTime(2002, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "TuyAnh_Ho@gmail.com", true, "Hoàng Nam Trịnh", 2, false, null, "TUYANH_HO@GMAIL.COM", "TUYANH_HO@GMAIL.COM", "AQAAAAIAAYagAAAAEKYl56dpbC6cRj3l7gk6pCDTgruKU81p5J6ASBo43dElWWQJNWfwhPomTR9/x8RFOw==", "0276 1893 1430", false, "b4a72070-6169-40da-9fa8-723c71b1d50e", null, false, "TuyAnh_Ho@gmail.com" },
                    { 68, 0, "707 Hữu Nghĩa Points", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20H%E1%BA%A3i%20An%20T%C3%B4", null, "64023e21-2f27-44e6-ae0d-48bcff409b2d", null, new DateTime(2015, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "XuanDung.Trinh@hotmail.com", true, "Nguyễn Hải An Tô", 1, false, null, "XUANDUNG.TRINH@HOTMAIL.COM", "XUANDUNG.TRINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPrE+sdsXz4hBo3Mko4IW+BRuGmWyvmmyr5HW+qjSIvui0TrXDX8T2zdXudSVEbt6g==", "023 9825 1785", false, "d6df9b06-29f8-4f80-86c9-09a02736efda", null, false, "XuanDung.Trinh@hotmail.com" },
                    { 69, 0, "5993 Ðông Quân Cliffs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tu%E1%BA%A5n%20S%E1%BB%B9%20L%C3%AA", null, "a9ed9f6b-31f6-48e8-8bdb-5de720d21612", null, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "DucPhi61@gmail.com", true, "Tuấn Sỹ Lê", 3, false, null, "DUCPHI61@GMAIL.COM", "DUCPHI61@GMAIL.COM", "AQAAAAIAAYagAAAAEK23A3+PbWowvhbe7XZE16zl8UkN2y0aqDvQ7TtDSi4v+pcvR9bVqzdubvkjnU3HAg==", "0229 2828 6894", false, "bd117d55-9c7e-49d8-b473-34d47de38edb", null, false, "DucPhi61@gmail.com" },
                    { 70, 0, "683 An Tường Drives", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Lan%20Khu%C3%AA%20L%C3%AA", null, "c7963ed1-652c-446d-8b73-68584fa26df2", null, new DateTime(2006, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "KimThong.Dao5@hotmail.com", true, "Lan Khuê Lê", 1, false, null, "KIMTHONG.DAO5@HOTMAIL.COM", "KIMTHONG.DAO5@HOTMAIL.COM", "AQAAAAIAAYagAAAAEOl+8GrgI5Z6w+G7AFDPNWZWPTgKdk45cMxDSSVTCky3i3n2fbcv2olKNaZftNA8VA==", "027 4269 7818", false, "3fde0f6b-d113-4c44-94d6-72c01652e975", null, false, "KimThong.Dao5@hotmail.com" },
                    { 71, 0, "90091 Đinh Lake", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BA%A3o%20Nhi%20H%E1%BB%93", null, "0c5b3e99-7b38-4570-9d8b-335c99f0f2d4", null, new DateTime(2016, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "DanhVan.Dinh85@gmail.com", true, "Hảo Nhi Hồ", 2, false, null, "DANHVAN.DINH85@GMAIL.COM", "DANHVAN.DINH85@GMAIL.COM", "AQAAAAIAAYagAAAAEEDvjOTzdze1/JdV6d8hYl7iCz68JSWj/shjsaUGEA6h/cFvOGXfz3Gvzqh6D4hMcw==", "027 8822 6651", false, "e13ee37a-7d06-47c9-8248-e3c08a26f692", null, false, "DanhVan.Dinh85@gmail.com" },
                    { 72, 0, "3661 Mai Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Minh%20Ho%C3%A0ng%20Ng%C3%B4", null, "adf49ba8-59a1-4550-a1e5-c7f33b33996c", null, new DateTime(2000, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "PhucLe.Tran@hotmail.com", true, "Minh Hoàng Ngô", 1, false, null, "PHUCLE.TRAN@HOTMAIL.COM", "PHUCLE.TRAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHQJFEMfNQqQEP2YZ9orMnyrUlKE8o4gHOJgIsPbwcSM4M/ktwJ2OMUubM7O6ghqEw==", "0266 2730 8768", false, "156097bc-4ae8-472f-9c6f-f91514adfce6", null, false, "PhucLe.Tran@hotmail.com" },
                    { 73, 0, "3982 Hoài Giang Plains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Y%E1%BA%BFn%20Mai%20Ph%E1%BA%A1m", null, "90b87d04-6f74-40f1-b6ea-2ce7da37c265", null, new DateTime(2009, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "TrongKien_Vu@hotmail.com", true, "Yến Mai Phạm", 3, false, null, "TRONGKIEN_VU@HOTMAIL.COM", "TRONGKIEN_VU@HOTMAIL.COM", "AQAAAAIAAYagAAAAELtkSnWoI/BL6s8hvi+Y3TlI2U49TN2bez+ThHQCTZFy5S5C5vzRk8Way6EwF+VWZg==", "0295 2212 0392", false, "5da0f0e2-1a12-40b2-8086-8303bc8fa172", null, false, "TrongKien_Vu@hotmail.com" },
                    { 74, 0, "25265 Trương Knoll", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BA%A3i%20Th%E1%BA%A3o%20%C4%90%C3%A0o", null, "70b214a0-ef3a-48f1-ad2e-868323f7dbb1", null, new DateTime(1995, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "ThuyUyen.To86@hotmail.com", true, "Hải Thảo Đào", 2, false, null, "THUYUYEN.TO86@HOTMAIL.COM", "THUYUYEN.TO86@HOTMAIL.COM", "AQAAAAIAAYagAAAAEB5ilXJ8PnDHkSd72YwYLeo3xki3yOs6lCYt1Nmje7xuqxbzqCnXgwzm2spJzh6Neg==", "028 0493 5714", false, "82156090-56a7-4585-bbff-0bf125656d80", null, false, "ThuyUyen.To86@hotmail.com" },
                    { 75, 0, "99072 Tăng Lodge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%B2a%20Th%C3%A1i%20B%C3%B9i", null, "8682bf3c-fa70-4415-8220-8f3a10ab1b05", null, new DateTime(2014, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "KhanhGiao_Dao@gmail.com", true, "Hòa Thái Bùi", 2, false, null, "KHANHGIAO_DAO@GMAIL.COM", "KHANHGIAO_DAO@GMAIL.COM", "AQAAAAIAAYagAAAAEAIOpV9FbV/kFlM2ZmWfc/k/onO8l5nLxr/9ur3uWnE/fSlsL2ZeLoUCORdgwLqAvQ==", "0260 9605 1838", false, "2624fcb5-2f5a-4b61-80b2-9a8a7e7627e7", null, false, "KhanhGiao_Dao@gmail.com" },
                    { 76, 0, "04214 Bùi Landing", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Dng%20H%C3%A0%20%C4%90o%C3%A0n", null, "19a8843b-d2ba-4036-80e4-6a9cfc092a77", null, new DateTime(2014, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "ManhTuan39@gmail.com", true, "Trọng Hà Đoàn", 1, false, null, "MANHTUAN39@GMAIL.COM", "MANHTUAN39@GMAIL.COM", "AQAAAAIAAYagAAAAEE40kRknnlALiaAqmG/qoK/r2e11xT8inINd+B9gNYS1/RSXdPSPqxQHc7AGnf9zrQ==", "0228 1408 4158", false, "ee48789f-5365-4051-acf5-8a0175959ae3", null, false, "ManhTuan39@gmail.com" },
                    { 77, 0, "640 Cao Thọ Motorway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ki%E1%BA%BFn%20%C3%90%E1%BB%A9c%20%C4%90%C3%A0o", null, "c6ec5ee4-6af6-48c4-9f74-75297e53124c", null, new DateTime(2013, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "HuyenTran_Hoang56@hotmail.com", true, "Kiến Ðức Đào", 1, false, null, "HUYENTRAN_HOANG56@HOTMAIL.COM", "HUYENTRAN_HOANG56@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAI/v1yrrAEV197chJj1RafLNdnKYvY+wR2bsqp0LNdrBLKrabpCgxbbRJC0XPvdDw==", "024 5072 1466", false, "446532ce-3e1a-4703-b11b-0ec64b59dc2e", null, false, "HuyenTran_Hoang56@hotmail.com" },
                    { 78, 0, "080 Phượng Liên Crescent", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=C%C3%A1t%20Ly%20Ng%C3%B4", null, "05d2c36f-069d-441d-b379-11cf115c03eb", null, new DateTime(1994, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "HamDuyen.Pham53@gmail.com", true, "Cát Ly Ngô", 2, false, null, "HAMDUYEN.PHAM53@GMAIL.COM", "HAMDUYEN.PHAM53@GMAIL.COM", "AQAAAAIAAYagAAAAEAF3zsjxOtqoXtxdY4jsLJXCQLVRFfXj2SV+/+uKmzedTQdBfwCx/mdMZVSD9KFqQQ==", "0246 0282 4180", false, "006f0d58-f977-404a-9297-c8d46f0f39c1", null, false, "HamDuyen.Pham53@gmail.com" },
                    { 79, 0, "54299 Hữu Thiện Lane", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Trung%20Hi%E1%BA%BFu%20V%C5%A9", null, "f9209652-2f00-4528-99a4-722be022001c", null, new DateTime(2009, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "CatTien.Doan@yahoo.com", true, "Trung Hiếu Vũ", 3, false, null, "CATTIEN.DOAN@YAHOO.COM", "CATTIEN.DOAN@YAHOO.COM", "AQAAAAIAAYagAAAAEBq1jIibVlCuoX6iM+nxvKd3Ln4yh3VfgfXTty+4UzqtgXbpUu4GTAQifLec/ZkNFg==", "0213 5524 2682", false, "d047a38a-e997-4402-b2b2-1d7171cf064d", null, false, "CatTien.Doan@yahoo.com" },
                    { 80, 0, "278 Hữu Trác Cape", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Loan%20Phan", null, "3fef8ccc-49bc-4b6a-9b3a-c161d14c907b", null, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "ThanhHau90@yahoo.com", true, "Mai Loan Phan", 2, false, null, "THANHHAU90@YAHOO.COM", "THANHHAU90@YAHOO.COM", "AQAAAAIAAYagAAAAEJzhvYeOwKvOGs2NpnNB0p1GpYwemgdJKXB3sOTfGLAbhCHJQgQX6pWIowXv1cA29w==", "028 8799 5022", false, "72f9c869-f8e9-4007-bab8-cc59ec00fb56", null, false, "ThanhHau90@yahoo.com" },
                    { 81, 0, "6699 Hà Roads", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%C3%AAn%20Kh%C3%B4i%20L%C3%A2m", null, "4130ef67-b918-4da3-aff3-20bef090aef2", null, new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "TuanTrung.Nguyen@gmail.com", true, "Nguyên Khôi Lâm", 3, false, null, "TUANTRUNG.NGUYEN@GMAIL.COM", "TUANTRUNG.NGUYEN@GMAIL.COM", "AQAAAAIAAYagAAAAEEejfGfG0tBfQomIxfiY9mbTb6DklHhmc0/pzk3PF7PhieFoYJ3M4rHL9RgUgTHaxA==", "0286 6679 7481", false, "5912d199-e41c-4d6d-9130-dea83cf31703", null, false, "TuanTrung.Nguyen@gmail.com" },
                    { 82, 0, "720 Anh Dũng Mills", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%E1%BA%A1%20H%C6%B0%C6%A1ng%20H%C3%A0", null, "c8258f2d-a758-49e2-90e4-e5705d0fbce8", null, new DateTime(2010, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "DiemPhuoc_Nguyen46@yahoo.com", true, "Dạ Hương Hà", 1, false, null, "DIEMPHUOC_NGUYEN46@YAHOO.COM", "DIEMPHUOC_NGUYEN46@YAHOO.COM", "AQAAAAIAAYagAAAAEAjqBrC/PwoCKI2er3oJgmLQOdhWznNwOu8n6OE9bmH0Zqx3VdoeKyW+1Gm7U6ErZg==", "0294 1624 3985", false, "3fefd346-6b6a-46ae-8dc3-0f0f820b8532", null, false, "DiemPhuoc_Nguyen46@yahoo.com" },
                    { 83, 0, "108 Ngọc Trinh Lake", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Thanh%20%C4%90inh", null, "07cfe983-d55d-462c-85a5-0b110f5bc3da", null, new DateTime(2015, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "HungDao93@gmail.com", true, "Hà Thanh Đinh", 1, false, null, "HUNGDAO93@GMAIL.COM", "HUNGDAO93@GMAIL.COM", "AQAAAAIAAYagAAAAEOcGoB4NTgvGyLTbZC8URUUCuAXNdGsZtCH7ebvYYQVSGGrWjohBSg3uboPky6NNdg==", "0257 2545 5892", false, "7154dc39-212a-429a-9460-abeb51ed4fa3", null, false, "HungDao93@gmail.com" },
                    { 84, 0, "2186 Dương Estates", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C6%B0%C6%A1ng%20Thi%20%C4%90%C3%A0o", null, "afc9995a-7e1e-4bb6-b5e8-d3c098b720e5", null, new DateTime(2010, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), "MinhThao_Dinh@yahoo.com", true, "Phương Thi Đào", 1, false, null, "MINHTHAO_DINH@YAHOO.COM", "MINHTHAO_DINH@YAHOO.COM", "AQAAAAIAAYagAAAAEJhO9eez2NkphQ6rqc+lq+o9fskkjriti3GwHQdg7Y+zqPVjVF5O8Gnod0A7mkj6qw==", "0207 2624 2177", false, "f62c8793-ac3d-45dc-8c63-e275cc247eb1", null, false, "MinhThao_Dinh@yahoo.com" },
                    { 85, 0, "62184 Linh Duyên Camp", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%E1%BA%BF%20N%C4%83ng%20B%C3%B9i", null, "a12f16de-122f-4047-8646-6fa3d77570ea", null, new DateTime(2009, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "HoaThien_Ha@yahoo.com", true, "Thế Năng Bùi", 1, false, null, "HOATHIEN_HA@YAHOO.COM", "HOATHIEN_HA@YAHOO.COM", "AQAAAAIAAYagAAAAEAOCupzqYmVbF12ICKRWGOnKq0rf4LC8KOAggqMxPyJCcWJFRMenss33ryOvrGL9FQ==", "0247 9866 8628", false, "63c7e84f-1506-41a2-b889-25e8c6060f01", null, false, "HoaThien_Ha@yahoo.com" },
                    { 86, 0, "59931 Dương Village", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C3%A2n%20Trang%20Mai", null, "44557ce1-c6d6-4ff3-bd37-3f861a5d8516", null, new DateTime(2013, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "XuanHuy.Trinh@hotmail.com", true, "Vân Trang Mai", 2, false, null, "XUANHUY.TRINH@HOTMAIL.COM", "XUANHUY.TRINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAEI9kfosY5yUStSgb0aE9/v20MoipB10xD01CuRNz1N2S7C4C/BSYwR0EPe3TAkB5bw==", "0217 0327 1560", false, "c6d28933-af0c-44ea-b847-6678c4604184", null, false, "XuanHuy.Trinh@hotmail.com" },
                    { 87, 0, "4142 Hoàng Khang Parkway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=S%E1%BB%B9%20Ho%C3%A0ng%20Tr%C6%B0%C6%A1ng", null, "52fb9e9b-e8b7-443b-8148-e1aececd712f", null, new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), "ChePhuong48@gmail.com", true, "Sỹ Hoàng Trương", 2, false, null, "CHEPHUONG48@GMAIL.COM", "CHEPHUONG48@GMAIL.COM", "AQAAAAIAAYagAAAAEGELXYU9AMBUCKfqdWRqaRySTbE5FKP9MyzIRMtGo9l+czf6b8U/3LMBADfFIrVssg==", "020 5990 4132", false, "9399cf2d-5c40-4a64-9486-338724893a88", null, false, "ChePhuong48@gmail.com" },
                    { 88, 0, "67203 Thiện Ân Cliff", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Song%20Th%C6%B0%20%C4%90o%C3%A0n", null, "6ae8b170-0a51-41ad-aff0-ed33fce21871", null, new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "LeQuyen.Phung47@yahoo.com", true, "Song Thư Đoàn", 3, false, null, "LEQUYEN.PHUNG47@YAHOO.COM", "LEQUYEN.PHUNG47@YAHOO.COM", "AQAAAAIAAYagAAAAEBxiWCRsIMY/a0H8CrpL29ZnTUCDxXes8+ooDyMwxsosOUY+CbR4jO+aRY5U2OAXqw==", "0231 9242 9367", false, "eb50e797-6b52-415a-aded-c5509b897984", null, false, "LeQuyen.Phung47@yahoo.com" },
                    { 89, 0, "57208 Bích Vân Path", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%A2n%20Tr%C3%BAc%20%C4%90%C3%A0o", null, "7515dd07-6274-4638-9cb9-60e7350063be", null, new DateTime(2004, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "KimOanh_Tran@gmail.com", true, "Ngân Trúc Đào", 3, false, null, "KIMOANH_TRAN@GMAIL.COM", "KIMOANH_TRAN@GMAIL.COM", "AQAAAAIAAYagAAAAEFiP3ESAXLEunJWbRZ4Bu4fnYacYsVMAM4YvapfwYZLW3zRhP5uz/QbKp5Iqq/3bUQ==", "026 4384 1817", false, "d0e4cbb7-773a-4551-9d63-277137d13eb8", null, false, "KimOanh_Tran@gmail.com" },
                    { 90, 0, "796 Huy Khiêm Overpass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B9ng%20L%C3%A2m%20%C4%90%C3%A0o", null, "ce30a3cf-e256-4153-a9a6-b302974d5bd4", null, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "DieuThuy_Ly82@yahoo.com", true, "Tùng Lâm Đào", 3, false, null, "DIEUTHUY_LY82@YAHOO.COM", "DIEUTHUY_LY82@YAHOO.COM", "AQAAAAIAAYagAAAAEBUGYVIVv6tlX6KiytEzuiezVENqISFXgJMuMkB9z9yCeV/mdt5w/60QFW2AdEDWkw==", "0297 9516 1637", false, "c5599d76-713b-49c2-b87e-210b5c308239", null, false, "DieuThuy_Ly82@yahoo.com" },
                    { 91, 0, "76386 Trung Nhân Prairie", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nh%C3%A3%20Y%E1%BA%BFn%20H%E1%BB%93", null, "76f29377-0d19-444a-b2a8-a3f5697d5552", null, new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "YBinh22@gmail.com", true, "Nhã Yến Hồ", 1, false, null, "YBINH22@GMAIL.COM", "YBINH22@GMAIL.COM", "AQAAAAIAAYagAAAAELU5k6jfy9hSTWU6NvY9spXPw3z3cVg0G7GmFoVxrx3AnaeShvSd4hF1hMchSdqtDA==", "0264 4539 1824", false, "eb9009a4-3fe6-46f8-a8db-cc168af99fdf", null, false, "YBinh22@gmail.com" },
                    { 92, 0, "3557 Tùng Lâm Circle", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C3%90%C3%ACnh%20Thi%E1%BB%87n%20T%C3%B4", null, "7f1a43cc-5423-4487-83bc-1cbe613d13d7", null, new DateTime(2005, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "GiaBach36@hotmail.com", true, "Ðình Thiện Tô", 1, false, null, "GIABACH36@HOTMAIL.COM", "GIABACH36@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMXHaYPNpb151w6hWUVARVczfrxsfnLfhsoYTGWWOPyzD5UTKLLKWnKKnT6MRW1f8w==", "0245 7519 7740", false, "aba06250-1eb6-4057-bf12-793c645a6fb3", null, false, "GiaBach36@hotmail.com" },
                    { 93, 0, "22322 Nhã Trúc Flats", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Trung%20Ki%C3%AAn%20T%C4%83ng", null, "e93e8489-a27b-4b82-b76e-f4df0f70e85a", null, new DateTime(1998, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "QuangTuan.Lam13@hotmail.com", true, "Trung Kiên Tăng", 2, false, null, "QUANGTUAN.LAM13@HOTMAIL.COM", "QUANGTUAN.LAM13@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKYzwxogOu4uEeh9rcmG+Qzo3U8Zrf5Ys1If1ZPuH1jFOqje5dBWXaYfsBnZqqHONw==", "023 5663 1180", false, "cfa91883-d411-4791-8519-75f047da8278", null, false, "QuangTuan.Lam13@hotmail.com" },
                    { 94, 0, "36779 Phùng Camp", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tuy%E1%BA%BFt%20Vy%20%C4%90%C3%A0o", null, "390f1fcd-7e1e-4cb8-9271-9904d033c529", null, new DateTime(2006, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), "HoaBinh23@hotmail.com", true, "Tuyết Vy Đào", 1, false, null, "HOABINH23@HOTMAIL.COM", "HOABINH23@HOTMAIL.COM", "AQAAAAIAAYagAAAAEB+Jyo8Tw9mH8Cf5b/ScnE54Y5MPj/ZkFr27u1vykvz+VvOQLl8Z3mG2Au/1nLPuXw==", "021 5801 6125", false, "5993f004-5ac8-4b84-84f4-02082770c2fb", null, false, "HoaBinh23@hotmail.com" },
                    { 95, 0, "059 Bình Yên Station", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%E1%BA%A3o%20Ch%E1%BA%A5n%20L%C3%A2m", null, "36a766a2-8f47-4eb3-88c0-c9bccae1a840", null, new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "QuanDuong.Bui@yahoo.com", true, "Bảo Chấn Lâm", 3, false, null, "QUANDUONG.BUI@YAHOO.COM", "QUANDUONG.BUI@YAHOO.COM", "AQAAAAIAAYagAAAAEE5IhMmJhnoGa544FxY/0G7cSewXqqU4FMgY+KneNfjChYFu6T7OZ5e7zM999EbduQ==", "025 4762 9142", false, "33b35c16-6cb6-4871-b58c-798cd422e17a", null, false, "QuanDuong.Bui@yahoo.com" },
                    { 96, 0, "707 Đinh Park", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Kim%20Xu%C3%A2n%20V%C5%A9", null, "2fc866ad-ca58-45ab-8a40-33bd98c2034a", null, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "HuuLong_Le@hotmail.com", true, "Kim Xuân Vũ", 2, false, null, "HUULONG_LE@HOTMAIL.COM", "HUULONG_LE@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAu4pqs3jAoMoETPo5otp8n9vVOAJR1hjly+0XDQCIBkuCzJWMjHof2OuhHiqDyQ+A==", "023 6066 8034", false, "521588b3-0803-44fb-918f-4dae84ed43b5", null, false, "HuuLong_Le@hotmail.com" },
                    { 97, 0, "5666 Thanh Hậu Islands", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tri%E1%BB%87u%20M%E1%BA%ABn%20Ho%C3%A0ng", null, "6b473d33-b4aa-4cb9-995d-a5c05ce8dcbc", null, new DateTime(2008, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "QuynhHuong62@yahoo.com", true, "Triệu Mẫn Hoàng", 2, false, null, "QUYNHHUONG62@YAHOO.COM", "QUYNHHUONG62@YAHOO.COM", "AQAAAAIAAYagAAAAEAtfF3xs/XWKo7APFDNm8fc9dYEBpKUnoCkXEV2KhdjYN++rRkEEO9avtEZnxIHj/Q==", "025 4657 4726", false, "c0024703-c560-445b-b046-28c8c06a6946", null, false, "QuynhHuong62@yahoo.com" },
                    { 98, 0, "631 Tiểu Bảo Spring", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%E1%BB%8Dc%20B%C3%ADch%20B%C3%B9i", null, "66755bea-ca3d-4861-99bf-bce3c970b3d0", null, new DateTime(2014, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "HoaTranh.Nguyen12@hotmail.com", true, "Ngọc Bích Bùi", 3, false, null, "HOATRANH.NGUYEN12@HOTMAIL.COM", "HOATRANH.NGUYEN12@HOTMAIL.COM", "AQAAAAIAAYagAAAAEC1uYHiPvcjI029LN8wzN5EUGr2R2B9dOQTiIh+ZDfm/HvThU77osBjafRgtZ8nhnQ==", "028 6926 2702", false, "7a9f5aa8-e7ed-4926-8ae7-85354b94e71c", null, false, "HoaTranh.Nguyen12@hotmail.com" },
                    { 99, 0, "2461 Trương Knoll", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Uy%C3%AAn%20Th%C6%A1%20Nguy%E1%BB%85n", null, "5725211a-7e6e-4c71-bd10-423ddcc764ec", null, new DateTime(2005, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "HongNhu.Duong5@yahoo.com", true, "Uyên Thơ Nguyễn", 2, false, null, "HONGNHU.DUONG5@YAHOO.COM", "HONGNHU.DUONG5@YAHOO.COM", "AQAAAAIAAYagAAAAEFLCYtS9XDr15aqv5pzo1aHTiabWN72RsDXdSZHadx96EMI8i2JJOhfVX8JfQLVfXA==", "0250 9004 5711", false, "ef60154a-dace-4d6c-9e23-ffe67c9991fc", null, false, "HongNhu.Duong5@yahoo.com" },
                    { 100, 0, "165 Phan Brook", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%E1%BA%A3o%20Hi%E1%BB%83n%20Mai", null, "0f32270a-0908-4871-b9c2-2d4acb240048", null, new DateTime(1996, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "XuanDung_Trinh@yahoo.com", true, "Bảo Hiển Mai", 2, false, null, "XUANDUNG_TRINH@YAHOO.COM", "XUANDUNG_TRINH@YAHOO.COM", "AQAAAAIAAYagAAAAENLK690yN1NCwKtDCzZrBOKqtvv1G4D4ELw28Qei+uZ/LJEBVpl0CvSCmJ3ykb3RPg==", "020 3106 7365", false, "8c45f2d9-61b7-4cdb-ad01-52b56343c916", null, false, "XuanDung_Trinh@yahoo.com" },
                    { 101, 0, "789 Phạm Station", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thanh%20Lan%20Tr%C6%B0%C6%A1ng", null, "0c7e0c04-6709-4671-8cb2-8d7ca6df2f17", null, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "BichTy.Do@hotmail.com", true, "Thanh Lan Trương", 1, false, null, "BICHTY.DO@HOTMAIL.COM", "BICHTY.DO@HOTMAIL.COM", "AQAAAAIAAYagAAAAENQjKAVlG7qkCxBYjt141I3+J+uqCoSx5Jz/CFRJ8EivZuCU0S4R8jqcl/0ESThjLg==", "0256 3842 1311", false, "17890cf9-c37b-407e-abad-bab42108fdcc", null, false, "BichTy.Do@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "About", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "Specialization", "UserId", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1, "Bác sĩ có hơn 7 năm trong lĩnh vực Thần kinh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 4, 2, 7 },
                    { 2, "Bác sĩ có hơn 1 năm trong lĩnh vực Tim mạch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2, 3, 1 },
                    { 3, "Bác sĩ có hơn 3 năm trong lĩnh vực Tim mạch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2, 4, 3 },
                    { 4, "Bác sĩ có hơn 3 năm trong lĩnh vực Tim mạch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2, 5, 3 },
                    { 5, "Bác sĩ có hơn 7 năm trong lĩnh vực Nhi khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 5, 6, 7 },
                    { 6, "Bác sĩ có hơn 10 năm trong lĩnh vực Đa khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1, 7, 10 },
                    { 7, "Bác sĩ có hơn 10 năm trong lĩnh vực Nhi khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 5, 8, 10 },
                    { 8, "Bác sĩ có hơn 4 năm trong lĩnh vực Tim mạch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2, 9, 4 },
                    { 9, "Bác sĩ có hơn 3 năm trong lĩnh vực Đa khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1, 10, 3 },
                    { 10, "Bác sĩ có hơn 6 năm trong lĩnh vực Da liễu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 3, 11, 6 },
                    { 11, "Bác sĩ có hơn 8 năm trong lĩnh vực Da liễu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 3, 12, 8 },
                    { 12, "Bác sĩ có hơn 6 năm trong lĩnh vực Tim mạch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2, 13, 6 },
                    { 13, "Bác sĩ có hơn 7 năm trong lĩnh vực Đa khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1, 14, 7 },
                    { 14, "Bác sĩ có hơn 6 năm trong lĩnh vực Đa khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1, 15, 6 },
                    { 15, "Bác sĩ có hơn 4 năm trong lĩnh vực Nhi khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 5, 16, 4 },
                    { 16, "Bác sĩ có hơn 8 năm trong lĩnh vực Tim mạch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2, 17, 8 },
                    { 17, "Bác sĩ có hơn 2 năm trong lĩnh vực Da liễu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 3, 18, 2 },
                    { 18, "Bác sĩ có hơn 1 năm trong lĩnh vực Da liễu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 3, 19, 1 },
                    { 19, "Bác sĩ có hơn 5 năm trong lĩnh vực Đa khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1, 20, 5 },
                    { 20, "Bác sĩ có hơn 2 năm trong lĩnh vực Da liễu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 3, 21, 2 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 3 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 4 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 5 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 6 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 7 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 8 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 9 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 10 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 11 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 12 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 13 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 14 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 15 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 16 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 17 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 18 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 19 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 20 },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 21 },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 22 },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 23 },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 24 },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 25 },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 26 },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 27 },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 28 },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 29 },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 30 },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 31 },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 32 },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 33 },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 34 },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 35 },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 36 },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 37 },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 38 },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 39 },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 40 },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 41 },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 42 },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 43 },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 44 },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 45 },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 46 },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 47 },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 48 },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 49 },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 50 },
                    { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 51 },
                    { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 52 },
                    { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 53 },
                    { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 54 },
                    { 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 55 },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 56 },
                    { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 57 },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 58 },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 59 },
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 60 },
                    { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 61 },
                    { 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 62 },
                    { 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 63 },
                    { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 64 },
                    { 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 65 },
                    { 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 66 },
                    { 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 67 },
                    { 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 68 },
                    { 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 69 },
                    { 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 70 },
                    { 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 71 },
                    { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 72 },
                    { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 73 },
                    { 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 74 },
                    { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 75 },
                    { 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 76 },
                    { 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 77 },
                    { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 78 },
                    { 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 79 },
                    { 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 80 },
                    { 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 81 },
                    { 82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 82 },
                    { 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 83 },
                    { 84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 84 },
                    { 85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 85 },
                    { 86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 86 },
                    { 87, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 87 },
                    { 88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 88 },
                    { 89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 89 },
                    { 90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 90 },
                    { 91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 91 },
                    { 92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 92 },
                    { 93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 93 },
                    { 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 94 },
                    { 95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 95 },
                    { 96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 96 },
                    { 97, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 97 },
                    { 98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 98 },
                    { 99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 99 },
                    { 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 100 },
                    { 101, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 101 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 2, 19 },
                    { 2, 20 },
                    { 2, 21 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "CreatedAt", "CreatedBy", "DoctorId", "EndTime", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "PatientId", "StartTime", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 44, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 2, new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 93, new TimeSpan(0, 14, 0, 0, 0), 3 },
                    { 3, new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 20, new TimeSpan(0, 13, 0, 0, 0), 1 },
                    { 4, new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 7, new TimeSpan(0, 17, 0, 0, 0), 4 },
                    { 5, new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 77, new TimeSpan(0, 16, 0, 0, 0), 4 },
                    { 6, new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 7, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 7, new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 12, new TimeSpan(0, 17, 0, 0, 0), 2 },
                    { 8, new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 74, new TimeSpan(0, 15, 0, 0, 0), 1 },
                    { 9, new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 79, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 10, new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 39, new TimeSpan(0, 16, 0, 0, 0), 1 },
                    { 11, new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 77, new TimeSpan(0, 17, 0, 0, 0), 2 },
                    { 12, new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 34, new TimeSpan(0, 10, 0, 0, 0), 2 },
                    { 13, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 56, new TimeSpan(0, 13, 0, 0, 0), 4 },
                    { 14, new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 68, new TimeSpan(0, 10, 0, 0, 0), 1 },
                    { 15, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 69, new TimeSpan(0, 15, 0, 0, 0), 4 },
                    { 16, new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 61, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 17, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 36, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 18, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 14, new TimeSpan(0, 13, 0, 0, 0), 4 },
                    { 19, new DateTime(2022, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 1, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 20, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 52, new TimeSpan(0, 16, 0, 0, 0), 3 },
                    { 21, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 40, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 22, new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 94, new TimeSpan(0, 17, 0, 0, 0), 3 },
                    { 23, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 73, new TimeSpan(0, 16, 0, 0, 0), 3 },
                    { 24, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 85, new TimeSpan(0, 8, 0, 0, 0), 0 },
                    { 25, new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 76, new TimeSpan(0, 15, 0, 0, 0), 1 },
                    { 26, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 28, new TimeSpan(0, 13, 0, 0, 0), 1 },
                    { 27, new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 1, new TimeSpan(0, 16, 0, 0, 0), 0 },
                    { 28, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 35, new TimeSpan(0, 17, 0, 0, 0), 3 },
                    { 29, new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 70, new TimeSpan(0, 15, 0, 0, 0), 2 },
                    { 30, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 15, new TimeSpan(0, 13, 0, 0, 0), 3 },
                    { 31, new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 91, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 32, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 2, new TimeSpan(0, 16, 0, 0, 0), 1 },
                    { 33, new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 31, new TimeSpan(0, 11, 0, 0, 0), 4 },
                    { 34, new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 64, new TimeSpan(0, 10, 0, 0, 0), 2 },
                    { 35, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 56, new TimeSpan(0, 16, 0, 0, 0), 1 },
                    { 36, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 56, new TimeSpan(0, 16, 0, 0, 0), 4 },
                    { 37, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 54, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 38, new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 82, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 39, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 94, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 40, new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 76, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 41, new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 21, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 42, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 28, new TimeSpan(0, 13, 0, 0, 0), 0 },
                    { 43, new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 49, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 44, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 46, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 45, new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 75, new TimeSpan(0, 14, 0, 0, 0), 4 },
                    { 46, new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 42, new TimeSpan(0, 17, 0, 0, 0), 3 },
                    { 47, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 50, new TimeSpan(0, 13, 0, 0, 0), 3 },
                    { 48, new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 97, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 49, new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 10, new TimeSpan(0, 11, 0, 0, 0), 4 },
                    { 50, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 78, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 51, new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 31, new TimeSpan(0, 12, 0, 0, 0), 3 },
                    { 52, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 78, new TimeSpan(0, 16, 0, 0, 0), 3 },
                    { 53, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 19, new TimeSpan(0, 15, 0, 0, 0), 1 },
                    { 54, new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 61, new TimeSpan(0, 12, 0, 0, 0), 3 },
                    { 55, new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 98, new TimeSpan(0, 16, 0, 0, 0), 1 },
                    { 56, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 87, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 57, new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 13, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 58, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 73, new TimeSpan(0, 11, 0, 0, 0), 4 },
                    { 59, new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 72, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 60, new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 91, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 61, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 33, new TimeSpan(0, 14, 0, 0, 0), 1 },
                    { 62, new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 72, new TimeSpan(0, 15, 0, 0, 0), 3 },
                    { 63, new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 97, new TimeSpan(0, 13, 0, 0, 0), 3 },
                    { 64, new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 13, new TimeSpan(0, 8, 0, 0, 0), 0 },
                    { 65, new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 60, new TimeSpan(0, 13, 0, 0, 0), 4 },
                    { 66, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 75, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 67, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 61, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 68, new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 100, new TimeSpan(0, 13, 0, 0, 0), 3 },
                    { 69, new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 14, new TimeSpan(0, 16, 0, 0, 0), 1 },
                    { 70, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 101, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 71, new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 83, new TimeSpan(0, 13, 0, 0, 0), 1 },
                    { 72, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 52, new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { 73, new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 87, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 74, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 53, new TimeSpan(0, 16, 0, 0, 0), 4 },
                    { 75, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 96, new TimeSpan(0, 15, 0, 0, 0), 4 },
                    { 76, new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 82, new TimeSpan(0, 13, 0, 0, 0), 2 },
                    { 77, new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 82, new TimeSpan(0, 13, 0, 0, 0), 0 },
                    { 78, new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 70, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 79, new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 71, new TimeSpan(0, 15, 0, 0, 0), 4 },
                    { 80, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 81, new TimeSpan(0, 14, 0, 0, 0), 3 },
                    { 81, new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 36, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 82, new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 22, new TimeSpan(0, 12, 0, 0, 0), 3 },
                    { 83, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 1, new TimeSpan(0, 13, 0, 0, 0), 4 },
                    { 84, new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 90, new TimeSpan(0, 10, 0, 0, 0), 2 },
                    { 85, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 33, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 86, new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 39, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 87, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 44, new TimeSpan(0, 17, 0, 0, 0), 0 },
                    { 88, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 77, new TimeSpan(0, 13, 0, 0, 0), 4 },
                    { 89, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 31, new TimeSpan(0, 17, 0, 0, 0), 4 },
                    { 90, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 94, new TimeSpan(0, 17, 0, 0, 0), 3 },
                    { 91, new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 41, new TimeSpan(0, 16, 0, 0, 0), 4 },
                    { 92, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 11, new TimeSpan(0, 17, 0, 0, 0), 4 },
                    { 93, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 31, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 94, new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 11, new TimeSpan(0, 17, 0, 0, 0), 3 },
                    { 95, new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 42, new TimeSpan(0, 15, 0, 0, 0), 0 },
                    { 96, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 13, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 97, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 54, new TimeSpan(0, 16, 0, 0, 0), 0 },
                    { 98, new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 35, new TimeSpan(0, 14, 0, 0, 0), 2 },
                    { 99, new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 46, new TimeSpan(0, 15, 0, 0, 0), 2 },
                    { 100, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 3, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 101, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 16, new TimeSpan(0, 17, 0, 0, 0), 3 },
                    { 102, new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 56, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 103, new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 32, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 104, new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 10, new TimeSpan(0, 13, 0, 0, 0), 1 },
                    { 105, new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 39, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 106, new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 90, new TimeSpan(0, 15, 0, 0, 0), 0 },
                    { 107, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 45, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 108, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 46, new TimeSpan(0, 17, 0, 0, 0), 2 },
                    { 109, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 4, new TimeSpan(0, 15, 0, 0, 0), 0 },
                    { 110, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 51, new TimeSpan(0, 15, 0, 0, 0), 2 },
                    { 111, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 77, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 112, new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 23, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 113, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 98, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 114, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 15, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 115, new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 18, new TimeSpan(0, 14, 0, 0, 0), 0 },
                    { 116, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 48, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 117, new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 97, new TimeSpan(0, 11, 0, 0, 0), 4 },
                    { 118, new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 60, new TimeSpan(0, 17, 0, 0, 0), 4 },
                    { 119, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 80, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 120, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 61, new TimeSpan(0, 17, 0, 0, 0), 3 },
                    { 121, new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 88, new TimeSpan(0, 15, 0, 0, 0), 0 },
                    { 122, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 95, new TimeSpan(0, 17, 0, 0, 0), 3 },
                    { 123, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 55, new TimeSpan(0, 14, 0, 0, 0), 3 },
                    { 124, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 29, new TimeSpan(0, 13, 0, 0, 0), 0 },
                    { 125, new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 75, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 126, new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 29, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 127, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 15, new TimeSpan(0, 17, 0, 0, 0), 4 },
                    { 128, new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 88, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 129, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 64, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 130, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 3, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 131, new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 34, new TimeSpan(0, 16, 0, 0, 0), 1 },
                    { 132, new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 66, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 133, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 21, new TimeSpan(0, 16, 0, 0, 0), 1 },
                    { 134, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 45, new TimeSpan(0, 13, 0, 0, 0), 3 },
                    { 135, new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 86, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 136, new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 41, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 137, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 69, new TimeSpan(0, 14, 0, 0, 0), 2 },
                    { 138, new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 16, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 139, new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 40, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 140, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 75, new TimeSpan(0, 11, 0, 0, 0), 4 },
                    { 141, new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 44, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 142, new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 58, new TimeSpan(0, 13, 0, 0, 0), 3 },
                    { 143, new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 7, new TimeSpan(0, 16, 0, 0, 0), 1 },
                    { 144, new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 39, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 145, new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 60, new TimeSpan(0, 15, 0, 0, 0), 1 },
                    { 146, new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 46, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 147, new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 84, new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { 148, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 99, new TimeSpan(0, 14, 0, 0, 0), 3 },
                    { 149, new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 19, new TimeSpan(0, 15, 0, 0, 0), 2 },
                    { 150, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 10, new TimeSpan(0, 16, 0, 0, 0), 3 },
                    { 151, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 55, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 152, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 81, new TimeSpan(0, 10, 0, 0, 0), 1 },
                    { 153, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 38, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 154, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 40, new TimeSpan(0, 14, 0, 0, 0), 4 },
                    { 155, new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 84, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 156, new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 47, new TimeSpan(0, 15, 0, 0, 0), 1 },
                    { 157, new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 64, new TimeSpan(0, 11, 0, 0, 0), 4 },
                    { 158, new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 26, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 159, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 78, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 160, new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 76, new TimeSpan(0, 15, 0, 0, 0), 2 },
                    { 161, new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 62, new TimeSpan(0, 17, 0, 0, 0), 2 },
                    { 162, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 37, new TimeSpan(0, 13, 0, 0, 0), 0 },
                    { 163, new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 48, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 164, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 82, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 165, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 98, new TimeSpan(0, 16, 0, 0, 0), 3 },
                    { 166, new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 40, new TimeSpan(0, 10, 0, 0, 0), 1 },
                    { 167, new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 43, new TimeSpan(0, 11, 0, 0, 0), 0 },
                    { 168, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 1, new TimeSpan(0, 9, 0, 0, 0), 4 },
                    { 169, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 89, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 170, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 97, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 171, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 30, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 172, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 18, new TimeSpan(0, 14, 0, 0, 0), 2 },
                    { 173, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 86, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 174, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 78, new TimeSpan(0, 17, 0, 0, 0), 4 },
                    { 175, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 38, new TimeSpan(0, 16, 0, 0, 0), 1 },
                    { 176, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 39, new TimeSpan(0, 14, 0, 0, 0), 2 },
                    { 177, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 85, new TimeSpan(0, 14, 0, 0, 0), 1 },
                    { 178, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 81, new TimeSpan(0, 15, 0, 0, 0), 0 },
                    { 179, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 59, new TimeSpan(0, 16, 0, 0, 0), 0 },
                    { 180, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 92, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 181, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 41, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 182, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 72, new TimeSpan(0, 14, 0, 0, 0), 4 },
                    { 183, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 7, new TimeSpan(0, 17, 0, 0, 0), 2 },
                    { 184, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 56, new TimeSpan(0, 14, 0, 0, 0), 0 },
                    { 185, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 88, new TimeSpan(0, 15, 0, 0, 0), 2 },
                    { 186, new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 33, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 187, new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 62, new TimeSpan(0, 13, 0, 0, 0), 1 },
                    { 188, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 32, new TimeSpan(0, 16, 0, 0, 0), 3 },
                    { 189, new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 68, new TimeSpan(0, 8, 0, 0, 0), 0 },
                    { 190, new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 42, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 191, new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 97, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 192, new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 63, new TimeSpan(0, 10, 0, 0, 0), 2 },
                    { 193, new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 61, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 194, new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 58, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 195, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 1, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 196, new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 10, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 197, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 62, new TimeSpan(0, 11, 0, 0, 0), 2 },
                    { 198, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 12, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 199, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 40, new TimeSpan(0, 13, 0, 0, 0), 1 },
                    { 200, new DateTime(2024, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 93, new TimeSpan(0, 17, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DayOfWeek", "DoctorId", "EndTime", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 1, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 1, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 1, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 1, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 1, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 2, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 2, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 2, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 2, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 2, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 3, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 3, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 3, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 3, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 3, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 3, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 4, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 4, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 4, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 4, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 4, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 4, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 5, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 5, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 5, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 5, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 5, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 5, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 6, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 6, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 6, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 6, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 6, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 6, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 7, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 7, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 7, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 7, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 7, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 7, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 8, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 8, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 8, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 8, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 8, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 8, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 9, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 9, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 9, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 9, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 9, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 9, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 10, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 10, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 10, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 10, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 10, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 10, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 11, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 11, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 11, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 11, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 11, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 11, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 12, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 12, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 12, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 12, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 12, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 12, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 13, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 13, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 13, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 13, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 13, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 13, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 14, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 14, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 14, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 14, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 14, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 14, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 15, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 15, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 87, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 15, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 15, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 15, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 15, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 16, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 16, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 16, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 16, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 16, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 16, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 97, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 17, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 17, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 17, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 17, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 101, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 17, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 102, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 17, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 103, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 18, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 104, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 18, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 105, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 18, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 106, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 18, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 107, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 18, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 108, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 18, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 19, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 110, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 19, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 111, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 19, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 112, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 19, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 113, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 19, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 114, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 19, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 115, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 20, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 116, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 20, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 117, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 20, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 118, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 20, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 119, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 20, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { 120, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 20, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) }
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
                name: "IX_Schedules_DoctorId",
                table: "Schedules",
                column: "DoctorId");

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
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
