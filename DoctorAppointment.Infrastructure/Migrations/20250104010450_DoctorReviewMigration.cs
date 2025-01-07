using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorAppointment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DoctorReviewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "AverageRating",
                table: "Doctors",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 9, 0, 0, 0), "Reprehenderit ut temporibus ullam.", 18, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 0, 0, 0), "Cumque sapiente aut qui iure asperiores temporibus expedita exercitationem minus.", 4, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 16, 0, 0, 0), "Ipsum excepturi dolores ex dolor optio ea.", 81, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 16, 0, 0, 0), "Autem ut delectus.", 50, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), "Totam ipsa doloremque nobis sed nihil.", 61, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 18, 0, 0, 0), "Voluptates voluptatibus eveniet asperiores pariatur soluta voluptatem quos omnis.", 62, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 9, 0, 0, 0), "Maxime itaque sunt earum.", 91, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 18, 0, 0, 0), "Itaque quis veritatis.", 20, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 9, 0, 0, 0), "Excepturi illo dolore tempora blanditiis enim facilis.", 24, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Voluptatum quaerat est veniam perferendis architecto voluptas.", 27, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 12, 0, 0, 0), "Eligendi ut et aut aut sed asperiores amet qui molestiae.", 1, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 0, 0, 0), "Est voluptatem saepe hic culpa hic sunt.", 28, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), 5, "Aut illum perferendis sunt quasi qui repudiandae consequatur perferendis.", 54, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 15, 0, 0, 0), "Ducimus eos ut illum rem animi enim.", 27, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), "Minima eum delectus autem ut doloremque ea porro.", 18, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 17, 0, 0, 0), "Ratione itaque accusantium autem cupiditate impedit error pariatur nulla.", 12, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 9, 0, 0, 0), "Et dolorem totam nihil.", 31, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 12, 0, 0, 0), "Quaerat animi dolorum ipsam cupiditate sit quam hic minus.", 93, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 0, 0, 0), "Veniam praesentium et aliquid aut saepe.", 48, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 18, 0, 0, 0), "Nihil in dolore tenetur quisquam omnis ad.", 24, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), "Saepe consectetur quis beatae tempora est ad rerum.", 6, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 10, 0, 0, 0), "Dolorem tempora fugiat sed et esse assumenda provident voluptatem vero.", 28, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 0, 0, 0), "Quaerat at nihil odio facilis quas omnis.", 19, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 17, 0, 0, 0), "Ex dolores aut rerum debitis nisi sapiente eius.", 12, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 12, 0, 0, 0), "Placeat temporibus et placeat minus corrupti quas natus.", 4, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 0, 0, 0), "Veniam aspernatur facere ab.", 60, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 17, 0, 0, 0), "Et et libero accusamus.", 62, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 0, 0, 0), "Saepe aliquam omnis ea maiores exercitationem quibusdam dicta.", 75, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 4, "Distinctio recusandae omnis reprehenderit id maiores.", 91, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 17, 0, 0, 0), "Et harum dolor quae eaque natus aut inventore odit odit.", 12, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Odio pariatur soluta perferendis consequatur.", new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 11, 0, 0, 0), "Ipsa reprehenderit voluptatibus.", 66, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 13, 0, 0, 0), "Magni quia modi aperiam ipsam dicta accusamus.", 91, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 16, 0, 0, 0), "Quas quasi et nulla.", 77, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 0, 0, 0), "Odit voluptas vel aperiam quae quo asperiores.", 46, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Ut earum voluptates quo laboriosam.", 55, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Porro qui voluptatem natus quis.", 48, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 16, 0, 0, 0), "Molestiae temporibus veritatis porro molestiae.", 22, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 12, 0, 0, 0), "Provident sunt quis in excepturi rerum cumque necessitatibus porro maxime.", 33, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 17, 0, 0, 0), "Autem cumque facilis et aperiam autem minus rem libero accusamus.", 4, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 18, 0, 0, 0), "Dolorem rerum tempore nesciunt temporibus sunt earum aspernatur sapiente voluptatem.", 67, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 13, 0, 0, 0), "Soluta nihil asperiores quia doloribus fuga fugit vel reprehenderit omnis.", 46, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 17, 0, 0, 0), "Nemo odit laboriosam odio provident quo dolor ut.", 34, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 14, 0, 0, 0), "Minus id hic eum vitae quod.", new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 15, 0, 0, 0), "Porro officiis doloribus non laborum perferendis nemo.", 24, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 12, "Tempora recusandae accusantium dolores tempora unde delectus culpa doloremque.", 24, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), 20, "Modi eligendi accusamus nemo reiciendis optio cupiditate ut.", 43, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), "Rem laborum culpa enim quasi rerum dolorum omnis laborum debitis.", 80, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), "Qui et blanditiis eum natus.", 8, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 14, 0, 0, 0), "Ex distinctio qui eum ipsam eaque magni.", 51, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 16, 0, 0, 0), "Voluptatum eum fugiat incidunt molestiae quasi voluptas ratione asperiores.", 16, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Enim rem et quisquam perspiciatis et ipsa cum modi qui.", 51, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 15, 0, 0, 0), "Sed sint sunt ullam qui nesciunt eos.", 28, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 9, 0, 0, 0), "Incidunt odit possimus consequatur quia qui aut.", 76, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), "Autem animi eos rem dicta dicta.", 67, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 9, 0, 0, 0), "Assumenda labore quia voluptas sed rem.", 79, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 20, "Est iusto est laboriosam laborum ipsam veniam minus minima.", 99, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Nam ut nulla.", 76, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 13, 0, 0, 0), "Qui voluptatem labore mollitia perspiciatis unde.", new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 9, 0, 0, 0), "Earum ex quasi ullam autem officia laudantium delectus.", 31, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), "Impedit quis maiores ut et iusto architecto id.", 39, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 0, 0, 0), "Ad veritatis soluta molestiae ullam est id vel consequatur.", 93, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), 5, "At earum quia iure necessitatibus at illo voluptatem pariatur blanditiis.", 44, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Dolorum alias omnis hic aperiam exercitationem eveniet molestias minus.", 58, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 15, 0, 0, 0), "Non et aspernatur laboriosam aut.", 29, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 19, "Ea illo provident.", 85, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Doloremque qui est architecto et quia praesentium.", 84, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 0, 0, 0), "Autem corporis deleniti est quasi nisi eum quo accusantium sunt.", 14, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 15, 0, 0, 0), "Quaerat libero ea nostrum quia sapiente necessitatibus dolores.", 77, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 14, "Eum veritatis perspiciatis ut dolores quia et dolorem aspernatur et.", 51, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Porro et placeat perferendis libero et inventore commodi porro error.", 70, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 17, 0, 0, 0), "Aut quibusdam quam aliquid ut nobis.", 42, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 13, 0, 0, 0), "Quam cupiditate praesentium sit placeat et temporibus.", 93, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "In quis ducimus vitae totam id facilis perspiciatis.", 67, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 18, 0, 0, 0), "Ab ab blanditiis repudiandae.", 12, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 14, 0, 0, 0), "Et vel omnis consequuntur quis quae qui non.", 24, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), "Cum a non rem ea praesentium incidunt.", 97, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AppointmentDate", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "Qui dolore alias.", 40, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 3, "Eum sint at itaque est velit inventore.", 46, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 14, 0, 0, 0), "Ipsam quis perferendis a dolore.", 82, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 16, 0, 0, 0), "Perferendis inventore enim natus velit dolorum non.", 68, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 17, 0, 0, 0), "Rerum nostrum earum est sed sint architecto ut.", 27, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 9, 0, 0, 0), "Animi a rem nisi ut culpa enim.", 95, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 15, 0, 0, 0), "Quo error quia totam.", 58, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 12, 0, 0, 0), "Iusto dolore ut.", 97, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 11, 0, 0, 0), "Eum sit adipisci eligendi et eos placeat consectetur voluptates.", 27, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 9, 0, 0, 0), "Aut necessitatibus et nobis enim ut ut earum inventore.", 60, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 18, 0, 0, 0), "Qui veniam porro impedit voluptatem quo quia.", 57, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 11, 0, 0, 0), "Voluptatem ab qui ut fuga quos at quia aut odio.", 41, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 13, 0, 0, 0), "Eligendi maiores ipsam eos voluptate modi non veritatis quaerat iusto.", 19, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 16, 0, 0, 0), "Velit debitis et quo temporibus eum fuga dolore et est.", 3, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), "Voluptatem nobis aut officiis.", 31, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), 9, "Mollitia repudiandae adipisci placeat neque similique rem rerum.", 18, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 12, 0, 0, 0), "Perspiciatis optio molestiae veritatis unde non.", 7, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 9, 0, 0, 0), "Pariatur et corporis.", 24, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), "Minima corrupti nihil voluptates.", 36, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Dicta saepe et totam id officia quam ut corporis est.", 43, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 13, 0, 0, 0), "Est odio tempore ipsum consequuntur.", 69, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 0, 0, 0), "Velit quia optio nesciunt voluptate officiis vitae corrupti aliquid harum.", 71, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), 1, "Repellat dolore nemo et expedita modi et soluta.", 5 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Assumenda consequatur consequatur eos.", 84, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 15, 0, 0, 0), "Sint qui libero exercitationem.", 20, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), "Sapiente facere quidem iusto qui eos et natus.", 70, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 17, 0, 0, 0), "Aut eos quibusdam.", 30, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 0, 0, 0), "Quam ut nobis.", 85, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), "Fugiat molestiae consequatur quod inventore dolores delectus.", 15, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 10, 0, 0, 0), "Consequatur quia fugiat neque qui veniam.", 55, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 14, 0, 0, 0), "Facere provident nesciunt quia commodi qui.", 11, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 18, 0, 0, 0), "Quod sed non cum est qui sint earum sunt.", 50, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 9, 0, 0, 0), "Sint libero voluptatibus voluptatum ut.", 35, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 0, 0, 0), "Iste suscipit non illo accusamus voluptatem sed enim placeat.", 17, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 14, 0, 0, 0), "Non cupiditate hic dolores facere et illo.", 92, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 0, 0, 0), "Odio magni repellat.", 65, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), "Amet sit eaque et illo explicabo et corrupti.", 74, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 11, 0, 0, 0), "Quasi sed et suscipit ullam qui aut qui omnis.", 92, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Similique repellendus dolorem voluptas.", 4, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 16, 0, 0, 0), "Et consequuntur eum minus sit consequatur eligendi.", 43, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 0, 0, 0), "Repudiandae est quas voluptatem in velit qui.", 38, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), "Neque culpa modi error est inventore aut eligendi ut.", 71, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 10, 0, 0, 0), "Aspernatur est cum labore ea dignissimos.", 21, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), 13, "Sed assumenda cupiditate possimus molestiae eligendi quod.", 22 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 14, 0, 0, 0), "Laudantium nesciunt aut est aspernatur.", 26, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 17, 0, 0, 0), "Eos aut sapiente doloribus possimus molestiae dolor et repellendus.", 26, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), 13, "Sed et facilis consectetur molestiae maxime ipsa officiis ut.", 29, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, "Quia et temporibus.", 41, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), "Accusamus ipsum eveniet omnis.", 46, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 5, "Neque pariatur ea suscipit.", 69, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), "Sed unde sed totam tempore et asperiores incidunt.", 16, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 0, 0, 0), "Et odit aut explicabo velit impedit explicabo.", 91, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 13, 0, 0, 0), "Optio dolorem doloribus reiciendis dolor praesentium voluptatem sed.", 57, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Quaerat veritatis fuga aut fugit qui laboriosam quo beatae.", 35, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), "Nihil ducimus et.", 45, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), 13, "Ipsam et laudantium fugiat aliquid aperiam sed inventore in dolorum.", 67, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 14, "Ea eaque sequi at aspernatur.", 6, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 11, 0, 0, 0), "Sunt porro eos nesciunt ratione eius.", 63, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 0, 0, 0), "Et cum autem qui qui quos id sit.", 86, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 12, 0, 0, 0), "Aut dolores voluptatem.", 95, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 12, 0, 0, 0), "Necessitatibus nobis quasi sapiente ea fugit voluptatem accusantium illum itaque.", 58, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 15, 0, 0, 0), "Culpa et natus vel earum quasi.", 77, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 12, 0, 0, 0), "Autem reiciendis non repellendus vitae deserunt accusantium amet exercitationem rerum.", 70, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 16, 0, 0, 0), "Numquam ad enim non magni.", 22, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 18, 0, 0, 0), "Est rem sed aperiam est et.", 63, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 13, 0, 0, 0), "Tenetur tempora dolore assumenda.", 80, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 9, 0, 0, 0), "Qui qui ea sunt voluptas neque sed et.", 42, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 13, 0, 0, 0), "Possimus porro temporibus iste.", 55, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 13, 0, 0, 0), "Atque enim nulla.", 39, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 11, 0, 0, 0), "A voluptates est minima est.", 19, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 14, 0, 0, 0), "Repellendus provident recusandae voluptatem ut.", 85, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 10, 0, 0, 0), "Eaque enim occaecati ducimus ipsam numquam est et doloremque iusto.", 15, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), 20, "Aspernatur maiores quas veniam aut.", 55, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), "Quae sunt consequatur minima excepturi et earum illum corporis.", 7, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 13, 0, 0, 0), "Quos qui non.", 63, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Veniam maiores voluptate est ut.", 32, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 10, 0, 0, 0), "Libero enim voluptas.", 15, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 14, 0, 0, 0), "Deleniti possimus eum aut.", 65, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 19, "Rerum mollitia voluptate minus sunt.", 88, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 12, 0, 0, 0), "Eos error culpa tempore.", 18, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), 14, "Eum cum sint et velit dolore.", 49, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Et quas natus iste labore aliquam officia.", 89, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 18, 0, 0, 0), "Ut blanditiis sit.", 81, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), "Perferendis facere id quo ut impedit.", 32, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 15, 0, 0, 0), "Sed id sunt nemo.", 82, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 9, 0, 0, 0), "Quidem rerum aut cum aliquid.", 58, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 17, 0, 0, 0), "Repudiandae et a unde.", 54, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 15, 0, 0, 0), "Eos iure sapiente hic in cum et.", 32, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 11, 0, 0, 0), "Illum vero illo ea.", 61, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 15, 0, 0, 0), "Est culpa nisi ad.", 28, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 10, "Id excepturi aut velit dolorem error id voluptas.", 47, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), "Dolore dolores consequatur impedit qui autem veniam.", 36, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 18, 0, 0, 0), "Dicta atque nihil.", 46, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 13, 0, 0, 0), "Eos adipisci rerum sit vero sed voluptas.", 38, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 14, 0, 0, 0), "Cum deleniti vero omnis omnis quia quam occaecati magnam.", 34, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 13, 0, 0, 0), "Consequatur aliquid eos deserunt laudantium hic quis dolore totam non.", 60, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Eos quam illum porro quia minus illum molestiae velit molestiae.", 46, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 12, 0, 0, 0), "Veniam nostrum et excepturi nihil est dolorem et et earum.", 100, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Ea aperiam quidem fugit.", 60, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Provident fuga delectus.", 48, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), 19, "Iure culpa cum eum.", 67, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 19, "Id rerum illo nulla pariatur odit est dolor placeat.", 69 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 16, 0, 0, 0), "Omnis vel eveniet.", 15, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 13, 0, 0, 0), "Repellat quis aliquam amet magni maiores deserunt consectetur beatae.", 43, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 9, 0, 0, 0), "Quos perferendis quae alias est nostrum tempore temporibus eos magni.", 12, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), "Accusantium harum ea tempore vel eligendi.", 100, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 13, 0, 0, 0), "Facilis et et rerum nisi.", 62, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 17, 0, 0, 0), "Ipsa eius qui repellat voluptatem et ex ut minus dolor.", 41, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 15, 0, 0, 0), "Eaque temporibus ea.", 37, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 15, 0, 0, 0), "Adipisci et culpa.", 84, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 18, 0, 0, 0), "Possimus repudiandae sed molestiae voluptatem alias tenetur.", 65, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 16, 0, 0, 0), "Assumenda corrupti ipsam facilis minima.", 7, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 10, 0, 0, 0), "Ut blanditiis et.", 71, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 12, 0, 0, 0), "Eligendi in atque accusantium minima quisquam quo eum eius quibusdam.", 65, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 9, 0, 0, 0), "Necessitatibus nostrum et neque autem.", 27, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), "Sed porro ullam et recusandae veniam rerum quasi ut.", 68, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), "Quo id dignissimos.", 100, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 10, 0, 0, 0), "Dignissimos quo excepturi praesentium aut ut.", 1, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), "Nam perspiciatis voluptas numquam dicta delectus.", 95, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 5, "Magni minima similique repellat esse reiciendis et natus.", 8, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 18, 0, 0, 0), "Eum sit minima doloribus eaque ducimus eos.", 84, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 12, 0, 0, 0), "Est voluptates eius voluptatem eos sed voluptatem quas aut impedit.", 80, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 14, 0, 0, 0), "Voluptatem nihil illum minima non et est voluptas at quam.", 52, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 16, 0, 0, 0), "Dolores voluptas dolorum qui nihil mollitia deleniti.", 29, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 10, 0, 0, 0), "Harum eveniet dignissimos quae.", 7, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 18, 0, 0, 0), "Ipsam repellendus officiis vel non.", 45, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 0, 0, 0), "Doloribus autem nulla.", 75, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 15, 0, 0, 0), "Cum natus omnis libero.", 10, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 13, 0, 0, 0), "Iusto rerum est delectus corporis natus autem quia eius doloribus.", 77, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 0, 0, 0), "Amet quod dolor.", 97, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 13, 0, 0, 0), "Aut vero maiores et consequatur sequi aut placeat.", 20, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 13, 0, 0, 0), "Omnis quidem non ratione reiciendis.", 57, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 12, 0, 0, 0), "Ducimus nam similique dicta qui et.", 52, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 17, 0, 0, 0), "Asperiores perspiciatis quibusdam error aut voluptatum eveniet illum.", 52, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 16, 0, 0, 0), "Ratione dicta neque architecto ducimus earum qui.", 85, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 12, 0, 0, 0), "Laborum fugiat est ea cum laboriosam voluptate et ipsa dolores.", 81, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Voluptatem voluptatem dicta.", 50, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 12, 0, 0, 0), "Nulla qui sequi qui non asperiores sit sint incidunt quibusdam.", 26, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), "Dignissimos vero reprehenderit minus.", 10, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 13, 0, 0, 0), "Omnis tempore id.", 101, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 16, 0, 0, 0), "Exercitationem explicabo sapiente placeat eius enim delectus ipsam itaque dolores.", 2, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Praesentium et aut consequatur quia et.", 20, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), "Quo eligendi qui veritatis tenetur voluptatem.", 6, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 9, 0, 0, 0), "Inventore in voluptate facere sint molestiae.", 20, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 16, 0, 0, 0), "Sunt voluptatem error nam quibusdam consequatur et inventore vel.", 40, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 0, 0, 0), "Nemo rerum eos quo aut.", 80, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 17, 0, 0, 0), "Et voluptas magnam minima nobis aut sit et consequatur.", 48, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AppointmentDate", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), "Repellat iusto repudiandae rerum recusandae.", 59, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 9, 0, 0, 0), "Libero occaecati et et quas dignissimos placeat praesentium.", 54, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 14, 0, 0, 0), "Minus odit ea soluta corrupti vel.", 96, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 17, 0, 0, 0), "Rerum veniam voluptate voluptatem quae distinctio.", 27, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 14, 0, 0, 0), "Adipisci harum a rem quis mollitia et eos dolores maiores.", 78, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 0, 0, 0), "Provident quia placeat corrupti consectetur nesciunt magni odit dignissimos.", 92, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), "Sint molestias maxime facilis qui omnis quam et a.", 99, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Qui earum est vitae ipsa.", 37, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Et ipsam consectetur voluptatem velit dolor id amet et explicabo.", 26, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 0, 0, 0), "Dolorem qui tempora distinctio distinctio architecto dolores enim molestias est.", 98, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 13, 0, 0, 0), "Nostrum sequi nihil perferendis eveniet dolorem voluptates quidem repellat ea.", new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 11, 0, 0, 0), "Esse beatae aliquid harum.", 100, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 18, 0, 0, 0), "Non iure voluptatem ratione eos qui.", 74, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 2, "Quo molestiae cumque natus sint magnam dolor fugit in.", 82, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 15, 0, 0, 0), "Deleniti et minima.", 29, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 17, 0, 0, 0), "Corrupti blanditiis qui odit reiciendis harum nihil quia.", 53, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, "Officiis sed sit ipsa.", 93, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), 6, "Libero praesentium et sequi exercitationem.", 12, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Nemo maiores voluptate aliquam ratione.", 85, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 0, 0, 0), "Sed laboriosam est eos consequatur voluptatibus explicabo voluptatibus.", 90, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 13, 0, 0, 0), "Non quod dolorem.", 56, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 11, 0, 0, 0), "Quos magnam eum omnis laboriosam.", 36, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 0, 0, 0), "Et rem quia voluptas eligendi non quisquam commodi ex nihil.", 70, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Enim eum voluptatibus sit minus.", 53, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), 7, "Repellendus accusamus ut reprehenderit rerum laboriosam aspernatur incidunt laudantium dolorem.", 95, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), "Iure voluptas voluptatem sapiente.", 2, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), 16, "Non enim quaerat ipsa a soluta vel in.", 97, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 11, 0, 0, 0), "Quidem molestias odit asperiores ea magni vero cupiditate et dolor.", 24, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Possimus autem adipisci illum optio sit nam officiis.", 11, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AppointmentDate", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Voluptatem consequatur temporibus dolores alias dolores molestiae repudiandae fuga.", 80, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 10, 0, 0, 0), "Deserunt esse ut eum quisquam quis voluptatem quisquam.", 64, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 15, 0, 0, 0), "Praesentium quo id voluptas.", 41, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 10, 0, 0, 0), "Aut quia velit sint est sit quia dolor necessitatibus.", 83, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 1, "Voluptatem laboriosam nemo esse rerum blanditiis.", 18, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 16, 0, 0, 0), "Et voluptas sint expedita ea quia officia aliquam iure vel.", 55, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 16, 0, 0, 0), "Voluptate ad aut.", 24, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 12, 0, 0, 0), "Voluptatem vel rem quibusdam corrupti.", 31, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), "Assumenda architecto facere eum tempore qui.", 86, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 17, 0, 0, 0), "Laborum quis neque dicta earum praesentium perferendis non maiores.", 86, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 0, 0, 0), "Odit aut dolores quo dolorem.", 38, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 15, 0, 0, 0), "Debitis quibusdam praesentium ut sapiente nam.", 58, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 12, 0, 0, 0), "Repudiandae eaque tenetur placeat.", 74, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 9, 0, 0, 0), "Consequuntur quaerat dolorem eos voluptas mollitia qui vel consectetur et.", 16, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 13, 0, 0, 0), "Qui aut id nesciunt laboriosam dolorum earum eaque.", 9, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Sit illo sunt vel recusandae quo sit vel exercitationem.", 15, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Non voluptatem illo aut asperiores.", 7, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 18, 0, 0, 0), "Fugit temporibus ut a voluptatem quibusdam eligendi.", 70, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 16, 0, 0, 0), "Soluta officiis est autem.", 98, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 11, 0, 0, 0), "Autem consequatur omnis.", 12, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), "Cumque ullam odio dolores quo.", 79, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Tempore eaque recusandae occaecati corporis cumque quo iusto omnis.", 20, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, "Magni numquam soluta enim rerum.", 49, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), 7, "Eaque aut tenetur non quibusdam consequatur quae voluptatum aut perferendis.", 98, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), "Sit sapiente ut.", 51, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), "Qui enim voluptatum voluptas quia ducimus necessitatibus est facilis modi.", 61, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 0, 0, 0), "Illum deleniti vitae quasi sint temporibus facilis.", 17, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 16, 0, 0, 0), "Sunt atque ea consequuntur sed deleniti cum et.", 30, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 13, 0, 0, 0), "Delectus saepe quibusdam voluptatem.", 78, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Fuga aperiam ut occaecati est ut dolorem voluptatum aut quod.", 81, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Fuga aut impedit quos quo iure.", 23, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Omnis perferendis optio voluptas in.", 11, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 17, 0, 0, 0), "Molestiae quia tempora ut a quas in ad.", 56, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 14, 0, 0, 0), "Et rerum molestiae.", 20, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 13, 0, 0, 0), "Praesentium magnam sequi rerum omnis.", 2, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), 18, "Deserunt tenetur et.", 8, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 0, 0, 0), "Quaerat temporibus quas qui amet nobis.", 81, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 12, 0, 0, 0), "Sunt est voluptatum quaerat.", 25, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 12, 0, 0, 0), "Voluptates dicta consectetur quia optio quibusdam libero commodi ducimus.", 7, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 2, "Excepturi sed error voluptates cumque placeat cupiditate repellendus vel et.", 71, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 18, 0, 0, 0), "Harum minima atque esse blanditiis tempore ullam.", 26, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 14, 0, 0, 0), "Odit et sit quis illo eos.", 6, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 15, 0, 0, 0), "Hic nisi consequuntur nihil est quas omnis.", 83, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), 11, "Nobis labore natus id similique rerum quo nostrum iusto autem.", 76, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 16, "Ut quidem ut tempora a temporibus.", 29, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 14, 0, 0, 0), "Voluptatem laborum quia laborum qui ipsam quia.", 17, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), "Laudantium et architecto et reiciendis.", 47, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Da liễu", 0f, 3, 9 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Tim mạch", 0f, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "AverageRating",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "About", "AverageRating", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Tim mạch", 0f, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Da liễu", 0f, 3, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "About", "AverageRating", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Thần kinh", 0f, 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Thần kinh", 0f, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Đa khoa", 0f, 1, 10 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Thần kinh", 0f, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Nhi khoa", 0f, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 3 năm trong lĩnh vực Thần kinh", 0f, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Tim mạch", 0f, 2, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Tim mạch", 0f, 2, 9 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "AverageRating",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Đa khoa", 0f, 1, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "AverageRating",
                value: 0f);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Da liễu", 0f, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Thần kinh", 0f, 4, 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Nhi khoa", 0f, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Tim mạch", 0f, 2, 7 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2181ff77-e0ce-43e3-88c7-1ca382feaa8a", "AQAAAAIAAYagAAAAEHryNInFGYZWumv3hmE8DFv+VwjJeEdSd39ZLI6YWWZ1v+nTRrv3XoUTak+ugQwLGQ==", "4e1be29b-2a94-4b79-a8f0-1b9fc59f02d2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "33888 Hoàng Point", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20V%C3%A0ng%20Anh", "560423d9-d038-46e5-9a4c-b097749ec3b7", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "BaoTien_To@gmail.com", "Phùng Vàng Anh", "BAOTIEN_TO@GMAIL.COM", "BAOTIEN_TO@GMAIL.COM", "AQAAAAIAAYagAAAAECuktbsuuZ4vLldFLh+WQLh1CUniZGgpVAP3567FBFeGeW+9bUFqBnS/F9VHk5OMgg==", "024 4401 6343", "ec217bc1-93f8-4be6-aee4-c382dddf0bba", "BaoTien_To@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "14476 Hương Chi Forest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20C%C3%B4ng%20H%C3%A0o", "88a536dc-5e1f-4526-8f2e-dbdbc8b9a996", new DateTime(1995, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "MyNga.Nguyen66@gmail.com", "Trần Công Hào", 3, "MYNGA.NGUYEN66@GMAIL.COM", "MYNGA.NGUYEN66@GMAIL.COM", "AQAAAAIAAYagAAAAEKBYNCkYBAxtfgGZLCDQJdj6pAWH1zc/9TkG8cCToSEWzUORxAnzC9/bd/oCsNwgew==", "026 1237 3032", "33cf775b-0339-4d07-aeea-bc8318bcec6c", "MyNga.Nguyen66@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2395 Tăng Coves", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Kh%E1%BA%AFc%20Tu%E1%BA%A5n", "aebe230e-1b91-49e5-9ee4-7d3012fb1fd9", new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "QuocHanh_Bui21@hotmail.com", "Mai Khắc Tuấn", 1, "QUOCHANH_BUI21@HOTMAIL.COM", "QUOCHANH_BUI21@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEmCT5xjDL+Cw7aN1e3WMBDQjoGyTrfHbz/d+2WtYlYgoPZeRxp0UJc6RH5q0v6LQA==", "023 2081 6517", "0c5695f1-0afc-4417-a2ca-a84eaeee8897", "QuocHanh_Bui21@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3219 Đào Meadows", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Nam%20Phi", "e7d282f2-769d-459f-88f9-b0846012c3d5", new DateTime(2009, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), "DoanTrang_Dinh@hotmail.com", "Bùi Nam Phi", 3, "DOANTRANG_DINH@HOTMAIL.COM", "DOANTRANG_DINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAECeY3CNVpPgmqm9JYWE8dA9iyhIXdw3H+2R3TOz4BWwoJYLIcaqgZdJOn2eQ0diB2Q==", "024 8375 2884", "d0499c5e-3f79-4b34-b3f7-91e89deafc8b", "DoanTrang_Dinh@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "656 Cát Tường Route", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Kim%20%C3%81nh", "70a0e705-4168-405c-99b6-0f8e9e6f6c89", new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "HieuThong59@hotmail.com", "Bùi Kim Ánh", "HIEUTHONG59@HOTMAIL.COM", "HIEUTHONG59@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHVJCfq+upGCE5loVbaX5c0Xvxc0fIuB+v3em0LSSHVlh2hzyVQFAIGzPjbpt8y0Eg==", "026 7021 9287", "6964f8dc-2ab7-4110-94be-3e99031ab169", "HieuThong59@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7308 Quang Lâm Walk", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Vi%E1%BB%87t%20Qu%E1%BB%91c", "6a391e05-acf0-4188-aeb1-3cb43ce5a773", new DateTime(2016, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "AnThien_Trinh64@yahoo.com", "Dương Việt Quốc", 2, "ANTHIEN_TRINH64@YAHOO.COM", "ANTHIEN_TRINH64@YAHOO.COM", "AQAAAAIAAYagAAAAEMYHXm2cKg0bWlwSBipcMKzEABhQAz3L3N1IUa115i8by1OS8S/5N9is6tF5JOlfUg==", "0251 1510 9997", "2f18b93e-1255-4ea2-8f56-2e62fd46d2f4", "AnThien_Trinh64@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "039 Nguyễn Dale", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20Ph%C3%BA%20H%E1%BA%A3i", "53693877-e193-4002-8a2e-fca400a6fa34", new DateTime(1998, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "DuyHien_Lam95@hotmail.com", "Đào Phú Hải", 2, "DUYHIEN_LAM95@HOTMAIL.COM", "DUYHIEN_LAM95@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHoS3GQOEBJqD4a2cXuFgt9WmS1qXVFwEanm0BfXxPmbwdkRwEAM9z9xnRa9ls//+g==", "0227 7550 3072", "df0712bc-c5ec-4f07-83c1-00d248487bde", "DuyHien_Lam95@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "533 Trương Summit", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Qu%E1%BB%B3nh%20Nh%C6%B0", "6479acee-322f-4446-93c9-3aeb82171bb2", new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "ThucTam.Bui33@gmail.com", "Đỗ Quỳnh Như", 2, "THUCTAM.BUI33@GMAIL.COM", "THUCTAM.BUI33@GMAIL.COM", "AQAAAAIAAYagAAAAEOWl8Pyimlfuhb01EUFTKZzAoiPBM3aaCFhUxSGqVmlrUe61VpV8qmYgMp015EOE1Q==", "021 8584 5271", "8d2e9991-a5cd-4e05-8d5f-5846795a3e6b", "ThucTam.Bui33@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "570 Mai Lakes", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20H%E1%BB%93ng%20L%C3%A2n", "0503c931-6ec6-4435-a93c-61de44016d2d", new DateTime(2008, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), "ThanhTuan.Truong@yahoo.com", "Lý Hồng Lân", "THANHTUAN.TRUONG@YAHOO.COM", "THANHTUAN.TRUONG@YAHOO.COM", "AQAAAAIAAYagAAAAEEoLTDU4LtsxZRoOF5XHkrigpjSGGLxU7cxiiZq4YDsC7jOU/NtbjxYny2gIo4cwDA==", "025 5931 5709", "91f3db3f-86be-48d1-9bce-5b2283a91b07", "ThanhTuan.Truong@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "63140 Tăng Vista", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Xu%C3%A2n%20Hi%E1%BB%81n", "06a140c9-54c4-47ec-9171-e9723f98a73a", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "LinhPhuong_Ho14@gmail.com", "Phạm Xuân Hiền", "LINHPHUONG_HO14@GMAIL.COM", "LINHPHUONG_HO14@GMAIL.COM", "AQAAAAIAAYagAAAAEAVoNNd9ibB1D+ejllSCncYmv+SS6SRUqMeKxbuBn8DDqO1phjQffNH9BZRF1eTbdg==", "022 2737 0893", "7c2c339f-d25a-49e5-b5a0-b965a3deafaa", "LinhPhuong_Ho14@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "88576 Phạm Meadows", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Th%E1%BA%A3o%20My", "221fca3f-14c0-4845-beb7-dde8b1ea1abd", new DateTime(2015, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "NhaY3@yahoo.com", "Lý Thảo My", 2, "NHAY3@YAHOO.COM", "NHAY3@YAHOO.COM", "AQAAAAIAAYagAAAAEIRp3i01VzCZBJMS1QePb88Nj//JRwYQ02HlgRJr6mix8k/M3ie2h8ekvOj2j67pqQ==", "023 2728 4402", "307c6ae0-59c4-4fab-89b4-951a3979ae6f", "NhaY3@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7538 Đinh Meadow", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Thu%20Li%C3%AAn", "aea262ac-08a4-4fa8-89dc-ee3119ff9a46", new DateTime(1999, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "DinhKim_To@hotmail.com", "Trịnh Thu Liên", 1, "DINHKIM_TO@HOTMAIL.COM", "DINHKIM_TO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEP3iIgpjUzburKzrOS/VcLFbeA20pS0ZR5cl0jaIMozb3ZjMs+AhCT+YNIzXA9rplA==", "025 5326 7487", "43e1a604-d3a3-4796-b9b6-1b6bcda5cc89", "DinhKim_To@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "39527 Trương Ridges", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20Ho%C3%A0i%20Trung", "95fcc88d-4ac0-4344-8f32-2eb9c60148fb", new DateTime(2002, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "AnhXuan63@gmail.com", "Đoàn Hoài Trung", "ANHXUAN63@GMAIL.COM", "ANHXUAN63@GMAIL.COM", "AQAAAAIAAYagAAAAEEIG7yN9mqfMDdIfXTex3eYdlCAIsxs1ZfUDuqTq/+76AcIcWi6KsFtdUQW4ASf2Bg==", "0203 6363 8423", "79e54773-f8de-4cfb-ab69-ebbb551b1f5e", "AnhXuan63@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "66903 Hải My Light", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20H%C3%B2a%20Hi%E1%BB%87p", "2e53a9a5-09e7-4fe3-994e-2036e67d5940", new DateTime(2004, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "VanDu.Do@gmail.com", "Bùi Hòa Hiệp", 3, "VANDU.DO@GMAIL.COM", "VANDU.DO@GMAIL.COM", "AQAAAAIAAYagAAAAEKp6gyPMWx3/HNsyFMOC6L2c83Rhl8HxMjd+0MWb9Ids8m8tXTTXlaFKTmDTs+Iq2A==", "022 9301 8961", "6844f229-4f1a-44d3-a486-1ab652157360", "VanDu.Do@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "08052 Xuân Hoa Stravenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20H%E1%BA%A3i%20Y%E1%BA%BFn", "2f09a00f-2004-474e-bb87-dbaac454e45d", new DateTime(2016, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "DongNghi.Bui@hotmail.com", "Phạm Hải Yến", "DONGNGHI.BUI@HOTMAIL.COM", "DONGNGHI.BUI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEP0UnX6ZVDnVKnxdyV7jrbt6HDr6gZooWoSlBsoM7DwB7yYNfZQP9wAZNe1yMemVVQ==", "0258 3163 5076", "1bfd55f9-0f74-4bb7-bd09-d963a8094d85", "DongNghi.Bui@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "33561 Lý Terrace", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Nh%E1%BA%ADt%20Qu%E1%BB%91c", "64a4d7ff-e4d0-42c8-91cf-3577245cf79f", new DateTime(1999, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), "DieuVan_Mai@gmail.com", "Đỗ Nhật Quốc", "DIEUVAN_MAI@GMAIL.COM", "DIEUVAN_MAI@GMAIL.COM", "AQAAAAIAAYagAAAAEFNL0yMj06u8fwsfE8VzntRRUIJFW/WG+sZt+2QpXV08L//hrPJQA/KZWOHskCMORA==", "027 5067 9896", "d4909e93-cd31-4722-a322-3f06a3570737", "DieuVan_Mai@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0490 Phạm Pike", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Quang%20%C3%90%E1%BA%A1t", "f2c5dad9-1914-49d5-863a-c90195f6b112", new DateTime(2001, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "HaGiang_Doan29@gmail.com", "Lê Quang Ðạt", 3, "HAGIANG_DOAN29@GMAIL.COM", "HAGIANG_DOAN29@GMAIL.COM", "AQAAAAIAAYagAAAAEIaX2ZiysJkl8KDGmw9M+H3zP/lvfgEpNVSuKVsujWTXbaJlPsR7BOVdZ2MGNx0kNA==", "028 9106 2683", "994589f8-dee4-4ad6-a58f-def773ea1b33", "HaGiang_Doan29@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3502 Phạm Camp", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Th%E1%BA%A3o%20My", "b638935e-f722-425e-aab0-b1fc5bc5023f", new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "PhuongLinh.Vuong29@gmail.com", "Hồ Thảo My", 1, "PHUONGLINH.VUONG29@GMAIL.COM", "PHUONGLINH.VUONG29@GMAIL.COM", "AQAAAAIAAYagAAAAEHE0tSnvx4tYZM8CNQvJMw7xM7CZHbTE9GwwZYzJ5cDZwKc2xXx5pWEy4wwGBS0/yQ==", "0255 7069 5748", "92b83596-b0ab-4109-94e1-196b5787e19c", "PhuongLinh.Vuong29@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "396 Vũ Park", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Nh%E1%BA%ADt%20Ti%E1%BA%BFn", "a3b5b0be-4f67-4f0f-aacc-3a2234ea396b", new DateTime(1997, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "XuanThu_Hoang37@gmail.com", "Phạm Nhật Tiến", "XUANTHU_HOANG37@GMAIL.COM", "XUANTHU_HOANG37@GMAIL.COM", "AQAAAAIAAYagAAAAEJpCffFaMTDGrngHUnITjayFD628iFrlAhGQ/4ssbWLF/3qs5pNZ3HXGn3ltj/R0IA==", "0272 1457 3430", "08a6eef6-5940-4117-b565-4242a9be43a8", "XuanThu_Hoang37@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "805 Trương Tunnel", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20Ban%20Mai", "8f3d2cdc-f13f-46c3-a120-542375de66dc", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "HoangMy.Dao@hotmail.com", "Đào Ban Mai", 2, "HOANGMY.DAO@HOTMAIL.COM", "HOANGMY.DAO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEL0aY4bN4fPZLjmovw0LLYdHWnFZQBvKRxr987LZpoyHqnE5/iaiAuPLwMbCnbXPfQ==", "028 5234 4109", "37ce7a53-b497-41f4-8f44-1b75ce0791ed", "HoangMy.Dao@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9454 Hòa Bình Islands", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Xu%C3%A2n%20L%E1%BA%A1c", "bd032fe8-8a64-473c-9176-009de15bb517", new DateTime(2004, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "TruongLien_Ly5@hotmail.com", "Hà Xuân Lạc", "TRUONGLIEN_LY5@HOTMAIL.COM", "TRUONGLIEN_LY5@HOTMAIL.COM", "AQAAAAIAAYagAAAAEN2kC/hW0ZurZvpC7r0tUEl+zgJxwmNcH/9mCl4sElF7q9tXjn7rSsr9gbFScrcVbA==", "0222 0783 0085", "3524111e-2976-4f78-b8b0-e065599f243f", "TruongLien_Ly5@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "008 Trần Curve", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20An%20H%E1%BA%B1ng", "ededbf7e-90b3-4ad4-813e-7c5f33b259a1", new DateTime(2005, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "VyLan27@hotmail.com", "Hoàng An Hằng", "VYLAN27@HOTMAIL.COM", "VYLAN27@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHgNT9Ahe8ReZHiRAsiI9LSKWWLXNQouimnYxbvEB6WkPgJmO/Znlja8WGe9Ha0aTA==", "0278 8973 8464", "dac6c778-4fd5-4fe2-bb8f-d2b6f2d5b75d", "VyLan27@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "57753 Thất Dũng Springs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20H%C6%B0%C6%A1ng%20Lan", "729d502c-d881-4a4a-a199-3380f18332a7", new DateTime(2011, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "TrongTuong56@gmail.com", "Trần Hương Lan", "TRONGTUONG56@GMAIL.COM", "TRONGTUONG56@GMAIL.COM", "AQAAAAIAAYagAAAAEKJZExc/CiwTXgBPUY1z44vVSHCjLcPxwVTFOzbnCjn4uz7WeVATSrsGKkv3q3TePw==", "021 6747 4496", "6249bcf8-cd49-48ca-9028-c070d15fda89", "TrongTuong56@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "349 Như Hồng Oval", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Thanh%20H%E1%BA%A3i", "4366d638-940f-4c81-9ba0-977541cab696", new DateTime(2011, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "ThienLac_Pham@hotmail.com", "Đỗ Thanh Hải", 2, "THIENLAC_PHAM@HOTMAIL.COM", "THIENLAC_PHAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEE7mn7TWphEHP+P6JJv0QsPFsC/ELTptLAzW0Xrg0XOkJM73gZzuye9bwjEDDDBUnA==", "0266 4020 5395", "030934d2-bbf2-4e58-98e5-38fd8aa57c58", "ThienLac_Pham@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2255 Vương Lock", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Di%E1%BB%85m%20Ki%E1%BB%81u", "fda2c12b-02b5-4683-b3ed-a0059349d7ed", new DateTime(2002, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "QuocTruong80@yahoo.com", "Phùng Diễm Kiều", "QUOCTRUONG80@YAHOO.COM", "QUOCTRUONG80@YAHOO.COM", "AQAAAAIAAYagAAAAEB/AnocBrvJunOQHQheXTc0uhm0aZMt4EXSLfrfblLhTPSHZKNs7Zwe8YNRYmSMnNg==", "0262 1320 4176", "b132cd76-b6f7-49e5-aa97-f88e114e14a7", "QuocTruong80@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "570 Trương Meadows", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20T%C3%B9y%20Linh", "3ec2bf13-e582-46a6-8ef0-e88563f2fdd4", new DateTime(1998, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "BaoHoa.Vu@yahoo.com", "Phan Tùy Linh", 2, "BAOHOA.VU@YAHOO.COM", "BAOHOA.VU@YAHOO.COM", "AQAAAAIAAYagAAAAEMG9PXKBTexEenrIqTHPW7Q0UYuegIDbKD5CGa77wfo7b+bkzvHwHtiQmRVWimL+uw==", "024 2085 1568", "dea77ded-792f-41bb-b690-e1a795f5e83e", "BaoHoa.Vu@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "601 Phan Summit", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Ph%C6%B0%C6%A1ng%20Thanh", "934f4507-5fe8-48cc-9fae-0c28ef83d3a7", new DateTime(2005, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "PhuongTrang.Ha84@hotmail.com", "Đỗ Phương Thanh", 3, "PHUONGTRANG.HA84@HOTMAIL.COM", "PHUONGTRANG.HA84@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJ3Gd/KFoo6lqlKAw4tiftK+8MY1Hsb9voyHfDj1GoPyQz3LpSPfOSvHcpEBQUCLbw==", "021 7916 6279", "4fb3def8-021f-4014-bc55-3fd26f3ddc5b", "PhuongTrang.Ha84@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "762 Vũ Walk", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Hi%E1%BB%87p%20Dinh", "8941d825-f223-496e-8f04-9ed8bb0951d0", new DateTime(1997, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "NgocTam.Dinh@hotmail.com", "Trương Hiệp Dinh", "NGOCTAM.DINH@HOTMAIL.COM", "NGOCTAM.DINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGG8WXJWuscA5ja5OIWbbZiaVVAV49/l1MZojITIC+yNYHCLUIEC7QVSCkO6avHr/w==", "0229 9791 2320", "aa112392-d00d-40f9-9d0b-cf8032f63b8e", "NgocTam.Dinh@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3021 Phạm Estates", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20M%E1%BA%A1nh%20C%C6%B0%C6%A1ng", "9ea37471-a1fd-468d-a99c-a66f1e68133e", new DateTime(2014, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "BichQuan29@gmail.com", "Dương Mạnh Cương", 2, "BICHQUAN29@GMAIL.COM", "BICHQUAN29@GMAIL.COM", "AQAAAAIAAYagAAAAEECl4Brc90sMhGom1Mtoo0/JT+M8iOISDv3JBWSJbT2PTGoPlhsXGqm2rSDChHNviA==", "020 2591 7483", "e66849a2-80b1-4fac-b60c-a8e9d144fa53", "BichQuan29@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3830 Hồng Ngân Parkway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20Ch%C3%AD%20C%C3%B4ng", "8950a3b5-3547-4fa2-9e64-90901630ff58", new DateTime(2012, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "DaLan_Bui26@gmail.com", "Nguyễn Chí Công", "DALAN_BUI26@GMAIL.COM", "DALAN_BUI26@GMAIL.COM", "AQAAAAIAAYagAAAAEC4gSjEhsyIqotzEL/hXAYKN+50SWe9j38rFwoAZB1cdw7Xcvetc3qeRlE/TJ2rx7g==", "0220 1863 6141", "e53f9917-fe66-4cdc-b8e4-932627bf5c82", "DaLan_Bui26@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "42490 Ðức Quyền Extensions", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20D%E1%BA%A1%20Y%E1%BA%BFn", "f7b97851-2802-4376-b19d-36dff7b43c5f", new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "PhuongNhi88@hotmail.com", "Phan Dạ Yến", "PHUONGNHI88@HOTMAIL.COM", "PHUONGNHI88@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBXKhGw8tQg9a3/JUori3WV8JrKDDfj5V0c6g7QYn1fPN/ihAy290ZCiLoKzY/PI1Q==", "023 0616 3976", "869a7972-01ef-41bd-9154-ccfd30ec55ee", "PhuongNhi88@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "754 Đoàn Ridges", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20Th%E1%BA%A1ch%20S%C6%A1n", "ce745b16-0abd-4766-a158-a01c2405d199", new DateTime(2008, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "AnCo.Le93@yahoo.com", "Đoàn Thạch Sơn", 2, "ANCO.LE93@YAHOO.COM", "ANCO.LE93@YAHOO.COM", "AQAAAAIAAYagAAAAEFRvM8cWAF3cEc+L1hDM+giKLi5I1w4kHxVWv4Cvz8fNoo4YLrF5jYGe2y5LWMiBVQ==", "021 0117 0702", "fc9cdc1a-a4db-40dc-a617-97499ddba45c", "AnCo.Le93@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "123 Lê Point", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Th%C6%B0%E1%BB%9Dng%20Ki%E1%BB%87t", "a9a193fa-21d6-4595-ace9-320431b0878f", new DateTime(2002, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "HuuTuong_Ly@yahoo.com", "Ngô Thường Kiệt", "HUUTUONG_LY@YAHOO.COM", "HUUTUONG_LY@YAHOO.COM", "AQAAAAIAAYagAAAAELtHEksDxF4pIfu8XdFnjlVnDQGlL0O1HQQASureON1vilNVsvoU2LRPxlOClKHzPg==", "0283 5623 4625", "f585e478-81dc-4b64-bdfe-9779a0684419", "HuuTuong_Ly@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "793 Thế Dân Pike", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Qu%E1%BB%91c%20Vinh", "54fedfdb-cab4-46ee-b0db-729fbda77f03", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), "DinhDieu9@gmail.com", "Lê Quốc Vinh", 3, "DINHDIEU9@GMAIL.COM", "DINHDIEU9@GMAIL.COM", "AQAAAAIAAYagAAAAED4cDnF7Y4RHhzm9Ge/I20pdexNDkK5wtetJzkrIW8VsdsvmRo8EJ3ScAwA8GDbJAw==", "021 1023 2437", "a780cfcf-360e-4f63-a19f-a317b7b75af3", "DinhDieu9@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "04628 Viễn Cảnh Branch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Ho%C3%A0ng%20%C3%82n", "afb0e941-49ad-41a6-86f5-206923cd57a7", new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "SonTrang.Do66@yahoo.com", "Tăng Hoàng Ân", "SONTRANG.DO66@YAHOO.COM", "SONTRANG.DO66@YAHOO.COM", "AQAAAAIAAYagAAAAEASYUBPKFTP/70Bv4kRJBl/2SlR6kjDLGT4ym0BFWygcxZmSk6ddK1Nc+pO3Uh5f4Q==", "0238 2803 5758", "1eca358d-64d2-458b-8b62-a2d4010db3a7", "SonTrang.Do66@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "93902 Tô Glens", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Th%E1%BB%A5c%20Oanh", "2af02676-006f-42f1-a8e1-93442e76c0e6", new DateTime(1997, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "BaoNgoc_Lam41@gmail.com", "Hồ Thục Oanh", 3, "BAONGOC_LAM41@GMAIL.COM", "BAONGOC_LAM41@GMAIL.COM", "AQAAAAIAAYagAAAAEMgjC9nxS3VfSxdIFWBS5gj8cxG9ytyFMsiU1Si9UrLSJICNAP0V27oSC9HE5zVT2g==", "0233 6871 8741", "2438d3c5-6351-4af8-b323-6a8c79677182", "BaoNgoc_Lam41@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8668 Quỳnh Trâm Mill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20B%E1%BA%A3o%20Ng%E1%BB%8Dc", "6986185f-0fb2-402c-b192-8b9a5e0f515d", new DateTime(2010, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "XuanCao50@yahoo.com", "Hà Bảo Ngọc", 2, "XUANCAO50@YAHOO.COM", "XUANCAO50@YAHOO.COM", "AQAAAAIAAYagAAAAEPOhjfTsEg7PEjzahblVVbd+p3kQOrs6IwAr1CsHrBQTdGCgNzfefKmCOeAIia2/mg==", "0296 5236 1387", "7b02b9c6-24e5-4bbe-b05f-feaddb65353a", "XuanCao50@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9247 Lý Orchard", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Tu%E1%BA%A5n%20Linh", "09099271-0d68-454f-96f0-dd929619c71c", new DateTime(2001, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "ThaiSon_Phan75@gmail.com", "Mai Tuấn Linh", 3, "THAISON_PHAN75@GMAIL.COM", "THAISON_PHAN75@GMAIL.COM", "AQAAAAIAAYagAAAAEJsHIcwRXXtUGWLwf3aerMAUMKH1LUAtBuMRSzjaeyFDTK7oD69PrtJA6Y84YAgVmQ==", "0213 2533 1551", "2ca61ecd-ea9a-4c25-aef1-074380e0df17", "ThaiSon_Phan75@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "06131 Vương Spur", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Di%E1%BB%85m%20My", "9c9d67d9-c6f8-4d4f-80a7-1ee213bc96cc", new DateTime(2016, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "DuyQuang86@yahoo.com", "Lý Diễm My", "DUYQUANG86@YAHOO.COM", "DUYQUANG86@YAHOO.COM", "AQAAAAIAAYagAAAAEDsufBYXCd5ZELgq4eXdzPN0g7mOGd144U+Ll7ReJ53mLjHTVR0iTeYpzSnzQ/quxg==", "029 1699 6105", "ec94f9f6-4544-4c3c-bf3f-b2af5c19349a", "DuyQuang86@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4838 Mai Bypass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20%C3%90%C3%B4ng%20Nghi", "e0df8d7e-e2b8-4d52-9390-24dd11eb5eb6", new DateTime(2011, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "BichDiep.Truong3@gmail.com", "Dương Ðông Nghi", 2, "BICHDIEP.TRUONG3@GMAIL.COM", "BICHDIEP.TRUONG3@GMAIL.COM", "AQAAAAIAAYagAAAAEMogA4e4K/H2S3P4BUboYfJdZ/tYeFhKLcUxioLgfHuYd4kJgK/78DfVszfqEYehQQ==", "0231 8236 1251", "1b499078-d303-4a0b-bf08-ad29e8cde575", "BichDiep.Truong3@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "86616 Bảo Phương Brooks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Tri%E1%BB%81u%20Nguy%E1%BB%87t", "9f086012-84dd-40d0-bf63-8b043ed012dc", new DateTime(2002, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "GiaHoang_Duong@hotmail.com", "Đinh Triều Nguyệt", "GIAHOANG_DUONG@HOTMAIL.COM", "GIAHOANG_DUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPDptRlWsnWZc9SO6tNushvhM0f83yqpdGku+n/OWhsnTYkXQ2jqwKBPkGgKzaKUxQ==", "0234 6149 2794", "43fa24a6-07ad-431a-8bf9-f54d7554c018", "GiaHoang_Duong@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "59965 Quế Lâm Terrace", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20L%C6%B0%C6%A1ng%20Tuy%E1%BB%81n", "4e94ef0f-9d01-40ae-8010-2f987639ce48", new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "ThuyHang_Tang@gmail.com", "Nguyễn Lương Tuyền", 3, "THUYHANG_TANG@GMAIL.COM", "THUYHANG_TANG@GMAIL.COM", "AQAAAAIAAYagAAAAEMJXo3WltLPPFmqR4w7bMuOXGx9F4jhHSBzgs+1emRqJvZQLqdUsXUhWp5sWi0aXoA==", "0200 7267 0275", "81917865-796e-4a69-b352-9a8f12f46143", "ThuyHang_Tang@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "431 Hồ Mountains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20%C3%90an%20T%C3%A2m", "9f47d146-072e-4754-8bd1-7971bcf9c160", new DateTime(2012, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "DiemThuy_Truong@hotmail.com", "Hoàng Ðan Tâm", 2, "DIEMTHUY_TRUONG@HOTMAIL.COM", "DIEMTHUY_TRUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDtH4rVfpzZ4jVSqBuNUMMO59JVeC6jqekZHd5tbxbmFTWDlJKqu6R4vP2UTdwxI7g==", "0264 4607 3366", "583dc978-4eff-4059-81f9-2887028fe073", "DiemThuy_Truong@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "92448 Hữu Nghĩa Inlet", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Th%E1%BA%BF%20Quy%E1%BB%81n", "9654f4f1-1870-410a-b4e8-4e8475954284", new DateTime(2003, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "VanThuong57@hotmail.com", "Đỗ Thế Quyền", 1, "VANTHUONG57@HOTMAIL.COM", "VANTHUONG57@HOTMAIL.COM", "AQAAAAIAAYagAAAAENmYNZBBwBsq42kEWYcePvxu3pGNVOoigLFYzLwtlvv5R9MC/S9DGe5HfxX7p7bv9A==", "0205 9943 2213", "27daeb22-e889-4167-ba43-89c22934eec9", "VanThuong57@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4103 Trịnh Plains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20H%C3%B9ng%20Anh", "de7b47d7-ffa3-4238-932d-793d4eb354db", new DateTime(2015, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "TatHoa_Duong26@gmail.com", "Trương Hùng Anh", 2, "TATHOA_DUONG26@GMAIL.COM", "TATHOA_DUONG26@GMAIL.COM", "AQAAAAIAAYagAAAAEFzmE5gPvK/gSonx3HTTvxwcZsvlfeyt4Kkmb6IGf4lPbo6cS+7pb3CI8MWxnUaDnA==", "0294 5520 0395", "c6d09eb4-88e3-494c-868d-0f1aa514c111", "TatHoa_Duong26@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "864 Ðình Quảng Parkway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20%C3%90%C3%ACnh%20L%E1%BB%99c", "00fdd42f-7e34-4c41-996d-4818983915ee", new DateTime(2012, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "DiemTrinh55@gmail.com", "Ngô Ðình Lộc", 2, "DIEMTRINH55@GMAIL.COM", "DIEMTRINH55@GMAIL.COM", "AQAAAAIAAYagAAAAEF7f6Yns2lOL3ffLwzRgBO+s3kQr5FA/EcEctR0VQuqhMSN3uXLjAampT7mZLFwv4A==", "0286 3592 6688", "a59f2030-606a-4054-906c-8f98ebd15370", "DiemTrinh55@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1643 Hoàng Phát Island", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Mai%20Linh", "6532cadd-e316-4f26-9b24-92d56b56396e", new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "NguyetUyen74@yahoo.com", "Đặng Mai Linh", "NGUYETUYEN74@YAHOO.COM", "NGUYETUYEN74@YAHOO.COM", "AQAAAAIAAYagAAAAEKhf73cHmtBlnPA+3QXqBR9QXuscWSgiJd7HJNypQAe2Hfd50iVlfcHOe/iMtSyEtA==", "026 1505 5932", "4521c407-2715-4c7d-bf47-c47a1f589711", "NguyetUyen74@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "485 Nguyễn Crossroad", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Kh%E1%BA%A3%20Khanh", "f98abf5a-642f-4f7b-9a6c-1245a69e05ed", new DateTime(1995, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "TuanSy_Trinh@gmail.com", "Đinh Khả Khanh", "TUANSY_TRINH@GMAIL.COM", "TUANSY_TRINH@GMAIL.COM", "AQAAAAIAAYagAAAAEDDZiZBr0JVU0vpSbFOQCVcSZgzmMHI48pkvU3VHPt8Z4lnxQXs/pwibwEKUbw0loQ==", "0275 3022 4528", "c06e8da9-b497-4c06-beea-24101c5a6537", "TuanSy_Trinh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0839 Bùi Fork", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Minh%20Uy%C3%AAn", "4b10b41e-1e0e-470e-94b9-3d6b0d64fa2f", new DateTime(2019, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), "CongLuan.To68@yahoo.com", "Hoàng Minh Uyên", 3, "CONGLUAN.TO68@YAHOO.COM", "CONGLUAN.TO68@YAHOO.COM", "AQAAAAIAAYagAAAAEJYQ92hylFHnH0YffzzqWZ5uuzlNs67ok8H5RbmiFgwdtU+U1wePTwdi3SLsWLvmtQ==", "029 6261 4123", "d221a9f3-a93e-4c45-8c26-c631a58ec46f", "CongLuan.To68@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7297 Anh Thư Vista", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Vi%E1%BB%87t%20Long", "95ea33cb-9774-4798-90fa-a6021f5a4a27", new DateTime(1997, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "SaoBang57@gmail.com", "Bùi Việt Long", "SAOBANG57@GMAIL.COM", "SAOBANG57@GMAIL.COM", "AQAAAAIAAYagAAAAEPCuJXwiB+dUMel5va4JzXXI6D1ndx7b+2hjEd91SdNvx8LicUE9StLNOwwZOKZcvw==", "021 1493 1169", "02f94510-4b61-4685-9222-af4314e6aaea", "SaoBang57@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "252 Nguyễn Point", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Di%E1%BB%87u%20V%C3%A2n", "b82d9b41-34ea-4991-a9c8-2ea3f8207524", new DateTime(2003, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "DongTuyen.Dang@gmail.com", "Dương Diệu Vân", 2, "DONGTUYEN.DANG@GMAIL.COM", "DONGTUYEN.DANG@GMAIL.COM", "AQAAAAIAAYagAAAAELshPTd/V/D27TYUKMWXvYMOtlZnvnas3pik0oXMgXW4C/D6JVuqprM46nFZEen5zw==", "029 6854 0361", "41a74fb5-39d9-4d15-b012-c0d574043915", "DongTuyen.Dang@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "370 Thanh Tịnh Rapids", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Ph%C3%BAc%20T%C3%A2m", "8b466a8b-ddb3-4c57-a63f-1ecf430d9b43", new DateTime(2004, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "DucNhan.Vu@yahoo.com", "Hà Phúc Tâm", 3, "DUCNHAN.VU@YAHOO.COM", "DUCNHAN.VU@YAHOO.COM", "AQAAAAIAAYagAAAAENgJZTtSKurgpuvlkwQvi6muDz+N+hmy8CXCR80W4a8hjssqoZFm+GVwc3Bx/SV6LQ==", "0211 9521 6052", "c1028849-ab1c-48d0-bd56-094ed620d8cf", "DucNhan.Vu@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "63290 Song Oanh Crossroad", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20Ng%E1%BB%8Dc%20H%E1%BA%A3i", "a4910c95-430a-40ab-bb6e-7aa37e9861dd", new DateTime(2012, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "ChieuDuong.Doan@hotmail.com", "Lâm Ngọc Hải", 3, "CHIEUDUONG.DOAN@HOTMAIL.COM", "CHIEUDUONG.DOAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEM8/k76lToqX0xnDJHizaRbrJpkawYiw3NhF7EYwNA7l8A7Klm5VrVKcCESBFLFx3A==", "020 3979 0632", "567a61df-4a08-4371-90d9-d53538623756", "ChieuDuong.Doan@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4268 Thụy Ðào Tunnel", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Uy%E1%BB%83n%20Khanh", "9884c515-b6d8-4681-b73f-97fadd6f5cce", new DateTime(2010, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "HuuBinh97@hotmail.com", "Đinh Uyển Khanh", 2, "HUUBINH97@HOTMAIL.COM", "HUUBINH97@HOTMAIL.COM", "AQAAAAIAAYagAAAAEK0HKtGIo7zMKSpayxb3Bgzdz1546Eh8bv30njXDEfvyN/HVs2whCEx8s7a61EWVNQ==", "026 7242 6917", "647cdfc7-7b01-483b-ab85-57e9a471378f", "HuuBinh97@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2111 Trần Points", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20B%E1%BA%A3o%20Kh%C3%A1nh", "21b3857e-b6b9-416b-af6a-d793780f116f", new DateTime(2007, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), "PhuongYen.Hoang80@hotmail.com", "Nguyễn Bảo Khánh", 1, "PHUONGYEN.HOANG80@HOTMAIL.COM", "PHUONGYEN.HOANG80@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAwhdJ9gabAlLQXqvOhs0pzpDpRUsjfsejyWRlqi8szBg+AFSQOKoBKg+OcoW+xiIg==", "0278 5329 5647", "d95ac590-c9ef-4c86-b49b-f41ae1948d93", "PhuongYen.Hoang80@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "052 Đoàn Roads", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Qu%E1%BB%91c%20To%E1%BA%A3n", "87031412-a51c-4741-80bb-732c1331990e", new DateTime(2010, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "NhaUyen48@hotmail.com", "Vương Quốc Toản", "NHAUYEN48@HOTMAIL.COM", "NHAUYEN48@HOTMAIL.COM", "AQAAAAIAAYagAAAAEK/EFOqcUaRzmFA1pnI9O1QYBHy/9xVpx57NmHqbSDvJCHbV4CB5CDlzboP0cmFrlw==", "024 0201 5064", "307ac30b-70a8-499d-b9d5-6dfed559090e", "NhaUyen48@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2259 Lâm Mountain", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20B%E1%BA%A3o%20L%C3%A2m", "b93c1294-a167-4ad3-98bc-78c246ab478e", new DateTime(2015, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "XuanVu.Vuong@gmail.com", "Nguyễn Bảo Lâm", 2, "XUANVU.VUONG@GMAIL.COM", "XUANVU.VUONG@GMAIL.COM", "AQAAAAIAAYagAAAAEHLt+H7HeBV7150r705ESyJbXrro8e2fv70TaTOeZbUFVhi2pS/cPXRp/L+9MVtlwQ==", "0210 0143 2950", "9719a713-9bb1-4981-ad56-812cb13dd1a6", "XuanVu.Vuong@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "77670 Hoàng Thư Streets", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20H%E1%BA%A3i%20Y%E1%BA%BFn", "e5a1b1c0-f9f6-4566-a90e-458825c7b3d7", new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "ManhThang46@gmail.com", "Dương Hải Yến", 3, "MANHTHANG46@GMAIL.COM", "MANHTHANG46@GMAIL.COM", "AQAAAAIAAYagAAAAEA29r6BnxITIEiyAlYf2bPLy7Zj79xPQPxTIiBoumURUXZqF2/MwE9Vgs7Bo+zDbIw==", "0243 8992 2783", "89bd3ea8-5c96-442b-a508-ec95b0ccb58c", "ManhThang46@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "833 Phạm Shore", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Thi%C3%AAn%20Ph%C6%B0%C6%A1ng", "e18db44b-5e8e-4ee6-a534-cf3dd21f4abd", new DateTime(1996, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "MinhVuong_Phan@hotmail.com", "Hà Thiên Phương", 3, "MINHVUONG_PHAN@HOTMAIL.COM", "MINHVUONG_PHAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEou/QjcQu387sAO6QhwIp0qAhpGEGfqC9Anh6+1W+4FZLUmDpVirec8q7hPFkeI2g==", "0205 7625 8452", "a973e7d4-a34d-4137-a33e-14243def4560", "MinhVuong_Phan@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "73849 Ánh Linh Flats", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Thi%C3%AAn%20Di", "be4c6ff6-bf57-4a62-aa0c-7d03e5fd0a21", new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "TheTrung.Bui76@yahoo.com", "Đỗ Thiên Di", 2, "THETRUNG.BUI76@YAHOO.COM", "THETRUNG.BUI76@YAHOO.COM", "AQAAAAIAAYagAAAAECBtK8pUI0Zdh/HcIRDYzX/SkdLCyY6a++S2/TIBCKT0q3q7kH3Fihc533WBtOaPYg==", "0218 9954 0330", "6ad76647-f93a-4c9f-bcaf-55ff65dfc4ad", "TheTrung.Bui76@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "30816 Thiều Ly Manors", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Thu%20Duy%C3%AAn", "e51cab48-6af6-4dfc-ae86-430ff9ba0e1b", new DateTime(2010, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "XuanMinh.Ly@yahoo.com", "Trương Thu Duyên", "XUANMINH.LY@YAHOO.COM", "XUANMINH.LY@YAHOO.COM", "AQAAAAIAAYagAAAAEL+mdFWuSbGZIPDseNzWR+GvuEEk//aFbcspOVLh25W1smgPx3wgZiWaOD+eS3T/3g==", "022 1038 3708", "df237da7-cb57-416f-8da5-277a6b1500ab", "XuanMinh.Ly@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "78617 Quốc Mạnh Square", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20B%E1%BB%ADu%20Di%E1%BB%87p", "b79ae5d9-6eb4-401d-9fdf-d38c298055b3", new DateTime(1996, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "VanThang.Truong79@hotmail.com", "Phạm Bửu Diệp", 2, "VANTHANG.TRUONG79@HOTMAIL.COM", "VANTHANG.TRUONG79@HOTMAIL.COM", "AQAAAAIAAYagAAAAELYjyJ3dhnOSgYw55LRS88+trckjo0O1KVnY3yjwmOMDEd633cwoWV21VabVHUXj/g==", "025 7899 1231", "97439663-6d46-4e54-ae37-bba6a92b9712", "VanThang.Truong79@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "27487 Quỳnh Vân Gateway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Duy%20H%E1%BA%A1nh", "101036c0-2497-429c-a178-3155582af287", new DateTime(2009, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "TaHien_Dao@yahoo.com", "Mai Duy Hạnh", 1, "TAHIEN_DAO@YAHOO.COM", "TAHIEN_DAO@YAHOO.COM", "AQAAAAIAAYagAAAAEOZR/f1eguGaCURKH2UT5qJ3PjBVTsaL5ydJZ1AGwlREch/eK2SkD6dRpoNNIGDLvg==", "025 2902 0451", "4f5337e7-5add-41ce-af17-f5955dddcc51", "TaHien_Dao@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "23226 Trọng Kiên Land", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20Thu%E1%BA%ADn%20Th%C3%A0nh", "9a50c6ec-286a-409a-b91b-45f743d30c7c", new DateTime(2004, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "HuyQuang86@yahoo.com", "Phan Thuận Thành", "HUYQUANG86@YAHOO.COM", "HUYQUANG86@YAHOO.COM", "AQAAAAIAAYagAAAAEGw2Wa3tH6SQgQKaNg+gWsctvLH3zyEmla2BoPJBW0i9l+OaV598QatkC137Xrjnxg==", "021 4551 4644", "2bcbe0f7-af9d-4627-aa82-7937749c0474", "HuyQuang86@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "44908 Trúc Linh Overpass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20Kh%C3%A1nh%20Chi", "7ce9511c-0e0a-4ac2-8137-dfea72b14e52", new DateTime(1998, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "ThangCanh.Lam65@yahoo.com", "Trần Khánh Chi", 1, "THANGCANH.LAM65@YAHOO.COM", "THANGCANH.LAM65@YAHOO.COM", "AQAAAAIAAYagAAAAEL8qzULs2Mf7UpqmJf4Qg4Qdz0169KSmiA/koaeg+61b+Q2J6IJ97Ew1AaUHifY/ww==", "029 1362 6248", "250ef0cd-591b-462a-90ae-6f006e2b350e", "ThangCanh.Lam65@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "48831 Vũ Harbors", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20M%E1%BA%A1nh%20%C3%90%C3%ACnh", "0a4b6629-206c-4c1d-9f72-995d70a401e3", new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "TrienSinh51@gmail.com", "Đào Mạnh Ðình", 2, "TRIENSINH51@GMAIL.COM", "TRIENSINH51@GMAIL.COM", "AQAAAAIAAYagAAAAEMT8ZaaAYaiHSTXxjKbOduRUn9a4t1EnEpl0TjYPSOa8NL1cRU7yd1OCrbRNqH5E6Q==", "0203 2528 1449", "574f33f9-9503-422a-8e11-8f075f82763f", "TrienSinh51@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "502 Ðăng Ðạt Circles", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20S%C6%A1n%20Trang", "988b8ece-6f01-40bf-88ab-27bbdb6dde75", new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), "MaiThu38@hotmail.com", "Lê Sơn Trang", 1, "MAITHU38@HOTMAIL.COM", "MAITHU38@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPeFMKDgKjl0EsYb9ft0JhL0Snp/gFrWYLRnooPERgeWR15VXs8Eehh4P0MgGcbPAg==", "0287 9144 8479", "7fa10332-d83b-4ecf-9889-586e190fdcc3", "MaiThu38@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9286 Hà Plains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Tu%E1%BB%87%20Nhi", "3c41d58e-662f-49bf-92e2-b0d22492c3c8", new DateTime(2014, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "KimXuan_Le9@yahoo.com", "Tô Tuệ Nhi", 1, "KIMXUAN_LE9@YAHOO.COM", "KIMXUAN_LE9@YAHOO.COM", "AQAAAAIAAYagAAAAEGr92BDZX6shlL/BD6nOZNsfId7fADRf+ihHM3YuYsB7paqlvGFChVr3PrG1JGM6PA==", "029 4218 8838", "eb1f4ced-0d76-4789-8f00-ef487deb4b3b", "KimXuan_Le9@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4516 Hồ Path", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20H%C3%B2a%20B%C3%ACnh", "2b3df4b5-cea6-4b35-9b55-70d2ae8a8b0b", new DateTime(2010, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "LeChi_Dao@gmail.com", "Dương Hòa Bình", 2, "LECHI_DAO@GMAIL.COM", "LECHI_DAO@GMAIL.COM", "AQAAAAIAAYagAAAAEI3k+ZsGB300/3/gEhlw1oqUTro9IK8QLLJVCjJtqT4EUXqy6Ij8+qVXYeVeynHMcA==", "027 3365 4493", "e04fcee1-6d84-43cb-9fb7-6d67e3c819a5", "LeChi_Dao@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "177 Huệ An Stravenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20Ph%C3%BAc%20L%C3%A2m", "1e1123cd-6473-4dd9-90e7-962088cd8c8c", new DateTime(2018, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "PhucLam.Dao@yahoo.com", "Phan Phúc Lâm", "PHUCLAM.DAO@YAHOO.COM", "PHUCLAM.DAO@YAHOO.COM", "AQAAAAIAAYagAAAAENpIXjLtKwQuVexLmR0vbcrmISYLDwkczxXgzCQE+E7UdD4hMgTzdLxUWECbovLHRA==", "028 7568 1925", "51568c8b-09b5-43f4-b2be-15f4ad49fe4b", "PhucLam.Dao@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "37567 Phùng Fort", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20Hu%E1%BB%87%20L%C3%A2m", "7158aa15-ebae-4f28-b791-15850ee95c95", new DateTime(2018, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "PhuTho16@gmail.com", "Đoàn Huệ Lâm", 3, "PHUTHO16@GMAIL.COM", "PHUTHO16@GMAIL.COM", "AQAAAAIAAYagAAAAEJ2VsfQHwU3BDSLS9TxnKep6tltWuxUsR2C4nlr6dxaS3EihF0iKuPVYplISxTybUA==", "023 2602 9646", "a4af6eb2-da60-49b6-bbf7-81c0034663a7", "PhuTho16@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0387 Kim Duyên Rue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Di%E1%BB%87u%20Linh", "0808fd9f-3380-4951-b852-b33412d8343c", new DateTime(1998, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "DieuHong.Dao@yahoo.com", "Ngô Diệu Linh", 3, "DIEUHONG.DAO@YAHOO.COM", "DIEUHONG.DAO@YAHOO.COM", "AQAAAAIAAYagAAAAEDsm2WnI8bQv51/onSnukCEIfcoRN7i07m5q1z9nXWtUKq7MuKt0nNW/yq4V5IuCXg==", "021 9488 3699", "a7e817f7-de61-42a2-a744-52751c8f5d79", "DieuHong.Dao@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0066 Ngô Springs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Ho%C3%A0ng%20Hi%E1%BB%87p", "ebcf4c07-957c-4904-8ee4-42fc90d6a569", new DateTime(2000, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "QuangSang_Phung21@yahoo.com", "Đinh Hoàng Hiệp", "QUANGSANG_PHUNG21@YAHOO.COM", "QUANGSANG_PHUNG21@YAHOO.COM", "AQAAAAIAAYagAAAAECRc5momtItvAQo1ym32XSRjuSrV1Ues7EHs5lVvOKfzU/kliuoCiDfdUst6T394vg==", "027 5427 6162", "31e69208-d657-4ac0-bfcc-74c3cd469e97", "QuangSang_Phung21@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "12101 Kiên Trung Prairie", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Anh%20V%C5%A9", "59eb49d0-1ac7-4a23-819b-66fae0c4b68f", new DateTime(1998, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "NhaHuong9@hotmail.com", "Hà Anh Vũ", "NHAHUONG9@HOTMAIL.COM", "NHAHUONG9@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAsI57VnTjc5T/RM1Vr2QjiKIYZeoIjMLDDfeOrDwiA+E7sN6NpwOV57xfrS+pId2g==", "0284 0137 3778", "93bd45be-63a5-43e1-9252-07ddbfd0097f", "NhaHuong9@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "719 Việt Dương Road", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20Quang%20Anh", "d9f7af86-6150-4b72-80f3-43fd1d912f2f", new DateTime(2000, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "HoaiPhuong.Bui@hotmail.com", "Đào Quang Anh", 1, "HOAIPHUONG.BUI@HOTMAIL.COM", "HOAIPHUONG.BUI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIO/nxkzrSVT5R2QXAGLe08JEcevsmiTtwcDOGQvkhsY8e+e/d90hfIGQ7PFz/1mFw==", "0267 3721 8167", "df9c8820-b43f-47ee-bc9f-c86651e874b9", "HoaiPhuong.Bui@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "55494 Trương Parks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20%C3%90%E1%BB%A9c%20Phi", "2c6916a3-9037-4e5a-95bb-d2125ee7ef4c", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "QuangXuan_Tran@yahoo.com", "Tăng Ðức Phi", "QUANGXUAN_TRAN@YAHOO.COM", "QUANGXUAN_TRAN@YAHOO.COM", "AQAAAAIAAYagAAAAEBn2lwMdxUZ1/J6JXkOAYVm9HPTYUdNyxc7rB16nlkGZIV5G2CrH7g4U0TpDUwk26g==", "028 1173 5614", "fcdd555c-bcda-48ff-8a6b-40e91a543045", "QuangXuan_Tran@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "889 Quang Hà Manor", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20M%E1%BB%99ng%20Lan", "89c847cf-8885-4064-b48a-a4385386c12b", new DateTime(2012, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "KhoaTruong.Ho14@yahoo.com", "Trịnh Mộng Lan", "KHOATRUONG.HO14@YAHOO.COM", "KHOATRUONG.HO14@YAHOO.COM", "AQAAAAIAAYagAAAAEOLEonkz6zkxJz8C7E7e0ooHFBpvYYjVvlYXm3kUPIlsbOBOHVXEDsLU1yBvkpox7w==", "025 1270 7294", "f3148d6d-45cf-44c2-b9d2-414c6800af01", "KhoaTruong.Ho14@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9460 Nam Nhật Trace", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Minh%20Ph%C6%B0%C6%A1ng", "0b416bcf-3a00-47b9-9542-bf2a8c98c5a9", new DateTime(2001, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "TheDuyet_Truong@hotmail.com", "Bùi Minh Phương", 1, "THEDUYET_TRUONG@HOTMAIL.COM", "THEDUYET_TRUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAELr5jkWHh0tEdFpri3kZ+61cUXIBAoIY6+vzK88x4C5l/GADp8AwLbx0d31VPN7C1g==", "0204 3145 2940", "4de65614-5eb6-49a4-980e-f452b03f19d4", "TheDuyet_Truong@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "40967 Dương Harbors", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Ng%E1%BB%8Dc%20%C3%90i%E1%BB%87p", "36e4a4e2-19e5-4ece-a58c-b52247c7369f", new DateTime(2014, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), "DiepVy_Ha@hotmail.com", "Dương Ngọc Ðiệp", "DIEPVY_HA@HOTMAIL.COM", "DIEPVY_HA@HOTMAIL.COM", "AQAAAAIAAYagAAAAENR6vqxhKTpcRZfiamApD/IP9Md1BI03p4efZi30DNn/R6bn+Su30U9zg6C8MnyJgQ==", "020 6669 4929", "73e5e3d6-0be9-44af-8bd6-f3710a5df7e4", "DiepVy_Ha@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "196 Phạm Ville", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Th%C6%B0%E1%BB%A3ng%20Thu%E1%BA%ADt", "219b2733-4c82-4f06-aa89-2e6a61e2070a", new DateTime(2017, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "TuanLong.Dinh@gmail.com", "Hà Thượng Thuật", "TUANLONG.DINH@GMAIL.COM", "TUANLONG.DINH@GMAIL.COM", "AQAAAAIAAYagAAAAEOFN4w6NHrSky5y7oWY6iZ83f5R6WuiQG5tj0M2wIOQZIFfDavgVuOkAUKGxwjPqoA==", "021 6705 9319", "c54e0b1d-1300-4e92-a91d-7a2b4bbea0b3", "TuanLong.Dinh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9470 Hà Knolls", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Thanh%20H%E1%BA%A1nh", "e2dbc461-d9b1-4b0f-bf4b-69b6a746b040", new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "TuAnh_To92@yahoo.com", "Đặng Thanh Hạnh", "TUANH_TO92@YAHOO.COM", "TUANH_TO92@YAHOO.COM", "AQAAAAIAAYagAAAAEIdKIWlIGrdVXMw32A9DNRNdKzRPm2UuW0qiT9+ZcCB9sOb/VdNfgiw0o09L+aATyQ==", "0242 6906 4799", "6f596515-64e5-4483-a30b-236d71e898e2", "TuAnh_To92@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "72716 Hồ Path", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20Ng%E1%BB%8Dc%20Uy%C3%AAn", "9fbe916b-c3b3-413e-b5ae-6c28683493c5", new DateTime(2007, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "KimThu.Pham@gmail.com", "Nguyễn Ngọc Uyên", 2, "KIMTHU.PHAM@GMAIL.COM", "KIMTHU.PHAM@GMAIL.COM", "AQAAAAIAAYagAAAAEB+xHUJUlbkXocZMa8oBv/Mj0I3hav172Y1jh8AFDq5aWEX0mGRmA+tmTpdCLO8rBg==", "022 0975 1373", "58d230ef-6efa-4a80-8e20-a94432152f4f", "KimThu.Pham@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "37934 Uyên Thy Keys", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20B%C3%ADch%20Lam", "b957721b-85e8-48ab-bde2-3f453e7dfb1a", new DateTime(2007, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), "QuangMinh24@hotmail.com", "Tô Bích Lam", 3, "QUANGMINH24@HOTMAIL.COM", "QUANGMINH24@HOTMAIL.COM", "AQAAAAIAAYagAAAAENCDk2eUZhQe6EgxvRiWvl+dVZE8HcbtZSE1PFpSnBWznN6EF2nCwzjhkpx9MGxUhQ==", "029 5660 0337", "c46621d4-a21d-4a99-a798-73693566452a", "QuangMinh24@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0445 Vương Branch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Qu%E1%BA%A3ng%20%C3%90%E1%BA%A1i", "e083e8df-113b-4c97-bcf9-89b9fd57630c", new DateTime(1999, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "ThienLac_Ly84@yahoo.com", "Lý Quảng Ðại", "THIENLAC_LY84@YAHOO.COM", "THIENLAC_LY84@YAHOO.COM", "AQAAAAIAAYagAAAAEEprjMhZuL/FcUIH+0MiZZtSqdpCUqxNDYHSWNFYO3uiebCt6D5GpzHFztrzBxK7UA==", "0229 1033 5522", "2de9c032-de16-458e-a70a-318ead3e6e29", "ThienLac_Ly84@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "302 Đỗ Bypass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Xu%C3%A2n%20Hoa", "f93e2e9a-6bad-4b54-9487-7d0c74f20051", new DateTime(2004, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "TheSon.Vu@yahoo.com", "Lý Xuân Hoa", 3, "THESON.VU@YAHOO.COM", "THESON.VU@YAHOO.COM", "AQAAAAIAAYagAAAAEC1FK1vdWWWHwrxfXYRZCON0QNZYHWznouX+Lap8HnoDhz26CYSohT+czhmkH++Ffg==", "023 2582 9700", "f3e1399b-2297-4c45-a759-49a2cb23b505", "TheSon.Vu@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "18488 Ðình Ngân Orchard", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20S%C6%B0%C6%A1ng%20S%C6%B0%C6%A1ng", "f4f0ea52-0361-41fe-bbf3-506c639096e6", new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "BangSon.Nguyen@gmail.com", "Vương Sương Sương", 3, "BANGSON.NGUYEN@GMAIL.COM", "BANGSON.NGUYEN@GMAIL.COM", "AQAAAAIAAYagAAAAEAZLgDQMJwpjqzuQOCYFMcYZFnuZykFRECH1GDObR3z7VuCZOKBqvidxw47G7zR9vw==", "0215 7682 5601", "c4d580ac-26fe-4c72-9081-df4bdd8fd587", "BangSon.Nguyen@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "155 Phạm Squares", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20V%C3%A0ng%20Anh", "51e9155a-44e1-41a4-bc10-c0a69123e3c2", new DateTime(2003, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "TriHao.Bui19@yahoo.com", "Trương Vàng Anh", "TRIHAO.BUI19@YAHOO.COM", "TRIHAO.BUI19@YAHOO.COM", "AQAAAAIAAYagAAAAEJPxZ9z4KCBGkS2B0Bic6mXqIpLY+0UCW2rQb8IQM8pv9ZssGvQ/ksNmXY/f9Fan+A==", "0298 7142 0475", "e6cfecac-1758-4be5-9fb8-ad7a1d7871fe", "TriHao.Bui19@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "96061 Duy Uyên Vista", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20Thi%C3%AAn%20Duy%C3%AAn", "54f18306-69b4-4581-874c-61b8d8e41029", new DateTime(2012, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "HoaGiang36@hotmail.com", "Nguyễn Thiên Duyên", 3, "HOAGIANG36@HOTMAIL.COM", "HOAGIANG36@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPy1iFR7S5gDTiAMp+tgENAbHcXHF/T8nIAurghxQrXTSvFNf2uqjcIjEDhqE27b9g==", "022 9621 9989", "6892ec77-f655-4635-84e4-b70859487ff6", "HoaGiang36@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "443 Ngô Point", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Ng%E1%BB%8Dc%20H%C3%A2n", "d603549e-4ef4-4a46-9211-4634f6cdcb2e", new DateTime(2016, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "TrongTuong.Phung48@gmail.com", "Tô Ngọc Hân", "TRONGTUONG.PHUNG48@GMAIL.COM", "TRONGTUONG.PHUNG48@GMAIL.COM", "AQAAAAIAAYagAAAAENgPaB+HN2vdDor82JR9tW1+0Hezw/Z7acBHPyZbUyvmJ1SCr/viEyny9DjOXzKK1g==", "0206 2551 5335", "2a6d6088-be38-46a9-badc-bc0ffb80e0b7", "TrongTuong.Phung48@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "482 Sơn Giang Forks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Vi%E1%BB%87t%20Tuy%E1%BA%BFt", "df503cad-9433-414c-87f4-02aef114aab0", new DateTime(2002, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "NhatHung18@gmail.com", "Trương Việt Tuyết", 2, "NHATHUNG18@GMAIL.COM", "NHATHUNG18@GMAIL.COM", "AQAAAAIAAYagAAAAEATGFpOaXwwj22BpdTsJsIGxChaG79HrGbsmHLKxOEC7aKIuXWx/gm2pTIL4p/EkJg==", "0269 5788 2248", "ca1a7518-1b22-49ac-af9a-f48c3158cbae", "NhatHung18@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4353 Công Hậu Squares", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20C%C3%B4ng%20Hi%E1%BA%BFu", "9302498c-88f4-4d4f-a845-8270e040b12f", new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "DiemQuynh.Ho@gmail.com", "Đoàn Công Hiếu", 3, "DIEMQUYNH.HO@GMAIL.COM", "DIEMQUYNH.HO@GMAIL.COM", "AQAAAAIAAYagAAAAEO82bDVgQRhYq/CKFzxbLSkGWuF2WcwL9Ft38tf6gr80BxuaBqYE4hqxHLIO3+y4pw==", "027 0581 5604", "f3a59cab-3b07-42d3-aee3-836bc06d0f18", "DiemQuynh.Ho@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7175 Bùi Passage", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C5%A9%20L%E1%BB%87%20Chi", "1ca6d49d-6808-4255-af9e-e05dd0f2ed6b", new DateTime(2003, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "ThuanPhong67@hotmail.com", "Vũ Lệ Chi", "THUANPHONG67@HOTMAIL.COM", "THUANPHONG67@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEUkeP6JSSBSQR8sAk8CmrUhQ29lDbvCbgYa9xZC7OHTfnB8d3Q02BpyaveNTTJHCA==", "025 0112 7848", "c7656216-6c45-407d-9dd2-b73473c630c6", "ThuanPhong67@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "14061 Hồ Rapids", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Th%C6%B0%20S%C6%B0%C6%A1ng", "31e2f564-e159-4510-9d62-61a52c01ec83", new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "MinhHuyen.Nguyen@hotmail.com", "Trương Thư Sương", 2, "MINHHUYEN.NGUYEN@HOTMAIL.COM", "MINHHUYEN.NGUYEN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJieWwYrymyMWTFtKiXL75NkP+wePnIOXoy0L65ldud3SbzSWbLYfd9pEz0e29gzfA==", "023 4769 6878", "5f20037f-acff-4b60-b4d9-7e149213d007", "MinhHuyen.Nguyen@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4428 Tường Nguyên Trace", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Duy%20Th%E1%BA%AFng", "46312687-fa91-4a45-b24c-8b3af5f0ede0", new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "ThanhChau66@gmail.com", "Đặng Duy Thắng", 1, "THANHCHAU66@GMAIL.COM", "THANHCHAU66@GMAIL.COM", "AQAAAAIAAYagAAAAEBHrByPRxZDv/6HlYWhmVHQuf13Ta8CKfwAe6tUkqmPa6UOS67JiTDpvgmrDxK6a0Q==", "0219 9469 2411", "a1f5d85c-6638-4a27-b037-51d43339187a", "ThanhChau66@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "431 Trọng Kiên Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20V%C3%A2n%20Khanh", "2da4df49-c35b-4e27-9c61-7dbfc1260fa1", new DateTime(1995, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "DongPhuong40@gmail.com", "Hồ Vân Khanh", 2, "DONGPHUONG40@GMAIL.COM", "DONGPHUONG40@GMAIL.COM", "AQAAAAIAAYagAAAAEKv25zqokKenDiXMT2THKCLWBe1uCVXim2TdCklFAkcCnaGSoNMZpNndvUtRu3SpZA==", "0257 7367 3298", "23776d8f-0afa-4694-b413-320022dcf67e", "DongPhuong40@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3280 Ngọc Nhi Spring", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Quang%20L%C3%A2m", "2831ae53-dd09-4012-86fb-685b98acdf56", new DateTime(2006, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "GiaKhiem_Do@gmail.com", "Đinh Quang Lâm", 2, "GIAKHIEM_DO@GMAIL.COM", "GIAKHIEM_DO@GMAIL.COM", "AQAAAAIAAYagAAAAEGIC8UA51oIdjNc6g1fW5xnMRo4RSU6Df9WF62phC0oqClTwSG9C5AklwEqAXyeAtw==", "0207 6199 2797", "5d31ac37-99c1-4b16-8b38-09147d147231", "GiaKhiem_Do@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0293 Thảo Hương Manor", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20%C3%90%E1%BB%A9c%20T%C3%A2m", "da66177a-ae51-42d8-9399-52ba63397f4f", new DateTime(2009, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "TanNam_Lam@yahoo.com", "Vương Ðức Tâm", "TANNAM_LAM@YAHOO.COM", "TANNAM_LAM@YAHOO.COM", "AQAAAAIAAYagAAAAEPJzoL4uFBOWu9y3KnIcT/JmTGZN6fG9KxMk/I3+K90e8gNc0vSPmfk15i4kn2P/Dw==", "026 5502 0444", "7952a7c8-3ba6-4a73-be0c-913d3cb2e047", "TanNam_Lam@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "015 Đinh Fall", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20C%C3%B4ng%20Th%C3%A0nh", "6672f211-9cf4-4062-8834-cac4adb08078", new DateTime(1998, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "LongVinh_Trinh@yahoo.com", "Đoàn Công Thành", 2, "LONGVINH_TRINH@YAHOO.COM", "LONGVINH_TRINH@YAHOO.COM", "AQAAAAIAAYagAAAAEM36kg6zh8a/mFSRxr7QWd68vc5y87AvOv9u5DMoj7VaNXKBY8NFC5ZZrxV3AJRgaA==", "0227 5389 8739", "0c38d9df-cfea-4ad9-b80e-fd97a41be881", "LongVinh_Trinh@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8843 Ngô Mills", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20B%C4%83ng%20B%C4%83ng", "10f48f8d-87c3-4fa1-9db1-d25ce9dbcf11", new DateTime(2002, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "AnhTho_Duong@gmail.com", "Lý Băng Băng", "ANHTHO_DUONG@GMAIL.COM", "ANHTHO_DUONG@GMAIL.COM", "AQAAAAIAAYagAAAAECaguF9s1zbEc3RXsKjZlsd005srdOrg4f8aQL2Wvv3rvyx8cxTQ8GPVPI9BouIhug==", "0277 3088 6183", "058311f7-5b1e-43b4-85e2-7a5ce040d346", "AnhTho_Duong@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "786 Hải Phương Plaza", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Uy%C3%AAn%20Minh", "c40a6315-39f4-49de-8250-051bd9bf642d", new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), "LamNhi.Pham@yahoo.com", "Vương Uyên Minh", 1, "LAMNHI.PHAM@YAHOO.COM", "LAMNHI.PHAM@YAHOO.COM", "AQAAAAIAAYagAAAAEDeRk9exotdSB0bJpbszLTMIVg1Hbilc1t9tdUipxcK5dt121KgSSRVHrQs5Rt6yJg==", "025 9016 9953", "0754a287-b1e1-474a-9e90-3bccd492c8fb", "LamNhi.Pham@yahoo.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageRating",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 16, 0, 0, 0), "Beatae accusamus vitae.", 8, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 0, 0, 0), "Ut minus odit enim unde et eos.", 24, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 18, 0, 0, 0), "Accusamus in error.", 55, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 9, 0, 0, 0), "Magni ut blanditiis vel sed distinctio.", 12, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 18, 0, 0, 0), "Blanditiis expedita aut aperiam unde aut et aut quae.", 89, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Pariatur nulla dolorum ducimus.", 46, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 16, 0, 0, 0), "Labore alias eveniet repudiandae quia qui velit.", 95, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 15, 0, 0, 0), "A quaerat deleniti ut perferendis cumque.", 14, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Enim voluptatem doloremque rerum nisi dignissimos est.", 81, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Mollitia fugit aut quasi atque dicta.", 75, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 14, 0, 0, 0), "Enim quasi et itaque quidem.", 21, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 15, 0, 0, 0), "Eligendi consectetur aperiam dolor dolor dolore accusamus.", 61, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 13, "Quidem earum itaque ut.", 86, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 13, 0, 0, 0), "Sit eum sint magni tenetur eum.", 78, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Soluta aspernatur iusto officiis repudiandae doloribus tempora qui possimus.", 86, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 9, 0, 0, 0), "Inventore odio provident est qui quasi dolor dolor.", 80, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Et ut ipsa a et dolore dicta dolor accusantium.", 39, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 15, 0, 0, 0), "Delectus voluptatem eum voluptatem enim.", 60, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 15, 0, 0, 0), "A mollitia sequi deleniti.", 11, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 9, 0, 0, 0), "Est recusandae dicta unde saepe ut inventore.", 57, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 18, 0, 0, 0), "Eum quo dignissimos sint rerum.", 74, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 14, 0, 0, 0), "Quibusdam laudantium et quae.", 64, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 15, 0, 0, 0), "Porro quaerat voluptas aut.", 10, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 11, 0, 0, 0), "Minus doloremque ut molestiae corporis nihil.", 87, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 13, 0, 0, 0), "Molestiae non consequatur ipsam.", 27, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 12, 0, 0, 0), "Sit reprehenderit molestiae dolorum temporibus voluptatibus itaque quaerat harum sequi.", 49, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 10, 0, 0, 0), "Natus iure dolor quam qui officiis dolorem voluptatem sunt quo.", 9, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 10, 0, 0, 0), "Cum voluptas eius nihil nostrum consequatur.", 43, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 19, "Dignissimos omnis modi hic.", 45, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 15, 0, 0, 0), "Qui in omnis occaecati eveniet.", 31, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 9, 0, 0, 0), "Est rerum aut doloribus odit ea deserunt voluptates veritatis ut.", new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 17, 0, 0, 0), "Amet at voluptas dolore consequatur labore nulla doloribus neque nobis.", 33, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), "Eos dolor optio deserunt possimus perferendis.", 72, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 9, 0, 0, 0), "Maxime veniam sit quia ut illum ipsa nihil labore.", 79, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 13, 0, 0, 0), "Eligendi id officia ut quia omnis porro.", 94, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 15, 0, 0, 0), "Harum voluptatem error dolores est illum ullam voluptatem.", 64, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 16, 0, 0, 0), "Reprehenderit et pariatur illum id aut saepe.", 8, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 0, 0, 0), "Minima facilis ea.", 38, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), "Modi aut quidem nam quia nulla voluptas sint.", 13, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 12, 0, 0, 0), "Iste non nostrum aut commodi distinctio fuga voluptatibus aliquam.", 13, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 14, 0, 0, 0), "Porro nulla delectus dolores magni accusantium eos earum qui quia.", 6, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 0, 0, 0), "Odit porro recusandae eveniet.", 59, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 9, 0, 0, 0), "Culpa nemo assumenda.", 21, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), "Nesciunt enim repudiandae et.", new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 13, 0, 0, 0), "Amet dignissimos sed voluptatem.", 83, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), 9, "Modi veniam omnis quam aspernatur possimus eius labore.", 10, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 19, "Aspernatur deleniti sequi cupiditate quia voluptas iure quaerat numquam.", 83, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 13, 0, 0, 0), "Recusandae vitae neque aut facilis eveniet iure sed.", 82, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 16, 0, 0, 0), "Vel nobis est repudiandae in similique totam minus.", 36, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 15, 0, 0, 0), "Vel qui accusantium eaque qui nemo nobis.", 87, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 0, 0, 0), "Consequuntur deserunt veniam quasi in aliquam sint.", 98, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 0, 0, 0), "Laborum ut aut minus ea autem.", 17, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 0, 0, 0), "Minima in libero.", 45, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 16, 0, 0, 0), "Architecto dignissimos voluptatem placeat.", 81, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), "Magni repudiandae assumenda recusandae aut.", 48, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Nesciunt et esse rerum illum aut reiciendis atque est aliquam.", 33, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), 12, "Saepe quod aliquid ea et.", 19, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 12, 0, 0, 0), "Tenetur voluptatum qui possimus itaque.", 12, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), "Adipisci accusantium dolorum assumenda recusandae.", new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 12, 0, 0, 0), "Officiis similique est a aut error nemo aut libero.", 7, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 14, 0, 0, 0), "Repellat repellendus natus vel ad quia esse laudantium quis omnis.", 79, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Quia odit exercitationem dignissimos et qui quia quod.", 49, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), 19, "Quasi minus porro veniam eos sed ut minima omnis.", 78, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 18, 0, 0, 0), "Inventore praesentium qui qui culpa sit eius.", 10, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), "Error neque quia ad eligendi.", 15, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 11, "Quas ut pariatur et vel quasi voluptate aut qui.", 52, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 16, 0, 0, 0), "Ea eius delectus voluptatem sed earum veniam repudiandae.", 90, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 13, 0, 0, 0), "Rem quis ut voluptas.", 28, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 14, 0, 0, 0), "Molestias omnis in et neque.", 78, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), 7, "Cum odio harum id aperiam et sint.", 94, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Qui illo at dolorem id inventore quos quidem.", 15, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 10, 0, 0, 0), "Ea laborum voluptates est accusamus sit et doloremque.", 70, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 10, 0, 0, 0), "Est perferendis eligendi consequatur quaerat necessitatibus.", 85, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 9, 0, 0, 0), "Iste et molestiae quas dolorum dignissimos.", 47, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 11, 0, 0, 0), "Voluptatem consequatur molestias.", 22, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 13, 0, 0, 0), "Eius enim suscipit.", 50, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Voluptas at quam consequatur dolorem ea in.", 41, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AppointmentDate", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), "Libero aut autem quia magni consequuntur libero.", 9, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), 9, "Omnis explicabo tenetur fugiat recusandae consequuntur nihil sint sequi.", 29, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 18, 0, 0, 0), "Quia placeat perspiciatis ea nemo consequatur ab magni velit.", 14, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), "Officia rerum nemo cupiditate qui necessitatibus cupiditate enim rem.", 94, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 13, 0, 0, 0), "Cum laudantium ut excepturi autem.", 23, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), "Qui iste autem saepe at eius suscipit rerum.", 35, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), "Nisi rerum ut sequi illo quaerat voluptatem non.", 79, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 10, 0, 0, 0), "Ducimus culpa culpa recusandae quis illo ad voluptates.", 49, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 9, 0, 0, 0), "Ab culpa repudiandae debitis.", 38, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), "Inventore ea eaque expedita sunt aliquam enim.", 52, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Ea optio similique sit rem est sit ex exercitationem voluptas.", 48, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), "Qui rem dolor adipisci eos ipsa impedit voluptas non vel.", 28, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 15, 0, 0, 0), "Provident fuga voluptas enim consequatur consequatur deserunt numquam recusandae repellat.", 72, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 12, 0, 0, 0), "Temporibus non velit reiciendis temporibus eum ab.", 43, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 17, 0, 0, 0), "Qui sint et reprehenderit.", 25, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), 2, "Reiciendis eius velit.", 85, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), "Optio qui sit aliquid consequuntur deserunt et.", 55, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), "Ipsum tempore explicabo molestiae est id et.", 57, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 15, 0, 0, 0), "Fuga quod autem quis.", 3, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 15, 0, 0, 0), "Est odio dolore eaque delectus aut hic aliquam.", 44, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 17, 0, 0, 0), "Enim quaerat consequatur aut sapiente nisi sit ut.", 67, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 13, 0, 0, 0), "Illum ea vel et inventore quis voluptate vel maiores.", 97, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 6, "Sed ipsa eum suscipit aut voluptas qui.", 70 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 16, 0, 0, 0), "Non non aut quasi repellendus.", 26, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 18, 0, 0, 0), "Fugiat et id eligendi sit quo tempora aut.", 58, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 14, 0, 0, 0), "Cumque eum ut.", 1, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 12, 0, 0, 0), "Rerum quos labore animi.", 48, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 16, 0, 0, 0), "Molestias dolor autem et nihil possimus explicabo accusantium.", 30, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 14, 0, 0, 0), "Autem omnis omnis explicabo doloribus et autem necessitatibus animi.", 80, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 13, 0, 0, 0), "Incidunt tempore autem.", 95, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), "Commodi ratione qui sed officiis modi.", 3, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 11, 0, 0, 0), "Excepturi maxime fugit soluta.", 46, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 15, 0, 0, 0), "Vero soluta nesciunt qui sed ex.", 15, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Nihil omnis illum magnam velit qui sit incidunt laboriosam praesentium.", 30, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 12, 0, 0, 0), "Ducimus provident dolore ipsam iste corporis.", 2, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 17, 0, 0, 0), "Qui quia quia quas eos nulla ut.", 31, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 12, 0, 0, 0), "Consequuntur veritatis possimus ut dolor deserunt asperiores culpa illo aut.", 32, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Qui qui debitis beatae et omnis.", 7, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 10, 0, 0, 0), "Rem molestiae molestiae autem facere laboriosam ex.", 56, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 9, 0, 0, 0), "Quos delectus et.", 3, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), "Veniam et ratione perspiciatis quas.", 100, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 17, 0, 0, 0), "Nam aut porro sed eaque illo quasi ut officia.", 75, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 14, 0, 0, 0), "Enim neque exercitationem omnis.", 86, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 12, "Vitae maxime quia qui neque ut nam magnam repudiandae consequatur.", 26 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 12, 0, 0, 0), "Voluptas omnis placeat asperiores quae omnis optio aut itaque et.", 58, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), "Modi porro facilis minima.", 72, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), 5, "Reiciendis unde est itaque et perspiciatis et.", 14, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 13, "Nulla est aspernatur corporis et autem.", 65, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 10, 0, 0, 0), "Doloremque ducimus illum.", 38, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), 3, "Libero veniam quia rerum et quis consequatur accusamus aspernatur iste.", 27, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), "Et ut architecto magni laudantium molestiae vel eos.", 100, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 15, 0, 0, 0), "Aspernatur molestiae a earum odio eaque.", 70, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), "Unde vel deserunt quia optio placeat ab.", 2, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 15, 0, 0, 0), "Sint ut dolor quidem quia possimus et voluptas doloribus sequi.", 2, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 12, 0, 0, 0), "Beatae molestias hic.", 7, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), 20, "Aut dolor dolor deleniti quia.", 100, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), 7, "Ipsum maiores ratione voluptates ut voluptatem cupiditate neque.", 41, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), "Quia atque dolores.", 66, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 17, 0, 0, 0), "Corrupti ad non excepturi voluptatem veniam.", 23, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 18, 0, 0, 0), "Quia qui accusamus earum.", 58, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 15, 0, 0, 0), "Eius sapiente quia harum occaecati.", 11, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 11, 0, 0, 0), "Omnis vitae qui molestias animi architecto.", 96, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 18, 0, 0, 0), "Molestiae excepturi eaque est eligendi veritatis quisquam.", 77, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 18, 0, 0, 0), "Quo alias voluptas architecto.", 7, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 11, 0, 0, 0), "Voluptatem ea magni.", 12, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 17, 0, 0, 0), "Assumenda fugit laboriosam omnis ab.", 81, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 16, 0, 0, 0), "Ad dolores sequi tempora rerum eligendi vel consequatur voluptates.", 27, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 10, 0, 0, 0), "Qui velit sunt sequi modi sit similique et quae.", 52, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 14, 0, 0, 0), "Qui et eum quaerat reiciendis quam consequatur veritatis necessitatibus.", 18, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 17, 0, 0, 0), "Deleniti nemo exercitationem suscipit repudiandae iure consectetur ex reiciendis aut.", 39, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 15, 0, 0, 0), "Hic at veritatis aut et.", 75, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 17, 0, 0, 0), "Id totam amet voluptatem perspiciatis laudantium saepe debitis consequuntur debitis.", 53, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), 12, "Nesciunt ullam neque temporibus.", 35, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), "Quis sapiente maxime consequatur cum quae sapiente nobis soluta fuga.", 44, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 0, 0, 0), "Temporibus non magni asperiores vel nostrum est nemo.", 18, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), "Quidem voluptas officia nobis corporis.", 7, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 18, 0, 0, 0), "Quibusdam incidunt animi earum.", 33, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), "Aut unde blanditiis eveniet ut inventore libero eveniet sequi.", 50, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), 6, "Et qui nostrum quod voluptatum impedit assumenda.", 70, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), "Minus sapiente unde.", 35, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), 16, "Amet id totam reprehenderit itaque voluptatem molestias optio fuga et.", 3, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 9, 0, 0, 0), "Quibusdam officia velit dolorem est est ab delectus.", 76, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 15, 0, 0, 0), "Non saepe dolore ipsum voluptatem est consectetur quae similique ut.", 101, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), "Ut iusto eius ad.", 50, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 16, 0, 0, 0), "Optio rerum officiis repellendus sit non velit.", 4, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 12, 0, 0, 0), "Quia nesciunt culpa.", 35, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), "Praesentium quisquam nisi a cupiditate.", 50, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 13, 0, 0, 0), "Aliquid modi neque omnis possimus accusamus ut voluptatibus aut.", 77, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), "Eveniet voluptas dolore odio dicta omnis voluptatem deserunt.", 3, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 0, 0, 0), "Et quae excepturi minima est et perferendis.", 86, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), 4, "Quas iusto necessitatibus ullam quos.", 55, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 10, 0, 0, 0), "Quia necessitatibus ratione inventore sed omnis.", 60, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 13, 0, 0, 0), "Voluptatum molestiae quis ex.", 95, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 17, 0, 0, 0), "Ea voluptas veritatis quis amet et reprehenderit accusamus.", 83, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 0, 0, 0), "Ab sint eum recusandae adipisci similique explicabo numquam voluptas.", 53, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 17, 0, 0, 0), "Consequatur et voluptas nulla est quia cupiditate.", 40, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 10, 0, 0, 0), "Repellendus molestias voluptatum.", 47, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Et unde dolorem est et autem expedita.", 34, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 18, 0, 0, 0), "Voluptatem at excepturi fugit eos et aliquid.", 43, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), "Sunt ut est quis maxime dolorem perspiciatis.", 4, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 4, "Est dolorem quo fugit optio et.", 80, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), 1, "Ut et incidunt iste quae est quia doloribus.", 64 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 9, 0, 0, 0), "Aut et architecto consequatur quia excepturi nobis et autem.", 20, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 16, 0, 0, 0), "Fuga in id perferendis quos amet illum tenetur pariatur eligendi.", 46, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 16, 0, 0, 0), "In dolorem placeat alias sequi explicabo voluptates dolorum totam.", 88, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 16, 0, 0, 0), "Sapiente repellat rerum laborum hic similique qui harum officiis voluptatum.", 80, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 12, 0, 0, 0), "Sit vel corporis eum minus enim modi.", 45, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 9, 0, 0, 0), "Accusamus provident aut corporis repellendus et suscipit non.", 85, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 18, 0, 0, 0), "Ut sit provident ab blanditiis.", 46, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 12, 0, 0, 0), "Id iure dolores dolore eveniet vel odio quibusdam.", 57, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), "Similique placeat eveniet temporibus voluptatem voluptates voluptatum.", 99, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 15, 0, 0, 0), "Natus hic magni.", 65, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), "Nisi consequatur laborum sit.", 74, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 11, 0, 0, 0), "Sit sed et qui autem quis in.", 83, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 12, 0, 0, 0), "Numquam possimus ipsam debitis labore.", 2, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 0, 0, 0), "Ab optio ab dolores voluptas aut placeat.", 55, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Quia voluptatibus error dolorem iste nemo est.", 19, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 11, 0, 0, 0), "Doloribus accusamus eius perspiciatis eum commodi.", 22, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 16, 0, 0, 0), "Voluptas totam eaque hic esse ipsum a.", 72, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), 16, "Corporis dolore ipsam sit distinctio nesciunt nobis.", 100, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 13, 0, 0, 0), "Aliquam similique illum excepturi labore molestiae culpa.", 94, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 16, 0, 0, 0), "Corporis nostrum consequatur aliquam vel quia corporis corrupti officia omnis.", 88, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 16, 0, 0, 0), "Fugiat iure esse explicabo fugit aut aspernatur atque qui minima.", 13, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 12, 0, 0, 0), "Et explicabo quibusdam impedit quis dignissimos dolor rerum voluptates minima.", 53, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), "Ea qui aperiam odit non eos vero saepe occaecati placeat.", 58, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 0, 0, 0), "Debitis iusto odit unde facilis expedita suscipit quisquam.", 68, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Consequuntur quae rerum quia rerum maxime impedit rerum.", 48, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 16, 0, 0, 0), "Eos necessitatibus maxime.", 60, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 17, 0, 0, 0), "Non quia dolorem quo perspiciatis eius rem et.", 36, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 14, 0, 0, 0), "Voluptas id reprehenderit magnam praesentium alias.", 52, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 17, 0, 0, 0), "Vel vero perspiciatis quia hic tenetur alias eum dolorum neque.", 14, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 17, 0, 0, 0), "Temporibus provident molestiae debitis voluptatem.", 51, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 16, 0, 0, 0), "Officiis quis sunt.", 85, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 14, 0, 0, 0), "Unde mollitia repellat quibusdam est.", 46, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), "Sequi vero odio voluptatem.", 64, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 10, 0, 0, 0), "Laudantium debitis unde rerum consectetur illum et.", 62, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), "Quis ad ipsa exercitationem architecto et et.", 40, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 18, 0, 0, 0), "Iusto adipisci qui repellat numquam est eum beatae.", 90, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Necessitatibus nobis ducimus corporis.", 16, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Reiciendis error voluptatibus mollitia aliquid ratione.", 18, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 15, 0, 0, 0), "Eos et praesentium ullam perferendis maxime.", 63, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 13, 0, 0, 0), "Temporibus quos ipsa magnam.", 19, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), "Nemo ut reprehenderit quia.", 42, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 13, 0, 0, 0), "Aut quasi eius.", 45, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 18, 0, 0, 0), "Quia amet ut quia et officia debitis quo.", 46, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 15, 0, 0, 0), "Aut eaque doloribus quod dicta ea vel cumque consectetur eos.", 93, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), "Quibusdam eos error quis quis ut.", 52, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AppointmentDate", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Eum commodi id repudiandae fugit quia minus eveniet.", 37, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), "Et incidunt est fugit eius explicabo.", 4, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Voluptatem dolores molestias error voluptatem facilis eum praesentium consequuntur.", 77, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), "Et eum ut expedita omnis.", 44, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Voluptatem excepturi autem.", 54, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 17, 0, 0, 0), "Debitis maiores nesciunt ducimus id rerum aspernatur laudantium cumque est.", 25, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 12, 0, 0, 0), "Fugit rerum magni quisquam corrupti velit.", 29, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 0, 0, 0), "Est voluptatem natus fuga voluptatem et itaque.", 14, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 13, 0, 0, 0), "In mollitia sint.", 24, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 11, 0, 0, 0), "Blanditiis neque nemo vitae consequuntur.", 92, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 14, 0, 0, 0), "Delectus nostrum fuga eligendi alias ullam consequuntur vitae dicta enim.", new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 14, 0, 0, 0), "Nostrum voluptatem consequatur non et autem minus dolores est quam.", 7, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), "Voluptatum eligendi consequatur voluptatum voluptas numquam voluptatem aut sed.", 60, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), 16, "Quia dolor praesentium pariatur illo provident velit nesciunt doloremque.", 83, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 18, 0, 0, 0), "Qui libero eum ut.", 40, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 15, 0, 0, 0), "Ex odio dolores amet.", 38, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 20, "Quia libero ipsa inventore porro aut illum placeat laudantium.", 89, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 17, "Recusandae quisquam dolores.", 26, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 9, 0, 0, 0), "Dolorem expedita est et culpa possimus.", 29, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 11, 0, 0, 0), "Qui voluptate et quos voluptatem qui suscipit omnis nobis.", 23, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 16, 0, 0, 0), "Consequatur at aut accusantium non provident officia.", 82, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 14, 0, 0, 0), "Et vel tenetur vel voluptates.", 20, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 9, 0, 0, 0), "Vel repudiandae aliquam ad a omnis.", 26, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 16, 0, 0, 0), "Aut enim molestiae.", 81, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 4, "Sunt aliquid libero eveniet delectus sit praesentium aut.", 15, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Pariatur ut ut animi consectetur.", 51, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 14, "Porro facilis nobis dolor sapiente facere est similique ut neque.", 7, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 9, 0, 0, 0), "Deleniti sit reiciendis labore.", 44, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 0, 0, 0), "Iure dicta dolor reiciendis similique ipsam eum sed.", 49, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AppointmentDate", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Quis velit fugit minima animi architecto corrupti qui.", 92, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 15, 0, 0, 0), "Officiis eius placeat incidunt velit est dicta a.", 38, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 14, 0, 0, 0), "Dignissimos facilis ut beatae quis.", 44, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 11, 0, 0, 0), "Assumenda ut et nisi aspernatur sed dolorum neque rerum.", 101, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), 20, "Et numquam voluptatem eum voluptatibus consequatur voluptate temporibus.", 97, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 11, 0, 0, 0), "Aut nobis quae earum quia.", 82, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 15, 0, 0, 0), "Ullam porro ut.", 60, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), "Magnam numquam dignissimos velit eos rerum in qui.", 56, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), "Corrupti optio assumenda harum officia nesciunt porro possimus rem.", 28, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 9, 0, 0, 0), "Alias unde in quis et facilis amet veritatis eligendi sapiente.", 89, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 18, 0, 0, 0), "Fuga necessitatibus doloribus repudiandae pariatur exercitationem libero.", 66, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), "Mollitia debitis id voluptatem omnis omnis qui sunt quo voluptatem.", 86, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 13, 0, 0, 0), "Fugit necessitatibus deleniti culpa porro sit.", 76, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 17, 0, 0, 0), "Quam fugiat et.", 72, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 9, 0, 0, 0), "Architecto veritatis saepe praesentium.", 79, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 16, 0, 0, 0), "Excepturi quod quos qui.", 54, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 15, 0, 0, 0), "Tempora quis est amet id veniam officiis.", 53, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 13, 0, 0, 0), "Quia ut eos porro.", 66, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 10, 0, 0, 0), "Facilis natus enim.", 66, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), "Est ea quis voluptatem.", 96, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 0, 0, 0), "Et amet adipisci corrupti voluptates dolores quo.", 55, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), "Ea maxime consequatur saepe velit et et et impedit beatae.", 94, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 6, "Nobis sunt vel aut delectus blanditiis.", 32, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), 18, "Voluptatum non et dolorem.", 8, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 15, 0, 0, 0), "Ea exercitationem sapiente neque qui.", 54, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Non aut quia qui sapiente placeat esse.", 100, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 16, 0, 0, 0), "Possimus beatae velit.", 30, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), "Repellat magni laborum voluptatem.", 71, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Officia aspernatur nostrum vitae.", 89, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 9, 0, 0, 0), "Eveniet facilis tenetur sapiente iste vero nulla ipsa.", 57, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 17, 0, 0, 0), "Perferendis praesentium doloremque voluptatem sit beatae earum consequatur.", 56, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 12, 0, 0, 0), "Aliquam nostrum nemo nihil enim vel.", 16, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 14, 0, 0, 0), "Fugit aliquid ut maiores cumque atque.", 12, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 16, 0, 0, 0), "Doloribus quo doloremque consequuntur optio corrupti.", 99, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 17, 0, 0, 0), "Quo expedita magnam sapiente fugit repellat at et id.", 68, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), 3, "Commodi occaecati placeat velit illo omnis.", 86, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 13, 0, 0, 0), "Libero expedita autem et vero laudantium nisi magni dolores sunt.", 32, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 16, 0, 0, 0), "Autem laborum quaerat et ratione repellat omnis sapiente.", 71, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 18, 0, 0, 0), "Et veritatis architecto sint mollitia ipsa alias.", 10, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 14, "Dignissimos ab autem pariatur nulla libero.", 52, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 11, 0, 0, 0), "Molestiae quaerat cupiditate.", 28, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), "Hic aut unde.", 68, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 10, 0, 0, 0), "Ad non eos voluptate accusantium tempore labore.", 76, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 10, "Est qui laboriosam pariatur voluptatum excepturi perspiciatis illo natus doloribus.", 35, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 12, "Enim debitis fugit cumque autem et.", 100, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), "Dolorem similique quia non omnis id.", 84, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), "Modi voluptas optio vero blanditiis nulla.", 10, new TimeSpan(0, 10, 0, 0, 0), 3 });

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
                keyValue: 4,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Tim mạch", 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Đa khoa", 1, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Thần kinh", 10 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Nhi khoa", 5, 6 });

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
                values: new object[] { "Bác sĩ có hơn 3 năm trong lĩnh vực Da liễu", 3, 3 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Da liễu", 3, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Tim mạch", 2, 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Thần kinh", 4, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Đa khoa", 1, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Da liễu", 3, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Thần kinh", 4, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 3 năm trong lĩnh vực Đa khoa", 1, 3 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Tim mạch", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Nhi khoa", 5, 8 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da985e81-e3a4-44f9-8822-89670e554761", "AQAAAAIAAYagAAAAEL0Mi9lUGgKAAUxRQ5/Fe9yezQy3E/DAPw1MBTz1baFngmSaHSQ5FYl9EEJRuUI0OQ==", "4923398e-fa15-4beb-9a1f-3db168d089eb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "57613 Đỗ Forges", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20H%C3%A0m%20%C3%9D", "91fe7eb1-103e-4849-83bf-959b19508e6c", new DateTime(1995, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), "ThuyVan.Ngo@gmail.com", "Đặng Hàm Ý", "THUYVAN.NGO@GMAIL.COM", "THUYVAN.NGO@GMAIL.COM", "AQAAAAIAAYagAAAAEHvDZrb1WnxbcshHsQktNN3tHdCQunBA1KmEe5w/nOP5t1XLqwudi8c/JyOEt9h1DQ==", "022 6578 7287", "a57ebb80-8ba3-461b-949a-269c82bce47f", "ThuyVan.Ngo@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "916 Hồ Spring", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Ng%E1%BB%8Dc%20Kh%C6%B0%C6%A1ng", "33ab15e8-0b11-403d-8ec1-8763a59af938", new DateTime(2014, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "ThiNgon.Lam97@hotmail.com", "Hồ Ngọc Khương", 2, "THINGON.LAM97@HOTMAIL.COM", "THINGON.LAM97@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIi2HOocPXtCt2/jfLW/Frj43uBGGux0Zkaqa0KHxUbYmrvpcDpnJF4OH3GgYwOHSQ==", "023 6818 8424", "91b8a5da-afee-4346-bb3f-3de5f3157fc4", "ThiNgon.Lam97@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "807 Nhật Phương Mountain", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20L%E1%BB%87%20Chi", "6f9daf46-f757-4910-9a1b-caa02162bfba", new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "ThuyVu_Ly90@gmail.com", "Đỗ Lệ Chi", 3, "THUYVU_LY90@GMAIL.COM", "THUYVU_LY90@GMAIL.COM", "AQAAAAIAAYagAAAAEOW+d8c/+Buh+kjQuXwrx3d2Rs53+U+821NQxzJzRmCX0aP8JafRNeUGTVXaWfqxJw==", "0290 7935 2584", "c9ce665f-bc40-437c-8407-f54f55ff5cfb", "ThuyVu_Ly90@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3625 Vương Court", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Ph%C6%B0%C6%A1ng%20Trinh", "8a9b318c-c549-411c-bf33-c49a83138b77", new DateTime(2009, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), "CongGiang_Dang73@hotmail.com", "Tô Phương Trinh", 2, "CONGGIANG_DANG73@HOTMAIL.COM", "CONGGIANG_DANG73@HOTMAIL.COM", "AQAAAAIAAYagAAAAECb3muSINz30/JauJWo+kLny8N+JP/8AbW6fk+EvE6aRckCtWr7IlS2Eiq9hwe9m2A==", "023 8795 7170", "c3a99a17-2d0a-4ce5-b10a-9d506056f6f2", "CongGiang_Dang73@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "31707 Lâm Terrace", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Long%20V%E1%BB%8Bnh", "73feb72d-03f6-4388-b94e-f888e3dd334b", new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "ThyOanh.Duong@hotmail.com", "Phùng Long Vịnh", "THYOANH.DUONG@HOTMAIL.COM", "THYOANH.DUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBX5bfBLzU79mppxTX9QAKPvy7a5VKnU5ANGvQD6oi316zFaRLXgj73dLiGvFyLZrA==", "026 4636 7653", "dc3becdc-644f-42ba-8358-7f1bad6d62fd", "ThyOanh.Duong@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "54189 Nam Tú Wells", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Ch%E1%BA%A5n%20H%C3%B9ng", "50a46f7a-2970-4e8e-8d61-9f37d69ee41c", new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "PhuongThe15@gmail.com", "Trịnh Chấn Hùng", 3, "PHUONGTHE15@GMAIL.COM", "PHUONGTHE15@GMAIL.COM", "AQAAAAIAAYagAAAAEKneSybsJ3lkPCoKElWXb59a8Z9tvpvPAfZS/TGSnTyvyaHWfmVPR7qMGIkUPZs0uQ==", "025 2759 6048", "e9350bab-be88-46cb-83a1-42935a66e75a", "PhuongThe15@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4497 Chí Giang Terrace", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Tr%C3%BAc%20Sinh", "4380015f-283e-46d3-aed3-f9aea4fcdd45", new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "DuyNgon.Tang90@gmail.com", "Lê Trúc Sinh", 1, "DUYNGON.TANG90@GMAIL.COM", "DUYNGON.TANG90@GMAIL.COM", "AQAAAAIAAYagAAAAEPrwhMADYkionm0S+GAqdlln47MaoDDCY8183pNczcTE9UE9Hz5YPyvNHdHEoRDiOA==", "0214 8757 2187", "4b2c36ca-3deb-4754-b1e6-a56857f1f433", "DuyNgon.Tang90@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "831 Tuấn Tú Way", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Duy%20Minh", "54aa5aff-f180-4133-987f-3a762ad7bc68", new DateTime(2022, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "AnDi99@gmail.com", "Vương Duy Minh", 3, "ANDI99@GMAIL.COM", "ANDI99@GMAIL.COM", "AQAAAAIAAYagAAAAENI9Cy9awOA7h44TR0yQrBoCJuabRa6Jjkot5h5w3sQ3yhK0vsNZ66cTSRFEM03IRg==", "0266 3576 7522", "1605d03a-03a1-4857-90a7-6a4e795ca8ee", "AnDi99@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "29309 Phan Squares", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20L%E1%BA%A1c%20Nh%C3%A2n", "010b096d-78de-49fe-9e99-80d8ccc535da", new DateTime(1999, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "HongQuy_Ha@gmail.com", "Phan Lạc Nhân", "HONGQUY_HA@GMAIL.COM", "HONGQUY_HA@GMAIL.COM", "AQAAAAIAAYagAAAAEJYnCcBEQ9YM5wrGqBVfTAHeTjZZGxKoeDOZ+WTe3w2rLejzszW1TZgGlDWLFR1+nQ==", "0258 5383 0555", "a3f332cb-a341-43a0-9ac1-570642193e49", "HongQuy_Ha@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "40125 Trần Corner", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Ng%E1%BB%8Dc%20Quang", "ee35e780-24b9-4f9c-a864-a55b382a3198", new DateTime(2014, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "BaThinh_Ngo@gmail.com", "Mai Ngọc Quang", "BATHINH_NGO@GMAIL.COM", "BATHINH_NGO@GMAIL.COM", "AQAAAAIAAYagAAAAEFq1YQ/lo0pQHi/jXpRUknmjFbKZPC58pXG+SSGWph4IWHR7/BHGqzmLVc0FezGxtA==", "025 1596 7062", "5c859042-f8fb-4b40-904f-6eb26371af5f", "BaThinh_Ngo@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "026 Mai Curve", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20B%C3%A1%20Thi%E1%BB%87n", "b43fc295-0ce3-478f-93d5-e154b7c70082", new DateTime(2018, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "LongQuan.Nguyen@gmail.com", "Lý Bá Thiện", 1, "LONGQUAN.NGUYEN@GMAIL.COM", "LONGQUAN.NGUYEN@GMAIL.COM", "AQAAAAIAAYagAAAAEAfz1OqvXtqGxygp5262JRJVLV9hsrxvyb/PXhELjLqt3lbLq0TFtIuHzrPNn1lBVQ==", "0253 8945 0617", "552b7d8e-c4a1-413d-bdc0-5e759d222e41", "LongQuan.Nguyen@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "49980 Lê Ford", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20Y%E1%BA%BFn%20%C3%90an", "fe517068-31b3-4be6-8911-e36791e0744b", new DateTime(2018, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "QuyVinh_Bui74@yahoo.com", "Lâm Yến Ðan", 3, "QUYVINH_BUI74@YAHOO.COM", "QUYVINH_BUI74@YAHOO.COM", "AQAAAAIAAYagAAAAEL2cfE+rpKKI6Uvts+YRiFzC6m/16jS91iwERN2U2O60+TWlMFXNazOkjyBaNMlUwA==", "0228 6205 6547", "98156838-903a-43f8-837b-90c128a8dbc6", "QuyVinh_Bui74@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "47079 Hoàng Turnpike", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20%C3%90%C4%83ng%20Kh%C3%A1nh", "6a26f072-8331-463a-bc59-78320b9b832d", new DateTime(2014, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "ThaiBinh94@yahoo.com", "Trương Ðăng Khánh", "THAIBINH94@YAHOO.COM", "THAIBINH94@YAHOO.COM", "AQAAAAIAAYagAAAAEABGB9CZZxhfkKcEUT+9V2nlN3jrYqqfHz0jL+C10yBoOi0UmeUxFEG2y04Z8Amqsg==", "024 6811 1051", "d1132607-e9fa-4cf9-95b4-cd98f2410bb3", "ThaiBinh94@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "240 Hà Common", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20%C3%90%E1%BB%A9c%20Si%C3%AAu", "034bf71a-ab1b-428c-a444-9808bc1b4099", new DateTime(2019, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "NhanSam_Ly80@yahoo.com", "Phạm Ðức Siêu", 2, "NHANSAM_LY80@YAHOO.COM", "NHANSAM_LY80@YAHOO.COM", "AQAAAAIAAYagAAAAEBAzT8vMBrJISZgNl+W8n7V76csIAXAHeNCvYdDuBC6JFz1SCP/lNKBvLqo4+Dlggw==", "022 1810 0947", "04596c65-8dc1-4c73-88cc-b4e53c834647", "NhanSam_Ly80@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "304 Tâm Nhi Tunnel", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Kh%C3%A1nh%20Mai", "6ffb1a7f-77c5-4b22-8b7c-526e93c1f84a", new DateTime(2007, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "BichNga57@hotmail.com", "Bùi Khánh Mai", "BICHNGA57@HOTMAIL.COM", "BICHNGA57@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAw86YI/n7+ueRXHLhCMm6qIQeDBJ9nINCV06yZlJokCjq8ZZkrBalciY6fjQtUbZA==", "0201 9541 9863", "2b401c9c-f97d-4fa8-9525-af419ce3dd7a", "BichNga57@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "70602 Hồng Thu Dam", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Chi%C3%AAu%20Phong", "5f83d8ca-c1b2-43a1-afd2-dd5dd8335d78", new DateTime(2000, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "LeKhanh_Le8@yahoo.com", "Đỗ Chiêu Phong", "LEKHANH_LE8@YAHOO.COM", "LEKHANH_LE8@YAHOO.COM", "AQAAAAIAAYagAAAAEFiUhc6//wqh7LtsRRumxrTUsUSkA1rd1PhjRyKpbzeXVYYPhe2NeDzkiLOsdLn7ZA==", "0296 5451 9151", "58a36404-2376-4be2-b1b6-cde2f74619fe", "LeKhanh_Le8@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "01331 Nguyễn Villages", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20B%C3%ADch%20Nh%C6%B0", "382e76a1-203b-4ae7-add7-08701b70900d", new DateTime(1998, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "ThuHau.Ho78@hotmail.com", "Hồ Bích Như", 1, "THUHAU.HO78@HOTMAIL.COM", "THUHAU.HO78@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHZgN5BA7BNmq4BoIKSblAGZ7+gHe3ElHX/mLqy3LyUcvZ1fval6jGYeyvqxk90PEg==", "027 7731 8593", "8765777a-6cca-4d42-9a80-cf033cb5b7f3", "ThuHau.Ho78@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "22569 Tú Tâm Path", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20B%C3%ACnh%20D%C6%B0%C6%A1ng", "b92e2d2f-94aa-444c-b5c7-44fe7e384f70", new DateTime(2017, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "ThuNhien2@hotmail.com", "Tô Bình Dương", 2, "THUNHIEN2@HOTMAIL.COM", "THUNHIEN2@HOTMAIL.COM", "AQAAAAIAAYagAAAAELBGDWz51PNWaQlLaXLO5aB2QWYCE1wD9fm9Oz4kK7rPUmJoGyZCBeksD+NXMvGB9A==", "0243 1599 7247", "057f1959-ace6-4b0a-ad9f-04d14aed931a", "ThuNhien2@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "687 Trương Crest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Uy%E1%BB%83n%20Nh%C3%A3", "3bc92a68-2f2b-4879-b278-ffe1da903fe9", new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "LamTruong_Ly95@gmail.com", "Đặng Uyển Nhã", "LAMTRUONG_LY95@GMAIL.COM", "LAMTRUONG_LY95@GMAIL.COM", "AQAAAAIAAYagAAAAEGfMNRqisUtZGBbC3kv6s6yQuKK4PAqCqRx+xsnmh5Eqal3nsH1/K7TXVVazEnA1lQ==", "0227 4079 6830", "ae6e3a8e-00c8-47dc-8bf5-98488c3ee581", "LamTruong_Ly95@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "08184 Hồ Loop", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Th%C3%BAy%20Huy%E1%BB%81n", "a28b33b8-9732-4883-b279-dca7462e3749", new DateTime(2017, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "LeThanh.Ly22@yahoo.com", "Dương Thúy Huyền", 3, "LETHANH.LY22@YAHOO.COM", "LETHANH.LY22@YAHOO.COM", "AQAAAAIAAYagAAAAEELaOyR4wHsivVWrfDzBgyVQm6BTXKP3iIJmolT9C8Q7bTLPx2ZXkjYTL4AsImLbpQ==", "026 7548 6707", "468c2ea0-f04d-4ed8-b02b-49427c1e45ab", "LeThanh.Ly22@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "86406 Ngọc Sơn Inlet", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20Uy%C3%AAn%20Th%C6%A1", "c112565a-b3ca-4730-9e56-6cc9f4acc5b0", new DateTime(2017, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "HongXuan_Le14@yahoo.com", "Nguyễn Uyên Thơ", "HONGXUAN_LE14@YAHOO.COM", "HONGXUAN_LE14@YAHOO.COM", "AQAAAAIAAYagAAAAEF6lGSTrRSiUwClnbNEzPpbFC7SCaZhrkeH9pZQd922F6EuxWeYBTkq+eqjyinCjUA==", "0273 6655 7622", "facd534b-9453-458d-b8f6-e9dc9d0f453a", "HongXuan_Le14@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "866 Trần Light", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Ng%E1%BB%8Dc%20H%E1%BA%A1nh", "fa54c9b0-f53a-4fb5-94b9-acdc67b1e895", new DateTime(2012, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "HoaiVy93@yahoo.com", "Mai Ngọc Hạnh", "HOAIVY93@YAHOO.COM", "HOAIVY93@YAHOO.COM", "AQAAAAIAAYagAAAAED2ai9Wpy6jm33Vw+dQ+Ap5w2ipBh96BVU+hBmH75cUkQm33EjbjJgNSENAoTVROuw==", "029 5899 6100", "cedf6943-d2f5-40c7-b50e-81ff8316332d", "HoaiVy93@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "03442 Vũ Village", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20Vi%E1%BB%87t%20Long", "4d52a987-7d68-4145-8909-9c14b0fa2abd", new DateTime(2017, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "HamTho40@gmail.com", "Lâm Việt Long", "HAMTHO40@GMAIL.COM", "HAMTHO40@GMAIL.COM", "AQAAAAIAAYagAAAAEOQhVk4flqbLvCeI+TrVAoTBJexDbdI/lazb5qxEPZbTleYcbejwAMSnZR5ZgyNeEQ==", "026 3064 1129", "5076bfd8-150d-4868-9200-648f1f156e1a", "HamTho40@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "18169 Đào Village", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20H%E1%BA%A3i%20Ph%C6%B0%E1%BB%A3ng", "26340418-0b12-4b94-af56-3dce39aabd28", new DateTime(2003, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), "MaiTrinh_Mai90@yahoo.com", "Bùi Hải Phượng", 3, "MAITRINH_MAI90@YAHOO.COM", "MAITRINH_MAI90@YAHOO.COM", "AQAAAAIAAYagAAAAELp+1zgRejy8cXoPwI9U23HdCL+Y7OKp0JWAVJ8BB5fb+4XZvQ5qp7sKQ7G0BEInlA==", "023 0162 3661", "d0e426f0-75b1-4066-ae88-56e67b36b5fd", "MaiTrinh_Mai90@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3795 Đinh Meadows", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Di%E1%BB%85m%20Khu%C3%AA", "f587be16-cc62-4035-b94b-7b5524ac86e4", new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "ThuyLam.Mai0@hotmail.com", "Hoàng Diễm Khuê", "THUYLAM.MAI0@HOTMAIL.COM", "THUYLAM.MAI0@HOTMAIL.COM", "AQAAAAIAAYagAAAAEE3i2jFdxm99YotmjDZh4yaSNa8ogsTT+SHERGQVPgsyYp+NyJXcm+wQJ82Szncrzg==", "0215 6816 2634", "c341130f-1e9d-469c-946f-14e41d9b6415", "ThuyLam.Mai0@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "823 Lê Square", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Phi%20Phi", "64e30da8-7879-49d8-9613-b448cf56dab3", new DateTime(2003, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "TheDung17@yahoo.com", "Hồ Phi Phi", 3, "THEDUNG17@YAHOO.COM", "THEDUNG17@YAHOO.COM", "AQAAAAIAAYagAAAAEGQB9gwj//iREGYBC6vxQ6h5W98hqU9D8vvYQpjpEr4pEdQsRHf29mhczv/qC9syNQ==", "025 7701 9476", "9acd3aac-85f6-441e-a981-782ff7970d27", "TheDung17@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "63179 Mai Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20%C3%90%C3%A0i%20Trang", "7c3f8a8d-f6ea-4c78-9de4-d314f0ac5be3", new DateTime(1998, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "SonDuong.To@gmail.com", "Đỗ Ðài Trang", 2, "SONDUONG.TO@GMAIL.COM", "SONDUONG.TO@GMAIL.COM", "AQAAAAIAAYagAAAAEG3XeZrO9w/JMW9VHM+6P7sfDpAjzxkrcB3RNGeDXh2kOugRVID8Y6UgObxynTdicA==", "022 5007 1094", "219b4b57-eba6-47a8-b69e-057633cfbfe5", "SonDuong.To@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "199 Liên Hoa Walk", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20C%C6%B0%C6%A1ng%20Ngh%E1%BB%8B", "79360594-d2fb-4440-8e49-e82fac53a5ef", new DateTime(2013, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "HuuTai.Mai@hotmail.com", "Hồ Cương Nghị", "HUUTAI.MAI@HOTMAIL.COM", "HUUTAI.MAI@HOTMAIL.COM", "AQAAAAIAAYagAAAAECDpyXB22KwLFWx3vcQMO/oHW9PCqfX2q37+7EXi2FO7LwMF8jhylQd7jveWnYU6bA==", "029 8068 6983", "86f1b554-5fc3-4675-815a-d634067dd2fb", "HuuTai.Mai@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "32907 Việt Quốc Keys", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20H%E1%BB%AFu%20C%E1%BA%A3nh", "a756db03-fefe-4e1c-a1a2-d069ef4f1235", new DateTime(2012, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "DiemLien.Le38@yahoo.com", "Phạm Hữu Cảnh", 3, "DIEMLIEN.LE38@YAHOO.COM", "DIEMLIEN.LE38@YAHOO.COM", "AQAAAAIAAYagAAAAEJOxMwk4k67v+H6X86X+b14utjlqqVUL6n2Rt9/H023sh5xXKVCA4rAh8Yb4PEYuaA==", "0271 6594 6967", "411fff58-98f1-4bc2-a32d-9b84449b70a3", "DiemLien.Le38@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1273 Ðức Trí Center", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Qu%E1%BB%B3nh%20Giang", "8c13a790-c623-4c9c-8a38-e55270634cce", new DateTime(1995, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "HaiMien_Phung@yahoo.com", "Đặng Quỳnh Giang", "HAIMIEN_PHUNG@YAHOO.COM", "HAIMIEN_PHUNG@YAHOO.COM", "AQAAAAIAAYagAAAAEChsvZbExlY+xXfiuCM/rWOCkJ/lOSvj+3UqJB+S1moUfRlpC4lIZbcIFtpO4D3mLw==", "0263 4604 4314", "02dabf38-dd44-4d9b-af61-5a7f9c66beea", "HaiMien_Phung@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "83554 Quang Lâm Glen", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20Duy%20Th%C3%A0nh", "e8037808-ee1b-44e8-a0a0-527e1e4235f9", new DateTime(2014, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "HaiSan.Vuong@gmail.com", "Lâm Duy Thành", "HAISAN.VUONG@GMAIL.COM", "HAISAN.VUONG@GMAIL.COM", "AQAAAAIAAYagAAAAEMlqpxCA8CF+tH3GFx8veQj/cBnhIzDoVWAVzmcGof1lga54oEMxsfuEv420YtrLJw==", "024 6302 3106", "7ac91221-67b0-4f20-85e2-d66fc977af34", "HaiSan.Vuong@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "189 Cường Dũng Plaza", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20%C3%90%E1%BB%A9c%20Khi%C3%AAm", "a1c357f1-a97f-40fe-a45e-207c4e35baa8", new DateTime(1998, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), "QuocDien.Vu49@yahoo.com", "Trịnh Ðức Khiêm", 3, "QUOCDIEN.VU49@YAHOO.COM", "QUOCDIEN.VU49@YAHOO.COM", "AQAAAAIAAYagAAAAEFC3RerIAurwR/SqAcWa8VtmdxygMy1TF8e8VJcp+1PUUlTDyBKgFOU58DE9viHnjQ==", "0270 6066 0560", "504fb2f7-934e-4b75-afde-9d0a717f8979", "QuocDien.Vu49@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "090 Hoài Nam Junctions", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Nguy%E1%BB%87t%20C%C3%A1t", "cb4c4a31-06c6-48d6-9adc-7204f9fc2506", new DateTime(2008, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "ThaoNghi.Tran@yahoo.com", "Lý Nguyệt Cát", "THAONGHI.TRAN@YAHOO.COM", "THAONGHI.TRAN@YAHOO.COM", "AQAAAAIAAYagAAAAEJGdAGRk1axcDXGghoSE/Zqv7cQ/+eiiQwKv5v6NxSv+zzIwb22BvpadPD4bEMiSJQ==", "0287 4204 0759", "b48ea56e-f62e-4fc7-a7fc-5ce50414301c", "ThaoNghi.Tran@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8027 Phượng Bích Circles", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Minh%20S%C6%A1n", "d32cd7d3-4d15-4b1c-b9bf-3edd75d82d38", new DateTime(1999, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "MinhMan_Pham@hotmail.com", "Ngô Minh Sơn", 1, "MINHMAN_PHAM@HOTMAIL.COM", "MINHMAN_PHAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFwVbLo6aSlfDpoWQVWMmvkasTkyyDewJJsPuTYEHTAXid6IjwcPrHQUR7s1xKhbyw==", "0217 3252 0808", "88b20457-412e-443f-8449-96efa3672896", "MinhMan_Pham@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2814 Hoàng Landing", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Di%E1%BB%85m%20Chi", "ab4eb177-b409-4103-b673-fafc4cdd6a67", new DateTime(1999, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "ThuanPhong.To@hotmail.com", "Ngô Diễm Chi", "THUANPHONG.TO@HOTMAIL.COM", "THUANPHONG.TO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJ6/UXBKgzGYHQxi245lWnvDfCraIjG0k+mq4kmhuL2hLk4d516sVyDMnIzoLEpZMA==", "0255 0596 4120", "99d4f0b8-1901-4283-a1fb-f97bd23c84a2", "ThuanPhong.To@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "852 Đào Court", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Ch%C3%AD%20Hi%E1%BA%BFu", "de54b183-2bec-45c2-b941-a031efc623e0", new DateTime(2013, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "NgocDiep91@gmail.com", "Hà Chí Hiếu", 1, "NGOCDIEP91@GMAIL.COM", "NGOCDIEP91@GMAIL.COM", "AQAAAAIAAYagAAAAEFukFoEBKTI1Khcyqbyv+c7mOIwXASH+kUloE8njRJqONvmBL8nNQvYgb5YbbhObNw==", "021 0889 7638", "6fd530a9-4c0a-4641-ab28-893e47571faf", "NgocDiep91@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "38357 Vĩnh Ân Gateway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Vi%E1%BB%87t%20D%C6%B0%C6%A1ng", "504578eb-9495-4026-84d8-4278f0fb6e5a", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), "NhatAnh_Dang@gmail.com", "Đỗ Việt Dương", 3, "NHATANH_DANG@GMAIL.COM", "NHATANH_DANG@GMAIL.COM", "AQAAAAIAAYagAAAAEEYcygPX6f9GshP69bktAk3s635lhmGuABwfxtf3p3AiFNH00SSEtccNfOhlt78Irw==", "0297 4903 6920", "3e63f277-24e4-4bd8-938f-5f8591a4ff59", "NhatAnh_Dang@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "545 Hồ Stream", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20C%C3%A1t%20Uy", "3112ea0a-856f-409d-abd2-c4d4e2206ba2", new DateTime(2010, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "KhaiCa91@yahoo.com", "Mai Cát Uy", 1, "KHAICA91@YAHOO.COM", "KHAICA91@YAHOO.COM", "AQAAAAIAAYagAAAAEAETRmHPJEQDr17u6ak5vZ78LekcObol7JZzHpmYTSbvxcpKNK9yOWKhnkaHVohxfg==", "022 6199 2269", "3541ee31-f7dc-40a0-910d-26fb1bfcaa9e", "KhaiCa91@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "48976 Thanh Vinh Rapid", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Th%E1%BB%A5c%20Khu%C3%AA", "29f1ba2f-cb7f-47c6-be0f-3ae29428c5df", new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "ThuyVan_To@gmail.com", "Lý Thục Khuê", "THUYVAN_TO@GMAIL.COM", "THUYVAN_TO@GMAIL.COM", "AQAAAAIAAYagAAAAEM+BL6nsinYTbkmvPWsqECkmTWdEw4Xx4V1x4QJYpYVryjo+EP2KctdMZvBvETPF1w==", "0288 7386 3609", "8d8271af-2359-4909-8f01-3b75b9b551fb", "ThuyVan_To@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "66877 Ðình Ngân Shoals", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Lam%20Ng%E1%BB%8Dc", "21e511a5-cb18-4a0a-974b-1eb36612ecd5", new DateTime(1999, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "KimToan_Tang21@yahoo.com", "Vương Lam Ngọc", 1, "KIMTOAN_TANG21@YAHOO.COM", "KIMTOAN_TANG21@YAHOO.COM", "AQAAAAIAAYagAAAAEENd3WybIyiGUo+2r4w7JL157s+BeakaET/7/v9kqwUGcxzdfiJ0dcEzSWjbERuFJw==", "024 9787 6836", "f6098976-7014-45ec-ac1f-60afdcf009a7", "KimToan_Tang21@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3321 Trâm Oanh Mission", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20%C3%90%C4%83ng%20Khoa", "be896719-454f-4735-a304-6764fa5203bc", new DateTime(2012, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "AnhHoa.To86@gmail.com", "Mai Ðăng Khoa", "ANHHOA.TO86@GMAIL.COM", "ANHHOA.TO86@GMAIL.COM", "AQAAAAIAAYagAAAAEI05sAaoHfxe3/vih7b23ZuAMJDb5rIB/dtozJeYMVgDI5tR5sAb+fL3iHfr2PVZSw==", "0262 0757 9112", "bd1a543d-186e-42d5-9b0a-f8c1c216c122", "AnhHoa.To86@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3474 Mai Plaza", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20H%E1%BA%A1nh%20Ph%C6%B0%C6%A1ng", "b8b9b348-0581-42e1-b697-ed20f4693f34", new DateTime(2008, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "LienPhuong81@hotmail.com", "Hồ Hạnh Phương", 1, "LIENPHUONG81@HOTMAIL.COM", "LIENPHUONG81@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBfBqbGRgsUmBINnND/0VDUX4NenLJVeHVNP+Db8X3FVbH+9ig1C2ZiQiMyn8pk3QA==", "028 8512 5038", "72904ad4-bd32-4dc3-972b-83299f4b533a", "LienPhuong81@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "73751 Hằng Anh Mountain", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20Ho%C3%A0ng%20L%C3%A2m", "162320d0-0790-4eed-b77a-6b13f6dcede0", new DateTime(2014, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "YenDan96@hotmail.com", "Đoàn Hoàng Lâm", 1, "YENDAN96@HOTMAIL.COM", "YENDAN96@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGECEmWFOiokTyj6sOMNSFg0V1lkVXnOGU3bY9y1PMaOSeIX8BvoBnKY07u6LqT8nw==", "025 9125 4005", "956bd7f4-e90b-41b2-8e7d-1ada0550964a", "YenDan96@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "29471 Đỗ Mission", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Nh%E1%BA%ADt%20Ho%C3%A0ng", "85767c18-1208-453c-a4b0-b8bab68d2e07", new DateTime(2003, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "AiVan.Bui@gmail.com", "Vương Nhật Hoàng", 2, "AIVAN.BUI@GMAIL.COM", "AIVAN.BUI@GMAIL.COM", "AQAAAAIAAYagAAAAEKBR4WF7izJOyemqUkm1hVIRmnFQTHOMdzc/aV/WeMtBKcJ7LWs2NzennsXFyd0knw==", "0281 8440 2317", "cd2a7e02-fcb9-448e-8830-22db8082d2bc", "AiVan.Bui@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "08819 Đông Tuyền Knoll", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Vi%E1%BB%87t%20D%C6%B0%C6%A1ng", "2cc19695-6738-4123-b8ad-ca7b6d9f419d", new DateTime(2002, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "ThinhCuong41@hotmail.com", "Dương Việt Dương", 3, "THINHCUONG41@HOTMAIL.COM", "THINHCUONG41@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDfhAYlr3q+NxXSMCDGzmQ+0PJ1ngfQJzJG2KyjQAXCTfLmRAFYK8CPIb/JInFSUMw==", "0285 9830 6871", "11b001cc-53c7-48ee-96a6-b8c814e03fe9", "ThinhCuong41@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "764 Ngọc Ðoàn Walks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20T%E1%BB%AB%20%C3%82n", "cd275503-5094-4dcb-88d5-a1c400509fb5", new DateTime(2005, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), "KhanhHuyen.Tang1@hotmail.com", "Đinh Từ Ân", 1, "KHANHHUYEN.TANG1@HOTMAIL.COM", "KHANHHUYEN.TANG1@HOTMAIL.COM", "AQAAAAIAAYagAAAAENdrsDB3cFqxmSMkuXW/ag5V5+03s2L3N5rWqqGYAnctNXgQMf1LBuhJN0wKbf423g==", "0234 4587 0504", "9bcaa70c-1317-42e6-9008-f6eacda324f8", "KhanhHuyen.Tang1@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "73889 Trịnh Port", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Thanh%20Ph%C6%B0%C6%A1ng", "7914206c-b397-4aff-9f99-193324e0d8d0", new DateTime(1995, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "ThuHien24@gmail.com", "Lê Thanh Phương", "THUHIEN24@GMAIL.COM", "THUHIEN24@GMAIL.COM", "AQAAAAIAAYagAAAAEJOQeNYF9fUGAFRH78ANxCirtnT/l6xsk2ej+mF4WOD5Av8Cy90wS6o/gU27R0M9Jg==", "0270 4498 5260", "f21bdde7-c980-4661-9028-cf9d58d656de", "ThuHien24@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "944 Đinh Corners", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Xu%C3%A2n%20Thu", "f39a8b3e-5f87-4682-a250-2dd5272c4eb6", new DateTime(1998, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "XuanNhi.Ho@gmail.com", "Hồ Xuân Thu", "XUANNHI.HO@GMAIL.COM", "XUANNHI.HO@GMAIL.COM", "AQAAAAIAAYagAAAAEDcJfmCMNIbM78FKG0B4EayU9OA7aN6x3KrlzvFDBHD9INdmaOG7P4rxZGlDFaOADQ==", "020 1258 8566", "c06114ca-1743-4830-8930-703ed70b4ade", "XuanNhi.Ho@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "82019 Đinh Tunnel", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20M%E1%BA%A1nh%20Tr%C6%B0%E1%BB%9Dng", "15f1069c-a963-4d17-bc64-f8aa93bfa12f", new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "TuanKiet_Phung69@yahoo.com", "Lý Mạnh Trường", 1, "TUANKIET_PHUNG69@YAHOO.COM", "TUANKIET_PHUNG69@YAHOO.COM", "AQAAAAIAAYagAAAAEFAupzzizTJTIX09iSUWS/PDUBIIbdqloDNpWecBQblEgO4KS+H+oCbJcfwnbNjsUw==", "0235 8252 4029", "4d99483f-86ee-4698-9e0b-0f514b57d142", "TuanKiet_Phung69@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "95102 Bùi Lane", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Nam%20An", "0e4ace2e-e4da-4ffe-b97b-65d2a8c00cc1", new DateTime(1998, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "BaoChau42@gmail.com", "Vương Nam An", "BAOCHAU42@GMAIL.COM", "BAOCHAU42@GMAIL.COM", "AQAAAAIAAYagAAAAEEe+reOrIvRKZVzg3HczeMuve1Tpm/VhoiKQrfZSV77Sw7lck6XPpFPzsRHAzDBtWg==", "029 8243 5486", "6b54d643-e785-4ac4-bc73-d04739c75300", "BaoChau42@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "89631 Mai Branch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20B%E1%BA%A3o%20Duy", "9d43cd47-338f-4b81-86b8-2e77c6be8dbf", new DateTime(2016, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "ManhDung.Pham@yahoo.com", "Dương Bảo Duy", 1, "MANHDUNG.PHAM@YAHOO.COM", "MANHDUNG.PHAM@YAHOO.COM", "AQAAAAIAAYagAAAAEHBMTf/DyzA3xkHYn5vpGQ94BprtJbFppPcEr+mHxmKHhP8Pci31fdzfCcEMG3PAGg==", "024 3564 5768", "dd020200-23a0-4f62-8ef3-82718730e699", "ManhDung.Pham@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "802 Duy Kính Cape", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Th%E1%BA%BF%20Duy%E1%BB%87t", "e1d39de5-5df9-4f45-8f54-f772fccb5e00", new DateTime(2006, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "MinhHieu_Truong91@yahoo.com", "Dương Thế Duyệt", 2, "MINHHIEU_TRUONG91@YAHOO.COM", "MINHHIEU_TRUONG91@YAHOO.COM", "AQAAAAIAAYagAAAAELRdLiYQGLZEOZuf4qQVtxGkSAIQYKSkLE7B/eOcpHrNr+nSxwz8IJcnxsIkXsrxnQ==", "029 2147 9566", "381c67c3-27fc-4fca-b620-a3f692be04d3", "MinhHieu_Truong91@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "91164 Đinh Knolls", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20B%E1%BB%99i%20Linh", "de780f9c-10ea-42a9-857e-06b8ef61db71", new DateTime(1999, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "QuocBao_Tang36@hotmail.com", "Dương Bội Linh", 1, "QUOCBAO_TANG36@HOTMAIL.COM", "QUOCBAO_TANG36@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMInYrVVId9Un47PhyaJdyXNL4leR2SUP0LiI5Irpz7u7lZez82hwZjCBueraDoi4g==", "0278 7353 8931", "6bd3e500-f317-4912-97eb-6eb49ac655e5", "QuocBao_Tang36@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2741 Tăng Shoal", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20An%20Ninh", "fc85d3f5-c8fb-43ef-88f8-0c5d102a2f6b", new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "ThanhNga70@yahoo.com", "Hồ An Ninh", 3, "THANHNGA70@YAHOO.COM", "THANHNGA70@YAHOO.COM", "AQAAAAIAAYagAAAAEHKztDSjFKxOtQATt3wof0vvGyao8+pCR0QYGDGu1bkg1dd5tMcQyb0TwYTtLgvtIg==", "0261 4033 0749", "b8ac21a5-1291-464d-b32a-3a774dbd6944", "ThanhNga70@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "41486 Thạch Sơn Stravenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Gia%20H%C6%B0ng", "70e43ab8-9aec-4f8b-bdf1-a4a724caa00e", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "MinhAnh_Ly@hotmail.com", "Hà Gia Hưng", 3, "MINHANH_LY@HOTMAIL.COM", "MINHANH_LY@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMrcMmqu9NpYktqilPuERhfkjkILuwv6QNITlZzSENJn2gY7jP/2OUPW/TPnIiEeYw==", "025 2994 5766", "746f680a-4ef3-4aac-b1df-de2910e3916d", "MinhAnh_Ly@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "31988 Vương Forge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Th%E1%BA%A3o%20H%C6%B0%C6%A1ng", "05407360-b4de-4efe-acc5-18eaa7e026c1", new DateTime(2010, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "BaoLan.Mai@hotmail.com", "Đỗ Thảo Hương", "BAOLAN.MAI@HOTMAIL.COM", "BAOLAN.MAI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAWKOKYxSG85yP4pyD6h0Z8HPnDXvRvpLESpiJ0DFFmxCK5rTcdxmXxCOlBLJmTDKg==", "0223 5535 6493", "aa897fe3-37c5-4845-92c9-9dcfeee60d0f", "BaoLan.Mai@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8786 Vũ Cape", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20Long%20Giang", "b2d5c1d3-a1b2-4a06-ab2d-04f0da798eae", new DateTime(1999, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "NghiaDung_Nguyen61@hotmail.com", "Trần Long Giang", 3, "NGHIADUNG_NGUYEN61@HOTMAIL.COM", "NGHIADUNG_NGUYEN61@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDqY0VQ76qbwyz+PaWleKfT3rb4uBVrZHCKJwJ6z5Ks6uKShS8hdqWvIVkSZycKcdw==", "0221 2526 6240", "443aeb69-04b1-4c5c-9317-4de0b644fbb8", "NghiaDung_Nguyen61@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0920 Tô Loaf", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Xu%C3%A2n%20Mai", "fcbe0448-cb1e-416c-88a4-a6a0e83041a2", new DateTime(2002, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "LanTruc.Phung@gmail.com", "Hoàng Xuân Mai", 1, "LANTRUC.PHUNG@GMAIL.COM", "LANTRUC.PHUNG@GMAIL.COM", "AQAAAAIAAYagAAAAEJIsncXds5nLG0q0ZR8qzOXbuxXnXkdHxUYQpv0PaaoSB4yy3XXWql0C3ctL/BmvEQ==", "020 5441 7562", "a8e3d5b8-d309-4270-95f2-ef9fd19545c0", "LanTruc.Phung@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "974 Lý Mountains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20%C3%90%C3%ACnh%20H%E1%BA%A3o", "0a0c9e72-9cf4-4e0e-995e-25df6ed5861c", new DateTime(2001, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), "LuongTuyen.Le47@hotmail.com", "Đinh Ðình Hảo", 1, "LUONGTUYEN.LE47@HOTMAIL.COM", "LUONGTUYEN.LE47@HOTMAIL.COM", "AQAAAAIAAYagAAAAECjIBFUWVYO/ZmCfTLXk11E/3YDqHke2Xe07S3YQkq9Ytw7DeFAVO+hI5JylbPOgww==", "0266 6215 3723", "e14c67bd-be74-43a3-a151-5f1d0e298583", "LuongTuyen.Le47@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3682 Trọng Kiên Green", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20%C3%90an%20Khanh", "25fc1a89-23ee-4aa8-b1e7-3599f195077a", new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "DucBang2@gmail.com", "Nguyễn Ðan Khanh", 1, "DUCBANG2@GMAIL.COM", "DUCBANG2@GMAIL.COM", "AQAAAAIAAYagAAAAEPWi4zhrznShbevzSf+/1STu/mH34QGBZxYV8BkrlZVqHar9hF1UGmhWqhQDp9mlDQ==", "029 0891 2745", "909e6908-d9f5-4753-9797-0b737e7abe13", "DucBang2@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5721 Vương Islands", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Ho%C3%A0ng%20Th%C3%A1i", "a3c22ace-f13f-4baf-a516-eaa67c4d92fb", new DateTime(2002, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "XuanHan79@hotmail.com", "Vương Hoàng Thái", "XUANHAN79@HOTMAIL.COM", "XUANHAN79@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMty72pDI5oE19qQnQofxEM6YXYi1ZQUjyrM9V+GpnpIF7/4yrMGX/Bq6c524SfZ2Q==", "029 4297 9644", "38ecd3b6-47d9-4f92-9fe6-6d792439b71f", "XuanHan79@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "29800 Hoạ Mi Causeway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Th%E1%BA%BF%20Minh", "ba629dc2-fead-4327-bc6b-0597fb3ac95b", new DateTime(2017, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "HuuVinh65@hotmail.com", "Phạm Thế Minh", 1, "HUUVINH65@HOTMAIL.COM", "HUUVINH65@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPPUZ+b6zMEjyc9IrfKOpijLfffARI1kKmWAgqTzXw7lyhYEgw9otLVdUm+AcciLNw==", "0236 5376 0373", "bc5b4c18-5236-4ab2-9dc1-7d51d7a298d9", "HuuVinh65@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3761 Mỹ Hạnh Views", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20V%C4%A9nh%20%C3%82n", "f9fda536-1dc2-46ff-afba-55d2e1f35362", new DateTime(1996, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "VietNhan.Le@hotmail.com", "Lý Vĩnh Ân", 2, "VIETNHAN.LE@HOTMAIL.COM", "VIETNHAN.LE@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDia70dJr5g2YrpRVMwXEGyL7rCohENkioNLN/Msir3SgRjezpA9KOfCJJNw878y4A==", "029 5351 8040", "d6ee6f84-98b8-4799-8db6-f9fdb6b11a97", "VietNhan.Le@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "37938 Phạm Oval", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Ng%E1%BB%8Dc%20Dung", "9169539e-bcfb-4f9d-a2cd-ebbbe50ca821", new DateTime(2003, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), "ThanhNhan_Lam@hotmail.com", "Phạm Ngọc Dung", "THANHNHAN_LAM@HOTMAIL.COM", "THANHNHAN_LAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAHOKV/P+skJTawu5ismuoAqgvSaVIdE0eILfRUNYSWVfjn6a/xhfUlzSYkAxNW0sA==", "0202 2349 9492", "2adb6781-8322-43f6-b090-8cd3540b8c38", "ThanhNhan_Lam@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4314 Thiện Tính Divide", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20K%E1%BB%B3%20V%C3%B5", "9dc33df8-cdc8-448a-b3d9-a49c5edd5eae", new DateTime(2005, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "PhuongPhi_Ly@gmail.com", "Trần Kỳ Võ", 2, "PHUONGPHI_LY@GMAIL.COM", "PHUONGPHI_LY@GMAIL.COM", "AQAAAAIAAYagAAAAEFjL42iozDoTsBFqrGLEoxm29tAJITtEEWlU1C5ihKO2BrOJmEXjmrkArEz2kvwYVw==", "023 4691 3745", "8fd91149-17ee-4993-b793-e4d75cde933d", "PhuongPhi_Ly@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "214 Tăng Throughway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Cao%20S%C4%A9", "fe5ac818-386f-4d7d-bc9e-992590a4a43c", new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "TienPhuong_Trinh16@yahoo.com", "Lê Cao Sĩ", 3, "TIENPHUONG_TRINH16@YAHOO.COM", "TIENPHUONG_TRINH16@YAHOO.COM", "AQAAAAIAAYagAAAAENTIx/fhP7N+UszJNcHw3oKk6ozAfPYxhp+Wdn4zQSa9y59Sw7t800JsuALTn3fs+Q==", "024 5548 1366", "692dffbd-8142-4c65-bc76-8065975817f6", "TienPhuong_Trinh16@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "189 Thu Sinh Common", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Th%C3%A0nh%20Nh%C3%A2n", "00f4ba72-b19d-4ce1-a789-ece37b15cfc6", new DateTime(2006, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "MinhHuan76@yahoo.com", "Lý Thành Nhân", 3, "MINHHUAN76@YAHOO.COM", "MINHHUAN76@YAHOO.COM", "AQAAAAIAAYagAAAAEJE3dE0dT0B4Xj7kZRwi4zekZ/HXdoaFOPRU3Lsvfc9U89a/9MBKagIgmwcMHqzNvA==", "020 3893 9110", "ed9f6f19-c488-4d7f-b232-6639b801d582", "MinhHuan76@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "434 Vương Prairie", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Ng%E1%BB%8Dc%20Th%C6%A1", "6bc9a4e6-e6b4-4a9d-aefd-393fdb9902e6", new DateTime(1996, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "ThuyLinh13@gmail.com", "Tô Ngọc Thơ", 2, "THUYLINH13@GMAIL.COM", "THUYLINH13@GMAIL.COM", "AQAAAAIAAYagAAAAEI9e/bR1Y/W5+JSxL2lGKkUWygiIupwJdef/mbo9SzaCUpSK8Tr0km0QTMJozl9X8g==", "0252 0270 9579", "4eeddd88-9ef3-4441-b63b-c04a5850ff3b", "ThuyLinh13@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "164 Trịnh Forest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20B%C3%ADch%20Loan", "b33dc8cb-40d9-497f-aeaa-dc2de0c9652b", new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "YenLoan69@gmail.com", "Hoàng Bích Loan", 1, "YENLOAN69@GMAIL.COM", "YENLOAN69@GMAIL.COM", "AQAAAAIAAYagAAAAEDD6RsvzyTgdG60XjYQ42C3StM3lpdwNxj6+aQr7PpD0iSnno7E6hJPR12nIPdEnTA==", "0242 1288 3791", "e1a823b3-2a24-46d2-9837-6f7eb13bdb0a", "YenLoan69@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3827 Ðức Huy Passage", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20B%C3%ADch%20Nga", "f213c0be-cc27-43bf-b3e0-74097f550f36", new DateTime(2001, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "DuyCuong.Dao@hotmail.com", "Hồ Bích Nga", "DUYCUONG.DAO@HOTMAIL.COM", "DUYCUONG.DAO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEnQBw6O2JY5Rhqjxiaev8sgqMFt26DiumgR5LlnnyL0fhp1li70264JfjWv3YhUig==", "022 1689 1300", "6d74004c-940c-4d0c-88c1-e4c9236dbb25", "DuyCuong.Dao@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "73936 Ðan Khanh Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Th%E1%BB%A7y%20Trang", "f420a829-3604-426e-8eb7-30a74a5eb2e3", new DateTime(2015, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "HuyLinh78@hotmail.com", "Phùng Thủy Trang", 2, "HUYLINH78@HOTMAIL.COM", "HUYLINH78@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMFxzIe3ybDh0VM1Efw3C5+Ma+SiRf+ZQsiBIwrLHzOZCuW8fxUlhSEjsN2lfeR8Vg==", "023 6952 4309", "0eb75943-67c8-44a4-818d-ca6e8930a8e4", "HuyLinh78@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "86677 Mai Court", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20H%E1%BA%A3i%20Giang", "f9ede558-fcd5-41d3-89fd-fb4fc27595dd", new DateTime(2003, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "ThuyMy83@gmail.com", "Trương Hải Giang", 2, "THUYMY83@GMAIL.COM", "THUYMY83@GMAIL.COM", "AQAAAAIAAYagAAAAEL/Ur9fxwGpgOwcmYgJKnoXsgrPuA+edtt5TRS6XQ08JOvDLxHJzBHClmMWAJFCTzw==", "027 5185 4595", "3eeb6e6c-309e-48c9-b849-872384b4f5c6", "ThuyMy83@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "587 Tăng Port", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Xu%C3%A2n%20H%C3%A0m", "a42bd142-3e1c-4a88-9e52-f15b4e6b1a96", new DateTime(2012, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "HuyKhanh_Nguyen@yahoo.com", "Lý Xuân Hàm", "HUYKHANH_NGUYEN@YAHOO.COM", "HUYKHANH_NGUYEN@YAHOO.COM", "AQAAAAIAAYagAAAAEMYtYkv1JbfH5DwY7ef8iBeQQAEq6OJWa5DFOOQiPQWt4ieRbTpRViwT7gCWLxNcLg==", "020 7898 8351", "8e5588e0-609f-4fcb-9175-41ce265df3c8", "HuyKhanh_Nguyen@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6456 Lâm Roads", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Thi%C3%AAn%20L%C6%B0%C6%A1ng", "aaba2862-2a54-4617-8b49-748ee8c628f8", new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "NhuHong_Dang1@gmail.com", "Phạm Thiên Lương", "NHUHONG_DANG1@GMAIL.COM", "NHUHONG_DANG1@GMAIL.COM", "AQAAAAIAAYagAAAAEGac6BG7ViMKWr1qtp3x285PJaBODrnfH0YM5wyqJRiLH3rKpp4xdo+55l/Bn9mYkA==", "026 1617 1467", "a3f3bc59-d773-4836-9e96-a37e12ab0535", "NhuHong_Dang1@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "51201 Tăng Row", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Ch%C3%AD%20Khi%C3%AAm", "b8e2e39f-162a-4e35-ac40-d666886f4e82", new DateTime(2011, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "HienNhi81@hotmail.com", "Trương Chí Khiêm", 2, "HIENNHI81@HOTMAIL.COM", "HIENNHI81@HOTMAIL.COM", "AQAAAAIAAYagAAAAEN/CqUCP/gOy2ef9KhyNRaOpKOp3kbx1DOn0QC6YRJZGKE+LbJgI4YhF7f+IJOnAwg==", "0229 5421 7283", "40f52199-d451-4b7f-bbc5-8852eac3fcd2", "HienNhi81@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4053 Lâm Viaduct", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20B%E1%BA%A1ch%20Kim", "ea32aab3-07f2-43d5-bbb8-b52557b0d905", new DateTime(2018, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "TruongNhan72@yahoo.com", "Nguyễn Bạch Kim", "TRUONGNHAN72@YAHOO.COM", "TRUONGNHAN72@YAHOO.COM", "AQAAAAIAAYagAAAAELQS8RpEV/md2+YlLB1sg6rUR1jV8qN6YeFc5HfBr6fCrU5ckFUB/hUE8kPoWPAtCQ==", "024 2669 1584", "94290bf7-31e2-46df-ac98-51b06eb2ebbe", "TruongNhan72@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "35754 Ái Khanh Springs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20%C3%90%E1%BB%A9c%20Tu%E1%BB%87", "d4ebf12c-668e-4a7b-8eb0-9999f207189e", new DateTime(2014, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "TienHoat_Mai@hotmail.com", "Đoàn Ðức Tuệ", "TIENHOAT_MAI@HOTMAIL.COM", "TIENHOAT_MAI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMWJlv1RDp2K13cLmEeuJg9tN0KfYwN5E42b95Epzv55WZK16plA3BbZPfPHP57aNg==", "0246 9242 2565", "f252df73-0b63-4a77-b1ac-53b53f608c4f", "TienHoat_Mai@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "19612 Lâm Loaf", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Qu%E1%BB%91c%20Quang", "3247de65-566f-4f42-a704-729bdadacc07", new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "DieuAi78@yahoo.com", "Dương Quốc Quang", 2, "DIEUAI78@YAHOO.COM", "DIEUAI78@YAHOO.COM", "AQAAAAIAAYagAAAAEFNhDBhSsMDTC7jRgGOlElpxyFBSuct3QRIuzEys5GmBMMmr9DTSJ+4QqX3MWfU86g==", "0236 0161 4229", "b24d5a46-8197-402b-afd1-04d3c513fc30", "DieuAi78@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3630 Vân Ngọc Bypass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Qu%E1%BB%B3nh%20Nhung", "98ee5d77-636e-4834-835d-9c62c8ecfd2c", new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), "ThanhThien33@gmail.com", "Lý Quỳnh Nhung", "THANHTHIEN33@GMAIL.COM", "THANHTHIEN33@GMAIL.COM", "AQAAAAIAAYagAAAAEBBI3llZgTzyLJUX330SA/ehCqPkxoVD05mbDuxz6fF/KQy0rPtk43gOa+Vlsx0OdA==", "026 1311 7712", "8dff42c3-d7ab-456c-a879-b8038b735d51", "ThanhThien33@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "288 Kim Thy Grove", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Thanh%20Loan", "cf62e2d2-e435-4646-880e-a22bf7c03619", new DateTime(2003, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "MinhHuyen_Duong@hotmail.com", "Hồ Thanh Loan", "MINHHUYEN_DUONG@HOTMAIL.COM", "MINHHUYEN_DUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFqecBDYmssJZV3wQf/yK3Rn9TqJ0MkWhxarAH4zSlQ2Zm9kIx8NJwRs99A4XOlAeg==", "021 2829 5300", "296a2295-95f8-4d23-8467-034405528743", "MinhHuyen_Duong@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7423 Từ Ân Walks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20Th%C3%A1i%20Minh", "450aef34-4a2e-486f-a88e-78eb0f05d1ed", new DateTime(2018, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "HaHai55@hotmail.com", "Phan Thái Minh", "HAHAI55@HOTMAIL.COM", "HAHAI55@HOTMAIL.COM", "AQAAAAIAAYagAAAAENHMdfJksw/7bnSAQkrrzr/ceYxTVp3s2v66RqSWwSutuYtnRVDfkMliZZYwfrPgnQ==", "022 7141 1385", "e33d3fcf-3b18-4b3d-88e1-418b38754426", "HaHai55@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "043 Nhật Huy Island", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20Qu%E1%BB%91c%20Anh", "e874643a-920b-41ed-a54d-e0af36df983d", new DateTime(2013, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), "PhuongUyen.Phung@yahoo.com", "Nguyễn Quốc Anh", 3, "PHUONGUYEN.PHUNG@YAHOO.COM", "PHUONGUYEN.PHUNG@YAHOO.COM", "AQAAAAIAAYagAAAAEJuvRCa7Xj0844//6Fuih6jkxAG2Gbw7Z1leI0sMLEuIE5oPJVccw53eTPozVv8y9Q==", "0204 4943 7651", "38aabaae-6ec2-4218-8161-e4900ed0a02a", "PhuongUyen.Phung@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9268 Mỹ Phượng Corners", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20Xu%C3%A2n%20Hoa", "be3fadd4-7207-44ee-abf8-78deb21865c4", new DateTime(2016, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "MinhHuan.Pham10@yahoo.com", "Đào Xuân Hoa", 2, "MINHHUAN.PHAM10@YAHOO.COM", "MINHHUAN.PHAM10@YAHOO.COM", "AQAAAAIAAYagAAAAEA6JH/3O3pzaefZTMqGl+ki7qnIzGxOAREgksb1Ntpad5Z0SIXsim2EIQkhrtXfxXw==", "0238 8749 0125", "29cb7c9b-33ff-482e-86f8-9111235fe65e", "MinhHuan.Pham10@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "302 Phạm Mill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20Tuy%E1%BA%BFt%20Nhung", "96a6964c-633c-4864-ae49-b67548ddf2d8", new DateTime(2000, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), "PhiLong_Ho@yahoo.com", "Đào Tuyết Nhung", "PHILONG_HO@YAHOO.COM", "PHILONG_HO@YAHOO.COM", "AQAAAAIAAYagAAAAEOhX/SrppFnCfD/Hz0Qnt2c0+75mb55Be3Uros1CGEuUl/SbE+87sB18ebme0YLDlQ==", "0285 0313 2751", "3f1e3591-0bb5-4900-8282-48c00b95bfb3", "PhiLong_Ho@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "407 Minh Toàn Square", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Tr%C6%B0%E1%BB%9Dng%20Nh%C3%A2n", "dfd462ab-6668-4ed3-afa0-615afd126ff0", new DateTime(2001, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "TrongHung.Pham65@hotmail.com", "Trịnh Trường Nhân", 2, "TRONGHUNG.PHAM65@HOTMAIL.COM", "TRONGHUNG.PHAM65@HOTMAIL.COM", "AQAAAAIAAYagAAAAEN1pL6M+ZM/hUAWrwDyPjWKaoZzYSIvvGVfNqOY+prlfiCHi/twLrR9ANVv+yWYppw==", "0215 6243 3463", "2da7493b-55f0-4c47-ba1b-1815f7a87fb0", "TrongHung.Pham65@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "467 Tăng Mill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20H%E1%BB%93ng%20Xu%C3%A2n", "6134550a-c0c1-4047-a219-3bd597f073c5", new DateTime(2004, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "MinhMinh.Nguyen87@hotmail.com", "Ngô Hồng Xuân", 1, "MINHMINH.NGUYEN87@HOTMAIL.COM", "MINHMINH.NGUYEN87@HOTMAIL.COM", "AQAAAAIAAYagAAAAEI0DhFX4AKpepnW67BHQqzjrpfAyaTn8u0AIrh77RFYK5yNHdxhPv6oIpwbp1/8t8w==", "0291 1769 0372", "6316a4f2-0e5a-4b1a-91ba-5048d9c3c6b9", "MinhMinh.Nguyen87@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5397 Đăng Khương Lakes", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Ch%C3%ADnh%20Thu%E1%BA%ADn", "f4865173-e648-4863-908a-b35ebc72e7f1", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "TrongKhanh.Ly40@gmail.com", "Bùi Chính Thuận", "TRONGKHANH.LY40@GMAIL.COM", "TRONGKHANH.LY40@GMAIL.COM", "AQAAAAIAAYagAAAAEGeQ5lAHX2GCow4PHTglNYMdrb3De/PsTlcjTA3REcMXgHg3Evgc+R5axzo4CVx+UA==", "0299 8205 2773", "4478d915-8a28-4e01-9b87-6db389ed9717", "TrongKhanh.Ly40@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9680 Hoàng Ramp", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Kh%E1%BA%AFc%20Tr%E1%BB%8Dng", "d564c3e6-b0d3-4bab-9eb4-d40e948e4eb5", new DateTime(2005, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), "AnhNgoc_Phan@yahoo.com", "Trịnh Khắc Trọng", 1, "ANHNGOC_PHAN@YAHOO.COM", "ANHNGOC_PHAN@YAHOO.COM", "AQAAAAIAAYagAAAAEMp/ZpcIglnUtbDepTyAvFPJroGTkIdr1QGdBUHPR3ikEl8/jEmBSnwM3CSX0Iw7CA==", "026 2163 4031", "01bd5662-53f2-44ae-ac3c-dbb438bbc560", "AnhNgoc_Phan@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "97227 Hải Dương River", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Ho%C3%A0ng%20Xu%C3%A2n", "f5e84a72-0697-4352-84ce-00539865a249", new DateTime(2012, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "HuongTrang_Tang@gmail.com", "Đặng Hoàng Xuân", "HUONGTRANG_TANG@GMAIL.COM", "HUONGTRANG_TANG@GMAIL.COM", "AQAAAAIAAYagAAAAEHSkC8aPZ/W0hEt2nYiuVZEU+IX4EBD4BisgXTlOj5+Iii0xpMEwa2KThoN0ZtGorQ==", "021 5984 1126", "96abd78d-6169-4a5e-a107-6c1ef4502560", "HuongTrang_Tang@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "211 Phạm Parkway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Minh%20Ho%C3%A0ng", "8c704281-9f79-446d-a964-0d7836838405", new DateTime(2000, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), "HungDung_Phan26@yahoo.com", "Bùi Minh Hoàng", 3, "HUNGDUNG_PHAN26@YAHOO.COM", "HUNGDUNG_PHAN26@YAHOO.COM", "AQAAAAIAAYagAAAAEPBbWWe7coN/r1A6ac/DMTKwFaUJ5ryLr8RQZa0CDr9rpZoB3F5OXfjkohqH8HnTgw==", "0258 1119 6639", "29539017-ccf6-4a3f-b51f-07077ea207be", "HungDung_Phan26@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "992 Bảo Lâm Trail", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Thanh%20B%C3%ACnh", "48573496-3ebe-4c17-8e5c-b90d655b3114", new DateTime(2002, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "ThanhToan_Dao19@yahoo.com", "Dương Thanh Bình", 2, "THANHTOAN_DAO19@YAHOO.COM", "THANHTOAN_DAO19@YAHOO.COM", "AQAAAAIAAYagAAAAEHIuhC/hCVnlP2MI9MCXj+Z8g9NciKUgqhV27dpBVZpwEVO7sN+OtoN/DhtnA7WzaQ==", "027 5908 7725", "08573f2d-2799-4bf7-8401-070ebd2be5be", "ThanhToan_Dao19@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "980 Việt Tuyết Cliffs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20C%C3%B4ng%20H%E1%BA%ADu", "c5bd2974-c6a4-4204-a151-847050eeafb2", new DateTime(2003, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "QuangTuan.Pham84@hotmail.com", "Tô Công Hậu", "QUANGTUAN.PHAM84@HOTMAIL.COM", "QUANGTUAN.PHAM84@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKJZQu10bplwktwzl5fvgivfU57Uj1kBIGssFwE7OO5sYQNmS9RHoggLPNifs+Zqrw==", "025 6427 7200", "e9327c23-d92f-44eb-91e1-5eb34dbffa64", "QuangTuan.Pham84@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "419 Khánh Giao Mews", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Linh%20Nhi", "01b9e881-ff0e-4353-8c22-95e8f0d7ed8a", new DateTime(1997, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "HuuTan_Dinh85@yahoo.com", "Tăng Linh Nhi", 1, "HUUTAN_DINH85@YAHOO.COM", "HUUTAN_DINH85@YAHOO.COM", "AQAAAAIAAYagAAAAEKOBBs0TspNaJ0leAb9w2yJ1fOzGySWsWXzEUoGJNn/c9hsgpu6didHPLJbP8xE1Mw==", "0265 0806 3611", "46ef89fe-dce3-4987-a77f-49059bd715f8", "HuuTan_Dinh85@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "053 Lý Hills", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20H%E1%BB%AFu%20Canh", "912cd256-6024-4897-b38a-197674801602", new DateTime(2002, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "TrongNhan.Le@gmail.com", "Trương Hữu Canh", 2, "TRONGNHAN.LE@GMAIL.COM", "TRONGNHAN.LE@GMAIL.COM", "AQAAAAIAAYagAAAAEEarrlL71hsi6j1UECYJWcWWbYmU3Jp+pJuvffDf1aEz7llLWRuCoG3MZaSkbSZRLw==", "0240 4613 0949", "f4641568-fa05-41ff-a916-33a611d27c10", "TrongNhan.Le@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "31181 Thụy Du Rue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20B%E1%BA%A1ch%20Tuy%E1%BA%BFt", "08ed24af-d3ce-47b7-90b2-e75a2e7c9bec", new DateTime(2008, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "GiaBach_Phan94@gmail.com", "Trương Bạch Tuyết", 3, "GIABACH_PHAN94@GMAIL.COM", "GIABACH_PHAN94@GMAIL.COM", "AQAAAAIAAYagAAAAEDEWdDsSmQ1rXuzZ6J0bQ/jwgRaKcMifuyMzR9vksW8M+qNoEq225PKilrF+ETrDag==", "029 0323 4446", "88b9229a-c2cf-47db-a2a0-55e351d2a7c9", "GiaBach_Phan94@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "412 Phùng Mission", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20B%C3%ADch%20H%E1%BA%A3o", "5744653d-3052-4da4-8603-0f543030b9bf", new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "HaThanh.Dao@yahoo.com", "Bùi Bích Hảo", 3, "HATHANH.DAO@YAHOO.COM", "HATHANH.DAO@YAHOO.COM", "AQAAAAIAAYagAAAAEL6Yah0jdbnJwoWIKU6U8VALgHkeL97IxkV+Sj7rmMWtABISNxB8HrCPSNf5Q3fjlw==", "020 6208 4602", "084a465f-4dc1-48a5-be6a-1ed75d24e785", "HaThanh.Dao@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "108 Ngọc Ánh Hill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20Xu%C3%A2n%20Nam", "403bc39e-902e-4cc1-9d08-3662515f93a7", new DateTime(2015, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "ChiNam_Truong@yahoo.com", "Lâm Xuân Nam", "CHINAM_TRUONG@YAHOO.COM", "CHINAM_TRUONG@YAHOO.COM", "AQAAAAIAAYagAAAAEPGZ4NIqRFW3pfbnhetbYellvgYskE1Jo+Dn261cMT47vfvf+i3nn4DtalvM+553DQ==", "0239 4849 4273", "518b12ff-88db-4ed7-975e-e4a57e260985", "ChiNam_Truong@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "194 Hà Canyon", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20Tr%C6%B0%E1%BB%9Dng%20An", "95a310c3-0b4c-48d5-b120-3281b88e03b3", new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "ThatDung_Duong@gmail.com", "Lâm Trường An", 1, "THATDUNG_DUONG@GMAIL.COM", "THATDUNG_DUONG@GMAIL.COM", "AQAAAAIAAYagAAAAENauXUemfmAReq0M7LJJhFwEhZUZ89UKpS9vzsQ4Ga4Mn3R6iuKPzpA4f1AMZ9JXrg==", "020 3608 3278", "95225777-6a63-4208-b95d-0ae76bfc2ef4", "ThatDung_Duong@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2890 Vương Crossroad", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Gia%20%C3%90%E1%BB%A9c", "a70dcf53-2bfd-4120-88d3-9e144717afcc", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "TrongHung3@hotmail.com", "Mai Gia Ðức", "TRONGHUNG3@HOTMAIL.COM", "TRONGHUNG3@HOTMAIL.COM", "AQAAAAIAAYagAAAAEL2hCVQ+j1Xw31S+o7bXnb5JXxUf9rIn7jU6/iomWK59EmkWxOyoOfU6W2jC0whQIw==", "0270 8674 9653", "72653eaf-954a-4ac4-812e-813e14cd6672", "TrongHung3@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "904 Nam Hải Falls", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20M%E1%BB%99ng%20H%E1%BA%B1ng", "44de1a6e-b86a-4108-8589-5e52e4c131dc", new DateTime(1997, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "ThanhLoi_Lam19@yahoo.com", "Đỗ Mộng Hằng", 2, "THANHLOI_LAM19@YAHOO.COM", "THANHLOI_LAM19@YAHOO.COM", "AQAAAAIAAYagAAAAEM/BnDcuUZ2x1951hNBJUT+wjXhWo8+UT2yo8CMVca2nC0nHtJ7F51TuMQipNB2A6g==", "024 6589 2690", "29767b5d-7c98-4f0c-ad5d-1be480ba800b", "ThanhLoi_Lam19@yahoo.com" });
        }
    }
}
