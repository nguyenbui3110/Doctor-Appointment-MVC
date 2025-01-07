using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorAppointment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DoctorReviewsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "AverageRating",
                table: "Doctors",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), "Voluptates temporibus voluptatem id sed molestiae omnis aut earum aspernatur.", 69, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 18, 0, 0, 0), "Et id odio expedita voluptatum tempore architecto minima.", 94, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 14, 0, 0, 0), "Dolores atque ea eum eos sequi enim assumenda.", 37, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 11, 0, 0, 0), "Error necessitatibus nulla quod cumque inventore ea voluptatum.", 76, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), "Neque sequi harum nobis sint.", 5, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 11, 0, 0, 0), "Quasi sit quod.", 15, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), 14, "Minima atque dicta ex quia non quia ut.", 12, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 17, 0, 0, 0), "Qui consectetur facilis sit blanditiis aliquam qui ipsa fugiat.", 17, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Dolorum quibusdam numquam ratione aliquam.", 16, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 12, "Debitis aliquam aspernatur occaecati quia iusto eaque consequatur sint.", 79, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), 14, "Id facere harum non sed quia laudantium minima velit.", 44, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 17, 0, 0, 0), "Qui quo harum asperiores impedit quia officia.", 5, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), 13, "Aliquid debitis quisquam saepe et quidem quisquam labore.", 12, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 10, 0, 0, 0), "Veritatis corporis hic qui.", 47, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 11, 0, 0, 0), "Aut quis est magnam doloribus a cum autem iste.", 36, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 15, 0, 0, 0), "Officiis quos vero reiciendis vero facere qui tenetur nisi provident.", 47, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 12, 0, 0, 0), "Quos ut rerum iure qui tempora.", 43, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), 7, "Ipsa perspiciatis quaerat autem voluptas non vel voluptatum.", 80, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 18, 0, 0, 0), "Dolore cumque quos iure perferendis aut voluptates error placeat.", 29, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), 13, "Quo libero non quia qui quasi et.", 66, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "At sit id.", 52, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), 13, "Et deserunt quia enim doloremque nobis repellendus qui.", 98, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), "Quisquam ut sit id unde et.", 23, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 14, 0, 0, 0), "Id omnis qui ipsum.", 54, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 18, 0, 0, 0), "Laudantium maxime sunt ea.", 88, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 9, 0, 0, 0), "Reiciendis magni accusantium voluptatem iure voluptatibus enim ipsa eum.", 40, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Error incidunt velit qui tempore beatae officia quod molestiae.", 65, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Sed voluptas culpa minima blanditiis et.", 49, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 16, 0, 0, 0), "Similique reiciendis tempore.", 80, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Voluptatum eius qui aspernatur aliquam id.", 17, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), "Eum et pariatur et est hic omnis dolores.", 70, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 9, 0, 0, 0), "Omnis laboriosam delectus similique vero ut.", 6, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 18, 0, 0, 0), "Itaque velit ut velit eius facere.", 61, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Blanditiis inventore dignissimos vel molestiae.", 51, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 10, 0, 0, 0), "Doloribus officiis impedit quaerat similique.", 1, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 13, 0, 0, 0), "Neque consequatur quae nesciunt id doloremque nihil.", 99, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 4, "Laboriosam laudantium incidunt exercitationem autem rerum.", 45, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 0, 0, 0), "Dolor culpa ea iste neque eos et.", 93, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Corrupti sit architecto ea numquam.", 60, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 0, 0, 0), "Aliquid cumque dolores ut cum.", 89, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 9, 0, 0, 0), "Est voluptatibus nobis architecto a ipsa asperiores.", 57, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Unde dignissimos deserunt vero inventore repellendus in.", 56, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), "Qui impedit exercitationem suscipit aut soluta sint id consectetur quos.", 58, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 16, 0, 0, 0), "Adipisci velit consequatur animi fugit nihil.", 62, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), "Quod ea velit dolor.", 64, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 11, 0, 0, 0), "Fugiat voluptatum sed consequuntur esse quasi quo quos.", 101, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 14, 0, 0, 0), "Non optio voluptas magni et consectetur quia sint.", 23, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 17, 0, 0, 0), "Magnam assumenda voluptatibus dicta qui laborum hic.", 81, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 9, 0, 0, 0), "Explicabo magni harum nihil corporis voluptatem.", 67, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 9, 0, 0, 0), "Ipsam sapiente facilis vel rerum odio dolore hic sed.", 30, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 17, 0, 0, 0), "Repellendus aut eligendi distinctio aliquid numquam omnis magni sed.", 87, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 13, 0, 0, 0), "Et dicta quia enim et et qui nihil quae.", 97, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 17, 0, 0, 0), "Animi placeat impedit non placeat repudiandae ab rerum voluptatem.", 29, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Illo est repellendus dolore eum quo quo.", 40, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 14, 0, 0, 0), "Molestias rerum quidem id quia exercitationem sit delectus.", 20, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 13, 0, 0, 0), "Rerum reiciendis et blanditiis nostrum nostrum.", 9, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 14, 0, 0, 0), "Consequatur et quia deleniti unde dolorem quia voluptatem voluptatem eum.", 41, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 15, 0, 0, 0), "Quibusdam sit rerum voluptas optio repellendus.", 84, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Dolores possimus ducimus possimus eligendi consequatur.", 85, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 17, 0, 0, 0), "Eos velit nihil omnis.", 34, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Aut illo facere aut maxime ex est expedita.", 72, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 15, 0, 0, 0), "Explicabo rerum cumque aut.", 77, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 14, 0, 0, 0), "Nisi doloremque et.", 71, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), "Autem earum neque id necessitatibus blanditiis velit similique.", 1, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 12, 0, 0, 0), "Illo quia consequatur nisi et ea numquam alias dolor fugit.", 66, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 10, 0, 0, 0), "Eum sapiente ipsam quod ad soluta eos tempora eum.", 51, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 13, "Omnis quia et et.", 71, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 13, 0, 0, 0), "Soluta aut velit.", 5, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 9, 0, 0, 0), "Iste sint dolorem.", 16, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), "Cum blanditiis qui cum aliquid ut sed laborum qui.", 80, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 7, "Eaque consequuntur omnis fugiat repellat quisquam expedita qui.", 88, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 15, 0, 0, 0), "Cum qui voluptatem aspernatur.", 68, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 16, 0, 0, 0), "Ea impedit et eos placeat sunt vero quam laudantium magnam.", 34, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), 11, "Adipisci dolore ea non fuga.", 87, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), "Odio dolorem et fugit reprehenderit hic.", 14, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), "Voluptatem quos sapiente sed tempore autem nulla iure enim doloribus.", 6, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), 15, "Est vitae quis ea molestias voluptatem repudiandae incidunt sapiente.", 63, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 9, 0, 0, 0), "Ipsa repellendus iste nobis quos ipsum fugit recusandae.", 9, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 18, 0, 0, 0), "Exercitationem est culpa quas iure occaecati laboriosam suscipit.", 4, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Nobis atque ad ut vel et temporibus.", 6, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 12, 0, 0, 0), "Provident ut saepe fuga.", 42, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), "Dicta laborum quidem non.", 14, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), "Assumenda distinctio est ut illum delectus dolor dolorem ratione repellendus.", 87, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 0, 0, 0), "Qui unde illum beatae.", 17, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), "Sed qui ipsa.", 70, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 13, 0, 0, 0), "Provident voluptatem reprehenderit velit rerum id consequatur praesentium ipsam ullam.", 74, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), 6, "Ut debitis quia at labore et dolores alias mollitia reiciendis.", 10, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 16, "Qui quod cumque non eveniet sequi ad.", 65, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Neque error inventore illo quis qui voluptas placeat pariatur nisi.", 58, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Itaque modi quibusdam rerum voluptas qui quis enim.", 58, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), "Architecto libero sit aut.", 1, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 15, 0, 0, 0), "Non itaque repudiandae optio.", 1, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 15, 0, 0, 0), "Animi dignissimos dolor et quidem et unde quam laudantium.", 2, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 13, 0, 0, 0), "Repudiandae pariatur eos aut dolorem.", 83, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 15, 0, 0, 0), "Facilis magni numquam ea dolor pariatur temporibus aut.", 92, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), "Dolorum nihil quibusdam reiciendis cum.", 28, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Unde voluptas itaque qui sed doloremque ut.", 26, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 12, 0, 0, 0), "Molestiae non non ad ea dolores itaque voluptatem.", 91, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 18, 0, 0, 0), "Iste ab rem consequatur consequuntur libero sed incidunt.", 62, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Nihil eius minus veritatis enim qui ut temporibus vero quia.", 97, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 16, 0, 0, 0), "Illo recusandae est sit quas quam sit.", 67, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 12, 0, 0, 0), "Consequatur ut vitae.", 33, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), "Nemo soluta ipsa.", 74, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 15, 0, 0, 0), "Vitae doloribus ducimus.", 47, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), "Consequatur qui laborum atque consequatur rem.", 4, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 16, 0, 0, 0), "Quae doloremque delectus et accusamus nesciunt.", 1, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 16, 0, 0, 0), "Nobis velit animi dignissimos nam exercitationem consequatur nobis.", 20, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Illum natus voluptas aut omnis odio pariatur.", 10, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 15, 0, 0, 0), "Distinctio eaque ipsa sed quis sint.", 95, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 17, 0, 0, 0), "Sit molestias possimus et quas quas alias quia labore vel.", 32, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 17, 0, 0, 0), "Nulla voluptatem sint quia maxime.", 83, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 13, 0, 0, 0), "Magni ut earum eligendi tempore.", 58, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), 7, "Expedita corporis cupiditate praesentium vitae doloremque quia et rerum dolor.", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 18, 0, 0, 0), "Numquam quod non accusantium dolorum repudiandae qui eveniet sed iusto.", 77, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 16, 0, 0, 0), "Minima et et voluptates perspiciatis facilis fugiat similique.", 9, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Porro et omnis aperiam aut fugit numquam quasi quae dolor.", 61, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 13, 0, 0, 0), "Qui culpa sit et iusto.", 16, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), "Sunt maxime omnis esse vero est alias.", 92, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 14, 0, 0, 0), "Dolorem reprehenderit maxime laudantium vitae et tenetur labore autem.", 41, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 18, 0, 0, 0), "Necessitatibus provident doloribus.", 30, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 15, 0, 0, 0), "Illo et quaerat nihil officiis facere et fugit dignissimos error.", 78, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 12, 0, 0, 0), "Quas pariatur qui officia.", 79, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), "Alias enim quis perferendis.", 67, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 9, 0, 0, 0), "Error quaerat neque qui.", 25, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 14, 0, 0, 0), "Et cum vitae.", 67, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 17, 0, 0, 0), "Dolorem autem suscipit error.", 75, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 9, 0, 0, 0), "Architecto autem consequatur est.", 3, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), "Voluptas tempora dolores.", 83, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Debitis maxime placeat id ea est architecto vero.", 68, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 14, 0, 0, 0), "Qui alias totam eius natus esse dolor et id.", 7, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Incidunt id rerum sed repellendus sed suscipit quos est.", 33, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "In qui sit similique.", 9, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 13, 0, 0, 0), "Voluptatibus assumenda tenetur nam tempore veritatis pariatur excepturi.", 82, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 17, 0, 0, 0), "Libero sint repudiandae iste sed tenetur consequuntur ratione.", 91, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 12, 0, 0, 0), "Aliquam sed voluptatem ut modi.", 9, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 13, 0, 0, 0), "Ea quaerat quod officiis et vel.", 61, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 15, 0, 0, 0), "Ut sed iusto reprehenderit ullam rem et praesentium culpa.", 58, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), "Minus doloremque adipisci eos tempore qui ut sed necessitatibus.", 22, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 9, 0, 0, 0), "Esse hic quibusdam et qui voluptas officia eveniet.", 67, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 17, 0, 0, 0), "Sequi aut qui similique.", 31, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 19, "Et aliquid id quia possimus quas quod dolor ab.", 78, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Voluptatem vero culpa adipisci ut.", 93, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 10, 0, 0, 0), "Omnis tempore facilis rem qui illo vel sunt.", 10, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 11, 0, 0, 0), "Porro nesciunt repellendus.", 52, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 16, 0, 0, 0), "Quis rerum ea amet itaque fugiat.", 90, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 14, 0, 0, 0), "Non omnis et nulla nostrum eos voluptatem voluptates.", 9, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 18, 0, 0, 0), "Quo reiciendis voluptate et tempore earum ipsam quis.", 70, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 15, 0, 0, 0), "Nobis animi quas numquam atque.", 74, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), "Atque optio nihil.", 25, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Eum porro voluptatem earum velit molestias eligendi a.", 61, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 14, 0, 0, 0), "Molestias quidem ea.", 58, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Totam ea quod suscipit dolores vel animi consectetur dolor ut.", 29, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 15, 0, 0, 0), "Consequatur provident esse.", 96, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 16, 0, 0, 0), "Ut incidunt maiores reiciendis.", 100, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 15, 0, 0, 0), "Voluptas fugit impedit asperiores quia consequatur sed voluptatem eos facere.", 12, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Sunt consequatur cupiditate incidunt et neque illo.", 26, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 18, 0, 0, 0), "Ut magnam nesciunt amet reprehenderit nobis distinctio.", 6, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 18, 0, 0, 0), "Fugit tempore voluptatum.", 1, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 14, 0, 0, 0), "Illo non repellat quia occaecati sint itaque sapiente totam.", 7, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 14, 0, 0, 0), "Quidem ullam voluptatem et beatae quam molestiae quis dolores.", 84, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), "Temporibus dolorem dolores odio autem qui.", 51, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 17, 0, 0, 0), "Assumenda eum praesentium voluptatem reiciendis vel molestiae.", 54, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 18, "Id animi nihil recusandae rerum non quis ullam repellat.", 3, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), "Enim vel magnam possimus recusandae dicta voluptatem vitae omnis.", 95, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 11, 0, 0, 0), "Magnam neque architecto.", 45, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 9, 0, 0, 0), "Numquam necessitatibus aut ipsum veritatis sed quaerat odio ratione consequatur.", 30, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), "Cum enim illum ea consequuntur est repellat et enim ratione.", 56, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 14, 0, 0, 0), "Commodi enim rerum perspiciatis ad quasi magnam quas.", 7, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 15, 0, 0, 0), "Veniam ut assumenda animi ipsa dolorem autem et.", 34, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 12, 0, 0, 0), "Error ex modi.", 68, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Rerum molestiae dolorem corrupti et consectetur enim culpa repellat natus.", 57, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 12, 0, 0, 0), "Ducimus a est expedita.", 7, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 12, 0, 0, 0), "Repellat pariatur sunt molestiae ut.", 72, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 13, 0, 0, 0), "Non omnis minima voluptatem est odio alias.", 13, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 9, 0, 0, 0), "Quia culpa sit ratione earum id magni.", 87, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 17, 0, 0, 0), "Fugiat suscipit totam voluptate commodi.", 78, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 15, 0, 0, 0), "Praesentium voluptatem in.", 79, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), "Ducimus mollitia totam veniam qui quo sapiente alias.", 72, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 16, 0, 0, 0), "Quia itaque et eos vero reiciendis deserunt.", 54, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 17, 0, 0, 0), "Nulla itaque est repellat a eaque et.", 71, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 19, "Ut ut vero.", 47, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 14, 0, 0, 0), "Placeat consequatur autem minima dignissimos temporibus autem provident vel architecto.", 90, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 12, 0, 0, 0), "Voluptas velit voluptates distinctio similique quod a non rerum nemo.", 3, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 14, 0, 0, 0), "Voluptates voluptatibus minus dolorem qui ut nihil architecto.", 94, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), "Molestias placeat aliquid sit aut expedita sint et autem quia.", 99, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 16, 0, 0, 0), "Labore laborum qui id similique.", 95, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 10, 0, 0, 0), "Quo voluptatem nesciunt nam perferendis adipisci.", 74, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Dignissimos repudiandae doloribus dicta aspernatur impedit aperiam officiis quia doloremque.", 13, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), "Eum id neque quasi exercitationem assumenda tempore temporibus sed.", 64, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 14, 0, 0, 0), "Assumenda sit aut laboriosam iste veritatis sequi aut necessitatibus.", 19, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 18, 0, 0, 0), "Iste quibusdam debitis vel quo ut pariatur facilis quia.", 57, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 14, 0, 0, 0), "Quo quod quae qui explicabo aperiam explicabo minima.", 63, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 15, 0, 0, 0), "Quae vel omnis accusamus quidem adipisci porro aut consequatur.", 97, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Et perspiciatis repellendus ut mollitia nostrum.", 73, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Et id nihil rerum dolore ut cumque nihil non animi.", 94, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 18, 0, 0, 0), "Numquam odit eum voluptatum.", 57, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 16, 0, 0, 0), "Ab qui sint dolor nisi numquam est.", 18, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), "Ipsa quos fugit.", 12, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), "Neque quasi enim nemo ut enim quo.", 61, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 10, 0, 0, 0), "Labore mollitia est repellat et ipsum voluptas.", 45, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Voluptatum tempora quibusdam quia est.", 65, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { 3, new TimeSpan(0, 14, 0, 0, 0), "Quo atque tempora aut eius facere minus aperiam rerum iure.", 3, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 0, 0, 0), "Voluptatem praesentium sequi id minima.", 94, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 0, 0, 0), "Aspernatur velit ut odio neque blanditiis quidem.", 35, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 9, 0, 0, 0), "Ipsum inventore ab totam possimus eum ipsum ipsa sint non.", 67, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), 2, "In reprehenderit qui.", 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), "Quidem ab dolores consequatur.", 86, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 18, 0, 0, 0), "Et dolor enim iusto libero mollitia dolorem.", 95, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 6, "Quia alias non pariatur iste quas unde voluptas ut suscipit.", 64, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), "Error quia deserunt repellendus quibusdam quaerat est exercitationem est nihil.", 35, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 10, 0, 0, 0), "Eos molestiae atque occaecati id cumque.", 97, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 11, 0, 0, 0), "Omnis numquam veritatis fugiat vel suscipit nisi.", 51, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 14, 0, 0, 0), "Hic voluptatem repellendus eos.", 72, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 14, 0, 0, 0), "Mollitia magnam et nihil facilis quos voluptatum.", 56, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 14, 0, 0, 0), "Et molestias aut deleniti ducimus quia veritatis.", 2, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), "Consequuntur eius perferendis veritatis nisi quae modi ut.", 8, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 18, 0, 0, 0), "Quas explicabo aliquid labore.", 66, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 14, 0, 0, 0), "Recusandae unde eum rem quo.", 53, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), "Ipsa quam quibusdam dolores natus laborum suscipit aliquam.", 16, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 0, 0, 0), "Sint asperiores aliquam in dignissimos dolores.", 25, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), "Aut est placeat iure excepturi qui quidem nesciunt asperiores.", 93, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), "Similique voluptatibus eveniet saepe aperiam facilis sapiente fugit qui sed.", 86, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 14, 0, 0, 0), "Quia sit consequatur explicabo sint.", 54, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 0, 0, 0), "Voluptates placeat eum suscipit ut numquam voluptatem ipsum aut.", 81, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 9, 0, 0, 0), "Esse modi sed ex modi reprehenderit vitae et amet fugit.", 95, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 0, 0, 0), "Quia eos illum ut sunt aut fugit et.", 72, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Alias eum aut qui est voluptate quasi praesentium.", 18, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 9, 0, 0, 0), "Sequi officia sint quia reiciendis officia quia quam.", 11, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 17, 0, 0, 0), "Doloremque quaerat eos laborum consequatur in facilis maxime.", 63, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 0, 0, 0), "Id in ab assumenda rerum.", 91, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 16, 0, 0, 0), "Autem iste rerum est aut odit earum blanditiis autem.", 2, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 15, 0, 0, 0), "Placeat nihil illum distinctio esse optio laboriosam.", 3, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 15, 0, 0, 0), "Quisquam eligendi voluptatem rerum.", 4, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 15, 0, 0, 0), "Delectus repudiandae voluptatem ut illum veniam.", 89, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 14, 0, 0, 0), "Minima excepturi veniam adipisci et provident eius molestiae magnam.", 13, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 0, 0, 0), "Facilis nemo ipsam nobis quasi sed in est vel eum.", 21, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Quos est ipsum tempora assumenda molestiae omnis dolorum accusamus.", 23, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 16, 0, 0, 0), "Eum ipsa non.", 52, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), "Qui sit distinctio et sint accusamus.", 10, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 0, 0, 0), "Architecto voluptas molestiae similique cupiditate perspiciatis quisquam qui.", 18, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 14, 0, 0, 0), "Architecto quia maiores ut.", 2, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 14, 0, 0, 0), "Autem suscipit sed unde debitis quod quo.", 68, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 13, 0, 0, 0), "Vero distinctio qui molestiae est rerum officia accusamus.", 56, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Molestiae vel fuga non est qui laudantium omnis culpa in.", 19, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 10, 0, 0, 0), "Ad cumque laborum ullam.", 85, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 12, 0, 0, 0), "Et eum earum voluptatibus voluptatem aut.", 90, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 8, "Optio natus perferendis.", 30, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), 8, "Labore sit dolore molestiae quia qui.", 78, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 16, 0, 0, 0), "Adipisci autem quia ut amet.", 97, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 18, 0, 0, 0), "Vel nesciunt recusandae.", 34, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Magnam non rerum repudiandae.", 53, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 12, 0, 0, 0), "Quam velit nobis temporibus.", 83, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 0, 0, 0), "Perspiciatis enim laudantium ex ad distinctio.", 90, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), "Quas et culpa qui nesciunt facere consectetur est qui.", 11, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 18, 0, 0, 0), "Illo nam accusantium quidem neque omnis impedit iusto aut.", 67, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 14, 0, 0, 0), "Vel illo et consequatur sunt occaecati minus dignissimos.", 21, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 17, 0, 0, 0), "Enim explicabo ullam distinctio.", 33, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, "Magni qui mollitia rerum vero ratione sit tempora dolore perferendis.", 64, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 0, 0, 0), "Non et ex optio aliquam facere non rem.", 88, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 12, 0, 0, 0), "Quidem non fugiat veritatis architecto.", 95, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 15, 0, 0, 0), "Ab mollitia in veritatis corrupti vero.", 15, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), "In dicta delectus totam facere quaerat voluptatum.", 6, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 13, 0, 0, 0), "Consequuntur sunt dolor.", 29, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 11, 0, 0, 0), "Corrupti officiis commodi cupiditate doloremque aut cupiditate.", 46, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 14, 0, 0, 0), "Corporis quisquam iure ut corrupti eos consequatur ut.", 94, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 16, "Et vero necessitatibus.", 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 19, "Aut dolores enim.", 31, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 15, 0, 0, 0), "Iure placeat et nobis.", 29, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 14, 0, 0, 0), "Et et perferendis nesciunt vel incidunt suscipit illum.", 26, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 15, 0, 0, 0), "Deserunt minima ab et sunt sed maiores quasi nihil.", 72, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), "Odio suscipit tenetur laudantium eum dolor velit omnis.", 68, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 14, 0, 0, 0), "Nulla ad voluptatibus architecto.", new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), 13, "Et doloribus inventore asperiores ut qui autem cum numquam dolor.", 56, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), "Reiciendis cumque quos dolor praesentium nihil autem.", 47, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 12, 0, 0, 0), "Dolorem voluptas neque amet totam explicabo.", 77, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 13, 0, 0, 0), "Aut sit dolorem.", 48, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 18, 0, 0, 0), "Eos non ut velit consequatur a repellendus dicta accusantium qui.", 67, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 11, 0, 0, 0), "Incidunt optio quo quasi consequatur mollitia voluptas.", 4, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 12, 0, 0, 0), "Ea sit rerum optio voluptas molestias provident non.", 7, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), "Cupiditate vel ipsum sapiente voluptatem est sunt quia expedita voluptatem.", 53, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 9, 0, 0, 0), "Nihil dicta rem dolorum.", 79, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), 2, "Earum facilis ipsum modi quae et sed repellat.", 3, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 0, 0, 0), "Nihil ut quisquam.", 44, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 12, 0, 0, 0), "Laudantium dicta eligendi ipsa.", 50, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 15, 0, 0, 0), "Mollitia sint praesentium doloremque.", 55, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 15, 0, 0, 0), "Amet perferendis dolorem magni omnis.", 62, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 16, 0, 0, 0), "Alias molestiae neque magnam iste est.", 30, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 17, 0, 0, 0), "Blanditiis enim vero enim natus.", 100, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 14, 0, 0, 0), "Fugiat laudantium aliquid eum.", 26, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 13, 0, 0, 0), "Ut magnam possimus sapiente enim.", 38, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 11, 0, 0, 0), "Cupiditate et repellendus officia dolores cumque sit ducimus assumenda.", 11, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 9, 0, 0, 0), "Tempora cupiditate id molestiae.", 45, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 18, 0, 0, 0), "Voluptatem impedit in aut ut voluptatum.", 101, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 12, 0, 0, 0), "Tenetur totam illum rerum.", 25, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 13, 0, 0, 0), "Amet dolorum aut inventore velit maxime impedit natus natus aut.", 18, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 17, 0, 0, 0), "Dignissimos et alias maxime ut magnam.", 88, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), "Dolorem quisquam aut voluptas explicabo eveniet.", 84, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 12, 0, 0, 0), "Earum rerum rerum nam rerum aliquam voluptas veritatis.", 11, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 16, 0, 0, 0), "Aut velit aut nam saepe earum dolores.", 84, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), "Veniam enim dignissimos et qui et reiciendis odit.", 67, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "AverageRating", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Da liễu", 0.0, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Thần kinh", 0.0, 4, 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Da liễu", 0.0, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Nhi khoa", 0.0, 5, 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Tim mạch", 0.0, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "About", "AverageRating", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Thần kinh", 0.0, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Da liễu", 0.0, 3, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Tim mạch", 0.0, 2, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "About", "AverageRating", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Thần kinh", 0.0, 9 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Tim mạch", 0.0, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Nhi khoa", 0.0, 5, 9 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Thần kinh", 0.0, 4, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Nhi khoa", 0.0, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Da liễu", 0.0, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Tim mạch", 0.0, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Đa khoa", 0.0, 1, 9 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Thần kinh", 0.0, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Da liễu", 0.0, 3, 10 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Thần kinh", 0.0, 4, 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Da liễu", 0.0, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90619bf7-e0ce-48fe-9d38-0a1a741cba9a", "AQAAAAIAAYagAAAAEPsT2o7Uy10tEY4XX3MFrGw6owFSmFyem3Ucq0TQSB6mDRI6ZudxX//Ah4Rva+eXQg==", "af256468-a878-472e-a974-2776c4c23b9a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "00926 Xuân Cung Hollow", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20Ho%C3%A0ng%20D%C5%A9ng", "75e5ec36-053c-4104-b35b-6e194792692f", new DateTime(2011, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "MinhNguyet.Dao@yahoo.com", "Phan Hoàng Dũng", 2, "MINHNGUYET.DAO@YAHOO.COM", "MINHNGUYET.DAO@YAHOO.COM", "AQAAAAIAAYagAAAAEBYJHGLM8DycURruOsbEYHdjAStzHWd1gKBBWwKNjix/09Y9HltwoZ1hHoGTN2Al6w==", "0283 1950 3875", "fe944007-91af-4f25-b5bc-5abedf9b6c42", "MinhNguyet.Dao@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "838 Quốc Hải Crescent", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Th%C3%BAy%20H%E1%BA%B1ng", "5ddbc10c-ff8f-4048-b162-ddc3adabb2bd", new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "DuyAn10@gmail.com", "Đinh Thúy Hằng", 2, "DUYAN10@GMAIL.COM", "DUYAN10@GMAIL.COM", "AQAAAAIAAYagAAAAEJ3YEtfmzVhOkKhEwI+zowfGBw9fXLx64H1v3rakVFy7yiG406Lcj/MVsGvmJ6mX+Q==", "0261 3606 4950", "33c37d6e-493d-4b8e-af41-766b7dcc7c3c", "DuyAn10@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2995 Phạm Valley", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Ng%E1%BB%8Dc%20C%E1%BA%A7m", "d6f8cf69-5a99-434e-8821-475977f63f66", new DateTime(2008, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "TraGiang_Phan@yahoo.com", "Ngô Ngọc Cầm", 3, "TRAGIANG_PHAN@YAHOO.COM", "TRAGIANG_PHAN@YAHOO.COM", "AQAAAAIAAYagAAAAEO5X9bODXBLQlxX8pFsd1RaGa7l2itNPNrJFccAsS5XL+HsQzoCZDFGTi+Ky2MwYXw==", "0271 6242 6484", "d9245e8b-a440-43ff-bcf1-abb44d6722d2", "TraGiang_Phan@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "280 Quang Khanh Flats", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Kim%20Lan", "08fd7319-229a-4424-8c56-79909ebd8897", new DateTime(2000, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), "MinhToan_Mai@yahoo.com", "Dương Kim Lan", "MINHTOAN_MAI@YAHOO.COM", "MINHTOAN_MAI@YAHOO.COM", "AQAAAAIAAYagAAAAEEeTkjzDIpw4vsBcXpswz9hgO5aL419RQ8O/JqVVkYCoOrWZGVhj45EKmF+chl1MpA==", "028 2111 2959", "aef5a09c-a82f-47d9-9fb1-45d55fed150a", "MinhToan_Mai@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "05083 Thu Trang Stream", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20B%C3%ADch%20Ch%C3%A2u", "09d17e34-f951-4e7c-9597-e918dc7f07ea", new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), "PhuongNghi.Ngo59@yahoo.com", "Bùi Bích Châu", 1, "PHUONGNGHI.NGO59@YAHOO.COM", "PHUONGNGHI.NGO59@YAHOO.COM", "AQAAAAIAAYagAAAAELXtCjXjGqiGJt1C/L6Mn+/zo0lyCSDlJuzWO3fHchadxmcjNphY8letFM2zaXH8jw==", "025 1239 8462", "13208091-32e4-42b2-865f-398485dd2def", "PhuongNghi.Ngo59@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2484 Vũ Mission", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Xu%C3%A2n%20Uy%C3%AAn", "be18bf29-7cf2-4d9f-a4a2-3cd7bb65e3e4", new DateTime(2018, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "PhucLe73@gmail.com", "Mai Xuân Uyên", 1, "PHUCLE73@GMAIL.COM", "PHUCLE73@GMAIL.COM", "AQAAAAIAAYagAAAAEOx+0shxqa06Yhw+Jh1HEfD8XoLJ5/ihJdPAKH5DYlmIcCsF9NMjoXDyCPesAysYqA==", "022 0607 7125", "0060b128-1ae5-42dd-baba-1b6e8bcb8609", "PhucLe73@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "44642 Hương Xuân Estate", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Th%E1%BB%91ng%20Nh%E1%BA%A5t", "809d0729-7137-4c9b-87f3-cb7177f182b3", new DateTime(2020, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), "HuuHung_Nguyen@yahoo.com", "Trịnh Thống Nhất", 1, "HUUHUNG_NGUYEN@YAHOO.COM", "HUUHUNG_NGUYEN@YAHOO.COM", "AQAAAAIAAYagAAAAEN/hRSBU/Vx7CAjA/UigM0BIEj5uwA0ZoW2M5S2eCAlIphDawgZF91iDsuxMVQLLaw==", "0277 5788 1085", "cee2ec48-a19a-436c-ad24-84a08f340e07", "HuuHung_Nguyen@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8680 Tất Hiếu Lights", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20H%E1%BA%A1nh%20San", "d80b52e7-bf44-4270-9046-2bee8ad1cbb7", new DateTime(2016, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "DucChinh_Bui@hotmail.com", "Tăng Hạnh San", 1, "DUCCHINH_BUI@HOTMAIL.COM", "DUCCHINH_BUI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFXFGGkXlU/pUMiFIwnbl0WalPyELbH0RM7cgD+99WTbKiGL2j8dzW6RZsqWufFr3w==", "021 8235 8990", "ddd98b32-49eb-41b2-8cb3-f4f53bba2124", "DucChinh_Bui@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6287 Nguyễn Hill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Qu%E1%BB%91c%20To%E1%BA%A3n", "a477df8e-e6ad-405b-a195-0b014e2c892e", new DateTime(1998, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "MyLoi.Phung99@gmail.com", "Bùi Quốc Toản", "MYLOI.PHUNG99@GMAIL.COM", "MYLOI.PHUNG99@GMAIL.COM", "AQAAAAIAAYagAAAAEIafTr2bhnpcA4emAk5iy3gqN+pFkGgEJ3YWVxbSMoJZWjKRJCOn3eoRbLlFh0lrEw==", "023 7121 4829", "f90d7ef1-3764-4e07-977f-5f587ad4586b", "MyLoi.Phung99@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "16154 Hiền Hòa Road", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20C%E1%BA%A9m%20V%C3%A2n", "1660e132-2f45-42ae-8d32-d323517b50be", new DateTime(2017, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "NgocCam_Bui@yahoo.com", "Lê Cẩm Vân", "NGOCCAM_BUI@YAHOO.COM", "NGOCCAM_BUI@YAHOO.COM", "AQAAAAIAAYagAAAAEAg+EqAmuIiu3NM9cnkLz1bR25x9DPTZM1RyibkuS0k8NjnIPtWz+6LTy1NsE6EWgw==", "0215 1157 8818", "288deedc-6c2a-49fa-a933-32b44b716963", "NgocCam_Bui@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7919 Phan Run", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20H%E1%BA%A1nh%20My", "4a9eaebc-99e3-46c8-9121-8699520e8326", new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "UyenTho_Hoang@gmail.com", "Phùng Hạnh My", "UYENTHO_HOANG@GMAIL.COM", "UYENTHO_HOANG@GMAIL.COM", "AQAAAAIAAYagAAAAEIEUivMWrjrc1hgFQ75REI0UhHoKNoHI6/DbBwzmWdB2RFnFvAV7rS13ic8ScNnOFQ==", "0266 2801 5439", "efc635dd-4e56-4bb8-ad14-e736f92a491d", "UyenTho_Hoang@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "64245 Trường Nam Ford", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20Qu%E1%BB%91c%20Anh", "f5c029e2-e9be-4b1d-8029-fa683e33f557", new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "NhatLe_Ho@hotmail.com", "Trần Quốc Anh", "NHATLE_HO@HOTMAIL.COM", "NHATLE_HO@HOTMAIL.COM", "AQAAAAIAAYagAAAAECW/CTnX2yJfAev4mz/ZADlznBn7cWDkYB/IID9EYN+pdq5ujurcmb728jVyqIPpSQ==", "0260 3925 5967", "165ab448-bd25-4056-b802-e31886d7dddd", "NhatLe_Ho@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "622 Ngọc Ðoàn Street", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20Tr%C3%BAc%20Vy", "29bc95ce-0d9f-4688-a649-c0c9dbcbf72e", new DateTime(2015, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "HuyTuan32@gmail.com", "Lâm Trúc Vy", 2, "HUYTUAN32@GMAIL.COM", "HUYTUAN32@GMAIL.COM", "AQAAAAIAAYagAAAAEIn48agf6X804ENYcft7xgV6GqOeTsHFnaqS0Cjdtcl3wXgm/V3vmw1f8TqxrNRglQ==", "0275 2388 8647", "acbc424b-6960-4574-a44b-b3ccc3d40a0b", "HuyTuan32@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "70590 Hoàng Quân Points", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20B%C3%ADch%20Loan", "23ab7d4e-e4de-49f6-bb04-9d3f77768cd3", new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "YenThanh.Tran@hotmail.com", "Hồ Bích Loan", 2, "YENTHANH.TRAN@HOTMAIL.COM", "YENTHANH.TRAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAECflnayp8nM4xR6gGCRadI1ppkTA0BScCJjIhln2NuxzHSh9rUaisUIa2+kEKIwRtw==", "0202 7864 9099", "ccdffe40-95df-426a-9683-cb50f2252a16", "YenThanh.Tran@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "01952 Vũ Mills", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Th%C3%A0nh%20T%C3%ADn", "b7200096-0472-428d-a416-cf303addf61d", new DateTime(2016, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "DucBang26@yahoo.com", "Phạm Thành Tín", 1, "DUCBANG26@YAHOO.COM", "DUCBANG26@YAHOO.COM", "AQAAAAIAAYagAAAAELjCvLU0HlUaA4jQCBNLEvIwF5KUaem8NW4RUGy6+X2NfQcIZdvFXbGmTL51uI/EtQ==", "0211 8797 4024", "ba4c462e-e420-4f04-9ab1-2810c8bc1659", "DucBang26@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9021 Xuân Lâm Orchard", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Tr%E1%BB%8Dng%20H%C3%B9ng", "c18ded68-9885-4e07-8e69-493165ec68a6", new DateTime(2008, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "LinhNhi.Bui@yahoo.com", "Hồ Trọng Hùng", "LINHNHI.BUI@YAHOO.COM", "LINHNHI.BUI@YAHOO.COM", "AQAAAAIAAYagAAAAEKdY7JzojuzDSp64fFlTzfJMUj9PeLDpheKNFFzcRsdsLbPIYnBeX1vT4OyI+aV1xw==", "0206 1575 4682", "6ff0af5a-a4d8-46bc-9694-f145f39c6515", "LinhNhi.Bui@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3169 Ngọc Lam Mount", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Minh%20Th%C3%BAy", "825a09dd-13ec-42e0-8120-7bcf5871b3d8", new DateTime(2017, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "DaiNgoc39@gmail.com", "Phạm Minh Thúy", 2, "DAINGOC39@GMAIL.COM", "DAINGOC39@GMAIL.COM", "AQAAAAIAAYagAAAAEA8gfx9KzFBHTltmOsf8oB5OArIiZUVsq8m+A7WhDoa/5sSU5FCgnLgKmfNfBSIkIg==", "020 5231 3677", "ea2c7c5f-a3b4-44d8-8143-a028e0441b35", "DaiNgoc39@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "55498 Liên Chi Causeway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20C%E1%BA%A9m%20Linh", "186c93fe-8fcc-44fe-b2aa-947cb06b5114", new DateTime(1996, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "YenBang.Vu12@gmail.com", "Mai Cẩm Linh", 2, "YENBANG.VU12@GMAIL.COM", "YENBANG.VU12@GMAIL.COM", "AQAAAAIAAYagAAAAEBDU7BamAJJHMZM/hIuZdNcdEJ9KowICtvyc6f6Kzb5cOYu3krqJDhohxyMjyZhXPQ==", "0206 8570 7625", "edd7b64c-7981-4e97-970d-fa83ab9e4efc", "YenBang.Vu12@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6375 Kiều Diễm Islands", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Ho%C3%A0ng%20L%C3%A2m", "cefdb77c-9cb4-4cb1-9419-09f5b5fe2bc4", new DateTime(2000, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), "MinhVy99@yahoo.com", "Lê Hoàng Lâm", 2, "MINHVY99@YAHOO.COM", "MINHVY99@YAHOO.COM", "AQAAAAIAAYagAAAAEBX4ThUEjoE/Q7YD0ow5NvM2vCtcAmLodZjd2Vl0idqjMV4yZcIbe+08vAUtE/7t2w==", "026 2077 7927", "b0f63f69-19b0-4757-880f-1b9966daf0cb", "MinhVy99@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "318 Kim Thảo Radial", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Ng%E1%BB%8Dc%20H%C3%A0", "a122c330-e0e8-4974-a123-f5fba653f585", new DateTime(1999, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "AnhThi_Mai@yahoo.com", "Bùi Ngọc Hà", 1, "ANHTHI_MAI@YAHOO.COM", "ANHTHI_MAI@YAHOO.COM", "AQAAAAIAAYagAAAAEBMiZloPDxjHQ5lk53ZQi5AJBWJ9J+rjGcnfRDEEoIPkOs/hlLUbGeiyKILFcUuOAw==", "021 3053 4622", "ac387512-35da-4ea4-bb96-a2273cd7e025", "AnhThi_Mai@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "13418 Lâm Common", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20H%E1%BA%A1%20B%C4%83ng", "4d079867-4f4e-4009-a6c5-731b46a2c519", new DateTime(2001, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "KimDan73@yahoo.com", "Ngô Hạ Băng", 1, "KIMDAN73@YAHOO.COM", "KIMDAN73@YAHOO.COM", "AQAAAAIAAYagAAAAEHCpcuJtHXzpHevnXU5L+udZ8AmwBSVMfeuFhaaC4tJ+czmi/Vau3bTkEa18RjBgZA==", "0292 3452 6519", "1a0203d0-9f86-497f-9385-d3ad2700350d", "KimDan73@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6259 Trần Vista", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Vi%E1%BB%87t%20Qu%E1%BB%91c", "6ad46fed-a353-433b-a662-3dbbd1f47758", new DateTime(1998, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "DinhNgan_Ho@hotmail.com", "Lý Việt Quốc", 2, "DINHNGAN_HO@HOTMAIL.COM", "DINHNGAN_HO@HOTMAIL.COM", "AQAAAAIAAYagAAAAENLD3dp0vPp4M0QQQ1zx7BnTYdrkw5i31sqQDhsNHsLALQp305Ecxzl4zcuPcK9tpA==", "0242 4723 8642", "adcb9248-4249-4058-ae3a-37a3d35876ae", "DinhNgan_Ho@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "705 Kim Loan Isle", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Long%20Qu%C3%A2n", "aca57aed-e61b-4735-842a-7bbec795fe1b", new DateTime(2019, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "HoangHiep.Phung@gmail.com", "Tăng Long Quân", "HOANGHIEP.PHUNG@GMAIL.COM", "HOANGHIEP.PHUNG@GMAIL.COM", "AQAAAAIAAYagAAAAEFlw4x6FrzXUsnoiG1+NcFZdBtsm8DO2dSlvMsVOMkz67Z0gRwdLFB+9wvqR6S5H3g==", "025 2466 6541", "268d88c1-ea1a-4d23-a750-757d71200e05", "HoangHiep.Phung@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "75344 Tú Quyên Way", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20Hi%E1%BA%BFu%20H%E1%BA%A1nh", "635f4820-1274-457d-abe1-34424bb80723", new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "HongQuy_Ngo21@gmail.com", "Phan Hiếu Hạnh", "HONGQUY_NGO21@GMAIL.COM", "HONGQUY_NGO21@GMAIL.COM", "AQAAAAIAAYagAAAAEBZ19FiTTpIS5gQT1IUue7avHY0Q6GwBtIaat3y3x8ffMOQgRkE9vgiUOdr5sxMWpw==", "0285 6673 8977", "4669c59f-5b92-4ed8-9fcc-cc9621617050", "HongQuy_Ngo21@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4213 Bích Ngân Passage", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20S%C6%A1n%20Giang", "ac495805-95ac-4339-bbca-c8621c787127", new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), "HaiSon.Dao19@gmail.com", "Lê Sơn Giang", 2, "HAISON.DAO19@GMAIL.COM", "HAISON.DAO19@GMAIL.COM", "AQAAAAIAAYagAAAAEJV9zsnvkWv3WDqllBGWezFMvF9XL5gkH+UpnPSG4aK5JuaRq6U5FVoFAZmI7vdRLg==", "0279 2425 8531", "f9cefa2c-756a-4f6f-a11e-11033782a314", "HaiSon.Dao19@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "474 Gia Hân Shoals", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20%C3%81nh%20Linh", "662ffc99-6927-48bf-bf5a-84ed0bc99314", new DateTime(2012, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "ThucDinh2@hotmail.com", "Lý Ánh Linh", 3, "THUCDINH2@HOTMAIL.COM", "THUCDINH2@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKsib11afbAToCPyI/xsf0WAvICMUtliHp+ywxnUpt+7pIKKlBAAStGiSxm9+11Uag==", "0213 1951 0635", "1d8f3670-b777-4b1d-96d5-531b2ec0ec34", "ThucDinh2@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "83677 Quỳnh Dao Street", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Nh%C6%B0%20%C3%9D", "aa7d222d-211c-41af-bcc2-a98fa8f863b2", new DateTime(2017, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "YNhi_Dao@gmail.com", "Hà Như Ý", 2, "YNHI_DAO@GMAIL.COM", "YNHI_DAO@GMAIL.COM", "AQAAAAIAAYagAAAAEJz7rgr8dH6KpMa4E31MOd3AtVi3xT9u2tO/vesu5oC7DXrEijWX/2fAmnTvNXDbng==", "0228 0141 2329", "d8311f4f-5320-4801-b296-2edb3a92a49d", "YNhi_Dao@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "85209 Tố Nga Haven", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20D%C3%A3%20Lan", "659d9eba-a806-4599-bd24-3c8235a59451", new DateTime(2003, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "VyLan.Duong69@gmail.com", "Lâm Dã Lan", "VYLAN.DUONG69@GMAIL.COM", "VYLAN.DUONG69@GMAIL.COM", "AQAAAAIAAYagAAAAEOAnxFHFJADTIkvq/FsW3ArTJI3wn5QbgpnVxKgPGadPx0XMvqZ4H2mLTHqDQKvZkQ==", "026 7039 9498", "589a21bd-a677-441c-9e82-dab8443eed5f", "VyLan.Duong69@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0750 Ðức Thành Ranch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20L%E1%BB%87%20Thu", "70595fa6-b78d-48db-8043-290095c20d41", new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "AnhDuong9@yahoo.com", "Trịnh Lệ Thu", 1, "ANHDUONG9@YAHOO.COM", "ANHDUONG9@YAHOO.COM", "AQAAAAIAAYagAAAAEFlTOtiGxfovjqb4H9fdGe/nMBAZjpRfgnczXIzRwzsqk0YtAGIND8ha8uBLuePzIw==", "026 4594 0996", "b0fea022-55d0-4548-bc35-b59f26b3cc3a", "AnhDuong9@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "495 Nhật Nam Ports", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20H%C3%B2a%20L%E1%BA%A1c", "80a6a0a0-b544-42d1-95f9-305e88d7c039", new DateTime(2006, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "NhuHong.Ho61@hotmail.com", "Đặng Hòa Lạc", "NHUHONG.HO61@HOTMAIL.COM", "NHUHONG.HO61@HOTMAIL.COM", "AQAAAAIAAYagAAAAEH47hyT8WEx+OLUuA7GboPs3nyDTrcauisIvkJnoj90oGCN6jk4UkzYKcoWsCrvOkA==", "020 4323 7535", "ee2bb8d1-ecfb-4cae-a3aa-a301cf979b11", "NhuHong.Ho61@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "696 Thuận Phong Pines", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20H%C6%B0%C6%A1ng%20Mai", "61393809-5eda-4b5b-8138-1ba2aadeb201", new DateTime(1997, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "DiemThao.To@yahoo.com", "Hồ Hương Mai", 3, "DIEMTHAO.TO@YAHOO.COM", "DIEMTHAO.TO@YAHOO.COM", "AQAAAAIAAYagAAAAEPkerAKh4lNMYAR7q3PJwcBki3+ltK6OGrVx2cDQFg3QLS7NuUh3DVLbdTytJqiKuQ==", "028 3166 7644", "5e0787d2-c56a-4266-afa1-a79625770da0", "DiemThao.To@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "51149 Quốc Hòa Point", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Minh%20Kh%C3%B4i", "51ba8040-a1bd-44c7-a211-c9a6aaa0d4e7", new DateTime(2001, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), "NgocTho.Mai@gmail.com", "Phùng Minh Khôi", 1, "NGOCTHO.MAI@GMAIL.COM", "NGOCTHO.MAI@GMAIL.COM", "AQAAAAIAAYagAAAAEGdUBmQNe7LS5AA/uje9/IggSCljearzBw27L1Ty9F6NkSdJ6m73FUXw/AbS3GBoWQ==", "020 1285 7352", "7723444a-c6e5-43d5-a884-b461540456fb", "NgocTho.Mai@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6825 Gia Thịnh Inlet", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Th%C3%A0nh%20Trung", "4e8e0e3d-0b80-4a56-8737-94ec6ec06cbd", new DateTime(2005, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "DienVy76@hotmail.com", "Phùng Thành Trung", 3, "DIENVY76@HOTMAIL.COM", "DIENVY76@HOTMAIL.COM", "AQAAAAIAAYagAAAAEE3JnY1YNNTLKjznZCCjylCr5uV7caWuoM3OHx2ZPG7e4vR6tspx1+O97mVoZyCI1g==", "0282 9656 6810", "9d856b1d-e0da-4a44-8730-a7e630b88f2e", "DienVy76@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "96318 Huy Khiêm Walks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20C%C3%A1t%20C%C3%A1t", "9fc9f74b-359f-468a-b485-29de39ea8e6f", new DateTime(2009, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "AnhThai.Vuong49@yahoo.com", "Trần Cát Cát", "ANHTHAI.VUONG49@YAHOO.COM", "ANHTHAI.VUONG49@YAHOO.COM", "AQAAAAIAAYagAAAAEH1vmLNs73WtoHeojXZGPBFHWJ8Bp5GPucDpc90nOc26uCRfJL/lfigyUNsBZoFEyQ==", "0268 6735 3604", "cb031b53-f4cc-4638-856f-e690fca08c5f", "AnhThai.Vuong49@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4864 Đỗ Pines", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Ng%C3%A2n%20Thanh", "73aa1060-81b3-493d-8755-62183e58d01d", new DateTime(2007, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), "ChanhViet26@gmail.com", "Tô Ngân Thanh", 1, "CHANHVIET26@GMAIL.COM", "CHANHVIET26@GMAIL.COM", "AQAAAAIAAYagAAAAEEuYTpntWggGErIitpw83cePBufarJE6lHYLjdAIoWFV9W5tGkML8EYLq1RDc4IKag==", "027 7332 0260", "15b72d28-1b10-481d-a37f-f2b8a7b34fbc", "ChanhViet26@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8392 Đoàn Rest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20%C3%90%E1%BB%8Bnh%20L%E1%BB%B1c", "f737f67c-9075-4d95-92c3-185b1839d9db", new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "AiVan_Lam@hotmail.com", "Ngô Ðịnh Lực", "AIVAN_LAM@HOTMAIL.COM", "AIVAN_LAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGMGuhzUA+OFzxx5QY9TKlrYDT3t8PocSMkD0EGIjsaGkxJLEkkmDJsODevZmYNniQ==", "0291 7028 6145", "3589cfef-f406-4a5e-86de-c4e1ef68638b", "AiVan_Lam@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "33397 Lê Mall", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Xu%C3%A2n%20Thu", "22684b18-5cbe-4655-bbd2-8087b377bfce", new DateTime(2017, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "BaoToan_Nguyen@gmail.com", "Phùng Xuân Thu", 1, "BAOTOAN_NGUYEN@GMAIL.COM", "BAOTOAN_NGUYEN@GMAIL.COM", "AQAAAAIAAYagAAAAEB93X+JmbRrsoW1k1o7It7Uhlg23ukDN4P5HuFUXbcYeW1Qj5XTV5WlcG+g1+CUJaw==", "0275 9198 6353", "e637d2df-2edf-42de-afa9-6ab0784db5f6", "BaoToan_Nguyen@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "756 Gia Minh Mall", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20Gia%20H%C3%B2a", "c7bd9329-9b42-4e60-8ae0-b2eb3ef4dfbf", new DateTime(2004, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), "NamLoc.To21@hotmail.com", "Lâm Gia Hòa", 1, "NAMLOC.TO21@HOTMAIL.COM", "NAMLOC.TO21@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHZrEUxz11BKSD9nbxMjoG6DbyGLH7XSoylXqt51IyOgACwCvVApxTyOmjNi8ly/MQ==", "028 6027 9873", "fcc8e43a-dba0-4d6d-a2be-ad46c4c93daf", "NamLoc.To21@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "07095 Lê Walk", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20H%E1%BB%AFu%20To%C3%A0n", "16b5692d-047a-455c-bdb1-9db5c8f3eb3c", new DateTime(2001, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "ThanhVan56@hotmail.com", "Mai Hữu Toàn", 1, "THANHVAN56@HOTMAIL.COM", "THANHVAN56@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBOsYlkEWmsosf5sftr+wLM9tIJDJUSXWBD3HkVtrGBAUxUWpwgrUNa3eg7c3qXTJg==", "023 2566 5693", "99aa0134-527a-4b5b-b4ed-f415813099a8", "ThanhVan56@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7956 Trường Kỳ Summit", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Qu%E1%BB%91c%20B%C3%ACnh", "8eb33af3-35cb-492d-961a-8eed13f8e7c9", new DateTime(2009, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "KimPhu.Vuong28@gmail.com", "Hồ Quốc Bình", "KIMPHU.VUONG28@GMAIL.COM", "KIMPHU.VUONG28@GMAIL.COM", "AQAAAAIAAYagAAAAEOKOCGxnYHbChRp2/8Dff0HlwQNNLqUvb5PNoCd5FFrz7qLIsh7I8kXZuV+GA850Xg==", "025 0257 0118", "6131eff4-e3c5-4b45-91c5-b6abc8ed1845", "KimPhu.Vuong28@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "23184 Gia Khiêm Vista", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20%C3%90%C4%83ng%20Minh", "7e8af582-16c2-4784-9a10-e25a411b7336", new DateTime(2004, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "XuanLac_Ha18@yahoo.com", "Tăng Ðăng Minh", "XUANLAC_HA18@YAHOO.COM", "XUANLAC_HA18@YAHOO.COM", "AQAAAAIAAYagAAAAEO4fkafM74Py7FBkCRdqRgPodSjzO9ANu7I75PXnVXCoPxvSsRLUSUTvPv7AUzR9WA==", "023 4082 7821", "92c4a9ed-3087-4599-b9f8-5b309212e52e", "XuanLac_Ha18@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "90215 Thương Huyền Meadows", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Hi%E1%BA%BFu%20Li%C3%AAm", "bc124512-8d46-4e09-87eb-2db310b95b19", new DateTime(1999, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), "DiemHanh56@gmail.com", "Hoàng Hiếu Liêm", 1, "DIEMHANH56@GMAIL.COM", "DIEMHANH56@GMAIL.COM", "AQAAAAIAAYagAAAAEM3FZ3k7N1GBaA35skrMkiLvJfwRsnaxYrJprmchxa/kysAP6Lu7NcKlzqDKxXntcw==", "0255 9664 7100", "f30cafd4-4284-4b0e-b57d-f1bd9a34a688", "DiemHanh56@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "36441 Lâm Rest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Kim%20Loan", "c86a1b17-2f81-4156-a347-3f43520fda76", new DateTime(2005, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), "ThuHong31@hotmail.com", "Vương Kim Loan", "THUHONG31@HOTMAIL.COM", "THUHONG31@HOTMAIL.COM", "AQAAAAIAAYagAAAAEETVXw82H9hcYncnymG+ywk8/eBZvtzYevNqaEGE//9Mit6ySsLIOBYezc2VIXmH/g==", "0217 2928 4480", "8f084f90-0cd9-4818-a340-c3659e6061ac", "ThuHong31@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "50197 Lâm Run", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20H%C3%A0%20Giang", "e574a32c-e7e0-4458-afd9-c4a75e5e744e", new DateTime(2014, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "ManhDinh_Hoang@gmail.com", "Vương Hà Giang", "MANHDINH_HOANG@GMAIL.COM", "MANHDINH_HOANG@GMAIL.COM", "AQAAAAIAAYagAAAAEHRCt09V7p72eMveJC4JrgH3hraB74M1erp33jLFUM8I+2AKWvQg3LdvpSLit9NF+w==", "027 3816 8715", "f4703920-7fa4-4bf7-9d73-b26af9aa759b", "ManhDinh_Hoang@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1946 Phương Thùy Prairie", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Phi%20H%C3%B9ng", "d1734639-3253-435a-bc94-7d818cbb9049", new DateTime(2000, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "BaoAn_Tang97@yahoo.com", "Vương Phi Hùng", "BAOAN_TANG97@YAHOO.COM", "BAOAN_TANG97@YAHOO.COM", "AQAAAAIAAYagAAAAECCW0WAjUzGegkgzwbt27tKyz7ghlYMVJAo2yJXvTuhbVn1rukh6XCS9UJLQkyf91Q==", "020 0588 7920", "accc992e-3fbd-443c-88fe-034ce87525c7", "BaoAn_Tang97@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2482 Hồ Manor", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Kh%E1%BB%9Fi%20Phong", "0ae7de3b-2354-4fac-94df-28ddef3a4037", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "HuuTho.Doan36@hotmail.com", "Hà Khởi Phong", "HUUTHO.DOAN36@HOTMAIL.COM", "HUUTHO.DOAN36@HOTMAIL.COM", "AQAAAAIAAYagAAAAEN1pnTbfNwAcBpQ9fymGUVaic2z/h+GxvmM+oT5GET0AIOMf3lM5ni4nuUDyCMmk+g==", "025 5184 2186", "8f2b613d-e16c-4e18-90ff-2429e1064c83", "HuuTho.Doan36@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "433 Vũ Meadow", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20Th%C3%A1i%20H%E1%BB%93ng", "46de1074-a08e-47f8-aa09-9da797f25755", new DateTime(2022, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "QuangTrong.Doan@hotmail.com", "Nguyễn Thái Hồng", 3, "QUANGTRONG.DOAN@HOTMAIL.COM", "QUANGTRONG.DOAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFBebv3qDMlNS8ebLCbGYs+hTnKV6wr10HcOxkMOpnPCalzF40lVQlhyMtmfsUZC6Q==", "021 0342 6549", "f750cd06-d2b8-4263-b907-db0867d9b8dc", "QuangTrong.Doan@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "484 Mai Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20%C3%81nh%20Xu%C3%A2n", "91f04176-2849-46c2-975d-38b7c8a7b5e6", new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "KienBinh_Doan98@gmail.com", "Phạm Ánh Xuân", "KIENBINH_DOAN98@GMAIL.COM", "KIENBINH_DOAN98@GMAIL.COM", "AQAAAAIAAYagAAAAELp4fbk/pqdjImWgHX3/BeEFX5jUajwbUQXcl35/Z5VECrV7dJn3pShHB/RnkGQBZA==", "024 0504 0014", "cfba6515-f827-4b26-8431-a76b924ab7b3", "KienBinh_Doan98@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "916 Oanh Thơ Fords", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Kim%20Tuy%E1%BB%81n", "e54a29e6-9981-43db-a254-b5a53176bdfa", new DateTime(2020, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "KhanhHuy21@hotmail.com", "Đỗ Kim Tuyền", 2, "KHANHHUY21@HOTMAIL.COM", "KHANHHUY21@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMvyQi/T3onE5PO9qieFwKLhCifrZ0dGtfGOnx6GFgeYeEJWiG5moEjiHAK6XnOdXQ==", "023 7069 1545", "873865a9-113e-402a-acf1-6b409d239066", "KhanhHuy21@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2580 Minh Huy Causeway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Tr%E1%BB%8Dng%20Vinh", "1230a53f-d7fb-42f3-9cde-737ce69b9bfd", new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "HoangMy_Tran@gmail.com", "Tô Trọng Vinh", "HOANGMY_TRAN@GMAIL.COM", "HOANGMY_TRAN@GMAIL.COM", "AQAAAAIAAYagAAAAEC2fbOg9XTdwR4DNK7DKvQEK1vaf83p/GbkpIZb+yJUFL9Tl65LrwTIZ5wYnuQp31w==", "024 0329 0608", "8f3bf570-4c6a-4889-840b-55663d889bb8", "HoangMy_Tran@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2272 Vũ Ridge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Qu%E1%BB%91c%20Th%C3%A0nh", "b3b6adca-3775-48df-8d3f-ae4fc1992191", new DateTime(2017, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "QuocBao_Truong67@yahoo.com", "Đỗ Quốc Thành", 1, "QUOCBAO_TRUONG67@YAHOO.COM", "QUOCBAO_TRUONG67@YAHOO.COM", "AQAAAAIAAYagAAAAEEh/3+9RnBrYGBRmhjiLs5yyuWp20+sWMPxg2ghPK8gxIJ7S5hWUu88+pE1vDMhJOA==", "024 1954 8597", "1e4b98db-3911-45c1-bc37-abea8b3fa028", "QuocBao_Truong67@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "18331 Hạc Cúc Burgs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20Di%E1%BB%85m%20Th%C3%BAy", "10e5f534-98ac-45e1-8350-a53fdff5005b", new DateTime(1998, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "ThuyKhanh48@gmail.com", "Đoàn Diễm Thúy", 1, "THUYKHANH48@GMAIL.COM", "THUYKHANH48@GMAIL.COM", "AQAAAAIAAYagAAAAEBreOCLqusIurGpoiA2Bj9n4n3zaDR2GiBarNLtAfJRhlhjh3fTFnEYwGC3L87wPBQ==", "0247 0364 1582", "656dd601-58f1-4cee-be1d-40f75122c5fa", "ThuyKhanh48@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4181 Đặng Bridge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Qu%E1%BB%91c%20%C3%90i%E1%BB%81n", "f96acae6-941f-412e-907f-cfa357fda27b", new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "BachKim_Vuong91@hotmail.com", "Hà Quốc Ðiền", "BACHKIM_VUONG91@HOTMAIL.COM", "BACHKIM_VUONG91@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMKfEIsWuNat3lw7Nm00ecM7iAntRCIlN8AD0Op2gVbl6nqsV4H3xYOqezpwxg8Gcg==", "0231 9790 6519", "7106fdb9-cf0e-4f9e-836e-ed4d34205256", "BachKim_Vuong91@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "201 Vương Valley", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Ph%C3%BA%20%C3%82n", "1471adf2-6798-43ac-b15d-3c4e1f6de9ba", new DateTime(2017, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), "TinhYen_Do@hotmail.com", "Dương Phú Ân", 3, "TINHYEN_DO@HOTMAIL.COM", "TINHYEN_DO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEmWZwZ0Qiy77PUgT3fYYHdvHmGD9bOr3I1rde1LO++6pcEHjBvRs+TQhujiWjDOIg==", "027 3780 1185", "97698eb1-fb9b-4f55-8cea-33b3f0098539", "TinhYen_Do@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "10339 Ngọc Trụ Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Vi%E1%BB%85n%20%C3%90%C3%B4ng", "d40739e5-2823-452b-9839-5ba6630b0e7f", new DateTime(2005, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), "KieuDiem_Pham@yahoo.com", "Lê Viễn Ðông", 3, "KIEUDIEM_PHAM@YAHOO.COM", "KIEUDIEM_PHAM@YAHOO.COM", "AQAAAAIAAYagAAAAEM829y37NMe8+2u4oD5I/FT7GJ86ukwgvvA/O7jBA+L3oLS0DRqRQFG0Lt83RIwlCQ==", "020 5968 6531", "dd1fec2d-356d-4405-a583-bd125166e4ee", "KieuDiem_Pham@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1426 Bảo Châu Field", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Th%E1%BB%A5c%20T%C3%A2m", "0bd2a069-7f2e-428f-9b12-1305cd0e3b1c", new DateTime(2009, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), "QuangLan_Dinh81@gmail.com", "Vương Thục Tâm", 2, "QUANGLAN_DINH81@GMAIL.COM", "QUANGLAN_DINH81@GMAIL.COM", "AQAAAAIAAYagAAAAEKHUdjTG7PzYbs9Y5mlOHVMNK7AGoYAyYmFbGYTUXkwpjdN2CIZ6B8W87yxFv7ACPw==", "0290 7147 3510", "6ae49646-79fa-4296-a7f4-c90eb9b58b4b", "QuangLan_Dinh81@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8636 Vương River", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C5%A9%20Ho%C3%A0n%20Ki%E1%BA%BFm", "ecbbf0c8-a5ea-4b14-9275-3b323dd4bce6", new DateTime(1999, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "QuangBuu_Le87@gmail.com", "Vũ Hoàn Kiếm", 3, "QUANGBUU_LE87@GMAIL.COM", "QUANGBUU_LE87@GMAIL.COM", "AQAAAAIAAYagAAAAEB2QmDDyMOBXSl3rLaP4u0bf6d3yKqxVzN5NG2TNAeQ2mni9nJAlpl/k3D9UWdqPHw==", "020 9955 9821", "5a9d87e6-580b-4d74-b35b-6349b34dec9e", "QuangBuu_Le87@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5602 Đỗ Harbor", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Th%C3%A1i%20Minh", "e36ebb9b-57a2-4389-a616-da339cc5e823", new DateTime(2007, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "QuocTrung43@hotmail.com", "Hồ Thái Minh", 1, "QUOCTRUNG43@HOTMAIL.COM", "QUOCTRUNG43@HOTMAIL.COM", "AQAAAAIAAYagAAAAEN/3K+la0+13eLDO0RbaywVG3TmLMRciA09uPD8RN1IaUC5A0nn/OLt0cMVpD9mSMQ==", "0242 4069 5354", "92a56c82-1b19-4053-9a7a-2f7518f596d5", "QuocTrung43@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "53612 Mai Drives", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Ch%C3%AD%20B%E1%BA%A3o", "9348e11b-7a02-4679-9a14-f70e5e39c4d6", new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "UyenMy63@yahoo.com", "Bùi Chí Bảo", 2, "UYENMY63@YAHOO.COM", "UYENMY63@YAHOO.COM", "AQAAAAIAAYagAAAAEEpQOJWJedAGs42FhAXq9etCYQjDpA80FgS1HU4lrXnu/UP33p6mUTdLEZf+eFudRg==", "0206 3973 4016", "14d0a0a0-1d60-40e6-ba1c-2fb07dbd8c90", "UyenMy63@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "151 Khánh Hòa Meadows", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Th%C6%B0%C6%A1ng%20Nga", "7ccb4baf-cadd-4662-bf88-608f6ded68bb", new DateTime(2000, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), "ThienHung.Truong@gmail.com", "Trịnh Thương Nga", "THIENHUNG.TRUONG@GMAIL.COM", "THIENHUNG.TRUONG@GMAIL.COM", "AQAAAAIAAYagAAAAELYgQ2ndWWgbrFaYK3m0jqFSWPaeT+9FWM+IUpA7Poh2Yl4UWLQ9XzGzQE5jhjJI2g==", "023 4146 9330", "342f892a-f4d6-4321-b316-2cbddfaa2644", "ThienHung.Truong@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1463 Đoàn Meadow", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20B%E1%BA%A3o%20Tr%C3%A2n", "f26c2bcb-7952-4429-8a67-8310cac2e9af", new DateTime(2009, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "PhuongPhi.Ngo@yahoo.com", "Lý Bảo Trân", 2, "PHUONGPHI.NGO@YAHOO.COM", "PHUONGPHI.NGO@YAHOO.COM", "AQAAAAIAAYagAAAAEGAOnA3ha3odnibZ+NetqtTiTBjqlhGvTObsik5a6IMNAKojOMvoz3fJZwrC7cc7Lg==", "0252 2382 3564", "6af0175c-ae9e-45fd-a091-40d7ffee4fa6", "PhuongPhi.Ngo@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7379 Đặng Cliff", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Tr%C3%BAc%20Mai", "acdf61b1-cfcd-40b3-8113-4930e6be9a05", new DateTime(2017, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "ThuyMai_Vu82@gmail.com", "Lê Trúc Mai", 1, "THUYMAI_VU82@GMAIL.COM", "THUYMAI_VU82@GMAIL.COM", "AQAAAAIAAYagAAAAENkOCyCgxcTpwQAGa5cLFkjojhT03vmt32n1R8IB9kg9XxSJHAbT26TYZJtO9LVWyA==", "0216 9115 4613", "948b9c3f-9a99-4629-8f2d-b4e2fcbb9608", "ThuyMai_Vu82@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5750 Diễm Trang Crossing", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20H%E1%BB%93ng%20%C3%90%C4%83ng", "70ef722a-b765-4372-89c5-e75e0b3b8025", new DateTime(2012, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), "HuongXuan31@gmail.com", "Ngô Hồng Ðăng", "HUONGXUAN31@GMAIL.COM", "HUONGXUAN31@GMAIL.COM", "AQAAAAIAAYagAAAAEIFyFdW/z+sHJnTPe3qRFGs/kbGcSUZ7VHSGcBUU8SAg/vpHhHNs7R73AQVePZJBfg==", "026 5636 2785", "a0c6d143-e1ad-4ea6-9fd7-8c84a8c076b6", "HuongXuan31@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7687 Trần Drive", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Thanh%20H%C3%A0o", "2f6a718b-688e-4452-b263-6d0b9c035a5f", new DateTime(2018, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "TuongVy_Nguyen@gmail.com", "Hồ Thanh Hào", 3, "TUONGVY_NGUYEN@GMAIL.COM", "TUONGVY_NGUYEN@GMAIL.COM", "AQAAAAIAAYagAAAAEIdjNe4t4WH3tELp1dT+XoTGkIlBx/De7daMnuJPo6YFrk9DHivccBvyFthu1IxCVQ==", "0221 3112 5135", "448f0f4f-4adf-4fac-877d-fc836d508b67", "TuongVy_Nguyen@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "699 Quang Triều Forges", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Th%C3%BAy%20Hi%E1%BB%81n", "1f2bc998-5d45-4ade-bf4c-1f14689726da", new DateTime(2000, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "VietThanh.Phung75@hotmail.com", "Ngô Thúy Hiền", 3, "VIETTHANH.PHUNG75@HOTMAIL.COM", "VIETTHANH.PHUNG75@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMVornS62cohB/dV3bW/+i6JPRO2NHv9UCzaGpq38AiFlQDVswTldgF7P6h7KUwePw==", "0210 3461 2620", "ec571bbe-afb8-4b32-96ed-f08d2e04a9fc", "VietThanh.Phung75@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "316 Phú Thọ Mountains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20An%20C%C6%A1", "052199de-cf4a-409e-ac52-2116cb3e8dd8", new DateTime(2014, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "BaoLong_Phan@gmail.com", "Trịnh An Cơ", 1, "BAOLONG_PHAN@GMAIL.COM", "BAOLONG_PHAN@GMAIL.COM", "AQAAAAIAAYagAAAAEODhhC7TnF1ABvzFxFnN4DCSf2RpN8lr+qJCZqJG7BbZbAamKixSqkGCIcGxfJEe2Q==", "022 4584 6652", "eba00214-4547-424c-8a94-971e2c088ba7", "BaoLong_Phan@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "750 Hạnh Nhơn Burgs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Gia%20Ngh%E1%BB%8B", "a644c8a0-0966-40dc-acef-a789115a7911", new DateTime(2015, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "HuuLuong90@gmail.com", "Đỗ Gia Nghị", 2, "HUULUONG90@GMAIL.COM", "HUULUONG90@GMAIL.COM", "AQAAAAIAAYagAAAAEHDSO3zlmR3btn9QBpb/MKH8J08JGL3jK+HQlGbjPKgrfddQ5hpXOlx1UmJS359dEA==", "0267 0312 3802", "c2bb8bcd-d405-49a0-988a-457f829a8c58", "HuuLuong90@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "69214 Trương Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20B%E1%BA%A3o%20V%C3%A2n", "16d1c5fe-4dc7-4191-bae9-3634fa121c52", new DateTime(2014, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "MinhKhang23@hotmail.com", "Tô Bảo Vân", 3, "MINHKHANG23@HOTMAIL.COM", "MINHKHANG23@HOTMAIL.COM", "AQAAAAIAAYagAAAAEASkvc75L7doqb3qLFTREHzTG5SVhkbGGxyo9fJw3Z5mCERKq7YJnzGpsaQ1Zbkx9w==", "026 7497 5395", "546a129d-a66c-4fbf-99c8-ed23e231a9d2", "MinhKhang23@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4440 Dương Rapids", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20C%C3%B4ng%20Hi%E1%BA%BFu", "02a93142-549a-4ec5-8c99-112523fa088b", new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), "PhuongTrieu.Hoang@hotmail.com", "Hồ Công Hiếu", 3, "PHUONGTRIEU.HOANG@HOTMAIL.COM", "PHUONGTRIEU.HOANG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHAHR9DHonQT9HsA8wwJgH5lBSwbUSNZPZX/xRiovxFdInLiHCxdEH6KNUHQrjrGBg==", "029 4781 8697", "934391aa-19c3-4fbb-bd14-99255a56060b", "PhuongTrieu.Hoang@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "35956 Trịnh Station", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20%C4%90oan%20Trang", "d5df512d-96de-4cf5-962d-9b8e4ac5cb7d", new DateTime(2009, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "ChinhTam.Le91@yahoo.com", "Đỗ Đoan Trang", 1, "CHINHTAM.LE91@YAHOO.COM", "CHINHTAM.LE91@YAHOO.COM", "AQAAAAIAAYagAAAAEEAep4nicKxZaNEx2oGAjrDSMMiOafv6l+29B94SGtFoizxuZnf/Cn/XvLhQX/nAjw==", "0291 4998 3034", "5e269593-8fe2-4fea-88af-53d59de89545", "ChinhTam.Le91@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5270 Nam Lộc Neck", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Th%E1%BA%A3o%20H%E1%BB%93ng", "39f5ae74-f2c5-4253-9fc2-c35de925ec93", new DateTime(2006, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "ThieuBao.Do76@hotmail.com", "Lý Thảo Hồng", "THIEUBAO.DO76@HOTMAIL.COM", "THIEUBAO.DO76@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBKrmDygqXMY0Q0Lr5wHGnOrK+7j7Zh4WURRvwWaIOxSCOVfP8M48/2VyzgjF7221g==", "022 5143 4226", "3d140e16-fd4e-413f-8b1c-f55e7370d947", "ThieuBao.Do76@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "03925 Vũ Crossroad", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Nguy%C3%AAn%20Phong", "119b1dc9-d0fc-42c3-8781-57441ba6c6c5", new DateTime(1996, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "MinhDan.Vu@gmail.com", "Phùng Nguyên Phong", 1, "MINHDAN.VU@GMAIL.COM", "MINHDAN.VU@GMAIL.COM", "AQAAAAIAAYagAAAAEAeYk7KnjZA+elfg8OcAIoePLHi8sTLd3FTqZTbRBPiwJ9vO/s45/Lohcc/QySFZNg==", "020 2726 9770", "b9feceb3-13f3-42dd-a69e-84cd447798f5", "MinhDan.Vu@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "17802 Dương Inlet", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20H%E1%BA%A3i%20Qu%C3%A2n", "74839b90-e4f1-48b5-97c1-046c3e5a9a25", new DateTime(2004, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "HoangSa_Tang@hotmail.com", "Đặng Hải Quân", "HOANGSA_TANG@HOTMAIL.COM", "HOANGSA_TANG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEP9msPGLPD1bQdPGy7PgOmW4OD4cv7aXGbmVhmrCEbD8V5o3wS1HEV0uyhV83vSeCQ==", "0265 7890 6683", "403f87d7-8ddd-481a-98bb-d3a7db37856e", "HoangSa_Tang@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "62705 Đặng Via", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20%C4%90%C3%B4ng%20Nghi", "d5d00a21-b719-462d-8508-f0ba619ca39a", new DateTime(2002, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "PhuongGiang13@hotmail.com", "Đinh Đông Nghi", "PHUONGGIANG13@HOTMAIL.COM", "PHUONGGIANG13@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKPHFu9OMDh8QOVYSYw2ziLEMePtEIlR2FJMDZzUuueqg5TyMqYzdIFXsHHlYn8d6w==", "0252 1964 7152", "7d1ae656-3bae-4b55-9fa7-e87ef7fe94c7", "PhuongGiang13@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "03368 Bích Hậu River", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Nguy%C3%AAn%20Th%E1%BA%A3o", "5d8f9b6d-6399-4219-95d8-b9d28ebdd8e8", new DateTime(1999, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "HueMy.Ho91@yahoo.com", "Lê Nguyên Thảo", 3, "HUEMY.HO91@YAHOO.COM", "HUEMY.HO91@YAHOO.COM", "AQAAAAIAAYagAAAAEN6vZNw9PN/whP10MoLATW9vz+w5h2fjQPiKnPbWQlU5LpfGj1aRuLQfy0aK+jkSJg==", "0254 5803 3573", "ab71f17f-747d-4c58-828e-adc0645d67ba", "HueMy.Ho91@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5366 Phúc Hòa Street", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Ph%C3%BAc%20Duy", "68f91672-ef0c-4541-a67b-8f2a522e8849", new DateTime(2013, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "KimNgan18@gmail.com", "Trương Phúc Duy", 3, "KIMNGAN18@GMAIL.COM", "KIMNGAN18@GMAIL.COM", "AQAAAAIAAYagAAAAEIIDS0eyPRgUT5lOVygM7AQ9X9jlIqEGahqk2yhTSQqlemQoI1y8gYTBafnVrpt68w==", "0244 6501 6054", "176e98c0-1ed3-4853-a7b4-94cc7ebc0047", "KimNgan18@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3484 Trịnh Place", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Nam%20Ph%C6%B0%C6%A1ng", "81cd8c84-82dc-4293-8fb6-6f3df1fb1d3d", new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), "MinhGiang.Lam3@hotmail.com", "Lý Nam Phương", 1, "MINHGIANG.LAM3@HOTMAIL.COM", "MINHGIANG.LAM3@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFgFtNMg5GmtPZi5Cs5kaqTjJs+w13NhJsYKgsi9uVWYdVz4ZCER2rJo4bj1Wpr9xQ==", "0245 8695 5390", "74aed26e-da09-447e-b444-f69aa1ba2e6d", "MinhGiang.Lam3@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "035 Đoàn Branch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20C%C6%B0%E1%BB%9Dng%20D%C5%A9ng", "f72d1190-4c49-4da2-9c5d-5bdbc3a41e36", new DateTime(2000, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "MinhVu.Dinh@gmail.com", "Phạm Cường Dũng", 2, "MINHVU.DINH@GMAIL.COM", "MINHVU.DINH@GMAIL.COM", "AQAAAAIAAYagAAAAENEe4Mo71uyScxy0Hm/I7BOFJpLeqi4OlrxvMh2vbDOFFBQR+EYjOSEsewAHxVPh6w==", "0293 5821 6989", "fe1a4cff-0ecb-406d-bd0e-36622e80baea", "MinhVu.Dinh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "34288 Quang Dũng Valleys", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Th%E1%BB%A5y%20Linh", "8db7ca8d-6565-49be-8096-4b4d008dd4a8", new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "YenAnh.Lam@gmail.com", "Ngô Thụy Linh", "YENANH.LAM@GMAIL.COM", "YENANH.LAM@GMAIL.COM", "AQAAAAIAAYagAAAAEDXdbllbl17pRZEcRACwmaR8NKpYdr0MDUv3SqeLizUyczz5mCLHUzqfASMAI1Tifg==", "0265 3247 6919", "a23dbf80-5b3a-4546-8182-62e0db18af05", "YenAnh.Lam@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5454 Đinh Light", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20Tr%C6%B0%E1%BB%9Dng%20S%C6%A1n", "8f8d52b1-8419-45f8-876c-93eecdb39745", new DateTime(2002, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "LanVy_Vuong16@hotmail.com", "Trần Trường Sơn", "LANVY_VUONG16@HOTMAIL.COM", "LANVY_VUONG16@HOTMAIL.COM", "AQAAAAIAAYagAAAAEK3IZ5QH3RMdh8laNWRn8VK7NlQlbXjRjZl32GfSXSE0tKTm6Vxw4k05zty71JmtyA==", "020 8626 2853", "40a6e8d4-da94-4d7a-b145-9965e034a880", "LanVy_Vuong16@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2551 Cao Nguyên Walk", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20B%C3%A1%20K%E1%BB%B3", "5190d55c-03ef-49e2-99ed-918e42e05250", new DateTime(2019, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "ThanhHoa_Ngo62@yahoo.com", "Dương Bá Kỳ", "THANHHOA_NGO62@YAHOO.COM", "THANHHOA_NGO62@YAHOO.COM", "AQAAAAIAAYagAAAAEM/fynN+PPzQ9AuOMkcO0RC59Ei2HPpt5h+E7FqvcZoA3cPBIz/0pNbl0uVRi4FFvw==", "028 5881 9396", "80a99936-6af9-41bd-abc4-ec2b43b525f9", "ThanhHoa_Ngo62@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "224 Tô Cape", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Ph%C3%BA%20B%C3%ACnh", "6e2b9937-43f1-45b6-8ae8-ca855765aff1", new DateTime(2000, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "BaoLong12@hotmail.com", "Tăng Phú Bình", "BAOLONG12@HOTMAIL.COM", "BAOLONG12@HOTMAIL.COM", "AQAAAAIAAYagAAAAEOGcbRJr0FYFrRRB5d8/BJlleSgBuiZE18xMqDHbwnVYOTQDAyfQ+YEsl2Yy0hAmTA==", "021 9399 4042", "4c0d9720-f44f-4405-8819-265f2cccd239", "BaoLong12@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2862 Đinh Village", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Ki%C3%AAn%20B%C3%ACnh", "277c654d-e04e-428f-9fee-35a1324b1a74", new DateTime(2000, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "DongNguyen_Trinh@hotmail.com", "Ngô Kiên Bình", 2, "DONGNGUYEN_TRINH@HOTMAIL.COM", "DONGNGUYEN_TRINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFdsfnfKL3X4yIrCJ29heGXaXpAs4Whc0Djh08DQrAeIXWPoXHRapr5r4CKVyIInOQ==", "0215 5370 0237", "37e66713-9db1-423a-8753-5b3f457582cb", "DongNguyen_Trinh@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9444 Đoàn Gateway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Thanh%20T%C3%BA", "4b6a2d6e-1ae4-4b82-bdad-223df5af84d2", new DateTime(2002, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "HiepDinh48@hotmail.com", "Đặng Thanh Tú", 3, "HIEPDINH48@HOTMAIL.COM", "HIEPDINH48@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJpIhIQ463f6oDD8B2jMqsUeHsGdtvR+hArxSJLstGVFxenLncs/320lpmWMzJi6iQ==", "0233 3824 5000", "d2d7b446-698c-471b-8fe1-ec802c18b067", "HiepDinh48@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7861 Hải Duyên Ports", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20Thanh%20Xu%C3%A2n", "a6578c2d-4c07-4b6a-8658-5a1296cc7f41", new DateTime(2013, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "BinhThuan38@yahoo.com", "Phan Thanh Xuân", "BINHTHUAN38@YAHOO.COM", "BINHTHUAN38@YAHOO.COM", "AQAAAAIAAYagAAAAEF11fPZ5GSFIhjr8Wo0ZB35mVMYUwTM7FS6MK2JaS27a/LQhZIR20/Enh6JtajZJEw==", "0205 8995 7576", "039cb48a-17fb-4e9d-a583-309c5b0909f9", "BinhThuan38@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "24759 Vương Ways", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20V%C5%A9%20Anh", "45ce760d-c7e1-49eb-a4ed-25646497e8b8", new DateTime(2017, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "HoangViet.Dao82@yahoo.com", "Ngô Vũ Anh", 2, "HOANGVIET.DAO82@YAHOO.COM", "HOANGVIET.DAO82@YAHOO.COM", "AQAAAAIAAYagAAAAEPTcLgJ1X2Y3ofhyE1TPR9pWXKa/uN2G8/1b5E0+lFVPwk54GBiAi6C9JCS2aaXeIw==", "021 8522 1653", "e6162827-4017-4b08-a462-c37cf936537f", "HoangViet.Dao82@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "94730 Lâm Inlet", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20%C4%90%E1%BB%A9c%20H%C3%B2a", "e5f6973e-6ed2-48a7-ac1c-79330deaa280", new DateTime(2016, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), "KieuAnh_To9@yahoo.com", "Phan Đức Hòa", "KIEUANH_TO9@YAHOO.COM", "KIEUANH_TO9@YAHOO.COM", "AQAAAAIAAYagAAAAENYZIdWyusvOqQB8/oGwIouqKlogiRaEjV69Yto3EOf4GmSYRNXZopeizagMaW2RNw==", "0253 7894 9135", "5ed4f61e-c56d-42b1-ae94-176760a0411d", "KieuAnh_To9@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9420 Huệ An Lake", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20T%C3%BA%20T%C3%A2m", "052e3668-2393-4b6f-9af4-55c316de8042", new DateTime(2017, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "QuangHuy25@yahoo.com", "Dương Tú Tâm", 1, "QUANGHUY25@YAHOO.COM", "QUANGHUY25@YAHOO.COM", "AQAAAAIAAYagAAAAEEKNsoKYZE8sGtPVq4EeSsfQdrRzlBQUAP6QsDtEwqLgxl4h9cqQPcLOt8jQGvUCdA==", "0270 3837 8173", "0426c332-09a9-4604-a9d0-1fdca09d62dd", "QuangHuy25@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "014 Linh Giang Stream", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Giao%20Ki%E1%BB%81u", "360a6c78-0d48-43ca-acc4-a0afee422cec", new DateTime(1998, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), "PhiHai.Dinh@hotmail.com", "Phùng Giao Kiều", 2, "PHIHAI.DINH@HOTMAIL.COM", "PHIHAI.DINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMNmp+TX8QfMk1ZOxKZ1utYJSwLa5kwiq3Jz1VDRULmMJAKzqg1jai3UXpKwf/Qz4A==", "023 2290 8730", "5d633d1a-f4bc-4eb5-95b5-7d595ae1868c", "PhiHai.Dinh@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "80448 Đào Brooks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Thanh%20H%C3%A0", "f60513dd-54c6-4149-b932-2091073f6d9c", new DateTime(2014, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "XuanNghi_Dao84@hotmail.com", "Hồ Thanh Hà", 1, "XUANNGHI_DAO84@HOTMAIL.COM", "XUANNGHI_DAO84@HOTMAIL.COM", "AQAAAAIAAYagAAAAECerfQ+9fgXMoXSijmM2cgT4zWAWC8XmGvz34XXhuCRDLOUtFHxPZvZ5aoxGXy75nQ==", "026 2438 7051", "4c0e2483-09ef-46c2-ba1b-962340bdb247", "XuanNghi_Dao84@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1882 Duy Tân Springs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20H%E1%BB%93ng%20L%C4%A9nh", "6345925c-6aa4-421b-9788-073f4d029753", new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "CamTu40@hotmail.com", "Mai Hồng Lĩnh", 2, "CAMTU40@HOTMAIL.COM", "CAMTU40@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDENbQ+3zqItoWHeeNsZf+8p+oi+OsAqzkcDTefM2x+hCNZYaNdQsPe1pdzP5SFt/g==", "0287 5967 6204", "10b7d46c-1647-4ba8-b339-cd3c070ea947", "CamTu40@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "597 Phan Road", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Minh%20M%E1%BA%ABn", "dfde1a03-44f6-48e2-994c-00e02b99a290", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "HoaiNam3@gmail.com", "Hà Minh Mẫn", 2, "HOAINAM3@GMAIL.COM", "HOAINAM3@GMAIL.COM", "AQAAAAIAAYagAAAAEPxfxIoMqtx7Qy1m85gH1qB30kOQQw8M9aSJZDj2Qk6vtSid00yVPTAR1FVdu7Bqng==", "0263 4259 5489", "62647b5f-498b-41d6-905c-6d62cf32e139", "HoaiNam3@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "863 Hoàng Drive", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Tu%E1%BA%A5n%20Kh%E1%BA%A3i", "e8c0caec-0f1c-4ff8-82e4-5365e9f80812", new DateTime(2016, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), "ChiGiang58@yahoo.com", "Hồ Tuấn Khải", 3, "CHIGIANG58@YAHOO.COM", "CHIGIANG58@YAHOO.COM", "AQAAAAIAAYagAAAAEL/vHOBKCl4XxWAE36LCVwAESqIqfI06sGM8ymfS+hzQVtywH+lsQ53mH5cI3IfWRw==", "020 7961 6336", "39ebadae-97a6-4f86-9e9c-ffb7e9487216", "ChiGiang58@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "994 Đào Tunnel", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20H%E1%BB%93ng%20Anh", "5c2ab1da-a111-4197-a2da-630f9f400c81", new DateTime(1995, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "LocUyen_To16@gmail.com", "Vương Hồng Anh", 3, "LOCUYEN_TO16@GMAIL.COM", "LOCUYEN_TO16@GMAIL.COM", "AQAAAAIAAYagAAAAEPTgwB4fjsr9ryArpz/LulpHFXFB84oadDWDj9ZTjKdbE+TrPwKUiX0afv9h6SkzYA==", "024 7106 5695", "a6ec9db6-88d9-47b5-b30d-a496b1b12eca", "LocUyen_To16@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "909 Hồng Thắm Bypass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Kh%C3%A1nh%20Th%E1%BB%A7y", "6a36cab0-c8b0-449d-90fc-5c41fa63ad16", new DateTime(2003, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "MaiLan_To@hotmail.com", "Hà Khánh Thủy", "MAILAN_TO@HOTMAIL.COM", "MAILAN_TO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFiobNnAviN/a/IQKsEl1Cov2IepSm4kZeOThTH4WSquBFIUeHl6K713eH7VOQ4EYg==", "0252 8966 4353", "a44f1fc0-3a1e-4c66-94fc-f81406b1b46d", "MaiLan_To@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1534 Tô Divide", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20T%C3%BA%20Anh", "6258f98c-073e-4f3c-91ce-29426859943f", new DateTime(2011, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "TuanTrung20@yahoo.com", "Đào Tú Anh", 1, "TUANTRUNG20@YAHOO.COM", "TUANTRUNG20@YAHOO.COM", "AQAAAAIAAYagAAAAEHQLw1t9N6ASD7OOt9BkO4eobyDRPxKCvcLEJjPau9TI9ebkn5nHdz6LcBgdP/asfA==", "028 8038 9518", "c31cc269-ac49-470e-af4d-1376cdc689e4", "TuanTrung20@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1805 Ngô Heights", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Nh%C6%B0%20Tr%C3%A2n", "a10fdb89-a86c-4c34-b66c-ecf57b381739", new DateTime(1996, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "NgocLy.Truong@hotmail.com", "Phạm Như Trân", 1, "NGOCLY.TRUONG@HOTMAIL.COM", "NGOCLY.TRUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBEVpH3pDBfos88J4NFhpeSA5pNGBsfE32BYByT/wd/gIDLB+IIKBnivk+2ODZu+iQ==", "026 1529 6202", "83af899e-3b82-464f-8334-58268d029081", "NgocLy.Truong@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "077 Quang Huy Overpass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Nh%E1%BA%ADt%20Quang", "02c96486-62d3-4799-970e-d32cb3ccabe6", new DateTime(2005, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "YenSon.Duong@gmail.com", "Đỗ Nhật Quang", "YENSON.DUONG@GMAIL.COM", "YENSON.DUONG@GMAIL.COM", "AQAAAAIAAYagAAAAEBVMarUau3GjTfadunwKVtVoUzIB8Ek8UyUruygcRPdVnQDF5EF45LhhJlMnOUqAAg==", "0291 4652 5906", "d878a044-911e-4e3c-afab-bfe7e02a0bbe", "YenSon.Duong@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "26351 Trần Hollow", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Anh%20Khoa", "8b7ac6ed-e798-4516-9540-8dcf9a52ef01", new DateTime(1995, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "KimVuong_Vuong@yahoo.com", "Hà Anh Khoa", 3, "KIMVUONG_VUONG@YAHOO.COM", "KIMVUONG_VUONG@YAHOO.COM", "AQAAAAIAAYagAAAAEH90zsY8UkwqJqpoiaX9XZnRcXXCzBMCaptSQFqDrGBF7Lp+PeDylqEAGwhOgEMMtw==", "024 5290 7257", "e1a92f34-b8d6-4107-b7eb-b0e1d33e0371", "KimVuong_Vuong@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "36620 Trương Coves", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Minh%20%C3%82n", "d57996cc-28c2-4161-b415-36651b17cc30", new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "DuyHung78@hotmail.com", "Hà Minh Ân", "DUYHUNG78@HOTMAIL.COM", "DUYHUNG78@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPt9TYUaJQ+kVBqh7v8AxCjWj8qTlDsqaUktnESvmDbzmEHHL2d1R9l858gTIP+Z/g==", "0206 1902 2354", "1e2bc683-e7f5-4736-8089-d8d58fc939e4", "DuyHung78@hotmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "AverageRating",
                table: "Doctors",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), "Ipsum excepturi dolores ex dolor optio ea.", 81, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 16, 0, 0, 0), "Autem ut delectus.", 50, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), "Totam ipsa doloremque nobis sed nihil.", 61, new TimeSpan(0, 9, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, "Maxime itaque sunt earum.", 91, 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 9, 0, 0, 0), "Excepturi illo dolore tempora blanditiis enim facilis.", 24, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 19, "Voluptatum quaerat est veniam perferendis architecto voluptas.", 27, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), 18, "Eligendi ut et aut aut sed asperiores amet qui molestiae.", 1, 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 17, 0, 0, 0), "Ratione itaque accusantium autem cupiditate impedit error pariatur nulla.", 12, new TimeSpan(0, 16, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), 16, "Quaerat animi dolorum ipsam cupiditate sit quam hic minus.", 93, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 0, 0, 0), "Veniam praesentium et aliquid aut saepe.", 48, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 3, "Nihil in dolore tenetur quisquam omnis ad.", 24, 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), 1, "Dolorem tempora fugiat sed et esse assumenda provident voluptatem vero.", 28, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Quaerat at nihil odio facilis quas omnis.", 19, new TimeSpan(0, 11, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 0, 0, 0), "Veniam aspernatur facere ab.", 60, new TimeSpan(0, 9, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 14, 0, 0, 0), "Distinctio recusandae omnis reprehenderit id maiores.", 91, new TimeSpan(0, 13, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Odio pariatur soluta perferendis consequatur.", 44, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 13, 0, 0, 0), "Magni quia modi aperiam ipsam dicta accusamus.", 91, new TimeSpan(0, 12, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 5, "Porro qui voluptatem natus quis.", 48, 2 });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), "Autem cumque facilis et aperiam autem minus rem libero accusamus.", 4, new TimeSpan(0, 16, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), "Nemo odit laboriosam odio provident quo dolor ut.", 34, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 14, 0, 0, 0), "Minus id hic eum vitae quod.", 42, new TimeSpan(0, 13, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 15, 0, 0, 0), "Tempora recusandae accusantium dolores tempora unde delectus culpa doloremque.", 24, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 12, 0, 0, 0), "Modi eligendi accusamus nemo reiciendis optio cupiditate ut.", 43, new TimeSpan(0, 11, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), "Qui et blanditiis eum natus.", 8, new TimeSpan(0, 10, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 16, 0, 0, 0), "Voluptatum eum fugiat incidunt molestiae quasi voluptas ratione asperiores.", 16, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 0, 0, 0), "Enim rem et quisquam perspiciatis et ipsa cum modi qui.", 51, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 15, 0, 0, 0), "Sed sint sunt ullam qui nesciunt eos.", 28, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 9, 0, 0, 0), "Incidunt odit possimus consequatur quia qui aut.", 76, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Autem animi eos rem dicta dicta.", 67, new TimeSpan(0, 14, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 0, 0, 0), "Est iusto est laboriosam laborum ipsam veniam minus minima.", 99, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Nam ut nulla.", 76, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 13, 0, 0, 0), "Qui voluptatem labore mollitia perspiciatis unde.", 80, new TimeSpan(0, 12, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), "Impedit quis maiores ut et iusto architecto id.", 39, new TimeSpan(0, 14, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 16, 0, 0, 0), "At earum quia iure necessitatibus at illo voluptatem pariatur blanditiis.", 44, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Dolorum alias omnis hic aperiam exercitationem eveniet molestias minus.", 58, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 0, 0, 0), "Ea illo provident.", 85, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), 19, "Doloremque qui est architecto et quia praesentium.", 84, 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 14, 0, 0, 0), "Eum veritatis perspiciatis ut dolores quia et dolorem aspernatur et.", 51, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, "Porro et placeat perferendis libero et inventore commodi porro error.", 70, 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 13, 0, 0, 0), "Quam cupiditate praesentium sit placeat et temporibus.", 93, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), 15, "In quis ducimus vitae totam id facilis perspiciatis.", 67, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 18, 0, 0, 0), "Ab ab blanditiis repudiandae.", 12, new TimeSpan(0, 17, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), 14, "Cum a non rem ea praesentium incidunt.", 97, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 13, 0, 0, 0), "Qui dolore alias.", 40, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 14, 0, 0, 0), "Eum sint at itaque est velit inventore.", 46, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 14, 0, 0, 0), "Ipsam quis perferendis a dolore.", 82, new TimeSpan(0, 13, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), "Rerum nostrum earum est sed sint architecto ut.", 27, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 9, 0, 0, 0), "Animi a rem nisi ut culpa enim.", 95, new TimeSpan(0, 8, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 11, 0, 0, 0), "Eum sit adipisci eligendi et eos placeat consectetur voluptates.", 27, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), 12, "Aut necessitatibus et nobis enim ut ut earum inventore.", 60, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), 1, "Qui veniam porro impedit voluptatem quo quia.", 57, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), "Voluptatem ab qui ut fuga quos at quia aut odio.", 41, new TimeSpan(0, 10, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 12, 0, 0, 0), "Mollitia repudiandae adipisci placeat neque similique rem rerum.", 18, new TimeSpan(0, 11, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 9, 0, 0, 0), "Pariatur et corporis.", 24, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), "Minima corrupti nihil voluptates.", 36, new TimeSpan(0, 9, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 12, 0, 0, 0), "Repellat dolore nemo et expedita modi et soluta.", 5, new TimeSpan(0, 11, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), "Sapiente facere quidem iusto qui eos et natus.", 70, new TimeSpan(0, 10, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), "Fugiat molestiae consequatur quod inventore dolores delectus.", 15, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 10, 0, 0, 0), "Consequatur quia fugiat neque qui veniam.", 55, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 14, 0, 0, 0), "Facere provident nesciunt quia commodi qui.", 11, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 18, 0, 0, 0), "Quod sed non cum est qui sint earum sunt.", 50, new TimeSpan(0, 17, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 14, 0, 0, 0), "Non cupiditate hic dolores facere et illo.", 92, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 3, "Odio magni repellat.", 65, 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 11, 0, 0, 0), "Quasi sed et suscipit ullam qui aut qui omnis.", 92, new TimeSpan(0, 10, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Repudiandae est quas voluptatem in velit qui.", 38, new TimeSpan(0, 11, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), "Sed assumenda cupiditate possimus molestiae eligendi quod.", 22, new TimeSpan(0, 17, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 15, 0, 0, 0), "Sed et facilis consectetur molestiae maxime ipsa officiis ut.", 29, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), "Quia et temporibus.", 41, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), "Accusamus ipsum eveniet omnis.", 46, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Neque pariatur ea suscipit.", 69, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), "Sed unde sed totam tempore et asperiores incidunt.", 16, new TimeSpan(0, 17, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), "Optio dolorem doloribus reiciendis dolor praesentium voluptatem sed.", 57, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), "Ipsam et laudantium fugiat aliquid aperiam sed inventore in dolorum.", 67, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 11, 0, 0, 0), "Ea eaque sequi at aspernatur.", 6, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 11, 0, 0, 0), "Sunt porro eos nesciunt ratione eius.", 63, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 0, 0, 0), "Et cum autem qui qui quos id sit.", 86, new TimeSpan(0, 9, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Necessitatibus nobis quasi sapiente ea fugit voluptatem accusantium illum itaque.", 58, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 15, 0, 0, 0), "Culpa et natus vel earum quasi.", 77, new TimeSpan(0, 14, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 4, "Numquam ad enim non magni.", 22, 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 13, 0, 0, 0), "Atque enim nulla.", 39, new TimeSpan(0, 12, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 12, 0, 0, 0), "Aspernatur maiores quas veniam aut.", 55, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 11, 0, 0, 0), "Quae sunt consequatur minima excepturi et earum illum corporis.", 7, new TimeSpan(0, 10, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Veniam maiores voluptate est ut.", 32, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 10, 0, 0, 0), "Libero enim voluptas.", 15, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 14, 0, 0, 0), "Deleniti possimus eum aut.", 65, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Rerum mollitia voluptate minus sunt.", 88, new TimeSpan(0, 17, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 12, 0, 0, 0), "Eum cum sint et velit dolore.", 49, new TimeSpan(0, 11, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), "Perferendis facere id quo ut impedit.", 32, new TimeSpan(0, 10, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 9, "Quidem rerum aut cum aliquid.", 58, 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 15, 0, 0, 0), "Est culpa nisi ad.", 28, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 13, 0, 0, 0), "Id excepturi aut velit dolorem error id voluptas.", 47, new TimeSpan(0, 12, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 18, 0, 0, 0), "Dicta atque nihil.", 46, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), "Eos adipisci rerum sit vero sed voluptas.", 38, new TimeSpan(0, 12, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 13, 0, 0, 0), "Consequatur aliquid eos deserunt laudantium hic quis dolore totam non.", 60, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Eos quam illum porro quia minus illum molestiae velit molestiae.", 46, new TimeSpan(0, 15, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), "Iure culpa cum eum.", 67, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 14, 0, 0, 0), "Id rerum illo nulla pariatur odit est dolor placeat.", 69, new TimeSpan(0, 13, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), 8, "Repellat quis aliquam amet magni maiores deserunt consectetur beatae.", 43, 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), "Accusantium harum ea tempore vel eligendi.", 100, new TimeSpan(0, 16, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), "Ipsa eius qui repellat voluptatem et ex ut minus dolor.", 41, new TimeSpan(0, 16, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), "Adipisci et culpa.", 84, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 0, 0, 0), "Possimus repudiandae sed molestiae voluptatem alias tenetur.", 65, new TimeSpan(0, 17, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), "Sed porro ullam et recusandae veniam rerum quasi ut.", 68, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), "Quo id dignissimos.", 100, new TimeSpan(0, 13, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), "Nam perspiciatis voluptas numquam dicta delectus.", 95, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 18, 0, 0, 0), "Magni minima similique repellat esse reiciendis et natus.", 8, new TimeSpan(0, 17, 0, 0, 0), 3 });

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
                columns: new[] { "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { 11, new TimeSpan(0, 10, 0, 0, 0), "Harum eveniet dignissimos quae.", 7, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 18, 0, 0, 0), "Ipsam repellendus officiis vel non.", 45, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Doloribus autem nulla.", 75, new TimeSpan(0, 11, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), 13, "Iusto rerum est delectus corporis natus autem quia eius doloribus.", 77 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 0, 0, 0), "Amet quod dolor.", 97, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 13, 0, 0, 0), "Aut vero maiores et consequatur sequi aut placeat.", 20, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), 20, "Omnis quidem non ratione reiciendis.", 57, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Ducimus nam similique dicta qui et.", 52, new TimeSpan(0, 11, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 12, 0, 0, 0), "Laborum fugiat est ea cum laboriosam voluptate et ipsa dolores.", 81, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Voluptatem voluptatem dicta.", 50, new TimeSpan(0, 15, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 13, 0, 0, 0), "Omnis tempore id.", 101, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Praesentium et aut consequatur quia et.", 20, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 9, 0, 0, 0), "Inventore in voluptate facere sint molestiae.", 20, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 16, 0, 0, 0), "Sunt voluptatem error nam quibusdam consequatur et inventore vel.", 40, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 0, 0, 0), "Nemo rerum eos quo aut.", 80, new TimeSpan(0, 11, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Repellat iusto repudiandae rerum recusandae.", 59, new TimeSpan(0, 14, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 14, 0, 0, 0), "Adipisci harum a rem quis mollitia et eos dolores maiores.", 78, new TimeSpan(0, 13, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Qui earum est vitae ipsa.", 37, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Et ipsam consectetur voluptatem velit dolor id amet et explicabo.", 26, new TimeSpan(0, 15, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 13, 0, 0, 0), "Nostrum sequi nihil perferendis eveniet dolorem voluptates quidem repellat ea.", 65, new TimeSpan(0, 12, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), "Quo molestiae cumque natus sint magnam dolor fugit in.", 82, new TimeSpan(0, 10, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 15, 0, 0, 0), "Officiis sed sit ipsa.", 93, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Libero praesentium et sequi exercitationem.", 12, new TimeSpan(0, 10, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 13, 0, 0, 0), "Non quod dolorem.", 56, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 7, "Et rem quia voluptas eligendi non quisquam commodi ex nihil.", 70, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), 5, "Enim eum voluptatibus sit minus.", 53, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 18, 0, 0, 0), "Repellendus accusamus ut reprehenderit rerum laboriosam aspernatur incidunt laudantium dolorem.", 95, new TimeSpan(0, 17, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 14, 0, 0, 0), "Non enim quaerat ipsa a soluta vel in.", 97, new TimeSpan(0, 13, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Possimus autem adipisci illum optio sit nam officiis.", 11, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 14, 0, 0, 0), "Voluptatem consequatur temporibus dolores alias dolores molestiae repudiandae fuga.", 80, new TimeSpan(0, 13, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), "Assumenda architecto facere eum tempore qui.", 86, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), 10, "Repudiandae eaque tenetur placeat.", 74 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), 4, "Consequuntur quaerat dolorem eos voluptas mollitia qui vel consectetur et.", 16, 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 16, 0, 0, 0), "Soluta officiis est autem.", new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 8, "Autem consequatur omnis.", 12, 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Tempore eaque recusandae occaecati corporis cumque quo iusto omnis.", 20, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), "Magni numquam soluta enim rerum.", 49, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 16, 0, 0, 0), "Eaque aut tenetur non quibusdam consequatur quae voluptatum aut perferendis.", 98, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), "Sit sapiente ut.", 51, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), "Qui enim voluptatum voluptas quia ducimus necessitatibus est facilis modi.", 61, new TimeSpan(0, 13, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 16, 0, 0, 0), "Sunt atque ea consequuntur sed deleniti cum et.", 30, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), 18, "Delectus saepe quibusdam voluptatem.", 78, 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Fuga aut impedit quos quo iure.", 23, new TimeSpan(0, 14, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 17, 0, 0, 0), "Molestiae quia tempora ut a quas in ad.", 56, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 13, 0, 0, 0), "Praesentium magnam sequi rerum omnis.", 2, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 12, 0, 0, 0), "Deserunt tenetur et.", 8, new TimeSpan(0, 11, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 12, 0, 0, 0), "Sunt est voluptatum quaerat.", 25, new TimeSpan(0, 11, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 0, 0, 0), "Excepturi sed error voluptates cumque placeat cupiditate repellendus vel et.", 71, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 18, 0, 0, 0), "Harum minima atque esse blanditiis tempore ullam.", 26, new TimeSpan(0, 17, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 16, 0, 0, 0), "Nobis labore natus id similique rerum quo nostrum iusto autem.", 76, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 9, 0, 0, 0), "Ut quidem ut tempora a temporibus.", 29, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 14, 0, 0, 0), "Voluptatem laborum quia laborum qui ipsam quia.", 17, new TimeSpan(0, 13, 0, 0, 0), 1 });

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
                columns: new[] { "About", "AverageRating", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Da liễu", 0f, 9 });

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
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Đa khoa", 0f, 1, 10 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Tim mạch", 0f, 2, 2 });

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
                columns: new[] { "About", "AverageRating", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Thần kinh", 0f, 4 });

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
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Đa khoa", 0f, 1, 1 });

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
                columns: new[] { "About", "AverageRating", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Da liễu", 0f, 3, 10 });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "33888 Hoàng Point", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20V%C3%A0ng%20Anh", "560423d9-d038-46e5-9a4c-b097749ec3b7", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "BaoTien_To@gmail.com", "Phùng Vàng Anh", 3, "BAOTIEN_TO@GMAIL.COM", "BAOTIEN_TO@GMAIL.COM", "AQAAAAIAAYagAAAAECuktbsuuZ4vLldFLh+WQLh1CUniZGgpVAP3567FBFeGeW+9bUFqBnS/F9VHk5OMgg==", "024 4401 6343", "ec217bc1-93f8-4be6-aee4-c382dddf0bba", "BaoTien_To@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3219 Đào Meadows", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Nam%20Phi", "e7d282f2-769d-459f-88f9-b0846012c3d5", new DateTime(2009, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), "DoanTrang_Dinh@hotmail.com", "Bùi Nam Phi", "DOANTRANG_DINH@HOTMAIL.COM", "DOANTRANG_DINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAECeY3CNVpPgmqm9JYWE8dA9iyhIXdw3H+2R3TOz4BWwoJYLIcaqgZdJOn2eQ0diB2Q==", "024 8375 2884", "d0499c5e-3f79-4b34-b3f7-91e89deafc8b", "DoanTrang_Dinh@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "656 Cát Tường Route", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Kim%20%C3%81nh", "70a0e705-4168-405c-99b6-0f8e9e6f6c89", new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "HieuThong59@hotmail.com", "Bùi Kim Ánh", 2, "HIEUTHONG59@HOTMAIL.COM", "HIEUTHONG59@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHVJCfq+upGCE5loVbaX5c0Xvxc0fIuB+v3em0LSSHVlh2hzyVQFAIGzPjbpt8y0Eg==", "026 7021 9287", "6964f8dc-2ab7-4110-94be-3e99031ab169", "HieuThong59@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "88576 Phạm Meadows", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Th%E1%BA%A3o%20My", "221fca3f-14c0-4845-beb7-dde8b1ea1abd", new DateTime(2015, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "NhaY3@yahoo.com", "Lý Thảo My", "NHAY3@YAHOO.COM", "NHAY3@YAHOO.COM", "AQAAAAIAAYagAAAAEIRp3i01VzCZBJMS1QePb88Nj//JRwYQ02HlgRJr6mix8k/M3ie2h8ekvOj2j67pqQ==", "023 2728 4402", "307c6ae0-59c4-4fab-89b4-951a3979ae6f", "NhaY3@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7538 Đinh Meadow", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Thu%20Li%C3%AAn", "aea262ac-08a4-4fa8-89dc-ee3119ff9a46", new DateTime(1999, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "DinhKim_To@hotmail.com", "Trịnh Thu Liên", "DINHKIM_TO@HOTMAIL.COM", "DINHKIM_TO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEP3iIgpjUzburKzrOS/VcLFbeA20pS0ZR5cl0jaIMozb3ZjMs+AhCT+YNIzXA9rplA==", "025 5326 7487", "43e1a604-d3a3-4796-b9b6-1b6bcda5cc89", "DinhKim_To@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "39527 Trương Ridges", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20Ho%C3%A0i%20Trung", "95fcc88d-4ac0-4344-8f32-2eb9c60148fb", new DateTime(2002, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "AnhXuan63@gmail.com", "Đoàn Hoài Trung", 3, "ANHXUAN63@GMAIL.COM", "ANHXUAN63@GMAIL.COM", "AQAAAAIAAYagAAAAEEIG7yN9mqfMDdIfXTex3eYdlCAIsxs1ZfUDuqTq/+76AcIcWi6KsFtdUQW4ASf2Bg==", "0203 6363 8423", "79e54773-f8de-4cfb-ab69-ebbb551b1f5e", "AnhXuan63@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "08052 Xuân Hoa Stravenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20H%E1%BA%A3i%20Y%E1%BA%BFn", "2f09a00f-2004-474e-bb87-dbaac454e45d", new DateTime(2016, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "DongNghi.Bui@hotmail.com", "Phạm Hải Yến", 2, "DONGNGHI.BUI@HOTMAIL.COM", "DONGNGHI.BUI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEP0UnX6ZVDnVKnxdyV7jrbt6HDr6gZooWoSlBsoM7DwB7yYNfZQP9wAZNe1yMemVVQ==", "0258 3163 5076", "1bfd55f9-0f74-4bb7-bd09-d963a8094d85", "DongNghi.Bui@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "396 Vũ Park", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Nh%E1%BA%ADt%20Ti%E1%BA%BFn", "a3b5b0be-4f67-4f0f-aacc-3a2234ea396b", new DateTime(1997, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "XuanThu_Hoang37@gmail.com", "Phạm Nhật Tiến", 1, "XUANTHU_HOANG37@GMAIL.COM", "XUANTHU_HOANG37@GMAIL.COM", "AQAAAAIAAYagAAAAEJpCffFaMTDGrngHUnITjayFD628iFrlAhGQ/4ssbWLF/3qs5pNZ3HXGn3ltj/R0IA==", "0272 1457 3430", "08a6eef6-5940-4117-b565-4242a9be43a8", "XuanThu_Hoang37@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9454 Hòa Bình Islands", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Xu%C3%A2n%20L%E1%BA%A1c", "bd032fe8-8a64-473c-9176-009de15bb517", new DateTime(2004, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "TruongLien_Ly5@hotmail.com", "Hà Xuân Lạc", 2, "TRUONGLIEN_LY5@HOTMAIL.COM", "TRUONGLIEN_LY5@HOTMAIL.COM", "AQAAAAIAAYagAAAAEN2kC/hW0ZurZvpC7r0tUEl+zgJxwmNcH/9mCl4sElF7q9tXjn7rSsr9gbFScrcVbA==", "0222 0783 0085", "3524111e-2976-4f78-b8b0-e065599f243f", "TruongLien_Ly5@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "008 Trần Curve", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20An%20H%E1%BA%B1ng", "ededbf7e-90b3-4ad4-813e-7c5f33b259a1", new DateTime(2005, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "VyLan27@hotmail.com", "Hoàng An Hằng", 1, "VYLAN27@HOTMAIL.COM", "VYLAN27@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHgNT9Ahe8ReZHiRAsiI9LSKWWLXNQouimnYxbvEB6WkPgJmO/Znlja8WGe9Ha0aTA==", "0278 8973 8464", "dac6c778-4fd5-4fe2-bb8f-d2b6f2d5b75d", "VyLan27@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "349 Như Hồng Oval", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Thanh%20H%E1%BA%A3i", "4366d638-940f-4c81-9ba0-977541cab696", new DateTime(2011, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), "ThienLac_Pham@hotmail.com", "Đỗ Thanh Hải", "THIENLAC_PHAM@HOTMAIL.COM", "THIENLAC_PHAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEE7mn7TWphEHP+P6JJv0QsPFsC/ELTptLAzW0Xrg0XOkJM73gZzuye9bwjEDDDBUnA==", "0266 4020 5395", "030934d2-bbf2-4e58-98e5-38fd8aa57c58", "ThienLac_Pham@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2255 Vương Lock", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Di%E1%BB%85m%20Ki%E1%BB%81u", "fda2c12b-02b5-4683-b3ed-a0059349d7ed", new DateTime(2002, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "QuocTruong80@yahoo.com", "Phùng Diễm Kiều", 1, "QUOCTRUONG80@YAHOO.COM", "QUOCTRUONG80@YAHOO.COM", "AQAAAAIAAYagAAAAEB/AnocBrvJunOQHQheXTc0uhm0aZMt4EXSLfrfblLhTPSHZKNs7Zwe8YNRYmSMnNg==", "0262 1320 4176", "b132cd76-b6f7-49e5-aa97-f88e114e14a7", "QuocTruong80@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "42490 Ðức Quyền Extensions", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20D%E1%BA%A1%20Y%E1%BA%BFn", "f7b97851-2802-4376-b19d-36dff7b43c5f", new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "PhuongNhi88@hotmail.com", "Phan Dạ Yến", 2, "PHUONGNHI88@HOTMAIL.COM", "PHUONGNHI88@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBXKhGw8tQg9a3/JUori3WV8JrKDDfj5V0c6g7QYn1fPN/ihAy290ZCiLoKzY/PI1Q==", "023 0616 3976", "869a7972-01ef-41bd-9154-ccfd30ec55ee", "PhuongNhi88@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "123 Lê Point", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Th%C6%B0%E1%BB%9Dng%20Ki%E1%BB%87t", "a9a193fa-21d6-4595-ace9-320431b0878f", new DateTime(2002, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "HuuTuong_Ly@yahoo.com", "Ngô Thường Kiệt", 1, "HUUTUONG_LY@YAHOO.COM", "HUUTUONG_LY@YAHOO.COM", "AQAAAAIAAYagAAAAELtHEksDxF4pIfu8XdFnjlVnDQGlL0O1HQQASureON1vilNVsvoU2LRPxlOClKHzPg==", "0283 5623 4625", "f585e478-81dc-4b64-bdfe-9779a0684419", "HuuTuong_Ly@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "793 Thế Dân Pike", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Qu%E1%BB%91c%20Vinh", "54fedfdb-cab4-46ee-b0db-729fbda77f03", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), "DinhDieu9@gmail.com", "Lê Quốc Vinh", "DINHDIEU9@GMAIL.COM", "DINHDIEU9@GMAIL.COM", "AQAAAAIAAYagAAAAED4cDnF7Y4RHhzm9Ge/I20pdexNDkK5wtetJzkrIW8VsdsvmRo8EJ3ScAwA8GDbJAw==", "021 1023 2437", "a780cfcf-360e-4f63-a19f-a317b7b75af3", "DinhDieu9@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "04628 Viễn Cảnh Branch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Ho%C3%A0ng%20%C3%82n", "afb0e941-49ad-41a6-86f5-206923cd57a7", new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "SonTrang.Do66@yahoo.com", "Tăng Hoàng Ân", 2, "SONTRANG.DO66@YAHOO.COM", "SONTRANG.DO66@YAHOO.COM", "AQAAAAIAAYagAAAAEASYUBPKFTP/70Bv4kRJBl/2SlR6kjDLGT4ym0BFWygcxZmSk6ddK1Nc+pO3Uh5f4Q==", "0238 2803 5758", "1eca358d-64d2-458b-8b62-a2d4010db3a7", "SonTrang.Do66@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "93902 Tô Glens", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Th%E1%BB%A5c%20Oanh", "2af02676-006f-42f1-a8e1-93442e76c0e6", new DateTime(1997, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), "BaoNgoc_Lam41@gmail.com", "Hồ Thục Oanh", "BAONGOC_LAM41@GMAIL.COM", "BAONGOC_LAM41@GMAIL.COM", "AQAAAAIAAYagAAAAEMgjC9nxS3VfSxdIFWBS5gj8cxG9ytyFMsiU1Si9UrLSJICNAP0V27oSC9HE5zVT2g==", "0233 6871 8741", "2438d3c5-6351-4af8-b323-6a8c79677182", "BaoNgoc_Lam41@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "06131 Vương Spur", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Di%E1%BB%85m%20My", "9c9d67d9-c6f8-4d4f-80a7-1ee213bc96cc", new DateTime(2016, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "DuyQuang86@yahoo.com", "Lý Diễm My", 3, "DUYQUANG86@YAHOO.COM", "DUYQUANG86@YAHOO.COM", "AQAAAAIAAYagAAAAEDsufBYXCd5ZELgq4eXdzPN0g7mOGd144U+Ll7ReJ53mLjHTVR0iTeYpzSnzQ/quxg==", "029 1699 6105", "ec94f9f6-4544-4c3c-bf3f-b2af5c19349a", "DuyQuang86@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4838 Mai Bypass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20%C3%90%C3%B4ng%20Nghi", "e0df8d7e-e2b8-4d52-9390-24dd11eb5eb6", new DateTime(2011, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "BichDiep.Truong3@gmail.com", "Dương Ðông Nghi", "BICHDIEP.TRUONG3@GMAIL.COM", "BICHDIEP.TRUONG3@GMAIL.COM", "AQAAAAIAAYagAAAAEMogA4e4K/H2S3P4BUboYfJdZ/tYeFhKLcUxioLgfHuYd4kJgK/78DfVszfqEYehQQ==", "0231 8236 1251", "1b499078-d303-4a0b-bf08-ad29e8cde575", "BichDiep.Truong3@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "431 Hồ Mountains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20%C3%90an%20T%C3%A2m", "9f47d146-072e-4754-8bd1-7971bcf9c160", new DateTime(2012, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "DiemThuy_Truong@hotmail.com", "Hoàng Ðan Tâm", "DIEMTHUY_TRUONG@HOTMAIL.COM", "DIEMTHUY_TRUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDtH4rVfpzZ4jVSqBuNUMMO59JVeC6jqekZHd5tbxbmFTWDlJKqu6R4vP2UTdwxI7g==", "0264 4607 3366", "583dc978-4eff-4059-81f9-2887028fe073", "DiemThuy_Truong@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "92448 Hữu Nghĩa Inlet", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Th%E1%BA%BF%20Quy%E1%BB%81n", "9654f4f1-1870-410a-b4e8-4e8475954284", new DateTime(2003, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), "VanThuong57@hotmail.com", "Đỗ Thế Quyền", "VANTHUONG57@HOTMAIL.COM", "VANTHUONG57@HOTMAIL.COM", "AQAAAAIAAYagAAAAENmYNZBBwBsq42kEWYcePvxu3pGNVOoigLFYzLwtlvv5R9MC/S9DGe5HfxX7p7bv9A==", "0205 9943 2213", "27daeb22-e889-4167-ba43-89c22934eec9", "VanThuong57@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4103 Trịnh Plains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20H%C3%B9ng%20Anh", "de7b47d7-ffa3-4238-932d-793d4eb354db", new DateTime(2015, 4, 14, 0, 0, 0, 0, DateTimeKind.Local), "TatHoa_Duong26@gmail.com", "Trương Hùng Anh", "TATHOA_DUONG26@GMAIL.COM", "TATHOA_DUONG26@GMAIL.COM", "AQAAAAIAAYagAAAAEFzmE5gPvK/gSonx3HTTvxwcZsvlfeyt4Kkmb6IGf4lPbo6cS+7pb3CI8MWxnUaDnA==", "0294 5520 0395", "c6d09eb4-88e3-494c-868d-0f1aa514c111", "TatHoa_Duong26@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "864 Ðình Quảng Parkway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20%C3%90%C3%ACnh%20L%E1%BB%99c", "00fdd42f-7e34-4c41-996d-4818983915ee", new DateTime(2012, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), "DiemTrinh55@gmail.com", "Ngô Ðình Lộc", "DIEMTRINH55@GMAIL.COM", "DIEMTRINH55@GMAIL.COM", "AQAAAAIAAYagAAAAEF7f6Yns2lOL3ffLwzRgBO+s3kQr5FA/EcEctR0VQuqhMSN3uXLjAampT7mZLFwv4A==", "0286 3592 6688", "a59f2030-606a-4054-906c-8f98ebd15370", "DiemTrinh55@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1643 Hoàng Phát Island", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Mai%20Linh", "6532cadd-e316-4f26-9b24-92d56b56396e", new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), "NguyetUyen74@yahoo.com", "Đặng Mai Linh", 1, "NGUYETUYEN74@YAHOO.COM", "NGUYETUYEN74@YAHOO.COM", "AQAAAAIAAYagAAAAEKhf73cHmtBlnPA+3QXqBR9QXuscWSgiJd7HJNypQAe2Hfd50iVlfcHOe/iMtSyEtA==", "026 1505 5932", "4521c407-2715-4c7d-bf47-c47a1f589711", "NguyetUyen74@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "63290 Song Oanh Crossroad", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20Ng%E1%BB%8Dc%20H%E1%BA%A3i", "a4910c95-430a-40ab-bb6e-7aa37e9861dd", new DateTime(2012, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "ChieuDuong.Doan@hotmail.com", "Lâm Ngọc Hải", "CHIEUDUONG.DOAN@HOTMAIL.COM", "CHIEUDUONG.DOAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEM8/k76lToqX0xnDJHizaRbrJpkawYiw3NhF7EYwNA7l8A7Klm5VrVKcCESBFLFx3A==", "020 3979 0632", "567a61df-4a08-4371-90d9-d53538623756", "ChieuDuong.Doan@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "052 Đoàn Roads", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Qu%E1%BB%91c%20To%E1%BA%A3n", "87031412-a51c-4741-80bb-732c1331990e", new DateTime(2010, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "NhaUyen48@hotmail.com", "Vương Quốc Toản", 3, "NHAUYEN48@HOTMAIL.COM", "NHAUYEN48@HOTMAIL.COM", "AQAAAAIAAYagAAAAEK/EFOqcUaRzmFA1pnI9O1QYBHy/9xVpx57NmHqbSDvJCHbV4CB5CDlzboP0cmFrlw==", "024 0201 5064", "307ac30b-70a8-499d-b9d5-6dfed559090e", "NhaUyen48@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "73849 Ánh Linh Flats", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Thi%C3%AAn%20Di", "be4c6ff6-bf57-4a62-aa0c-7d03e5fd0a21", new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "TheTrung.Bui76@yahoo.com", "Đỗ Thiên Di", "THETRUNG.BUI76@YAHOO.COM", "THETRUNG.BUI76@YAHOO.COM", "AQAAAAIAAYagAAAAECBtK8pUI0Zdh/HcIRDYzX/SkdLCyY6a++S2/TIBCKT0q3q7kH3Fihc533WBtOaPYg==", "0218 9954 0330", "6ad76647-f93a-4c9f-bcaf-55ff65dfc4ad", "TheTrung.Bui76@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "30816 Thiều Ly Manors", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Thu%20Duy%C3%AAn", "e51cab48-6af6-4dfc-ae86-430ff9ba0e1b", new DateTime(2010, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "XuanMinh.Ly@yahoo.com", "Trương Thu Duyên", 1, "XUANMINH.LY@YAHOO.COM", "XUANMINH.LY@YAHOO.COM", "AQAAAAIAAYagAAAAEL+mdFWuSbGZIPDseNzWR+GvuEEk//aFbcspOVLh25W1smgPx3wgZiWaOD+eS3T/3g==", "022 1038 3708", "df237da7-cb57-416f-8da5-277a6b1500ab", "XuanMinh.Ly@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "27487 Quỳnh Vân Gateway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Duy%20H%E1%BA%A1nh", "101036c0-2497-429c-a178-3155582af287", new DateTime(2009, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "TaHien_Dao@yahoo.com", "Mai Duy Hạnh", "TAHIEN_DAO@YAHOO.COM", "TAHIEN_DAO@YAHOO.COM", "AQAAAAIAAYagAAAAEOZR/f1eguGaCURKH2UT5qJ3PjBVTsaL5ydJZ1AGwlREch/eK2SkD6dRpoNNIGDLvg==", "025 2902 0451", "4f5337e7-5add-41ce-af17-f5955dddcc51", "TaHien_Dao@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "23226 Trọng Kiên Land", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20Thu%E1%BA%ADn%20Th%C3%A0nh", "9a50c6ec-286a-409a-b91b-45f743d30c7c", new DateTime(2004, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "HuyQuang86@yahoo.com", "Phan Thuận Thành", 1, "HUYQUANG86@YAHOO.COM", "HUYQUANG86@YAHOO.COM", "AQAAAAIAAYagAAAAEGw2Wa3tH6SQgQKaNg+gWsctvLH3zyEmla2BoPJBW0i9l+OaV598QatkC137Xrjnxg==", "021 4551 4644", "2bcbe0f7-af9d-4627-aa82-7937749c0474", "HuyQuang86@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "177 Huệ An Stravenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20Ph%C3%BAc%20L%C3%A2m", "1e1123cd-6473-4dd9-90e7-962088cd8c8c", new DateTime(2018, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "PhucLam.Dao@yahoo.com", "Phan Phúc Lâm", 3, "PHUCLAM.DAO@YAHOO.COM", "PHUCLAM.DAO@YAHOO.COM", "AQAAAAIAAYagAAAAENpIXjLtKwQuVexLmR0vbcrmISYLDwkczxXgzCQE+E7UdD4hMgTzdLxUWECbovLHRA==", "028 7568 1925", "51568c8b-09b5-43f4-b2be-15f4ad49fe4b", "PhucLam.Dao@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "37567 Phùng Fort", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20Hu%E1%BB%87%20L%C3%A2m", "7158aa15-ebae-4f28-b791-15850ee95c95", new DateTime(2018, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "PhuTho16@gmail.com", "Đoàn Huệ Lâm", "PHUTHO16@GMAIL.COM", "PHUTHO16@GMAIL.COM", "AQAAAAIAAYagAAAAEJ2VsfQHwU3BDSLS9TxnKep6tltWuxUsR2C4nlr6dxaS3EihF0iKuPVYplISxTybUA==", "023 2602 9646", "a4af6eb2-da60-49b6-bbf7-81c0034663a7", "PhuTho16@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "55494 Trương Parks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20%C3%90%E1%BB%A9c%20Phi", "2c6916a3-9037-4e5a-95bb-d2125ee7ef4c", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "QuangXuan_Tran@yahoo.com", "Tăng Ðức Phi", 1, "QUANGXUAN_TRAN@YAHOO.COM", "QUANGXUAN_TRAN@YAHOO.COM", "AQAAAAIAAYagAAAAEBn2lwMdxUZ1/J6JXkOAYVm9HPTYUdNyxc7rB16nlkGZIV5G2CrH7g4U0TpDUwk26g==", "028 1173 5614", "fcdd555c-bcda-48ff-8a6b-40e91a543045", "QuangXuan_Tran@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "889 Quang Hà Manor", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20M%E1%BB%99ng%20Lan", "89c847cf-8885-4064-b48a-a4385386c12b", new DateTime(2012, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "KhoaTruong.Ho14@yahoo.com", "Trịnh Mộng Lan", 3, "KHOATRUONG.HO14@YAHOO.COM", "KHOATRUONG.HO14@YAHOO.COM", "AQAAAAIAAYagAAAAEOLEonkz6zkxJz8C7E7e0ooHFBpvYYjVvlYXm3kUPIlsbOBOHVXEDsLU1yBvkpox7w==", "025 1270 7294", "f3148d6d-45cf-44c2-b9d2-414c6800af01", "KhoaTruong.Ho14@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "72716 Hồ Path", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20Ng%E1%BB%8Dc%20Uy%C3%AAn", "9fbe916b-c3b3-413e-b5ae-6c28683493c5", new DateTime(2007, 12, 31, 0, 0, 0, 0, DateTimeKind.Local), "KimThu.Pham@gmail.com", "Nguyễn Ngọc Uyên", "KIMTHU.PHAM@GMAIL.COM", "KIMTHU.PHAM@GMAIL.COM", "AQAAAAIAAYagAAAAEB+xHUJUlbkXocZMa8oBv/Mj0I3hav172Y1jh8AFDq5aWEX0mGRmA+tmTpdCLO8rBg==", "022 0975 1373", "58d230ef-6efa-4a80-8e20-a94432152f4f", "KimThu.Pham@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0445 Vương Branch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Qu%E1%BA%A3ng%20%C3%90%E1%BA%A1i", "e083e8df-113b-4c97-bcf9-89b9fd57630c", new DateTime(1999, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), "ThienLac_Ly84@yahoo.com", "Lý Quảng Ðại", 1, "THIENLAC_LY84@YAHOO.COM", "THIENLAC_LY84@YAHOO.COM", "AQAAAAIAAYagAAAAEEprjMhZuL/FcUIH+0MiZZtSqdpCUqxNDYHSWNFYO3uiebCt6D5GpzHFztrzBxK7UA==", "0229 1033 5522", "2de9c032-de16-458e-a70a-318ead3e6e29", "ThienLac_Ly84@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "302 Đỗ Bypass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Xu%C3%A2n%20Hoa", "f93e2e9a-6bad-4b54-9487-7d0c74f20051", new DateTime(2004, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "TheSon.Vu@yahoo.com", "Lý Xuân Hoa", "THESON.VU@YAHOO.COM", "THESON.VU@YAHOO.COM", "AQAAAAIAAYagAAAAEC1FK1vdWWWHwrxfXYRZCON0QNZYHWznouX+Lap8HnoDhz26CYSohT+czhmkH++Ffg==", "023 2582 9700", "f3e1399b-2297-4c45-a759-49a2cb23b505", "TheSon.Vu@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "443 Ngô Point", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Ng%E1%BB%8Dc%20H%C3%A2n", "d603549e-4ef4-4a46-9211-4634f6cdcb2e", new DateTime(2016, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), "TrongTuong.Phung48@gmail.com", "Tô Ngọc Hân", 3, "TRONGTUONG.PHUNG48@GMAIL.COM", "TRONGTUONG.PHUNG48@GMAIL.COM", "AQAAAAIAAYagAAAAENgPaB+HN2vdDor82JR9tW1+0Hezw/Z7acBHPyZbUyvmJ1SCr/viEyny9DjOXzKK1g==", "0206 2551 5335", "2a6d6088-be38-46a9-badc-bc0ffb80e0b7", "TrongTuong.Phung48@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7175 Bùi Passage", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C5%A9%20L%E1%BB%87%20Chi", "1ca6d49d-6808-4255-af9e-e05dd0f2ed6b", new DateTime(2003, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "ThuanPhong67@hotmail.com", "Vũ Lệ Chi", 3, "THUANPHONG67@HOTMAIL.COM", "THUANPHONG67@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEUkeP6JSSBSQR8sAk8CmrUhQ29lDbvCbgYa9xZC7OHTfnB8d3Q02BpyaveNTTJHCA==", "025 0112 7848", "c7656216-6c45-407d-9dd2-b73473c630c6", "ThuanPhong67@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "431 Trọng Kiên Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20V%C3%A2n%20Khanh", "2da4df49-c35b-4e27-9c61-7dbfc1260fa1", new DateTime(1995, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "DongPhuong40@gmail.com", "Hồ Vân Khanh", "DONGPHUONG40@GMAIL.COM", "DONGPHUONG40@GMAIL.COM", "AQAAAAIAAYagAAAAEKv25zqokKenDiXMT2THKCLWBe1uCVXim2TdCklFAkcCnaGSoNMZpNndvUtRu3SpZA==", "0257 7367 3298", "23776d8f-0afa-4694-b413-320022dcf67e", "DongPhuong40@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0293 Thảo Hương Manor", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20%C3%90%E1%BB%A9c%20T%C3%A2m", "da66177a-ae51-42d8-9399-52ba63397f4f", new DateTime(2009, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "TanNam_Lam@yahoo.com", "Vương Ðức Tâm", 2, "TANNAM_LAM@YAHOO.COM", "TANNAM_LAM@YAHOO.COM", "AQAAAAIAAYagAAAAEPJzoL4uFBOWu9y3KnIcT/JmTGZN6fG9KxMk/I3+K90e8gNc0vSPmfk15i4kn2P/Dw==", "026 5502 0444", "7952a7c8-3ba6-4a73-be0c-913d3cb2e047", "TanNam_Lam@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "015 Đinh Fall", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20C%C3%B4ng%20Th%C3%A0nh", "6672f211-9cf4-4062-8834-cac4adb08078", new DateTime(1998, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "LongVinh_Trinh@yahoo.com", "Đoàn Công Thành", "LONGVINH_TRINH@YAHOO.COM", "LONGVINH_TRINH@YAHOO.COM", "AQAAAAIAAYagAAAAEM36kg6zh8a/mFSRxr7QWd68vc5y87AvOv9u5DMoj7VaNXKBY8NFC5ZZrxV3AJRgaA==", "0227 5389 8739", "0c38d9df-cfea-4ad9-b80e-fd97a41be881", "LongVinh_Trinh@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8843 Ngô Mills", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20B%C4%83ng%20B%C4%83ng", "10f48f8d-87c3-4fa1-9db1-d25ce9dbcf11", new DateTime(2002, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "AnhTho_Duong@gmail.com", "Lý Băng Băng", 1, "ANHTHO_DUONG@GMAIL.COM", "ANHTHO_DUONG@GMAIL.COM", "AQAAAAIAAYagAAAAECaguF9s1zbEc3RXsKjZlsd005srdOrg4f8aQL2Wvv3rvyx8cxTQ8GPVPI9BouIhug==", "0277 3088 6183", "058311f7-5b1e-43b4-85e2-7a5ce040d346", "AnhTho_Duong@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "786 Hải Phương Plaza", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Uy%C3%AAn%20Minh", "c40a6315-39f4-49de-8250-051bd9bf642d", new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), "LamNhi.Pham@yahoo.com", "Vương Uyên Minh", "LAMNHI.PHAM@YAHOO.COM", "LAMNHI.PHAM@YAHOO.COM", "AQAAAAIAAYagAAAAEDeRk9exotdSB0bJpbszLTMIVg1Hbilc1t9tdUipxcK5dt121KgSSRVHrQs5Rt6yJg==", "025 9016 9953", "0754a287-b1e1-474a-9e90-3bccd492c8fb", "LamNhi.Pham@yahoo.com" });
        }
    }
}
