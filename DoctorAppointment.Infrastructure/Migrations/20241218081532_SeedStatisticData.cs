using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorAppointment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedStatisticData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), 35, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 9, 0, 0, 0), 100, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), 50, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), 78, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 14, 0, 0, 0), 1, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 18, 0, 0, 0), 35, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 10, 0, 0, 0), 66, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), 46, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 12, 0, 0, 0), 19, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 9, 0, 0, 0), 40, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 12, 0, 0, 0), 34, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 17, 0, 0, 0), 60, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 19, 23, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), 11, 70, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 13, 0, 0, 0), 60, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 10, 0, 0, 0), 84, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 11, 0, 0, 0), 81, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 13, 0, 0, 0), 37, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 2, 13, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 16, 0, 0, 0), 45, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), 100, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 0, 0, 0), 82, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), 69, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), 71, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 18, 0, 0, 0), 31, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 11, 0, 0, 0), 100, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 14, 0, 0, 0), 63, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), 95, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 11, 0, 0, 0), 55, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 18, 0, 0, 0), 30, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 12, 0, 0, 0), 100, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 16, 0, 0, 0), 101, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 15, 0, 0, 0), 62, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 14, 0, 0, 0), 61, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 0, 0, 0), 101, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 15, 0, 0, 0), 87, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 16, 78, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 17, 0, 0, 0), 67, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 18, 0, 0, 0), 73, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 17, 0, 0, 0), 12, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), 44, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), 17, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 10, 0, 0, 0), 38, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 11, 0, 0, 0), 6, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), 17, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 0, 0, 0), 72, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 0, 0, 0), 95, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 3, 81, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 14, 0, 0, 0), 1, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), 92, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), 75, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 10, 0, 0, 0), 77, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 9, 0, 0, 0), 4, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 14, 0, 0, 0), 55, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 11, 48, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), 55, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 3, 15, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), 39, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), 41, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), 16, 26, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 14, 0, 0, 0), 99, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 15, 0, 0, 0), 76, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), 88, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), 56, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 17, 0, 0, 0), 30, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 16, 0, 0, 0), 39, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), 76, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, 47 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 14, 0, 0, 0), 51, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), 26, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 10, 0, 0, 0), 75, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), 23, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), 80, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 15, 0, 0, 0), 29, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 9, 0, 0, 0), 73, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 16, 0, 0, 0), 44, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 9, 0, 0, 0), 97, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 18, 0, 0, 0), 52, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 17, 0, 0, 0), 60, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 10, 0, 0, 0), 34, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), 58, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 18, 0, 0, 0), 70, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, 23, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 18, 0, 0, 0), 25, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 16, 0, 0, 0), 78, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 9, 0, 0, 0), 16, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), 78, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), 8, 49, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 16, 0, 0, 0), 82, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 11, 0, 0, 0), 36, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), 25, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), 57, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), 77, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 12, 0, 0, 0), 74, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), 48, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 0, 0, 0), 84, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), 17, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 13, 0, 0, 0), 27, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), 47, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), 60, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 18, 0, 0, 0), 80, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 12, 0, 0, 0), 31, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 10, 0, 0, 0), 64, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 10, 0, 0, 0), 65, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 15, 0, 0, 0), 4, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 16, 0, 0, 0), 67, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 16, 0, 0, 0), 56, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 14, 0, 0, 0), 90, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), 12, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 11, 0, 0, 0), 28, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 0, 0, 0), 47, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 12, 0, 0, 0), 90, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 10, 0, 0, 0), 11, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 16, 0, 0, 0), 70, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 18, 0, 0, 0), 81, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 15, 0, 0, 0), 57, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 14, 0, 0, 0), 41, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 14, 0, 0, 0), 83, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 17, 0, 0, 0), 15, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 0, 0, 0), 61, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 15, 0, 0, 0), 52, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 12, 0, 0, 0), 3, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 18, 0, 0, 0), 92, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 15, 0, 0, 0), 44, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, 32 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 12, 0, 0, 0), 44, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), 27, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 18, 0, 0, 0), 82, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), 48, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), 26, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 13, 0, 0, 0), 2, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), 2, 41 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 14, 0, 0, 0), 19, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 9, 0, 0, 0), 54, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), 26, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 13, 0, 0, 0), 95, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), 56, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), 80, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 17, 0, 0, 0), 77, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 16, 0, 0, 0), 61, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 16, 0, 0, 0), 91, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 0, 0, 0), 82, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 14, 0, 0, 0), 76, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 13, 0, 0, 0), 81, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 9, 0, 0, 0), 94, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 15, 0, 0, 0), 62, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 14, 0, 0, 0), 100, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 11, 0, 0, 0), 27, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 18, 0, 0, 0), 20, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 9, 0, 0, 0), 15, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 14, 0, 0, 0), 2, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), 14, 73, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 0, 0, 0), 64, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 11, 0, 0, 0), 95, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 9, 0, 0, 0), 65, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 18, 0, 0, 0), 78, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 15, 0, 0, 0), 81, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 17, 0, 0, 0), 69, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 13, 0, 0, 0), 56, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, 57, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), 42, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 16, 0, 0, 0), 91, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), 3, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), 84, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 9, 0, 0, 0), 9, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), 19, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 14, 0, 0, 0), 72, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), 4, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 12, 0, 0, 0), 31, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 9, 0, 0, 0), 59, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 14, 0, 0, 0), 22, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 9, 0, 0, 0), 76, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 14, 0, 0, 0), 49, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 14, 0, 0, 0), 65, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 13, 0, 0, 0), 84, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 6, 99, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 13, 0, 0, 0), 11, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), 56, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 16, 0, 0, 0), 70, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 0, 0, 0), 21, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 15, 0, 0, 0), 12, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), 14, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 17, 0, 0, 0), 32, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 11, 0, 0, 0), 81, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), 19, 42, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 15, 0, 0, 0), 85, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 14, 0, 0, 0), 89, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 15, 0, 0, 0), 70, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 13, 0, 0, 0), 79, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 14, 0, 0, 0), 20, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 9, 0, 0, 0), 74, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), 31, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 10, 0, 0, 0), 25, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "CreatedAt", "CreatedBy", "DoctorId", "EndTime", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "PatientId", "StartTime", "Status" },
                values: new object[,]
                {
                    { 201, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 36, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 202, new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 60, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 203, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 86, new TimeSpan(0, 16, 0, 0, 0), 4 },
                    { 204, new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 53, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 205, new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 11, new TimeSpan(0, 15, 0, 0, 0), 2 },
                    { 206, new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 9, new TimeSpan(0, 14, 0, 0, 0), 0 },
                    { 207, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 48, new TimeSpan(0, 13, 0, 0, 0), 3 },
                    { 208, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 41, new TimeSpan(0, 13, 0, 0, 0), 2 },
                    { 209, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 37, new TimeSpan(0, 14, 0, 0, 0), 2 },
                    { 210, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 57, new TimeSpan(0, 14, 0, 0, 0), 0 },
                    { 211, new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 73, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 212, new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 98, new TimeSpan(0, 13, 0, 0, 0), 0 },
                    { 213, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 88, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 214, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 98, new TimeSpan(0, 10, 0, 0, 0), 1 },
                    { 215, new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 64, new TimeSpan(0, 16, 0, 0, 0), 0 },
                    { 216, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 19, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 217, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 55, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 218, new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 27, new TimeSpan(0, 14, 0, 0, 0), 1 },
                    { 219, new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 30, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 220, new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 55, new TimeSpan(0, 13, 0, 0, 0), 0 },
                    { 221, new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 32, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 222, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 57, new TimeSpan(0, 17, 0, 0, 0), 2 },
                    { 223, new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 16, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 224, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 16, new TimeSpan(0, 14, 0, 0, 0), 0 },
                    { 225, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 48, new TimeSpan(0, 16, 0, 0, 0), 2 },
                    { 226, new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 54, new TimeSpan(0, 11, 0, 0, 0), 0 },
                    { 227, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 23, new TimeSpan(0, 16, 0, 0, 0), 1 },
                    { 228, new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 2, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 229, new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 77, new TimeSpan(0, 16, 0, 0, 0), 0 },
                    { 230, new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 94, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 231, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 9, new TimeSpan(0, 14, 0, 0, 0), 3 },
                    { 232, new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 45, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 233, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 44, new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { 234, new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 32, new TimeSpan(0, 13, 0, 0, 0), 1 },
                    { 235, new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 75, new TimeSpan(0, 17, 0, 0, 0), 0 },
                    { 236, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 9, new TimeSpan(0, 15, 0, 0, 0), 3 },
                    { 237, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 34, new TimeSpan(0, 11, 0, 0, 0), 4 },
                    { 238, new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 9, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 239, new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 25, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 240, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 13, new TimeSpan(0, 13, 0, 0, 0), 3 },
                    { 241, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 35, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 242, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 51, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 243, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 40, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 244, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 95, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 245, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 97, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 246, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 85, new TimeSpan(0, 10, 0, 0, 0), 0 },
                    { 247, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 72, new TimeSpan(0, 9, 0, 0, 0), 0 },
                    { 248, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 58, new TimeSpan(0, 16, 0, 0, 0), 4 },
                    { 249, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 16, new TimeSpan(0, 15, 0, 0, 0), 0 },
                    { 250, new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 94, new TimeSpan(0, 15, 0, 0, 0), 2 },
                    { 251, new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 90, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 252, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 42, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 253, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 84, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 254, new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 53, new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { 255, new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 62, new TimeSpan(0, 13, 0, 0, 0), 2 },
                    { 256, new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 90, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 257, new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 93, new TimeSpan(0, 14, 0, 0, 0), 4 },
                    { 258, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 46, new TimeSpan(0, 15, 0, 0, 0), 2 },
                    { 259, new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 98, new TimeSpan(0, 12, 0, 0, 0), 1 },
                    { 260, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 92, new TimeSpan(0, 13, 0, 0, 0), 2 },
                    { 261, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 45, new TimeSpan(0, 15, 0, 0, 0), 0 },
                    { 262, new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, new TimeSpan(0, 14, 0, 0, 0), false, null, null, 55, new TimeSpan(0, 13, 0, 0, 0), 1 },
                    { 263, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 53, new TimeSpan(0, 8, 0, 0, 0), 2 },
                    { 264, new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 92, new TimeSpan(0, 16, 0, 0, 0), 0 },
                    { 265, new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 85, new TimeSpan(0, 17, 0, 0, 0), 4 },
                    { 266, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 16, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 267, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 72, new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { 268, new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 96, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 269, new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 90, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 270, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 64, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 271, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 55, new TimeSpan(0, 11, 0, 0, 0), 1 },
                    { 272, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 58, new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { 273, new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 83, new TimeSpan(0, 12, 0, 0, 0), 2 },
                    { 274, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 12, 0, 0, 0), false, null, null, 49, new TimeSpan(0, 11, 0, 0, 0), 3 },
                    { 275, new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 28, new TimeSpan(0, 9, 0, 0, 0), 2 },
                    { 276, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 80, new TimeSpan(0, 9, 0, 0, 0), 3 },
                    { 277, new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 84, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 278, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 10, new TimeSpan(0, 10, 0, 0, 0), 1 },
                    { 279, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 9, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 280, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 3, new TimeSpan(0, 16, 0, 0, 0), 3 },
                    { 281, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 66, new TimeSpan(0, 15, 0, 0, 0), 4 },
                    { 282, new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 15, new TimeSpan(0, 17, 0, 0, 0), 0 },
                    { 283, new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 75, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 284, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 32, new TimeSpan(0, 8, 0, 0, 0), 2 },
                    { 285, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 76, new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { 286, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 51, new TimeSpan(0, 16, 0, 0, 0), 0 },
                    { 287, new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 67, new TimeSpan(0, 8, 0, 0, 0), 4 },
                    { 288, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 92, new TimeSpan(0, 12, 0, 0, 0), 0 },
                    { 289, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 46, new TimeSpan(0, 10, 0, 0, 0), 3 },
                    { 290, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 39, new TimeSpan(0, 10, 0, 0, 0), 4 },
                    { 291, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 25, new TimeSpan(0, 14, 0, 0, 0), 4 },
                    { 292, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 22, new TimeSpan(0, 8, 0, 0, 0), 3 },
                    { 293, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 11, 0, 0, 0), false, null, null, 85, new TimeSpan(0, 10, 0, 0, 0), 2 },
                    { 294, new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new TimeSpan(0, 17, 0, 0, 0), false, null, null, 63, new TimeSpan(0, 16, 0, 0, 0), 3 },
                    { 295, new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, new TimeSpan(0, 15, 0, 0, 0), false, null, null, 79, new TimeSpan(0, 14, 0, 0, 0), 1 },
                    { 296, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new TimeSpan(0, 13, 0, 0, 0), false, null, null, 39, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 297, new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new TimeSpan(0, 18, 0, 0, 0), false, null, null, 9, new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { 298, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, new TimeSpan(0, 10, 0, 0, 0), false, null, null, 61, new TimeSpan(0, 9, 0, 0, 0), 1 },
                    { 299, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new TimeSpan(0, 16, 0, 0, 0), false, null, null, 93, new TimeSpan(0, 15, 0, 0, 0), 4 },
                    { 300, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, new TimeSpan(0, 9, 0, 0, 0), false, null, null, 12, new TimeSpan(0, 8, 0, 0, 0), 4 }
                });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Nhi khoa", 5, 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Nhi khoa", 5, 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "Specialization" },
                values: new object[] { "Bác sĩ có hơn 3 năm trong lĩnh vực Nhi khoa", 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Đa khoa", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Nhi khoa", 9 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Tim mạch", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Đa khoa", 1, 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Nhi khoa", 5, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Nhi khoa", 5, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "About", "Specialization" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Tim mạch", 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Thần kinh", 4, 9 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Da liễu", 3, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Thần kinh", 4, 10 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "About", "Specialization" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Tim mạch", 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Nhi khoa", 5, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Nhi khoa", 5, 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Thần kinh", 4, 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 3 năm trong lĩnh vực Nhi khoa", 5, 3 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Nhi khoa", 5, 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "154eda7f-e85b-4d77-864e-3a3a31c47121", "AQAAAAIAAYagAAAAEES4TzEWKoVQvGTKM5Nz2YstU/3iRuYIrdX7CuQ9HjRJfbAQrZWS0uM0mnc8nl80vg==", "1b2d06ee-be49-4ef1-a726-229068f44684" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8855 Bá Thiện Squares", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Nh%C3%A3%20S%C6%B0%C6%A1ng", "49f249a2-f4a8-4ff1-aced-66313ded4752", new DateTime(2002, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "LamNgoc_Nguyen@gmail.com", "Đỗ Nhã Sương", "LAMNGOC_NGUYEN@GMAIL.COM", "LAMNGOC_NGUYEN@GMAIL.COM", "AQAAAAIAAYagAAAAEE+ihwV7mR9JnG+w4iXWAPNYYDaInefLzB9ZEQsQ2gWEa0E30uKNDXGI9gF/OW9tmA==", "0201 0050 8056", "e765c562-ecf3-45a3-9625-e60bcb3aee1b", "LamNgoc_Nguyen@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "36999 Hướng Tiền Shoals", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Ho%C3%A0ng%20H%C3%A0", "1aee3631-b228-41bf-b6a9-5c7a33605c34", new DateTime(2016, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "BichHien.Truong41@hotmail.com", "Phạm Hoàng Hà", 2, "BICHHIEN.TRUONG41@HOTMAIL.COM", "BICHHIEN.TRUONG41@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDHEf1jyu2GQTurL+/H2vjA+A57htJp2/TAxxr+tp6DVyfVW8Od33DLAE/60Itjm2A==", "0286 0281 2685", "1cd206b2-2f7a-47b5-bf26-e87546252a3e", "BichHien.Truong41@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "87520 Tô Port", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Ng%E1%BB%8Dc%20H%C3%A0", "430b19eb-f3fc-4d7b-8292-0dc5f6f1bdbe", new DateTime(2001, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "ThanhQuang.Vu@gmail.com", "Lê Ngọc Hà", 2, "THANHQUANG.VU@GMAIL.COM", "THANHQUANG.VU@GMAIL.COM", "AQAAAAIAAYagAAAAEEv/WoP3MYyNWWHW2VN4WMWClGdse3c7kC2vd73ViiHCb4hrgk+5ZP63n16xc7jyRQ==", "023 7845 4507", "f8e7bafb-59b1-49c1-8a97-c10f4f411edb", "ThanhQuang.Vu@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "94124 Thùy Nhi Landing", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20H%E1%BB%93ng%20%C4%90%C4%83ng", "0f0467a8-c364-46bb-be7e-e9268714e6c7", new DateTime(2005, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "BaoHoa_Trinh36@yahoo.com", "Lê Hồng Đăng", 2, "BAOHOA_TRINH36@YAHOO.COM", "BAOHOA_TRINH36@YAHOO.COM", "AQAAAAIAAYagAAAAEGAMvMwirw2wSHmSiVAY7n2CnxtFF4/c2Ung3GzeoJ52Asmi9JPY8vhEKY/hlv+b+w==", "021 8554 6911", "24ca19ca-dda0-47b2-bd3c-7d464f008e99", "BaoHoa_Trinh36@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "74596 Hoài Giang Loop", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20C%C3%B4ng%20Th%C3%A0nh", "38b82c05-59f2-4c8b-b03c-30cedbe1e6d2", new DateTime(2006, 3, 24, 0, 0, 0, 0, DateTimeKind.Local), "MyUyen93@yahoo.com", "Mai Công Thành", 1, "MYUYEN93@YAHOO.COM", "MYUYEN93@YAHOO.COM", "AQAAAAIAAYagAAAAEBM4Wevhnco8lNBXc9nyixV1roogknmP8gLPXRqJcvcIS0XG51d0vGbQ8M0erppIjg==", "0221 1611 3447", "93425566-0712-4bf8-8fb5-8ce850cd8a4f", "MyUyen93@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "78371 Mai Common", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20C%C3%B4ng%20Th%C3%A0nh", "67cab565-b100-4d82-a024-ec30371042d0", new DateTime(2017, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "MyDuyen_Phung@hotmail.com", "Hồ Công Thành", 1, "MYDUYEN_PHUNG@HOTMAIL.COM", "MYDUYEN_PHUNG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEC75Llwm5OLyVSbuwG1sxJUvaGPVJAlyffKD6ZcXBybWtbc1l4HcupyJlM3ejrTIsg==", "024 7760 5658", "5b80af76-ad82-47d2-a63c-752c795dc159", "MyDuyen_Phung@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "157 Ngô Place", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20T%E1%BB%91%20Loan", "52318c36-cdfa-456c-9970-17a0c0b0eb26", new DateTime(2002, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "BichQuan.Dang83@hotmail.com", "Tô Tố Loan", 3, "BICHQUAN.DANG83@HOTMAIL.COM", "BICHQUAN.DANG83@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFYA6jwvCiQucFZ+PpYisHSTAtHkTypist2e4Azfm3ixf20uK7WQCsQ3b+0xPmEhuQ==", "0289 9145 5594", "00edcdd9-63aa-4168-a917-0070b72f2048", "BichQuan.Dang83@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "365 Vũ Corners", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Thi%C3%AAn%20Tr%C3%AD", "288503b9-102a-4c4e-af4b-9393f3a734dd", new DateTime(2010, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "HoaHiep.Trinh51@gmail.com", "Phạm Thiên Trí", 2, "HOAHIEP.TRINH51@GMAIL.COM", "HOAHIEP.TRINH51@GMAIL.COM", "AQAAAAIAAYagAAAAEIW57Q4TpEZ02bQyZwMkfQq+1VcMP/ugPTMknFSH++A4Gu70Hlfq6xNBH2cY8s4O5Q==", "025 8759 5944", "a475bb2c-9998-4d97-b969-30d140692c86", "HoaHiep.Trinh51@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5757 Ngô Loaf", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Cao%20S%E1%BB%B9", "49fa8f3c-c430-42e5-885d-c522fd0c5219", new DateTime(2014, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "DongNghi.Ha@yahoo.com", "Mai Cao Sỹ", 1, "DONGNGHI.HA@YAHOO.COM", "DONGNGHI.HA@YAHOO.COM", "AQAAAAIAAYagAAAAECFwFOybIf2Ct5jfGGIX9mFf3WhuaJcxAqi5SWykNC94SA1t94/kUmaNL1EROktwhg==", "0297 1154 2479", "b9e1ba6f-32b2-4f11-936e-7328e4228dd0", "DongNghi.Ha@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "508 Hạnh Chi Burgs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Anh%20Tu%E1%BA%A5n", "85bfefa4-d352-4127-a46d-80a893a88562", new DateTime(2017, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "DangQuang_Ly18@yahoo.com", "Đinh Anh Tuấn", 1, "DANGQUANG_LY18@YAHOO.COM", "DANGQUANG_LY18@YAHOO.COM", "AQAAAAIAAYagAAAAEEgyHBO3EK8oYVvHsZU+yHv//WhQdCoKEMl0pjf7KHJhXtYVo5jy5rWYb/sr8hdi9A==", "0248 3951 3396", "e53309f2-fb18-49d1-8b73-7d1331eee230", "DangQuang_Ly18@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "611 Hà Lakes", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Qu%E1%BB%91c%20Ti%E1%BA%BFn", "8cd2e851-879a-41ad-8a98-17d74075c6db", new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "HoaiThanh40@hotmail.com", "Trương Quốc Tiến", "HOAITHANH40@HOTMAIL.COM", "HOAITHANH40@HOTMAIL.COM", "AQAAAAIAAYagAAAAEM0sW44tbT+ClPnW0Y+uSibIkui4SGNcFC1dt0z+zauYN6HOCaUWDbAENcbPJuO/fg==", "0235 8121 4055", "7ca72c43-77c4-4447-945b-bfa2b4d45ef5", "HoaiThanh40@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "40375 Thành Tín Harbor", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Kim%20Thoa", "871ebccd-2655-4f8b-b02a-a0597d727d58", new DateTime(2003, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "NgocLien18@yahoo.com", "Hồ Kim Thoa", 3, "NGOCLIEN18@YAHOO.COM", "NGOCLIEN18@YAHOO.COM", "AQAAAAIAAYagAAAAEMug7hpVpNKIvPCUEhqwWcR/bcjHuK92T3fL8MS6w3bEqDZ/whWDyRtDvzL46OLONw==", "024 2323 0888", "c292b03e-2496-4be9-9e5d-503c3cee2744", "NgocLien18@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "81013 Đỗ Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20B%E1%BA%A3o%20Ng%E1%BB%8Dc", "02a4db34-9860-4e6d-add1-a05fb6c23531", new DateTime(2000, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "DongTuyen.Dao90@gmail.com", "Phạm Bảo Ngọc", 2, "DONGTUYEN.DAO90@GMAIL.COM", "DONGTUYEN.DAO90@GMAIL.COM", "AQAAAAIAAYagAAAAEGgMTi7JgOM49zBwtydD/N9KWpng6qfb8f/OAX0X118o4SJH3U0bLi3LT/72w3yJZA==", "0223 9774 3985", "1a44c8e0-f378-4d8a-8489-cd2b3478d013", "DongTuyen.Dao90@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "29133 Đinh Knoll", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Duy%20Khi%C3%AAm", "a771d145-ae19-4fa7-a0f5-a67ff9fda4c1", new DateTime(2003, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "KieuHoa_Vuong@gmail.com", "Trương Duy Khiêm", 3, "KIEUHOA_VUONG@GMAIL.COM", "KIEUHOA_VUONG@GMAIL.COM", "AQAAAAIAAYagAAAAEMzv/8MLvjrhOLvyEY67G36BxVXA+eY2zX1jeOMnOXtp2F2i2HTK+d0gt0MUnSo21g==", "024 8167 0941", "8f679d6b-8237-4e9f-adc0-4363fc05b238", "KieuHoa_Vuong@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0349 Trịnh Glens", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Minh%20S%C6%A1n", "54942ece-b7d0-4cba-80bd-ffd2a18f392c", new DateTime(2012, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "ThuyHang.Dang@yahoo.com", "Hồ Minh Sơn", 2, "THUYHANG.DANG@YAHOO.COM", "THUYHANG.DANG@YAHOO.COM", "AQAAAAIAAYagAAAAEKQlDytdGuH9oVwRfbYnXQcuf9wnzrsE4sKmKy56syYVsbYmsoViXP7b9PN5FstnjA==", "027 8147 7823", "3a618d36-15dd-439e-b3d2-1c082e161c5e", "ThuyHang.Dang@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "213 Đào Cliff", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Ng%E1%BB%8Dc%20%E1%BA%A8n", "cb1921f7-cf51-45f7-a124-1d4e9a64e4a0", new DateTime(2002, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "LinhDan51@gmail.com", "Lý Ngọc Ẩn", 2, "LINHDAN51@GMAIL.COM", "LINHDAN51@GMAIL.COM", "AQAAAAIAAYagAAAAEE7XfYPm71PdOgpZll22Hxj2mYo8KxXbYSduh8j0aNm0bcL0J2hqi7Ld7VnIs9Ey+g==", "0275 7228 3979", "dc62e57e-fd41-4b3e-bd82-65152baa1fb4", "LinhDan51@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7016 Xuân Thủy Streets", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20%C3%90%C3%ACnh%20Trung", "4ecfe597-3074-4377-9ebb-e2e940d48686", new DateTime(1998, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), "PhuongThanh73@hotmail.com", "Phan Ðình Trung", 2, "PHUONGTHANH73@HOTMAIL.COM", "PHUONGTHANH73@HOTMAIL.COM", "AQAAAAIAAYagAAAAEOppJ3U8jWJgzTVvJsRYlXHKivkJlNCaPc/DmF9qnyaLDObh4fSc1uCj6gGbQF7dig==", "022 0524 1733", "7ca9dabe-4dd9-4c02-85c6-06d892116028", "PhuongThanh73@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "543 Đoàn Station", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Hi%E1%BB%81n%20H%C3%B2a", "c816b2d5-99ff-4eb2-8893-4fec1cc3e84a", new DateTime(2016, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "TrungThuc_Nguyen@yahoo.com", "Lý Hiền Hòa", 3, "TRUNGTHUC_NGUYEN@YAHOO.COM", "TRUNGTHUC_NGUYEN@YAHOO.COM", "AQAAAAIAAYagAAAAEK85U4pgs2Nm6N7OaAbeuo6VNBHSHRL9lLLXvEE4/aijIwUO87XM6GspigLwmii/gQ==", "0298 4849 8744", "6e44447e-d846-411e-a89c-6415d38a612a", "TrungThuc_Nguyen@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "539 Công Hậu Port", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20%C3%90%C3%ACnh%20Nam", "08b74e96-7231-40bf-99d6-11e38c69bf8e", new DateTime(1999, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), "NgocTien8@yahoo.com", "Bùi Ðình Nam", 2, "NGOCTIEN8@YAHOO.COM", "NGOCTIEN8@YAHOO.COM", "AQAAAAIAAYagAAAAELQFMG+eoU2I9BEywqTLNwDQq15bFbmEf1gusuaMPS3Zw+saNq9EP/APjY6s/L3n1Q==", "022 3854 4363", "94fa3bd5-7448-4f17-93d7-50f830a51362", "NgocTien8@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "34083 Minh Vu Divide", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C5%A9%20Thanh%20To%E1%BA%A3n", "7f549ccd-ccad-41bf-970c-59578ddedfeb", new DateTime(2007, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), "NgocHien.Ha@gmail.com", "Vũ Thanh Toản", "NGOCHIEN.HA@GMAIL.COM", "NGOCHIEN.HA@GMAIL.COM", "AQAAAAIAAYagAAAAEAVcjezrx4VZR2uSmWWNqgEhDVbrNYD+jMUz1No/xTjQHd+DbQIBIXDEr9yfiKzmzA==", "022 5778 7889", "83f1795c-64ff-4bd8-84e6-9aed4e1aaca0", "NgocHien.Ha@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "67191 Phạm Village", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20H%C3%A0m%20Duy%C3%AAn", "8fb25da8-fdd4-4e3e-9f4f-90144cbfa1c4", new DateTime(2009, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), "QuangTuan_Ly21@hotmail.com", "Lý Hàm Duyên", "QUANGTUAN_LY21@HOTMAIL.COM", "QUANGTUAN_LY21@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDOdVslineqWkBc1gTQdC6RmPAnLJWXpHcBgAA+ofMFohZKIo3AZprDGiAbUtZ084Q==", "025 3976 8520", "bb3fcaf0-230a-45f0-821b-6838bad38cd3", "QuangTuan_Ly21@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "65106 Mỹ Lệ Crest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20%C4%90an%20Linh", "2929159e-1c12-433e-b3e4-3bfd7c0569e4", new DateTime(1997, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "NguyetMinh_Bui@yahoo.com", "Hoàng Đan Linh", "NGUYETMINH_BUI@YAHOO.COM", "NGUYETMINH_BUI@YAHOO.COM", "AQAAAAIAAYagAAAAEOIt/yLHdlcyoL3QzWkokaWPZzf+Qn+LGV6FLOirvmsUbOKhvZG/4WKtwt2l41GJ1w==", "0257 6443 8711", "bcdcf07d-352e-41ec-aaed-adf5284a96f5", "NguyetMinh_Bui@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "635 Lâm Keys", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Th%E1%BB%A7y%20Ti%C3%AAn", "66e78b23-7c17-4558-8537-f48099be7116", new DateTime(2001, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "XuanPhuong83@yahoo.com", "Trương Thủy Tiên", 3, "XUANPHUONG83@YAHOO.COM", "XUANPHUONG83@YAHOO.COM", "AQAAAAIAAYagAAAAELe8wuW863vSpaKl0CZPYKXdaLiOFumD2a88+80EVpy/K/XvbJM8gaI4WEYib97l2A==", "029 8762 5620", "d8b7b51d-e437-42ec-ae1f-78f9d4cc1ef2", "XuanPhuong83@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "13871 Ánh Trang Glens", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20H%C6%B0%C6%A1ng%20Th%E1%BA%A3o", "f96923f6-d7c7-4ea9-bfb9-0e56c66a5234", new DateTime(2005, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), "HoangLan.Le@hotmail.com", "Đặng Hương Thảo", 1, "HOANGLAN.LE@HOTMAIL.COM", "HOANGLAN.LE@HOTMAIL.COM", "AQAAAAIAAYagAAAAELnLOEewMUolBquu0xySwk6EM7tq86OaZVE3xcdz1MMnGmU7pBpb2/PNRUEG4ZM46w==", "0298 3174 2096", "7f38a5f6-9189-42ae-8279-a3888b08c103", "HoangLan.Le@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "685 Đặng Forks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20%C3%90%E1%BB%A9c%20%C3%82n", "6bcbd9a3-6c72-444b-8a61-28661fdbda8b", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "QuangHoa.Doan@gmail.com", "Đỗ Ðức Ân", 2, "QUANGHOA.DOAN@GMAIL.COM", "QUANGHOA.DOAN@GMAIL.COM", "AQAAAAIAAYagAAAAEDRX4tY3cl2locpBniUne03jPtLofG947tLIWVOCCJj2505ECgfnfvE/2mxc/XkO1w==", "025 4403 8605", "30abc9c4-4575-4753-8558-9088b3c0a513", "QuangHoa.Doan@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "27457 Phạm Street", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20B%C3%ADch%20Ng%C3%A2n", "5acf5782-6fef-4020-af78-782b339d412a", new DateTime(2007, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "MinhKhieu_Do26@yahoo.com", "Lê Bích Ngân", 2, "MINHKHIEU_DO26@YAHOO.COM", "MINHKHIEU_DO26@YAHOO.COM", "AQAAAAIAAYagAAAAEI55wn0ArsqPFga4TadXQrHciAlxBPgT0EZHNi8C3z7DGPf3qZNZPduePGKqmXhV+w==", "021 8014 6504", "e0844cc2-a0e6-404e-b731-1e0f83672f51", "MinhKhieu_Do26@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6522 Tú Nguyệt Spur", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20Minh%20H%C3%B9ng", "0ff7805b-0fd8-4b02-b1f7-212243d64bdb", new DateTime(2010, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "MyPhuong_Bui63@gmail.com", "Đào Minh Hùng", 1, "MYPHUONG_BUI63@GMAIL.COM", "MYPHUONG_BUI63@GMAIL.COM", "AQAAAAIAAYagAAAAEPawJ1a4ctaxc5/v1uy6wgV9XovBu0uhELXzXsYYgWpjKlIxg0O40j/QtM3GSglQHg==", "023 0848 6495", "4e009f7f-b2eb-4957-8b93-14497d29f42f", "MyPhuong_Bui63@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "491 Phú Bình Spring", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Tr%C3%A0%20Giang", "4be14ff8-f841-4736-8ab9-a50bde675229", new DateTime(2004, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "PhuongThi16@yahoo.com", "Đặng Trà Giang", "PHUONGTHI16@YAHOO.COM", "PHUONGTHI16@YAHOO.COM", "AQAAAAIAAYagAAAAEAi+TU3oyvl9l3R5t4xuOt7ntA4+Asb/0vbSzKnRPPVc9wHjfAeXRvdUdmoTA6apYQ==", "021 3277 2228", "1a9a063c-6001-410b-a0d2-3c7d9fd8fd2f", "PhuongThi16@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "467 Lâm Forge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Nam%20An", "191d22a4-1ec8-4476-bbb3-e361e150759f", new DateTime(1995, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "ThaiVan.Hoang33@yahoo.com", "Lê Nam An", "THAIVAN.HOANG33@YAHOO.COM", "THAIVAN.HOANG33@YAHOO.COM", "AQAAAAIAAYagAAAAEC5Ir0ZHyBY87vNZ1Zrdj4PKiBmTxVFRJW4bnLpPBYMG+e56oW9rRomOoSC9wLtlSQ==", "0268 0123 9325", "1c16f395-9349-42c0-bb59-209b7b239b5e", "ThaiVan.Hoang33@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2066 Diệu Lan Hollow", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C5%A9%20Minh%20Tri%E1%BA%BFt", "006ad401-3157-4299-b717-00cfff48626a", new DateTime(2011, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "MongLam.Ly@hotmail.com", "Vũ Minh Triết", 2, "MONGLAM.LY@HOTMAIL.COM", "MONGLAM.LY@HOTMAIL.COM", "AQAAAAIAAYagAAAAED+p5YGezZckBYP7HOLaG4GQtVmp8JatiU7ychmBTi63QXle7svDFp/tyCcCMJpblw==", "024 9640 6895", "d53d46a6-87a0-4cfc-ba4b-570abd79aea3", "MongLam.Ly@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "794 Minh Toàn Route", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Linh%20Ph%C6%B0%C6%A1ng", "5ad0b26c-145b-47b6-a51d-e8f323312b20", new DateTime(2017, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "HuongLien32@gmail.com", "Tăng Linh Phương", 2, "HUONGLIEN32@GMAIL.COM", "HUONGLIEN32@GMAIL.COM", "AQAAAAIAAYagAAAAENqoRAZOwqnAHYAz68RJFljIGaSMqEO82k269QTXOEdhfsnTnSKdW0H/oNLr7Pu2nw==", "0201 8152 9372", "86aaf6f9-f184-41b2-a1de-9a2a1906f61a", "HuongLien32@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "629 Hồ Street", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20H%E1%BB%93ng%20Xu%C3%A2n", "63a22dde-c18d-4041-a88f-15edc07d157c", new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), "ThanhNgoc.Hoang@yahoo.com", "Đào Hồng Xuân", 3, "THANHNGOC.HOANG@YAHOO.COM", "THANHNGOC.HOANG@YAHOO.COM", "AQAAAAIAAYagAAAAEPDRcmTA7MM8j/P+bOyooQmC1/6ToBQW7+ghV8BE7iyaJ/5Y+eLUGHVNNr2W0caT2Q==", "0269 5893 4843", "0dd64d56-3bbd-4e8d-8d4a-b9a9da63ca34", "ThanhNgoc.Hoang@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "71578 Ngô Lake", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Minh%20Th%C6%B0", "88af88c7-46ca-4fd3-884e-38c1a28c3412", new DateTime(2019, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "HungAnh99@hotmail.com", "Đinh Minh Thư", 1, "HUNGANH99@HOTMAIL.COM", "HUNGANH99@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJjO9KK30df5YE4kpf5A/g7DMD+KwfZZ4qDhzxK0HjgErYFyz8tqtrMOEbCZLBarGg==", "027 1068 7995", "1f4257b9-1ed6-42a8-bf8e-8e6bf17cfbc8", "HungAnh99@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "346 Trương Haven", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Th%C3%A0nh%20Ph%C6%B0%C6%A1ng", "2e59d082-b5a6-4941-a310-c8d741f65113", new DateTime(2016, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "QuynhNhu_Vu@yahoo.com", "Đỗ Thành Phương", 1, "QUYNHNHU_VU@YAHOO.COM", "QUYNHNHU_VU@YAHOO.COM", "AQAAAAIAAYagAAAAEPCxKrPlJXnM6gx5+9jyv6ZBNGtDF7albx/tDYubb572Vzr9UI8orC5FslmJzkci+Q==", "020 3552 4965", "53a9de4d-0bf7-4944-ba72-14ec3c1a5979", "QuynhNhu_Vu@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "89711 Vũ Brooks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Trung%20L%E1%BB%B1c", "85c4cdda-83d9-490b-a811-4448428e513d", new DateTime(2002, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "HongDang.Truong@yahoo.com", "Tăng Trung Lực", "HONGDANG.TRUONG@YAHOO.COM", "HONGDANG.TRUONG@YAHOO.COM", "AQAAAAIAAYagAAAAEDGkZJ1IULcKyImBN9LDrWZZ12AACbWAerZ04L161sZ8vEa9T/U8GP46BY/27TxENg==", "0293 4017 9526", "65807bba-827c-4051-aa61-a8eeb9e5dee2", "HongDang.Truong@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "80816 Thục Ðình Row", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Minh%20Th%E1%BB%A7y", "110cd24b-f520-4097-a289-9178ca5df4ef", new DateTime(1998, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "HaiThanh_Dang46@yahoo.com", "Đinh Minh Thủy", 2, "HAITHANH_DANG46@YAHOO.COM", "HAITHANH_DANG46@YAHOO.COM", "AQAAAAIAAYagAAAAEJ/tNZYX3aP3xpBgRNRgKm/vt0Nv8QS0g5RSb08sX6lRKP4+xHzXlvS+Ey3ZAZVuMA==", "0238 2795 0114", "5beb1e9d-3a95-4fc8-821f-aff6f5801dc1", "HaiThanh_Dang46@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "56414 Phú Bình Ridge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Ph%C3%BA%20%C3%82n", "f916e6cd-0f9c-47a8-b3b2-a573c803dc72", new DateTime(1995, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), "CaoSi69@gmail.com", "Đinh Phú Ân", "CAOSI69@GMAIL.COM", "CAOSI69@GMAIL.COM", "AQAAAAIAAYagAAAAEIC/PXn/3Q3Ss6Aqkvxvvl6QpDPpNHqKyXscUVuBgDe8+4XrTuEjjJKRV+BN5a6m6w==", "0233 9837 7468", "638878c2-b8e5-45c8-b0a8-543a99a9a648", "CaoSi69@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8908 Đặng Ports", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Thi%E1%BB%87u%20B%E1%BA%A3o", "345edccc-dddf-460c-9dce-e008c1462e00", new DateTime(2014, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "HongLan.Tang87@yahoo.com", "Dương Thiệu Bảo", "HONGLAN.TANG87@YAHOO.COM", "HONGLAN.TANG87@YAHOO.COM", "AQAAAAIAAYagAAAAEFDUYT2UIBaddbma8AA8Z47jQZ7+hzMDdtTa2wU000EK39Gsejykj2zOJMg7vUJT+A==", "0263 7072 3868", "8ad57daf-4636-41bb-9efa-37c7f3e12caf", "HongLan.Tang87@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4907 Trần Vista", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20%C3%90%C3%B4ng%20Tr%C3%A0", "eebfc523-3d06-4564-994b-9e6ffe1846fd", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "ThaoNguyen_Ngo10@yahoo.com", "Trần Ðông Trà", "THAONGUYEN_NGO10@YAHOO.COM", "THAONGUYEN_NGO10@YAHOO.COM", "AQAAAAIAAYagAAAAEO3oYwnHsTiVQHaliz9iTHWaEw3VeCoZBqNjXOgLExYDLK0eVgq3SzZoUZFCVpiUuw==", "021 9971 8803", "33a60c74-24ec-47ba-bd65-8990bbbe7f79", "ThaoNguyen_Ngo10@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0104 Thiên Ðức Bridge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20%C4%90an%20Thu", "12155b2e-6bab-4bab-9f37-4e6d2cd72e8d", new DateTime(2009, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "KimVuong.Phan63@hotmail.com", "Lâm Đan Thu", 2, "KIMVUONG.PHAN63@HOTMAIL.COM", "KIMVUONG.PHAN63@HOTMAIL.COM", "AQAAAAIAAYagAAAAEOg10Em4pp9qiHEH3jfbNMG4zGktJ+1HE6ecfysO9bwVUuCCjkmFJ+eV5DvKK2xghA==", "022 8009 7537", "59a9d411-e95f-4d5e-b037-68caaccad84e", "KimVuong.Phan63@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "29761 Tô Plains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C5%A9%20Tu%E1%BA%A5n%20Minh", "dcf75c2a-5301-4432-b9fe-12fa3b098260", new DateTime(2021, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), "HongDiem.Phan93@gmail.com", "Vũ Tuấn Minh", "HONGDIEM.PHAN93@GMAIL.COM", "HONGDIEM.PHAN93@GMAIL.COM", "AQAAAAIAAYagAAAAEP4GEMFIgd+QBukdepl4b43ej/iwj5M+1kZ28h223wgRhnydev2oIRnKaEpvQjwD0g==", "0294 5482 4510", "45e9d56e-b89f-4f85-9cd4-18ba78f38c6b", "HongDiem.Phan93@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2981 Thiện Sinh Underpass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20H%E1%BA%A3i%20%C3%90%C6%B0%E1%BB%9Dng", "aa2bae58-4711-4bfe-bf8c-7ea4f5737930", new DateTime(2007, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "ThiYen_To20@yahoo.com", "Đào Hải Ðường", 3, "THIYEN_TO20@YAHOO.COM", "THIYEN_TO20@YAHOO.COM", "AQAAAAIAAYagAAAAEPTqBPfwNaX8kN7AGn+HyQFD0jwm/WBjpKfSHg9VCrypppC2abdEip2oV+IzvGKwTQ==", "020 9344 6437", "cb8cde72-2d3e-4fd2-a745-42a3e9fb7784", "ThiYen_To20@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "65055 Hồ Forest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20H%E1%BB%93ng%20%C4%90%E1%BB%A9c", "bc4b53b1-97e0-4451-8dae-6b531aeaaf56", new DateTime(1999, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "LamUyen_Phung33@gmail.com", "Tô Hồng Đức", 2, "LAMUYEN_PHUNG33@GMAIL.COM", "LAMUYEN_PHUNG33@GMAIL.COM", "AQAAAAIAAYagAAAAECmTT82ihkZj7Hz0YubA/lqAfJsy9E4mdGXFyJHvhPW3qZAE4tcCMHTUxRfqZDuPxg==", "0204 8489 9815", "31f64a5e-522e-47ae-a9ec-41edf6172c0e", "LamUyen_Phung33@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "43521 Tuyết Nhi Spurs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Uy%C3%AAn%20Th%C6%A1", "8a9e6c08-b042-47a1-a5b9-56439cb5604e", new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "DuyNgon_Ho@yahoo.com", "Hà Uyên Thơ", "DUYNGON_HO@YAHOO.COM", "DUYNGON_HO@YAHOO.COM", "AQAAAAIAAYagAAAAEEcUlXLzreTHA3+6OrUHkTOC4MoMuSs/OojRNKzceir/ROBrVWzkjWmHyYjAb4qEWw==", "0217 9697 7483", "8d11c2bf-0ca8-487b-ba14-0b543f3bee37", "DuyNgon_Ho@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0317 Lý Junctions", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20B%E1%BB%ADu%20Ch%C6%B0%E1%BB%9Fng", "8d9e545f-a02e-45f0-922a-175536fb7a30", new DateTime(2007, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "ThanhHien_Do@yahoo.com", "Trịnh Bửu Chưởng", 2, "THANHHIEN_DO@YAHOO.COM", "THANHHIEN_DO@YAHOO.COM", "AQAAAAIAAYagAAAAEIHTHm9CUI5AtEkYrPPy9qvl/sjGEd8S/NCYZkDdeNerFy6U3vBtpfyHvH5kOE9jvA==", "028 1939 4360", "ce52cb7a-7357-4b10-a7f2-4c1a4efcdd78", "ThanhHien_Do@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0143 Khánh Duy Mews", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Qu%E1%BB%91c%20Ph%C6%B0%C6%A1ng", "99a088f8-782f-4473-ae62-43604ccac054", new DateTime(2001, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "XuanLam.Mai@hotmail.com", "Phạm Quốc Phương", 2, "XUANLAM.MAI@HOTMAIL.COM", "XUANLAM.MAI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEH/rDKgIv1ZS9t4NCsUX70A6cDe0Z1qMAy5/LbhGrrAntsEM3X96PcPAB8eQogxvOA==", "0293 7196 7006", "7e42de61-d0bd-4bd0-ab4b-a2c683af5dcf", "XuanLam.Mai@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2539 Hải Châu Mill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Kh%C3%A1nh%20B%C3%ACnh", "61af6592-f4d8-44f1-a22b-9be04c850bea", new DateTime(1996, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "HuongMai.Ngo78@hotmail.com", "Lý Khánh Bình", "HUONGMAI.NGO78@HOTMAIL.COM", "HUONGMAI.NGO78@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPkOtSyfcu7j3PrewyBJ4nAwyDLPrKkNLAYxSq3b/3lfBNK+zbqOLYIag+PyOWGZFQ==", "0221 3737 1306", "d3f8ab92-602d-41fe-af9e-2ed0be812788", "HuongMai.Ngo78@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8063 Đỗ Inlet", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20V%C3%A2n%20H%C3%A0", "b0cb7277-d810-4279-9152-31aa24af115d", new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "KhueTrung9@yahoo.com", "Đoàn Vân Hà", 2, "KHUETRUNG9@YAHOO.COM", "KHUETRUNG9@YAHOO.COM", "AQAAAAIAAYagAAAAEP3v+7h2H2xYSflby/m2yzDsAuOwtVVVQIc1+2Mn57wd0EjVQ+/yabzKJDCRBgqTkg==", "0233 4756 8619", "c3c0c097-d377-411f-b40e-185bd7fc8386", "KhueTrung9@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5687 Tăng Camp", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20H%E1%BA%A1%20Vy", "554a3d59-53e6-4b0a-9101-1d7ab9d42d6d", new DateTime(1996, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "AnhTung_Mai@yahoo.com", "Tăng Hạ Vy", 2, "ANHTUNG_MAI@YAHOO.COM", "ANHTUNG_MAI@YAHOO.COM", "AQAAAAIAAYagAAAAEEEfW1iy0jNIbrKfpr1XC+gkYkEWOXg/a7JirSkiZtnZ+i/MPv86Xb5u+ws7QacEDQ==", "0221 5395 0921", "b6f9674e-edcf-4894-9682-01b905bfb33a", "AnhTung_Mai@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "060 Yến Anh Skyway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Trung%20Hi%E1%BA%BFu", "38e78df4-30c8-4b05-b382-7d0cbb6928f8", new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "PhuongChau.Mai59@hotmail.com", "Trịnh Trung Hiếu", 2, "PHUONGCHAU.MAI59@HOTMAIL.COM", "PHUONGCHAU.MAI59@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIb0v8h8rlCe3VDUO+JYlyxSf+XWzgmHT1iWnkZzMUAa22ioWawnnjdy3HkAiOi20w==", "0204 4423 8047", "d5573cdf-1341-4295-a856-d825f2f59e00", "PhuongChau.Mai59@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "218 Quang Thiên Neck", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20M%E1%BB%B9%20Y%E1%BA%BFn", "ff00408c-52f0-4c56-a412-d5d2a82f3bb2", new DateTime(2013, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "PhiKhanh37@yahoo.com", "Vương Mỹ Yến", "PHIKHANH37@YAHOO.COM", "PHIKHANH37@YAHOO.COM", "AQAAAAIAAYagAAAAEEhGOENM8pi9n6oKcujm1RboDNT+t05FKzD5mZAkZLW41AxdUqZK6kosx5ynxEllkg==", "0208 1149 5309", "df4bd7b6-2c32-4619-9967-7bca83abc6ba", "PhiKhanh37@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "93620 Thư Lâm Knolls", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Thanh%20Vy", "8729ee99-e2fd-481e-9837-ff9cc4939627", new DateTime(1997, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "ThanhCong.Tang19@hotmail.com", "Hà Thanh Vy", 3, "THANHCONG.TANG19@HOTMAIL.COM", "THANHCONG.TANG19@HOTMAIL.COM", "AQAAAAIAAYagAAAAEOzThawDX7m2Wd6vc36LNzf9YTanyWmMH4voWIQTpIsHuaL4ZVRMB0GAnWpbT8v8tg==", "022 4598 2457", "17be86d2-34d3-44fb-b20a-98b16667b532", "ThanhCong.Tang19@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7809 Xuân Nam Summit", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Kh%C3%A1nh%20Giang", "39b4c84d-4b3b-42a8-8452-2131fafab2e1", new DateTime(2009, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "MinhDanh_Lam@yahoo.com", "Bùi Khánh Giang", 2, "MINHDANH_LAM@YAHOO.COM", "MINHDANH_LAM@YAHOO.COM", "AQAAAAIAAYagAAAAEP1NfvHvGmhB9LpVWYyR78YF6XtCTT4/fROkQcTBBxQmuwmN9BBJE5JDU9M/GvfndA==", "026 0971 1132", "7f21a239-c633-4126-a936-df2d772248ba", "MinhDanh_Lam@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "333 Thúy Hiền Drives", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20B%C3%A1%20Long", "30ec4354-1039-4e26-847a-d7bb5712503e", new DateTime(2003, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "ManhThang.Lam13@yahoo.com", "Hồ Bá Long", 2, "MANHTHANG.LAM13@YAHOO.COM", "MANHTHANG.LAM13@YAHOO.COM", "AQAAAAIAAYagAAAAEA09f0mTEg4UPZYOcgWM/xDEts6r8OL/qbodyJBR0xG2apT+b5EbGvGGHOvNPpJIuw==", "0279 2024 1485", "fe1019a9-185a-4717-b5db-0473e0492f9e", "ManhThang.Lam13@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "413 Vương Knoll", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Xu%C3%A2n%20Y%E1%BA%BFn", "2e5b586e-b542-4c27-ab42-47460f4f19e4", new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), "MaiThy58@yahoo.com", "Phùng Xuân Yến", 1, "MAITHY58@YAHOO.COM", "MAITHY58@YAHOO.COM", "AQAAAAIAAYagAAAAEGXvabuVG8QgrcCIKuCDEJ082tWq65+rmHmd1/pIDo70eshFEtnWsgdnIEuwxPc22g==", "0254 8162 6917", "537950eb-06c9-45b7-a32d-7caa2eea84f9", "MaiThy58@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8424 Phùng Passage", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20C%C3%B4ng%20Tr%C3%A1ng", "13cd7240-91e3-4f11-998d-6d23a5902422", new DateTime(2002, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "VietTien47@hotmail.com", "Tăng Công Tráng", 3, "VIETTIEN47@HOTMAIL.COM", "VIETTIEN47@HOTMAIL.COM", "AQAAAAIAAYagAAAAEO/MsV+aZKca5lXArPh4anb0s0B7q76byZfBTsj3f//zGeLdPfajtXLkWuAOFdzpxQ==", "027 2020 8699", "4900f646-1d14-46ee-a156-af9d821176b7", "VietTien47@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "45390 Thanh Hảo Vista", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Tr%C6%B0%E1%BB%9Dng%20Li%C3%AAn", "92c0003f-8c37-4253-b221-80850e302325", new DateTime(2015, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "TrongDung_Do77@yahoo.com", "Hồ Trường Liên", 1, "TRONGDUNG_DO77@YAHOO.COM", "TRONGDUNG_DO77@YAHOO.COM", "AQAAAAIAAYagAAAAELDhaJAFfLyTeP2xxMaTVcD9sLLRi0tsA5X5akhoqA5uZZydheillAAGu09xtSCZjw==", "021 1977 2348", "ef5c49fa-9bdf-44e0-994f-644c9f49c76d", "TrongDung_Do77@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "338 Chí Thành Hills", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Nghi%20Dung", "6d444751-31ba-4963-b122-b7ac89a98e25", new DateTime(2011, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "TriThang_Phung@yahoo.com", "Trương Nghi Dung", 1, "TRITHANG_PHUNG@YAHOO.COM", "TRITHANG_PHUNG@YAHOO.COM", "AQAAAAIAAYagAAAAEFI+XS/iGjBRYLdKPknDvkL2ScMGbw0qOFeiAMRklxM7/PeXp2vEF9KW7AaWrNaGyQ==", "026 2803 7569", "98af0318-160c-4604-8da5-80d953ee64d1", "TriThang_Phung@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "01307 Trương Crest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Gia%20Khi%C3%AAm", "cd4f2c51-2799-41a7-92e2-f67d79193a4c", new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "BachQuynh_Dang@hotmail.com", "Tăng Gia Khiêm", 2, "BACHQUYNH_DANG@HOTMAIL.COM", "BACHQUYNH_DANG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGrfomrUQFyXAqjYM2lw+dhMLPHhd/WYv26dTYTUwrdDpCORIlnlkz0keqWyVUBIbA==", "021 5931 0878", "219b8206-30d9-4e73-8d62-1c077137adac", "BachQuynh_Dang@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "197 Tăng Stravenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Th%C6%B0%E1%BB%9Dng%20Xu%C3%A2n", "d0de0f85-e859-4022-bbe0-04d463d1e7eb", new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "HaVy.Mai19@yahoo.com", "Ngô Thường Xuân", 1, "HAVY.MAI19@YAHOO.COM", "HAVY.MAI19@YAHOO.COM", "AQAAAAIAAYagAAAAEBrTjKW8zqcP5V8dqdGOO9vE35GsO7SSEwXzQyt9tUpG8q37yEdvnyWg9UlxjbJZnA==", "022 3038 9905", "5c968de7-85a4-4907-a42e-5f6cd9aa4ff1", "HaVy.Mai19@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "127 Đoàn Lane", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C5%A9%20H%E1%BB%AFu%20T%C6%B0%E1%BB%9Dng", "5fa3008c-d7a7-4dce-bf21-9cca9bf2d28c", new DateTime(2000, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), "ThuHuyen11@hotmail.com", "Vũ Hữu Tường", 3, "THUHUYEN11@HOTMAIL.COM", "THUHUYEN11@HOTMAIL.COM", "AQAAAAIAAYagAAAAEO2i/rgydnJB6ypvTBy9D9DcCxrtgXDxdsf97TcgRi2e6vd3c/WWyUDqIkVmPTHZqg==", "029 2794 8602", "f68ffe87-1189-4a64-a3cf-eafd27880ab0", "ThuHuyen11@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "01732 Dương Ports", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Th%E1%BB%A5y%20Du", "92a15709-8d82-42e8-aa5e-84b085a7a6bd", new DateTime(2006, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "QuanDuong_Nguyen@yahoo.com", "Phạm Thụy Du", 1, "QUANDUONG_NGUYEN@YAHOO.COM", "QUANDUONG_NGUYEN@YAHOO.COM", "AQAAAAIAAYagAAAAENKYrXmo8UYvlk1go1vgwTecnmn8HkwMQLfiUZKrWvNLk/9FQIbSQ42p5o3eBaVi3Q==", "021 6395 9926", "c5c87e26-9b83-498c-b7da-e48af8900448", "QuanDuong_Nguyen@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "28149 Trương Parks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20H%C6%B0%C6%A1ng%20Chi", "44415584-5197-4854-8b12-ced9e65f0c83", new DateTime(2017, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "XuanNgoc19@yahoo.com", "Tô Hương Chi", 2, "XUANNGOC19@YAHOO.COM", "XUANNGOC19@YAHOO.COM", "AQAAAAIAAYagAAAAEPIVNLCK+FoC4yfgmc+XoPZET9F0GAzpvcNVDHqcD20baCPvDIiy7aMy16vdcWVuRg==", "0281 5347 4117", "9e844440-e2f3-4972-b949-e227ced1d69f", "XuanNgoc19@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "717 Đặng Freeway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Nh%C3%A3%20%C3%9D", "bfe5d8f6-e35c-4700-8af8-68aa02100d4d", new DateTime(2002, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "LacPhuc_Nguyen77@hotmail.com", "Tăng Nhã Ý", 2, "LACPHUC_NGUYEN77@HOTMAIL.COM", "LACPHUC_NGUYEN77@HOTMAIL.COM", "AQAAAAIAAYagAAAAEID5r4k94MbWCRPq8aKJY3+9rAlXxDb4AKiu30tQqFv1QrHStYxbe6mBEACs6e/IQA==", "0234 1797 5708", "e5db0a65-9a44-4e67-b0e0-783ca677d4b2", "LacPhuc_Nguyen77@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "15845 Trần Via", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Phong%20Ch%C3%A2u", "32dcf8d0-3a94-4385-88c2-a44ea740de3a", new DateTime(1995, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), "ThanhDan_Ngo6@gmail.com", "Lê Phong Châu", 2, "THANHDAN_NGO6@GMAIL.COM", "THANHDAN_NGO6@GMAIL.COM", "AQAAAAIAAYagAAAAEICpWv7WIOm2UeB9ycOLjTBQ+M6ezP/PM76TEH8Mta9eB0B67sg+Gc2j9rnlcxhw2g==", "026 4630 3624", "1ebadd23-0a46-414d-aa64-f289ce4b04ab", "ThanhDan_Ngo6@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "899 Trần Plaza", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Ho%C3%A0i%20Thanh", "42de6480-efe1-4be8-b02a-3e163e6b5b16", new DateTime(2005, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "MinhHieu24@hotmail.com", "Trịnh Hoài Thanh", 1, "MINHHIEU24@HOTMAIL.COM", "MINHHIEU24@HOTMAIL.COM", "AQAAAAIAAYagAAAAEH3acxm/45PxZOnJCZ/Zmq0+qZYfeu/4lfFChVN7SFPz0nlVc4z7PDP6ECLxN8Rwwg==", "0230 5943 9082", "fab964a3-f4d2-4e09-83bb-e9ed7060085e", "MinhHieu24@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4814 Minh Yến Mountains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C5%A9%20V%C4%A9nh%20Lu%C3%A2n", "f42ab07a-da07-42e4-9708-49f1fd44a7aa", new DateTime(2012, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "VangAnh_Trinh@gmail.com", "Vũ Vĩnh Luân", 3, "VANGANH_TRINH@GMAIL.COM", "VANGANH_TRINH@GMAIL.COM", "AQAAAAIAAYagAAAAEGUORJZOIyqLqPDrz/C3X/1r6SitoMTHyAON/bKvOczSm0ldUg17KySpPiAtpg/D4w==", "029 1428 8295", "932ce288-ab26-455d-aeca-13ad8e5c96f6", "VangAnh_Trinh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "81279 Duy Quang Plaza", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20%C3%90%E1%BB%A9c%20To%E1%BA%A3n", "f7163258-b8a8-42ff-94e8-eef049304d90", new DateTime(2019, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "KimPhuong78@hotmail.com", "Vương Ðức Toản", "KIMPHUONG78@HOTMAIL.COM", "KIMPHUONG78@HOTMAIL.COM", "AQAAAAIAAYagAAAAEO16Z426JBGsxWqGUEJb6jBweEkBHeCUIh9QQ2p23Dfo7pPyuk4bPdMpZ66YTVqKXA==", "022 7458 3095", "b6f4153e-752d-411d-9daf-66927628a9b7", "KimPhuong78@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0352 Quang Ðạt Creek", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Minh%20Th%C6%B0%C6%A1ng", "424c03e6-082a-45b6-8be3-8ce1c6da1120", new DateTime(2007, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), "HoangDung71@hotmail.com", "Đinh Minh Thương", "HOANGDUNG71@HOTMAIL.COM", "HOANGDUNG71@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHcMvFL+alkznWwyAMjGE0PFPmCxRDhCtp5IjaNEbfx4TJcnop9mtiYdL2xM93VroA==", "0206 7638 3006", "6b308db2-d1c4-4bc7-aff4-c294c8c3ea3c", "HoangDung71@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "01097 Trương Station", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Ng%E1%BB%8Dc%20L%C3%A2m", "4427afc8-7d65-42d5-898d-93be16371398", new DateTime(2001, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "ThanhLiem_Mai@yahoo.com", "Hà Ngọc Lâm", "THANHLIEM_MAI@YAHOO.COM", "THANHLIEM_MAI@YAHOO.COM", "AQAAAAIAAYagAAAAENGBsS8ieDecq/xzh/lMtfx5CZhHb08SWV/JVcgRZbaQXj0S3nu5KlzIslYup+zj1Q==", "0257 3498 2497", "507a4097-e3e3-4a0b-8bf8-cda4ab249609", "ThanhLiem_Mai@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "565 Mai Trail", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20%C3%90%E1%BB%A9c%20Ph%C3%BA", "cf7fb07c-b92f-4c25-a4a6-06ea77dd9207", new DateTime(2016, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "XuanThuyet_Do11@hotmail.com", "Tô Ðức Phú", "XUANTHUYET_DO11@HOTMAIL.COM", "XUANTHUYET_DO11@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJaEhmmMNijDK+4el8+hsBsDg2743WmWwibgWOt4Jc56pOSKLNxnQVGnYZyj35x/Nw==", "029 5752 5337", "dddffc51-9a57-4322-a865-77460ef24518", "XuanThuyet_Do11@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "761 Duy Minh Pike", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Ph%C3%BAc%20L%C3%A2m", "b747bc6c-c030-4492-bc26-75435bf154f5", new DateTime(2016, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "VanTrinh.Pham@yahoo.com", "Lý Phúc Lâm", "VANTRINH.PHAM@YAHOO.COM", "VANTRINH.PHAM@YAHOO.COM", "AQAAAAIAAYagAAAAEPcSBKLsK+lsbNVyeQBo1sDEng+qAGZjHgeGnuh6MBG+gapx39CFp8Mfcf4vO/MAFA==", "025 5945 3405", "71cbf8a8-2db3-4cf2-b0a8-f22792b71564", "VanTrinh.Pham@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "556 Phùng Route", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Tr%C6%B0%E1%BB%9Dng%20Chinh", "057f18a8-083e-4ce8-977d-2b9bdf3bf239", new DateTime(1998, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), "AnhTho_Mai@yahoo.com", "Lê Trường Chinh", 1, "ANHTHO_MAI@YAHOO.COM", "ANHTHO_MAI@YAHOO.COM", "AQAAAAIAAYagAAAAEERDbPa0PY9aZ7br70wMKIs56grdYN8GXYz2yMZPZlmfATgLWsf2j2uYeOaFAqBr8A==", "0237 5940 8716", "cc239fc9-08df-40e6-8636-abc179fe62b2", "AnhTho_Mai@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "25779 Dạ Nguyệt Squares", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Ti%C3%AAn%20Ph%C6%B0%C6%A1ng", "0cbc05c6-13d5-48bb-b614-54aecd005fcc", new DateTime(2017, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "KhietTam_Doan40@gmail.com", "Lý Tiên Phương", 1, "KHIETTAM_DOAN40@GMAIL.COM", "KHIETTAM_DOAN40@GMAIL.COM", "AQAAAAIAAYagAAAAEIQzlolKYOX9vj+OgENdLvTyh4tVztO2nYnrwWY0sZbW3feL2vgj30xhnNLsuzUauA==", "025 7033 5119", "97a5b44a-be04-426b-a5c7-a9a25c38bd4e", "KhietTam_Doan40@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "09667 Lâm Drives", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Qu%E1%BB%91c%20Th%C3%B4ng", "306f1319-8bc1-4378-a23e-a60234ace0a7", new DateTime(1995, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), "HongVan.Phan@gmail.com", "Hà Quốc Thông", 2, "HONGVAN.PHAN@GMAIL.COM", "HONGVAN.PHAN@GMAIL.COM", "AQAAAAIAAYagAAAAEDqg0kzgXMCCyWfpp6liQKL4QWTx+0B29vwYGDbxRgo66BtKZcnPZibXMKN2ChO8ZA==", "0256 6754 2546", "ac6d190f-4fb8-4f9e-a360-649f8e5f5238", "HongVan.Phan@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "12897 Đoàn Extensions", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20%C3%90%E1%BA%AFc%20L%E1%BB%99", "b20374af-a149-4930-9e47-bbdbd1cd5c26", new DateTime(1997, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "MinhXuan.Duong@hotmail.com", "Đinh Ðắc Lộ", "MINHXUAN.DUONG@HOTMAIL.COM", "MINHXUAN.DUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKUH+d69eNu0+gYWQdXfr/yDxD4/3r1x8c46JkSebqqmLy3c362qkoT3dWOzX1lP6A==", "028 1062 5214", "f86919b7-9d55-410c-959e-c4332278da7b", "MinhXuan.Duong@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9160 Lê Estates", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Kh%C3%A1nh%20Chi", "be04bd1a-9d3f-404d-a522-aea9432320b8", new DateTime(2000, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "AnhMai_Dang30@yahoo.com", "Bùi Khánh Chi", 1, "ANHMAI_DANG30@YAHOO.COM", "ANHMAI_DANG30@YAHOO.COM", "AQAAAAIAAYagAAAAEMLdQ2EOp++7pBPSwSbdB33FPiuMDTgUDNSfEsWDUt5TAJBrRYRvKrUn5upx9xeISw==", "028 2425 7326", "b4fb3cc7-2fbc-46fe-9e5c-217e6e2cbb03", "AnhMai_Dang30@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "13864 Ngô Way", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Ch%E1%BA%A5n%20Phong", "eb51d928-f984-4edb-b4ca-10c81e0820a0", new DateTime(1994, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "KhacMinh.Trinh@gmail.com", "Hà Chấn Phong", 2, "KHACMINH.TRINH@GMAIL.COM", "KHACMINH.TRINH@GMAIL.COM", "AQAAAAIAAYagAAAAEOly7GLADq/0Rny0MN/4sRtjhlECa9UY9XqOktX9vFohW6d6+LAi22bINIhElWBoqg==", "0270 5575 7296", "834f3d17-854d-49cf-82da-54ea780f701b", "KhacMinh.Trinh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4334 Sơn Trang Haven", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Th%C3%B4ng%20%C3%90%E1%BA%A1t", "659ba731-0dc3-442f-9c76-9da633414b2d", new DateTime(2017, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "ThanhKieu51@yahoo.com", "Hoàng Thông Ðạt", "THANHKIEU51@YAHOO.COM", "THANHKIEU51@YAHOO.COM", "AQAAAAIAAYagAAAAEIUiB+61KBDdC4GzmQeOMw58HWXMKyOuICeYhPgzI5uAU9lDymlCAmTPRJXvqNwM7g==", "020 9187 7027", "ffc939b5-db38-40bf-8f2d-11bbbd8382f2", "ThanhKieu51@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "928 Đỗ Field", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Xu%C3%A2n%20Li%E1%BB%85u", "0658d61f-6ae5-4ca2-aa60-27afba32084f", new DateTime(2018, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "BinhDuong.Ngo@hotmail.com", "Lê Xuân Liễu", 1, "BINHDUONG.NGO@HOTMAIL.COM", "BINHDUONG.NGO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBQvKQiVD+F62TTjVJnSnbDIrA22CwNiOZMfa+7oGDgvKU7XfbphFAeJqdmaEZWXrg==", "027 0144 9233", "57737506-ea80-4cec-bf99-3bb62fd746bf", "BinhDuong.Ngo@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9820 Trịnh Shoals", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Trang%20Anh", "90b4eb70-cda7-4302-b2a5-3580ef470f40", new DateTime(2011, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "TungLam_Phan35@yahoo.com", "Trương Trang Anh", 3, "TUNGLAM_PHAN35@YAHOO.COM", "TUNGLAM_PHAN35@YAHOO.COM", "AQAAAAIAAYagAAAAEMK4C12VEAFNLZxOyt634rV/3Q8mSji06aTZeysiifczawLV6vKJG6U1/L28cOR9YQ==", "025 3833 8758", "01d09e72-d521-41cc-8b94-b218eee04a1e", "TungLam_Phan35@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "842 Vũ Cape", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C5%A9%20Ph%C3%BA%20%C3%82n", "463e61e6-e9bf-402d-aa06-709587303380", new DateTime(2000, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), "NgocLan.Truong@yahoo.com", "Vũ Phú Ân", 3, "NGOCLAN.TRUONG@YAHOO.COM", "NGOCLAN.TRUONG@YAHOO.COM", "AQAAAAIAAYagAAAAEE7Rzr1zPWuwSPQW0BsyE1ZqAhrWc225+VAZsb7iUfgCEkhxFrl7Q58ble4jvbpScg==", "024 5341 7076", "f5f5956e-4545-4233-a49d-7046f460a3c7", "NgocLan.Truong@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "11460 Linh Châu River", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Quang%20Th%E1%BA%A1ch", "a4891858-efb2-4215-b344-62839cdc614d", new DateTime(2006, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "BichSan54@hotmail.com", "Hồ Quang Thạch", "BICHSAN54@HOTMAIL.COM", "BICHSAN54@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGYEGTBBSeRvl09BEL4SjT4uL8nbO7sRfKDLKSL3owTFnuvbRmOJLs18maSN9RUOtg==", "023 2111 7997", "98e5595c-d57f-4892-a48d-42fa34d271c5", "BichSan54@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "72277 Hoàng Giang Summit", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20%C3%90%E1%BB%A9c%20Th%E1%BA%AFng", "0c0dc97f-383b-4fa4-92ef-a8153dc3a84e", new DateTime(2010, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "HuyKhanh.Truong85@hotmail.com", "Phùng Ðức Thắng", "HUYKHANH.TRUONG85@HOTMAIL.COM", "HUYKHANH.TRUONG85@HOTMAIL.COM", "AQAAAAIAAYagAAAAECfT7fGWL4+JqemLl7ZJRiOnEBisH+pnQZ1NJ2N/9BDutMJVsEYubRGy2oymaDwn6A==", "024 6898 9449", "203351de-0438-4e4a-b798-ee3168d34a5a", "HuyKhanh.Truong85@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "25247 Ðông Tuyền Forest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20H%E1%BA%A3i%20Anh", "fced7108-a390-4264-8e72-8df8f233da70", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "MinhAnh.Dao12@gmail.com", "Lê Hải Anh", "MINHANH.DAO12@GMAIL.COM", "MINHANH.DAO12@GMAIL.COM", "AQAAAAIAAYagAAAAEPymbNrjjKX5FyIe7vHpaN6eI2WoR3ypMaMscdXQhiVXpGSVTjHGcYy020ck4yHU/Q==", "025 0683 6728", "b8736778-08b8-4a96-951e-626873c9d351", "MinhAnh.Dao12@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7444 Nhã Ý Stravenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20B%C3%ADch%20Hu%E1%BB%87", "ade866ce-213e-4a08-8f59-acd48a7e5dde", new DateTime(2006, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "DinhDon.Truong@yahoo.com", "Lâm Bích Huệ", "DINHDON.TRUONG@YAHOO.COM", "DINHDON.TRUONG@YAHOO.COM", "AQAAAAIAAYagAAAAECaMW8cToj/qAaFqmHt/iLzzOFKtQYABDpi7DhthbJexQh9HHNNJKsP7rRYoxczdHw==", "029 3457 1850", "62b3237c-65c0-49d5-9380-a85ea35881a5", "DinhDon.Truong@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3258 Trần Mill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20Tr%E1%BB%8Dng%20T%C6%B0%E1%BB%9Dng", "7d03c4be-d4f1-4755-9921-f20f3ad48b0a", new DateTime(1997, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "PhuongNgoc_Dinh@yahoo.com", "Đoàn Trọng Tường", "PHUONGNGOC_DINH@YAHOO.COM", "PHUONGNGOC_DINH@YAHOO.COM", "AQAAAAIAAYagAAAAEHU+xt1RmuFuUUajkYyfcSjbRc3r2Vo+8XqMiNVpzukTmMWs8cD9K0KobX6Qr/dQ6w==", "028 3882 0858", "279bd1ab-8e5b-4b46-9dca-42a7d6b0dbf2", "PhuongNgoc_Dinh@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4705 Thanh Thư Path", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Th%C3%BAy%20H%E1%BA%A1nh", "123b3091-a384-45e6-849e-864eae767fd0", new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "TuanKhanh.Dang69@hotmail.com", "Lý Thúy Hạnh", 1, "TUANKHANH.DANG69@HOTMAIL.COM", "TUANKHANH.DANG69@HOTMAIL.COM", "AQAAAAIAAYagAAAAENHAD+0hXAIUe+1BqbwMv0R3uyrahmwW9fPTRuBidVAmSLXCpkh1JP0y9/A3flO/gg==", "027 6764 0977", "82ba1d02-b004-4e49-9c83-3a8657b185dc", "TuanKhanh.Dang69@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "52551 Lâm Cliffs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20%C3%90%C3%ACnh%20Kim", "dedd4a61-c117-48c6-a36f-c9276f99a56e", new DateTime(2010, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "DiemKieu.Trinh65@hotmail.com", "Nguyễn Ðình Kim", 2, "DIEMKIEU.TRINH65@HOTMAIL.COM", "DIEMKIEU.TRINH65@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJ1h0LonWxMiIxDLBCeThF/IlL+PjV+/jPshuJ16ZNMz22iQGGnjW1B5FGFkmvV+5Q==", "027 4529 0581", "c174b281-dc1f-4884-9ad6-fd0e4db4282a", "DiemKieu.Trinh65@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "454 Phùng Freeway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Di%E1%BB%87u%20%C3%81i", "d97f5dab-fc67-49c0-9cd3-590058d48082", new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "HoaiVy.Ly@yahoo.com", "Tăng Diệu Ái", 3, "HOAIVY.LY@YAHOO.COM", "HOAIVY.LY@YAHOO.COM", "AQAAAAIAAYagAAAAECcfw/jh2Nq6pOOFC7CbotKs4oabUJh/OFVEVvWWZt8HFWaNZAPVdiLuY1QMjpZAAA==", "026 7967 1892", "a5919acf-478b-43e3-b9d3-b9f571357a25", "HoaiVy.Ly@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "533 Đỗ Parks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Trung%20Ki%C3%AAn", "2a0b1cba-91e3-4fdd-8b1e-cd45c4927f76", new DateTime(2016, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "NgocHoa.Vu@yahoo.com", "Ngô Trung Kiên", 2, "NGOCHOA.VU@YAHOO.COM", "NGOCHOA.VU@YAHOO.COM", "AQAAAAIAAYagAAAAEPxuLrYCp7/KQZLbkYCLqkmqPKvMH/U3F8c+D4HFbEy+pXZ7i8g/11LUTV1ztLlvRg==", "024 5724 2168", "c21dcc3f-9201-42f5-8915-053570786d8e", "NgocHoa.Vu@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2235 Trương Mount", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Tu%E1%BB%87%20M%E1%BA%ABn", "a248b9f2-6059-4ebb-8856-7b3071c8b6da", new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "TrangAnh.To@hotmail.com", "Mai Tuệ Mẫn", "TRANGANH.TO@HOTMAIL.COM", "TRANGANH.TO@HOTMAIL.COM", "AQAAAAIAAYagAAAAELzHi1oIGg7fE8Fm3aQlvsg42lk5NyG2RgABxna6UPXUF+A+i/lEEplL8SlcskJI7Q==", "028 3054 7914", "88f774a8-924e-40af-aa70-4a3473c32275", "TrangAnh.To@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "594 Hiếu Liêm Burgs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20Th%E1%BB%A5y%20Uy%C3%AAn", "34022923-ac5e-41cb-bbd6-127c1fea4f2c", new DateTime(2001, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "QuyKhanh.Le17@hotmail.com", "Nguyễn Thụy Uyên", 3, "QUYKHANH.LE17@HOTMAIL.COM", "QUYKHANH.LE17@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGRJ2mOwqgwE+NhKmt09lxL6kj7PobfEKIvj2lEgu+qezazFCBAYGc9+QW0YOZxiRQ==", "022 3242 6520", "4539b0f2-b609-4065-80dc-fa0a891cdeb6", "QuyKhanh.Le17@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "87419 Diệu Nương Grove", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20H%E1%BB%AFu%20C%C6%B0%E1%BB%9Dng", "dd1ae8ac-0081-4698-9932-f61183bc7fd3", new DateTime(2019, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "BaoQuyen_Nguyen12@hotmail.com", "Phan Hữu Cường", "BAOQUYEN_NGUYEN12@HOTMAIL.COM", "BAOQUYEN_NGUYEN12@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKfDhb4k2rKmWBf/RnGuUH3CajncRRkqoMSsNS536BUXw8+F4rp+6lNgKj1YcJaMAw==", "0224 1609 2723", "8ca26863-d411-4b28-b343-5e5d3def009e", "BaoQuyen_Nguyen12@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "666 Bùi Vista", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20Xu%C3%A2n%20Thi%E1%BB%87n", "9a860426-b5de-493f-b1b5-33f609ecc4d7", new DateTime(1995, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "LeGiang.Truong84@yahoo.com", "Đào Xuân Thiện", 3, "LEGIANG.TRUONG84@YAHOO.COM", "LEGIANG.TRUONG84@YAHOO.COM", "AQAAAAIAAYagAAAAEEmjIGOToZNR1k8pes+AjI5rq8vDnCaL+DiPrsiplERLSJe7ysE+/D9RRyQKgsm/5Q==", "0255 6097 8521", "55efd9d8-b623-426a-a623-2de7858f85da", "LeGiang.Truong84@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7883 Quang Lân Manors", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Th%C3%BAy%20Huy%E1%BB%81n", "f78c9531-23c5-4712-9ce6-b83f39ac7be0", new DateTime(2015, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "SonQuan_Vu@yahoo.com", "Mai Thúy Huyền", 1, "SONQUAN_VU@YAHOO.COM", "SONQUAN_VU@YAHOO.COM", "AQAAAAIAAYagAAAAEB90jJP0JRStwjog0y7iJ3hfbsr/oufF1pNRw0+ckNnMgxgOarCFbj0HtrM5Em5J2g==", "025 1585 4411", "19bca615-8d7f-4d3f-928e-a8206dd03c8b", "SonQuan_Vu@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "21515 Mỹ Diễm Canyon", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Di%E1%BB%87u%20Th%C3%BAy", "756e21f0-5039-4bfe-bcda-f65a2f491934", new DateTime(2000, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "HongTham.Dang76@hotmail.com", "Lý Diệu Thúy", "HONGTHAM.DANG76@HOTMAIL.COM", "HONGTHAM.DANG76@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAevR0Gkpnavvot8lj3gU5oKEYmaEIxtbrzEP6hzvFHZbBawMgS4jM1Ha0pbmOldgg==", "022 8528 9169", "6812d00f-659c-48db-bb61-3b34a8651b64", "HongTham.Dang76@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "97206 Nguyễn Knolls", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20H%E1%BA%A1nh%20T%C6%B0%E1%BB%9Dng", "88695e1e-7e02-4011-99a4-0ad44755bdcd", new DateTime(2011, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "HuuHoang52@yahoo.com", "Trần Hạnh Tường", "HUUHOANG52@YAHOO.COM", "HUUHOANG52@YAHOO.COM", "AQAAAAIAAYagAAAAEKeIOKDiB+DEYLMlYtrJ4kca2nndhvd+McJZOhdfHmM2XFWTrQVy9+XHDSPkRAtY9Q==", "0298 5207 8476", "afb5a009-4bf2-4f77-810e-adf2e1250b1b", "HuuHoang52@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4269 Tường Anh Fork", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Quang%20L%C3%A2m", "551eef0b-a1ec-4378-9535-ce5aeb151d56", new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "MinhThu_Lam@hotmail.com", "Tăng Quang Lâm", "MINHTHU_LAM@HOTMAIL.COM", "MINHTHU_LAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEO4ipOjgpG17WHPK97E3yanB5SvGCL9LUHUOvRECkYEZqxn5wwUEY43b1FYHcgn6RA==", "024 8931 2363", "1523144d-cbaf-4f64-a953-e2b92702e7bb", "MinhThu_Lam@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8648 Diệu Ngọc Plain", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20An%20B%C3%ACnh", "44912615-b85a-41a8-94e1-3c3b3004bb85", new DateTime(2012, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "TanPhat.Dang52@yahoo.com", "Hoàng An Bình", 2, "TANPHAT.DANG52@YAHOO.COM", "TANPHAT.DANG52@YAHOO.COM", "AQAAAAIAAYagAAAAEKbMspHwPtMSLAZP4WkN5iaPBTU3BsOYpiC74B5zBt66bYJYiQP37leRroiXmEWigA==", "0269 1128 9071", "67cf8463-b8bc-42f4-a9f2-7b95a97219df", "TanPhat.Dang52@yahoo.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 12, 0, 0, 0), 44, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), 93, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 14, 0, 0, 0), 20, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 0, 0, 0), 7, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 17, 0, 0, 0), 77, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 13, 0, 0, 0), 7, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 18, 0, 0, 0), 12, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), 74, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 13, 0, 0, 0), 79, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 17, 0, 0, 0), 39, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 18, 0, 0, 0), 77, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), 34, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), 6, 56, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), 20, 68, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 16, 0, 0, 0), 69, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), 61, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 10, 0, 0, 0), 36, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 14, 0, 0, 0), 14, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2022, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 9, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 17, 0, 0, 0), 52, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), 40, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 18, 0, 0, 0), 94, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 17, 0, 0, 0), 73, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 9, 0, 0, 0), 85, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 16, 0, 0, 0), 76, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 14, 0, 0, 0), 28, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), 1, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 18, 0, 0, 0), 35, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 16, 0, 0, 0), 70, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 14, 0, 0, 0), 15, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 10, 0, 0, 0), 91, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 0, 0, 0), 31, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 11, 0, 0, 0), 64, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 17, 0, 0, 0), 56, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 17, 0, 0, 0), 56, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), 18, 54, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), 82, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 11, 0, 0, 0), 94, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 12, 0, 0, 0), 76, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 13, 0, 0, 0), 21, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 14, 0, 0, 0), 28, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 12, 0, 0, 0), 49, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 9, 0, 0, 0), 46, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 15, 0, 0, 0), 75, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 18, 0, 0, 0), 42, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 14, 0, 0, 0), 50, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), 19, 97, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 0, 0, 0), 10, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 13, 0, 0, 0), 78, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 13, 0, 0, 0), 31, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 17, 0, 0, 0), 78, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 16, 0, 0, 0), 19, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 13, 0, 0, 0), 61, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), 1, 98, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 10, 0, 0, 0), 87, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), 18, 13, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 12, 0, 0, 0), 73, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), 72, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), 3, 91, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), 33, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 16, 0, 0, 0), 72, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 14, 0, 0, 0), 97, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 9, 0, 0, 0), 13, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), 60, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 12, 0, 0, 0), 75, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 9, 0, 0, 0), 61, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2022, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), 13, 100 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 17, 0, 0, 0), 14, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 13, 0, 0, 0), 101, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2022, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 14, 0, 0, 0), 83, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 18, 0, 0, 0), 52, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 10, 0, 0, 0), 87, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 17, 0, 0, 0), 53, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 16, 0, 0, 0), 96, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 14, 0, 0, 0), 82, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), 82, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 13, 0, 0, 0), 70, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 16, 0, 0, 0), 71, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 15, 0, 0, 0), 81, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 12, 0, 0, 0), 36, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 13, 0, 0, 0), 22, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 14, 0, 0, 0), 1, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), 1, 90, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), 33, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), 39, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 18, 0, 0, 0), 44, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 14, 0, 0, 0), 77, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 20, 31, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 18, 0, 0, 0), 94, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 17, 0, 0, 0), 41, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 0, 0, 0), 11, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), 31, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 18, 0, 0, 0), 11, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 16, 0, 0, 0), 42, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), 13, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 17, 0, 0, 0), 54, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 15, 0, 0, 0), 35, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 16, 0, 0, 0), 46, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), 3, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 0, 0, 0), 16, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 0, 0, 0), 56, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 10, 0, 0, 0), 32, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 14, 0, 0, 0), 10, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), 39, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 16, 0, 0, 0), 90, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 11, 0, 0, 0), 45, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 18, 0, 0, 0), 46, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 16, 0, 0, 0), 4, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 16, 0, 0, 0), 51, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 9, 0, 0, 0), 77, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 9, 0, 0, 0), 23, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 13, 0, 0, 0), 98, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 12, 0, 0, 0), 15, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 15, 0, 0, 0), 18, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), 48, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 12, 0, 0, 0), 97, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 18, 0, 0, 0), 60, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 9, 0, 0, 0), 80, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 16, 0, 0, 0), 88, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 18, 0, 0, 0), 95, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), 55, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), 29, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 11, 0, 0, 0), 75, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), 29, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 18, 0, 0, 0), 15, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 17, 88 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 9, 0, 0, 0), 64, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), 3, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 17, 0, 0, 0), 34, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), 66, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), 21, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), 45, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 17, 86 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 11, 0, 0, 0), 41, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 15, 0, 0, 0), 69, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), 16, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 0, 0, 0), 40, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 12, 0, 0, 0), 75, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 10, 0, 0, 0), 44, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), 58, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 17, 0, 0, 0), 7, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 11, 0, 0, 0), 39, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 16, 0, 0, 0), 60, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 9, 0, 0, 0), 46, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), 84, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 15, 0, 0, 0), 99, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), 19, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 17, 0, 0, 0), 10, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 0, 0, 0), 55, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), 81, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 13, 0, 0, 0), 38, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 15, 0, 0, 0), 40, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), 5, 84, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 16, 0, 0, 0), 47, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 0, 0, 0), 64, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 10, 0, 0, 0), 26, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), 78, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 16, 0, 0, 0), 76, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 18, 0, 0, 0), 62, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 14, 0, 0, 0), 37, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 12, 0, 0, 0), 48, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), 11, 82, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 17, 0, 0, 0), 98, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 11, 0, 0, 0), 40, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 0, 0, 0), 43, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 10, 0, 0, 0), 1, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 10, 0, 0, 0), 89, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 10, 0, 0, 0), 30, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), 18, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), 86, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 18, 0, 0, 0), 78, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 17, 0, 0, 0), 38, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 15, 0, 0, 0), 39, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 15, 0, 0, 0), 85, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 16, 0, 0, 0), 81, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), 59, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), 92, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, 41, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 18, 0, 0, 0), 7, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 15, 0, 0, 0), 56, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 16, 0, 0, 0), 88, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 9, 0, 0, 0), 33, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 14, 0, 0, 0), 62, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 17, 0, 0, 0), 32, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 9, 0, 0, 0), 68, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 13, 0, 0, 0), 42, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 9, 0, 0, 0), 97, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), 12, 63, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 10, 0, 0, 0), 61, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), 58, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 9, 0, 0, 0), 1, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 9, 0, 0, 0), 10, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 12, 0, 0, 0), 62, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), 12, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 14, 0, 0, 0), 40, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 18, 0, 0, 0), 93, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Thần kinh", 4, 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Tim mạch", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "Specialization" },
                values: new object[] { "Bác sĩ có hơn 3 năm trong lĩnh vực Tim mạch", 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 3 năm trong lĩnh vực Tim mạch", 2, 3 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Nhi khoa", 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Đa khoa", 1, 10 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Nhi khoa", 5, 10 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Tim mạch", 2, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 3 năm trong lĩnh vực Đa khoa", 1, 3 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "About", "Specialization" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Da liễu", 3 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Da liễu", 3, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Tim mạch", 2, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Đa khoa", 1, 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "About", "Specialization" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Đa khoa", 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Tim mạch", 2, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Da liễu", 3, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Da liễu", 3, 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Đa khoa", 1, 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Da liễu", 3, 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2d5a603-fdf8-4482-ab36-c4dbbde43074", "AQAAAAIAAYagAAAAEEejT/8JFFw95bPViyCbrdhqlwnG+Pxb81+5U4XFAf4zwHjNDbVWqjhS64+n+2p/GQ==", "f86da275-5f52-4c45-a026-1c54b8395de7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "473 Đinh Orchard", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Kh%C3%A1nh%20Huy%20Ph%E1%BA%A1m", "58e42801-9c9c-48ee-b687-02b479874024", new DateTime(2017, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "DucBinh27@yahoo.com", "Khánh Huy Phạm", "DUCBINH27@YAHOO.COM", "DUCBINH27@YAHOO.COM", "AQAAAAIAAYagAAAAEOpel+T1GNyoxZqskr4m6mg0w6E1Za13znkaD5CwCoYysy3WwBLe8NrvtrWHlM4F6A==", "028 5077 6849", "f9232cb9-ade1-4996-99d7-21e265a94a78", "DucBinh27@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2430 Tô Lodge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Qu%C3%A2n%20%C4%90%E1%BA%B7ng", "b5cd3a22-ae71-470a-8697-cc06b696aff6", new DateTime(1997, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "ThanhViet_Phung@gmail.com", "Hoàng Quân Đặng", 3, "THANHVIET_PHUNG@GMAIL.COM", "THANHVIET_PHUNG@GMAIL.COM", "AQAAAAIAAYagAAAAEJKEqOeQ9dGpO1yy7snz99dy3HoNTI1SHdWYCrnQkdQgvljXURMHxc+pmXyI8Q16Ug==", "028 2650 5498", "8bad7c25-e073-4439-b18e-39a978d57cdb", "ThanhViet_Phung@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1414 Minh Cảnh Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thu%E1%BA%ADn%20To%C3%A0n%20%C4%90inh", "bb27be52-9a95-4c8d-bc32-c020d78112ee", new DateTime(2015, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "BaoHa60@yahoo.com", "Thuận Toàn Đinh", 1, "BAOHA60@YAHOO.COM", "BAOHA60@YAHOO.COM", "AQAAAAIAAYagAAAAEPse6KJyMiWyZtL/5SCxycl4LM4HZOBtLi+iiG+6gwYZ8Alm4u3dCVVoFfv+JYa/Og==", "028 0067 7051", "71f91967-21f0-407a-af8a-b6de7fb830b5", "BaoHa60@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "83624 Hà Trail", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%E1%BB%A5c%20Trang%20%C4%90%E1%BA%B7ng", "ec55828e-fcf2-4594-8cd0-a7d38d691a50", new DateTime(2016, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "HungDung_Hoang@hotmail.com", "Thục Trang Đặng", 3, "HUNGDUNG_HOANG@HOTMAIL.COM", "HUNGDUNG_HOANG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDBi0osczoMACWa6Se8K5ktkeDrM5RbyAfY/venpCviVdq22b8d9cEzytqxfbMDZtQ==", "022 7204 2706", "9cd75536-0c3e-45f6-ade5-9ab433bd142d", "HungDung_Hoang@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6674 Đỗ Prairie", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thu%20Huy%E1%BB%81n%20Tr%E1%BA%A7n", "01929f14-12e9-42dd-8931-374988c535e3", new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), "TriHuu_To69@gmail.com", "Thu Huyền Trần", 2, "TRIHUU_TO69@GMAIL.COM", "TRIHUU_TO69@GMAIL.COM", "AQAAAAIAAYagAAAAEG6gmIWaRiGqkeR2q2UuYT0sDWzayWa+kzjZAKrjezAG5e4BGe4MG9if5shBrbD1rw==", "026 9715 7509", "1f4237c0-cfd1-4269-bb63-7daf68148498", "TriHuu_To69@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "45341 Quang Thạch Common", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C3%AD%20Li%C3%AAn%20Mai", "30930fd9-3910-4fd7-b6e8-dbded0a552e7", new DateTime(1995, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "ThienThanh_Do@hotmail.com", "Trí Liên Mai", 3, "THIENTHANH_DO@HOTMAIL.COM", "THIENTHANH_DO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMBcuRkNvLBWoTQpeJtcS3W5Mfm5j31BgokjFe06HeWCorsETnUUW4PD+BiNYxzbGQ==", "0283 1761 5530", "b67b151b-74a8-4931-862d-a785aeb8cf28", "ThienThanh_Do@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "428 Ðoan Thanh Coves", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Qu%E1%BB%91c%20Trung%20T%C3%B4", "b69d9014-b59a-4145-9dd5-3f07127be61b", new DateTime(2019, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "AiVan.Ngo@yahoo.com", "Quốc Trung Tô", 2, "AIVAN.NGO@YAHOO.COM", "AIVAN.NGO@YAHOO.COM", "AQAAAAIAAYagAAAAEC/u+6RweTCE9pVFm4AAL1xf0yIhr8iXJIt79gpilwoJYA16yALwOm1x+f85eLa65Q==", "023 0956 3364", "4437c944-e2ca-4f32-bb7b-fb2315d9431e", "AiVan.Ngo@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0716 Thúy Vân Lake", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ch%C3%AD%20Hi%E1%BA%BFu%20Ph%C3%B9ng", "38db17f5-681a-4cb2-b353-300291130e26", new DateTime(1995, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "TrucLy16@yahoo.com", "Chí Hiếu Phùng", 1, "TRUCLY16@YAHOO.COM", "TRUCLY16@YAHOO.COM", "AQAAAAIAAYagAAAAED+8D3pQpV60ZerqVh5VRBPpOXk3jutciMTrs6CcibshfJhr4CVWWp/kueqaKlV4eQ==", "021 4280 5913", "dadc50c7-25cc-4ef0-8edf-d2189ce9241c", "TrucLy16@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7625 An Nhiên Port", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%E1%BA%BF%20Ph%C3%BAc%20Ph%E1%BA%A1m", "90b825c7-3ca0-4141-b1d9-c14efed58298", new DateTime(2010, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "HongChau.Le@gmail.com", "Thế Phúc Phạm", 2, "HONGCHAU.LE@GMAIL.COM", "HONGCHAU.LE@GMAIL.COM", "AQAAAAIAAYagAAAAEHSeTJYHXI/mlSIogRAjOb6Y2lL7UGEKaGqiI6ovBxsf7v8/HAFQCMYVYwLBt6xWvw==", "022 8001 2952", "5250d917-0b37-4803-9963-df25a70fab7a", "HongChau.Le@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "881 Đinh Land", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%E1%BB%9Dng%20Giang%20Ng%C3%B4", "7f92914b-5d39-421f-90e6-a3996d2dd977", new DateTime(2015, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "HongAnh.Vuong7@yahoo.com", "Trường Giang Ngô", 3, "HONGANH.VUONG7@YAHOO.COM", "HONGANH.VUONG7@YAHOO.COM", "AQAAAAIAAYagAAAAEB/uCZBidhs5qBfM5sjbHZYi4Gg82Qpkn542aAdnuUh85ECf8FFWA1fJxQpflS2Yrw==", "029 3255 6130", "209e3f59-461c-46c4-af65-c0946286d751", "HongAnh.Vuong7@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2806 Tô Coves", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%C3%A1i%20Th%E1%BA%A3o%20L%C3%BD", "0aed4b5c-2ac8-4fce-9b12-ef94a23170e0", new DateTime(2002, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), "VyLan17@hotmail.com", "Thái Thảo Lý", "VYLAN17@HOTMAIL.COM", "VYLAN17@HOTMAIL.COM", "AQAAAAIAAYagAAAAELaxrafOilhCG9a0LPmjwN/H/YgZcd++voerfzeWPTmUgFW2amKXvDtZo7gD1YI+WQ==", "0243 3783 2654", "cef8a3cf-d8a4-43fd-97af-2f2ccbac0d8d", "VyLan17@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "114 Ngô Ford", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Vi%E1%BB%87t%20Tuy%E1%BA%BFt%20T%C4%83ng", "d89d7f46-b9cb-49fe-bbc7-0101d3fa3528", new DateTime(2005, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "ThanhThuy.Phung2@yahoo.com", "Việt Tuyết Tăng", 2, "THANHTHUY.PHUNG2@YAHOO.COM", "THANHTHUY.PHUNG2@YAHOO.COM", "AQAAAAIAAYagAAAAEG77BeHFtmF+lN8aKOLiWdKO8TCOp0+LkRpzbvdNIMWCtz2xZh0NWbZlSlheDn7fPA==", "0261 9543 1333", "67ad70a4-758d-47ba-b899-aaab63e17ee7", "ThanhThuy.Phung2@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "282 Vương Port", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=M%E1%BB%99ng%20Nhi%20V%C6%B0%C6%A1ng", "0c580f91-1743-40ac-9191-96c1ccdd71c0", new DateTime(2009, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "ThuThuy.Tang@yahoo.com", "Mộng Nhi Vương", 3, "THUTHUY.TANG@YAHOO.COM", "THUTHUY.TANG@YAHOO.COM", "AQAAAAIAAYagAAAAEOeMk3DhcEd+qSv9tZGNouTk47IAeSi/r26OAJIp5o3EU0BAHUnRw55fJ/OxLuaGmw==", "0289 8218 2142", "c747ef7c-58fc-411d-a724-395152692fdc", "ThuThuy.Tang@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9928 Đoàn Hollow", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%E1%BA%A1ch%20V%C3%A2n%20L%C3%A2m", "64eb86e8-7273-426a-94e0-38161c0232f8", new DateTime(2005, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "AnhHong.Phung@hotmail.com", "Bạch Vân Lâm", 1, "ANHHONG.PHUNG@HOTMAIL.COM", "ANHHONG.PHUNG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBG6JfGMyztrrtb73s5NhSzyL8sSzPUNVXHM2RYQrA+lcXUaI1eS7P8CDejE7STgww==", "0237 9493 0324", "137e079f-545c-4552-b75c-e4605ff94e14", "AnhHong.Phung@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8517 Thành Tín Isle", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C3%90%E1%BB%A9c%20Th%C3%A0nh%20%C4%90%C3%A0o", "921cd16b-6da1-4af5-b02c-9f74720b1d43", new DateTime(2006, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "KienDuc10@gmail.com", "Ðức Thành Đào", 1, "KIENDUC10@GMAIL.COM", "KIENDUC10@GMAIL.COM", "AQAAAAIAAYagAAAAEDF1Qy3/hmXxt+/ScMmjObMsbv8I5dfCfDliigm5OBtJ0a5+D4RWk2QLfRaReEW5UQ==", "0224 3618 1808", "97d02c24-b4ec-4d66-a301-a9322eb5c45c", "KienDuc10@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "690 Lâm Plaza", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%E1%BA%A3o%20Ch%E1%BA%A5n%20L%C3%AA", "8017289f-5488-4d83-a4c1-7e088a6ce584", new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "TuanTrung_Pham5@hotmail.com", "Bảo Chấn Lê", 1, "TUANTRUNG_PHAM5@HOTMAIL.COM", "TUANTRUNG_PHAM5@HOTMAIL.COM", "AQAAAAIAAYagAAAAELJTLRncU8U9qK9dVXZKHOVD9qtVhiZ8SmOYoAF0LUEFyybmIKPckH399uKuuQPxHw==", "0242 7271 3194", "fb8c4761-019c-44cd-9a1f-0c4898bb2956", "TuanTrung_Pham5@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "93753 Đào Estate", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=M%E1%BA%A1nh%20T%E1%BA%A5n%20Nguy%E1%BB%85n", "a1d7037f-9735-46f4-aeeb-2ccc986f323f", new DateTime(2017, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), "BichHue_Doan24@hotmail.com", "Mạnh Tấn Nguyễn", 3, "BICHHUE_DOAN24@HOTMAIL.COM", "BICHHUE_DOAN24@HOTMAIL.COM", "AQAAAAIAAYagAAAAED1jvWarQ+/bhOORHHX2Ryui5VzWignaCHLyZSetGdZVFpQVDXunfwUu3eafRZdAZA==", "020 4944 5637", "022cd7ea-57b6-41d4-8a27-dbfd43d84cb3", "BichHue_Doan24@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2567 Lê Hills", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=M%E1%BB%B9%20Tr%C3%A2m%20%C4%90%E1%BA%B7ng", "9a617aee-396a-48b6-92a1-84da473bf70d", new DateTime(2003, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "NgocDoan87@yahoo.com", "Mỹ Trâm Đặng", 2, "NGOCDOAN87@YAHOO.COM", "NGOCDOAN87@YAHOO.COM", "AQAAAAIAAYagAAAAEEtU9sYAz/RQ49xLYOZPvXuN/hll53PaddBynDil3ror+HE9nbFfxyJSn5AjDY+ifw==", "0289 8030 3395", "43036263-45d3-43ce-a7c8-e3aa1742ec90", "NgocDoan87@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "687 Hạnh My Plains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thi%C3%AAn%20M%E1%BA%A1nh%20Ph%C3%B9ng", "568fca23-07a1-4a45-843d-06bef8908f31", new DateTime(2010, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "BaThinh76@hotmail.com", "Thiên Mạnh Phùng", 1, "BATHINH76@HOTMAIL.COM", "BATHINH76@HOTMAIL.COM", "AQAAAAIAAYagAAAAED5PUBWEJZG37vPaMvw18NFDidg6bThMKS3GKdlGYLL22iPQGj7aB1fMidOThGPfkQ==", "0201 4849 6235", "d497e652-c6a9-4054-898b-4b8d10d5047b", "BaThinh76@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "16203 Phan Cape", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Nhi%20%C4%90%E1%BB%97", "4a57bceb-d1d6-4b78-af94-bbe37884060d", new DateTime(1998, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "DucPhong_Vu97@yahoo.com", "Mai Nhi Đỗ", "DUCPHONG_VU97@YAHOO.COM", "DUCPHONG_VU97@YAHOO.COM", "AQAAAAIAAYagAAAAEByrnhZooy4mMnYQGxPA81DTt7bIPPqezsnoCFJccgHh4IiwDC/F1akJlwWc0vHv7w==", "0288 4070 1645", "3206be4a-7660-4c94-9ec6-369810af4b5f", "DucPhong_Vu97@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "26571 Hoàng Khang Pine", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%E1%BA%BF%20H%C3%B9ng%20%C4%90%C3%A0o", "9e3b3a15-c9df-4b3e-b6d8-91144ea077b2", new DateTime(1997, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), "DongTuyen_Truong47@gmail.com", "Thế Hùng Đào", "DONGTUYEN_TRUONG47@GMAIL.COM", "DONGTUYEN_TRUONG47@GMAIL.COM", "AQAAAAIAAYagAAAAEOY5PJwxHmAIbmliBWss1LJoRY3WL1uWYagoxw0+DT1UJ1qIlOUuEBfC7F12b9GsOQ==", "025 2159 5733", "1c885690-d2f9-4609-99b1-4637dd62ef4e", "DongTuyen_Truong47@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "981 Duy Tuyền River", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Danh%20Nh%C3%A2n%20H%E1%BB%93", "5a49dc10-6426-47de-8520-2549663ec32f", new DateTime(2018, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "DuyLuan_Bui91@hotmail.com", "Danh Nhân Hồ", "DUYLUAN_BUI91@HOTMAIL.COM", "DUYLUAN_BUI91@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBDYqBbgFYcIB5BZg/+cg3r/bz0FTwMBqAzWteKtZE9i/GxZKOWVimUCLptMtDS0qA==", "020 4118 5183", "5a1e17f1-f6af-4645-8ec4-222597cc4198", "DuyLuan_Bui91@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "54876 Trịnh Route", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%A2n%20Tr%C3%BAc%20T%C3%B4", "b5d65ec0-03b8-4663-a805-b2144e7678ba", new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "KhaiTam.Ho66@gmail.com", "Ngân Trúc Tô", 1, "KHAITAM.HO66@GMAIL.COM", "KHAITAM.HO66@GMAIL.COM", "AQAAAAIAAYagAAAAEMoHN91sZnkA8PPdWQDuglXptLRZcosylQ8JL2wlL5Pnh7y3C3avTcJjXmGnGUM23w==", "026 6308 7948", "0357da13-4237-4afb-bf63-3f5d601befa9", "KhaiTam.Ho66@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "615 Việt Quyết Drive", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C6%B0%E1%BB%A3ng%20Uy%C3%AAn%20Mai", "06c84b2d-2ce1-4fd2-a055-f9d7aee6fb7a", new DateTime(2017, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), "ThienGiang_Doan@hotmail.com", "Phượng Uyên Mai", 3, "THIENGIANG_DOAN@HOTMAIL.COM", "THIENGIANG_DOAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJe0iRz/lTV+r3VuvxHHJQ+CjwzmbSSvZtZ05yNobhqeYksj2zXk9IlTYC18cLn3WQ==", "021 6065 8166", "a2ddd15a-92bc-44e2-a07f-1566eb2f6991", "ThienGiang_Doan@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "28559 Vũ Stream", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nh%C6%B0%20Khang%20Ph%C3%B9ng", "da024a62-fd9b-424c-be80-6c90bdc68778", new DateTime(2017, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "QuePhuong.Duong52@gmail.com", "Như Khang Phùng", 3, "QUEPHUONG.DUONG52@GMAIL.COM", "QUEPHUONG.DUONG52@GMAIL.COM", "AQAAAAIAAYagAAAAEJVLen53GhpN4nkrz3+hBqY4OeXbsMyOqe1bbj2GrJdymDAVJcp8rxqc9fwSz+Zl1w==", "0268 3838 2702", "38dae0f7-73df-467c-b4cc-c828cf2261ed", "QuePhuong.Duong52@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "545 Hồng Giang Trace", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%A1%20Ph%C6%B0%E1%BB%9Bc%20Mai", "38e9bf93-24b5-421f-9273-37a961375ef7", new DateTime(2003, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "XuanTrung_Nguyen41@gmail.com", "Bá Phước Mai", 3, "XUANTRUNG_NGUYEN41@GMAIL.COM", "XUANTRUNG_NGUYEN41@GMAIL.COM", "AQAAAAIAAYagAAAAECdgz/XZt1xdvbRqjB8eTd9EMtJGbByEISyfJB7P0QHWKiT7mVRd4YVSjClkhL0eIw==", "0284 8047 4661", "08c0c260-fd86-47b5-b817-454ab1562ccc", "XuanTrung_Nguyen41@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "504 Giáng Tiên Row", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thi%E1%BB%87n%20Ph%C6%B0%E1%BB%9Bc%20L%C3%AA", "12352276-1cc8-4e4e-894e-f48db37f6a48", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "HuuTho.Duong@hotmail.com", "Thiện Phước Lê", 3, "HUUTHO.DUONG@HOTMAIL.COM", "HUUTHO.DUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFWIaKx3vpooaJFk8f6xbiTU125z5CJEyA3fOlsL8udE8xyvcobwxzJwasJF/vlztQ==", "021 0857 8371", "5c346e71-aace-4e7f-9295-265c63e01eab", "HuuTho.Duong@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5302 Lê Inlet", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Gia%20Ph%C6%B0%E1%BB%9Bc%20Ph%E1%BA%A1m", "493744f0-d65f-4cee-88a6-491a2280f41b", new DateTime(2009, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "QuynhGiao23@gmail.com", "Gia Phước Phạm", "QUYNHGIAO23@GMAIL.COM", "QUYNHGIAO23@GMAIL.COM", "AQAAAAIAAYagAAAAEEKqrFI6Pc23Kp+TAzczDeEXxQTgHLMrojVL5huzxh/LE1eeA2tjcK8g4di1fZKMHQ==", "028 9515 7091", "9bcb9a42-5099-434e-8951-3b4a0cdab895", "QuynhGiao23@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7484 Phan Pine", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C3%AD%20Th%E1%BA%AFng%20T%C4%83ng", "52e06a66-0533-4f00-a9bb-e152684c1d66", new DateTime(1999, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "HuyHa39@hotmail.com", "Trí Thắng Tăng", "HUYHA39@HOTMAIL.COM", "HUYHA39@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPjD93Wzzl6sWjhZEhGUIPX8Wq/HS2soEBbCrCoz29CKmCAXCz4O3Q/FxK8DxMkzIw==", "0254 5517 1984", "da325261-b506-48e8-b1df-057e50e2475c", "HuyHa39@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "42345 Nguyễn Walks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%E1%BB%87%20Qu%C3%A2n%20Tr%E1%BA%A7n", "0f77a303-dc2f-403b-ac64-4329ca6f07cc", new DateTime(2010, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "LamDung_Vuong@hotmail.com", "Lệ Quân Trần", 3, "LAMDUNG_VUONG@HOTMAIL.COM", "LAMDUNG_VUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPwEqHx+aGDjuXL04G2trARUyVb9jDZY1M/D3jyXTC6e21+/xFom+FZW1PKMBanyRQ==", "0200 7375 4052", "42e162a9-2771-4033-840b-ef19027a9b0d", "LamDung_Vuong@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "02587 Trang Tâm Loaf", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%C3%B9y%20Dung%20Phan", "e0d5e1af-596f-4e4c-91dd-8ab6bcabfdb5", new DateTime(2009, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "MyKieu_Tran@gmail.com", "Thùy Dung Phan", 1, "MYKIEU_TRAN@GMAIL.COM", "MYKIEU_TRAN@GMAIL.COM", "AQAAAAIAAYagAAAAEFsPTBwbqZz1vxhfbJGiTcwP628pNEkJEI8ncyZNh+Dnz/KALuYHPJ3VkzxH8sQQ8g==", "0269 7757 2901", "1f79a23c-332c-4e3b-850f-d3a5f014bb77", "MyKieu_Tran@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "00660 Diệu Ngà Drives", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Vi%E1%BB%87t%20C%C6%B0%E1%BB%9Dng%20%C4%90inh", "f64e4b19-4f3b-4769-bd58-d3a32396e3f6", new DateTime(1996, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), "KimCuong.Tran59@hotmail.com", "Việt Cường Đinh", 2, "KIMCUONG.TRAN59@HOTMAIL.COM", "KIMCUONG.TRAN59@HOTMAIL.COM", "AQAAAAIAAYagAAAAEINGsmbOfKP00ChhPtfaHOn4oQWrHNNfz6DfkEC9xtaCopxWhQgy4kELGnG3PiFRpg==", "025 5783 9352", "e9d529af-fc72-4442-ae9f-7a3cba43653c", "KimCuong.Tran59@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0057 Dương Summit", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nh%E1%BA%ADt%20Mai%20%C4%90o%C3%A0n", "70e525d9-d198-46d6-adc6-1925e7ba06da", new DateTime(2004, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "TheLuc90@hotmail.com", "Nhật Mai Đoàn", 3, "THELUC90@HOTMAIL.COM", "THELUC90@HOTMAIL.COM", "AQAAAAIAAYagAAAAEOJILEkAJYyz0BryDI8y4icKmEYklxMDvlxynZ3vOnnBKaUzqMwxcoMCiF84YhhkiA==", "023 2883 3788", "66e70e03-2399-4d64-a27d-8b7497468d3b", "TheLuc90@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "17665 Quốc Trụ Heights", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=An%20Khang%20%C4%90%C3%A0o", "04e3e9be-c1b0-4610-a2f4-f672bcd5e961", new DateTime(2012, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "LeThuy.Ngo@yahoo.com", "An Khang Đào", 3, "LETHUY.NGO@YAHOO.COM", "LETHUY.NGO@YAHOO.COM", "AQAAAAIAAYagAAAAEHQJcn5ty94lW/9LfVMpq5CJidcoWT5NnBmCe/T146pKWRNVZBh8EG1jtOJSwqCyNA==", "029 0295 7294", "b659292f-5fcc-4987-9f00-24b2aa66bea1", "LeThuy.Ngo@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "01284 Bá Thịnh Estates", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C3%81nh%20Nguy%E1%BB%87t%20T%C3%B4", "989ad431-6cfc-4a22-9e10-713015f45b0e", new DateTime(1995, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "NguyenSu_Bui@hotmail.com", "Ánh Nguyệt Tô", "NGUYENSU_BUI@HOTMAIL.COM", "NGUYENSU_BUI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEH0iDIAxInTjnTGbGDpaQpVt9i3lPlLVdrcr0hc5gZ7wHo0jqPXC7Fe+x9fDAOMvHw==", "021 0100 5900", "7854da05-691c-4da0-aed0-89da24a041f3", "NguyenSu_Bui@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "06220 Nguyễn Neck", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%ADch%20Nh%C3%A3%20%C4%90%E1%BB%97", "1c9dfbfa-19fc-4eb4-bd06-961ebcebb466", new DateTime(2009, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), "HaiYen.Vuong@hotmail.com", "Bích Nhã Đỗ", 1, "HAIYEN.VUONG@HOTMAIL.COM", "HAIYEN.VUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMuetvpMG7VX+zuRyYWLn/WNiLLjuHgxHr/+G7P0noCRgh5ySDirztnRVrlT28cGcg==", "0263 6204 8358", "a18af42f-2e6c-4ffd-a1f0-49c6e9317cac", "HaiYen.Vuong@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6095 Phùng Landing", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Hoa%20Tranh%20D%C6%B0%C6%A1ng", "d8e4a4a3-989f-4a2d-863b-b738fa587fdb", new DateTime(2004, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "DongPhuong_Dinh62@hotmail.com", "Hoa Tranh Dương", "DONGPHUONG_DINH62@HOTMAIL.COM", "DONGPHUONG_DINH62@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEWjNPOYZDuTkSDB1Sdp+0wyCYETelPa/K2YuTZeaxt2La2czrHrndDZ/aXm9CgqIA==", "0255 6190 5267", "ecda134f-2192-45bf-8008-fa8263fb110c", "DongPhuong_Dinh62@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "763 Khắc Minh Lodge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C3%90%C3%ACnh%20Thi%E1%BB%87n%20Mai", "4044771a-29aa-4208-9435-f4a46877e238", new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "VietCuong.Phung3@gmail.com", "Ðình Thiện Mai", "VIETCUONG.PHUNG3@GMAIL.COM", "VIETCUONG.PHUNG3@GMAIL.COM", "AQAAAAIAAYagAAAAEIwU/KsT8o/UnNVc5CE5dERSpE22Eof7npcLYv2d2xjCQtJxl89Ot0NCOitcqJQ/zw==", "0209 9863 5340", "091fe986-8686-4f9b-95cc-9382bb50e5ef", "VietCuong.Phung3@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "54297 Tô Spur", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%E1%BB%9Dng%20Hi%E1%BB%87p%20T%C3%B4", "ce8a369d-5789-4b88-9982-e44eb20c33e2", new DateTime(2015, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "ThuyKieu.Truong@yahoo.com", "Trường Hiệp Tô", "THUYKIEU.TRUONG@YAHOO.COM", "THUYKIEU.TRUONG@YAHOO.COM", "AQAAAAIAAYagAAAAEHjW2PwILmmh7gymrLdVCfiaY3dfyu+BVE6/ivAErqr8DaytgQfM3msRpkIHvnl5uw==", "029 3048 4935", "d6acb039-9cb5-465e-9c6b-9bb85d307a0b", "ThuyKieu.Truong@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "33127 Phan Club", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=C%C3%B4ng%20L%C3%BD%20V%C5%A9", "1e0b03fa-6ec1-4df8-8792-4f3b151e1af1", new DateTime(2006, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "NamPhuong4@gmail.com", "Công Lý Vũ", 3, "NAMPHUONG4@GMAIL.COM", "NAMPHUONG4@GMAIL.COM", "AQAAAAIAAYagAAAAEJjM+4Ld06/jr034t4P1V05i4Q3h8s/gO5ppTYsj62hnr7pJYtZeOq7eqxpiZE+zKA==", "023 3357 9356", "2dd09467-4a7e-4eda-9c21-4f066b9866e4", "NamPhuong4@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0966 Hải Uyên Causeway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%E1%BB%9Dng%20Hi%E1%BB%87p%20T%C3%B4", "c457e402-8c6f-4f6b-9b80-0b414fe7f846", new DateTime(1995, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "QuocHien_Ly8@gmail.com", "Trường Hiệp Tô", "QUOCHIEN_LY8@GMAIL.COM", "QUOCHIEN_LY8@GMAIL.COM", "AQAAAAIAAYagAAAAEHOqQx9Yr26ma1bhKswe+qQilGm3Qdt9VnCnAFWFG22ZHUF1Loaib2fSv8GUF7MvIA==", "0202 2672 5742", "58b681f6-78b3-40d7-84ff-9750fa9cff96", "QuocHien_Ly8@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "84859 Trúc Quỳnh Crossing", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tuy%E1%BA%BFt%20Tr%E1%BA%A7m%20L%C3%AA", "4834e7a2-17fc-41c1-92f7-6720904e2734", new DateTime(2000, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "HanhTuong.Lam@hotmail.com", "Tuyết Trầm Lê", 2, "HANHTUONG.LAM@HOTMAIL.COM", "HANHTUONG.LAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPV0JREJrW14QAR2+CGKih8k9AnNhT72U6TIhI7+Rc0CQEXxgSUpMtyFe67k60GQCQ==", "026 2090 9393", "ba86920c-8601-4f36-b8b4-005331b48031", "HanhTuong.Lam@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3546 Phạm Port", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Quang%20T%C3%BA%20%C4%90%E1%BB%97", "8edd3937-c8e7-408d-acdc-eb18473fea1a", new DateTime(2016, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "YenThanh_Doan30@gmail.com", "Quang Tú Đỗ", 1, "YENTHANH_DOAN30@GMAIL.COM", "YENTHANH_DOAN30@GMAIL.COM", "AQAAAAIAAYagAAAAEOTw7DME7bfdNvGg10rAdXr2y65933k4GiIOQgYdPJjWBX79GfzVSosAHcn7pjv2qg==", "029 8109 1004", "b97510ab-9505-4796-a514-b5614b08a8a2", "YenThanh_Doan30@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9878 Mai Place", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%E1%BA%A3o%20Ng%E1%BB%8Dc%20Tr%C6%B0%C6%A1ng", "6c3ec578-3696-453a-a4bd-ec439bc75db1", new DateTime(1998, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "PhuongYen_Bui@yahoo.com", "Bảo Ngọc Trương", "PHUONGYEN_BUI@YAHOO.COM", "PHUONGYEN_BUI@YAHOO.COM", "AQAAAAIAAYagAAAAEHHI9VO2FbCvT1CSEHHn+bYTOR8fM1ZzdlN8IxdZKJDSDDoeDA1DCU8T46sLZOeE/A==", "0268 1627 8136", "b6f43c10-e1e9-4667-aeeb-2332f87faa17", "PhuongYen_Bui@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "17262 Đặng Springs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C6%B0%E1%BB%9Dng%20Nguy%C3%AAn%20D%C6%B0%C6%A1ng", "a4113b80-11b9-47c7-aad1-37ae22038b5b", new DateTime(2010, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "TuanSy_Nguyen38@yahoo.com", "Tường Nguyên Dương", 1, "TUANSY_NGUYEN38@YAHOO.COM", "TUANSY_NGUYEN38@YAHOO.COM", "AQAAAAIAAYagAAAAEKRGqXOOyfFB04sWkTW3vXQ+a2pHGWKDuXt1jHDjNOw1vPJMUsSym+81e6Bl6HU2ig==", "025 9142 7593", "13c4b448-3a8a-4a79-8ce5-562ad97137fb", "TuanSy_Nguyen38@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6041 Ngô Plaza", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Giang%20Thanh%20Tr%E1%BB%8Bnh", "37f13d17-c018-414f-9fa5-b6fe047c2647", new DateTime(2002, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "ThatCuong_Hoang@yahoo.com", "Giang Thanh Trịnh", 3, "THATCUONG_HOANG@YAHOO.COM", "THATCUONG_HOANG@YAHOO.COM", "AQAAAAIAAYagAAAAEEQuMBPHrPGylJYEsKZUtj+zNbSKIMY6ZC/4J+W4at8CPQOpm7n5y9s4vPo50XJLfg==", "029 7085 8905", "434fb55d-05d0-465c-83e1-f7a668dda567", "ThatCuong_Hoang@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "06724 Hồ Rest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Duy%C3%AAn%20N%C6%B0%C6%A1ng%20V%C6%B0%C6%A1ng", "ceae58c1-bd00-4879-9f91-14e287d75bad", new DateTime(2000, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), "DinhLuan_To2@hotmail.com", "Duyên Nương Vương", "DINHLUAN_TO2@HOTMAIL.COM", "DINHLUAN_TO2@HOTMAIL.COM", "AQAAAAIAAYagAAAAEF/s2PDJklZr7kLjYFps+mgpyW9ux2qM2QdXNz9COIxbF1vFDt08i819WGFzwPHTnw==", "0262 1259 4359", "797bd511-613b-49fb-aa33-e299dceac26f", "DinhLuan_To2@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "62606 Vũ Brooks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Loan%20Ch%C3%A2u%20T%C4%83ng", "b9b85818-9581-4f80-947b-cc587f7cc76a", new DateTime(2016, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "MinhVy.Ly@gmail.com", "Loan Châu Tăng", 1, "MINHVY.LY@GMAIL.COM", "MINHVY.LY@GMAIL.COM", "AQAAAAIAAYagAAAAEKequIumZnoyK4Um3d9++bdlbAo6Oq2iTwy/PoQlyysyVCOveXPAgN/16tKJRIDRGA==", "020 6217 0416", "39d7f45f-2f0a-47b2-9460-6d04e5d391aa", "MinhVy.Ly@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "66300 Quang Thuận Harbors", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C6%B0%C6%A1ng%20Trinh%20Ng%C3%B4", "eb5565cd-faa4-48d8-a900-a791d1afc58e", new DateTime(2006, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "SongKe62@yahoo.com", "Phương Trinh Ngô", 3, "SONGKE62@YAHOO.COM", "SONGKE62@YAHOO.COM", "AQAAAAIAAYagAAAAEHaiPlnidKp5ONLTcE0Vq+k+3xI+fxi0bXxVtJi5WCnEaEVvbvAucfbVDGR/77w5oQ==", "0213 9729 9431", "89753f23-8421-49a8-bc02-c7337daf7116", "SongKe62@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2735 Vũ Mill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%ADch%20Tr%C3%A2m%20V%C6%B0%C6%A1ng", "86b7370d-ce5b-476d-a04d-fbbbd3d5dd61", new DateTime(2016, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "DongDuong_Dao6@hotmail.com", "Bích Trâm Vương", 1, "DONGDUONG_DAO6@HOTMAIL.COM", "DONGDUONG_DAO6@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBcRKIR4U7JPyUsFBovkkxK/gIId5ReT5Rdckz7290dHKXVOd2bVwohVFcyw81lv3A==", "0271 2196 8909", "e7b0c7db-7afc-461f-9e64-a09a21b558bd", "DongDuong_Dao6@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "39522 Trịnh Underpass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Di%E1%BB%85m%20Quy%C3%AAn%20D%C6%B0%C6%A1ng", "3c2d7b8c-7b85-4505-b010-224bdaf7658d", new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "NguyenGiap_Vu99@yahoo.com", "Diễm Quyên Dương", "NGUYENGIAP_VU99@YAHOO.COM", "NGUYENGIAP_VU99@YAHOO.COM", "AQAAAAIAAYagAAAAEG7jc45rOGi8QrM8FuTqSPbfogpL20KHIWlxfpCQnYLVs3G16L3nYjQ+Smmgo1vYWw==", "0297 8876 3706", "694ad6a0-7f9d-483d-aed8-356dbd266bfd", "NguyenGiap_Vu99@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6688 Mạnh Thiện Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C3%AD%20Minh%20Tr%E1%BB%8Bnh", "e191b558-9e80-47bd-9fe7-b8e370b18ee2", new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "ThuyDiem_Phan@yahoo.com", "Trí Minh Trịnh", 1, "THUYDIEM_PHAN@YAHOO.COM", "THUYDIEM_PHAN@YAHOO.COM", "AQAAAAIAAYagAAAAENwT2kdWvyl90eBtMfqB5LczOpCEmdF7iF5E33SYIRqwaZ2gSzctUd7K0jW0qqe0FQ==", "020 2438 6767", "20f2f80b-1837-4b35-a07d-313984bfbf04", "ThuyDiem_Phan@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "98695 Trương Garden", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90an%20Thu%20Tr%C6%B0%C6%A1ng", "e164e440-de63-428f-bd43-92164be3bbdd", new DateTime(2010, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "HaiUyen.Pham@hotmail.com", "Đan Thu Trương", 1, "HAIUYEN.PHAM@HOTMAIL.COM", "HAIUYEN.PHAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEP2c0MkI5IaVX+JTNdlXUzEuHqs2W5TL/yc3zoIgfkcOZD2bB7WgPQ6Xo8K7zPvXFw==", "023 6513 7900", "8580d0b6-e840-480d-a700-7f024ad76784", "HaiUyen.Pham@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "50577 Trần Corner", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Cao%20Minh%20V%C6%B0%C6%A1ng", "525ad8aa-264a-4812-a79e-113872430612", new DateTime(2006, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "NguyetQue19@yahoo.com", "Cao Minh Vương", 1, "NGUYETQUE19@YAHOO.COM", "NGUYETQUE19@YAHOO.COM", "AQAAAAIAAYagAAAAEN4KEd0yGk5Q3R1RtHeauUoObayqGgxsRGdeZxG6vf0mL5x8W3P1oWllBUcxhI4sUQ==", "0298 2150 6036", "fdd2f0c6-8f50-4e51-8a14-3a852221331d", "NguyetQue19@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "85719 Phùng Shores", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0n%20Ki%E1%BA%BFm%20%C4%90o%C3%A0n", "f5642e9c-7a13-4c59-9d76-326bf00a4ddd", new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "VienPhuong60@gmail.com", "Hoàn Kiếm Đoàn", 3, "VIENPHUONG60@GMAIL.COM", "VIENPHUONG60@GMAIL.COM", "AQAAAAIAAYagAAAAEAd+Pt6Xv3Plv/mYtfBEVeJPqBeck1WTjD/nFFxkqKah3efFg3iFpVkl3FaFGQGKDQ==", "0223 6286 8479", "77308216-dead-4649-b9f5-2d03af0ada17", "VienPhuong60@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "43619 Đỗ Canyon", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C3%90inh%20H%C6%B0%C6%A1ng%20Ng%C3%B4", "02d02bf3-30d9-464b-8650-e8e85288927d", new DateTime(1998, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), "PhuongLien_Le40@gmail.com", "Ðinh Hương Ngô", 2, "PHUONGLIEN_LE40@GMAIL.COM", "PHUONGLIEN_LE40@GMAIL.COM", "AQAAAAIAAYagAAAAEFjN8jc/PD/Hry2TdTeE1+568hHnDAifukpC1vY8iJh4iBeSj4SSgothrQRu8/qPUA==", "0220 6663 3514", "d0ca865b-b39f-4e94-a18f-df9773ae3c27", "PhuongLien_Le40@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "09010 Đan Linh Mountain", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Hoa%20Tranh%20L%C3%BD", "73bfcfdb-ccf4-4c9e-a897-2b3a126b55ff", new DateTime(2003, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "LeBang_Mai@hotmail.com", "Hoa Tranh Lý", 3, "LEBANG_MAI@HOTMAIL.COM", "LEBANG_MAI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHarZgl7pUMThX93ug2Suuix6wtxG5ylC3d9Nl//xrJVw536Bd8yTo5MBvPz/vNuQw==", "026 1717 6488", "83318fbc-35d2-41dd-93bf-d7eca76a0f99", "LeBang_Mai@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8538 Trung Ðức Way", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Kh%C3%A1nh%20Nam%20T%C4%83ng", "91d76419-276a-4282-a9b6-97755f2491a7", new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "MinhDan_Pham41@hotmail.com", "Khánh Nam Tăng", 2, "MINHDAN_PHAM41@HOTMAIL.COM", "MINHDAN_PHAM41@HOTMAIL.COM", "AQAAAAIAAYagAAAAEF/MyhOSeNWAzGdmftuTd8gjr2UXTg0UKD7et6QDYVHEtMG4A+bSztFeN6ZLrAa6Mg==", "0252 8121 4181", "4672306e-470f-4709-ae5f-d25575640eaa", "MinhDan_Pham41@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6074 Thiện Minh Drive", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=C%C3%B4ng%20Lu%E1%BA%ADn%20Tr%C6%B0%C6%A1ng", "609251fc-abb7-426c-b1cb-331ce969f2f4", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "UyenPhuong.Tran@hotmail.com", "Công Luận Trương", 3, "UYENPHUONG.TRAN@HOTMAIL.COM", "UYENPHUONG.TRAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPCmFbka7recrXY2JAmiHPlKh4itVRC+U5dSU8cE4edjIP8aLhAX8CZjYTnES2kYaQ==", "022 5817 0820", "67189a0f-616d-4497-b717-ce0a501c3f76", "UyenPhuong.Tran@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "183 Thu Oanh Loop", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Kim%20Th%C6%B0%20T%C3%B4", "7e22d4cc-0145-48ff-a78a-51d91d65df30", new DateTime(2000, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "TruongAn_Phung@hotmail.com", "Kim Thư Tô", 2, "TRUONGAN_PHUNG@HOTMAIL.COM", "TRUONGAN_PHUNG@HOTMAIL.COM", "AQAAAAIAAYagAAAAENR3MyYdpoCAamGpjHEUA63u83CQ1FEfY597eiTBUUcERsd+F2thSi5mCVHq7rg8FA==", "0252 7630 8372", "f57a79c4-cef9-4e72-abe4-6cdaf2a075dc", "TruongAn_Phung@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "86084 Đỗ Brook", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Hi%E1%BB%81n%20Chung%20Tr%C6%B0%C6%A1ng", "0fa80425-3acc-43cb-91ac-b5711ffe564f", new DateTime(2014, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), "TanTrinh5@gmail.com", "Hiền Chung Trương", 2, "TANTRINH5@GMAIL.COM", "TANTRINH5@GMAIL.COM", "AQAAAAIAAYagAAAAEHSmwbFOSDkyoDdVfZNbVWCJ3qwxZE1Jl3guCvW3/kR0v0zIWH9SNvAsdAlBkGquQw==", "024 5051 4999", "d38097b2-f084-4924-a55d-59104b8d43bd", "TanTrinh5@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8735 Ngô Parkway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C6%B0%C6%A1ng%20Linh%20H%C3%A0", "e3efa44c-dbaa-4164-960a-8ec1796cf9b1", new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "ThienLam_Lam89@yahoo.com", "Phương Linh Hà", 2, "THIENLAM_LAM89@YAHOO.COM", "THIENLAM_LAM89@YAHOO.COM", "AQAAAAIAAYagAAAAEJ+MUMIzsARhWzxMj04NzU2lY+3IRNkHY7AawB1kEj1vKJbmnE4fMHHtwNzpbwwi+w==", "027 0072 1123", "6f55d800-a1d3-4a93-901c-7bb1488d9883", "ThienLam_Lam89@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3136 Đỗ Corners", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C3%BAc%20Vy%20H%C3%A0", "7a2efe00-dde4-49ea-b96c-aa62ad8f3e1d", new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "TuanLinh31@yahoo.com", "Trúc Vy Hà", 1, "TUANLINH31@YAHOO.COM", "TUANLINH31@YAHOO.COM", "AQAAAAIAAYagAAAAEJoZcfN+igtFeF9zXQ/YCDMeTNfmZpk0w5GTUAhOull9xLR7Oalr58uujyV2bDE7kQ==", "0232 2373 5211", "89f81096-f012-4fee-a176-a7c656cc7941", "TuanLinh31@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "104 Nguyễn Brook", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%E1%BA%A3o%20H%C3%A2n%20Tr%E1%BA%A7n", "245ec13d-1adc-4997-aa78-0f6e47a0e283", new DateTime(1995, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "KhacThanh_Trinh@yahoo.com", "Bảo Hân Trần", 3, "KHACTHANH_TRINH@YAHOO.COM", "KHACTHANH_TRINH@YAHOO.COM", "AQAAAAIAAYagAAAAELiApixpuhqCz0+Qjce3ZzwMxSqwi3hd9oiP9Z3toLffZM3YW3Zss/CJtydl8Mcp0A==", "0213 2572 2842", "57fb25be-42e2-49ca-9dec-18271001aefb", "KhacThanh_Trinh@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "34116 Lệ Băng Village", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C3%A3%20Th%E1%BA%A3o%20H%C3%A0", "9d8af353-9196-4d31-92b0-cd7eb38a3238", new DateTime(2012, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "KhacTrong.Bui@hotmail.com", "Dã Thảo Hà", 3, "KHACTRONG.BUI@HOTMAIL.COM", "KHACTRONG.BUI@HOTMAIL.COM", "AQAAAAIAAYagAAAAELMMxUPctHcF0PwUAx0Z+4JGrPyV+jLd/D+/EnmpHg/qbOPH0a303fmZqowwyRd3xw==", "0296 7610 6067", "979ca585-efd8-46a1-afdb-30cc074a8898", "KhacTrong.Bui@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "287 Ngọc Hạ Hills", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Nam%20Tr%E1%BB%8Bnh", "3afabaab-df3b-4e23-998f-b82b5fd2e58e", new DateTime(2002, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "TuyAnh_Ho@gmail.com", "Hoàng Nam Trịnh", 2, "TUYANH_HO@GMAIL.COM", "TUYANH_HO@GMAIL.COM", "AQAAAAIAAYagAAAAEKYl56dpbC6cRj3l7gk6pCDTgruKU81p5J6ASBo43dElWWQJNWfwhPomTR9/x8RFOw==", "0276 1893 1430", "b4a72070-6169-40da-9fa8-723c71b1d50e", "TuyAnh_Ho@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "707 Hữu Nghĩa Points", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20H%E1%BA%A3i%20An%20T%C3%B4", "64023e21-2f27-44e6-ae0d-48bcff409b2d", new DateTime(2015, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "XuanDung.Trinh@hotmail.com", "Nguyễn Hải An Tô", 1, "XUANDUNG.TRINH@HOTMAIL.COM", "XUANDUNG.TRINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPrE+sdsXz4hBo3Mko4IW+BRuGmWyvmmyr5HW+qjSIvui0TrXDX8T2zdXudSVEbt6g==", "023 9825 1785", "d6df9b06-29f8-4f80-86c9-09a02736efda", "XuanDung.Trinh@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5993 Ðông Quân Cliffs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tu%E1%BA%A5n%20S%E1%BB%B9%20L%C3%AA", "a9ed9f6b-31f6-48e8-8bdb-5de720d21612", new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "DucPhi61@gmail.com", "Tuấn Sỹ Lê", "DUCPHI61@GMAIL.COM", "DUCPHI61@GMAIL.COM", "AQAAAAIAAYagAAAAEK23A3+PbWowvhbe7XZE16zl8UkN2y0aqDvQ7TtDSi4v+pcvR9bVqzdubvkjnU3HAg==", "0229 2828 6894", "bd117d55-9c7e-49d8-b473-34d47de38edb", "DucPhi61@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "683 An Tường Drives", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Lan%20Khu%C3%AA%20L%C3%AA", "c7963ed1-652c-446d-8b73-68584fa26df2", new DateTime(2006, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "KimThong.Dao5@hotmail.com", "Lan Khuê Lê", "KIMTHONG.DAO5@HOTMAIL.COM", "KIMTHONG.DAO5@HOTMAIL.COM", "AQAAAAIAAYagAAAAEOl+8GrgI5Z6w+G7AFDPNWZWPTgKdk45cMxDSSVTCky3i3n2fbcv2olKNaZftNA8VA==", "027 4269 7818", "3fde0f6b-d113-4c44-94d6-72c01652e975", "KimThong.Dao5@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "90091 Đinh Lake", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BA%A3o%20Nhi%20H%E1%BB%93", "0c5b3e99-7b38-4570-9d8b-335c99f0f2d4", new DateTime(2016, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "DanhVan.Dinh85@gmail.com", "Hảo Nhi Hồ", "DANHVAN.DINH85@GMAIL.COM", "DANHVAN.DINH85@GMAIL.COM", "AQAAAAIAAYagAAAAEEDvjOTzdze1/JdV6d8hYl7iCz68JSWj/shjsaUGEA6h/cFvOGXfz3Gvzqh6D4hMcw==", "027 8822 6651", "e13ee37a-7d06-47c9-8248-e3c08a26f692", "DanhVan.Dinh85@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3661 Mai Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Minh%20Ho%C3%A0ng%20Ng%C3%B4", "adf49ba8-59a1-4550-a1e5-c7f33b33996c", new DateTime(2000, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "PhucLe.Tran@hotmail.com", "Minh Hoàng Ngô", "PHUCLE.TRAN@HOTMAIL.COM", "PHUCLE.TRAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHQJFEMfNQqQEP2YZ9orMnyrUlKE8o4gHOJgIsPbwcSM4M/ktwJ2OMUubM7O6ghqEw==", "0266 2730 8768", "156097bc-4ae8-472f-9c6f-f91514adfce6", "PhucLe.Tran@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3982 Hoài Giang Plains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Y%E1%BA%BFn%20Mai%20Ph%E1%BA%A1m", "90b87d04-6f74-40f1-b6ea-2ce7da37c265", new DateTime(2009, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "TrongKien_Vu@hotmail.com", "Yến Mai Phạm", "TRONGKIEN_VU@HOTMAIL.COM", "TRONGKIEN_VU@HOTMAIL.COM", "AQAAAAIAAYagAAAAELtkSnWoI/BL6s8hvi+Y3TlI2U49TN2bez+ThHQCTZFy5S5C5vzRk8Way6EwF+VWZg==", "0295 2212 0392", "5da0f0e2-1a12-40b2-8086-8303bc8fa172", "TrongKien_Vu@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "25265 Trương Knoll", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BA%A3i%20Th%E1%BA%A3o%20%C4%90%C3%A0o", "70b214a0-ef3a-48f1-ad2e-868323f7dbb1", new DateTime(1995, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "ThuyUyen.To86@hotmail.com", "Hải Thảo Đào", 2, "THUYUYEN.TO86@HOTMAIL.COM", "THUYUYEN.TO86@HOTMAIL.COM", "AQAAAAIAAYagAAAAEB5ilXJ8PnDHkSd72YwYLeo3xki3yOs6lCYt1Nmje7xuqxbzqCnXgwzm2spJzh6Neg==", "028 0493 5714", "82156090-56a7-4585-bbff-0bf125656d80", "ThuyUyen.To86@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "99072 Tăng Lodge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%B2a%20Th%C3%A1i%20B%C3%B9i", "8682bf3c-fa70-4415-8220-8f3a10ab1b05", new DateTime(2014, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "KhanhGiao_Dao@gmail.com", "Hòa Thái Bùi", 2, "KHANHGIAO_DAO@GMAIL.COM", "KHANHGIAO_DAO@GMAIL.COM", "AQAAAAIAAYagAAAAEAIOpV9FbV/kFlM2ZmWfc/k/onO8l5nLxr/9ur3uWnE/fSlsL2ZeLoUCORdgwLqAvQ==", "0260 9605 1838", "2624fcb5-2f5a-4b61-80b2-9a8a7e7627e7", "KhanhGiao_Dao@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "04214 Bùi Landing", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Dng%20H%C3%A0%20%C4%90o%C3%A0n", "19a8843b-d2ba-4036-80e4-6a9cfc092a77", new DateTime(2014, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "ManhTuan39@gmail.com", "Trọng Hà Đoàn", 1, "MANHTUAN39@GMAIL.COM", "MANHTUAN39@GMAIL.COM", "AQAAAAIAAYagAAAAEE40kRknnlALiaAqmG/qoK/r2e11xT8inINd+B9gNYS1/RSXdPSPqxQHc7AGnf9zrQ==", "0228 1408 4158", "ee48789f-5365-4051-acf5-8a0175959ae3", "ManhTuan39@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "640 Cao Thọ Motorway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ki%E1%BA%BFn%20%C3%90%E1%BB%A9c%20%C4%90%C3%A0o", "c6ec5ee4-6af6-48c4-9f74-75297e53124c", new DateTime(2013, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "HuyenTran_Hoang56@hotmail.com", "Kiến Ðức Đào", "HUYENTRAN_HOANG56@HOTMAIL.COM", "HUYENTRAN_HOANG56@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAI/v1yrrAEV197chJj1RafLNdnKYvY+wR2bsqp0LNdrBLKrabpCgxbbRJC0XPvdDw==", "024 5072 1466", "446532ce-3e1a-4703-b11b-0ec64b59dc2e", "HuyenTran_Hoang56@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "080 Phượng Liên Crescent", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=C%C3%A1t%20Ly%20Ng%C3%B4", "05d2c36f-069d-441d-b379-11cf115c03eb", new DateTime(1994, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "HamDuyen.Pham53@gmail.com", "Cát Ly Ngô", 2, "HAMDUYEN.PHAM53@GMAIL.COM", "HAMDUYEN.PHAM53@GMAIL.COM", "AQAAAAIAAYagAAAAEAF3zsjxOtqoXtxdY4jsLJXCQLVRFfXj2SV+/+uKmzedTQdBfwCx/mdMZVSD9KFqQQ==", "0246 0282 4180", "006f0d58-f977-404a-9297-c8d46f0f39c1", "HamDuyen.Pham53@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "54299 Hữu Thiện Lane", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Trung%20Hi%E1%BA%BFu%20V%C5%A9", "f9209652-2f00-4528-99a4-722be022001c", new DateTime(2009, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), "CatTien.Doan@yahoo.com", "Trung Hiếu Vũ", 3, "CATTIEN.DOAN@YAHOO.COM", "CATTIEN.DOAN@YAHOO.COM", "AQAAAAIAAYagAAAAEBq1jIibVlCuoX6iM+nxvKd3Ln4yh3VfgfXTty+4UzqtgXbpUu4GTAQifLec/ZkNFg==", "0213 5524 2682", "d047a38a-e997-4402-b2b2-1d7171cf064d", "CatTien.Doan@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "278 Hữu Trác Cape", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Loan%20Phan", "3fef8ccc-49bc-4b6a-9b3a-c161d14c907b", new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "ThanhHau90@yahoo.com", "Mai Loan Phan", "THANHHAU90@YAHOO.COM", "THANHHAU90@YAHOO.COM", "AQAAAAIAAYagAAAAEJzhvYeOwKvOGs2NpnNB0p1GpYwemgdJKXB3sOTfGLAbhCHJQgQX6pWIowXv1cA29w==", "028 8799 5022", "72f9c869-f8e9-4007-bab8-cc59ec00fb56", "ThanhHau90@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6699 Hà Roads", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%C3%AAn%20Kh%C3%B4i%20L%C3%A2m", "4130ef67-b918-4da3-aff3-20bef090aef2", new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "TuanTrung.Nguyen@gmail.com", "Nguyên Khôi Lâm", 3, "TUANTRUNG.NGUYEN@GMAIL.COM", "TUANTRUNG.NGUYEN@GMAIL.COM", "AQAAAAIAAYagAAAAEEejfGfG0tBfQomIxfiY9mbTb6DklHhmc0/pzk3PF7PhieFoYJ3M4rHL9RgUgTHaxA==", "0286 6679 7481", "5912d199-e41c-4d6d-9130-dea83cf31703", "TuanTrung.Nguyen@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "720 Anh Dũng Mills", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%E1%BA%A1%20H%C6%B0%C6%A1ng%20H%C3%A0", "c8258f2d-a758-49e2-90e4-e5705d0fbce8", new DateTime(2010, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "DiemPhuoc_Nguyen46@yahoo.com", "Dạ Hương Hà", 1, "DIEMPHUOC_NGUYEN46@YAHOO.COM", "DIEMPHUOC_NGUYEN46@YAHOO.COM", "AQAAAAIAAYagAAAAEAjqBrC/PwoCKI2er3oJgmLQOdhWznNwOu8n6OE9bmH0Zqx3VdoeKyW+1Gm7U6ErZg==", "0294 1624 3985", "3fefd346-6b6a-46ae-8dc3-0f0f820b8532", "DiemPhuoc_Nguyen46@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "108 Ngọc Trinh Lake", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Thanh%20%C4%90inh", "07cfe983-d55d-462c-85a5-0b110f5bc3da", new DateTime(2015, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "HungDao93@gmail.com", "Hà Thanh Đinh", 1, "HUNGDAO93@GMAIL.COM", "HUNGDAO93@GMAIL.COM", "AQAAAAIAAYagAAAAEOcGoB4NTgvGyLTbZC8URUUCuAXNdGsZtCH7ebvYYQVSGGrWjohBSg3uboPky6NNdg==", "0257 2545 5892", "7154dc39-212a-429a-9460-abeb51ed4fa3", "HungDao93@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2186 Dương Estates", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C6%B0%C6%A1ng%20Thi%20%C4%90%C3%A0o", "afc9995a-7e1e-4bb6-b5e8-d3c098b720e5", new DateTime(2010, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), "MinhThao_Dinh@yahoo.com", "Phương Thi Đào", "MINHTHAO_DINH@YAHOO.COM", "MINHTHAO_DINH@YAHOO.COM", "AQAAAAIAAYagAAAAEJhO9eez2NkphQ6rqc+lq+o9fskkjriti3GwHQdg7Y+zqPVjVF5O8Gnod0A7mkj6qw==", "0207 2624 2177", "f62c8793-ac3d-45dc-8c63-e275cc247eb1", "MinhThao_Dinh@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "62184 Linh Duyên Camp", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Th%E1%BA%BF%20N%C4%83ng%20B%C3%B9i", "a12f16de-122f-4047-8646-6fa3d77570ea", new DateTime(2009, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "HoaThien_Ha@yahoo.com", "Thế Năng Bùi", "HOATHIEN_HA@YAHOO.COM", "HOATHIEN_HA@YAHOO.COM", "AQAAAAIAAYagAAAAEAOCupzqYmVbF12ICKRWGOnKq0rf4LC8KOAggqMxPyJCcWJFRMenss33ryOvrGL9FQ==", "0247 9866 8628", "63c7e84f-1506-41a2-b889-25e8c6060f01", "HoaThien_Ha@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "59931 Dương Village", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C3%A2n%20Trang%20Mai", "44557ce1-c6d6-4ff3-bd37-3f861a5d8516", new DateTime(2013, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "XuanHuy.Trinh@hotmail.com", "Vân Trang Mai", "XUANHUY.TRINH@HOTMAIL.COM", "XUANHUY.TRINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAEI9kfosY5yUStSgb0aE9/v20MoipB10xD01CuRNz1N2S7C4C/BSYwR0EPe3TAkB5bw==", "0217 0327 1560", "c6d28933-af0c-44ea-b847-6678c4604184", "XuanHuy.Trinh@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4142 Hoàng Khang Parkway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=S%E1%BB%B9%20Ho%C3%A0ng%20Tr%C6%B0%C6%A1ng", "52fb9e9b-e8b7-443b-8148-e1aececd712f", new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), "ChePhuong48@gmail.com", "Sỹ Hoàng Trương", "CHEPHUONG48@GMAIL.COM", "CHEPHUONG48@GMAIL.COM", "AQAAAAIAAYagAAAAEGELXYU9AMBUCKfqdWRqaRySTbE5FKP9MyzIRMtGo9l+czf6b8U/3LMBADfFIrVssg==", "020 5990 4132", "9399cf2d-5c40-4a64-9486-338724893a88", "ChePhuong48@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "67203 Thiện Ân Cliff", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Song%20Th%C6%B0%20%C4%90o%C3%A0n", "6ae8b170-0a51-41ad-aff0-ed33fce21871", new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "LeQuyen.Phung47@yahoo.com", "Song Thư Đoàn", "LEQUYEN.PHUNG47@YAHOO.COM", "LEQUYEN.PHUNG47@YAHOO.COM", "AQAAAAIAAYagAAAAEBxiWCRsIMY/a0H8CrpL29ZnTUCDxXes8+ooDyMwxsosOUY+CbR4jO+aRY5U2OAXqw==", "0231 9242 9367", "eb50e797-6b52-415a-aded-c5509b897984", "LeQuyen.Phung47@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "57208 Bích Vân Path", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%A2n%20Tr%C3%BAc%20%C4%90%C3%A0o", "7515dd07-6274-4638-9cb9-60e7350063be", new DateTime(2004, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "KimOanh_Tran@gmail.com", "Ngân Trúc Đào", 3, "KIMOANH_TRAN@GMAIL.COM", "KIMOANH_TRAN@GMAIL.COM", "AQAAAAIAAYagAAAAEFiP3ESAXLEunJWbRZ4Bu4fnYacYsVMAM4YvapfwYZLW3zRhP5uz/QbKp5Iqq/3bUQ==", "026 4384 1817", "d0e4cbb7-773a-4551-9d63-277137d13eb8", "KimOanh_Tran@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "796 Huy Khiêm Overpass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B9ng%20L%C3%A2m%20%C4%90%C3%A0o", "ce30a3cf-e256-4153-a9a6-b302974d5bd4", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "DieuThuy_Ly82@yahoo.com", "Tùng Lâm Đào", 3, "DIEUTHUY_LY82@YAHOO.COM", "DIEUTHUY_LY82@YAHOO.COM", "AQAAAAIAAYagAAAAEBUGYVIVv6tlX6KiytEzuiezVENqISFXgJMuMkB9z9yCeV/mdt5w/60QFW2AdEDWkw==", "0297 9516 1637", "c5599d76-713b-49c2-b87e-210b5c308239", "DieuThuy_Ly82@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "76386 Trung Nhân Prairie", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nh%C3%A3%20Y%E1%BA%BFn%20H%E1%BB%93", "76f29377-0d19-444a-b2a8-a3f5697d5552", new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "YBinh22@gmail.com", "Nhã Yến Hồ", 1, "YBINH22@GMAIL.COM", "YBINH22@GMAIL.COM", "AQAAAAIAAYagAAAAELU5k6jfy9hSTWU6NvY9spXPw3z3cVg0G7GmFoVxrx3AnaeShvSd4hF1hMchSdqtDA==", "0264 4539 1824", "eb9009a4-3fe6-46f8-a8db-cc168af99fdf", "YBinh22@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3557 Tùng Lâm Circle", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C3%90%C3%ACnh%20Thi%E1%BB%87n%20T%C3%B4", "7f1a43cc-5423-4487-83bc-1cbe613d13d7", new DateTime(2005, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "GiaBach36@hotmail.com", "Ðình Thiện Tô", 1, "GIABACH36@HOTMAIL.COM", "GIABACH36@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMXHaYPNpb151w6hWUVARVczfrxsfnLfhsoYTGWWOPyzD5UTKLLKWnKKnT6MRW1f8w==", "0245 7519 7740", "aba06250-1eb6-4057-bf12-793c645a6fb3", "GiaBach36@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "22322 Nhã Trúc Flats", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Trung%20Ki%C3%AAn%20T%C4%83ng", "e93e8489-a27b-4b82-b76e-f4df0f70e85a", new DateTime(1998, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "QuangTuan.Lam13@hotmail.com", "Trung Kiên Tăng", "QUANGTUAN.LAM13@HOTMAIL.COM", "QUANGTUAN.LAM13@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKYzwxogOu4uEeh9rcmG+Qzo3U8Zrf5Ys1If1ZPuH1jFOqje5dBWXaYfsBnZqqHONw==", "023 5663 1180", "cfa91883-d411-4791-8519-75f047da8278", "QuangTuan.Lam13@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "36779 Phùng Camp", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tuy%E1%BA%BFt%20Vy%20%C4%90%C3%A0o", "390f1fcd-7e1e-4cb8-9271-9904d033c529", new DateTime(2006, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), "HoaBinh23@hotmail.com", "Tuyết Vy Đào", 1, "HOABINH23@HOTMAIL.COM", "HOABINH23@HOTMAIL.COM", "AQAAAAIAAYagAAAAEB+Jyo8Tw9mH8Cf5b/ScnE54Y5MPj/ZkFr27u1vykvz+VvOQLl8Z3mG2Au/1nLPuXw==", "021 5801 6125", "5993f004-5ac8-4b84-84f4-02082770c2fb", "HoaBinh23@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "059 Bình Yên Station", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%E1%BA%A3o%20Ch%E1%BA%A5n%20L%C3%A2m", "36a766a2-8f47-4eb3-88c0-c9bccae1a840", new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "QuanDuong.Bui@yahoo.com", "Bảo Chấn Lâm", "QUANDUONG.BUI@YAHOO.COM", "QUANDUONG.BUI@YAHOO.COM", "AQAAAAIAAYagAAAAEE5IhMmJhnoGa544FxY/0G7cSewXqqU4FMgY+KneNfjChYFu6T7OZ5e7zM999EbduQ==", "025 4762 9142", "33b35c16-6cb6-4871-b58c-798cd422e17a", "QuanDuong.Bui@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "707 Đinh Park", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Kim%20Xu%C3%A2n%20V%C5%A9", "2fc866ad-ca58-45ab-8a40-33bd98c2034a", new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "HuuLong_Le@hotmail.com", "Kim Xuân Vũ", 2, "HUULONG_LE@HOTMAIL.COM", "HUULONG_LE@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAu4pqs3jAoMoETPo5otp8n9vVOAJR1hjly+0XDQCIBkuCzJWMjHof2OuhHiqDyQ+A==", "023 6066 8034", "521588b3-0803-44fb-918f-4dae84ed43b5", "HuuLong_Le@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5666 Thanh Hậu Islands", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tri%E1%BB%87u%20M%E1%BA%ABn%20Ho%C3%A0ng", "6b473d33-b4aa-4cb9-995d-a5c05ce8dcbc", new DateTime(2008, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), "QuynhHuong62@yahoo.com", "Triệu Mẫn Hoàng", 2, "QUYNHHUONG62@YAHOO.COM", "QUYNHHUONG62@YAHOO.COM", "AQAAAAIAAYagAAAAEAtfF3xs/XWKo7APFDNm8fc9dYEBpKUnoCkXEV2KhdjYN++rRkEEO9avtEZnxIHj/Q==", "025 4657 4726", "c0024703-c560-445b-b046-28c8c06a6946", "QuynhHuong62@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "631 Tiểu Bảo Spring", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%E1%BB%8Dc%20B%C3%ADch%20B%C3%B9i", "66755bea-ca3d-4861-99bf-bce3c970b3d0", new DateTime(2014, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "HoaTranh.Nguyen12@hotmail.com", "Ngọc Bích Bùi", "HOATRANH.NGUYEN12@HOTMAIL.COM", "HOATRANH.NGUYEN12@HOTMAIL.COM", "AQAAAAIAAYagAAAAEC1uYHiPvcjI029LN8wzN5EUGr2R2B9dOQTiIh+ZDfm/HvThU77osBjafRgtZ8nhnQ==", "028 6926 2702", "7a9f5aa8-e7ed-4926-8ae7-85354b94e71c", "HoaTranh.Nguyen12@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2461 Trương Knoll", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Uy%C3%AAn%20Th%C6%A1%20Nguy%E1%BB%85n", "5725211a-7e6e-4c71-bd10-423ddcc764ec", new DateTime(2005, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "HongNhu.Duong5@yahoo.com", "Uyên Thơ Nguyễn", "HONGNHU.DUONG5@YAHOO.COM", "HONGNHU.DUONG5@YAHOO.COM", "AQAAAAIAAYagAAAAEFLCYtS9XDr15aqv5pzo1aHTiabWN72RsDXdSZHadx96EMI8i2JJOhfVX8JfQLVfXA==", "0250 9004 5711", "ef60154a-dace-4d6c-9e23-ffe67c9991fc", "HongNhu.Duong5@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "165 Phan Brook", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%E1%BA%A3o%20Hi%E1%BB%83n%20Mai", "0f32270a-0908-4871-b9c2-2d4acb240048", new DateTime(1996, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "XuanDung_Trinh@yahoo.com", "Bảo Hiển Mai", "XUANDUNG_TRINH@YAHOO.COM", "XUANDUNG_TRINH@YAHOO.COM", "AQAAAAIAAYagAAAAENLK690yN1NCwKtDCzZrBOKqtvv1G4D4ELw28Qei+uZ/LJEBVpl0CvSCmJ3ykb3RPg==", "020 3106 7365", "8c45f2d9-61b7-4cdb-ad01-52b56343c916", "XuanDung_Trinh@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "789 Phạm Station", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Thanh%20Lan%20Tr%C6%B0%C6%A1ng", "0c7e0c04-6709-4671-8cb2-8d7ca6df2f17", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "BichTy.Do@hotmail.com", "Thanh Lan Trương", 1, "BICHTY.DO@HOTMAIL.COM", "BICHTY.DO@HOTMAIL.COM", "AQAAAAIAAYagAAAAENQjKAVlG7qkCxBYjt141I3+J+uqCoSx5Jz/CFRJ8EivZuCU0S4R8jqcl/0ESThjLg==", "0256 3842 1311", "17890cf9-c37b-407e-abad-bab42108fdcc", "BichTy.Do@hotmail.com" });
        }
    }
}
