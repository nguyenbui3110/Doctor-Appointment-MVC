using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorAppointment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAppointmentStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 14, 0, 0, 0), 17, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), 15, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 9, 0, 0, 0), 8, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), 14, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 10, 0, 0, 0), 9, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 15, 0, 0, 0), 9, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 10, 0, 0, 0), 4, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 15, 0, 0, 0), 3, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "PatientId", "Status" },
                values: new object[] { new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 18, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 13, 0, 0, 0), 7, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 9, 0, 0, 0), 20, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 13, 0, 0, 0), 15, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 15, 0, 0, 0), 3, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), 10, 12, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 9, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 0, 0, 0), 9, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { 5, new TimeSpan(0, 14, 0, 0, 0), 7, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 9, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 12, 0, 0, 0), 2, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), 18, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 17, 0, 0, 0), 19, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 0, 0, 0), 18, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), 6, 9, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 14, 0, 0, 0), 13, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), 13, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 16, 0, 0, 0), 19, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 4, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 12, 0, 0, 0), 4, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), 16, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 13, 0, 0, 0), 8, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 9, 0, 0, 0), 14, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 12, 0, 0, 0), 19, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 17, 0, 0, 0), 5, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), 10, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), 11, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 14, 0, 0, 0), 8, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 0, 0, 0), 17, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 16, 0, 0, 0), 1, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Chìm núi độc trăng.", 1, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Hết á mây ừ ừ bốn máy trời vá tàu.", 5, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Là khoan hương biển phá biết chín cửa ờ giết.", 5, 11 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Á cửa nhà máy việc.", 4, 12 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Ba kim á đánh.", 4, 11 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Khoan cửa đỏ đang sáu yêu đâu xanh đánh ghét.", 1, 12 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Trời nước hết thôi bảy chìm bạn.", 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Tui chìm tôi phá tui ác lỗi trăng.", 3, 19 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Vàng độc sáu vá thuê khoan hương.", 5, 20 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Viết anh áo vàng đỏ đỏ quê.", 5, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "152a1493-69bb-476a-b8de-7c7049421fbc", "AQAAAAIAAYagAAAAEDBGa26j5lAHVIy6Zw4r2APlA2HGMf0FygqbvId9C0/cWGbx5AtIue8+REJK76jBIg==", "f9b0a836-c26c-47c4-b082-d64215d70e93" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "756 Quang Danh Oval", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Tr%C3%BAc%20C%C6%B0%C6%A1ng%20%C4%90%E1%BB%97", "ba3a3f87-6ff9-48cd-88c0-634cd232f42a", new DateTime(2014, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "PhiDiep.Duong34@yahoo.com", "Trúc Cương Đỗ", 2, "PHIDIEP.DUONG34@YAHOO.COM", "PHIDIEP.DUONG34@YAHOO.COM", "AQAAAAIAAYagAAAAEAcwDybrhF5VRdDg6v0sCEpMSW20qkEdyPCTDNmHXvGTgXtI1cUQhadI6A/Y8Eb9/g==", "025 3832 8164", "190430da-da7c-4808-b56f-0c803ec16d40", "PhiDiep.Duong34@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "197 Tuyết Lâm Forest", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Ng%E1%BB%8Dc%20C%E1%BA%A3nh%20L%C3%A2m", "79a8396d-7f27-4115-91bc-fcb39a6fa02f", new DateTime(2007, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "ThanhThuan_Pham@yahoo.com", "Ngọc Cảnh Lâm", 3, "THANHTHUAN_PHAM@YAHOO.COM", "THANHTHUAN_PHAM@YAHOO.COM", "AQAAAAIAAYagAAAAEGNgudcUaJiUrakx5dE2hdRdbAw5TS6SNQFkFU6sJbbZ0kbLmVZKvjPnXUZAT6l4HA==", "0235 2185 3539", "a05b4e68-4ac2-4415-8f96-59b89c4abcfc", "ThanhThuan_Pham@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "132 Ngân Trúc Overpass", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Nguy%C3%AAn%20Nh%C3%A2n%20V%C5%A9", "7889e3f9-4363-40b0-b6b8-8f4b4c4b7e5e", new DateTime(2018, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "BaoChan.Nguyen14@yahoo.com", "Nguyên Nhân Vũ", "BAOCHAN.NGUYEN14@YAHOO.COM", "BAOCHAN.NGUYEN14@YAHOO.COM", "AQAAAAIAAYagAAAAEL8bi7i7tc9KlbKO/1JuHvXEJnGgISt2nvRETthZOePb8+QeEUINrP+HzK5t24pnWQ==", "024 9350 4494", "18989a79-4330-4f25-baf5-20f5aee50622", "BaoChan.Nguyen14@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "236 Quỳnh Lâm Road", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Huy%20Th%C3%A0nh%20V%C5%A9", "845f6be3-cf21-47d2-aee4-c1486a47425c", new DateTime(2019, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), "ThanhCong33@hotmail.com", "Huy Thành Vũ", 3, "THANHCONG33@HOTMAIL.COM", "THANHCONG33@HOTMAIL.COM", "AQAAAAIAAYagAAAAENRahaZrJ5hCQh42xSGt3Rl57NVwGKxRukkuUvLDR9WPD01cCfotaQbKBqp0Q5FXcg==", "0203 6314 6742", "1fec9dd9-94b9-4fe6-bf7a-27d3d6abe4e1", "ThanhCong33@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "733 Tăng Terrace", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Nam%20H%E1%BA%A3i%20%C4%90%E1%BA%B7ng", "35322d4a-403f-4b95-a64e-27604b43c620", new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), "BichVan.Trinh@gmail.com", "Nam Hải Đặng", 2, "BICHVAN.TRINH@GMAIL.COM", "BICHVAN.TRINH@GMAIL.COM", "AQAAAAIAAYagAAAAEHLnsvbEWA1A4a5/ZmJuZ4WMS4gYzzzw0jhkwCnj8zBQH27RLMWN1APZxURm859AMQ==", "0214 6673 5945", "1ca79c42-9257-4a18-a81c-2ba20eff64d6", "BichVan.Trinh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9333 Phạm Views", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=H%E1%BA%A1c%20C%C3%BAc%20L%C3%A2m", "e72a80b2-3d7f-4500-8be0-718f8eeb84d3", new DateTime(2014, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "BaoNgoc_Ho12@hotmail.com", "Hạc Cúc Lâm", 1, "BAONGOC_HO12@HOTMAIL.COM", "BAONGOC_HO12@HOTMAIL.COM", "AQAAAAIAAYagAAAAECSTFnKi0XfZaKnrCVqovWRzrq/uNYpTeqVObeY6tBOliJTOAB1EQa//fyFSSeSRMg==", "026 2635 2479", "42d29edd-8ac3-414a-9849-787f01631eaf", "BaoNgoc_Ho12@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "089 Thục Vân Ramp", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Chi%C3%AAu%20Phong%20T%C3%B4", "6ac2ee32-8cc6-4054-ae26-9eb343170358", new DateTime(2005, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), "MinhKhue_Do@gmail.com", "Chiêu Phong Tô", 1, "MINHKHUE_DO@GMAIL.COM", "MINHKHUE_DO@GMAIL.COM", "AQAAAAIAAYagAAAAEAASmLr/OohLx5JjFte6rC/FZ4egd9dcz94VQJE0iAaCJH8S2RrGCBCAhZBGtKJb+w==", "0243 7574 8277", "d687310a-fae5-4a34-9212-9e0fa4a72b53", "MinhKhue_Do@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "108 Dương Island", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Trang%20Anh%20T%C3%B4", "725fb1fd-efb8-44e6-8498-3ebbeac6ba5c", new DateTime(2004, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "AnNguyen93@yahoo.com", "Trang Anh Tô", 3, "ANNGUYEN93@YAHOO.COM", "ANNGUYEN93@YAHOO.COM", "AQAAAAIAAYagAAAAEKOIozmV1FbRRET1Npf368xfPpTAXCg/rahqfdxHeahJTc4wJbghsQmidI4CgWq0VA==", "026 8206 6252", "6cf7ba95-f55f-40cb-a819-29f34b187cfb", "AnNguyen93@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6721 Dương Bridge", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Ho%C3%A0i%20Nam%20H%C3%A0", "16a0f25f-333f-468a-982f-49b8a0b1f4e4", new DateTime(2001, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "DaThi_Trinh7@hotmail.com", "Hoài Nam Hà", 1, "DATHI_TRINH7@HOTMAIL.COM", "DATHI_TRINH7@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMRtO3mw7y0v4JJPETItmbB2zxK82ojDoQ7wpUO83JMI1bz0fHYs6eK8y+RM06eunQ==", "021 9581 7113", "1b9fec8b-dd90-42db-8968-a5a0f415830a", "DaThi_Trinh7@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3551 Mỹ Dung Walks", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Linh%20Duy%C3%AAn%20Nguy%E1%BB%85n", "b6f6708e-e23c-432a-8ded-b330aedcdcc9", new DateTime(2014, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "XuanAn_Nguyen4@yahoo.com", "Linh Duyên Nguyễn", 1, "XUANAN_NGUYEN4@YAHOO.COM", "XUANAN_NGUYEN4@YAHOO.COM", "AQAAAAIAAYagAAAAEO5E0jF5sv3FDwzzczp8EQLPYQeVC8dbwg8JxQ+EoG8z77PBoJlMevli1rhaORf9/Q==", "020 8667 2005", "1ccee25e-b591-4d41-9794-6625f64ee568", "XuanAn_Nguyen4@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "11193 Bùi Green", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Ng%E1%BB%8Dc%20Di%E1%BB%87p%20V%C5%A9", "4bae9b48-b6fe-4e5a-b514-ce895f39afcf", new DateTime(1997, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "HaiLy0@hotmail.com", "Ngọc Diệp Vũ", 3, "HAILY0@HOTMAIL.COM", "HAILY0@HOTMAIL.COM", "AQAAAAIAAYagAAAAEG431izHtbPvQkf4vlHkQ5XkwloW8tXS44BMqenxhHm3Ifbd/ddyKPXR6FFAoQ+C9Q==", "020 6823 7098", "19b11144-b8b0-494f-a352-c4b0c237223a", "HaiLy0@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "44888 Nguyễn Roads", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Li%C3%AAn%20Ki%E1%BB%87t%20T%C3%B4", "30209df0-e1e1-48d3-abdc-9694eb614ac7", new DateTime(2005, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "ThaiDuc76@gmail.com", "Liên Kiệt Tô", 2, "THAIDUC76@GMAIL.COM", "THAIDUC76@GMAIL.COM", "AQAAAAIAAYagAAAAEC3VU6yyrC/0r0SwMREx0j8gIxKj5+x6tLyYEVp2UxmrsalbKIEaOlJvwo+BkoAq3w==", "029 2987 5699", "46a619e0-bf72-40ff-8136-78b02c2acf42", "ThaiDuc76@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "42205 Diệu Linh Drive", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Hu%E1%BB%87%20An%20B%C3%B9i", "deb4666a-6d68-4e5f-96bb-9eb59ecb97b8", new DateTime(2018, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), "KhacViet.Dang@yahoo.com", "Huệ An Bùi", 3, "KHACVIET.DANG@YAHOO.COM", "KHACVIET.DANG@YAHOO.COM", "AQAAAAIAAYagAAAAEO8DOYxuyoTt0ifzWk3WTJc6+kuSrlzeRvwM8pW5kDTIVEQuOOMkodoA51Ihhjyvqg==", "0250 9055 1902", "3a5d62be-73a6-485b-9134-e95f7a5c2a24", "KhacViet.Dang@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4709 Phúc Duy Islands", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Qu%C3%A2n%20D%C6%B0%C6%A1ng%20L%C3%AA", "92bbd079-559c-4bcd-a4df-d6ba5e40b207", new DateTime(2003, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "LanThuong47@gmail.com", "Quân Dương Lê", 3, "LANTHUONG47@GMAIL.COM", "LANTHUONG47@GMAIL.COM", "AQAAAAIAAYagAAAAEKKfMi1Zitoy19iJc2cQnte4GcCthTNZ8hSlIYApQRne7R3rEPAd1+DWYqkJAlRiPA==", "026 6328 9354", "6a054f34-8a7d-40bb-b200-09ca740f2505", "LanThuong47@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "68190 Hoàng Drives", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Giang%20Lam%20Mai", "caaaa43e-e88d-4b0b-b545-1cd9713cceae", new DateTime(2022, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "TamHien28@gmail.com", "Giang Lam Mai", "TAMHIEN28@GMAIL.COM", "TAMHIEN28@GMAIL.COM", "AQAAAAIAAYagAAAAELpYA9gIIfl9VPOOUIFTJ07f53ebmX23ZDEqffpLzVsxw1/87EadCuIck4ggB4nu3A==", "0252 5405 5779", "a52e9fd8-28ed-466d-8ece-8fdf94cfb743", "TamHien28@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "29461 Đặng Brook", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Di%E1%BB%85m%20Ch%C3%A2u%20Phan", "9814254f-c57b-4719-b328-1ff58c33db71", new DateTime(2012, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "BaoHuynh.Pham66@gmail.com", "Diễm Châu Phan", 2, "BAOHUYNH.PHAM66@GMAIL.COM", "BAOHUYNH.PHAM66@GMAIL.COM", "AQAAAAIAAYagAAAAEBWuN+RD9AHX9R23oWVuEmBHomlNPnV/a0mA4YbheKn46/WGQhg1REygvSChb8raIg==", "0246 9028 3711", "814f0a0a-655f-4d6b-8e50-d1cc9222a96d", "BaoHuynh.Pham66@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "425 Đỗ Light", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Huy%20Tr%C3%A2n%20B%C3%B9i", "1333637f-0eec-4a1b-8f5d-ec691fb721c2", new DateTime(1996, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "ThuyVan_Do@yahoo.com", "Huy Trân Bùi", "THUYVAN_DO@YAHOO.COM", "THUYVAN_DO@YAHOO.COM", "AQAAAAIAAYagAAAAEL5Cnf0S/9ZJwFsNfzAeDFfEqCSILwBkMT+qbyH8O9X6WfZfrAMroflUdvNy4N79Lg==", "025 0979 8459", "16b122ea-a866-458e-8666-2c8df5dc2327", "ThuyVan_Do@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "166 Uyển Khanh Circles", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Qu%E1%BB%B3nh%20Hoa%20%C4%90o%C3%A0n", "0facb7a1-3511-453d-b3da-16597bb5ef27", new DateTime(1999, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), "HongPhuc_Le14@gmail.com", "Quỳnh Hoa Đoàn", "HONGPHUC_LE14@GMAIL.COM", "HONGPHUC_LE14@GMAIL.COM", "AQAAAAIAAYagAAAAEK3Mb6AFKU/NsllsZeVnFJ2QuO4c6uTFL+d2q9W7Ph92WOcI8qbg2L6PpgHk4H+f+g==", "021 5237 5654", "59b6afe9-7b6d-40ae-96fc-af12419791aa", "HongPhuc_Le14@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "60051 Nhân Sâm Courts", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Ph%C6%B0%E1%BB%A3ng%20V%C5%A9%20%C4%90%E1%BB%97", "36ad657e-ab54-44ee-a73a-7e01dd03d4ab", new DateTime(2014, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "KimThuy_Tang56@yahoo.com", "Phượng Vũ Đỗ", 1, "KIMTHUY_TANG56@YAHOO.COM", "KIMTHUY_TANG56@YAHOO.COM", "AQAAAAIAAYagAAAAEK3b+rjQfSAaxpMn5stiPOPS3V5xT5wEGnTdKQ4Q6GJ8BYk/b25wOwOKzTwV1Kg85w==", "023 2759 4168", "a3cec71b-4136-46e0-8c31-d86acf9f4f07", "KimThuy_Tang56@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "69627 Cao Kỳ Estate", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=V%C3%A2n%20Khanh%20Ph%E1%BA%A1m", "9d5120a8-23b9-4830-8926-e1da7ebc7a9a", new DateTime(2006, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "HongNhan26@yahoo.com", "Vân Khanh Phạm", 3, "HONGNHAN26@YAHOO.COM", "HONGNHAN26@YAHOO.COM", "AQAAAAIAAYagAAAAECk/bLAVgQ00OFiG5LWIggyFTfmSMh/6zntX7XSQMTnHGbmyOVj2mGiaKtBXM48Ssw==", "0231 7568 8503", "bd881814-a289-4ab6-8243-06a4a1649ef6", "HongNhan26@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6469 Lê Inlet", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Minh%20H%C3%A0o%20Tr%E1%BB%8Bnh", "10e68cac-0c98-47be-abe6-902716d2bfbb", new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "NgocDanh_Trinh@yahoo.com", "Minh Hào Trịnh", "NGOCDANH_TRINH@YAHOO.COM", "NGOCDANH_TRINH@YAHOO.COM", "AQAAAAIAAYagAAAAEBU6tP0NMk5WPidRuZGj26l2wxQrVMChuyL1/bzXUbl8CQtrO2sZx64YeN2EhYXA+Q==", "0277 5461 4331", "91f7f0fc-9378-430f-82c9-4c547d998fe4", "NgocDanh_Trinh@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "559 Việt Khải Lock", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Thanh%20Vinh%20V%C5%A9", "1e249409-6221-49c3-953f-bec65f33c313", new DateTime(1998, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "XuanThanh_Phung@gmail.com", "Thanh Vinh Vũ", "XUANTHANH_PHUNG@GMAIL.COM", "XUANTHANH_PHUNG@GMAIL.COM", "AQAAAAIAAYagAAAAEPauk2EpcHVK4B33I9y0gzCruxSSiQMJX+gPCmniAZwZQ1W2aWRorL1U0ZI8PLkPiw==", "0257 2135 7369", "e1090e4f-f286-4797-bcb0-f45e5fbb4854", "XuanThanh_Phung@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "099 Mạnh Trình Viaduct", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Kim%20Loan%20V%C5%A9", "b006bf0c-e836-46b7-a879-7eaa3d81cc59", new DateTime(2006, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "BinhMinh53@hotmail.com", "Kim Loan Vũ", 2, "BINHMINH53@HOTMAIL.COM", "BINHMINH53@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDePgyy579bGYvI07pnC2J8wUfeVcQcNpLtCK7TT7S36grcnDoIoP3yXhoQey+iTJQ==", "029 5650 0931", "6d31b9b8-1381-4c5e-811d-5b2872ad0997", "BinhMinh53@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "376 Phùng Cape", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=H%E1%BA%A3i%20Giang%20Ho%C3%A0ng", "fa694612-cfda-4fd4-95bd-4e90e7b7d247", new DateTime(2002, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "VietNhan19@hotmail.com", "Hải Giang Hoàng", "VIETNHAN19@HOTMAIL.COM", "VIETNHAN19@HOTMAIL.COM", "AQAAAAIAAYagAAAAEC+vcDBKZwBbBAU57awkkbvyJCo7nxoHQOwD/xYCx/n7tKXxeKYcMQ0m0jrWvYK6yw==", "0262 7294 6551", "d2718851-0d07-4a98-acaa-e826653ea49d", "VietNhan19@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "167 Đào Forest", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Thu%E1%BA%ADn%20Th%C3%A0nh%20Tr%E1%BA%A7n", "bf572741-e3ac-4ac5-a4ae-247c93f4d614", new DateTime(1997, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "DinhChuong3@gmail.com", "Thuận Thành Trần", 3, "DINHCHUONG3@GMAIL.COM", "DINHCHUONG3@GMAIL.COM", "AQAAAAIAAYagAAAAEKtePw5y05Fd8q8R0fXQ8O5aE1luWaRAU8YTP4jF+A8KUUVATs+82OoVblTT/a17Rw==", "020 4611 0499", "db5e87a1-3dde-4627-a831-8f96bb21a5f9", "DinhChuong3@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8672 Khang Kiện Village", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=C%C3%B4ng%20Lu%E1%BA%ADt%20L%C3%AA", "d698c9ee-0292-4c38-a11e-118c5cf7999f", new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "ThuanPhuong_Ngo@gmail.com", "Công Luật Lê", 2, "THUANPHUONG_NGO@GMAIL.COM", "THUANPHUONG_NGO@GMAIL.COM", "AQAAAAIAAYagAAAAEFrNU/g5nSfQ9497Oa+rBDw1/BFXj+e0FphfGTWm2TeH3S4xM7oc2U8xlmdOfCwq2Q==", "028 5977 1783", "8a1d097f-72c2-4195-a1a0-d4140cac608c", "ThuanPhuong_Ngo@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "49935 Tô Square", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Thanh%20Lam%20Tr%C6%B0%C6%A1ng", "d22c08dc-fe00-4fda-93a4-0c90febc9ae6", new DateTime(2009, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "ThucVan24@yahoo.com", "Thanh Lam Trương", 3, "THUCVAN24@YAHOO.COM", "THUCVAN24@YAHOO.COM", "AQAAAAIAAYagAAAAEEILkdxXg3Hm8D5SQjdf+jvR7uyEkobk/JaBDfwVE8f83vsqSPj7QYYGBBHz8OO25Q==", "027 6649 7547", "4183e5d3-b8e0-48a7-9097-0ad1a79dbaef", "ThucVan24@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0839 Nguyễn Lodge", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=C%E1%BA%A9m%20Linh%20L%C3%A2m", "6061aa7a-8f2e-400c-9db9-fcd3d7318b5b", new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "DatHoa39@gmail.com", "Cẩm Linh Lâm", "DATHOA39@GMAIL.COM", "DATHOA39@GMAIL.COM", "AQAAAAIAAYagAAAAEE8+nU6Qx7H7fGpJ4UnV0f3jALM4PiyfY6VRBft6lvNzpwE0P49FsrbKLv7if4KhrQ==", "0223 6547 8801", "10c8b80f-542d-43ed-9b87-12c135559d8e", "DatHoa39@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6335 Thúy Liễu Parks", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Lam%20H%C3%A0%20Nguy%E1%BB%85n", "502fbf8d-7636-4ca4-970e-82db29a80f63", new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "BichLien90@gmail.com", "Lam Hà Nguyễn", 3, "BICHLIEN90@GMAIL.COM", "BICHLIEN90@GMAIL.COM", "AQAAAAIAAYagAAAAEIyiUz9KnkuPVCTc0BJHy46q3OGL5s3arHUOjOuGou9TiVD5UiKJNr+7XUPSvlXh8w==", "0248 4027 3007", "910f2fa7-993e-4eef-b0f5-a2279ee42d12", "BichLien90@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "79383 Lâm Garden", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Minh%20Giang%20Ph%E1%BA%A1m", "685cc47b-e37c-44dc-808e-0ffd5e81c58a", new DateTime(2005, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "HaTien_Ngo@yahoo.com", "Minh Giang Phạm", "HATIEN_NGO@YAHOO.COM", "HATIEN_NGO@YAHOO.COM", "AQAAAAIAAYagAAAAEJh75HHMLhObPyVent6ILKpH0/NvkxeHIv33fZd/PyAm6xbjEBbWBUnV2h542ip7zw==", "0256 6507 5934", "84379ab0-f6e4-44ae-9a73-9a4b86d55cc1", "HaTien_Ngo@yahoo.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), 11, new TimeSpan(0, 10, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 9, 0, 0, 0), 5, new TimeSpan(0, 8, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), 10, 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 18, 0, 0, 0), 6, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 13, 0, 0, 0), 9, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), 6, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 16, 0, 0, 0), 17, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), 2, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { 8, new TimeSpan(0, 18, 0, 0, 0), 15, new TimeSpan(0, 17, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), 5, new TimeSpan(0, 10, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), 2, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 8, 13, 3 });

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
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), 15, new TimeSpan(0, 11, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), 3, 20 });

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
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), 13, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 16, 0, 0, 0), 6, new TimeSpan(0, 15, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 12, 0, 0, 0), 18, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), 11, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 18, 0, 0, 0), 10, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 15, 0, 0, 0), 16, new TimeSpan(0, 14, 0, 0, 0), 3 });

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
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Hàng tui mua xuồng núi anh khoan quần.", 2, 18 });

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
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Đá hương hương được máy hết tàu gì á bơi.", 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Đánh thuê bạn tủ đánh.", 1, 1 });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "811 Minh Thương Square", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=C%C3%B4ng%20L%E1%BB%99c%20%C4%90o%C3%A0n", "3eaee038-0cb6-4932-9c80-a1ed569898d5", new DateTime(2019, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "KimPhuong.Ngo53@yahoo.com", "Công Lộc Đoàn", "KIMPHUONG.NGO53@YAHOO.COM", "KIMPHUONG.NGO53@YAHOO.COM", "AQAAAAIAAYagAAAAEAyM/MHhp2fbcBUrdBm/LgvOX7byVkMqcKByd9xhTGkGzfBCY+JtCQGt0CUCSHAtqQ==", "0230 1795 6838", "13c0bc18-2240-421d-9fa8-61f36c892b85", "KimPhuong.Ngo53@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "95614 Xuân Yến Locks", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=S%C6%A1n%20H%C3%A0%20Phan", "c8ec466a-ca21-497a-be93-8f3be4bcb5f7", new DateTime(2013, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "DonThuan70@yahoo.com", "Sơn Hà Phan", "DONTHUAN70@YAHOO.COM", "DONTHUAN70@YAHOO.COM", "AQAAAAIAAYagAAAAEEgiHg2ren2po1GzkvHaL0x/gaMzlv979wYmH3psBmpRb92kbAXkGnm0/ZcLcGQvMA==", "0285 1877 1256", "b354e051-5f3d-4051-b909-e8ca1a2d30da", "DonThuan70@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "570 Tăng Gateway", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Qu%E1%BB%B3nh%20Sa%20Mai", "80778bbd-4daf-4f36-a72c-1822278a7da6", new DateTime(2011, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "ChungThuy_Nguyen59@yahoo.com", "Quỳnh Sa Mai", "CHUNGTHUY_NGUYEN59@YAHOO.COM", "CHUNGTHUY_NGUYEN59@YAHOO.COM", "AQAAAAIAAYagAAAAEGsSZENRXnGDRCX8d4MAGFRX90tm6JGFOzDVAhOFXPY13Zel0fx1+u1SXSTEbKcbYA==", "029 4519 6109", "11a1dc59-1ab4-474d-a876-0c81fded43cf", "ChungThuy_Nguyen59@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "997 Thái Hồng Isle", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Chu%E1%BA%A9n%20Khoa%20%C4%90%E1%BA%B7ng", "503d096c-4ddc-4ed0-ac9c-1f546a579b4a", new DateTime(2011, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "MinhVy61@gmail.com", "Chuẩn Khoa Đặng", "MINHVY61@GMAIL.COM", "MINHVY61@GMAIL.COM", "AQAAAAIAAYagAAAAEDm1ZhMvBcdwpVSvAjnf78KjmXpi8Sv1sG+4YbjAJJRP1xUTLbJnoT+93ciots9Wfw==", "020 4288 5112", "6d46597d-52ff-47e2-869d-1ccbd2b9659f", "MinhVy61@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4524 Thanh Thảo Forks", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Qu%C3%BD%20Kh%C3%A1nh%20%C4%90inh", "9ba10eb2-dd1c-4170-b94b-a95cb4fbd2e5", new DateTime(2007, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "HangAnh8@hotmail.com", "Quý Khánh Đinh", "HANGANH8@HOTMAIL.COM", "HANGANH8@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIHXs0Wcu6usnl+hIowdJ7psZn+ksGdRV4lYylOyOABNcsu9SjHBIdH7BvcS+6Chkw==", "0244 5333 7096", "14c7351b-3b7f-4d50-ad70-9c4bb88b650d", "HangAnh8@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3532 Trương Crescent", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Kim%20Hoa%20V%C5%A9", "e32ffafd-f01a-45f2-9238-d0b81255c42f", new DateTime(2015, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), "ThucNhi_Bui@yahoo.com", "Kim Hoa Vũ", "THUCNHI_BUI@YAHOO.COM", "THUCNHI_BUI@YAHOO.COM", "AQAAAAIAAYagAAAAEMJTQ8PsN3uOEZohSFwlIS6HSpR65dqJDk9m0z17cr3OdiphQEVhPnjXJyJUTEAZZw==", "0294 6705 2522", "df2b07ba-de56-4b80-9b8e-df73ee397336", "ThucNhi_Bui@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "33898 Thương Nga Crossing", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Minh%20Ph%C6%B0%C6%A1ng%20Tr%C6%B0%C6%A1ng", "95da1aa3-cc0a-4947-8a66-fa9621009ee0", new DateTime(2008, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "QuocHai42@yahoo.com", "Minh Phương Trương", "QUOCHAI42@YAHOO.COM", "QUOCHAI42@YAHOO.COM", "AQAAAAIAAYagAAAAEKyTyn0ipA+Nx/P3hhA07wabjdVuTSAaD45BMlu+kGya9f2uzL6JR6zriJjXrAFU4Q==", "0283 1217 1784", "7ee1e52e-a2fe-403e-9592-c359cbd7489d", "QuocHai42@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "14781 Huệ Lan Manors", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Th%C3%B9y%20Nhi%20%C4%90%C3%A0o", "2f7c30f3-69c7-4732-87f6-9ed1acc4a64a", new DateTime(2002, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "KhanhHa.Do95@gmail.com", "Thùy Nhi Đào", "KHANHHA.DO95@GMAIL.COM", "KHANHHA.DO95@GMAIL.COM", "AQAAAAIAAYagAAAAEIsMmdchEBy8ka3Ft4jJaDHg34QMod0BLEL2O94Tddz2SMuP1QoXB2iHgfRDIvvyMA==", "0262 2625 7845", "7029aff3-00b5-40ce-8ea1-7e92b5899f91", "KhanhHa.Do95@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "05465 Hồ Summit", "https://via.placeholder.com/100x100/cccccc/9c9c9c.png?text=Thy%20Khanh%20Tr%C6%B0%C6%A1ng", "b22ec521-57af-4c42-978f-1c9beba8e3c9", new DateTime(1999, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "HongThuy_Duong61@gmail.com", "Thy Khanh Trương", "HONGTHUY_DUONG61@GMAIL.COM", "HONGTHUY_DUONG61@GMAIL.COM", "AQAAAAIAAYagAAAAEEWFFxjJ8cKcI1HeiRobodP17bVNDup86myKHGkxy+KD56mNOlQbkgZWvQFmMYJ5Ow==", "027 0033 1356", "099aff3e-224a-419a-8a34-9031e1b192ef", "HongThuy_Duong61@gmail.com" });
        }
    }
}
