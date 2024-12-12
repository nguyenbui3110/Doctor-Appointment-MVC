using System;
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
                    { 1, 0, "Admin Address", null, null, "6a0f2ca6-9df2-46ac-8d9e-81cdd5cc785e", null, null, "admin@gmail.com", true, "Admin", null, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEBfU/USfyQ/nhm8hrYXr27gfDCvWPP3Qqr7s6tjMVmITWbYCnp9iBiylnT59Sqg4Kw==", "123456789", false, "30116e62-96cf-4b80-9bfb-028dc135fe14", null, false, "admin" },
                    { 2, 0, "0098 Hồ Trail", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thanh%20Nh%C3%A0n%20Tr%E1%BB%8Bnh", null, "18f06f76-4782-4c80-9727-6a0f7d1f84f3", null, new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "DuyHung3@hotmail.com", true, "Thanh Nhàn Trịnh", 2, false, null, "DUYHUNG3@HOTMAIL.COM", "DUYHUNG3@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFM9a70IdCKNKlfR17j8vhaBFmIyM+5Cavb9TvnQb/jtsH/hLZfL5MzJALp1DmI1pQ==", "023 8096 2260", false, "66822a06-17ba-494b-80d6-28554da943cf", null, false, "DuyHung3@hotmail.com" },
                    { 3, 0, "764 Ðình Sang Squares", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%E1%BA%A3o%20H%C3%A2n%20Ph%C3%B9ng", null, "da39a95c-68d9-4ad9-a672-e1b19ad12dcc", null, new DateTime(1996, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "MongVi_Trinh@hotmail.com", true, "Bảo Hân Phùng", 1, false, null, "MONGVI_TRINH@HOTMAIL.COM", "MONGVI_TRINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAEF/icVHNoB2KA1GzOxRETtNGKZRsmU3Yp8VLDZI6JHT1RMNKOOjZpgrFgLdlBQCnnw==", "026 9636 6377", false, "d9485a93-3c4d-4280-acd7-992511514c89", null, false, "MongVi_Trinh@hotmail.com" },
                    { 4, 0, "7138 Vương Trail", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%E1%BA%A1%20Nguy%E1%BB%87t%20Ho%C3%A0ng", null, "e47cd393-7507-45fb-a9c6-88a6b683261f", null, new DateTime(2014, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "NhaUyen96@yahoo.com", true, "Dạ Nguyệt Hoàng", 3, false, null, "NHAUYEN96@YAHOO.COM", "NHAUYEN96@YAHOO.COM", "AQAAAAIAAYagAAAAEFxCBlaEn8SEi2Tus1yThtkBPwBm25BfjUTx1WB+9wi4s8Q6quKi5ZbUcDcepkSRig==", "0271 8674 0926", false, "a2fc22dc-ad00-45c8-80c7-776068a953f1", null, false, "NhaUyen96@yahoo.com" },
                    { 5, 0, "5201 Khuyến Học Burg", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%ADch%20%C3%90i%E1%BB%87p%20Nguy%E1%BB%85n", null, "91346b23-0383-4d2c-8e03-56a5463d14c8", null, new DateTime(2007, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "ThienPhu.Trinh44@yahoo.com", true, "Bích Ðiệp Nguyễn", 3, false, null, "THIENPHU.TRINH44@YAHOO.COM", "THIENPHU.TRINH44@YAHOO.COM", "AQAAAAIAAYagAAAAECWHmMxSC5c5qzTfdwSXS9b9cXGLSCVI9mYQJhEdwQTfZHXglOv0S72K1C4Aty++Lw==", "0237 8954 1688", false, "ec954cd7-bc0f-4297-a877-6f98bb1615df", null, false, "ThienPhu.Trinh44@yahoo.com" },
                    { 6, 0, "52239 Vũ Glen", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Anh%20V%C5%A9%20L%C3%AA", null, "98a6db85-b060-4269-8cd3-5b19ad380463", null, new DateTime(2006, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "DucToan_Dao28@gmail.com", true, "Anh Vũ Lê", 1, false, null, "DUCTOAN_DAO28@GMAIL.COM", "DUCTOAN_DAO28@GMAIL.COM", "AQAAAAIAAYagAAAAEJkdEQJDK69TLLa+aXL9HktYUPNK4+LbaxCu4sy3RBGdBFgil++l2XpFjhLC7oLcuQ==", "020 1141 6251", false, "e2363bd9-b005-4fa1-94ec-f9c80441aec5", null, false, "DucToan_Dao28@gmail.com" },
                    { 7, 0, "42065 Tấn Trình Plains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thu%20Thu%E1%BA%ADn%20L%C3%BD", null, "07da8873-db6e-4fab-a181-1162634cb94c", null, new DateTime(2011, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "TrucChi.Lam@gmail.com", true, "Thu Thuận Lý", 2, false, null, "TRUCCHI.LAM@GMAIL.COM", "TRUCCHI.LAM@GMAIL.COM", "AQAAAAIAAYagAAAAEBAHpu5BKhu8CAV+ArYc8QKkWcVXRTqVP4Nt/WEluMTCl6eXYDncVQoXXUVGMrassQ==", "026 5430 9879", false, "03c443f9-f72f-4002-995c-a10f0f5d129c", null, false, "TrucChi.Lam@gmail.com" },
                    { 8, 0, "90451 Xuân Kiên Curve", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Danh%20S%C6%A1n%20%C4%90%C3%A0o", null, "c5040baa-b0d0-4e0d-9a3c-c4b35c985df1", null, new DateTime(2004, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "ThucNhi74@gmail.com", true, "Danh Sơn Đào", 2, false, null, "THUCNHI74@GMAIL.COM", "THUCNHI74@GMAIL.COM", "AQAAAAIAAYagAAAAEHDnbxymklgWfoS4L3Thi9IbxuHJ2pa7ZwRVPEiGmAJ9nT49u0BrtdFS3I5G8XM41g==", "0253 2187 4161", false, "e7fe957b-8b40-492d-9a1f-04ec585e376a", null, false, "ThucNhi74@gmail.com" },
                    { 9, 0, "8134 Vũ Light", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BA%BFt%20%C3%81nh%20%C4%90o%C3%A0n", null, "89aed02d-5086-4c4b-ad59-6dc995521007", null, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), "SonQuyen52@hotmail.com", true, "Nguyết Ánh Đoàn", 1, false, null, "SONQUYEN52@HOTMAIL.COM", "SONQUYEN52@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAjx/MbLjVHD3DpefArxsSIVx6soWTcso4gIHvjqCc0k3ZAfJEd3jJ+i3IKScaI9Gw==", "023 7363 7159", false, "4ee062c3-acfa-4031-9762-d634feb5539b", null, false, "SonQuyen52@hotmail.com" },
                    { 10, 0, "977 Hồng Xuân Centers", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%C3%BAy%20Li%E1%BB%85u%20%C4%90o%C3%A0n", null, "282df4d1-8c47-4854-9c76-48ad3cb0e116", null, new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "HaThanh_Phung@hotmail.com", true, "Thúy Liễu Đoàn", 1, false, null, "HATHANH_PHUNG@HOTMAIL.COM", "HATHANH_PHUNG@HOTMAIL.COM", "AQAAAAIAAYagAAAAECTpQh5d3CL0BsPqdm1TRyOm7+/S2pSj/Sa+gRS0f+wENm8dzJlccPDuzE/A+XtmLQ==", "025 8129 2751", false, "5101a13c-9d91-493d-a36a-127fe696421d", null, false, "HaThanh_Phung@hotmail.com" },
                    { 11, 0, "4104 Quốc Huy Spurs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C6%B0%C6%A1ng%20Th%E1%BB%83%20Tr%C6%B0%C6%A1ng", null, "04b45bc7-3d9d-4a20-8ebe-fbb2498f2804", null, new DateTime(2017, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "BinhDinh_Do41@yahoo.com", true, "Phương Thể Trương", 3, false, null, "BINHDINH_DO41@YAHOO.COM", "BINHDINH_DO41@YAHOO.COM", "AQAAAAIAAYagAAAAEFKCWGoJY2ntG7lJRE8tqslsW7ivkoA4sygnfm5dZRRs61jB4qG7l6EXHodj5uKi7w==", "025 8083 9042", false, "7548c910-4628-45ec-9cee-0f26236b4ad3", null, false, "BinhDinh_Do41@yahoo.com" },
                    { 12, 0, "85084 Ðoan Thanh Pine", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Di%E1%BB%85m%20H%E1%BA%B1ng%20T%C3%B4", null, "93e4a496-b4a2-43c0-9df6-f9533a6a908e", null, new DateTime(2007, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "ThanhDoanh_Mai61@gmail.com", true, "Diễm Hằng Tô", 3, false, null, "THANHDOANH_MAI61@GMAIL.COM", "THANHDOANH_MAI61@GMAIL.COM", "AQAAAAIAAYagAAAAEC6Ty6k/3K/Umv+Ub0qm2lNx1c980ltrqmX1Y+sjATtmklx3n+dI4QNkqWdrb2zvxg==", "027 7832 3306", false, "46c95924-978c-48a9-8171-f537c76d4bb3", null, false, "ThanhDoanh_Mai61@gmail.com" },
                    { 13, 0, "564 Vũ Estates", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Kim%20Quy%C3%AAn%20Tr%E1%BB%8Bnh", null, "1cf72946-1b69-4703-95e6-d442e2ac13af", null, new DateTime(2013, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "KhanhMy_Nguyen10@gmail.com", true, "Kim Quyên Trịnh", 3, false, null, "KHANHMY_NGUYEN10@GMAIL.COM", "KHANHMY_NGUYEN10@GMAIL.COM", "AQAAAAIAAYagAAAAELVMEE/Fh3HxLg7zXdYw09C5PzpQ0dmsN9uMzzyAtiFGESq5k9h90xUB9MpqWvRRQg==", "0273 2918 9250", false, "a6bb754f-807a-44df-89a3-bd7ddd685437", null, false, "KhanhMy_Nguyen10@gmail.com" },
                    { 14, 0, "87994 Hoàng Ford", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=M%E1%BB%99ng%20%C3%90i%E1%BB%87p%20Tr%E1%BA%A7n", null, "7aa365d9-8d43-42d6-bbb6-252ef8b5b9ad", null, new DateTime(2002, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "LienTran25@hotmail.com", true, "Mộng Ðiệp Trần", 2, false, null, "LIENTRAN25@HOTMAIL.COM", "LIENTRAN25@HOTMAIL.COM", "AQAAAAIAAYagAAAAEA8S5meQIS9BsCwwcdd5AGtKzk7zREMkgHVm3pIXliHxCeIfP89fSx/xt5sK1g996Q==", "023 4740 8725", false, "40da2e57-d525-4001-9256-e0f716577ec7", null, false, "LienTran25@hotmail.com" },
                    { 15, 0, "8878 Trâm Anh Knoll", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C3%90%C3%ACnh%20Nh%C3%A2n%20%C4%90%E1%BB%97", null, "9431115c-5025-44a3-b92b-77f3b5d45462", null, new DateTime(2010, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "DieuHoa.Hoang50@hotmail.com", true, "Ðình Nhân Đỗ", 1, false, null, "DIEUHOA.HOANG50@HOTMAIL.COM", "DIEUHOA.HOANG50@HOTMAIL.COM", "AQAAAAIAAYagAAAAEO3hG5fl/ocuIa9M8QV6mYOKRWVkC5oO7zcpFo53FDVJYTGWgu9Nu6EIodfTf7J2OA==", "024 3556 6230", false, "cc6004e7-1676-4608-b62e-a7be4c670fdb", null, false, "DieuHoa.Hoang50@hotmail.com" },
                    { 16, 0, "450 Lập Thành Bypass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C3%A2n%20Khanh%20V%C6%B0%C6%A1ng", null, "3f156c24-9464-4abd-9b60-168ea340d8ad", null, new DateTime(2003, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "NgocNgan17@yahoo.com", true, "Vân Khanh Vương", 3, false, null, "NGOCNGAN17@YAHOO.COM", "NGOCNGAN17@YAHOO.COM", "AQAAAAIAAYagAAAAEIyaylwh0k2VbC7YI8aNNdordwPFxPHJ06VexmhzKUxPI6zU8VQf/P1uBccQiqAx5Q==", "026 5398 5913", false, "fd7b0aa4-bc31-4a63-8c58-a49b3a6e70bc", null, false, "NgocNgan17@yahoo.com" },
                    { 17, 0, "49060 Tăng Roads", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C3%BAc%20Loan%20Ho%C3%A0ng", null, "db74fa46-e240-4453-8f1b-b017f206ff46", null, new DateTime(1997, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "TuyetBang_Hoang@yahoo.com", true, "Trúc Loan Hoàng", 1, false, null, "TUYETBANG_HOANG@YAHOO.COM", "TUYETBANG_HOANG@YAHOO.COM", "AQAAAAIAAYagAAAAEG4y/mi6RXvNt58buxuJL4n30bKv9ZMi8FEN8t8muNogjYJTRS/L2KI41w9LJ9Jq9w==", "0201 4200 2327", false, "6eb54abd-486e-4cb6-977c-31785536812f", null, false, "TuyetBang_Hoang@yahoo.com" },
                    { 18, 0, "619 Diễm Uyên Mill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%C6%B0%C6%A1ng%20Nga%20T%C4%83ng", null, "cc97565d-ea6c-4b46-aa1f-21d882d89fe1", null, new DateTime(2018, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "ThanhLong.Doan@hotmail.com", true, "Thương Nga Tăng", 3, false, null, "THANHLONG.DOAN@HOTMAIL.COM", "THANHLONG.DOAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEOfYPDFcOgf0WoeAmwRJL6sfdmxWOvLcI4ai2OauT0eRUgsoDx2x2J8uElqVIS5UQ==", "0242 8682 5550", false, "edd67e3f-97b0-45da-8d72-038774fb8d1a", null, false, "ThanhLong.Doan@hotmail.com" },
                    { 19, 0, "1998 Đỗ Estate", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Kh%C3%A1nh%20V%C4%83n%20Tr%E1%BB%8Bnh", null, "507d4970-e038-4ba4-bfb0-63128023fdcf", null, new DateTime(2014, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "PhuHung3@gmail.com", true, "Khánh Văn Trịnh", 2, false, null, "PHUHUNG3@GMAIL.COM", "PHUHUNG3@GMAIL.COM", "AQAAAAIAAYagAAAAEFrvL6D4EfiRZRTxkW/HHFRIpLI7D+3P0LWCoCepWYK+i6ka1imdVlw1NRjzIKpabA==", "0252 6588 2633", false, "30b47e80-9645-40d3-b6b5-c1cb036244fd", null, false, "PhuHung3@gmail.com" },
                    { 20, 0, "31141 Thanh Lâm Points", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Minh%20Ng%E1%BB%8Dc%20D%C6%B0%C6%A1ng", null, "8301c0cc-b2d0-434f-83ab-1eada47811b5", null, new DateTime(2007, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "VietThanh_Do53@hotmail.com", true, "Minh Ngọc Dương", 3, false, null, "VIETTHANH_DO53@HOTMAIL.COM", "VIETTHANH_DO53@HOTMAIL.COM", "AQAAAAIAAYagAAAAENyEdXbn6exDpuQij5xmYSQ+JUS1k+0gHWTc7zQz85KIPLXCBglhlqQqRxhGijh3Pg==", "027 5995 4971", false, "804c1094-560f-44a0-856c-e1f8df6a37ba", null, false, "VietThanh_Do53@hotmail.com" },
                    { 21, 0, "3759 Tăng Key", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Dng%20Tr%C3%AD%20Ph%C3%B9ng", null, "b7f7938e-ce0f-434a-9787-c9fd79053bd3", null, new DateTime(2006, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), "PhuongNhi94@yahoo.com", true, "Trọng Trí Phùng", 3, false, null, "PHUONGNHI94@YAHOO.COM", "PHUONGNHI94@YAHOO.COM", "AQAAAAIAAYagAAAAEP9TYNITXkKsyok6zrH/GZsGwjYOX/wGTSGGFA/ZWcYUOFNWqKRj3zwYLHLMJfhLiA==", "020 3579 4104", false, "7e5caba1-ab15-4cce-a1bd-5af6489f9ec1", null, false, "PhuongNhi94@yahoo.com" },
                    { 22, 0, "9583 Hạ Phương Squares", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0i%20Trang%20T%C4%83ng", null, "37bd82d6-9d44-4154-9ebb-aeb73abfe0fd", null, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), "ThienHa40@gmail.com", true, "Đài Trang Tăng", 2, false, null, "THIENHA40@GMAIL.COM", "THIENHA40@GMAIL.COM", "AQAAAAIAAYagAAAAEN2srZyA3ajNf6ElRkRE4/Qj5RDWGUQegDl0RgaFT913xGkP7uYUYsh805cJPA8UeA==", "025 5866 9477", false, "deb8c50c-87dd-41e2-9bef-5633b6505ae5", null, false, "ThienHa40@gmail.com" },
                    { 23, 0, "22450 Lâm Forks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C3%BAc%20Qu%E1%BB%B3nh%20B%C3%B9i", null, "e8382ea6-3175-4425-9245-5959e6ccdafb", null, new DateTime(2016, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "TheQuyen_To14@yahoo.com", true, "Trúc Quỳnh Bùi", 1, false, null, "THEQUYEN_TO14@YAHOO.COM", "THEQUYEN_TO14@YAHOO.COM", "AQAAAAIAAYagAAAAEIJCk2uoEfQK9FWvfdsqZZvtFR4hokjoKExjGLy4feBhgj+Wjedtw2iSbLThbea8vA==", "020 1360 5377", false, "710c075c-7591-4477-a706-f12a7d30963a", null, false, "TheQuyen_To14@yahoo.com" },
                    { 24, 0, "33293 Diệu Ngọc Street", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%E1%BB%AB%20%C3%82n%20T%C4%83ng", null, "c929c3b9-bd95-4f29-817b-cdf24311b430", null, new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "BaoLan.Phung88@gmail.com", true, "Từ Ân Tăng", 1, false, null, "BAOLAN.PHUNG88@GMAIL.COM", "BAOLAN.PHUNG88@GMAIL.COM", "AQAAAAIAAYagAAAAEDUtu+cCzPuiklrgKE3xAQIl1xJ2CxM+6AYLtz0fLjf+iHjnKq8jFV3NO53bln2mPg==", "0298 3511 1843", false, "16bdf93d-2976-48ba-aa88-362db83a1229", null, false, "BaoLan.Phung88@gmail.com" },
                    { 25, 0, "5474 Kim Yến Freeway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=M%E1%BB%B9%20Lan%20L%C3%BD", null, "83de9198-b4ae-4652-9508-2f37c87e91ef", null, new DateTime(2001, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "ThuDuyen_Dao50@hotmail.com", true, "Mỹ Lan Lý", 2, false, null, "THUDUYEN_DAO50@HOTMAIL.COM", "THUDUYEN_DAO50@HOTMAIL.COM", "AQAAAAIAAYagAAAAEP9+trnUVnM26cG5G3jeMKC2VZivKpO/8RUAMSjHt5m+ky+NH7vbOLyfIl4/iYEfog==", "0228 6236 8882", false, "9f19883b-28c9-4c05-975b-5923c64be3ca", null, false, "ThuDuyen_Dao50@hotmail.com" },
                    { 26, 0, "089 Cao Nguyên Parks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Minh%20Vu%20%C4%90%E1%BB%97", null, "3103b1ee-d959-43a8-ab2c-70ee96fc50c1", null, new DateTime(2015, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "QuynhNga19@yahoo.com", true, "Minh Vu Đỗ", 3, false, null, "QUYNHNGA19@YAHOO.COM", "QUYNHNGA19@YAHOO.COM", "AQAAAAIAAYagAAAAEKtcG1zATwJHhO8rS2ieILhizn3VkKuXlOD+gePATMsfh7VcLjpFY9VCT8eVQFlR5Q==", "022 4696 5505", false, "98f912a2-7bb1-4529-8c6a-aba72dfa2104", null, false, "QuynhNga19@yahoo.com" },
                    { 27, 0, "8446 Phạm Cove", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%C3%A0nh%20Danh%20%C4%90%E1%BA%B7ng", null, "dbf0fa64-9926-4a92-9d2c-dd6bddffcc31", null, new DateTime(1998, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "DaThi.Do@hotmail.com", true, "Thành Danh Đặng", 2, false, null, "DATHI.DO@HOTMAIL.COM", "DATHI.DO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGf7WrigfoHDU/UJse5t8ZXA/1W9mrx8ouBb7ZyQEWTEK5i4J1LbVYUXj+P78kmqXA==", "0293 5594 1260", false, "5866d9d3-841b-4e2b-b80c-32ed93dd202a", null, false, "DaThi.Do@hotmail.com" },
                    { 28, 0, "655 Đào Squares", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thanh%20Giang%20Tr%E1%BB%8Bnh", null, "4e6d1c09-c322-418c-b126-4c58e17fac00", null, new DateTime(2015, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "TruongThanh.Mai@gmail.com", true, "Thanh Giang Trịnh", 2, false, null, "TRUONGTHANH.MAI@GMAIL.COM", "TRUONGTHANH.MAI@GMAIL.COM", "AQAAAAIAAYagAAAAELhxPiDSW0DV5tXqFXl74AT8XUJbjvXUD5A6DgWN2EC86NDP4hmmN6HlbX5uqsz8lQ==", "025 0700 8628", false, "20122545-5ffd-4645-8f36-79798a912ff6", null, false, "TruongThanh.Mai@gmail.com" },
                    { 29, 0, "562 Thảo Nhi Gateway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Dng%20Nh%C3%A2n%20Ho%C3%A0ng", null, "c54ecd67-2f1d-43e2-8815-b711449e1921", null, new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "KimTuyen_Trinh@yahoo.com", true, "Trọng Nhân Hoàng", 3, false, null, "KIMTUYEN_TRINH@YAHOO.COM", "KIMTUYEN_TRINH@YAHOO.COM", "AQAAAAIAAYagAAAAEGg8goTfTf61N/e7toX9+PfeSMFsp/83QhVlDZgprwKnJCjwhwot6sGkdJ+lgmbPxw==", "025 4344 1930", false, "ef5887b2-115e-4cac-8a9f-b818c509313c", null, false, "KimTuyen_Trinh@yahoo.com" },
                    { 30, 0, "9557 Xuân Vũ Islands", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%C6%B0%E1%BB%A3ng%20C%C6%B0%E1%BB%9Dng%20T%C4%83ng", null, "84c2a0b5-64aa-405b-b2da-8cb11ba531a3", null, new DateTime(2015, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "MyHanh_Tran69@hotmail.com", true, "Thượng Cường Tăng", 2, false, null, "MYHANH_TRAN69@HOTMAIL.COM", "MYHANH_TRAN69@HOTMAIL.COM", "AQAAAAIAAYagAAAAEG00qSUrqXA3yo0ouwzgIfXxVanaJfuOxCUcijMvwJan0+Jg9Dj2OwV8yNu925uwlQ==", "0220 9006 5709", false, "b375244d-e324-48b8-a18b-efd97e6a93a6", null, false, "MyHanh_Tran69@hotmail.com" },
                    { 31, 0, "81398 Thiện Dũng Plaza", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Xu%C3%A2n%20Hoa%20H%E1%BB%93", null, "1d30e8fb-e066-4176-9125-517df10254da", null, new DateTime(2019, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "ThuYen_Phan@yahoo.com", true, "Xuân Hoa Hồ", 1, false, null, "THUYEN_PHAN@YAHOO.COM", "THUYEN_PHAN@YAHOO.COM", "AQAAAAIAAYagAAAAEEKkZRSH1bhuvDVakmC/EdnT38ED1UB+4Pc+M2HhuirTGE9hNy/3bRvEebpac+7gZA==", "028 0505 6477", false, "18a2e777-a1d3-4efe-874d-277d4ae42c05", null, false, "ThuYen_Phan@yahoo.com" },
                    { 32, 0, "5712 Bùi Crossing", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%C3%B9y%20V%C3%A2n%20H%E1%BB%93", null, "c9128323-7a9b-4881-a2ab-848faa38d580", null, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Local), "NhatNam35@gmail.com", true, "Thùy Vân Hồ", 1, false, null, "NHATNAM35@GMAIL.COM", "NHATNAM35@GMAIL.COM", "AQAAAAIAAYagAAAAEFXsAwgU/0oI06fxR/SU2LlHawS3y3/eylayBywtJx1FZMgX70GoeuyRibZ0amBl8A==", "024 2994 3849", false, "1cb0a0d1-1605-4852-9681-44a92d1948d5", null, false, "NhatNam35@gmail.com" },
                    { 33, 0, "94734 Vương Gia Row", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C3%81nh%20Th%C6%A1%20Nguy%E1%BB%85n", null, "7d92daa3-b56b-470d-8a15-45fdb813948d", null, new DateTime(2015, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "NamAn40@yahoo.com", true, "Ánh Thơ Nguyễn", 3, false, null, "NAMAN40@YAHOO.COM", "NAMAN40@YAHOO.COM", "AQAAAAIAAYagAAAAEAXu37OO7zAFircuuyy6Nu5uQzPsWbKZDcDs46ZTLJxtnHPMAl35lkxZOzxeJg+g2A==", "0243 8987 7637", false, "62c5f1a7-fa6a-4918-b5e6-fd7ae14b856a", null, false, "NamAn40@yahoo.com" },
                    { 34, 0, "1804 Đặng Islands", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=K%E1%BB%B3%20Anh%20%C4%90%E1%BB%97", null, "604080d4-1db4-4bcf-8269-3d56cdb0b76a", null, new DateTime(2022, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), "KimLoan_Do68@gmail.com", true, "Kỳ Anh Đỗ", 2, false, null, "KIMLOAN_DO68@GMAIL.COM", "KIMLOAN_DO68@GMAIL.COM", "AQAAAAIAAYagAAAAEOZ8/8hqnYZeDN1YDgNTE3McQOhMaNHn1YpZYucRhvVPXsAuVoM+djK367BiFCR/wQ==", "0216 9722 2841", false, "edc2d1d7-120b-4652-9cec-1c9f58348842", null, false, "KimLoan_Do68@gmail.com" },
                    { 35, 0, "811 Trường Phát Common", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thi%E1%BB%87n%20Giang%20Ph%E1%BA%A1m", null, "734a20ae-b2b5-47c4-a928-a50de8650fd9", null, new DateTime(2000, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "QuynhGiang72@yahoo.com", true, "Thiện Giang Phạm", 2, false, null, "QUYNHGIANG72@YAHOO.COM", "QUYNHGIANG72@YAHOO.COM", "AQAAAAIAAYagAAAAEGAymOYEQ5YVRglvStqBYmQDIhjOobY4Xt/9mUH0WzqA7XoHbISfeElo32PK2GKG7Q==", "0220 7836 8928", false, "2fe21064-7e77-4bd0-b03a-ef3ca69750f8", null, false, "QuynhGiang72@yahoo.com" },
                    { 36, 0, "0707 Vương Ways", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Oanh%20V%C5%A9%20%C4%90%C3%A0o", null, "6c18904a-9987-44b8-974a-8e3431103c7c", null, new DateTime(2005, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), "NhuQuynh.Le@hotmail.com", true, "Oanh Vũ Đào", 3, false, null, "NHUQUYNH.LE@HOTMAIL.COM", "NHUQUYNH.LE@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHQywziXxa9IZqmJtdBQ5HuffaQMXPZB32vyLlasHRGPK7wDNMZmTr9eafBrTqieBg==", "0263 8648 3296", false, "ac7953b8-5f13-4d98-8360-8b15414f6558", null, false, "NhuQuynh.Le@hotmail.com" },
                    { 37, 0, "701 Đào Canyon", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Xu%C3%A2n%20Lan%20Tr%C6%B0%C6%A1ng", null, "ae996d23-e3a4-46de-825a-370f2714c113", null, new DateTime(2002, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "ThuThao_Ho4@gmail.com", true, "Xuân Lan Trương", 1, false, null, "THUTHAO_HO4@GMAIL.COM", "THUTHAO_HO4@GMAIL.COM", "AQAAAAIAAYagAAAAEEvLn1DnWhXWbLbYSmcddSKVO5gLYuvN7ux/o8+wS88DSdEUKy88PNbZ9KHy3O6ZBg==", "0206 4107 5889", false, "1f23e480-c27a-4f2f-8937-079ccfd5607c", null, false, "ThuThao_Ho4@gmail.com" },
                    { 38, 0, "2917 Bích Vân Street", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%E1%BA%A3o%20Ch%C3%A2u%20Ho%C3%A0ng", null, "49ecae3a-524c-41fe-8c0c-a1472fd669b9", null, new DateTime(2017, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "KhoiVi_Dinh88@hotmail.com", true, "Bảo Châu Hoàng", 3, false, null, "KHOIVI_DINH88@HOTMAIL.COM", "KHOIVI_DINH88@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHC3ZgvLc9rFxd16qRH91DG8l0Ju7rhKhP+Y9WhxH79B+h8wElPDUCoazWpaFCs9kw==", "023 4454 8584", false, "9d129aaf-c2d6-40b7-b430-2689a09b4a1e", null, false, "KhoiVi_Dinh88@hotmail.com" },
                    { 39, 0, "85955 Đỗ Ville", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Hoa%20Li%C3%AAn%20L%C3%A2m", null, "397716d4-a3ea-4748-b688-9e03733bc406", null, new DateTime(2000, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "HongKhanh90@hotmail.com", true, "Hoa Liên Lâm", 3, false, null, "HONGKHANH90@HOTMAIL.COM", "HONGKHANH90@HOTMAIL.COM", "AQAAAAIAAYagAAAAENu03CVYV9AeCjhClFRKMvkP3r2drjPTgVpoSPcNF7O/b3Ozo8ERe9ADT5jPkzxAng==", "026 8135 8294", false, "add790ca-8e3f-4e05-b0b0-17b46155830f", null, false, "HongKhanh90@hotmail.com" },
                    { 40, 0, "832 Diệu Ái Parks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%AFu%20V%C6%B0%E1%BB%A3ng%20%C4%90o%C3%A0n", null, "62f691df-d4bc-44e4-bb7f-17a18e26b472", null, new DateTime(2014, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "LinhNhi_Duong47@yahoo.com", true, "Hữu Vượng Đoàn", 3, false, null, "LINHNHI_DUONG47@YAHOO.COM", "LINHNHI_DUONG47@YAHOO.COM", "AQAAAAIAAYagAAAAEKWErar3k9/uak+MLc1IbbwtT3PzFX/BFHy6cmDNOvM+VxY9yIWakDVCJMtHluUK3A==", "0232 5715 5003", false, "1ed5ade4-d90e-4074-9b06-f8a3362aac89", null, false, "LinhNhi_Duong47@yahoo.com" },
                    { 41, 0, "550 Dương Manors", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Y%C3%AAn%20%C4%90an%20V%C5%A9", null, "e17efc68-abb5-49ca-8bfb-63fd84320fb8", null, new DateTime(1999, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "ThanhKieu_Lam@gmail.com", true, "Yên Đan Vũ", 1, false, null, "THANHKIEU_LAM@GMAIL.COM", "THANHKIEU_LAM@GMAIL.COM", "AQAAAAIAAYagAAAAEGvWVWI4Ob9aWtv95GZ3I4Pd/8XOYiM0mMPz9YlwDmPkvpWhJZ654IIr0KXIvfUUuw==", "026 4925 7300", false, "37866603-98c7-4938-ae2f-ccbbba2efa13", null, false, "ThanhKieu_Lam@gmail.com" },
                    { 42, 0, "408 Quang Tài Village", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%E1%BB%91%20Quy%C3%AAn%20%C4%90%E1%BA%B7ng", null, "6d32d5a3-c5c5-49ce-8d88-316c03995e70", null, new DateTime(2016, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "HongVinh.Bui36@yahoo.com", true, "Tố Quyên Đặng", 1, false, null, "HONGVINH.BUI36@YAHOO.COM", "HONGVINH.BUI36@YAHOO.COM", "AQAAAAIAAYagAAAAEPRLnaGeCuKWJaJNRRPLIOKGbl8K+ruhh1Uv/kTS7CYRriAIHF/ZlqK5ETz6e72MTA==", "027 2064 4107", false, "ce88d7fe-5ad0-4621-8922-73fb3acee77e", null, false, "HongVinh.Bui36@yahoo.com" },
                    { 43, 0, "914 Đinh Route", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BA%A1nh%20My%20H%C3%A0", null, "3cc5b908-e276-4c3a-8b4e-5b02a13dde80", null, new DateTime(1996, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), "XuanTrang.Lam@hotmail.com", true, "Hạnh My Hà", 1, false, null, "XUANTRANG.LAM@HOTMAIL.COM", "XUANTRANG.LAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAELPdyRrqSbhoKX10r6HFtgwjEUI0WjXi2PNKkryNkSju26rbQs2stM1UuFsQZwNaUA==", "026 3128 0088", false, "9355614d-c515-411e-af5b-01d301182475", null, false, "XuanTrang.Lam@hotmail.com" },
                    { 44, 0, "9688 Phạm Causeway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Huy%20Kh%C3%A1nh%20Ph%C3%B9ng", null, "c5279516-8b0e-476f-866c-4f02f5b70dca", null, new DateTime(2019, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "DinhTrung.Bui@hotmail.com", true, "Huy Khánh Phùng", 3, false, null, "DINHTRUNG.BUI@HOTMAIL.COM", "DINHTRUNG.BUI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMnM7zlvG9MHZdwh+eZSGYXWu88Hxjx4nTuZQEOIkCKyDzPkKMDcbxYcUElJYNrVpA==", "023 4220 4464", false, "05875ee8-f364-4247-8b12-749c2ae1119d", null, false, "DinhTrung.Bui@hotmail.com" },
                    { 45, 0, "77597 Vũ Club", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thanh%20Tu%E1%BA%A5n%20%C4%90%C3%A0o", null, "ec488336-6d0c-46cf-b89d-5da1b05a0b04", null, new DateTime(2011, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "HuongLy36@hotmail.com", true, "Thanh Tuấn Đào", 1, false, null, "HUONGLY36@HOTMAIL.COM", "HUONGLY36@HOTMAIL.COM", "AQAAAAIAAYagAAAAEC5GIQcfwzJAT26uj7vKM9TDzzZfStsO81hA7VxnsS2TT14tFo9KMZatILsLuTNNxQ==", "0223 6410 1764", false, "d1854404-206e-44e3-819b-b2a46e75eee6", null, false, "HuongLy36@hotmail.com" },
                    { 46, 0, "7924 Hồ Place", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%E1%BB%A7y%20Minh%20Mai", null, "9f15c0b7-f92a-4fd7-bc34-026518c5e00d", null, new DateTime(2013, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "HuyViet_Duong34@gmail.com", true, "Thủy Minh Mai", 3, false, null, "HUYVIET_DUONG34@GMAIL.COM", "HUYVIET_DUONG34@GMAIL.COM", "AQAAAAIAAYagAAAAEAaOpZdLA72ExAHB8VbFCPJBfQkwXTcdJ+BeJjGDzBqvLNqzZASMGCPFOmFZn3SBbg==", "023 8831 4000", false, "c1d4445e-1d9e-4263-ac7b-7675a2796f48", null, false, "HuyViet_Duong34@gmail.com" },
                    { 47, 0, "173 Dương Road", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Lan%20H%C6%B0%C6%A1ng%20Tr%E1%BA%A7n", null, "d491598c-9146-47e9-8198-24cde962781d", null, new DateTime(2000, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "DongPhong.Dinh49@yahoo.com", true, "Lan Hương Trần", 2, false, null, "DONGPHONG.DINH49@YAHOO.COM", "DONGPHONG.DINH49@YAHOO.COM", "AQAAAAIAAYagAAAAEDWUmZySdYUZ7D2wh+InKubBFDVXaH3V6/kq5igLCDMg+5CdcwG6pAyLrp+oVsHSSg==", "0210 7792 6060", false, "d4331269-1f38-4a60-8fbd-aa2a411a38c6", null, false, "DongPhong.Dinh49@yahoo.com" },
                    { 48, 0, "49132 Nhã Trúc Flat", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%C3%BAy%20Li%C3%AAn%20%C4%90%E1%BB%97", null, "eecfb24b-5d09-4a53-8444-efc14175fceb", null, new DateTime(2015, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "YenTram_Ly89@gmail.com", true, "Thúy Liên Đỗ", 1, false, null, "YENTRAM_LY89@GMAIL.COM", "YENTRAM_LY89@GMAIL.COM", "AQAAAAIAAYagAAAAEB85oxYIhrD/TvU+abcnpccONXsGrCa9qUYZrdoiD75FIAjvcwb1ni+RXZ0gxerpgQ==", "021 5325 5007", false, "b22e8869-726d-48d9-88aa-d07ad082ba16", null, false, "YenTram_Ly89@gmail.com" },
                    { 49, 0, "6312 Kim Dung Mountain", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Kim%20S%C6%A1n%20%C4%90o%C3%A0n", null, "9469b0c8-9c22-4dc5-a014-5b8fe3629516", null, new DateTime(2017, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "SongLam_Trinh55@yahoo.com", true, "Kim Sơn Đoàn", 3, false, null, "SONGLAM_TRINH55@YAHOO.COM", "SONGLAM_TRINH55@YAHOO.COM", "AQAAAAIAAYagAAAAEIE8D7ZlzQOuawfUHbGbOtsxeC0192nSiXPw817BAP8DzjQU3NPFgSadKllCJ3/IqQ==", "027 6504 0300", false, "279e904c-02f7-4d28-8ccd-0b982ed28ce5", null, false, "SongLam_Trinh55@yahoo.com" },
                    { 50, 0, "8719 Chí Giang Islands", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C3%90o%C3%A0n%20T%E1%BB%A5%20Tr%E1%BB%8Bnh", null, "1a07eb29-7047-4a52-82a9-936cbf5be17e", null, new DateTime(2017, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "QuangVinh26@hotmail.com", true, "Ðoàn Tụ Trịnh", 1, false, null, "QUANGVINH26@HOTMAIL.COM", "QUANGVINH26@HOTMAIL.COM", "AQAAAAIAAYagAAAAENYHvNeUZisbSjaPCCtplOn5xrQo4VK/7Bg3BDSzfAYOZ+gujzo+47VWLloWjpHLeA==", "024 0540 0368", false, "bf59e2f3-fd96-4c23-9f2a-b1285d9e3d33", null, false, "QuangVinh26@hotmail.com" },
                    { 51, 0, "846 Tịnh Yên Tunnel", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=M%E1%BB%B9%20L%E1%BB%87%20Tr%E1%BA%A7n", null, "12a9590f-a836-4b73-874e-78adce6b23e1", null, new DateTime(2006, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "QuanDuong.Tang@yahoo.com", true, "Mỹ Lệ Trần", 1, false, null, "QUANDUONG.TANG@YAHOO.COM", "QUANDUONG.TANG@YAHOO.COM", "AQAAAAIAAYagAAAAEIVHMxGnKA6NS3Jqf6Ivd6LaYv1wUPnIyCdP0gLm7Xul5G8kSROcGNIATGC/H7Pm8w==", "022 9161 6611", false, "24579955-13e5-4990-bdc5-2fbd0e5c4b20", null, false, "QuanDuong.Tang@yahoo.com" },
                    { 52, 0, "1285 Minh Uyên Prairie", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thanh%20Li%C3%AAm%20L%C3%BD", null, "63717e0e-b6c3-4e7f-925d-003427cb4713", null, new DateTime(2015, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), "BachLoan_Dao@gmail.com", true, "Thanh Liêm Lý", 3, false, null, "BACHLOAN_DAO@GMAIL.COM", "BACHLOAN_DAO@GMAIL.COM", "AQAAAAIAAYagAAAAEHYrYXGQmIhZMimkt6LOTsBuvU9mmpe+HLKPnWVNrUOoLK5VoN5ZjRBcQa37eHQrOA==", "0218 7340 8632", false, "a65637c3-0448-43a4-a515-5fca68b5ce21", null, false, "BachLoan_Dao@gmail.com" },
                    { 53, 0, "8272 Phùng Fork", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nh%E1%BA%ADt%20H%E1%BB%93ng%20T%C4%83ng", null, "18b9c213-0e46-4c01-970a-1c56d90aaad5", null, new DateTime(2017, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "BaoThoa40@yahoo.com", true, "Nhật Hồng Tăng", 3, false, null, "BAOTHOA40@YAHOO.COM", "BAOTHOA40@YAHOO.COM", "AQAAAAIAAYagAAAAEBH3c683Z5XnZuD+bKr8K4nrfsI9Bxk+UUxEDW+1hR18a8eFc32joX1+A+UsAaICAQ==", "0280 3720 6520", false, "9057d241-7680-4040-8657-eae8277e4c28", null, false, "BaoThoa40@yahoo.com" },
                    { 54, 0, "532 Thiếu Anh Field", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%AFu%20Chi%E1%BA%BFn%20H%E1%BB%93", null, "5c591b1b-e870-4569-bc7f-9d4c9efff4c4", null, new DateTime(2008, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "MyHanh.Bui@hotmail.com", true, "Hữu Chiến Hồ", 2, false, null, "MYHANH.BUI@HOTMAIL.COM", "MYHANH.BUI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPeox2nZ+d3ZT7lUHZm+9pj4FmYPDJqDTjfWTIydKcRDd/U6MyXAWPrkcqIYfO0o9w==", "029 2645 1191", false, "e8e32963-86f7-4f4b-bd0e-b3ab239e7480", null, false, "MyHanh.Bui@hotmail.com" },
                    { 55, 0, "232 Phong Châu Junction", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Hi%E1%BA%BFu%20Minh%20L%C3%A2m", null, "639e5a0e-5ed7-4f7d-9f76-8fcd758f40bd", null, new DateTime(2003, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "PhungYen18@hotmail.com", true, "Hiếu Minh Lâm", 3, false, null, "PHUNGYEN18@HOTMAIL.COM", "PHUNGYEN18@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPrd6E+SeoS5mMNbR3l0js64tZmiy+yexxIOYaRI98RgLU/2t+4D4cvGHQQSQ6FMoQ==", "025 3007 8215", false, "41d01923-327d-4db5-a0a2-8b965d89fcbc", null, false, "PhungYen18@hotmail.com" },
                    { 56, 0, "61822 Dương Stream", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thi%C3%AAn%20Thanh%20L%C3%AA", null, "11775e0b-fdba-4876-9c4e-b1b3f8b0027e", null, new DateTime(1997, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "HuuTri_Le@yahoo.com", true, "Thiên Thanh Lê", 3, false, null, "HUUTRI_LE@YAHOO.COM", "HUUTRI_LE@YAHOO.COM", "AQAAAAIAAYagAAAAEIZE1GyQ86+xzUMuYA8cTakyauQEKWerIVD/qJ0mRaL4zR0RPeWikvR9+QyI69uU3A==", "025 7243 8492", false, "2fa14f62-afd6-4f30-8509-a61b4def9fc4", null, false, "HuuTri_Le@yahoo.com" },
                    { 57, 0, "3339 Đỗ Circle", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%E1%BB%8Dc%20Ly%20Tr%E1%BA%A7n", null, "3a037546-3895-4fe6-9d3b-09ade93c1294", null, new DateTime(1995, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "DinhTrung87@yahoo.com", true, "Ngọc Ly Trần", 1, false, null, "DINHTRUNG87@YAHOO.COM", "DINHTRUNG87@YAHOO.COM", "AQAAAAIAAYagAAAAEA5pyN+vE7S96U3WWPxjn623QyYiar41awEEVM/BeQQXZREajdgqBUEASX56Deo/YA==", "0265 7249 9378", false, "e8654d39-e7f6-4d06-a4b4-dc564d325f4d", null, false, "DinhTrung87@yahoo.com" },
                    { 58, 0, "2539 Vinh Diệu Plain", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Cao%20Minh%20H%C3%A0", null, "cf450033-ab08-4271-8651-cfcaa0a543a8", null, new DateTime(2016, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "BaoChan.Le@gmail.com", true, "Cao Minh Hà", 2, false, null, "BAOCHAN.LE@GMAIL.COM", "BAOCHAN.LE@GMAIL.COM", "AQAAAAIAAYagAAAAEC8cHbe3V0ABtIWBQoICKELWXteTTj1s+9w099NYoJCee8yiVgCMt2wPNPxsLNAKyw==", "023 0564 6996", false, "08be5643-21f6-4b7e-9429-de07a66f124b", null, false, "BaoChan.Le@gmail.com" },
                    { 59, 0, "535 Nguyết Ánh Station", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%A1ch%20Du%20B%C3%B9i", null, "9ff643cb-ea4b-473f-8664-32e3ebfc9d94", null, new DateTime(2003, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "LapNghiep.Nguyen61@yahoo.com", true, "Bách Du Bùi", 2, false, null, "LAPNGHIEP.NGUYEN61@YAHOO.COM", "LAPNGHIEP.NGUYEN61@YAHOO.COM", "AQAAAAIAAYagAAAAEOODhVJ9ohlSCsqGqwaWPLCSaNTFdEgCnwuYCVEvyX8GvG5NzIPQHE/VXhfu95KMOg==", "024 3491 7948", false, "a648aa43-dbe7-4e57-ad3c-aa8c0d66a7c7", null, false, "LapNghiep.Nguyen61@yahoo.com" },
                    { 60, 0, "318 Trịnh Oval", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Vi%E1%BA%BFt%20T%C3%A2n%20%C4%90o%C3%A0n", null, "82443d37-c925-4f4d-a5c6-50a144c288fc", null, new DateTime(2015, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "VanPhi24@yahoo.com", true, "Viết Tân Đoàn", 3, false, null, "VANPHI24@YAHOO.COM", "VANPHI24@YAHOO.COM", "AQAAAAIAAYagAAAAENj/9xJmq7LKBisuP5sBkUQsproaoo5Y5kHZJiWnYJQEl6SUCrkD7DCu+PaxpwurTg==", "029 6287 4635", false, "886a55b7-ee65-413b-a48e-28d3f46a5817", null, false, "VanPhi24@yahoo.com" },
                    { 61, 0, "6460 Đoàn Junction", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BA%A1c%20C%C3%BAc%20T%C4%83ng", null, "45ce0b10-5fdf-4fb7-90b4-125b98096f06", null, new DateTime(2012, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "TriMinh.Phan97@yahoo.com", true, "Hạc Cúc Tăng", 1, false, null, "TRIMINH.PHAN97@YAHOO.COM", "TRIMINH.PHAN97@YAHOO.COM", "AQAAAAIAAYagAAAAEENzhprTW5I4tD/fLS182zQgMBZtr16c0RXQfMs1Fgw5fqicZwEHs4exwqjxozASRg==", "021 8014 6422", false, "3d59acc0-1136-471e-996b-eb561c95d0d9", null, false, "TriMinh.Phan97@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "About", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "Specialization", "UserId", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1, "Bác sĩ có hơn 2 năm trong lĩnh vực Đa khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1, 2, 2 },
                    { 2, "Bác sĩ có hơn 3 năm trong lĩnh vực Thần kinh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 4, 3, 3 },
                    { 3, "Bác sĩ có hơn 6 năm trong lĩnh vực Da liễu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 3, 4, 6 },
                    { 4, "Bác sĩ có hơn 8 năm trong lĩnh vực Tim mạch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2, 5, 8 },
                    { 5, "Bác sĩ có hơn 10 năm trong lĩnh vực Da liễu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 3, 6, 10 },
                    { 6, "Bác sĩ có hơn 3 năm trong lĩnh vực Tim mạch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2, 7, 3 },
                    { 7, "Bác sĩ có hơn 5 năm trong lĩnh vực Đa khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1, 8, 5 },
                    { 8, "Bác sĩ có hơn 4 năm trong lĩnh vực Thần kinh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 4, 9, 4 },
                    { 9, "Bác sĩ có hơn 9 năm trong lĩnh vực Tim mạch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2, 10, 9 },
                    { 10, "Bác sĩ có hơn 9 năm trong lĩnh vực Nhi khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 5, 11, 9 },
                    { 11, "Bác sĩ có hơn 4 năm trong lĩnh vực Nhi khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 5, 12, 4 },
                    { 12, "Bác sĩ có hơn 4 năm trong lĩnh vực Thần kinh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 4, 13, 4 },
                    { 13, "Bác sĩ có hơn 10 năm trong lĩnh vực Đa khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1, 14, 10 },
                    { 14, "Bác sĩ có hơn 9 năm trong lĩnh vực Đa khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1, 15, 9 },
                    { 15, "Bác sĩ có hơn 3 năm trong lĩnh vực Nhi khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 5, 16, 3 },
                    { 16, "Bác sĩ có hơn 7 năm trong lĩnh vực Nhi khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 5, 17, 7 },
                    { 17, "Bác sĩ có hơn 6 năm trong lĩnh vực Thần kinh", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 4, 18, 6 },
                    { 18, "Bác sĩ có hơn 4 năm trong lĩnh vực Đa khoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 1, 19, 4 },
                    { 19, "Bác sĩ có hơn 8 năm trong lĩnh vực Da liễu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 3, 20, 8 },
                    { 20, "Bác sĩ có hơn 2 năm trong lĩnh vực Tim mạch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2, 21, 2 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 3 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 4 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 5 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 6 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 7 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 8 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 9 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 10 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 11 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 12 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 13 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 14 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 15 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 16 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 17 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 18 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 19 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 20 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 21 },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 22 },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 23 },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 24 },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 25 },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 26 },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 27 },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 28 },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 29 },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 30 },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 31 },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 32 },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 33 },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 34 },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 35 },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 36 },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 37 },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 38 },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 39 },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 40 },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 41 },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 42 },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 43 },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 44 },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 45 },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 46 },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 47 },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 48 },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 49 },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 50 },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 51 },
                    { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 52 },
                    { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 53 },
                    { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 54 },
                    { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 55 },
                    { 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 56 },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 57 },
                    { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 58 },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 59 },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 60 },
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 61 }
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
                    { 1, new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 55, new TimeSpan(0, 13, 0, 0, 0), 1 },
                    { 2, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 58, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 3, new DateTime(2024, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 37, new TimeSpan(0, 16, 0, 0, 0), 1 },
                    { 4, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 20, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 5, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 41, new TimeSpan(0, 14, 0, 0, 0), 1 },
                    { 6, new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 41, new TimeSpan(0, 17, 0, 0, 0), 3 },
                    { 7, new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 47, new TimeSpan(0, 17, 0, 0, 0), 2 },
                    { 8, new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 31, new TimeSpan(0, 8, 0, 0, 0), 0 },
                    { 9, new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 8, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 10, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 3, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 11, new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 11, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 12, new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 7, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 13, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 52, new TimeSpan(0, 13, 0, 0, 0), 0 },
                    { 14, new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 59, new TimeSpan(0, 15, 0, 0, 0), 0 },
                    { 15, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 22, new TimeSpan(0, 13, 0, 0, 0), 1 },
                    { 16, new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 5, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 17, new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 35, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 18, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 14, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 19, new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 41, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 20, new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 59, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 21, new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 47, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 22, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 4, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 23, new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 7, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 24, new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 26, new TimeSpan(0, 12, 0, 0, 0), 3 },
                    { 25, new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 48, new TimeSpan(0, 13, 0, 0, 0), 1 },
                    { 26, new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 38, new TimeSpan(0, 17, 0, 0, 0), 3 },
                    { 27, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 52, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 28, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 53, new TimeSpan(0, 15, 0, 0, 0), 2 },
                    { 29, new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 30, new TimeSpan(0, 15, 0, 0, 0), 3 },
                    { 30, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 58, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 31, new DateTime(2024, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 46, new TimeSpan(0, 16, 0, 0, 0), 2 },
                    { 32, new DateTime(2024, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 5, new TimeSpan(0, 12, 0, 0, 0), 3 },
                    { 33, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 30, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 34, new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 58, new TimeSpan(0, 15, 0, 0, 0), 0 },
                    { 35, new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 40, new TimeSpan(0, 12, 0, 0, 0), 3 },
                    { 36, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 8, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 37, new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 56, new TimeSpan(0, 14, 0, 0, 0), 0 },
                    { 38, new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 32, new TimeSpan(0, 16, 0, 0, 0), 3 },
                    { 39, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 17, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 40, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 52, new TimeSpan(0, 11, 0, 0, 0), 2 }
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
