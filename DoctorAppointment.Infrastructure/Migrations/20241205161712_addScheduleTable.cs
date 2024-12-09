using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorAppointment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addScheduleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "Appointments",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "Appointments",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

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

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 0, 0, 0), 2, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 11, 0, 0, 0), 11, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 0, 0, 0), 12, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 16, 0, 0, 0), 20, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 9, 0, 0, 0), 5, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 14, 0, 0, 0), 16, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 11, 0, 0, 0), 2, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 14, 0, 0, 0), 5, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), 16, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 13, 0, 0, 0), 10, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 17, 0, 0, 0), 17, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), 16, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 18, 0, 0, 0), 6, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 13, 0, 0, 0), 9, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), 3, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), 17, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 9, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 18, 0, 0, 0), 15, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 17, 0, 0, 0), 20, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), 11, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 15, 0, 0, 0), 14, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), 2, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 10, 0, 0, 0), 16, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 18, 0, 0, 0), 13, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 16, 0, 0, 0), 14, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 13, 0, 0, 0), 11, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 16, 0, 0, 0), 20, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), 20, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 11, 0, 0, 0), 13, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), 12, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 0, 0, 0), 16, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 16, 0, 0, 0), 17, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 0, 0, 0), 7, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), 18, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), 11, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 18, 0, 0, 0), 10, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), 16, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Đỏ tím xuồng leo thuyền thế.", 2, 9 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Hàng tui mua xuồng núi anh khoan quần.", 18 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Khoảng nón việc.", 2, 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Quần nha áo mây bạn gió con.", 3, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Làm áo khoảng hết không đang.", 2, 18 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Ác hương gió đồng.", 4, 10 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Đá hương hương được máy hết tàu gì á bơi.", 3, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Đánh thuê bạn tủ đánh.", 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Ừ nhà chìm vẽ tủ mướn bảy con bảy chín.", 4, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Áo vàng xe độc cửa con khoan xanh thích làm.", 4, 11 });

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
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 10, new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "637a49db-b108-45fb-b628-072e993df7e0", "AQAAAAIAAYagAAAAEE3KfFaRB/nAUI1S48tH//v6nxAPgTNmp2IZ+RTu2FGjTT6MSX91iCN83vs9oE8oCw==", "5666438c-7d10-4944-8287-586a780ba783" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "23019 Đinh Drives", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Huy%20Anh%20V%C6%B0%C6%A1ng", "3cffe50c-c86a-4d44-9f38-0dc50f6f10e9", new DateTime(2011, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "KieuGiang15@yahoo.com", "Huy Anh Vương", 1, "KIEUGIANG15@YAHOO.COM", "KIEUGIANG15@YAHOO.COM", "AQAAAAIAAYagAAAAEN4iGmadyVUwakXKEY/kTPvmP1mBLOUAmLozS2KACK3yNcjexuKXAKfMqT6dYKZ7Xg==", "028 7637 9062", "67d8c1d2-6edf-4e65-896d-ab2d0bc71b62", "KieuGiang15@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7964 Cẩm Thúy Shoal", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Minh%20Thu%20Phan", "6cc2335d-172b-4bfa-a662-d0d9c4a88deb", new DateTime(2013, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "ManhTuan.Dang@yahoo.com", "Minh Thu Phan", 1, "MANHTUAN.DANG@YAHOO.COM", "MANHTUAN.DANG@YAHOO.COM", "AQAAAAIAAYagAAAAEM0ni8vGnlszPxaouvruTlqx6k0QRkiaQmgn5q7VOhFnUSSMDxxoTiOqg/fG9vg9Fg==", "0228 2148 8120", "b05e3fdf-1612-4b7d-9b93-3ae4a4a847a4", "ManhTuan.Dang@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "811 Minh Thương Square", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=C%C3%B4ng%20L%E1%BB%99c%20%C4%90o%C3%A0n", "3eaee038-0cb6-4932-9c80-a1ed569898d5", new DateTime(2019, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "KimPhuong.Ngo53@yahoo.com", "Công Lộc Đoàn", 2, "KIMPHUONG.NGO53@YAHOO.COM", "KIMPHUONG.NGO53@YAHOO.COM", "AQAAAAIAAYagAAAAEAyM/MHhp2fbcBUrdBm/LgvOX7byVkMqcKByd9xhTGkGzfBCY+JtCQGt0CUCSHAtqQ==", "0230 1795 6838", "13c0bc18-2240-421d-9fa8-61f36c892b85", "KimPhuong.Ngo53@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "176 Anh Chi Square", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Kim%20Sa%20Ng%C3%B4", "ce52caba-a302-4f21-ab20-642db7dae6d3", new DateTime(2000, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "HongNhuan.Hoang87@yahoo.com", "Kim Sa Ngô", 2, "HONGNHUAN.HOANG87@YAHOO.COM", "HONGNHUAN.HOANG87@YAHOO.COM", "AQAAAAIAAYagAAAAEF3nZcPu6iwovOalfg+/dDDDt//CNqNbhhk/Q70Z9wIs7vKD3/jYssHwWgdCgJM63A==", "026 2404 7094", "a557aefd-ab2f-42d6-976e-73a1fc8ce0f8", "HongNhuan.Hoang87@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2774 Ngô Common", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Th%C3%B9y%20My%20Mai", "6aca0f0b-b0f3-4a1f-9678-5d6b1cafcfce", new DateTime(2001, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), "KienGiang.Bui5@yahoo.com", "Thùy My Mai", 3, "KIENGIANG.BUI5@YAHOO.COM", "KIENGIANG.BUI5@YAHOO.COM", "AQAAAAIAAYagAAAAEAjMOCOcZHR9pASFdtZuL++6FxAyPTMae0Sg6kequ7m3Jz+OLV9CMoPdFt6XZ4vLdw==", "024 4736 5540", "15385a79-b116-4c11-96c9-1bf6c38994f9", "KienGiang.Bui5@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "372 Quốc Minh Centers", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=B%C3%ADch%20Ng%E1%BB%8Dc%20L%C3%AA", "ac59547d-4899-4bf8-8e57-b26d6ed20314", new DateTime(1996, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "MyNhi.Hoang@gmail.com", "Bích Ngọc Lê", 2, "MYNHI.HOANG@GMAIL.COM", "MYNHI.HOANG@GMAIL.COM", "AQAAAAIAAYagAAAAEEXU7qa681whzAC6evg+HzsuuvP8WbDzAAZwvKebLFSe4QyMlMtmfVxsdWOtBzAD8Q==", "0206 8940 5714", "23e679bf-8ed8-4922-9394-460c1d481e9c", "MyNhi.Hoang@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "006 Ngọc Tú Road", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=H%C3%B9ng%20S%C6%A1n%20Tr%C6%B0%C6%A1ng", "27224eec-aebe-4848-b131-be369fd7b505", new DateTime(1996, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "DanhSon62@yahoo.com", "Hùng Sơn Trương", 2, "DANHSON62@YAHOO.COM", "DANHSON62@YAHOO.COM", "AQAAAAIAAYagAAAAEP9VzpSCkVnnoiWuj7r+KAaCvBwOoctdynr4exGOIApix9juXqsWDeTgGsHhtvYixA==", "023 3405 1163", "44594a63-b2e7-4725-bbcd-5c6e95b8d03a", "DanhSon62@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7480 Hoàng Estate", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=T%C3%B4n%20L%E1%BB%85%20%C4%90inh", "004f23b5-a573-4b6a-9893-e745da202a3b", new DateTime(2010, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "XuanBao26@gmail.com", "Tôn Lễ Đinh", 1, "XUANBAO26@GMAIL.COM", "XUANBAO26@GMAIL.COM", "AQAAAAIAAYagAAAAEAqx2eFeBXow1PiSqCG7gfNIPyAv+F7FwKXh8lEDMhlDgdM6olyuXgHDBZ1KR5uZ0Q==", "0279 7734 4838", "8e6160b2-c733-43a4-9c90-80013c328aad", "XuanBao26@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "59821 Trương Brooks", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Thi%C3%AAn%20%C3%90%E1%BB%A9c%20Tr%C6%B0%C6%A1ng", "c71dd67b-84ac-442d-90ad-755daf8db87f", new DateTime(2015, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "HuuCanh.Hoang@yahoo.com", "Thiên Ðức Trương", 3, "HUUCANH.HOANG@YAHOO.COM", "HUUCANH.HOANG@YAHOO.COM", "AQAAAAIAAYagAAAAEOtWiPh1gwJ+IUjTz3iAmZyFH6vWQWEJfNW1wfOzm3MOejYPC3Hcng+MysV5icD5OA==", "0273 5513 8978", "f9c69a10-c7c2-4fd6-845f-5556dae4879b", "HuuCanh.Hoang@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "079 Hương Lan Pass", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=V%C4%A9nh%20Long%20%C4%90%C3%A0o", "106d6a10-859e-4f63-84c3-c0e59f662a20", new DateTime(2017, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), "ThanhHao.Trinh@hotmail.com", "Vĩnh Long Đào", 3, "THANHHAO.TRINH@HOTMAIL.COM", "THANHHAO.TRINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAECI9ff7jJPrC+bwAVFSI2KGmJmZx+0d/rJIBPw0WnasVPbNkMVxldHAOY7lnAElwHg==", "0201 6386 2134", "9b62d7ae-4d28-4b9d-8491-7c916e757315", "ThanhHao.Trinh@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "96265 Tăng Rest", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=M%E1%BB%99ng%20Thi%20Phan", "ca8baadb-0287-40f6-9aa8-00dcd0c6c345", new DateTime(1999, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "HoangKhang_Hoang93@yahoo.com", "Mộng Thi Phan", 2, "HOANGKHANG_HOANG93@YAHOO.COM", "HOANGKHANG_HOANG93@YAHOO.COM", "AQAAAAIAAYagAAAAEEmWPrY4bMqT9K6YAhlFWzGg/AaCTXN8XkrureWPK00dOqbyU7iA+lA6V2BaI0PRJg==", "026 6392 7050", "a54983b6-a5ef-4571-a6fc-f640aa905120", "HoangKhang_Hoang93@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "34568 Quang Thuận Gardens", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=S%C6%A1n%20T%C3%B9ng%20B%C3%B9i", "81375969-1ef5-43bb-80a5-c2b8b2d227b3", new DateTime(1999, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), "KimThy99@yahoo.com", "Sơn Tùng Bùi", 1, "KIMTHY99@YAHOO.COM", "KIMTHY99@YAHOO.COM", "AQAAAAIAAYagAAAAEAGWXgTFyP501xl8QMi9xwXFf4cHRIf7jWU4oGBJF8xCGtA2zl+7YlXfJKhpG04JIA==", "029 5361 2429", "16a7b4a1-29d3-47e9-bd93-9fe2c659ebd1", "KimThy99@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "982 Lâm Knoll", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=B%C3%ACnh%20Y%C3%AAn%20H%C3%A0", "df1cb371-4841-4942-affa-054cc7a0682c", new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "QuyVinh_Nguyen@yahoo.com", "Bình Yên Hà", 1, "QUYVINH_NGUYEN@YAHOO.COM", "QUYVINH_NGUYEN@YAHOO.COM", "AQAAAAIAAYagAAAAENXSCiaI9hUR8Gwb6ecLfJ+f6IsrvAtXVQtUomdEDsxbEodkoeJN8eB9qoYNp4zfhg==", "023 8391 1597", "c9177979-5fce-45f0-b472-264b2337bc40", "QuyVinh_Nguyen@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "606 Uyển Nhi Throughway", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Quy%E1%BA%BFt%20Th%E1%BA%AFng%20Nguy%E1%BB%85n", "35ceb6dd-bfb4-4ea9-be25-6f11e8e5a0a9", new DateTime(2005, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "PhuocAn_Truong40@yahoo.com", "Quyết Thắng Nguyễn", 1, "PHUOCAN_TRUONG40@YAHOO.COM", "PHUOCAN_TRUONG40@YAHOO.COM", "AQAAAAIAAYagAAAAEFEOjgGPzYEIFxPcGw01Tuo7G+fRivwvVZQStO8Rlm+lbiJBHZfFGoRJlHB6tTPMFw==", "0278 6261 0942", "67562521-5bda-4af6-8e5e-063e28de3cf4", "PhuocAn_Truong40@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "95614 Xuân Yến Locks", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=S%C6%A1n%20H%C3%A0%20Phan", "c8ec466a-ca21-497a-be93-8f3be4bcb5f7", new DateTime(2013, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "DonThuan70@yahoo.com", "Sơn Hà Phan", 1, "DONTHUAN70@YAHOO.COM", "DONTHUAN70@YAHOO.COM", "AQAAAAIAAYagAAAAEEgiHg2ren2po1GzkvHaL0x/gaMzlv979wYmH3psBmpRb92kbAXkGnm0/ZcLcGQvMA==", "0285 1877 1256", "b354e051-5f3d-4051-b909-e8ca1a2d30da", "DonThuan70@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "64695 Nguyễn Corner", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Kh%E1%BA%AFc%20Minh%20Tr%C6%B0%C6%A1ng", "ae6b48eb-7f06-4914-89ba-afe18e6c0f31", new DateTime(2015, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), "LamTruong_Hoang96@gmail.com", "Khắc Minh Trương", 3, "LAMTRUONG_HOANG96@GMAIL.COM", "LAMTRUONG_HOANG96@GMAIL.COM", "AQAAAAIAAYagAAAAEOb0fyArVxQJ7nEdL0q322as3euYY9BccfzFeAScxa7fU02EXPzS96+CEB85nThhWA==", "0280 1187 5062", "803250bd-80c4-4694-ab41-04d7ed85933e", "LamTruong_Hoang96@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "570 Tăng Gateway", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Qu%E1%BB%B3nh%20Sa%20Mai", "80778bbd-4daf-4f36-a72c-1822278a7da6", new DateTime(2011, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "ChungThuy_Nguyen59@yahoo.com", "Quỳnh Sa Mai", 1, "CHUNGTHUY_NGUYEN59@YAHOO.COM", "CHUNGTHUY_NGUYEN59@YAHOO.COM", "AQAAAAIAAYagAAAAEGsSZENRXnGDRCX8d4MAGFRX90tm6JGFOzDVAhOFXPY13Zel0fx1+u1SXSTEbKcbYA==", "029 4519 6109", "11a1dc59-1ab4-474d-a876-0c81fded43cf", "ChungThuy_Nguyen59@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "997 Thái Hồng Isle", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Chu%E1%BA%A9n%20Khoa%20%C4%90%E1%BA%B7ng", "503d096c-4ddc-4ed0-ac9c-1f546a579b4a", new DateTime(2011, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "MinhVy61@gmail.com", "Chuẩn Khoa Đặng", 3, "MINHVY61@GMAIL.COM", "MINHVY61@GMAIL.COM", "AQAAAAIAAYagAAAAEDm1ZhMvBcdwpVSvAjnf78KjmXpi8Sv1sG+4YbjAJJRP1xUTLbJnoT+93ciots9Wfw==", "020 4288 5112", "6d46597d-52ff-47e2-869d-1ccbd2b9659f", "MinhVy61@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "415 Tăng Falls", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Gia%20Anh%20%C4%90o%C3%A0n", "fa7fbe3e-4dde-4ae8-9c08-d936cb3a2210", new DateTime(1996, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "DiemHang.Hoang@gmail.com", "Gia Anh Đoàn", 3, "DIEMHANG.HOANG@GMAIL.COM", "DIEMHANG.HOANG@GMAIL.COM", "AQAAAAIAAYagAAAAEERJw1mTtkCdHiR+zmY+76kGtn3H+z40fTLevbsL21kY+osOXLtxgufw+KASlfJhOQ==", "026 8087 7219", "1117e856-e759-4582-8d55-da8f72d94999", "DiemHang.Hoang@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6571 Bùi Groves", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=H%E1%BB%AFu%20B%E1%BA%A3o%20%C4%90%E1%BB%97", "d7e04d31-2553-48e3-853f-295b6391dee1", new DateTime(2002, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "CuongNghi.Ngo54@yahoo.com", "Hữu Bảo Đỗ", 1, "CUONGNGHI.NGO54@YAHOO.COM", "CUONGNGHI.NGO54@YAHOO.COM", "AQAAAAIAAYagAAAAEAB8wJpqLCW/K3VRIktYcKffCrLetYjtVIZYZt59A7SDk1cCLh1llYtepXEgoGr4zw==", "0208 1362 9975", "9339c67c-8d0a-471c-8ec0-25204952f2a7", "CuongNghi.Ngo54@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4524 Thanh Thảo Forks", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Qu%C3%BD%20Kh%C3%A1nh%20%C4%90inh", "9ba10eb2-dd1c-4170-b94b-a95cb4fbd2e5", new DateTime(2007, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "HangAnh8@hotmail.com", "Quý Khánh Đinh", 1, "HANGANH8@HOTMAIL.COM", "HANGANH8@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIHXs0Wcu6usnl+hIowdJ7psZn+ksGdRV4lYylOyOABNcsu9SjHBIdH7BvcS+6Chkw==", "0244 5333 7096", "14c7351b-3b7f-4d50-ad70-9c4bb88b650d", "HangAnh8@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3532 Trương Crescent", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Kim%20Hoa%20V%C5%A9", "e32ffafd-f01a-45f2-9238-d0b81255c42f", new DateTime(2015, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "ThucNhi_Bui@yahoo.com", "Kim Hoa Vũ", 2, "THUCNHI_BUI@YAHOO.COM", "THUCNHI_BUI@YAHOO.COM", "AQAAAAIAAYagAAAAEMJTQ8PsN3uOEZohSFwlIS6HSpR65dqJDk9m0z17cr3OdiphQEVhPnjXJyJUTEAZZw==", "0294 6705 2522", "df2b07ba-de56-4b80-9b8e-df73ee397336", "ThucNhi_Bui@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "81003 Bích Vân Motorway", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=L%E1%BA%A1c%20Ph%C3%BAc%20T%C3%B4", "673fe694-0d01-4a75-8244-ba19da1e120b", new DateTime(2008, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "MongHoan.Le10@gmail.com", "Lạc Phúc Tô", 1, "MONGHOAN.LE10@GMAIL.COM", "MONGHOAN.LE10@GMAIL.COM", "AQAAAAIAAYagAAAAEF4afLLU42xKg2h8Cm0ngkegeqcXOPUDeeZ9YyWSuC+N4ddxPEzkK8ObWLuIdjjCPw==", "025 7318 6696", "a0efa1dc-b9e1-401f-a60a-d9cdcd06b00d", "MongHoan.Le10@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "33898 Thương Nga Crossing", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Minh%20Ph%C6%B0%C6%A1ng%20Tr%C6%B0%C6%A1ng", "95da1aa3-cc0a-4947-8a66-fa9621009ee0", new DateTime(2008, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "QuocHai42@yahoo.com", "Minh Phương Trương", 2, "QUOCHAI42@YAHOO.COM", "QUOCHAI42@YAHOO.COM", "AQAAAAIAAYagAAAAEKyTyn0ipA+Nx/P3hhA07wabjdVuTSAaD45BMlu+kGya9f2uzL6JR6zriJjXrAFU4Q==", "0283 1217 1784", "7ee1e52e-a2fe-403e-9592-c359cbd7489d", "QuocHai42@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8294 Đặng Parkway", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Ph%C6%B0%E1%BB%9Bc%20Nh%C3%A2n%20%C4%90%C3%A0o", "2dd0758c-e794-4f89-954f-948719050cf4", new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "QuocPhong.Hoang48@yahoo.com", "Phước Nhân Đào", 1, "QUOCPHONG.HOANG48@YAHOO.COM", "QUOCPHONG.HOANG48@YAHOO.COM", "AQAAAAIAAYagAAAAEGsZeppTSeYjD2QI8Uj32Bjl0taZi8tIaq5AyYo7X5gQqTMFYpAdHqeoGb/5kNieYA==", "022 3154 2711", "a7b93673-715f-4b18-9940-b53c0b0d814c", "QuocPhong.Hoang48@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "170 Tăng Village", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Mi%C3%AAn%20Ng%C3%B4", "e10329fa-0653-447c-ba6e-74e7743ea11e", new DateTime(2007, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), "DacTrong.Vu7@hotmail.com", "Hoàng Miên Ngô", 3, "DACTRONG.VU7@HOTMAIL.COM", "DACTRONG.VU7@HOTMAIL.COM", "AQAAAAIAAYagAAAAEL7eBQ2E8YZ+TXhFLizbiioiHJqQvliooaTD2Dl7UPSTwydxCx+Mh5pYcDx2DZo9VA==", "0237 6289 6830", "80c94ff7-e603-46fd-a375-d922e6e1b62a", "DacTrong.Vu7@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7791 Anh Quân Orchard", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=T%C6%B0%E1%BB%9Dng%20L%C3%A2n%20Mai", "25813d12-b807-488f-ad4a-da4327cc70dc", new DateTime(1995, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "HaiNam.Trinh76@yahoo.com", "Tường Lân Mai", 2, "HAINAM.TRINH76@YAHOO.COM", "HAINAM.TRINH76@YAHOO.COM", "AQAAAAIAAYagAAAAEHZ3T1QNx7iTjRTPzszbVJ8KrfOmXTHYZvHtOKCyzvXY3lGIGYP7tcbSLtsb1IkSdg==", "0232 3459 7648", "b775531f-3308-4668-b6ea-d424e9c92f5d", "HaiNam.Trinh76@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "14781 Huệ Lan Manors", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Th%C3%B9y%20Nhi%20%C4%90%C3%A0o", "2f7c30f3-69c7-4732-87f6-9ed1acc4a64a", new DateTime(2002, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "KhanhHa.Do95@gmail.com", "Thùy Nhi Đào", 1, "KHANHHA.DO95@GMAIL.COM", "KHANHHA.DO95@GMAIL.COM", "AQAAAAIAAYagAAAAEIsMmdchEBy8ka3Ft4jJaDHg34QMod0BLEL2O94Tddz2SMuP1QoXB2iHgfRDIvvyMA==", "0262 2625 7845", "7029aff3-00b5-40ce-8ea1-7e92b5899f91", "KhanhHa.Do95@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "497 Đinh Forks", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=H%E1%BA%A3i%20San%20T%C3%B4", "1b1c0f8c-68b0-4001-a908-2d779a86f6b5", new DateTime(2022, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "MaiThu_Do83@hotmail.com", "Hải San Tô", 1, "MAITHU_DO83@HOTMAIL.COM", "MAITHU_DO83@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBEnEaWLRU125Kq9xhkhM9JBgT/fsq9bMELvbVpGsHrYWKyr9GV2UURpJkEIVG+VSA==", "021 4585 4420", "ee0d0a27-6e8f-4904-9886-8f214f97ec34", "MaiThu_Do83@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "05465 Hồ Summit", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Thy%20Khanh%20Tr%C6%B0%C6%A1ng", "b22ec521-57af-4c42-978f-1c9beba8e3c9", new DateTime(1999, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "HongThuy_Duong61@gmail.com", "Thy Khanh Trương", 2, "HONGTHUY_DUONG61@GMAIL.COM", "HONGTHUY_DUONG61@GMAIL.COM", "AQAAAAIAAYagAAAAEEWFFxjJ8cKcI1HeiRobodP17bVNDup86myKHGkxy+KD56mNOlQbkgZWvQFmMYJ5Ow==", "027 0033 1356", "099aff3e-224a-419a-8a34-9031e1b192ef", "HongThuy_Duong61@gmail.com" });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_DoctorId",
                table: "Schedules",
                column: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2012, 8, 19, 15, 19, 38, 285, DateTimeKind.Local).AddTicks(9774), 6, 7 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2004, 10, 5, 0, 8, 49, 260, DateTimeKind.Local).AddTicks(4550), 6, 19 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2007, 8, 13, 18, 40, 8, 883, DateTimeKind.Local).AddTicks(97), 10, 20, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2005, 5, 29, 18, 18, 28, 737, DateTimeKind.Local).AddTicks(7724), 6, 18, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2008, 8, 18, 20, 14, 3, 232, DateTimeKind.Local).AddTicks(982), 5, 13, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2020, 2, 26, 22, 9, 8, 887, DateTimeKind.Local).AddTicks(2866), 3, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2006, 4, 26, 3, 24, 14, 488, DateTimeKind.Local).AddTicks(8410), 10, 19, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "PatientId", "Status" },
                values: new object[] { new DateTime(2012, 10, 15, 3, 13, 10, 776, DateTimeKind.Local).AddTicks(4000), 20, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2003, 6, 19, 18, 57, 58, 881, DateTimeKind.Local).AddTicks(7219), 5, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2022, 7, 24, 19, 3, 1, 90, DateTimeKind.Local).AddTicks(7914), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2004, 8, 11, 16, 36, 5, 663, DateTimeKind.Local).AddTicks(4515), 2, 13, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2024, 5, 7, 15, 6, 8, 985, DateTimeKind.Local).AddTicks(9594), 7, 10 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2022, 1, 17, 7, 17, 29, 723, DateTimeKind.Local).AddTicks(1479), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(1999, 12, 8, 6, 30, 27, 483, DateTimeKind.Local).AddTicks(8883), 5, 13, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(1996, 5, 13, 3, 4, 9, 357, DateTimeKind.Local).AddTicks(7462), 8, 13, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "PatientId" },
                values: new object[] { new DateTime(2016, 7, 1, 10, 42, 34, 451, DateTimeKind.Local).AddTicks(4279), 14 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "PatientId", "Status" },
                values: new object[] { new DateTime(2000, 1, 24, 22, 53, 45, 690, DateTimeKind.Local).AddTicks(8785), 15, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(1997, 9, 16, 18, 57, 35, 32, DateTimeKind.Local).AddTicks(4421), 10, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(1994, 12, 1, 7, 37, 3, 78, DateTimeKind.Local).AddTicks(4451), 3, 12, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2003, 2, 12, 21, 33, 18, 701, DateTimeKind.Local).AddTicks(7820), 4, 9, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2006, 7, 10, 23, 37, 27, 258, DateTimeKind.Local).AddTicks(3429), 2, 18 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(1997, 9, 30, 2, 37, 23, 752, DateTimeKind.Local).AddTicks(1069), 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2012, 12, 1, 15, 41, 2, 763, DateTimeKind.Local).AddTicks(2720), 5, 13, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppointmentDate", "PatientId", "Status" },
                values: new object[] { new DateTime(1996, 1, 23, 2, 29, 13, 310, DateTimeKind.Local).AddTicks(5557), 9, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2010, 3, 28, 22, 42, 4, 638, DateTimeKind.Local).AddTicks(4952), 10, 15 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2020, 3, 24, 8, 52, 7, 150, DateTimeKind.Local).AddTicks(6628), 6, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AppointmentDate", "DoctorId" },
                values: new object[] { new DateTime(2008, 2, 11, 6, 38, 17, 315, DateTimeKind.Local).AddTicks(6517), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2014, 8, 24, 21, 30, 0, 56, DateTimeKind.Local).AddTicks(945), 1, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(1999, 1, 11, 19, 22, 39, 398, DateTimeKind.Local).AddTicks(2903), 2, 18 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2020, 12, 8, 22, 18, 38, 53, DateTimeKind.Local).AddTicks(5963), 4, 14, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2016, 10, 18, 21, 52, 30, 856, DateTimeKind.Local).AddTicks(361), 1, 14, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2001, 5, 25, 8, 58, 36, 403, DateTimeKind.Local).AddTicks(4922), 10, 14, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AppointmentDate", "PatientId", "Status" },
                values: new object[] { new DateTime(2003, 1, 31, 8, 37, 37, 701, DateTimeKind.Local).AddTicks(856), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2015, 12, 3, 14, 31, 48, 223, DateTimeKind.Local).AddTicks(547), 10, 8, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2006, 5, 13, 19, 8, 25, 370, DateTimeKind.Local).AddTicks(1692), 6, 7, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2013, 6, 27, 3, 23, 16, 314, DateTimeKind.Local).AddTicks(4665), 1, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AppointmentDate", "PatientId" },
                values: new object[] { new DateTime(2009, 5, 18, 0, 18, 26, 684, DateTimeKind.Local).AddTicks(641), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 11, 3, 15, 4, 0, 935, DateTimeKind.Local).AddTicks(2181), 7, 16, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2005, 9, 14, 14, 4, 1, 840, DateTimeKind.Local).AddTicks(7309), 3, 16 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AppointmentDate", "PatientId", "Status" },
                values: new object[] { new DateTime(1997, 2, 7, 6, 17, 16, 752, DateTimeKind.Local).AddTicks(5201), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Aliquam vero repellat debitis tempore.", 4, 19 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Nulla tempore similique et architecto sunt saepe vel est.", 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Ducimus magni dolores est aut ducimus.", 5, 13 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Aliquid facere accusamus rem et consequuntur.", 2, 14 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Est voluptates omnis eum vel fugiat excepturi.", 3, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Nisi est quia veritatis voluptatibus accusantium blanditiis facere velit.", 1, 14 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Quasi facere rerum autem illo possimus.", 2, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Minus soluta vero corporis qui sit et voluptas.", 12 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Dicta vel recusandae nesciunt doloremque excepturi explicabo voluptas totam aut.", 1, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Voluptatem est at molestias nisi facere et ab et.", 2, 18 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94007c83-3024-4d4a-8a77-b35f71fb4417", "AQAAAAIAAYagAAAAEORc7bGC+deVrsYiA1NszXLyzBlDv1KeupCuEMern6cmI7E1G3ZN/SHPoZu5zFa5Ng==", "5bb30bd9-b786-4313-9a47-bfab9f334493" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "237 Rau Valley", null, "05c9eb30-22b9-4207-9755-64f31c4449a8", null, "Nelda.Beatty21@hotmail.com", "Tess Hagenes", null, "NELDA.BEATTY21@HOTMAIL.COM", "NELDA.BEATTY21@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBeE6n2GABc2uTpdrBrQ7IGddZ5yFkHS2Rk71UpSLP47AfXpz2wBuVIDQA/qZCp9oA==", "386.292.5786", "99bb14d0-1ff6-4325-8097-ee33d8dd6aff", "Nelda.Beatty21@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "934 Murl Cape", null, "06677116-b98b-497f-bd46-ccaa32ec42d4", null, "Wilfrid12@hotmail.com", "Bertha Funk", null, "WILFRID12@HOTMAIL.COM", "WILFRID12@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEv0qiLpkBOEtR82TfRoa4BXLVsbYsWXo1Zf5ctB9dE/UCgPPTi7EiMPSXnQuOyh7Q==", "1-693-489-3139 x9981", "394f41f6-97eb-4798-96cb-a75d64d5dc87", "Wilfrid12@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3154 Gusikowski Shoals", null, "0ab179a2-b9b9-4a65-af31-16a7315859f0", null, "Tatyana.Beatty75@yahoo.com", "Nellie Ruecker", null, "TATYANA.BEATTY75@YAHOO.COM", "TATYANA.BEATTY75@YAHOO.COM", "AQAAAAIAAYagAAAAEKOvsW6jYy4LBJkxNtJTel0x6UId7+uIS+8Xl/g4hRVztjFbO2/eug7jxvFrQQdD9g==", "1-805-915-5337", "7bd866b3-40ca-4a75-8dc8-d1239f198485", "Tatyana.Beatty75@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "12957 Raoul Gateway", null, "23c7edf8-2993-4f51-8739-5e7a594c6a9e", null, "Kelton19@hotmail.com", "Rosalinda Hayes", null, "KELTON19@HOTMAIL.COM", "KELTON19@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKyB4GcfkthZ/JqVyLN9oQT2K54owCTsTunzWQEBktLQm6LT8vHpkmuXkOsTR/M2zw==", "(372) 249-1632 x741", "ce6fd451-61a9-47a5-9d58-93fb3e9edf41", "Kelton19@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0391 Wuckert Drive", null, "f55de45d-506d-4247-8dce-ee2ee1bb3cc8", null, "Bonita_Maggio@yahoo.com", "Vernie Gleason", null, "BONITA_MAGGIO@YAHOO.COM", "BONITA_MAGGIO@YAHOO.COM", "AQAAAAIAAYagAAAAEGFwK9Q7VmlsudWEixK2VOwW0rqFYiwZCD6y4lQAaTzGHNyuy7PpR4mDxCFVb+Nu7Q==", "(550) 433-6983", "5717103d-223f-493a-bfc9-e42f7c71dbe5", "Bonita_Maggio@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "48260 Jackeline Port", null, "e6276069-237d-4f38-a926-f5d058b72d51", null, "Frank_Langosh@gmail.com", "Marianne Denesik", null, "FRANK_LANGOSH@GMAIL.COM", "FRANK_LANGOSH@GMAIL.COM", "AQAAAAIAAYagAAAAEJR0GXwv/dCjtDSIVMb9OCYv0etxfGvAChyQik90szkSsFr2TsSutT0/NLqzcSdIlw==", "265-729-1434 x8989", "8b99890f-b51e-4fa7-a4d0-92ad21c9b795", "Frank_Langosh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2307 Karianne Stravenue", null, "18b39181-fbd0-4fa9-8cd5-d470ecb91ea0", null, "Frederic.Keeling49@yahoo.com", "Myrtle Littel", null, "FREDERIC.KEELING49@YAHOO.COM", "FREDERIC.KEELING49@YAHOO.COM", "AQAAAAIAAYagAAAAEBcb+175HvjmeZWNi6wy/vp0QUY49GsfRsEPNBxkQBB/pza4UEdFL6q5O+LOCa8tqg==", "881.728.2385 x564", "7fbb0492-60fb-4d3e-9359-8fe7a7331a43", "Frederic.Keeling49@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "451 Smitham Drive", null, "1a94c557-bb10-4421-a7bf-593235b90609", null, "Miguel.Stark24@yahoo.com", "Emil Hegmann", null, "MIGUEL.STARK24@YAHOO.COM", "MIGUEL.STARK24@YAHOO.COM", "AQAAAAIAAYagAAAAEPW84hwRmQCFg/uHURXJfE9ShATbPwrnuKet0N0jQ7xI/T4SUtd6PtVIdxg5TgMzPw==", "798-424-2955 x399", "f47a416a-196c-43ab-b808-8ddb6eabdacf", "Miguel.Stark24@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4840 Leuschke Plains", null, "008be66e-ba61-4e7f-991e-3f1f2391326a", null, "Darrell.Lakin@yahoo.com", "Alyson Larson", null, "DARRELL.LAKIN@YAHOO.COM", "DARRELL.LAKIN@YAHOO.COM", "AQAAAAIAAYagAAAAEJUrhL29ueW7ILqY6hFy0cbzTydCSbq1q2Jr/RWguB4ZyhBHun6/IBbqap7z8aRYhg==", "(267) 887-1121", "92d9d3ac-d912-44a0-ab21-d98c87a7f235", "Darrell.Lakin@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "471 Santino Turnpike", null, "c06ade12-cec7-46b6-ae35-442aa4b2d81c", null, "Fidel74@yahoo.com", "Troy Koch", null, "FIDEL74@YAHOO.COM", "FIDEL74@YAHOO.COM", "AQAAAAIAAYagAAAAEH4boPPNx9Pwq98QiFbRSVW3R3XicVSivOAdMJRi1fy39Z8Rh416yyENM6ecw8UyRw==", "(271) 515-9499", "b13dd230-ab0d-4219-aa8e-d660eff9be35", "Fidel74@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7622 Collier Forge", null, "68b6963f-7200-4869-a9d7-53daaf43b9ee", null, "Gracie_Gleichner34@gmail.com", "Randal Waelchi", null, "GRACIE_GLEICHNER34@GMAIL.COM", "GRACIE_GLEICHNER34@GMAIL.COM", "AQAAAAIAAYagAAAAEGW6hPHoYEfpxltXbT6pUuqPZHulAmmeGTslC0HxQSflDx1y44fNbuydSRMq9dK6+Q==", "671.963.6357", "1c4fb973-203f-45ae-87c0-1a1b1bd03c9a", "Gracie_Gleichner34@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "30364 Sawayn Brooks", null, "c31440f6-2f57-403d-b4a1-80cc118da61e", null, "Cassandra.Langosh39@hotmail.com", "Luz Wilderman", null, "CASSANDRA.LANGOSH39@HOTMAIL.COM", "CASSANDRA.LANGOSH39@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPE3AMI9wCwVQVT7Olh4tTjtGn9Mhv3eaVpyoM75JwacAeBtBFeRa1w8iyw0+XLdgg==", "376-258-9676", "0f0ee7a9-852d-4ad4-a300-67cb80c92f27", "Cassandra.Langosh39@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "88971 Antonina Forks", null, "0ef99e28-c599-4d14-977b-d8821e767e6b", null, "Terrill.McKenzie@yahoo.com", "Paolo Runolfsdottir", null, "TERRILL.MCKENZIE@YAHOO.COM", "TERRILL.MCKENZIE@YAHOO.COM", "AQAAAAIAAYagAAAAEPEKhGLBVuRue4+DEzC5IdTaRi9zA1Sv3w+3k5VpmGbxK5hixgYfdPUdjOT+zb9W8A==", "1-533-202-7814 x0682", "540d4ff3-a251-4207-9503-7c3c8e5a6877", "Terrill.McKenzie@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "379 Jones Junction", null, "c8574b3d-eb0c-4d10-9b34-7d904b1f686a", null, "Leilani_Medhurst87@yahoo.com", "Xander Kerluke", null, "LEILANI_MEDHURST87@YAHOO.COM", "LEILANI_MEDHURST87@YAHOO.COM", "AQAAAAIAAYagAAAAEDdfgnnvuwEtGQ+le3HK6c4jqLCaLHfLg4kvm4pOicDGm+ivewp/jIvKugWSxRsWzg==", "477-354-1196 x024", "6caedc93-20ad-4517-8ebf-ccff36a482d4", "Leilani_Medhurst87@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "87381 Beier Mountain", null, "f1577a5c-827f-411b-8b1b-a6549c544ccb", null, "Sadye.Reynolds@hotmail.com", "Esmeralda Welch", null, "SADYE.REYNOLDS@HOTMAIL.COM", "SADYE.REYNOLDS@HOTMAIL.COM", "AQAAAAIAAYagAAAAEA3Uau8f4VlVrHOdLeKheBodNxXOq9W0etls4c4f9ZfMPSFL46q5YechOu5eOHiRaQ==", "(425) 384-6812 x2371", "356012c0-973d-4055-aea1-59ef8947785c", "Sadye.Reynolds@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "38100 Sporer Motorway", null, "3937a063-0d91-4981-85c3-7bbd4a6ea0f5", null, "Ethel13@hotmail.com", "Marcelino Macejkovic", null, "ETHEL13@HOTMAIL.COM", "ETHEL13@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIe6NGz1YTENY2K5T7gpoxenneSrvneYkk/wtz3eUyoUi38hA06rKMeFhA1SqUr/+A==", "232.589.7860 x291", "68e0d4a0-ff5d-4acc-93b5-5f2b525c6739", "Ethel13@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "633 Whitney Plaza", null, "c5f56100-df6c-4890-bfab-4bf7aae0d7e4", null, "Maya.Jacobs@gmail.com", "Daphne Schulist", null, "MAYA.JACOBS@GMAIL.COM", "MAYA.JACOBS@GMAIL.COM", "AQAAAAIAAYagAAAAEKKKgzIH8FBMSAOuVn+doOXsMnOtwLOf1IgSwWIaTwlsdfvTuCUAH24c3DX/j+/G7g==", "1-700-267-5843 x34253", "9a59aad5-3fe5-4e5e-8525-a2a15ac322b2", "Maya.Jacobs@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3707 Strosin Villages", null, "c92416e5-1f12-4019-8176-313947e71fc2", null, "Issac.Halvorson38@gmail.com", "Roberta Walsh", null, "ISSAC.HALVORSON38@GMAIL.COM", "ISSAC.HALVORSON38@GMAIL.COM", "AQAAAAIAAYagAAAAEKrnPGUdWsnyFBN/DfFv/wQefSGdTgh6Seqz+/ghlUciNYAvvNPlVdIFGV1FgoyxVg==", "673.721.4367", "dd0269c1-eb02-4501-8d80-032e4e30ced3", "Issac.Halvorson38@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "09793 Melissa Centers", null, "f79f9cbf-f057-4559-ba58-9587700a912d", null, "Noemi.Koch83@yahoo.com", "Electa Will", null, "NOEMI.KOCH83@YAHOO.COM", "NOEMI.KOCH83@YAHOO.COM", "AQAAAAIAAYagAAAAEBsPwTlT6Ge3F4wtxbHgSCIepvlfojbSs0ZqZb3ILoDhCI0BtM2E+wjv+YL7OkR5jw==", "1-208-846-1429", "f24ce1df-3d5f-4b48-b25d-bc1041f42e25", "Noemi.Koch83@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "958 Padberg Dam", null, "29ba0cc0-974a-49af-b158-53530dbdda4f", null, "Jaden.Mraz46@gmail.com", "Rocio Koch", null, "JADEN.MRAZ46@GMAIL.COM", "JADEN.MRAZ46@GMAIL.COM", "AQAAAAIAAYagAAAAEOnzJhV0SwxUKFTThOqL7pKoVRynmVzc59nQFQGTYIoDkIsndkZ12f64OMr4d+Vgdg==", "429.780.3939 x016", "e323c78c-0bdb-428d-9551-62177d3aee52", "Jaden.Mraz46@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4116 Kuvalis Skyway", null, "2ffc08ac-76b1-45a1-a54c-6ce3c0c0278c", null, "Trevion.Schuster55@yahoo.com", "Heather Terry", null, "TREVION.SCHUSTER55@YAHOO.COM", "TREVION.SCHUSTER55@YAHOO.COM", "AQAAAAIAAYagAAAAENwDuPCyH2tTBp0FEu1Jwxb1JrPYJ+2euDuBOUwRd1nJT9DWoZtDcn/tl8okyW86Tg==", "681.803.0040 x5351", "2c8dabaa-b2e3-4d93-8c53-c6e7f3eb9bef", "Trevion.Schuster55@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "00861 Elvie Mission", null, "73a8017a-b49a-4b87-a522-820de44bcb7d", null, "Lera_Batz@yahoo.com", "Bennie Koepp", null, "LERA_BATZ@YAHOO.COM", "LERA_BATZ@YAHOO.COM", "AQAAAAIAAYagAAAAEMsYi+Qu0wKfMbuBcpVV87Qflwrb4ErNgL1L6NALV2LQJD5n8xb2MS7GfFplfo9/MA==", "(265) 239-5938", "30a2786e-f01a-4765-8e72-0983222969fe", "Lera_Batz@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "199 Brook Stream", null, "f784bf99-f26c-47b9-8ba0-e1f3808a6366", null, "Assunta69@hotmail.com", "Mina Brakus", null, "ASSUNTA69@HOTMAIL.COM", "ASSUNTA69@HOTMAIL.COM", "AQAAAAIAAYagAAAAELkwBdpdG+zhCfhREFK+mvtnM2C87RWIlBXLVhXrbtroMNG5o4oEwaMvxhig/49QHA==", "345.970.8297 x669", "a2f3e2f7-b425-4dfa-af6a-3a5b0c2a98e7", "Assunta69@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5028 Quinn Street", null, "5a3a60ed-482c-4940-bed6-db00d3217505", null, "Deja86@yahoo.com", "Krystina Dibbert", null, "DEJA86@YAHOO.COM", "DEJA86@YAHOO.COM", "AQAAAAIAAYagAAAAECFyRugoz4dgVhdwvKMjiy47/LCHroBtke+iZajgaqKBVpLQd2AAPRRD+9YH+Tql+Q==", "379.595.0326", "0bddd0e2-5c64-49c6-b043-8976b4e45b3b", "Deja86@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4978 Kunze Harbor", null, "9fe051eb-d304-4995-8f2e-4b7c5d540ba1", null, "Corbin0@hotmail.com", "Daren Strosin", null, "CORBIN0@HOTMAIL.COM", "CORBIN0@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIK0WrJ2Igq22nyyyxjemqn8v8C8uWa77ZJVx/DOmlDMeCeQU/oaL2PPJzL45XxWGQ==", "947.492.1521 x082", "b3900445-92c1-4cbf-b638-9ffc7668c848", "Corbin0@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "08779 Baumbach Plaza", null, "de33fdd5-d4f1-4c14-bbac-e74fca0a3dd3", null, "Leonie80@gmail.com", "Fiona Crona", null, "LEONIE80@GMAIL.COM", "LEONIE80@GMAIL.COM", "AQAAAAIAAYagAAAAEAC/1T+tohDwN5sFH35Alnbl8fkez2FZlStXl5LJiXL2GwsycrJ+apM9CLjLKKpc0A==", "1-715-785-5841 x290", "3168f25a-8e31-4dad-922d-fd529777303a", "Leonie80@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3570 Ernser Ports", null, "09e8a6cf-9e80-49bd-9a54-050fbe6720bc", null, "Penelope.Fisher25@gmail.com", "Dayne Berge", null, "PENELOPE.FISHER25@GMAIL.COM", "PENELOPE.FISHER25@GMAIL.COM", "AQAAAAIAAYagAAAAEOoL35pF+/bbFHYWgw2L0eP5p9W+MMxDF5icrYQ3uNnrKFEbwoRabns9a73P2XbwiQ==", "(454) 512-5946", "f6fb71cf-35ef-4f8e-ae46-31d59459aa5d", "Penelope.Fisher25@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7071 Ritchie Heights", null, "1c992531-2a63-4516-9637-5d896fd687ef", null, "Arlo_Schumm@hotmail.com", "Gordon Douglas", null, "ARLO_SCHUMM@HOTMAIL.COM", "ARLO_SCHUMM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEafqGk1BOM/V4Mnh8kt7bQK6PTargqiYnphj2D01d7esMHyWr5bOkvSXDDzI8iURw==", "974-579-9035 x483", "0d4b9040-4237-4fdf-9f58-60d52dfcf304", "Arlo_Schumm@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "259 Kertzmann Road", null, "da6b86b8-cc7e-4982-acc2-982cfbcad489", null, "Arlo_Ernser79@yahoo.com", "Heather Roberts", null, "ARLO_ERNSER79@YAHOO.COM", "ARLO_ERNSER79@YAHOO.COM", "AQAAAAIAAYagAAAAEDjALJN6sya63e0YNFLmBNAJHaEaKQLx5EaNB6e8cVHTniotQFuElbdTgcp3Yc+oKg==", "(932) 838-0968 x08962", "fa17438c-fb1a-4840-94df-1217bcebbf6e", "Arlo_Ernser79@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0089 Retta Lodge", null, "e6ce76c6-6d88-472d-969b-086233760f32", null, "Creola_Steuber@gmail.com", "Christy Harber", null, "CREOLA_STEUBER@GMAIL.COM", "CREOLA_STEUBER@GMAIL.COM", "AQAAAAIAAYagAAAAEA3Pm4zE2BM1PdGnYttRjtmA4wWOx9volwGQifwQwRAuxjOXxqWmTEUI/FV3octA1w==", "770.205.4429 x646", "74070d76-d119-4e51-8ab7-f280144f4a98", "Creola_Steuber@gmail.com" });
        }
    }
}
