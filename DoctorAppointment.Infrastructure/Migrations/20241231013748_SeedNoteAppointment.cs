using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorAppointment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedNoteAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 16, 0, 0, 0), "Voluptatum non voluptate sit omnis.", 81, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 17, 0, 0, 0), "Inventore ducimus vel in laboriosam.", 28, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 18, 0, 0, 0), "Voluptatem odit mollitia ipsum ad odit omnis ab.", 58, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), 19, "Consectetur reiciendis in laborum nulla laudantium quo rerum.", 49 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 16, 0, 0, 0), "Sequi perspiciatis id sit reiciendis itaque natus.", 99, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 10, 0, 0, 0), "Beatae reprehenderit quam occaecati eius aut sed accusamus suscipit.", 88, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 17, 0, 0, 0), "Repellat explicabo rerum qui sint voluptatem.", 3, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 14, 0, 0, 0), "Quia eos ex ea quo.", 51, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 18, 0, 0, 0), "Blanditiis dolorem alias non hic et aperiam autem dicta.", 92, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 11, 0, 0, 0), "Voluptatem nostrum aut adipisci aspernatur est doloribus velit.", 46, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 15, 0, 0, 0), "Est ab consequatur repellat quasi possimus unde totam quidem.", 53, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 10, 0, 0, 0), "Voluptatem voluptates et laboriosam et et ut et recusandae.", 27, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 16, 0, 0, 0), "Perspiciatis voluptates et et ab.", 99, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 17, 0, 0, 0), "Veniam est enim velit nisi dicta.", 85, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 16, "Repellendus perferendis voluptatem.", 70, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 17, 0, 0, 0), "Sint accusantium accusantium sint magnam aut deserunt.", 2, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), "Ut asperiores assumenda in et sunt.", 83, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AppointmentDate", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Esse et at.", 88, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 16, 0, 0, 0), "Voluptatem facere veniam vero repellendus.", 41, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 13, 0, 0, 0), "Vitae quaerat ad molestias laboriosam.", 16, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 9, 0, 0, 0), "In omnis in ratione ut optio qui porro optio ut.", 82, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), "Nam tempora eligendi unde ad est.", 71, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 18, 0, 0, 0), "Aut tenetur dolorem aut.", 36, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 0, 0, 0), "Voluptates consequatur fugit et.", 29, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 11, 0, 0, 0), "Esse omnis nostrum.", 8, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 0, 0, 0), "Qui quos quas eveniet et aut voluptates.", 20, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 0, 0, 0), "Ut voluptatem et quia.", 18, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), "Voluptatem dolor ex deserunt.", 73, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), 9, "Non animi ipsa sed maxime voluptatum consequatur sunt.", 70 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 16, 0, 0, 0), "Unde minima tempore voluptatem quia molestiae ut aspernatur sint.", 2, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Vitae perferendis est itaque dolorem fugit.", 1, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 18, "Voluptate ut ut velit rerum sed voluptatem aspernatur temporibus.", 24, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), "Et reiciendis eum placeat voluptas qui.", 46, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Deserunt sed et alias quas occaecati.", 2, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 15, 0, 0, 0), "Repudiandae consectetur sint itaque dolorum officiis qui et.", 85, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 9, 0, 0, 0), "Deserunt officia enim rem maxime quis numquam perferendis expedita.", 74, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 17, 0, 0, 0), "Recusandae dicta repellendus itaque.", 53, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 0, 0, 0), "Totam consectetur in.", 70, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Assumenda voluptatem est adipisci laborum praesentium dolorem.", 56, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 16, 0, 0, 0), "Nostrum aspernatur et voluptatem doloribus reiciendis corporis voluptate.", new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 11, 0, 0, 0), "Voluptas laborum sit voluptatem saepe non quis laudantium.", 99, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 17, 0, 0, 0), "Qui aut nihil ab ea quae impedit facere et sed.", 31, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 17, 0, 0, 0), "Eum sed minus.", 97, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 12, 0, 0, 0), "Eum perferendis possimus.", 1, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), "Omnis quam dicta nihil.", 26, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 15, 0, 0, 0), "Quia velit id quos optio alias alias vero modi.", 85, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 16, 0, 0, 0), "Magnam magni laudantium.", 19, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 14, "Perspiciatis exercitationem ullam consequuntur.", 98, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), "Excepturi eaque voluptatibus quas.", 26, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 14, 0, 0, 0), "Nobis aut veniam soluta.", 98, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { 16, new TimeSpan(0, 12, 0, 0, 0), "Iure officia officiis non modi perspiciatis ut quam voluptatem.", 29, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), "Quia voluptate voluptates modi est nobis ullam beatae consequatur laudantium.", 82, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 15, 0, 0, 0), "Et est animi repellat id fugit reprehenderit nemo.", 17, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), "Praesentium nesciunt eum nostrum modi in aut odit voluptatibus aut.", 100, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 9, 0, 0, 0), "Nisi ut aliquid perferendis voluptates aut est deserunt dolor qui.", 43, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 3, "Voluptatem nesciunt temporibus consequatur officiis dolores et atque.", 86, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 12, 0, 0, 0), "Cupiditate nostrum et ipsum sit laudantium occaecati sit voluptatem temporibus.", 9, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), 8, "Nihil quo quasi voluptatem ullam fugiat eum.", 70, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), "Aperiam aut ad sit eaque maiores enim perferendis iusto.", 95, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 15, 0, 0, 0), "Architecto voluptates aliquid et inventore libero ea nulla eum.", 56, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 13, 0, 0, 0), "Aut consequatur eum explicabo quibusdam voluptatem sunt qui facere.", 30, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 14, 0, 0, 0), "Unde quaerat et qui accusamus.", 96, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 15, 0, 0, 0), "Blanditiis rem nostrum.", 48, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 9, 0, 0, 0), "Repellendus a nihil consequatur quis.", 77, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), "Expedita aperiam veniam dignissimos nemo.", 47, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, "Aut dolorem ab sunt sapiente.", 32, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 0, 0, 0), "Voluptatem alias rerum quia quidem consequatur labore veniam.", 8, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), "Et rem ut consequatur nam.", 80, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 11, 0, 0, 0), "Doloribus qui inventore blanditiis ut.", 57, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 13, 0, 0, 0), "Delectus delectus et minus quam recusandae inventore vitae alias.", 81, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 16, "Aut laborum numquam voluptas ea nemo.", 13, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 9, 0, 0, 0), "Asperiores reprehenderit eum necessitatibus.", 18, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Expedita ea ab laudantium sit vel.", 90, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 12, 0, 0, 0), "Porro id officia qui architecto asperiores iusto.", 3, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), "At et magnam nihil quia inventore repellendus saepe laboriosam.", 64, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Cupiditate in quia laboriosam quia delectus et rerum odio.", 101, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 18, 0, 0, 0), "Aut quia magnam numquam accusamus et quo.", 83, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 16, 0, 0, 0), "Et quasi sit accusantium libero sed qui tempora qui tenetur.", 59, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), 11, "Commodi odio aut quaerat alias.", 30, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Dolorum vitae aut iste nisi blanditiis et.", 74, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 13, 0, 0, 0), "Architecto est non in enim architecto.", 4, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 10, 0, 0, 0), "Autem vero nulla aperiam nemo molestiae et.", 83, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 15, 0, 0, 0), "Neque aperiam sunt est impedit.", new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 9, 0, 0, 0), "Delectus maiores dolorem ut voluptas veniam perspiciatis ex ut est.", 66, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), "Aut dolore necessitatibus laudantium.", 98, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Accusantium enim aut non corporis fugit in molestiae ipsum.", 24, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 13, 0, 0, 0), "Sit inventore deserunt quos repellendus hic.", 90, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 13, 0, 0, 0), "Vel modi debitis consectetur sed dolores perspiciatis perspiciatis quo.", 34, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 12, 0, 0, 0), "Voluptates perspiciatis aut recusandae possimus.", 87, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 17, 0, 0, 0), "Fuga qui et necessitatibus ut quia.", 80, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 16, 0, 0, 0), "Quam exercitationem minus nihil.", 57, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 13, 0, 0, 0), "Error aspernatur facilis consequatur porro eius voluptas eveniet.", 55, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), 4, "Et sed aut ullam.", 62, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), "Adipisci ex dolor.", 18, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), "Laudantium adipisci ad sed sed ut voluptates mollitia non.", 25, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 14, 0, 0, 0), "Architecto quia error.", 7, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Qui explicabo cumque et unde.", 68, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), "Et quis exercitationem ipsam iusto ut vitae voluptatem alias vel.", 23, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), "Debitis aut eaque ut.", 45, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, "Nemo molestiae praesentium id alias consectetur.", 34, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Et aut atque nostrum quia molestiae.", 15, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Aut in laboriosam temporibus molestiae voluptatem eveniet labore facilis voluptatem.", 38, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), "Et ut porro tempora provident delectus.", 57, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 17, 0, 0, 0), "Eum rerum dolorem aut sint exercitationem odit.", 50, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 13, 0, 0, 0), "Quis inventore eos odit rerum deleniti.", 88, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 16, 0, 0, 0), "Sunt fugit accusamus aperiam quisquam consequatur.", 18, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 10, 0, 0, 0), "Suscipit in fugiat ut nostrum mollitia et vitae aut porro.", 64, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), 5, "Dolores perferendis deleniti reprehenderit.", 76, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Et ducimus quaerat.", 43, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), 17, "Quo nihil qui eaque.", 30, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 14, 0, 0, 0), "Autem consequatur non minima alias aliquam.", 90, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 9, 0, 0, 0), "Nobis omnis voluptatem a perferendis.", 15, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 13, 0, 0, 0), "Maxime non doloribus.", 92, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), "Cupiditate veritatis recusandae voluptas et.", 83, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), 16, "Et voluptas voluptatem nemo aspernatur possimus.", 34, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 0, 0, 0), "Enim aliquam cumque atque.", 39, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), "Nemo consectetur dolorem iusto esse tempore velit iure.", 40, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 10, 0, 0, 0), "Non saepe libero nisi veritatis ut excepturi similique.", 88, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 0, 0, 0), "Aspernatur inventore impedit.", 31, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 8, "Voluptatibus rerum molestiae aliquam molestias architecto voluptate aut culpa.", 59, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 18, 0, 0, 0), "Dolores ex corrupti omnis.", 17, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), "Ullam est beatae iure consequatur dolorem.", 53, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 16, "Id veritatis iste amet laboriosam aut debitis voluptatem et soluta.", 33, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 0, 0, 0), "Sed totam velit aut natus distinctio placeat non illum aut.", 7, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), 17, "Earum ab non enim voluptatem aut ab quo totam explicabo.", 101, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 13, 0, 0, 0), "Aspernatur dolorum perferendis provident ipsa distinctio sunt animi cumque aut.", 3, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), "Veritatis magni occaecati velit dolor rem nemo.", 80, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 10, 0, 0, 0), "Nesciunt dolores ad.", 13, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 17, 0, 0, 0), "A molestiae omnis accusantium illum.", 18, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), "Facere aut est.", 77, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 14, 0, 0, 0), "Nesciunt iusto nostrum itaque eius ab.", 53, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 9, 0, 0, 0), "Et repudiandae delectus magni rem.", 86, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 18, 0, 0, 0), "Qui ut deserunt voluptatem facere excepturi sed doloribus at.", 15, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 14, 0, 0, 0), "Blanditiis quo eum necessitatibus voluptate.", 58, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 11, 0, 0, 0), "Sed provident voluptas ea eaque repellendus qui.", 21, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Magni ipsam voluptatem officiis commodi ut hic.", 61, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 12, 0, 0, 0), "Fugiat nihil ducimus velit quos possimus nobis velit qui.", 22, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), "Maiores nam libero.", 46, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 18, 0, 0, 0), "Minima culpa a atque modi aspernatur aut reprehenderit.", 98, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 16, 0, 0, 0), "Sit voluptas cum praesentium magnam doloremque cum dolorem ea.", 20, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), 4, "Officia in est dolor sed quos et sint nulla.", 53 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 13, 0, 0, 0), "Voluptas qui dicta est et sit similique necessitatibus qui.", 22, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Nesciunt et aut sed neque nesciunt.", 13, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Voluptas voluptatibus enim sint esse facere aut omnis fugit.", 92, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 9, 0, 0, 0), "Maiores facere sunt tempore dolorem voluptatem.", 73, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 15, "Ut modi rem aut est mollitia natus.", 87, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 9, 0, 0, 0), "Ad alias id dolores ad.", 9, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 15, 0, 0, 0), "Velit molestiae aut ipsum possimus nostrum recusandae ipsa modi.", 77, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), 8, "Qui eum beatae.", 40, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Repellendus qui soluta impedit illo facilis.", 47, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 18, 0, 0, 0), "Fugit placeat tempore qui quasi sed.", 63, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), "Minus odit aut.", 87, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 18, 0, 0, 0), "Odit qui autem est asperiores.", 25, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 9, 0, 0, 0), "Nobis dolor nam quasi libero voluptatem possimus distinctio in.", 48, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 16, 0, 0, 0), "In voluptatem omnis quia.", 49, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 17, 0, 0, 0), "Soluta dolor consequuntur pariatur accusantium.", 20, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Et nihil porro voluptates eveniet accusantium aspernatur quia.", 42, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), "Harum tenetur vitae id voluptas iste aliquid optio facilis suscipit.", 54, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Eligendi animi alias velit qui consequuntur maxime exercitationem possimus.", 2, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 0, 0, 0), "Ab reiciendis repellendus.", 19, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), "Impedit consequuntur hic.", 89, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 18, 0, 0, 0), "Mollitia fuga sit.", 28, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 10, 0, 0, 0), "Nihil nihil accusamus rerum atque recusandae repellendus hic deleniti.", 80, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 17, 0, 0, 0), "Repudiandae voluptatem temporibus minus est.", 45, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 13, 0, 0, 0), "Similique voluptatem modi.", 36, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 9, 0, 0, 0), "Asperiores neque eaque quo quos quae accusantium perferendis.", 90, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), 12, "Excepturi beatae non voluptatem.", 21, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 13, 0, 0, 0), "Optio qui et consequatur voluptatem aut.", 37, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 10, 0, 0, 0), "Cupiditate sit aut.", 79, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Dolorum et impedit non.", 90, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), "Autem rerum officiis qui et aliquid placeat.", 59, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 11, 0, 0, 0), "Et tenetur omnis delectus voluptas qui animi sapiente et.", 78, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 9, 0, 0, 0), "Velit dolor ea dolorum sunt qui nobis laborum et excepturi.", 1, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 10, 0, 0, 0), "Dolorum consequatur ducimus vel dicta tenetur.", 46, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 10, 0, 0, 0), "Error est est.", 2, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Debitis aut qui dolorem non.", 97, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), "Molestiae vel provident.", 48, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 17, 0, 0, 0), "Aut libero fuga dolorem sunt animi.", 20, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 17, 0, 0, 0), "Est possimus sit quisquam ullam quibusdam reiciendis atque.", 57, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 10, 0, 0, 0), "Mollitia fuga est.", 29, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 14, 0, 0, 0), "Aut cum consequatur optio et consequatur ut.", 90, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 0, 0, 0), "Rerum nihil consequatur eos illo.", 82, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 16, 0, 0, 0), "Totam rerum in velit id atque.", 101, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), "Animi error at.", 96, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 16, 0, 0, 0), "Ipsam labore reiciendis autem similique totam optio vero temporibus.", 59, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), "Atque quae unde officia et consequatur facilis vitae dignissimos perspiciatis.", 93, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 14, 0, 0, 0), "Harum enim sint neque.", 56, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 12, 0, 0, 0), "Voluptates officia dolores vel nobis sunt quod nostrum.", 63, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), "Ut deleniti cumque aut rerum.", 32, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 0, 0, 0), "Dolores debitis velit aut soluta.", 9, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 0, 0, 0), "A molestiae nam voluptas amet enim unde vel incidunt ab.", 59, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Omnis porro et tempora dolores velit quo voluptatem in.", 100, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 18, 0, 0, 0), "Ipsa voluptas optio qui vitae nulla.", 29, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 16, 0, 0, 0), "Necessitatibus deserunt architecto illo voluptatibus voluptatem aliquam hic laboriosam deleniti.", 62, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 15, "Pariatur rerum et atque omnis maxime.", 20, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 9, 0, 0, 0), "Tenetur voluptatum est maiores est.", 59, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 15, 0, 0, 0), "Deserunt et provident vero.", 27, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 10, 0, 0, 0), "Quidem dicta voluptatum excepturi velit atque.", 23, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 15, 0, 0, 0), "Dicta optio nemo repudiandae aliquam autem.", 13, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 13, 0, 0, 0), "Et tenetur et.", 89, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Facilis odio et sit quo eos.", 63, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 14, 0, 0, 0), "Deleniti autem et.", 15, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 16, 0, 0, 0), "Cumque distinctio et.", 9, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), "Illum itaque sint similique ea.", 10, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), "Doloremque nemo ullam ut in amet occaecati porro.", 68, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 17, 0, 0, 0), "Et minus blanditiis placeat quia voluptatibus autem.", 46, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Quisquam laborum ipsa.", 92, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 9, 0, 0, 0), "Architecto praesentium quaerat consequatur blanditiis nulla occaecati nobis.", 47, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { 20, new TimeSpan(0, 13, 0, 0, 0), "Similique dolor ipsum illo ut officiis.", 24, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 17, 0, 0, 0), "Non qui officiis et magnam et delectus officiis amet.", 18, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 9, 0, 0, 0), "Molestiae iusto dolorem.", 19, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), 6, "Et sint est nihil dolore.", 74 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Ad temporibus dolores iste accusantium occaecati recusandae a voluptas.", 67, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 15, 0, 0, 0), "Non ipsum vel at consequatur in.", 8, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Aperiam quae consequatur quibusdam praesentium molestias cum inventore nihil.", 54, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 9, 0, 0, 0), "Deleniti doloremque ullam provident ipsa ex.", 87, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 0, 0, 0), "Voluptas a totam et aut dolore et.", 79, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), "Voluptatem qui dolorem occaecati qui doloribus porro ea.", 30, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 12, "Reiciendis autem neque rem repellat culpa id.", 88, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 11, 0, 0, 0), "Commodi quo ab dolores et.", 76, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 13, 0, 0, 0), "Incidunt et amet et nam recusandae est sit culpa.", 38, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 0, 0, 0), "Expedita illum a vel voluptatibus.", 10, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), "Aperiam facere iste aut consequatur ab suscipit necessitatibus.", 36, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 10, 0, 0, 0), "In voluptas ab molestias placeat sint illo impedit tempore.", 71, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), "Aut officiis debitis eos.", 37, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 9, 0, 0, 0), "Aliquid ad commodi non et doloremque ad omnis.", 15, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Omnis tenetur assumenda suscipit ut modi totam accusamus ut vel.", 42, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 18, 0, 0, 0), "Impedit totam qui illum.", 50, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 10, 0, 0, 0), "Eius laborum excepturi quos possimus qui vel amet itaque autem.", 2, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Pariatur repudiandae dolorum nihil aperiam.", 25, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), "Ipsam eos dolores aspernatur est culpa labore et sit.", 64, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), "Tempore id et ut quia nihil dignissimos.", 2, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), "Rem magni expedita facilis.", 66, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), "Voluptatibus recusandae amet quis adipisci.", 96, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 15, 0, 0, 0), "Architecto tempore recusandae temporibus illo voluptas magnam dolorem.", 58, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Ad doloribus aut vitae deserunt quisquam odio omnis quod delectus.", 34, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 14, 0, 0, 0), "Earum ea eligendi odit nobis aut.", 31, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 11, 0, 0, 0), "Consectetur quisquam amet aspernatur.", 89, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 14, 0, 0, 0), "Non enim eos.", 11, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 9, 0, 0, 0), "Quam quia quo non consequatur suscipit.", 11, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 18, "Enim nihil voluptas consequatur optio non quo facilis.", 87, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 18, 0, 0, 0), "Voluptas ullam asperiores.", 55, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 15, 0, 0, 0), "Quia dolores ut sequi.", 44, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 13, 0, 0, 0), "Repellendus cumque deleniti tempora aspernatur aut atque ipsa.", 35, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), "Accusantium illo officiis non quam illum at qui error.", 25, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Iusto praesentium aperiam.", 37, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 16, 0, 0, 0), "Delectus vitae dolores ipsa voluptates aut voluptatum sed quod iure.", 52, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 11, 0, 0, 0), "Dicta quam facere.", 59, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 19, "Laboriosam ipsa accusantium.", 6, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), "Nemo fuga est.", 27, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 11, 0, 0, 0), "Assumenda consequatur recusandae et.", 73, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), "Alias inventore at corrupti corrupti cupiditate.", 6, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 14, 0, 0, 0), "Distinctio sint ex sit.", 70, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 20, "Rem et aut aut voluptates molestiae exercitationem sint.", 41, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 15, 0, 0, 0), "Molestiae vitae cumque earum omnis vel repellat.", 3, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 16, 0, 0, 0), "Odio quia omnis.", 24, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 17, 0, 0, 0), "Itaque similique dolores id delectus necessitatibus ducimus.", 34, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 13, 0, 0, 0), "Quo laborum modi quam repellat eveniet at occaecati.", 20, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 15, 0, 0, 0), "Expedita illo sed temporibus facilis ut ut ipsa temporibus.", new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 10, 0, 0, 0), "Eaque quas consectetur ea quas.", 58, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), 9, "Doloribus quae tempora ut sapiente.", 77, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), "Repudiandae non aperiam et.", 66, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 10, 0, 0, 0), "Itaque quia quasi.", 50, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 11, 0, 0, 0), "Omnis doloribus dolor aperiam.", 63, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 16, 0, 0, 0), "Voluptatibus non libero et modi laboriosam voluptatem inventore et.", 52, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 9, 0, 0, 0), "Qui dolores aperiam molestiae exercitationem labore consectetur dicta nihil quae.", 50, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 13, 0, 0, 0), "In incidunt aperiam perspiciatis numquam recusandae voluptatum.", 69, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Voluptates et quam.", 46, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), "Fugiat cupiditate repellat voluptatem autem numquam et voluptas ut in.", 61, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AppointmentDate", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "Incidunt minus harum numquam.", 12, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 11, 0, 0, 0), "Odio officia ullam.", 70, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), "Non omnis rerum quia voluptate explicabo impedit quaerat.", 91, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 0, 0, 0), "Vitae blanditiis voluptas qui vitae voluptatem voluptas illum quo iste.", 51, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Natus doloribus maxime et cumque.", 24, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 9, 0, 0, 0), "Expedita corrupti aspernatur voluptate.", 42, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 9, 0, 0, 0), "Qui sed iusto qui quisquam consequatur vel reprehenderit hic voluptates.", 26, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 9, 0, 0, 0), "Ea aut ratione illum provident tempora.", 55, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), "Dolorem eum sit non.", 22, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 15, 0, 0, 0), "Totam pariatur quasi vero laudantium voluptatem voluptatum vitae deleniti modi.", 35, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 9, 0, 0, 0), "Commodi porro quia numquam id omnis qui placeat.", 58, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 18, 0, 0, 0), "Tempore unde est molestiae facere rerum optio.", 85, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 17, 0, 0, 0), "Cumque minima rerum quis officia reiciendis nostrum quidem commodi.", 42, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 10, 0, 0, 0), "Est ut illo voluptatibus mollitia.", 18, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 0, 0, 0), "Iste nam nesciunt est magni consequatur soluta nihil.", 39, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 10, 0, 0, 0), "Cumque facere fugiat aut.", 46, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 18, 0, 0, 0), "Dolor deleniti laboriosam architecto voluptates commodi ut consequuntur.", 84, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 0, 0, 0), "Quam possimus aut consectetur quis corrupti.", 29, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 11, 0, 0, 0), "Iure veniam placeat amet sunt optio est.", 91, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), "Voluptatem ex accusantium enim eveniet est voluptatibus.", 4, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 9, 0, 0, 0), "Enim tempore qui occaecati praesentium doloribus.", 75, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 4, "Molestiae sit explicabo dolorem nulla aut sunt modi et.", 32, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 17, 0, 0, 0), "Maxime tenetur id molestiae.", 2, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), 6, "Architecto illo est voluptate.", 19, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 9, 0, 0, 0), "Et beatae officiis eos aut eius itaque libero aliquid quae.", 76, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 13, 0, 0, 0), "Enim qui est molestias odio.", 59, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 10, 0, 0, 0), "Et cum est cum vero et laudantium.", 96, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 12, 0, 0, 0), "Omnis eligendi totam magni iure.", 38, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), "Qui occaecati suscipit.", 17, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), "Voluptate id quia qui deleniti iusto qui reiciendis.", 95, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), "Voluptas nam quia inventore ipsum dolorum eveniet unde.", 45, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Đa khoa", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Thần kinh", 4, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Thần kinh", 4, 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Nhi khoa", 5, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Đa khoa", 1, 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Nhi khoa", 5, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Thần kinh", 4, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "About", "Specialization" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Tim mạch", 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Tim mạch", 2, 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Đa khoa", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Tim mạch", 2, 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Nhi khoa", 5, 10 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Đa khoa", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Da liễu", 3, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Thần kinh", 4, 6 });

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
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Da liễu", 3, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Da liễu", 3, 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Tim mạch", 2, 9 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Tim mạch", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcbfc465-07c0-49b3-a42f-53d09f24b66e", "AQAAAAIAAYagAAAAEBaDS362cFgt0NBobgqOpwVW4WK+z6g9Ti8Inue5PfgUECdNYSDx3CHUd+NH9L8HxQ==", "2af5defe-540f-4bb0-93ce-60a2d7a14221" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "207 Trần Burg", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Tr%C3%BAc%20Lan", "f9492856-b2ee-420a-a309-0ecf7f0bc009", new DateTime(2012, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "VietKhoa7@gmail.com", "Phùng Trúc Lan", "VIETKHOA7@GMAIL.COM", "VIETKHOA7@GMAIL.COM", "AQAAAAIAAYagAAAAEJdFaWPBBYqW+I4JRoNuDyIuovfnY/s74effimtvoifqdy4kUWiqa7No7pdpG57Obw==", "022 2327 4260", "c1804da0-ca75-4600-8b21-1d3d114af72e", "VietKhoa7@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8955 Tùng Linh Drive", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Qu%E1%BB%91c%20H%C3%B2a", "64acd163-7784-4c9e-8be7-254722331fa0", new DateTime(2015, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "LongGiang29@yahoo.com", "Đỗ Quốc Hòa", "LONGGIANG29@YAHOO.COM", "LONGGIANG29@YAHOO.COM", "AQAAAAIAAYagAAAAEIJuuOCGFKEuxICnDj8BI8aBXvrv0BNqbCNCGlmOYK33lol9xQAvhgdumd6rDgg6Lg==", "025 2349 0218", "2a863df0-0dfd-4980-bded-096daba719eb", "LongGiang29@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "58043 Hà Crossing", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Th%C3%A0nh%20Sang", "944185d2-7f79-4dbf-a80b-644c5e0853a5", new DateTime(2019, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "HongQuy.Vuong74@hotmail.com", "Trịnh Thành Sang", 1, "HONGQUY.VUONG74@HOTMAIL.COM", "HONGQUY.VUONG74@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJ+8Hf2JpyjFb4fGwAFMt5G4341dO5MM1bLjxJPCUZXlT4b4iFTZsys21H2uWnRtwQ==", "029 1138 7889", "dae13957-6228-4ec7-81db-29a05b704ac4", "HongQuy.Vuong74@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "221 Lê Corner", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20%C3%90%E1%BB%A9c%20Tu%E1%BA%A5n", "5cc08d60-b752-456b-b3db-5579bd617cab", new DateTime(2019, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "TuongVi46@hotmail.com", "Mai Ðức Tuấn", 1, "TUONGVI46@HOTMAIL.COM", "TUONGVI46@HOTMAIL.COM", "AQAAAAIAAYagAAAAEE5hDAYtUf0NqSDa8bNW/Hw5VXZdupoSA9MIoaRnnfpS3LD/bk12Y8WxMCF1sDmdvg==", "0283 1225 8271", "b5c59f5d-6e96-41eb-b817-2789c5b58fbb", "TuongVi46@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "38538 Hà Fort", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Quang%20Trung", "6e3da394-cf20-4e2e-a28b-05c1fa28dde3", new DateTime(2005, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "PhuongHoa19@hotmail.com", "Hà Quang Trung", 3, "PHUONGHOA19@HOTMAIL.COM", "PHUONGHOA19@HOTMAIL.COM", "AQAAAAIAAYagAAAAEK0ZIq3hBo39qisayevVq5oURmd40abog9t0Xibwzr/M/wtrU0yqV/W5xt5fkjjoqg==", "0246 6777 1917", "c3a761c1-29d2-4976-abc9-72182c2a141f", "PhuongHoa19@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "39334 Vương Route", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Ng%E1%BB%8Dc%20Loan", "f381d046-6622-493c-8859-03fd828ee7b9", new DateTime(1999, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "QuangTai.Lam2@hotmail.com", "Mai Ngọc Loan", 3, "QUANGTAI.LAM2@HOTMAIL.COM", "QUANGTAI.LAM2@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHhzcwsQaEcO+mGVKqdhzVEGv27nv/oxy6OlWGrtPb10zWNQMzQAajPnqY9/1deMVw==", "0259 0252 9151", "ea8bf02e-5f4f-4cca-90ad-4db25cc315ab", "QuangTai.Lam2@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "060 Phùng Knolls", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Qu%C3%A2n%20D%C6%B0%C6%A1ng", "ae371e34-7801-4be6-a088-03d7b9508e8e", new DateTime(2003, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "VuongGia_Truong62@yahoo.com", "Tô Quân Dương", 2, "VUONGGIA_TRUONG62@YAHOO.COM", "VUONGGIA_TRUONG62@YAHOO.COM", "AQAAAAIAAYagAAAAEDLG1SEflp05nxraSk8nLg1yXYqaY+sldm+uquds/KRnWjLDHtnOAOVIoxoeSADD/g==", "021 3681 4515", "52779362-ebae-4232-8b7b-1073647e93d1", "VuongGia_Truong62@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "66970 Công Sinh Landing", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Minh%20Hi%C3%AAn", "eae8f307-c533-4ddd-b1a9-28ef113839c2", new DateTime(2019, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "NgocHa_To@gmail.com", "Ngô Minh Hiên", 1, "NGOCHA_TO@GMAIL.COM", "NGOCHA_TO@GMAIL.COM", "AQAAAAIAAYagAAAAEH+s/3Z6CGED8ZDpU6gKpTVY9SZt9u/pMbDUw/RSzgaElq0XbYOxeNNuVa3UsTXezQ==", "026 2897 2281", "471970b8-aada-4368-9304-4c07da73919a", "NgocHa_To@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "79221 Trịnh Canyon", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Nghi%20Dung", "50bda333-3b82-41ec-90a6-93e162a4f24e", new DateTime(2000, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "DiemHuong_Phan71@hotmail.com", "Hoàng Nghi Dung", "DIEMHUONG_PHAN71@HOTMAIL.COM", "DIEMHUONG_PHAN71@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAU0V1s4GNNsTI7V1ke3YRQgM50FLApq3iORhfTFPHnsmZ33SrlYKHH9MT0VS96xUg==", "023 1252 1205", "63353b47-d19e-4592-ae11-e48387ae403f", "DiemHuong_Phan71@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "980 Vương Triệu Estate", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20H%E1%BB%93ng%20Linh", "a2d26bfc-6395-4b8c-a680-815c986646a3", new DateTime(2003, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "BinhMinh46@yahoo.com", "Hà Hồng Linh", "BINHMINH46@YAHOO.COM", "BINHMINH46@YAHOO.COM", "AQAAAAIAAYagAAAAEA+mGf8JvFkxTrk+YXLY/DY1as0xjF9yt1SD8Re9VwWSNIhru2bJ+SxFeaGqUpcslw==", "022 7043 9528", "5cc7b44a-7adf-432a-9e82-a54e8f654185", "BinhMinh46@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "959 Như Quân Alley", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Ho%C3%A0i%20V%E1%BB%B9", "9a052c9d-8435-401e-a96a-fc7cf0dc479d", new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "ThanhTuyen_Ha64@gmail.com", "Đinh Hoài Vỹ", 2, "THANHTUYEN_HA64@GMAIL.COM", "THANHTUYEN_HA64@GMAIL.COM", "AQAAAAIAAYagAAAAEAyA643PUQ1yKkmyN9AYKZGtD3kYECCnPoUplw0C2NtN1xhE0yvbfXuUYJIBwWFArw==", "0283 3711 7600", "4a2d1870-24ff-436e-aa2a-2ac4eebbe773", "ThanhTuyen_Ha64@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6649 Lâm Viên Stream", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Li%E1%BB%85u%20Oanh", "61e91be9-7ca1-4870-9b5f-07fee4726dd5", new DateTime(1997, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "ThanhVan_Ho@yahoo.com", "Đặng Liễu Oanh", 1, "THANHVAN_HO@YAHOO.COM", "THANHVAN_HO@YAHOO.COM", "AQAAAAIAAYagAAAAEMpoyd4hwAzRqnteyp4aQWNraioEbvAp+Q2sYgBNuVUN6DChE4b+HQrb8kUyl//32Q==", "028 2922 9948", "413b1f81-646c-462b-9a52-0052013a6723", "ThanhVan_Ho@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1313 Vũ Squares", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20%C4%90an%20Th%C6%B0", "870c5385-bb6e-4c54-9f17-ffce9032c2a8", new DateTime(2013, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "VanSon.Do@hotmail.com", "Trương Đan Thư", 3, "VANSON.DO@HOTMAIL.COM", "VANSON.DO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEODjZNX5PHoEnOs3qVpc1W3q5ZZ6zGRQSl0igKQj1irZCt4LSfxI9bSw8Wi6wX8srg==", "0264 5246 5113", "f47eb50f-8fcd-44c5-95aa-29ee03d976d5", "VanSon.Do@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1718 Phùng Corners", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Tr%C3%AD%20Li%C3%AAn", "eecc7811-8b0b-4d8f-9af2-2f313e31c8a4", new DateTime(2004, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "TuanLinh9@yahoo.com", "Trương Trí Liên", "TUANLINH9@YAHOO.COM", "TUANLINH9@YAHOO.COM", "AQAAAAIAAYagAAAAEHahFQh5hHnfOxtJdX4gU6QeEmDOftDUwT7peEpLOpkRZMm38WIAd7uJTTg3J2If6Q==", "0291 0822 8396", "c7e8ac0a-436d-4f7d-95be-ed7eef4e2dc2", "TuanLinh9@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "37939 Hạc Cúc Hill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Nguy%C3%AAn%20V%C4%83n", "944a6aab-259f-41ca-9262-464aae7bedf9", new DateTime(2011, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "QuangDuong_Trinh25@yahoo.com", "Hồ Nguyên Văn", "QUANGDUONG_TRINH25@YAHOO.COM", "QUANGDUONG_TRINH25@YAHOO.COM", "AQAAAAIAAYagAAAAELNkAaunwnev7V9D58RAgCwpGWhgniMMbyMtmr/l6AJSqNSHGJRmLN1+hPmgNh+pgg==", "0294 1957 2519", "3972bdb9-c8a1-41bd-a0be-72aa97dfbd07", "QuangDuong_Trinh25@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6696 Đặng Junction", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Ho%C3%A0ng%20Th%C6%B0", "0f82c4d0-d317-475f-bad1-3e94544223f7", new DateTime(2014, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), "DuyQuang41@gmail.com", "Tăng Hoàng Thư", 1, "DUYQUANG41@GMAIL.COM", "DUYQUANG41@GMAIL.COM", "AQAAAAIAAYagAAAAEGuBN24hRz2VIFrRkIcTNb1IDOwZgsPV7edgzibde4s3ArIomaGQ4qdccX9NOfCGsg==", "029 4482 0686", "b92e76ad-96c5-4a15-bd04-626300bc50df", "DuyQuang41@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "061 Ngọc Loan Burgs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Tr%C3%BAc%20Ly", "7ae50480-b662-4b78-b2f5-27fafccaba46", new DateTime(2008, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "HoangCuc91@gmail.com", "Tăng Trúc Ly", 3, "HOANGCUC91@GMAIL.COM", "HOANGCUC91@GMAIL.COM", "AQAAAAIAAYagAAAAEBIPliIPR4Pd5GF70AZdZVbbc3xc0rv63g75gad2bue0Dhq5UEGfTyxiQk7Uh4mPMg==", "029 9581 8629", "bbc071d1-57d3-42cc-83fa-1ae3ab7de38b", "HoangCuc91@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "02439 Phan Road", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Nguy%C3%AAn%20Nh%C3%A2n", "53221bf3-cd41-4d89-88b4-a7ebe67cb718", new DateTime(2012, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "CongSinh48@gmail.com", "Mai Nguyên Nhân", "CONGSINH48@GMAIL.COM", "CONGSINH48@GMAIL.COM", "AQAAAAIAAYagAAAAEE6JPlzsw6Yy8/FX5739+Ky3WMLqEmMkOKYSTUnVJ9AJRW+y2V2CZ7kWxcouSTEmzg==", "0263 7706 3024", "bd84235e-61f4-462a-ba7a-38b64769733b", "CongSinh48@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "377 Thảo Nguyên Haven", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Th%C3%BAy%20H%C6%B0%C6%A1ng", "208e71b0-d698-4366-87bd-55aa7e2bbe8e", new DateTime(2011, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "ThieuMai.Lam@hotmail.com", "Đỗ Thúy Hương", 3, "THIEUMAI.LAM@HOTMAIL.COM", "THIEUMAI.LAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAECCaOBsbFjBYJpyL9xb4synMLXxlUQ0deIOrJN5e0u8pXrzhGCsZiT59mXK+jQVEVA==", "0276 2207 9798", "4d5ff206-fe7e-4331-96c9-0044cbfd7ae0", "ThieuMai.Lam@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "997 Thục Nhi Shore", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Mai%20Li%C3%AAn", "f39a7e75-5e75-47a3-959d-b96fbbd25941", new DateTime(2014, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "ThienSinh50@gmail.com", "Vương Mai Liên", 3, "THIENSINH50@GMAIL.COM", "THIENSINH50@GMAIL.COM", "AQAAAAIAAYagAAAAEEBBm7gjS0INgGBv/zugk2t8SSB6bLE/ixObQBlSj5/ybwSWVgOt0eAK1WbXEMjszA==", "027 8500 9712", "10ecb74e-95fc-4b3b-9cb0-d864c5f97d5b", "ThienSinh50@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6918 Chiêu Dương Stravenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Uy%E1%BB%83n%20My", "5930adcf-804b-4b14-be54-397847387f12", new DateTime(1995, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "HuongLien_Dinh@yahoo.com", "Phùng Uyển My", "HUONGLIEN_DINH@YAHOO.COM", "HUONGLIEN_DINH@YAHOO.COM", "AQAAAAIAAYagAAAAEKXK+dahqoVwjPqwZ3x+IhMIv0pwU3xZNfOp7b3StMgZrswxciEMnYXQyfByX/vl/w==", "0293 8965 8146", "76924c92-9f97-4599-87ae-47082f318588", "HuongLien_Dinh@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5897 Lê Walks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C5%A9%20Huy%20Kha", "8f9c341c-c60a-4b84-8e44-8dc78e60195f", new DateTime(2004, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "HaiDuong_Vu23@hotmail.com", "Vũ Huy Kha", 3, "HAIDUONG_VU23@HOTMAIL.COM", "HAIDUONG_VU23@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEl+NS94EuRwzKWjeGLP7seLqf+/7VK0JVQMITlnPRqqTUZSzCV34LaqRdR58E7/Rg==", "029 1621 2693", "1534f10b-0c0b-424c-a238-f1941a396e05", "HaiDuong_Vu23@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7396 Phương An Neck", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Duy%20M%E1%BA%A1nh", "61444506-1e77-493c-9afe-5af62bb8a889", new DateTime(2010, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "KhietLinh_Mai95@hotmail.com", "Lê Duy Mạnh", "KHIETLINH_MAI95@HOTMAIL.COM", "KHIETLINH_MAI95@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFo804Z4cBdtgUhoxXsSc/9LDqG7fnLuXvX21qDorRq9Hh3XkKBhN9dMi0uJphNaIg==", "028 3794 5291", "37d20399-da7a-4b25-accc-5a6c624596e5", "KhietLinh_Mai95@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3088 Ngọc Tâm Meadow", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20V%C4%A9nh%20To%C3%A0n", "e4eec9be-1c7a-4335-be7e-7f697f051de8", new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), "DucTho98@yahoo.com", "Phùng Vĩnh Toàn", 2, "DUCTHO98@YAHOO.COM", "DUCTHO98@YAHOO.COM", "AQAAAAIAAYagAAAAEB4puqfSyztbOWABk3vs1wO8qvTMgJ5ODf1TbfPRBMT/C5dUOE7YQcyLle8cB9m7ZQ==", "0220 3030 7221", "37ddc22c-a2e0-4315-bed2-3c44b77364d1", "DucTho98@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3327 Đỗ Terrace", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Nh%C3%A3%20Y%E1%BA%BFn", "d4b3b5fa-ad03-4cb6-8039-ee7b93c38ad7", new DateTime(1998, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "ChiNam33@hotmail.com", "Tô Nhã Yến", "CHINAM33@HOTMAIL.COM", "CHINAM33@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFRgk2moW1nnBIzQuY1ghGZyt1mItTtNBxW26A4Fc6hnzYIB6D8m3x7/8wvufUj2LQ==", "026 0753 8048", "46ba98d7-30d7-4755-b698-dcaa8cd36757", "ChiNam33@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "519 Hữu Trác Walk", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20Vi%E1%BB%85n%20%C3%90%C3%B4ng", "a305d5cb-bb1f-47a5-9ce3-5a62c81b60bc", new DateTime(2018, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "ThuyKhanh.Ha94@yahoo.com", "Đào Viễn Ðông", "THUYKHANH.HA94@YAHOO.COM", "THUYKHANH.HA94@YAHOO.COM", "AQAAAAIAAYagAAAAED3Rztpw3fLlI99p6+IWS9onMwtrQMUjyHXE3BMCcponlJOS9APM9IbQBMUk0X2Fag==", "0235 6001 1807", "7309c106-4279-420b-8a4d-772d3b8ea2ff", "ThuyKhanh.Ha94@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "33899 Lý Park", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20%C3%90inh%20L%E1%BB%99c", "bfa49e52-1104-44c5-91bf-bbcfb08dd779", new DateTime(2007, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "NguyetUyen19@yahoo.com", "Hoàng Ðinh Lộc", 3, "NGUYETUYEN19@YAHOO.COM", "NGUYETUYEN19@YAHOO.COM", "AQAAAAIAAYagAAAAEAlFJPR6J8zrLxU2G4k0/UYhSzeV4F2cx+Gtm5mUdS1CPDX+zwiQRah5+/bBwe/TPg==", "0224 0046 8873", "69f76ddb-b697-4133-8986-03658f9cbce7", "NguyetUyen19@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4646 Trần Station", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20L%C6%B0%C6%A1ng%20T%C3%A0i", "d30542ba-533d-4a21-bf3a-5d0f9ed73fbe", new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "GiaBao_Dao47@hotmail.com", "Bùi Lương Tài", 3, "GIABAO_DAO47@HOTMAIL.COM", "GIABAO_DAO47@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDAJjIwUyyfvAnRrj1mQhr9WGVHMoO0YC+uhyS4wZVHz1T86OZCLk+yIWeEMHmE10A==", "022 7839 9380", "2f696c06-4f12-465d-a670-84a7673bff79", "GiaBao_Dao47@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "79646 Việt Nga Vista", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Th%E1%BA%A3o%20Ti%C3%AAn", "702992cd-db53-415f-995e-cdb59d565b58", new DateTime(2001, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "ThuNhien47@gmail.com", "Dương Thảo Tiên", 2, "THUNHIEN47@GMAIL.COM", "THUNHIEN47@GMAIL.COM", "AQAAAAIAAYagAAAAEFRlrcyKsnlBK/R3imjj21w+vuTp8cWgCtNHFg2OW9/c6U+AQSGHvGOb6zLjqfjlpw==", "0272 5686 1804", "5f781037-b4e3-41e0-8a2c-3b11c3c93314", "ThuNhien47@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "46483 Thụy Lâm Ranch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20Thanh%20Thi%C3%AAn", "9a7f8ac2-99fb-4903-8475-19b688f3bda7", new DateTime(2012, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), "LamDong_Ngo@gmail.com", "Đoàn Thanh Thiên", "LAMDONG_NGO@GMAIL.COM", "LAMDONG_NGO@GMAIL.COM", "AQAAAAIAAYagAAAAEPBdL41+t8St1+Lp7k1LFUnkIC5hq2dnR1Uu2itYbd1qpiOj9Ayhy+y9hir8yyu7lg==", "023 1767 0468", "b470eb53-3a1d-4d55-a702-45c7e9281b17", "LamDong_Ngo@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7641 Kim Toàn Lock", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20Nh%E1%BA%ADt%20Lan", "55391bbb-1c5b-42fd-8f85-be75a279f4dc", new DateTime(2012, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "ThaiSang.To53@gmail.com", "Đoàn Nhật Lan", 1, "THAISANG.TO53@GMAIL.COM", "THAISANG.TO53@GMAIL.COM", "AQAAAAIAAYagAAAAELVBzU4kNlFtXyIwaaqtiyErKgFyUoqGuTgTirZXedyknNYRq0mE8gmWJ+UpYaEW9A==", "0231 8190 3311", "bb42b278-4154-4f19-8cc0-e6491ec56345", "ThaiSang.To53@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "829 Trương Land", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20H%C3%A0%20Ti%C3%AAn", "424f85f8-9032-4f94-99f9-04a057b1c399", new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "PhuHung_Ho@hotmail.com", "Đào Hà Tiên", 1, "PHUHUNG_HO@HOTMAIL.COM", "PHUHUNG_HO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMZVgI3TCkOyfwDF+ZwR530YUMCOfZsv3skot33F6AqfiGm/WnpEMVMgZvqk1rqd1w==", "029 5079 6016", "0c4e7a98-ef3a-4570-a63c-23a0f8cf7362", "PhuHung_Ho@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4651 Tô Roads", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Thi%E1%BB%87u%20B%E1%BA%A3o", "63dfa495-ccd7-4053-aa01-80075f2e6c47", new DateTime(2000, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "DucQuang.Ngo2@gmail.com", "Lý Thiệu Bảo", 2, "DUCQUANG.NGO2@GMAIL.COM", "DUCQUANG.NGO2@GMAIL.COM", "AQAAAAIAAYagAAAAEEqxHamuzoNEU3L7LT01KTU0caW009u80slJOPVpIrrH0wLXRKSl9pRVnShM7cB11A==", "0266 6707 3374", "8346776f-31ca-4571-9df7-915bc1ae1cea", "DucQuang.Ngo2@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "59755 Trần Rue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Tri%E1%BB%87u%20M%E1%BA%ABn", "f21a20aa-b666-401c-aa68-3092840db5b8", new DateTime(2005, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "DinhHao_To@yahoo.com", "Đặng Triệu Mẫn", 3, "DINHHAO_TO@YAHOO.COM", "DINHHAO_TO@YAHOO.COM", "AQAAAAIAAYagAAAAEHjpu0Bcid8aCPNDHor35fOOCB5x9X4yiPAc2iM9ko5b0XxdfvNY/APO4OCjp6by0w==", "0208 7139 3367", "509bd9aa-37c1-4ecb-af97-a727c3b08143", "DinhHao_To@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "527 Lê Stravenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Th%C3%BAy%20H%C6%B0%C6%A1ng", "6316611e-febf-4436-aae2-eba9fd001ca7", new DateTime(2000, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "NgocAi_Ngo38@hotmail.com", "Bùi Thúy Hương", "NGOCAI_NGO38@HOTMAIL.COM", "NGOCAI_NGO38@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDNzdc1r1ERqn5ulLjH/CbYafyBPhto9hVHqbPtjV6rKtqYUe9DAgXWwxYSap4llrg==", "023 7123 2539", "c7246b43-adc7-436e-988b-e9f4ba1bb7a7", "NgocAi_Ngo38@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "78654 Thúy Vi Tunnel", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20L%C3%A2m%20%C3%90%E1%BB%93ng", "82f1181f-bede-4896-b02a-a5e1b2192832", new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "ChanPhong.Trinh@gmail.com", "Phùng Lâm Ðồng", "CHANPHONG.TRINH@GMAIL.COM", "CHANPHONG.TRINH@GMAIL.COM", "AQAAAAIAAYagAAAAENna63akdVNbWZ+/0hWQ0QNII1QFmnJ619Pzot52FtwqIrksg6RZZhY7H/IywNlifQ==", "022 9715 9582", "db66b9c0-e917-4a97-9019-5f83f7b4379f", "ChanPhong.Trinh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "408 Quốc Hiền Fall", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Hu%E1%BB%87%20Ph%C6%B0%C6%A1ng", "3eeba0ed-c814-4fe7-894f-d7a732182b5d", new DateTime(1998, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "TruongHiep4@yahoo.com", "Trịnh Huệ Phương", "TRUONGHIEP4@YAHOO.COM", "TRUONGHIEP4@YAHOO.COM", "AQAAAAIAAYagAAAAENqdOSqrUitj2cfOQ6GBMrBwPWiq2CQnwXBf7LPBp3bm1VxlHO/Gv35ItdKfM2DTYg==", "020 1352 9878", "695f94e9-4cf7-4297-961f-45a7ce7b0d48", "TruongHiep4@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "84798 Ðoan Thanh Islands", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Minh%20Ch%C3%A2u", "26afa03f-6ae0-4b80-90ec-d983d9aca59a", new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "DaiHanh62@gmail.com", "Lê Minh Châu", 2, "DAIHANH62@GMAIL.COM", "DAIHANH62@GMAIL.COM", "AQAAAAIAAYagAAAAEDbYYM1TpdC1RPJSNq/2NvJ+G51vgqekZun6RfCEEUSwrj6ccJmTLGeUNpQSgvo6EQ==", "0278 0731 5287", "9fc09154-7c2c-413b-8fa5-426c6d125c1e", "DaiHanh62@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6294 Đoàn Way", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20H%E1%BA%A3i%20Nhi", "02bdd99f-37d2-4031-bc50-6dbef26f511b", new DateTime(1997, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "KyVo.Duong@yahoo.com", "Hoàng Hải Nhi", 3, "KYVO.DUONG@YAHOO.COM", "KYVO.DUONG@YAHOO.COM", "AQAAAAIAAYagAAAAEIrab99PZ3s6YhKX0ecgRAtkMrQqBG84MIRWDiuFXaMyj74KgazrauD3+n4lntgtbg==", "0281 3348 7823", "795697e2-3775-406c-b691-20dea66376fd", "KyVo.Duong@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "24268 Kỳ Võ Station", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Ph%C6%B0%C6%A1ng%20Chi", "2324db6e-ba96-46cb-b036-5dd5bf464de5", new DateTime(2005, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "CongPhung.Ho@gmail.com", "Đỗ Phương Chi", "CONGPHUNG.HO@GMAIL.COM", "CONGPHUNG.HO@GMAIL.COM", "AQAAAAIAAYagAAAAEC6ju0ngMMqmre+dGBGhFds5tjo2KAO9BbNKr9xbqA1HWs4xFss6q0r8JY1frh4wpw==", "0243 1466 0337", "9eb8775b-a85f-4d00-a67d-b1a226117deb", "CongPhung.Ho@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "35386 Trung Việt Groves", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20L%E1%BB%87%20Giang", "390b4547-6854-41bd-b76c-9ce9864788c1", new DateTime(2007, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), "GiaHuan15@yahoo.com", "Đặng Lệ Giang", "GIAHUAN15@YAHOO.COM", "GIAHUAN15@YAHOO.COM", "AQAAAAIAAYagAAAAEPlLrc/z57J//e6F/B/HWLksE8HtYz6YX7MJVS3HFsdt5ahGW+VQN36Z356jEzaEbA==", "0271 3085 2726", "fcecc80b-8667-454e-9b14-74cb85f6a8d9", "GiaHuan15@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1804 Phương Trạch Place", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Kim%20Thanh", "33ea0d50-2fe1-495c-8b7e-50be65588c9d", new DateTime(1996, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "SaoMai51@gmail.com", "Hoàng Kim Thanh", "SAOMAI51@GMAIL.COM", "SAOMAI51@GMAIL.COM", "AQAAAAIAAYagAAAAEFLMictn8tHqg3W225U1ZF+ifTd23CrNyenFc/RHED0yTVX75RnH/ypZXHmboALBkg==", "0272 2069 3461", "cfbdd79d-cdc8-4ba8-aac6-e06d721d4f8f", "SaoMai51@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4103 Đinh Square", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20Nam%20Ninh", "f395daed-04aa-488c-bfce-fe488d10fa35", new DateTime(2005, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "UyenMinh88@yahoo.com", "Nguyễn Nam Ninh", "UYENMINH88@YAHOO.COM", "UYENMINH88@YAHOO.COM", "AQAAAAIAAYagAAAAEA6XiHbKjloNWh3dCXYqhouCLr5C+JYbU03ITaOXYsFalhLXwxvub9cYjk97QvoFsQ==", "021 1908 8701", "35210710-332a-4138-a497-123c2c83a31d", "UyenMinh88@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "118 Tuyết Băng Islands", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Th%C3%A1i%20Nguy%C3%AAn", "8a9d8117-2868-4a0f-81d5-ad68a410b0e0", new DateTime(2000, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "TuongVy.Dinh42@gmail.com", "Trịnh Thái Nguyên", "TUONGVY.DINH42@GMAIL.COM", "TUONGVY.DINH42@GMAIL.COM", "AQAAAAIAAYagAAAAEOtq7GurOn7wVdvCyC4Lrg7VF3k5x2qByPG8q1RVZDnoFZoX0kP4hUaD+TH1qdNgTQ==", "0214 6107 4715", "34bd84bb-574d-42d8-9eaa-e69e6b249b9c", "TuongVy.Dinh42@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "102 Kim Tuyết Lane", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Huy%20Kha", "b8ddea28-7119-402e-bb96-c5d652a34fba", new DateTime(2005, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "XuanHuong37@yahoo.com", "Vương Huy Kha", 3, "XUANHUONG37@YAHOO.COM", "XUANHUONG37@YAHOO.COM", "AQAAAAIAAYagAAAAEBR6j6faFxxhsQ/fpWGCxjREuSAabJRpMQf2fQLXpEDPgKHj+CsjisqVfkHGH8UZcQ==", "022 5464 5091", "c718c729-b793-4d9e-98f1-a07c92c66cb5", "XuanHuong37@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "04339 Viễn Phương Burg", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Duy%20Ti%E1%BA%BFp", "01a86b70-1446-4c65-abf3-76388ecbd191", new DateTime(1996, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "HungNgoc_Bui@hotmail.com", "Phùng Duy Tiếp", "HUNGNGOC_BUI@HOTMAIL.COM", "HUNGNGOC_BUI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDqI0ZJUS/c77JaxC74/k6e3cIjAPpOpvQ+h21wKQjzQSZTL/kfaitndj0KB7pMwUw==", "0222 2865 1218", "faf0c5ad-74ff-4d65-82c5-26d5c5f310f0", "HungNgoc_Bui@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "804 Bảo Giang Valleys", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20Minh%20Trung", "00082b16-78bb-4589-bc83-692d788572f5", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "ChiMai41@hotmail.com", "Nguyễn Minh Trung", "CHIMAI41@HOTMAIL.COM", "CHIMAI41@HOTMAIL.COM", "AQAAAAIAAYagAAAAELxQfA/vzDX62seHcoTSjZatpnS++8VAnMWBGDl/5596g5E1kyrcQ9qMrDIw4ylLVg==", "0260 5261 6904", "dbdf2444-959a-4fbf-8f02-2da432511038", "ChiMai41@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7272 Phúc Ðiền Crescent", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Quang%20Tri%E1%BB%81u", "366f885a-553c-44b7-9c38-bbb1f168fee5", new DateTime(2018, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "NhaHong_Tang34@gmail.com", "Tăng Quang Triều", "NHAHONG_TANG34@GMAIL.COM", "NHAHONG_TANG34@GMAIL.COM", "AQAAAAIAAYagAAAAELkqxBsrpo+8k5QL7Bmn9/dfU8YnP35CsjeLPK+O3Qx0xdeZpzsmRS+JnrcKaPDEQw==", "021 0440 0183", "fce42301-a856-48ab-95a7-e82ef80bc963", "NhaHong_Tang34@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3951 Vũ Neck", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20V%C3%A2n%20Trang", "f9551b25-a305-4a33-8186-f3ae45b62566", new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "AnhTai_To@yahoo.com", "Đinh Vân Trang", 3, "ANHTAI_TO@YAHOO.COM", "ANHTAI_TO@YAHOO.COM", "AQAAAAIAAYagAAAAEDP+CI9HysDvGjyNjKJoKVEhpDrJHv5MAovpfbiUFk/zVK/l0Nem5YjGa9ZOeatNCQ==", "028 3902 9735", "eceb6d8a-87fb-43de-9f60-3fa7f42dc6e5", "AnhTai_To@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "50403 Lý Mill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Mai%20Thanh", "b6a51f3c-c938-4f06-9a57-d1cca83351ea", new DateTime(1997, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "HoangViet78@hotmail.com", "Tăng Mai Thanh", 1, "HOANGVIET78@HOTMAIL.COM", "HOANGVIET78@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJirJOqgiEkJFeN5g8nRpUm5o0vwE5w84+4j3RcbUhw9fivcDhxMb0gvaov4KLM36g==", "020 9968 1530", "a125fbfd-f2ae-434b-b4b8-e1f7797021fb", "HoangViet78@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "073 Kim Vượng Walks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20Qu%E1%BA%A3ng%20Th%C3%B4ng", "cf879847-a7eb-45b7-bed6-24170ff211c2", new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "NamThong39@yahoo.com", "Lâm Quảng Thông", 1, "NAMTHONG39@YAHOO.COM", "NAMTHONG39@YAHOO.COM", "AQAAAAIAAYagAAAAEHnla8+C+l1uEDyBDN7Q5ghyKnH6OmthCTT4rP0KNR5tuPHWFtFx4M9ZthxKj7x7Gw==", "0270 8262 0984", "56c8314c-7945-4757-bd43-afebc80af2fc", "NamThong39@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "170 Kim Cương Circles", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Minh%20Tr%C3%AD", "8a5c7560-4734-465d-bbb3-a75897d6cd9f", new DateTime(2011, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), "HoaiBac34@gmail.com", "Tăng Minh Trí", 2, "HOAIBAC34@GMAIL.COM", "HOAIBAC34@GMAIL.COM", "AQAAAAIAAYagAAAAEP7HB7VCFGuzp/696Tb75IOVgeW/6TkU6fYyg4KO7445bZSil0h8czBhfWctiiVm9Q==", "0260 6820 4423", "d3d6c8b0-4250-4776-9499-86cf14e669e0", "HoaiBac34@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "918 Lâm Canyon", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Gia%20Kh%C3%A1nh", "c825f53f-17b6-4b26-979a-5c616de391eb", new DateTime(2003, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "KhoiVi.Vuong@gmail.com", "Tăng Gia Khánh", 1, "KHOIVI.VUONG@GMAIL.COM", "KHOIVI.VUONG@GMAIL.COM", "AQAAAAIAAYagAAAAEHxz+sd5i3kkwTiUeyl0dHlakv2fNOlXVl1qhpRUQxWiVqjiTthJ8FlYr5PBGckXuw==", "0249 0167 0546", "acadb231-e6f9-40be-a4ba-7159f78f6ec3", "KhoiVi.Vuong@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "40478 Đặng Expressway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Phi%20%C3%90i%E1%BB%87p", "e38bdd82-874e-4d31-b237-8c93fb83a89a", new DateTime(2004, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "HaNhi.Dinh@hotmail.com", "Trịnh Phi Ðiệp", "HANHI.DINH@HOTMAIL.COM", "HANHI.DINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFyCqO1qQXE65lvIcW6eZQpWCDj583vjaawp2o1RCJStCRBjViLALRMeSaIfq14I8A==", "029 9187 4786", "beda3ce2-0164-4a5d-b144-fac4cd193dc1", "HaNhi.Dinh@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "003 Tăng Island", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20Ch%C3%AD%20Anh", "1553e190-5831-4935-addb-bb7ae4d6d2d7", new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), "QuocThang.Do@hotmail.com", "Nguyễn Chí Anh", 2, "QUOCTHANG.DO@HOTMAIL.COM", "QUOCTHANG.DO@HOTMAIL.COM", "AQAAAAIAAYagAAAAELePmCDnbo7RNiS3uiM6NtUid1VUkznqReviVoOZejlOBhtv+da2qus81ZHA8yqWcQ==", "026 1692 3328", "b57f1585-3ab9-444e-a117-d1f28eae93e5", "QuocThang.Do@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5686 An Nhàn Court", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Lan%20Tr%C3%BAc", "8867c702-46a6-4d4c-b567-cf1c122add70", new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "PhuongUyen_Nguyen62@yahoo.com", "Trịnh Lan Trúc", "PHUONGUYEN_NGUYEN62@YAHOO.COM", "PHUONGUYEN_NGUYEN62@YAHOO.COM", "AQAAAAIAAYagAAAAEBwmGVdqf1bcR7QvKgA1yZva2mln43yDgeOY0vP4mIlBn7ettdpU9h4Id7GWlOJaLg==", "0299 5881 0063", "42d7865c-b071-4607-ab00-c8091cb1e600", "PhuongUyen_Nguyen62@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7717 Lý Shore", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20B%E1%BA%A3o%20Hoa", "8118d052-1ec2-4593-96f9-08e922f65fe0", new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "NgocHue.Tang@hotmail.com", "Phan Bảo Hoa", 2, "NGOCHUE.TANG@HOTMAIL.COM", "NGOCHUE.TANG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEINQ7UhxO8kNQ81NyLSleJw8LIqgl/3UsWb+Yju26WPOp34ckTxaPXTAHQ3snxOALw==", "0283 3153 7422", "77af97ea-2d5e-4f20-8e8b-e88d8705f243", "NgocHue.Tang@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "277 Kim Ly Walks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20Kh%C3%A1nh%20Huy%E1%BB%81n", "ec7189cd-08f8-4f64-9fbc-8c40e06979d3", new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "ThaiLam_To@hotmail.com", "Đào Khánh Huyền", 2, "THAILAM_TO@HOTMAIL.COM", "THAILAM_TO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBIXWAmyc61xhZRDalcG/YvhFy2Uxtj49dtm7kFAh6sbiI8YtQnD6Mv6uXgVnjKz+A==", "025 7053 4079", "a7dfe8d2-d41e-48ec-95ce-ed12040f9d7b", "ThaiLam_To@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9979 Nhật Huy Branch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20T%C3%B9ng%20Quang", "587c9cdf-d2d5-46e0-9713-c1a990a0dc4a", new DateTime(2006, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "AnhTu_Ho@gmail.com", "Lý Tùng Quang", "ANHTU_HO@GMAIL.COM", "ANHTU_HO@GMAIL.COM", "AQAAAAIAAYagAAAAELATSYVfgm68DF+SM3a0+F7I92bZJhRa5apcWWU8KBI5fdeRjkVQXNEccaYTgbsrRg==", "0239 6584 2911", "fa6d71b9-6ee8-40df-881e-4e8520453c60", "AnhTu_Ho@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "342 Trần Lake", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Vi%E1%BB%87t%20Mi", "494e2ab8-a9b6-4712-bfbb-10e01f522179", new DateTime(2007, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "DanhSon.Trinh@yahoo.com", "Dương Việt Mi", 3, "DANHSON.TRINH@YAHOO.COM", "DANHSON.TRINH@YAHOO.COM", "AQAAAAIAAYagAAAAEEw3A5fJ+jOCh8aZvjNZpOYBGTFvN1B5hZjVzfAAcFrmkDxxEVynaxSUh68SRWCg1g==", "0269 7777 1632", "822cfddc-e996-411d-9a27-5fdb98160c06", "DanhSon.Trinh@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7500 Bùi Springs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20L%E1%BB%87%20Qu%C3%A2n", "bbc09795-7e5d-4887-8178-a61a5e34b87a", new DateTime(2018, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "BichLoan.Ho@yahoo.com", "Hà Lệ Quân", 2, "BICHLOAN.HO@YAHOO.COM", "BICHLOAN.HO@YAHOO.COM", "AQAAAAIAAYagAAAAEDFD7ZtWqdWMda2koExIIc6qBf/JZPzku0KBaxToLtQ+c0o9TNNj6I6GBwcufVoRzQ==", "021 3464 3642", "c36c0ede-f976-41fc-b8e1-bc2836fa13f8", "BichLoan.Ho@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "467 Vạn Hạnh Center", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Thu%E1%BA%ADn%20Ph%C6%B0%C6%A1ng", "b92d0b69-9d5f-429c-9248-8d53839e3811", new DateTime(2015, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "HaMy.Mai@gmail.com", "Trương Thuận Phương", "HAMY.MAI@GMAIL.COM", "HAMY.MAI@GMAIL.COM", "AQAAAAIAAYagAAAAEHbUTyDsTRtyKeeF238KgS9AoRnJtwSMY2/qqWMeHpTxnWJgKAE8RLBpKr6Aq6XUrw==", "023 3155 7006", "7af37cc9-e65b-4110-b778-d79d8622e51d", "HaMy.Mai@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "79122 Phúc Ðiền Mountain", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20H%E1%BA%A3i%20Th%E1%BB%A5y", "2e602fe1-8ae5-4412-b99f-7dde95bbca29", new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "HanhNhon96@yahoo.com", "Trương Hải Thụy", "HANHNHON96@YAHOO.COM", "HANHNHON96@YAHOO.COM", "AQAAAAIAAYagAAAAEBvUX8q70XNe5D6wG1ED+6+iF9+q6qxnSqxCK5GdbMM0sRsWFNDLhuaqiffgOCISxQ==", "024 7095 0389", "95245f52-4246-4172-bb5f-6b394832ae65", "HanhNhon96@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "47785 Quang Anh Manor", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Trung%20Hi%E1%BA%BFu", "5bd5add2-cf5a-4ad9-b773-1218a8c9eda9", new DateTime(1996, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "TuDong_Phung64@hotmail.com", "Bùi Trung Hiếu", 1, "TUDONG_PHUNG64@HOTMAIL.COM", "TUDONG_PHUNG64@HOTMAIL.COM", "AQAAAAIAAYagAAAAELUru/wGPYJ2ODWGneDZRfkPhAZJYnhF0Fde75EsnJgtOT2ueagWrVQFWX0mTmRwMg==", "0253 3098 2615", "2d81723d-354a-4ab0-93d1-d1f1f49df042", "TuDong_Phung64@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "53318 Tuyết Lâm Village", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20T%C3%BA%20Quy%C3%AAn", "ecdd7f95-ccc2-4539-a368-1aba457638bf", new DateTime(2024, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "UyenTram_Vuong22@hotmail.com", "Vương Tú Quyên", 1, "UYENTRAM_VUONG22@HOTMAIL.COM", "UYENTRAM_VUONG22@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMsjMp//kG3eoU35RrVnpv0RdrrVtA9jTxZpsXThJoCUCTJF1NZu44VvKMat27epNw==", "0290 0020 9720", "9178113b-1e9b-45a1-b970-650a0b0036c3", "UyenTram_Vuong22@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3226 Hoàng Shore", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20%C4%90%C3%B4ng%20Tr%C3%A0", "19d38330-5d51-4948-9220-56d974c3fc54", new DateTime(2014, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "ThuyHang.Ho@yahoo.com", "Bùi Đông Trà", "THUYHANG.HO@YAHOO.COM", "THUYHANG.HO@YAHOO.COM", "AQAAAAIAAYagAAAAEHjMn20S4dWDSg82DhQMhb6eSRrkB3D2H9WVHm/d5Y3Gmcxl44OBBJOSoRfhACvT2g==", "0255 5915 8423", "a19d0874-9c70-491c-ad79-e35f64e61b37", "ThuyHang.Ho@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "28714 Nguyễn Circle", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Kh%C3%A1nh%20Ly", "d4d9b62b-4a4a-4a51-ad28-00d77df1703d", new DateTime(2008, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "TienDung.Tang47@yahoo.com", "Phạm Khánh Ly", "TIENDUNG.TANG47@YAHOO.COM", "TIENDUNG.TANG47@YAHOO.COM", "AQAAAAIAAYagAAAAEC4JfsIt0pOzot0nOLl8J4u02VNhQ08PjPBeHFRHVHf/8F/2G1Neq59QROtPefwmqQ==", "0245 5927 3393", "af576b8c-bb4b-4193-8849-e69321dbd66e", "TienDung.Tang47@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "39654 Hạc Cúc Station", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Trung%20L%E1%BB%B1c", "938c260d-8c13-422d-a5f3-ec32865d4c4b", new DateTime(1996, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "DuyKhanh_Dang@gmail.com", "Trịnh Trung Lực", 2, "DUYKHANH_DANG@GMAIL.COM", "DUYKHANH_DANG@GMAIL.COM", "AQAAAAIAAYagAAAAEB/Jo6VwCxfaG+/dJgOtb+cJ20TkbX4LjQMe3SYwKrhEgQEQtdpYFgT3Ioafun46bg==", "0285 4760 7247", "76f1a612-3ea6-46ff-ab98-8c069eca434e", "DuyKhanh_Dang@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "491 Trương Pine", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Thu%20Giang", "590d6734-ed1d-4274-a905-6687a01098c4", new DateTime(2013, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "MinhTan74@gmail.com", "Ngô Thu Giang", 2, "MINHTAN74@GMAIL.COM", "MINHTAN74@GMAIL.COM", "AQAAAAIAAYagAAAAEGfWhZX4QldNTqjhV0uhGVIA+fAjaipAxhE0yRn2vnQ1Q3vYPnnb9Acrn6LBVU9M5w==", "029 7474 0461", "0d22346b-6345-485c-a831-4905758830ad", "MinhTan74@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "269 Lam Tuyền Camp", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Ph%C3%BAc%20C%C6%B0%E1%BB%9Dng", "91580804-0fec-40eb-af18-d73040004d47", new DateTime(2000, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "BinhNguyen.Vu62@hotmail.com", "Tô Phúc Cường", "BINHNGUYEN.VU62@HOTMAIL.COM", "BINHNGUYEN.VU62@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGnDXzW4KQkcZXSNcdj7kke5fiY26MHmSDptfSZlLc9IsXd9gnZAABL5fBFTu9yZ2g==", "0268 6777 6080", "c8bb8e1a-1226-45e2-be41-dc8cfd7a5733", "BinhNguyen.Vu62@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1432 Xuân Lan Stravenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Li%C3%AAn%20Ki%E1%BB%87t", "5cdb21a3-9200-4c11-b871-77a5ce7a3492", new DateTime(1999, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "NgocQue.Ly16@hotmail.com", "Hồ Liên Kiệt", 2, "NGOCQUE.LY16@HOTMAIL.COM", "NGOCQUE.LY16@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHdFuOyAFDPiT7NMDABOEcDmMkU3BtDf8swp5SBI72MoDy6lNBeeD4wEFybqNvvN7Q==", "0229 8130 2871", "7b3da495-66cc-4b24-9e4e-9f7e1e49e4ee", "NgocQue.Ly16@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "87346 Hoàng Avenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Thi%20Y%E1%BA%BFn", "5daebea6-690f-4ae7-8a3d-534598c733cd", new DateTime(2005, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "MaiChi23@hotmail.com", "Tô Thi Yến", "MAICHI23@HOTMAIL.COM", "MAICHI23@HOTMAIL.COM", "AQAAAAIAAYagAAAAEC5lOBo80dowmhe5oh5dxssPNpi8H5awtHzb6laPEz1vFOAkiMVIdaqx7eMYB12T1g==", "020 5042 2538", "4ac16cf3-96c1-4ee6-b1bb-b01d2cd3799b", "MaiChi23@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "296 Trương Plain", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20L%E1%BB%99c%20Uy%E1%BB%83n", "8bd75e2e-3889-4e23-b708-515f6fde818b", new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "LinhLan_Ngo76@yahoo.com", "Hồ Lộc Uyển", 3, "LINHLAN_NGO76@YAHOO.COM", "LINHLAN_NGO76@YAHOO.COM", "AQAAAAIAAYagAAAAEO8sIg64g53UWCQrW+wpKl2eidvo49xPqMPX7iPZmnajDqYrMQCuKSvsIa4IPhdpCw==", "0209 0921 0148", "1143b690-1b92-43de-83fd-7c021afb778d", "LinhLan_Ngo76@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8149 Hoài Việt Mews", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20C%C3%B4ng%20L%E1%BB%99c", "e320b041-ea08-4dd7-abf5-995e10d18264", new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "TrungLuc50@gmail.com", "Phùng Công Lộc", 2, "TRUNGLUC50@GMAIL.COM", "TRUNGLUC50@GMAIL.COM", "AQAAAAIAAYagAAAAEKY1P/8q/lQw3rtKx6LLGzmOtMyOdYAx1ONFLQ5dupSxW8SR27FlxfIcV8OHfvlzDA==", "022 1606 4472", "89a47352-0d30-4901-8298-26931527f57f", "TrungLuc50@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "72404 Nguyễn Hills", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20Minh%20Qu%E1%BB%91c", "9f6784f2-550f-46dd-8e2f-1e86a8cfe9c4", new DateTime(2006, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), "DucToan.Pham21@gmail.com", "Phan Minh Quốc", 3, "DUCTOAN.PHAM21@GMAIL.COM", "DUCTOAN.PHAM21@GMAIL.COM", "AQAAAAIAAYagAAAAEBD64GYLyliU3epXtApsWFsLsOZVFubzEQkXni+Wot0N8S7pNN6g+Bl10ucckVHwwQ==", "0247 5992 8227", "9706a332-5f19-436b-94e1-368a9c590697", "DucToan.Pham21@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "49179 Vàng Anh Ridges", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Ng%E1%BB%8Dc%20Uy%C3%AAn", "a6db5286-93da-462d-a048-d80b55fa491c", new DateTime(2005, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "TruongVinh_Do93@gmail.com", "Hồ Ngọc Uyên", 2, "TRUONGVINH_DO93@GMAIL.COM", "TRUONGVINH_DO93@GMAIL.COM", "AQAAAAIAAYagAAAAEEl+bvieCpuIemWNdXyBq3XScT/e46XBSNxPu7Um+aFh+8nRbh4udgDaMdy+rcc0xw==", "023 3553 7506", "85e77826-e160-4e51-a384-36806fda31a8", "TruongVinh_Do93@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0730 Bình Yên Ramp", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20T%E1%BB%AB%20Dung", "ef3da698-bf84-4c1c-a7e4-2aef5a9b9cd0", new DateTime(2011, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "AnhViet_Vuong@yahoo.com", "Vương Từ Dung", 2, "ANHVIET_VUONG@YAHOO.COM", "ANHVIET_VUONG@YAHOO.COM", "AQAAAAIAAYagAAAAEBTIgoZ1ua4v3ZxOgFCLQ70KW4nHyf7J4uPE7O0StFdx7zMLiOZ0BOm+PNPIG0jceQ==", "0296 4102 5710", "0d30da6d-b399-4ab0-8308-a44a88dd3ccd", "AnhViet_Vuong@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "08359 Đặng Bypass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Th%C3%A0nh%20Long", "2568caf7-5b6b-400f-ab71-f6977dc30187", new DateTime(2015, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "DuyenMy44@gmail.com", "Dương Thành Long", "DUYENMY44@GMAIL.COM", "DUYENMY44@GMAIL.COM", "AQAAAAIAAYagAAAAEAkl5jEBkJ6XnvUaX3jJNg56RrROnIMOKNvH0ij3MFqpK636SoVmIW5H4Rdus95i1A==", "028 5722 3381", "60644237-0a0c-47c5-9f9f-8c0deca2675a", "DuyenMy44@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "76362 Phan Branch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Kh%C3%A1nh%20My", "2c2dcf2b-38af-4b12-87c2-b20727ea4d52", new DateTime(1997, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), "DuyHung.Dao44@yahoo.com", "Dương Khánh My", 1, "DUYHUNG.DAO44@YAHOO.COM", "DUYHUNG.DAO44@YAHOO.COM", "AQAAAAIAAYagAAAAELiUBtIelRi2hFtpDnFVxJYq6CpS/uUbu7OWQIG3jpIwt//wl5KbERgR2u/SfLtQDQ==", "0207 0630 2029", "32805932-5f76-4f74-8131-7fc756497a98", "DuyHung.Dao44@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8944 Vương Plain", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Ph%C6%B0%C6%A1ng%20Ng%E1%BB%8Dc", "ada7a9eb-e648-4496-986c-bd7e1df31f10", new DateTime(2017, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "HuongLan90@gmail.com", "Mai Phương Ngọc", "HUONGLAN90@GMAIL.COM", "HUONGLAN90@GMAIL.COM", "AQAAAAIAAYagAAAAEJDO2fU0EC0TbQQEkU+plzuL43b5VCmw17CLVpXwqfsAzUZjsskQhOoaegxWsAPo9w==", "025 5246 2969", "f35d0ae7-ef10-4e64-a79e-1b80132d3349", "HuongLan90@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "808 Đặng Route", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Trung%20Anh", "3194fccd-ac9a-45ec-af22-10a3380798e0", new DateTime(2012, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), "MinhDanh60@yahoo.com", "Trương Trung Anh", 1, "MINHDANH60@YAHOO.COM", "MINHDANH60@YAHOO.COM", "AQAAAAIAAYagAAAAEL6rU4qj+TfwDZaeovnC0QbGhtMKAFUtMvhnDXGgmJ5wX1RfNLHu6I+eFItQnYMmdw==", "0261 5942 9614", "5e5b41ad-1ff5-463f-9861-35419586c63c", "MinhDanh60@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "138 Trương Burgs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20H%E1%BA%A3i%20M%E1%BB%B9", "31c7ed53-6963-4c9c-981d-c1cde0de4c3f", new DateTime(2009, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "HongQuy_Doan@gmail.com", "Hà Hải Mỹ", 1, "HONGQUY_DOAN@GMAIL.COM", "HONGQUY_DOAN@GMAIL.COM", "AQAAAAIAAYagAAAAEAJwAk++gzQauZnW0x70jYMbd4hJK0xLo6xW6/HXWwb73XKcxlv8HuKK7M/sBJO27A==", "0271 4609 0860", "713265c1-71a0-4619-938c-e2d382a497ad", "HongQuy_Doan@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "339 Đặng Square", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20Gia%20Phong", "54e0334f-75f6-4040-aa25-ca55c5502318", new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "ThuyOanh.Dinh7@gmail.com", "Đoàn Gia Phong", 2, "THUYOANH.DINH7@GMAIL.COM", "THUYOANH.DINH7@GMAIL.COM", "AQAAAAIAAYagAAAAEEzrekwC57Z5F+m1+MttC4tl+ybp1smKEJuFKT/VDMtCyGOaJ0IeKcgMQF8JtPlFHA==", "0247 4918 6350", "8d87cb21-22e0-4767-b4bf-9dfa447cd081", "ThuyOanh.Dinh7@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "469 Trần Underpass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20M%E1%BB%99ng%20Thu", "e7e5b402-110f-438e-b58b-84b1071de965", new DateTime(2001, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "TuDung_Phung@hotmail.com", "Mai Mộng Thu", "TUDUNG_PHUNG@HOTMAIL.COM", "TUDUNG_PHUNG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHJY0+3qZERahgNJOezZcGZ19BVd0Ipklqu++FlcGfyagCXFb/vlpyMHTpcPLPLTpg==", "0217 7399 1923", "e3c8ba69-368f-4259-b0dd-f016e9bf74f2", "TuDung_Phung@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8340 Lâm Brook", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20H%E1%BA%A1o%20Nhi%C3%AAn", "64c44479-bc7f-4169-8c11-7c17613290e3", new DateTime(1997, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "QuocThanh66@gmail.com", "Đỗ Hạo Nhiên", 3, "QUOCTHANH66@GMAIL.COM", "QUOCTHANH66@GMAIL.COM", "AQAAAAIAAYagAAAAEMpgSLXkcjjzTnSWATF06nh6q8WGrbuWvx9Vcgbxxt9FOweuYuxPiOOPZn6cdl7plg==", "0230 6753 2788", "d091cb81-4761-461c-8d81-a785a65f572b", "QuocThanh66@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5040 Anh Ðức Oval", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Phi%20H%C3%B9ng", "8d569cca-a5e7-4062-84b3-7a99dac0153c", new DateTime(2005, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), "KimDuyen_Ha@hotmail.com", "Phạm Phi Hùng", "KIMDUYEN_HA@HOTMAIL.COM", "KIMDUYEN_HA@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKVUPUM+WbzJYBjWfhsdQOau7/0dY+R/PRlUShFOHuaeYbkK2C4evLZ+KBqgUE1Edw==", "023 8525 9845", "112330e3-9692-459f-a2b7-7dac63abf65c", "KimDuyen_Ha@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "900 Đoàn Alley", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Di%E1%BB%85m%20H%E1%BA%B1ng", "56255224-f0ea-4e21-ab9e-dce877f32813", new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), "BichThuy_Doan@yahoo.com", "Lê Diễm Hằng", 1, "BICHTHUY_DOAN@YAHOO.COM", "BICHTHUY_DOAN@YAHOO.COM", "AQAAAAIAAYagAAAAELDez435Wq5rWApfOg1q9AiDM75zKFXN+ueiV1hC7yt5QDfyD0AIlM83DBQaoTYd9A==", "028 3034 5994", "4e18f6a1-f95b-4fcb-b445-8de887dfdde2", "BichThuy_Doan@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "19495 Mai Common", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Th%E1%BB%A5y%20Tr%C3%A2m", "57fd1244-e356-4b6d-9646-5438a78c77df", new DateTime(1998, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), "ThanhVan.Bui@gmail.com", "Lý Thụy Trâm", "THANHVAN.BUI@GMAIL.COM", "THANHVAN.BUI@GMAIL.COM", "AQAAAAIAAYagAAAAEBOx7qlnfA0bth2wY7nu7zhh4iWEE9X+0NRZVT94kSzu8vBfUz1+D5ELInKfvNq9HA==", "0231 2108 7849", "0e25bc00-75be-4063-b666-f11185c609d7", "ThanhVan.Bui@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "29036 Vân Chi Fords", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Thu%20Thu%E1%BA%ADn", "70b4c2e8-a877-412a-9fdd-6b1c2c33c4f5", new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "VanMinh_Tang@hotmail.com", "Trịnh Thu Thuận", "VANMINH_TANG@HOTMAIL.COM", "VANMINH_TANG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKkSvdGskoiBpQPw6BSITy5DQW07Feb2gzdFgae3GVU28qLbW1AcZzcLyA9KpDw05Q==", "0206 0743 2060", "19a74282-7d0c-4b43-aaca-d5674f39133f", "VanMinh_Tang@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "24116 Bích Phượng Mill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20Gia%20H%C3%A2n", "d9134f66-9412-4b5f-a1c3-7ff28fe5fc5d", new DateTime(1995, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), "ChienThang26@hotmail.com", "Trần Gia Hân", 1, "CHIENTHANG26@HOTMAIL.COM", "CHIENTHANG26@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFZVzwq8y/Q9mJqzCIUqVjUgqIAdRUHgguExgC2s9thZHPdBRQXb4pxhU/sQb+vtbg==", "028 5892 7124", "674ba1b2-b126-49e9-8f83-23bf21eebc6f", "ChienThang26@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9722 Lý Key", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Trung%20H%E1%BA%A3i", "0f89e3ea-c2ce-4890-9e68-9bbbaf62ed7b", new DateTime(2001, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "GiaPhong_Tran@yahoo.com", "Đặng Trung Hải", "GIAPHONG_TRAN@YAHOO.COM", "GIAPHONG_TRAN@YAHOO.COM", "AQAAAAIAAYagAAAAEMSACmMCAWDvzVnsK0dIP4NNkHslUnBkiiYAAl382QMC9NBeF8qQvn1lgzIsNvqY/g==", "0228 4461 3649", "bf435262-8761-4f5e-9ff0-21633a6281c2", "GiaPhong_Tran@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2955 Nhật Lan Unions", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20Di%E1%BB%87u%20H%E1%BA%A1nh", "a8060ee3-6d9f-42f1-bb0e-90bc3130163a", new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), "HuynhAnh.Bui58@gmail.com", "Trần Diệu Hạnh", 1, "HUYNHANH.BUI58@GMAIL.COM", "HUYNHANH.BUI58@GMAIL.COM", "AQAAAAIAAYagAAAAEG7mnW1smh2873C/utY19M8qfGfG9g4Wn4VuIgypeve7W9eK2Rml4w2CyoN+ybmQOA==", "025 3083 9872", "8a18377f-4b4e-42c1-8fd0-8727f6e87239", "HuynhAnh.Bui58@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4192 Tăng Circle", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Gia%20%C3%82n", "452a63d2-13ec-44a8-bf2f-2689ffbcbace", new DateTime(2016, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "NguyetMinh.Hoang@hotmail.com", "Tăng Gia Ân", 2, "NGUYETMINH.HOANG@HOTMAIL.COM", "NGUYETMINH.HOANG@HOTMAIL.COM", "AQAAAAIAAYagAAAAENMurj2S1txjWRkKMpG8cPwDsZMXn8dSRu+VDENdsxVaLEznnuRhuJvhvki0pqPT9g==", "026 1476 9628", "380c8d52-f490-43af-b15c-c9f1792a038c", "NguyetMinh.Hoang@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "625 Lê Ramp", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20H%E1%BB%8Da%20Mi", "59a14830-0838-4c7c-ac2c-92febb59cd54", new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "VanLy_Ly97@gmail.com", "Đỗ Họa Mi", "VANLY_LY97@GMAIL.COM", "VANLY_LY97@GMAIL.COM", "AQAAAAIAAYagAAAAEP+gjyald7A9NUPCx9oElSHdMxec9mvO2lkrtwfPNBal7mZ4QhrHM7K7+UZRJo9Oow==", "024 5562 7611", "26c0bd96-17d3-400b-9e65-cadb6da71df9", "VanLy_Ly97@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "350 Xuân Ninh Junction", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20M%E1%BB%B9%20Lan", "ad574b93-d19a-44fd-a5f3-581af7ce007b", new DateTime(2000, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "CamLinh.Doan42@gmail.com", "Mai Mỹ Lan", 2, "CAMLINH.DOAN42@GMAIL.COM", "CAMLINH.DOAN42@GMAIL.COM", "AQAAAAIAAYagAAAAECRtbztTz2IlKbimaF+4nXjwDtaUOMf2QvpDw3/Xgs0ya1llFddI5FCQETKrTnhgrg==", "021 1527 5352", "9a91a101-dd3b-4a84-b5da-af055926580e", "CamLinh.Doan42@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6229 Tô Freeway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20V%C3%A2n%20Ng%E1%BB%8Dc", "15e6f9ff-28ed-4d3f-8428-e2c71cd02599", new DateTime(1996, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "QuangKhai_Dao95@gmail.com", "Lâm Vân Ngọc", "QUANGKHAI_DAO95@GMAIL.COM", "QUANGKHAI_DAO95@GMAIL.COM", "AQAAAAIAAYagAAAAEGUi1eevMzUfS9e54LAJxlWvsu8jhs0lYimsMwDw3z62jcUJZP6J6sjpsb3H5f4LVw==", "020 3641 7968", "64b1dc82-01eb-46c8-9c98-38e8d3fd32b1", "QuangKhai_Dao95@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "107 Anh Vũ Ports", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Kh%E1%BA%AFc%20Vi%E1%BB%87t", "a36c9cf3-7bcd-4826-ad64-9984ab8f4bdf", new DateTime(2001, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "MocMien_Dao51@hotmail.com", "Đinh Khắc Việt", "MOCMIEN_DAO51@HOTMAIL.COM", "MOCMIEN_DAO51@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFiZDN2HQwrteKvE8HFrgD6fd1vtXMMzsZbUa1FXloGsoQJwKMMaY7+BLFVpF+38Ag==", "029 4627 6927", "5ca28de0-e055-4c00-9c3f-4239bfc1ad45", "MocMien_Dao51@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "95959 Trần Crescent", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20%C3%81nh%20Nguy%E1%BB%87t", "4b6518dc-5983-4b84-8c5d-4066a1470ff9", new DateTime(2015, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "NgocQuyen.Dao@gmail.com", "Phùng Ánh Nguyệt", 3, "NGOCQUYEN.DAO@GMAIL.COM", "NGOCQUYEN.DAO@GMAIL.COM", "AQAAAAIAAYagAAAAEGHi9PCUeJeGwLBDZnK1/waWN62U096bIB9tpb00DeTNGuu6Wbes0Eyrg5hW7es3Tw==", "026 8470 6037", "4104bffb-fb73-4de5-b525-0eaf34298a03", "NgocQuyen.Dao@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6297 Nhã Khanh Pines", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Thanh%20T%C3%B9ng", "6d0d583d-ce52-4461-a485-7a9b05c69e3e", new DateTime(2011, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "MongThi98@gmail.com", "Trương Thanh Tùng", 1, "MONGTHI98@GMAIL.COM", "MONGTHI98@GMAIL.COM", "AQAAAAIAAYagAAAAEO5rMvWK+elbQ4m1dhqmIpUYGf6oJ45e6vt8rF72T7DpTAnOb7RTQU4GspTIKFDvjA==", "026 0710 6205", "63ce09ad-1ed1-4266-8543-bd38bd77b70c", "MongThi98@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "024 Đinh Dam", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Phi%20Khanh", "564def9b-ae6e-4222-b950-b13b443657af", new DateTime(1997, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "VinhDieu75@yahoo.com", "Mai Phi Khanh", 3, "VINHDIEU75@YAHOO.COM", "VINHDIEU75@YAHOO.COM", "AQAAAAIAAYagAAAAEBPHwvZFW3Y8viWMVdpbUtKVAkNqgGW59hO8y1L990TK1dDiL88InLSHUGuUN6H1ag==", "0274 4423 2234", "f21e4501-cad4-4fe0-aeb0-44750507ccc3", "VinhDieu75@yahoo.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Appointments");

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 9, 0, 0, 0), 100, new TimeSpan(0, 8, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), 3, 78 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 14, 0, 0, 0), 1, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 18, 0, 0, 0), 35, new TimeSpan(0, 17, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 15, 0, 0, 0), 46, new TimeSpan(0, 14, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 9, 0, 0, 0), 40, new TimeSpan(0, 8, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 17, 0, 0, 0), 60, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 14, 0, 0, 0), 23, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 11, 0, 0, 0), 70, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), 10, 60, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 10, 0, 0, 0), 84, new TimeSpan(0, 9, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), 37, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 9, 0, 0, 0), 13, new TimeSpan(0, 8, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 0, 0, 0), 82, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), 69, new TimeSpan(0, 15, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 18, 0, 0, 0), 31, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 11, 0, 0, 0), 100, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 14, 0, 0, 0), 63, new TimeSpan(0, 13, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, 55 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 7, 101, 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 0, 0, 0), 101, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 15, 0, 0, 0), 87, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 11, 0, 0, 0), 78, new TimeSpan(0, 10, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 18, 0, 0, 0), 73, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), 44, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 11, 0, 0, 0), 6, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), 17, new TimeSpan(0, 10, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 0, 0, 0), 95, new TimeSpan(0, 9, 0, 0, 0) });

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
                columns: new[] { "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { 9, new TimeSpan(0, 16, 0, 0, 0), 75, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 10, 0, 0, 0), 77, new TimeSpan(0, 9, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 17, 0, 0, 0), 48, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 13, 55, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 9, 0, 0, 0), 15, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), 18, 39, 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 9, 0, 0, 0), 26, new TimeSpan(0, 8, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), 56, new TimeSpan(0, 14, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 11, 39, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), 76, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), 47, new TimeSpan(0, 13, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 12, 75, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), 23, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 17, 0, 0, 0), 80, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), 10, 60, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 0, 0, 0), 6, new TimeSpan(0, 11, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), 58, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), 23, new TimeSpan(0, 10, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 18, 0, 0, 0), 49, new TimeSpan(0, 17, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 15, 0, 0, 0), 25, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 3, 57, 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 16, 0, 0, 0), 48, new TimeSpan(0, 15, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), 17, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), 4, 47, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 12, 0, 0, 0), 60, new TimeSpan(0, 11, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 10, 0, 0, 0), 65, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 15, 0, 0, 0), 4, new TimeSpan(0, 14, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 10, 56, 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), 18, 12, 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 0, 0, 0), 47, new TimeSpan(0, 9, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), 4, 70, 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), 2, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), 12, 61, 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), 7, 61, 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), 12, 3, 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 15, 0, 0, 0), 44, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 9, 0, 0, 0), 32, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 12, 0, 0, 0), 44, new TimeSpan(0, 11, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 18, 0, 0, 0), 82, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), 48, new TimeSpan(0, 10, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 13, 0, 0, 0), 2, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), 41, new TimeSpan(0, 12, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 13, 0, 0, 0), 26, new TimeSpan(0, 12, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), 56, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), 9, 80 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 0, 0, 0), 82, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), 17, 76, 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 17, 62, 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 11, 0, 0, 0), 27, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 18, 0, 0, 0), 20, new TimeSpan(0, 17, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 11, 0, 0, 0), 73, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 0, 0, 0), 64, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 11, 0, 0, 0), 95, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 17, 0, 0, 0), 6, new TimeSpan(0, 16, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 13, 0, 0, 0), 57, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), 42, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), 91, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), 3, 3, 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 9, 0, 0, 0), 97, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), 19, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 14, 0, 0, 0), 72, new TimeSpan(0, 13, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 12, 0, 0, 0), 31, new TimeSpan(0, 11, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 14, 0, 0, 0), 22, new TimeSpan(0, 13, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 10, 0, 0, 0), 99, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 17, 0, 0, 0), 72, new TimeSpan(0, 16, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), 56, new TimeSpan(0, 17, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 11, 0, 0, 0), 42, new TimeSpan(0, 10, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), 20, 70, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 13, 0, 0, 0), 79, new TimeSpan(0, 12, 0, 0, 0) });

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

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 10, 0, 0, 0), 36, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), 60, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), 86, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 9, 0, 0, 0), 53, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 16, 0, 0, 0), 11, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), 9, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 14, 0, 0, 0), 48, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 14, 0, 0, 0), 41, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { 3, new TimeSpan(0, 15, 0, 0, 0), 37, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), 57, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 0, 0, 0), 73, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId" },
                values: new object[] { new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 16, 98 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), 88, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 11, 0, 0, 0), 98, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 17, 0, 0, 0), 64, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 11, 0, 0, 0), 19, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), 55, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), 27, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 5, 30, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 14, 0, 0, 0), 55, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 9, 0, 0, 0), 32, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 18, 0, 0, 0), 57, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), 16, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 15, 0, 0, 0), 16, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), 48, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 12, 0, 0, 0), 54, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 17, 0, 0, 0), 23, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), 2, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 17, 0, 0, 0), 77, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), 94, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), 9, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 13, 0, 0, 0), 45, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 0, 0, 0), 44, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 14, 0, 0, 0), 32, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 18, 0, 0, 0), 75, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), 9, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 0, 0, 0), 34, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 12, 0, 0, 0), 9, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 10, 0, 0, 0), 25, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), 13, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), 7, 35, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 11, 0, 0, 0), 51, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 13, 0, 0, 0), 40, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 9, 0, 0, 0), 95, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), 97, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 11, 0, 0, 0), 85, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), 72, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), 58, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), 16, 16, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 16, 0, 0, 0), 94, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 13, 0, 0, 0), 90, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 12, 0, 0, 0), 42, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 10, 0, 0, 0), 84, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 6, 53, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 14, 0, 0, 0), 62, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 9, 0, 0, 0), 90, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), 93, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 16, 0, 0, 0), 46, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 14, 0, 0, 0), 92, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), 7, 45, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), 55, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 9, 0, 0, 0), 53, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 17, 0, 0, 0), 92, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 18, 0, 0, 0), 85, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), 16, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), 72, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 13, 0, 0, 0), 96, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), 90, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AppointmentDate", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 64, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 12, 0, 0, 0), 55, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 9, 0, 0, 0), 58, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 13, 0, 0, 0), 83, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 12, 0, 0, 0), 49, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 10, 0, 0, 0), 28, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), 80, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 11, 0, 0, 0), 84, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 0, 0, 0), 10, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), 9, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 17, 0, 0, 0), 3, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 16, 0, 0, 0), 66, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), 15, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), 75, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 9, 0, 0, 0), 32, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 18, 0, 0, 0), 76, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), 51, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 9, 0, 0, 0), 67, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 13, 0, 0, 0), 92, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AppointmentDate", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), 46, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 11, 0, 0, 0), 39, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), 8, 25, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), 22, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AppointmentDate", "DoctorId", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 18, 85, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 17, 0, 0, 0), 63, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), 79, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), 39, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 18, 0, 0, 0), 9, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), 61, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 16, 0, 0, 0), 93, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), 12, new TimeSpan(0, 8, 0, 0, 0), 4 });

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
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 3 năm trong lĩnh vực Nhi khoa", 5, 3 });

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
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Nhi khoa", 5, 9 });

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
                columns: new[] { "About", "Specialization" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Nhi khoa", 5 });

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
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Tim mạch", 2, 6 });

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
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Tim mạch", 2, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Nhi khoa", 5, 4 });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "36999 Hướng Tiền Shoals", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Ho%C3%A0ng%20H%C3%A0", "1aee3631-b228-41bf-b6a9-5c7a33605c34", new DateTime(2016, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "BichHien.Truong41@hotmail.com", "Phạm Hoàng Hà", "BICHHIEN.TRUONG41@HOTMAIL.COM", "BICHHIEN.TRUONG41@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDHEf1jyu2GQTurL+/H2vjA+A57htJp2/TAxxr+tp6DVyfVW8Od33DLAE/60Itjm2A==", "0286 0281 2685", "1cd206b2-2f7a-47b5-bf26-e87546252a3e", "BichHien.Truong41@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5757 Ngô Loaf", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Cao%20S%E1%BB%B9", "49fa8f3c-c430-42e5-885d-c522fd0c5219", new DateTime(2014, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "DongNghi.Ha@yahoo.com", "Mai Cao Sỹ", "DONGNGHI.HA@YAHOO.COM", "DONGNGHI.HA@YAHOO.COM", "AQAAAAIAAYagAAAAECFwFOybIf2Ct5jfGGIX9mFf3WhuaJcxAqi5SWykNC94SA1t94/kUmaNL1EROktwhg==", "0297 1154 2479", "b9e1ba6f-32b2-4f11-936e-7328e4228dd0", "DongNghi.Ha@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "508 Hạnh Chi Burgs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Anh%20Tu%E1%BA%A5n", "85bfefa4-d352-4127-a46d-80a893a88562", new DateTime(2017, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), "DangQuang_Ly18@yahoo.com", "Đinh Anh Tuấn", "DANGQUANG_LY18@YAHOO.COM", "DANGQUANG_LY18@YAHOO.COM", "AQAAAAIAAYagAAAAEEgyHBO3EK8oYVvHsZU+yHv//WhQdCoKEMl0pjf7KHJhXtYVo5jy5rWYb/sr8hdi9A==", "0248 3951 3396", "e53309f2-fb18-49d1-8b73-7d1331eee230", "DangQuang_Ly18@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "611 Hà Lakes", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Qu%E1%BB%91c%20Ti%E1%BA%BFn", "8cd2e851-879a-41ad-8a98-17d74075c6db", new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "HoaiThanh40@hotmail.com", "Trương Quốc Tiến", 3, "HOAITHANH40@HOTMAIL.COM", "HOAITHANH40@HOTMAIL.COM", "AQAAAAIAAYagAAAAEM0sW44tbT+ClPnW0Y+uSibIkui4SGNcFC1dt0z+zauYN6HOCaUWDbAENcbPJuO/fg==", "0235 8121 4055", "7ca72c43-77c4-4447-945b-bfa2b4d45ef5", "HoaiThanh40@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "29133 Đinh Knoll", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Duy%20Khi%C3%AAm", "a771d145-ae19-4fa7-a0f5-a67ff9fda4c1", new DateTime(2003, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "KieuHoa_Vuong@gmail.com", "Trương Duy Khiêm", "KIEUHOA_VUONG@GMAIL.COM", "KIEUHOA_VUONG@GMAIL.COM", "AQAAAAIAAYagAAAAEMzv/8MLvjrhOLvyEY67G36BxVXA+eY2zX1jeOMnOXtp2F2i2HTK+d0gt0MUnSo21g==", "024 8167 0941", "8f679d6b-8237-4e9f-adc0-4363fc05b238", "KieuHoa_Vuong@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0349 Trịnh Glens", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Minh%20S%C6%A1n", "54942ece-b7d0-4cba-80bd-ffd2a18f392c", new DateTime(2012, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "ThuyHang.Dang@yahoo.com", "Hồ Minh Sơn", "THUYHANG.DANG@YAHOO.COM", "THUYHANG.DANG@YAHOO.COM", "AQAAAAIAAYagAAAAEKQlDytdGuH9oVwRfbYnXQcuf9wnzrsE4sKmKy56syYVsbYmsoViXP7b9PN5FstnjA==", "027 8147 7823", "3a618d36-15dd-439e-b3d2-1c082e161c5e", "ThuyHang.Dang@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "543 Đoàn Station", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Hi%E1%BB%81n%20H%C3%B2a", "c816b2d5-99ff-4eb2-8893-4fec1cc3e84a", new DateTime(2016, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "TrungThuc_Nguyen@yahoo.com", "Lý Hiền Hòa", "TRUNGTHUC_NGUYEN@YAHOO.COM", "TRUNGTHUC_NGUYEN@YAHOO.COM", "AQAAAAIAAYagAAAAEK85U4pgs2Nm6N7OaAbeuo6VNBHSHRL9lLLXvEE4/aijIwUO87XM6GspigLwmii/gQ==", "0298 4849 8744", "6e44447e-d846-411e-a89c-6415d38a612a", "TrungThuc_Nguyen@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "34083 Minh Vu Divide", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C5%A9%20Thanh%20To%E1%BA%A3n", "7f549ccd-ccad-41bf-970c-59578ddedfeb", new DateTime(2007, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), "NgocHien.Ha@gmail.com", "Vũ Thanh Toản", 1, "NGOCHIEN.HA@GMAIL.COM", "NGOCHIEN.HA@GMAIL.COM", "AQAAAAIAAYagAAAAEAVcjezrx4VZR2uSmWWNqgEhDVbrNYD+jMUz1No/xTjQHd+DbQIBIXDEr9yfiKzmzA==", "022 5778 7889", "83f1795c-64ff-4bd8-84e6-9aed4e1aaca0", "NgocHien.Ha@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "65106 Mỹ Lệ Crest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20%C4%90an%20Linh", "2929159e-1c12-433e-b3e4-3bfd7c0569e4", new DateTime(1997, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "NguyetMinh_Bui@yahoo.com", "Hoàng Đan Linh", 2, "NGUYETMINH_BUI@YAHOO.COM", "NGUYETMINH_BUI@YAHOO.COM", "AQAAAAIAAYagAAAAEOIt/yLHdlcyoL3QzWkokaWPZzf+Qn+LGV6FLOirvmsUbOKhvZG/4WKtwt2l41GJ1w==", "0257 6443 8711", "bcdcf07d-352e-41ec-aaed-adf5284a96f5", "NguyetMinh_Bui@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "635 Lâm Keys", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Th%E1%BB%A7y%20Ti%C3%AAn", "66e78b23-7c17-4558-8537-f48099be7116", new DateTime(2001, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "XuanPhuong83@yahoo.com", "Trương Thủy Tiên", "XUANPHUONG83@YAHOO.COM", "XUANPHUONG83@YAHOO.COM", "AQAAAAIAAYagAAAAELe8wuW863vSpaKl0CZPYKXdaLiOFumD2a88+80EVpy/K/XvbJM8gaI4WEYib97l2A==", "029 8762 5620", "d8b7b51d-e437-42ec-ae1f-78f9d4cc1ef2", "XuanPhuong83@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "685 Đặng Forks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20%C3%90%E1%BB%A9c%20%C3%82n", "6bcbd9a3-6c72-444b-8a61-28661fdbda8b", new DateTime(2014, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "QuangHoa.Doan@gmail.com", "Đỗ Ðức Ân", "QUANGHOA.DOAN@GMAIL.COM", "QUANGHOA.DOAN@GMAIL.COM", "AQAAAAIAAYagAAAAEDRX4tY3cl2locpBniUne03jPtLofG947tLIWVOCCJj2505ECgfnfvE/2mxc/XkO1w==", "025 4403 8605", "30abc9c4-4575-4753-8558-9088b3c0a513", "QuangHoa.Doan@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "27457 Phạm Street", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20B%C3%ADch%20Ng%C3%A2n", "5acf5782-6fef-4020-af78-782b339d412a", new DateTime(2007, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "MinhKhieu_Do26@yahoo.com", "Lê Bích Ngân", "MINHKHIEU_DO26@YAHOO.COM", "MINHKHIEU_DO26@YAHOO.COM", "AQAAAAIAAYagAAAAEI55wn0ArsqPFga4TadXQrHciAlxBPgT0EZHNi8C3z7DGPf3qZNZPduePGKqmXhV+w==", "021 8014 6504", "e0844cc2-a0e6-404e-b731-1e0f83672f51", "MinhKhieu_Do26@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "491 Phú Bình Spring", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Tr%C3%A0%20Giang", "4be14ff8-f841-4736-8ab9-a50bde675229", new DateTime(2004, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "PhuongThi16@yahoo.com", "Đặng Trà Giang", 1, "PHUONGTHI16@YAHOO.COM", "PHUONGTHI16@YAHOO.COM", "AQAAAAIAAYagAAAAEAi+TU3oyvl9l3R5t4xuOt7ntA4+Asb/0vbSzKnRPPVc9wHjfAeXRvdUdmoTA6apYQ==", "021 3277 2228", "1a9a063c-6001-410b-a0d2-3c7d9fd8fd2f", "PhuongThi16@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "467 Lâm Forge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Nam%20An", "191d22a4-1ec8-4476-bbb3-e361e150759f", new DateTime(1995, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "ThaiVan.Hoang33@yahoo.com", "Lê Nam An", 1, "THAIVAN.HOANG33@YAHOO.COM", "THAIVAN.HOANG33@YAHOO.COM", "AQAAAAIAAYagAAAAEC5Ir0ZHyBY87vNZ1Zrdj4PKiBmTxVFRJW4bnLpPBYMG+e56oW9rRomOoSC9wLtlSQ==", "0268 0123 9325", "1c16f395-9349-42c0-bb59-209b7b239b5e", "ThaiVan.Hoang33@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2066 Diệu Lan Hollow", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C5%A9%20Minh%20Tri%E1%BA%BFt", "006ad401-3157-4299-b717-00cfff48626a", new DateTime(2011, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), "MongLam.Ly@hotmail.com", "Vũ Minh Triết", "MONGLAM.LY@HOTMAIL.COM", "MONGLAM.LY@HOTMAIL.COM", "AQAAAAIAAYagAAAAED+p5YGezZckBYP7HOLaG4GQtVmp8JatiU7ychmBTi63QXle7svDFp/tyCcCMJpblw==", "024 9640 6895", "d53d46a6-87a0-4cfc-ba4b-570abd79aea3", "MongLam.Ly@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "80816 Thục Ðình Row", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Minh%20Th%E1%BB%A7y", "110cd24b-f520-4097-a289-9178ca5df4ef", new DateTime(1998, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "HaiThanh_Dang46@yahoo.com", "Đinh Minh Thủy", "HAITHANH_DANG46@YAHOO.COM", "HAITHANH_DANG46@YAHOO.COM", "AQAAAAIAAYagAAAAEJ/tNZYX3aP3xpBgRNRgKm/vt0Nv8QS0g5RSb08sX6lRKP4+xHzXlvS+Ey3ZAZVuMA==", "0238 2795 0114", "5beb1e9d-3a95-4fc8-821f-aff6f5801dc1", "HaiThanh_Dang46@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8908 Đặng Ports", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Thi%E1%BB%87u%20B%E1%BA%A3o", "345edccc-dddf-460c-9dce-e008c1462e00", new DateTime(2014, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "HongLan.Tang87@yahoo.com", "Dương Thiệu Bảo", 3, "HONGLAN.TANG87@YAHOO.COM", "HONGLAN.TANG87@YAHOO.COM", "AQAAAAIAAYagAAAAEFDUYT2UIBaddbma8AA8Z47jQZ7+hzMDdtTa2wU000EK39Gsejykj2zOJMg7vUJT+A==", "0263 7072 3868", "8ad57daf-4636-41bb-9efa-37c7f3e12caf", "HongLan.Tang87@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4907 Trần Vista", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20%C3%90%C3%B4ng%20Tr%C3%A0", "eebfc523-3d06-4564-994b-9e6ffe1846fd", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "ThaoNguyen_Ngo10@yahoo.com", "Trần Ðông Trà", 2, "THAONGUYEN_NGO10@YAHOO.COM", "THAONGUYEN_NGO10@YAHOO.COM", "AQAAAAIAAYagAAAAEO3oYwnHsTiVQHaliz9iTHWaEw3VeCoZBqNjXOgLExYDLK0eVgq3SzZoUZFCVpiUuw==", "021 9971 8803", "33a60c74-24ec-47ba-bd65-8990bbbe7f79", "ThaoNguyen_Ngo10@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0104 Thiên Ðức Bridge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20%C4%90an%20Thu", "12155b2e-6bab-4bab-9f37-4e6d2cd72e8d", new DateTime(2009, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "KimVuong.Phan63@hotmail.com", "Lâm Đan Thu", "KIMVUONG.PHAN63@HOTMAIL.COM", "KIMVUONG.PHAN63@HOTMAIL.COM", "AQAAAAIAAYagAAAAEOg10Em4pp9qiHEH3jfbNMG4zGktJ+1HE6ecfysO9bwVUuCCjkmFJ+eV5DvKK2xghA==", "022 8009 7537", "59a9d411-e95f-4d5e-b037-68caaccad84e", "KimVuong.Phan63@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2981 Thiện Sinh Underpass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20H%E1%BA%A3i%20%C3%90%C6%B0%E1%BB%9Dng", "aa2bae58-4711-4bfe-bf8c-7ea4f5737930", new DateTime(2007, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), "ThiYen_To20@yahoo.com", "Đào Hải Ðường", "THIYEN_TO20@YAHOO.COM", "THIYEN_TO20@YAHOO.COM", "AQAAAAIAAYagAAAAEPTqBPfwNaX8kN7AGn+HyQFD0jwm/WBjpKfSHg9VCrypppC2abdEip2oV+IzvGKwTQ==", "020 9344 6437", "cb8cde72-2d3e-4fd2-a745-42a3e9fb7784", "ThiYen_To20@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "65055 Hồ Forest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20H%E1%BB%93ng%20%C4%90%E1%BB%A9c", "bc4b53b1-97e0-4451-8dae-6b531aeaaf56", new DateTime(1999, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "LamUyen_Phung33@gmail.com", "Tô Hồng Đức", "LAMUYEN_PHUNG33@GMAIL.COM", "LAMUYEN_PHUNG33@GMAIL.COM", "AQAAAAIAAYagAAAAECmTT82ihkZj7Hz0YubA/lqAfJsy9E4mdGXFyJHvhPW3qZAE4tcCMHTUxRfqZDuPxg==", "0204 8489 9815", "31f64a5e-522e-47ae-a9ec-41edf6172c0e", "LamUyen_Phung33@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0143 Khánh Duy Mews", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Qu%E1%BB%91c%20Ph%C6%B0%C6%A1ng", "99a088f8-782f-4473-ae62-43604ccac054", new DateTime(2001, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "XuanLam.Mai@hotmail.com", "Phạm Quốc Phương", "XUANLAM.MAI@HOTMAIL.COM", "XUANLAM.MAI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEH/rDKgIv1ZS9t4NCsUX70A6cDe0Z1qMAy5/LbhGrrAntsEM3X96PcPAB8eQogxvOA==", "0293 7196 7006", "7e42de61-d0bd-4bd0-ab4b-a2c683af5dcf", "XuanLam.Mai@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8063 Đỗ Inlet", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20V%C3%A2n%20H%C3%A0", "b0cb7277-d810-4279-9152-31aa24af115d", new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "KhueTrung9@yahoo.com", "Đoàn Vân Hà", "KHUETRUNG9@YAHOO.COM", "KHUETRUNG9@YAHOO.COM", "AQAAAAIAAYagAAAAEP3v+7h2H2xYSflby/m2yzDsAuOwtVVVQIc1+2Mn57wd0EjVQ+/yabzKJDCRBgqTkg==", "0233 4756 8619", "c3c0c097-d377-411f-b40e-185bd7fc8386", "KhueTrung9@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "218 Quang Thiên Neck", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20M%E1%BB%B9%20Y%E1%BA%BFn", "ff00408c-52f0-4c56-a412-d5d2a82f3bb2", new DateTime(2013, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "PhiKhanh37@yahoo.com", "Vương Mỹ Yến", 2, "PHIKHANH37@YAHOO.COM", "PHIKHANH37@YAHOO.COM", "AQAAAAIAAYagAAAAEEhGOENM8pi9n6oKcujm1RboDNT+t05FKzD5mZAkZLW41AxdUqZK6kosx5ynxEllkg==", "0208 1149 5309", "df4bd7b6-2c32-4619-9967-7bca83abc6ba", "PhiKhanh37@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "333 Thúy Hiền Drives", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20B%C3%A1%20Long", "30ec4354-1039-4e26-847a-d7bb5712503e", new DateTime(2003, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "ManhThang.Lam13@yahoo.com", "Hồ Bá Long", "MANHTHANG.LAM13@YAHOO.COM", "MANHTHANG.LAM13@YAHOO.COM", "AQAAAAIAAYagAAAAEA09f0mTEg4UPZYOcgWM/xDEts6r8OL/qbodyJBR0xG2apT+b5EbGvGGHOvNPpJIuw==", "0279 2024 1485", "fe1019a9-185a-4717-b5db-0473e0492f9e", "ManhThang.Lam13@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8424 Phùng Passage", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20C%C3%B4ng%20Tr%C3%A1ng", "13cd7240-91e3-4f11-998d-6d23a5902422", new DateTime(2002, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "VietTien47@hotmail.com", "Tăng Công Tráng", "VIETTIEN47@HOTMAIL.COM", "VIETTIEN47@HOTMAIL.COM", "AQAAAAIAAYagAAAAEO/MsV+aZKca5lXArPh4anb0s0B7q76byZfBTsj3f//zGeLdPfajtXLkWuAOFdzpxQ==", "027 2020 8699", "4900f646-1d14-46ee-a156-af9d821176b7", "VietTien47@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "01307 Trương Crest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Gia%20Khi%C3%AAm", "cd4f2c51-2799-41a7-92e2-f67d79193a4c", new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "BachQuynh_Dang@hotmail.com", "Tăng Gia Khiêm", "BACHQUYNH_DANG@HOTMAIL.COM", "BACHQUYNH_DANG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGrfomrUQFyXAqjYM2lw+dhMLPHhd/WYv26dTYTUwrdDpCORIlnlkz0keqWyVUBIbA==", "021 5931 0878", "219b8206-30d9-4e73-8d62-1c077137adac", "BachQuynh_Dang@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "01732 Dương Ports", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Th%E1%BB%A5y%20Du", "92a15709-8d82-42e8-aa5e-84b085a7a6bd", new DateTime(2006, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "QuanDuong_Nguyen@yahoo.com", "Phạm Thụy Du", "QUANDUONG_NGUYEN@YAHOO.COM", "QUANDUONG_NGUYEN@YAHOO.COM", "AQAAAAIAAYagAAAAENKYrXmo8UYvlk1go1vgwTecnmn8HkwMQLfiUZKrWvNLk/9FQIbSQ42p5o3eBaVi3Q==", "021 6395 9926", "c5c87e26-9b83-498c-b7da-e48af8900448", "QuanDuong_Nguyen@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "28149 Trương Parks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20H%C6%B0%C6%A1ng%20Chi", "44415584-5197-4854-8b12-ced9e65f0c83", new DateTime(2017, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "XuanNgoc19@yahoo.com", "Tô Hương Chi", "XUANNGOC19@YAHOO.COM", "XUANNGOC19@YAHOO.COM", "AQAAAAIAAYagAAAAEPIVNLCK+FoC4yfgmc+XoPZET9F0GAzpvcNVDHqcD20baCPvDIiy7aMy16vdcWVuRg==", "0281 5347 4117", "9e844440-e2f3-4972-b949-e227ced1d69f", "XuanNgoc19@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "899 Trần Plaza", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Ho%C3%A0i%20Thanh", "42de6480-efe1-4be8-b02a-3e163e6b5b16", new DateTime(2005, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "MinhHieu24@hotmail.com", "Trịnh Hoài Thanh", "MINHHIEU24@HOTMAIL.COM", "MINHHIEU24@HOTMAIL.COM", "AQAAAAIAAYagAAAAEH3acxm/45PxZOnJCZ/Zmq0+qZYfeu/4lfFChVN7SFPz0nlVc4z7PDP6ECLxN8Rwwg==", "0230 5943 9082", "fab964a3-f4d2-4e09-83bb-e9ed7060085e", "MinhHieu24@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4814 Minh Yến Mountains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C5%A9%20V%C4%A9nh%20Lu%C3%A2n", "f42ab07a-da07-42e4-9708-49f1fd44a7aa", new DateTime(2012, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "VangAnh_Trinh@gmail.com", "Vũ Vĩnh Luân", "VANGANH_TRINH@GMAIL.COM", "VANGANH_TRINH@GMAIL.COM", "AQAAAAIAAYagAAAAEGUORJZOIyqLqPDrz/C3X/1r6SitoMTHyAON/bKvOczSm0ldUg17KySpPiAtpg/D4w==", "029 1428 8295", "932ce288-ab26-455d-aeca-13ad8e5c96f6", "VangAnh_Trinh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "81279 Duy Quang Plaza", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20%C3%90%E1%BB%A9c%20To%E1%BA%A3n", "f7163258-b8a8-42ff-94e8-eef049304d90", new DateTime(2019, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "KimPhuong78@hotmail.com", "Vương Ðức Toản", 3, "KIMPHUONG78@HOTMAIL.COM", "KIMPHUONG78@HOTMAIL.COM", "AQAAAAIAAYagAAAAEO16Z426JBGsxWqGUEJb6jBweEkBHeCUIh9QQ2p23Dfo7pPyuk4bPdMpZ66YTVqKXA==", "022 7458 3095", "b6f4153e-752d-411d-9daf-66927628a9b7", "KimPhuong78@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0352 Quang Ðạt Creek", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Minh%20Th%C6%B0%C6%A1ng", "424c03e6-082a-45b6-8be3-8ce1c6da1120", new DateTime(2007, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), "HoangDung71@hotmail.com", "Đinh Minh Thương", 1, "HOANGDUNG71@HOTMAIL.COM", "HOANGDUNG71@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHcMvFL+alkznWwyAMjGE0PFPmCxRDhCtp5IjaNEbfx4TJcnop9mtiYdL2xM93VroA==", "0206 7638 3006", "6b308db2-d1c4-4bc7-aff4-c294c8c3ea3c", "HoangDung71@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "565 Mai Trail", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20%C3%90%E1%BB%A9c%20Ph%C3%BA", "cf7fb07c-b92f-4c25-a4a6-06ea77dd9207", new DateTime(2016, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "XuanThuyet_Do11@hotmail.com", "Tô Ðức Phú", 1, "XUANTHUYET_DO11@HOTMAIL.COM", "XUANTHUYET_DO11@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJaEhmmMNijDK+4el8+hsBsDg2743WmWwibgWOt4Jc56pOSKLNxnQVGnYZyj35x/Nw==", "029 5752 5337", "dddffc51-9a57-4322-a865-77460ef24518", "XuanThuyet_Do11@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "12897 Đoàn Extensions", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20%C3%90%E1%BA%AFc%20L%E1%BB%99", "b20374af-a149-4930-9e47-bbdbd1cd5c26", new DateTime(1997, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "MinhXuan.Duong@hotmail.com", "Đinh Ðắc Lộ", 1, "MINHXUAN.DUONG@HOTMAIL.COM", "MINHXUAN.DUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKUH+d69eNu0+gYWQdXfr/yDxD4/3r1x8c46JkSebqqmLy3c362qkoT3dWOzX1lP6A==", "028 1062 5214", "f86919b7-9d55-410c-959e-c4332278da7b", "MinhXuan.Duong@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "13864 Ngô Way", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Ch%E1%BA%A5n%20Phong", "eb51d928-f984-4edb-b4ca-10c81e0820a0", new DateTime(1994, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "KhacMinh.Trinh@gmail.com", "Hà Chấn Phong", "KHACMINH.TRINH@GMAIL.COM", "KHACMINH.TRINH@GMAIL.COM", "AQAAAAIAAYagAAAAEOly7GLADq/0Rny0MN/4sRtjhlECa9UY9XqOktX9vFohW6d6+LAi22bINIhElWBoqg==", "0270 5575 7296", "834f3d17-854d-49cf-82da-54ea780f701b", "KhacMinh.Trinh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4334 Sơn Trang Haven", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Th%C3%B4ng%20%C3%90%E1%BA%A1t", "659ba731-0dc3-442f-9c76-9da633414b2d", new DateTime(2017, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "ThanhKieu51@yahoo.com", "Hoàng Thông Ðạt", 2, "THANHKIEU51@YAHOO.COM", "THANHKIEU51@YAHOO.COM", "AQAAAAIAAYagAAAAEIUiB+61KBDdC4GzmQeOMw58HWXMKyOuICeYhPgzI5uAU9lDymlCAmTPRJXvqNwM7g==", "020 9187 7027", "ffc939b5-db38-40bf-8f2d-11bbbd8382f2", "ThanhKieu51@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "928 Đỗ Field", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Xu%C3%A2n%20Li%E1%BB%85u", "0658d61f-6ae5-4ca2-aa60-27afba32084f", new DateTime(2018, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), "BinhDuong.Ngo@hotmail.com", "Lê Xuân Liễu", "BINHDUONG.NGO@HOTMAIL.COM", "BINHDUONG.NGO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBQvKQiVD+F62TTjVJnSnbDIrA22CwNiOZMfa+7oGDgvKU7XfbphFAeJqdmaEZWXrg==", "027 0144 9233", "57737506-ea80-4cec-bf99-3bb62fd746bf", "BinhDuong.Ngo@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "11460 Linh Châu River", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Quang%20Th%E1%BA%A1ch", "a4891858-efb2-4215-b344-62839cdc614d", new DateTime(2006, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), "BichSan54@hotmail.com", "Hồ Quang Thạch", 1, "BICHSAN54@HOTMAIL.COM", "BICHSAN54@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGYEGTBBSeRvl09BEL4SjT4uL8nbO7sRfKDLKSL3owTFnuvbRmOJLs18maSN9RUOtg==", "023 2111 7997", "98e5595c-d57f-4892-a48d-42fa34d271c5", "BichSan54@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "25247 Ðông Tuyền Forest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20H%E1%BA%A3i%20Anh", "fced7108-a390-4264-8e72-8df8f233da70", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "MinhAnh.Dao12@gmail.com", "Lê Hải Anh", 2, "MINHANH.DAO12@GMAIL.COM", "MINHANH.DAO12@GMAIL.COM", "AQAAAAIAAYagAAAAEPymbNrjjKX5FyIe7vHpaN6eI2WoR3ypMaMscdXQhiVXpGSVTjHGcYy020ck4yHU/Q==", "025 0683 6728", "b8736778-08b8-4a96-951e-626873c9d351", "MinhAnh.Dao12@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3258 Trần Mill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20Tr%E1%BB%8Dng%20T%C6%B0%E1%BB%9Dng", "7d03c4be-d4f1-4755-9921-f20f3ad48b0a", new DateTime(1997, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "PhuongNgoc_Dinh@yahoo.com", "Đoàn Trọng Tường", 3, "PHUONGNGOC_DINH@YAHOO.COM", "PHUONGNGOC_DINH@YAHOO.COM", "AQAAAAIAAYagAAAAEHU+xt1RmuFuUUajkYyfcSjbRc3r2Vo+8XqMiNVpzukTmMWs8cD9K0KobX6Qr/dQ6w==", "028 3882 0858", "279bd1ab-8e5b-4b46-9dca-42a7d6b0dbf2", "PhuongNgoc_Dinh@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4705 Thanh Thư Path", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Th%C3%BAy%20H%E1%BA%A1nh", "123b3091-a384-45e6-849e-864eae767fd0", new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "TuanKhanh.Dang69@hotmail.com", "Lý Thúy Hạnh", "TUANKHANH.DANG69@HOTMAIL.COM", "TUANKHANH.DANG69@HOTMAIL.COM", "AQAAAAIAAYagAAAAENHAD+0hXAIUe+1BqbwMv0R3uyrahmwW9fPTRuBidVAmSLXCpkh1JP0y9/A3flO/gg==", "027 6764 0977", "82ba1d02-b004-4e49-9c83-3a8657b185dc", "TuanKhanh.Dang69@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "52551 Lâm Cliffs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20%C3%90%C3%ACnh%20Kim", "dedd4a61-c117-48c6-a36f-c9276f99a56e", new DateTime(2010, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "DiemKieu.Trinh65@hotmail.com", "Nguyễn Ðình Kim", "DIEMKIEU.TRINH65@HOTMAIL.COM", "DIEMKIEU.TRINH65@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJ1h0LonWxMiIxDLBCeThF/IlL+PjV+/jPshuJ16ZNMz22iQGGnjW1B5FGFkmvV+5Q==", "027 4529 0581", "c174b281-dc1f-4884-9ad6-fd0e4db4282a", "DiemKieu.Trinh65@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "533 Đỗ Parks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Trung%20Ki%C3%AAn", "2a0b1cba-91e3-4fdd-8b1e-cd45c4927f76", new DateTime(2016, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "NgocHoa.Vu@yahoo.com", "Ngô Trung Kiên", "NGOCHOA.VU@YAHOO.COM", "NGOCHOA.VU@YAHOO.COM", "AQAAAAIAAYagAAAAEPxuLrYCp7/KQZLbkYCLqkmqPKvMH/U3F8c+D4HFbEy+pXZ7i8g/11LUTV1ztLlvRg==", "024 5724 2168", "c21dcc3f-9201-42f5-8915-053570786d8e", "NgocHoa.Vu@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2235 Trương Mount", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Tu%E1%BB%87%20M%E1%BA%ABn", "a248b9f2-6059-4ebb-8856-7b3071c8b6da", new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "TrangAnh.To@hotmail.com", "Mai Tuệ Mẫn", 2, "TRANGANH.TO@HOTMAIL.COM", "TRANGANH.TO@HOTMAIL.COM", "AQAAAAIAAYagAAAAELzHi1oIGg7fE8Fm3aQlvsg42lk5NyG2RgABxna6UPXUF+A+i/lEEplL8SlcskJI7Q==", "028 3054 7914", "88f774a8-924e-40af-aa70-4a3473c32275", "TrangAnh.To@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7883 Quang Lân Manors", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Th%C3%BAy%20Huy%E1%BB%81n", "f78c9531-23c5-4712-9ce6-b83f39ac7be0", new DateTime(2015, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), "SonQuan_Vu@yahoo.com", "Mai Thúy Huyền", "SONQUAN_VU@YAHOO.COM", "SONQUAN_VU@YAHOO.COM", "AQAAAAIAAYagAAAAEB90jJP0JRStwjog0y7iJ3hfbsr/oufF1pNRw0+ckNnMgxgOarCFbj0HtrM5Em5J2g==", "025 1585 4411", "19bca615-8d7f-4d3f-928e-a8206dd03c8b", "SonQuan_Vu@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "97206 Nguyễn Knolls", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20H%E1%BA%A1nh%20T%C6%B0%E1%BB%9Dng", "88695e1e-7e02-4011-99a4-0ad44755bdcd", new DateTime(2011, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "HuuHoang52@yahoo.com", "Trần Hạnh Tường", 2, "HUUHOANG52@YAHOO.COM", "HUUHOANG52@YAHOO.COM", "AQAAAAIAAYagAAAAEKeIOKDiB+DEYLMlYtrJ4kca2nndhvd+McJZOhdfHmM2XFWTrQVy9+XHDSPkRAtY9Q==", "0298 5207 8476", "afb5a009-4bf2-4f77-810e-adf2e1250b1b", "HuuHoang52@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4269 Tường Anh Fork", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Quang%20L%C3%A2m", "551eef0b-a1ec-4378-9535-ce5aeb151d56", new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "MinhThu_Lam@hotmail.com", "Tăng Quang Lâm", 2, "MINHTHU_LAM@HOTMAIL.COM", "MINHTHU_LAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEO4ipOjgpG17WHPK97E3yanB5SvGCL9LUHUOvRECkYEZqxn5wwUEY43b1FYHcgn6RA==", "024 8931 2363", "1523144d-cbaf-4f64-a953-e2b92702e7bb", "MinhThu_Lam@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8648 Diệu Ngọc Plain", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20An%20B%C3%ACnh", "44912615-b85a-41a8-94e1-3c3b3004bb85", new DateTime(2012, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), "TanPhat.Dang52@yahoo.com", "Hoàng An Bình", 2, "TANPHAT.DANG52@YAHOO.COM", "TANPHAT.DANG52@YAHOO.COM", "AQAAAAIAAYagAAAAEKbMspHwPtMSLAZP4WkN5iaPBTU3BsOYpiC74B5zBt66bYJYiQP37leRroiXmEWigA==", "0269 1128 9071", "67cf8463-b8bc-42f4-a9f2-7b95a97219df", "TanPhat.Dang52@yahoo.com" });
        }
    }
}
