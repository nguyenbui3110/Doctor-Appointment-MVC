using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorAppointment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ReSeedAvatarUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 9, 0, 0, 0), "Quis delectus magni ipsa quia nihil veniam incidunt eum non.", 75, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, "Quaerat enim nesciunt.", 36, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), "Nisi aperiam sint excepturi officia dolorum alias rerum quisquam.", 56, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 12, 0, 0, 0), "Unde maiores officiis enim et.", 61, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 16, 0, 0, 0), "Inventore nihil itaque ad doloribus eum.", 76, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Incidunt recusandae quibusdam voluptate quibusdam accusamus.", 75, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), 10, "Cupiditate ullam expedita aut nesciunt voluptas numquam in quae.", 99 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 12, 0, 0, 0), "Libero officia vero autem veniam nihil earum illo sed.", 28, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 13, 0, 0, 0), "Corrupti voluptas vel nihil quam ut.", 62, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Local), 19, "Neque qui nemo numquam amet voluptatibus quia.", 25, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), "Nesciunt eaque molestiae.", 82, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 12, 0, 0, 0), "Nihil harum dolorem et facere repellendus quod nihil magni.", 7, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 13, 0, 0, 0), "Necessitatibus maiores officia facere harum.", 38, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), "Labore est neque est delectus modi sunt numquam amet quia.", 72, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 18, 0, 0, 0), "Odio nostrum porro ea inventore ut.", 78, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 13, 0, 0, 0), "Voluptas ullam ullam.", 21, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Porro nemo nulla sint quia sapiente quae.", 31, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 14, 0, 0, 0), "Ullam id dolore unde delectus.", 27, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 0, 0, 0), "Quis ipsam molestias quia.", 8, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Quis nostrum repellendus est vitae repellendus quia.", 69, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 16, 0, 0, 0), "Odio sunt ut ut aut debitis dolorem vero.", 63, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 20, "Distinctio vero repudiandae non maiores quis culpa temporibus ex dolores.", 54, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 12, 0, 0, 0), "Aliquid accusantium voluptatibus qui quam explicabo eum qui.", 10, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 9, 0, 0, 0), "Sit reiciendis est sed consequuntur et reiciendis temporibus distinctio.", 19, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 9, 0, 0, 0), "Sit rerum in voluptatum facere quos ipsam et impedit.", 81, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 12, "Quo enim facere aut eligendi ad asperiores laboriosam.", 97, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 18, 0, 0, 0), "Nesciunt asperiores esse beatae a.", 88, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 16, 0, 0, 0), "Et placeat ipsa quasi dolorem nulla accusantium quaerat consequatur.", 68, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 0, 0, 0), "Ipsam facilis et maiores ut ut et.", 36, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), 15, "Blanditiis doloremque quibusdam deleniti excepturi assumenda ullam quidem.", 9 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 16, 0, 0, 0), "Quam placeat non aut delectus harum magni in autem aut.", 2, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), "Veritatis iure omnis laborum molestiae tenetur id.", 77, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 11, 0, 0, 0), "Nesciunt excepturi deleniti ut corporis velit mollitia.", 14, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 12, 0, 0, 0), "In et sunt.", 2, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 14, 0, 0, 0), "Molestiae necessitatibus blanditiis dolorem aut atque aperiam nulla ut et.", 40, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), "Voluptates assumenda amet suscipit illo quasi.", 86, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 16, 0, 0, 0), "Consectetur voluptatem saepe est et possimus iusto.", 36, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 17, 0, 0, 0), "Eveniet eligendi et quo perspiciatis corporis unde rerum vero.", 11, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 0, 0, 0), "Ea rerum necessitatibus est laudantium libero est adipisci totam eum.", 78, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), "Placeat sit quisquam adipisci excepturi eos cupiditate blanditiis est porro.", 21, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 12, 0, 0, 0), "Sed eos ratione.", 96, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 18, 0, 0, 0), "Ea ipsa consequatur a minus.", 88, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 10, 0, 0, 0), "In quod et odio aut voluptatem qui pariatur officia.", 52, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 12, 0, 0, 0), "Incidunt nihil vel natus ratione soluta qui architecto officiis ex.", 23, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 16, 0, 0, 0), "Velit eum nobis sint.", 50, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 0, 0, 0), "Aliquid provident sunt aut asperiores ut.", 15, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 13, 0, 0, 0), "Eum saepe quasi eaque et.", 99, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), "Debitis et saepe nulla sed nisi eius.", 101, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 10, 0, 0, 0), "Sed animi quia perferendis vel ut ab error.", 78, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 14, 0, 0, 0), "Eos accusantium eaque aut possimus aut provident quia.", 70, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Odit quam aut facilis necessitatibus ut quam.", 47, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Sed quia ut illo pariatur fugit.", 39, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), "Sit quod totam totam porro magnam.", 99, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 16, 0, 0, 0), "Id aut officia nostrum.", 85, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Cum omnis nihil voluptatem exercitationem.", 51, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 15, 0, 0, 0), "Ducimus est veniam fuga voluptatibus et vero rem eaque explicabo.", 21, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 13, 0, 0, 0), "Rerum odio ab quos iure corrupti et totam.", 29, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 18, 0, 0, 0), "Minus aut corrupti molestias ut qui repellat aut.", 41, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), 5, "Eligendi soluta dolor recusandae numquam adipisci eos accusamus doloremque.", 33 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 4, "Asperiores iusto debitis consequatur architecto nulla omnis.", 80, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 0, 0, 0), "Aut quasi at impedit.", 89, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 12, 0, 0, 0), "Et quidem autem provident autem maxime id.", 70, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 15, 0, 0, 0), "Odit ea ex voluptates.", 52, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 15, 0, 0, 0), "Illum rem dolorem ad ut incidunt ipsam sint.", 81, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 9, 0, 0, 0), "Aut ipsam labore in quo expedita eos tempore.", new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, "Eveniet vel non alias voluptatem velit.", 37, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Sit quis aperiam praesentium nam assumenda eligendi.", 75, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 11, 0, 0, 0), "Perferendis similique laboriosam.", 35, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 15, 0, 0, 0), "Necessitatibus reiciendis ut qui quaerat.", 47, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 4, "Quasi assumenda aperiam reiciendis amet labore voluptatem delectus fuga quam.", 35, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), "Cupiditate qui recusandae neque iure ea ut architecto.", 41, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 9, 0, 0, 0), "Quis est eveniet illo assumenda expedita.", 17, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 17, 0, 0, 0), "Sint dolor ipsam doloribus ut qui libero.", 37, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 16, 0, 0, 0), "Nulla dolorem beatae praesentium alias molestiae accusantium.", 67, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Est repudiandae id animi illo.", 62, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Qui nostrum qui facere autem ut tenetur quasi nulla quia.", 12, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 10, 0, 0, 0), "Corporis ut quia delectus delectus labore et omnis.", 38, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), "Voluptatem occaecati est unde est explicabo iure et.", 28, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 17, 0, 0, 0), "Sit blanditiis magni modi sed consectetur eius ipsum provident.", 45, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), "Repellendus eius iste sunt error aut rerum.", 72, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), "Nisi qui velit exercitationem.", 4, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 0, 0, 0), "Ea voluptas consequatur quia sint eum sed consequatur ut ea.", 6, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 14, 0, 0, 0), "Nobis dolorem sit.", 98, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 16, 0, 0, 0), "Voluptatem omnis voluptate magnam provident vitae sed non tenetur veritatis.", 8, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 18, 0, 0, 0), "Ullam voluptatibus deserunt deserunt eaque.", 47, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 12, 0, 0, 0), "Odit suscipit et praesentium rerum minima et sint iure vel.", 2, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 12, 0, 0, 0), "Sed accusamus eos.", 9, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 9, 0, 0, 0), "Molestias odit velit ut voluptatibus.", 47, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 14, 0, 0, 0), "Sit officiis aliquam beatae magni voluptatem enim et.", 45, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 18, 0, 0, 0), "Vero magnam consequatur cupiditate deleniti.", 25, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), 13, "Voluptas itaque non qui atque quia quia quia eaque est.", 28, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 0, 0, 0), "Qui sint corrupti laboriosam accusamus similique in in velit animi.", 58, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 0, 0, 0), "Esse est reiciendis et ipsam consectetur sint voluptatem voluptate.", 77, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 0, 0, 0), "Laboriosam est est.", 88, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 11, 0, 0, 0), "Voluptatem itaque aut soluta autem est qui laborum.", new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Qui harum aut quis non excepturi est unde facere rem.", 7, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 9, 0, 0, 0), "Ipsum reiciendis et atque repellat.", 29, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 9, 0, 0, 0), "Qui cum aut saepe voluptatibus assumenda eos distinctio.", 77, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Modi cupiditate architecto quis sed sapiente.", 19, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), 10, "Aut aut assumenda nihil commodi.", 65, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 9, 0, 0, 0), "Labore est rerum.", 28, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 11, 0, 0, 0), "Qui fugiat ipsa nostrum voluptates autem veniam.", 58, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 16, 0, 0, 0), "Ullam distinctio rem.", 38, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Dolores molestias blanditiis expedita repellendus incidunt similique.", 53, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 13, 0, 0, 0), "Fugit nostrum ut.", 88, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 14, 0, 0, 0), "Dolores commodi expedita ipsum id.", 56, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), 11, "Vel esse eaque aut rem ducimus fugit quia veritatis.", 85, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 18, 0, 0, 0), "Ut iusto necessitatibus consectetur.", 70, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), "Maxime ut molestias voluptates omnis dolor ut et doloremque.", 54, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 9, 0, 0, 0), "Delectus sint nemo dolor ut aut est nobis.", 26, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 9, 0, 0, 0), "Illo quia enim tempore quos nostrum nihil facere.", 88, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 17, 0, 0, 0), "Reprehenderit mollitia numquam iure dolorem odit doloribus ducimus voluptas.", 82, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 15, 0, 0, 0), "Quo voluptatem ad sunt velit quia repellendus.", 47, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), "Consectetur aperiam asperiores ut.", 13, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 12, 0, 0, 0), "Architecto repellendus dolor sunt velit quaerat aliquam.", 26, new TimeSpan(0, 11, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), "Distinctio nulla quaerat.", 72, new TimeSpan(0, 9, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 16, 0, 0, 0), "Accusamus rem tenetur id minus.", 100, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 18, 0, 0, 0), "Veniam est eum nam consectetur.", 23, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Quam est magni a molestias.", 88, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 17, 0, 0, 0), "Earum veritatis perferendis animi libero quas provident reprehenderit.", 8, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 11, 0, 0, 0), "Vero laboriosam illum odio ducimus aut sequi iure eveniet nesciunt.", 5, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 18, 0, 0, 0), "Reprehenderit et asperiores est consequatur aut blanditiis alias laborum voluptatem.", 1, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 0, 0, 0), "Culpa consectetur dolorem tempore et quam.", 93, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 14, 0, 0, 0), "Delectus nam natus nihil sunt quia et eius.", 81, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 11, 0, 0, 0), "Corrupti eaque error sit quia non sed quia dolore.", 65, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Corporis facere eos accusantium.", 14, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 15, 0, 0, 0), "Inventore earum sapiente expedita ex aut iusto voluptatum sed sint.", 54, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), 13, "Nemo ut quia.", 43 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), "Neque eos ea dolorum culpa fuga error eum.", 81, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 15, 0, 0, 0), "Similique omnis exercitationem dolor tempore in molestiae quis ratione.", 38, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), 18, "Magnam quod ea velit.", 89, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 11, 0, 0, 0), "Quia consequatur quo qui voluptatum ullam odio.", 4, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 10, 0, 0, 0), "Magnam ut et numquam quia modi reiciendis.", 94, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 18, 0, 0, 0), "Provident voluptas voluptatibus.", 58, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 18, 0, 0, 0), "Et veritatis ut tempore dolor in.", 18, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 10, 0, 0, 0), "Rerum placeat omnis fuga reprehenderit vitae et aut.", 10, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 18, 0, 0, 0), "Laborum ea aut magni sapiente in exercitationem eos aliquid ea.", 43, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Velit exercitationem est vel sed nobis.", 29, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 17, 0, 0, 0), "Aut eaque quis et occaecati.", 64, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 14, 0, 0, 0), "Dignissimos eos repellendus quaerat voluptatem.", 2, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 12, 0, 0, 0), "Accusamus quia sunt.", 16, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 15, 0, 0, 0), "Deserunt dolorem ab atque.", 72, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 18, 0, 0, 0), "Quo est sed cumque ut.", 76, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 16, 0, 0, 0), "Minima iusto autem dolore numquam nulla accusamus voluptatem qui.", 42, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 18, 0, 0, 0), "Quod totam ut corporis asperiores facilis enim fugit debitis voluptatem.", 71, new TimeSpan(0, 17, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 16, 0, 0, 0), "Dicta veritatis id recusandae vero hic illum exercitationem.", 68, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), "Blanditiis magnam sed qui dolorum.", 86, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), "Qui et est provident at voluptatem odit.", 27, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 10, 0, 0, 0), "Rerum explicabo magni fugiat rem voluptatem.", 86, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 12, 0, 0, 0), "Eum exercitationem optio temporibus laudantium autem eos.", 58, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 15, 0, 0, 0), "Natus ex fugiat ut.", 40, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 16, 0, 0, 0), "Explicabo explicabo velit quia veniam distinctio excepturi voluptas tempora praesentium.", 75, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Dolorem quasi officiis soluta.", 12, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), "Qui at sequi voluptatum nostrum maiores quae ut amet vel.", 64, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 9, 0, 0, 0), "Facere quas inventore tempore.", 24, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 13, 0, 0, 0), "Suscipit enim commodi velit sed est illo laborum repellat nemo.", 45, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 14, 0, 0, 0), "Voluptatum perspiciatis quos velit dolore iusto qui.", 40, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 15, 0, 0, 0), "Voluptatem nulla et in.", 53, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 3, "Id dolores et qui.", 24, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 17, "Dolor aliquid quaerat omnis eum ea.", 97, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 9, 0, 0, 0), "Totam voluptatem est reprehenderit repudiandae quis aspernatur modi fugiat.", 18, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 10, 0, 0, 0), "Dignissimos alias quia ea aut.", 17, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), "Qui iure vel.", 39, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 14, 0, 0, 0), "Facere aut occaecati rerum ut iste voluptatibus.", 77, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 18, 0, 0, 0), "In fugit dolores provident hic necessitatibus dicta.", 35, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 18, "Voluptas dignissimos qui quia expedita voluptas eos eos qui id.", 47, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), "Praesentium et sint.", 92, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 16, 0, 0, 0), "Vero sunt veniam aliquam earum laudantium suscipit in.", 86, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 16, 0, 0, 0), "Commodi ullam repudiandae totam minima voluptatum qui labore non.", 27, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 9, 0, 0, 0), "Saepe vitae non et dicta rerum rerum.", 56, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 11, 0, 0, 0), "Maiores fugit expedita.", 30, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 11, 0, 0, 0), "Est sunt fugit quas rerum repellat non quas suscipit.", 11, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 17, 0, 0, 0), "Totam adipisci et.", 7, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 16, 0, 0, 0), "Quos assumenda asperiores a.", 27, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 11, 0, 0, 0), "Praesentium dolorum doloremque et possimus est eaque suscipit.", 6, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), "Magni tenetur mollitia dolore in quo similique.", 73, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 13, 0, 0, 0), "Quidem vel dolore est et.", 65, new TimeSpan(0, 12, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Asperiores vel rem eligendi sed commodi velit aliquid.", 64, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Pariatur aperiam aut atque neque ea est.", 77, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), "Expedita non quia sint.", 45, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 11, 0, 0, 0), "Maxime atque voluptatem et tenetur asperiores sapiente numquam sint.", 90, new TimeSpan(0, 10, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 15, 0, 0, 0), "Accusantium saepe tempora tempore tenetur voluptatem a officia.", 14, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), "Ipsam sunt qui dicta quia.", 8, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 3, "Facere dolores optio quasi.", 93 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 17, 0, 0, 0), "Velit necessitatibus dolores molestias.", 71, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 10, 0, 0, 0), "Sequi adipisci quos.", 98, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 13, 0, 0, 0), "Rerum quia adipisci recusandae.", 91, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 18, 0, 0, 0), "Eius repellendus laudantium dolor.", 4, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 0, 0, 0), "Libero quaerat et rerum rerum.", new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Maxime quae debitis quia excepturi omnis quis accusantium est voluptas.", 56, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 13, 0, 0, 0), "Modi quasi quibusdam voluptatibus sapiente et nam.", 50, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), "Autem qui et omnis.", 56, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 16, 0, 0, 0), "Voluptates impedit non et.", 59, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 9, 0, 0, 0), "Velit consequatur nobis et illum est asperiores.", 3, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 13, 0, 0, 0), "Ad exercitationem magni et reiciendis.", 13, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 9, 0, 0, 0), "Cumque dolores unde.", 12, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 9, 0, 0, 0), "Aspernatur et maxime iste quo sed nihil quia.", 29, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), "Error quam illo ipsum optio consequuntur quia hic quisquam dicta.", 39, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 14, 0, 0, 0), "Exercitationem omnis ea et.", 85, new TimeSpan(0, 13, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 16, 0, 0, 0), "Eos ea cumque aut non assumenda inventore animi adipisci.", 41, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 9, 0, 0, 0), "Sint eum omnis ut est aut reiciendis consequatur repudiandae qui.", 97, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 0, 0, 0), "Consequatur molestias ducimus earum perspiciatis excepturi dicta.", 12, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 17, 0, 0, 0), "Cum sed rem ullam ducimus ad porro neque doloremque.", 74, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 16, 0, 0, 0), "Amet officiis non consequatur vel dolor culpa rem.", 84, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), "Quod labore sunt et sint asperiores non dolores quae.", 31, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 17, 0, 0, 0), "Corporis quia itaque quidem quos vitae fugiat cupiditate eligendi.", 66, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 0, 0, 0), "Animi nisi qui quaerat nemo.", 33, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 17, 0, 0, 0), "Ipsa id et ut aperiam tempore nulla laborum vero.", 57, new TimeSpan(0, 16, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), "Ut repellendus et soluta ut est nemo.", 28, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Pariatur et iste qui incidunt deleniti at ipsam aliquid qui.", 71, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 9, 0, 0, 0), "Quis saepe aperiam placeat vitae eos qui laboriosam debitis ea.", 59, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 15, 0, 0, 0), "Ipsam dolorum accusamus blanditiis.", 20, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 16, 0, 0, 0), "Soluta quisquam itaque.", 60, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 16, 0, 0, 0), "Omnis repudiandae mollitia aut expedita qui quibusdam voluptas.", 39, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 12, 0, 0, 0), "Blanditiis qui dolores vel inventore voluptatem esse.", 67, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 16, 0, 0, 0), "Voluptatem vitae aperiam earum cupiditate nihil.", 55, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 17, 0, 0, 0), "Magnam qui dolores quo cupiditate et non odit odio.", 53, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), "Asperiores numquam temporibus ipsam quo nesciunt voluptas rem doloribus.", 91, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local), 16, "Adipisci architecto qui.", 85, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 13, 0, 0, 0), "Impedit laboriosam cum dicta asperiores odio.", 79, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), "Nesciunt ab blanditiis iusto.", 72, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 13, 0, 0, 0), "Nobis aliquid distinctio.", 68, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 10, 0, 0, 0), "Perspiciatis est sunt recusandae veritatis ea harum.", 56, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 9, 0, 0, 0), "Exercitationem rerum magni molestiae distinctio magni quia dolor.", 75, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 16, 0, 0, 0), "Ea id eligendi aut suscipit reiciendis inventore aperiam quis.", 13, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 0, 0, 0), "Dolore dolorem dolorem amet quia enim.", 75, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 9, 0, 0, 0), "Qui quia in dolore dignissimos et.", 27, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), "Voluptatem perferendis distinctio quidem esse.", 8, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), 6, "Autem vero et mollitia assumenda inventore.", 49, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 13, 0, 0, 0), "Harum ea aliquid quia.", 44, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), 17, "Quibusdam quos mollitia consequatur saepe vero.", 90 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 9, 0, 0, 0), "Molestias qui qui iste provident suscipit et soluta.", 76, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 13, 0, 0, 0), "Et voluptatum neque a cupiditate quos enim occaecati autem.", 11, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 11, 0, 0, 0), "Saepe iure ipsa dolorum dignissimos quia fugit et.", 65, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 0, 0, 0), "Deserunt libero eum reiciendis.", 90, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 10, 0, 0, 0), "Ullam excepturi maxime dignissimos.", 5, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 17, 0, 0, 0), "Dolores culpa id nemo recusandae eaque.", 30, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 12, 0, 0, 0), "Dolor voluptas quos.", 60, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 9, 0, 0, 0), "Esse qui error ut est sit vero.", 58, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 15, 0, 0, 0), "Enim ut et.", 76, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 17, 0, 0, 0), "Nulla quo illum cum autem iste magnam omnis odio quis.", 87, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 9, 0, 0, 0), "Nam amet est impedit.", 27, new TimeSpan(0, 8, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 18, 0, 0, 0), "Soluta voluptatum iusto voluptatem rerum sint enim aut et assumenda.", 42, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 9, 0, 0, 0), "Maiores iure excepturi.", 3, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 17, 0, 0, 0), "Eum consequatur consequatur velit aut omnis.", 67, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Ipsam quaerat autem.", 1, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 17, 0, 0, 0), "Nostrum tempora qui.", 57, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), "Sequi optio rerum quibusdam ratione aperiam magnam.", 25, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Non et possimus.", 44, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), "Autem minus sint non sed.", 57, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 15, 0, 0, 0), "Laborum laborum consectetur nesciunt exercitationem.", 60, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 14, 0, 0, 0), "Ut vero qui quia minus numquam minima.", 101, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Molestiae laudantium quia deleniti mollitia iure est.", 56, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 14, 0, 0, 0), "Sapiente ab praesentium.", 26, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 11, 0, 0, 0), "Nihil neque praesentium quasi omnis quo.", 36, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), "Culpa cum laboriosam.", 69, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 11, 0, 0, 0), "Modi ut exercitationem quisquam.", 44, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 16, 0, 0, 0), "Occaecati quasi sit est repellat quo sit.", 65, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 16, 0, 0, 0), "Cumque dolore blanditiis omnis aliquid ea.", 35, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 10, 0, 0, 0), "Illo id aut labore natus.", 71, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 12, "Modi soluta expedita consequatur aliquam et aut consectetur deleniti.", 55, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), "Odit dolor perferendis.", 73, new TimeSpan(0, 9, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 11, 0, 0, 0), "Aut error assumenda nam quis natus quaerat temporibus est quo.", 85, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), "Voluptatem sed quo.", 79, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 18, 0, 0, 0), "Tenetur quos mollitia ab repellendus veniam consequatur aut accusamus eos.", 17, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 9, 0, 0, 0), "Odio accusantium perferendis necessitatibus.", 17, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 0, 0, 0), "Qui deleniti quia.", 3, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 14, 0, 0, 0), "Quasi aut possimus eligendi explicabo eveniet.", 24, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 15, 0, 0, 0), "Enim quia temporibus assumenda.", 40, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 18, 0, 0, 0), "Porro et ipsa.", 30, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 16, 0, 0, 0), "Quisquam quo quo excepturi aut et esse in.", 94, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 15, 0, 0, 0), "Est accusamus et quas dolore.", 99, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), 3, "Sed aut odit voluptatem voluptate qui laudantium id ut.", 72, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 15, 0, 0, 0), "Quis atque hic quos voluptatem magni temporibus non similique debitis.", 81, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 14, 0, 0, 0), "Similique et non deserunt qui omnis reiciendis nihil voluptatem enim.", 74, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), 11, "Deserunt dolore eveniet temporibus aperiam libero impedit ea ut.", 38 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), "Occaecati consectetur sit quisquam nihil aut.", 13, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Qui blanditiis occaecati et occaecati sed aut aut quo occaecati.", 82, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 15, 0, 0, 0), "Et natus rerum dolor dicta aut.", 53, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Nihil aut eos quisquam molestiae natus.", 61, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 17, 0, 0, 0), "Cupiditate dolorum dolorem.", 95, new TimeSpan(0, 16, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 14, 0, 0, 0), "Quisquam earum omnis praesentium ab qui qui culpa necessitatibus.", 6, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 9, 0, 0, 0), "Sint dolore aut quas odio et laboriosam consequatur quia quia.", 68, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 10, 0, 0, 0), "Necessitatibus voluptatem doloribus.", 45, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), 20, "Incidunt fugit recusandae.", 59 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), "Inventore repudiandae qui eaque sed repellendus temporibus recusandae perferendis.", 52, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 10, 0, 0, 0), "Accusantium perspiciatis neque sint.", 59, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 12, 0, 0, 0), "Beatae distinctio explicabo et atque exercitationem et nobis ipsa.", 81, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 13, 0, 0, 0), "Possimus id odio aliquid nihil.", 81, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 12, 0, 0, 0), "Quas accusamus consequuntur blanditiis expedita quo hic perferendis corporis.", 78, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), 20, "Sed dolor sunt aperiam illo.", 43, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 14, 0, 0, 0), "Eius et sequi incidunt blanditiis rerum delectus suscipit.", 15, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AppointmentDate", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Perspiciatis ipsa ut amet voluptates dolorum consequatur.", 38, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), "Velit ipsum aut ex atque pariatur sed.", 5, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 9, 0, 0, 0), "Et sed aut et dicta ullam temporibus sit possimus tempora.", 80, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), "Cumque aut consequuntur.", 27, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 12, 0, 0, 0), "Ut in eaque sit praesentium officia consequatur.", 92, new TimeSpan(0, 11, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), 13, "Soluta qui architecto et.", 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 11, "Sapiente similique distinctio.", 35, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), "Quo minima sed.", 54, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Thần kinh", 4, 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Thần kinh", 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Đa khoa", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Thần kinh", 4, 10 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Thần kinh", 4, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Nhi khoa", 5, 9 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Đa khoa", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Tim mạch", 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "About", "Specialization" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Da liễu", 3 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Tim mạch", 10 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Thần kinh", 4, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Tim mạch", 2, 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Thần kinh", 4, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 3 năm trong lĩnh vực Da liễu", 3 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Tim mạch", 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Thần kinh", 4, 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Tim mạch", 2, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Thần kinh", 4, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Đa khoa", 1, 10 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Da liễu", 9 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa9503e7-33dd-48fa-ac54-97e3b1a41f05", "AQAAAAIAAYagAAAAEOkKxF3qSnH3nIGGyP0je6OQ0jeqr2VTF0ylaRCAfN0D3b1uHuXHQ1vPEIbvhCRnjQ==", "78498c48-d98f-4475-9152-ea32560fe99c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "586 Ðạt Hòa Ports", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trương Khải Ca", "4738c2df-9703-4adf-8ffb-f2773d343924", new DateTime(2020, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "LeKhanh_Vu62@hotmail.com", "Trương Khải Ca", 1, "LEKHANH_VU62@HOTMAIL.COM", "LEKHANH_VU62@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAHGsS9TKa/Njb8fjB37b2DcXOKKGPYKVNW/f0aCGcep2WKwjnq7z2UJ8S/wHhxagQ==", "023 4506 0422", "59f7c2ef-2916-4890-a999-62dda63a6647", "LeKhanh_Vu62@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "97345 Hồng Phúc Forks", "https://placehold.co/250/2D2D2D/ffffff.png?text=Hoàng Thanh Thảo", "e08f5fd5-166b-418f-bf8b-edf2a1a509b6", new DateTime(2018, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "BaoTran.Nguyen80@yahoo.com", "Hoàng Thanh Thảo", 1, "BAOTRAN.NGUYEN80@YAHOO.COM", "BAOTRAN.NGUYEN80@YAHOO.COM", "AQAAAAIAAYagAAAAEOpHVxVEEIgIxwD91yBxxq3gRNRuYEF1ZW1Mmjc4mZCGEGsYBFiYSBSnbmVGI2oIYQ==", "0216 6651 8260", "ba7a9363-79f6-426f-bcd8-63fa542d5e44", "BaoTran.Nguyen80@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5073 Hòa Giang Mill", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đinh Thi Xuân", "58b48fa1-279e-4d3e-b976-929a3192f62c", new DateTime(2002, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "AnhHoa_Dang@hotmail.com", "Đinh Thi Xuân", 2, "ANHHOA_DANG@HOTMAIL.COM", "ANHHOA_DANG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHxWzw1030oqjNfCLbkdg/8Dbqy6Hux7kAqIx+WZOSk4zu/GgR+z35Occp2wPRn3zw==", "0258 1429 9964", "02999801-7ee2-4073-b33e-6dffeaf7a44a", "AnhHoa_Dang@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0311 Tuệ Mẫn Mall", "https://placehold.co/250/2D2D2D/ffffff.png?text=Tăng Như Bảo", "72bbb43c-390a-42b0-b939-e591a941800c", new DateTime(2012, 2, 23, 0, 0, 0, 0, DateTimeKind.Local), "NgocTram8@yahoo.com", "Tăng Như Bảo", "NGOCTRAM8@YAHOO.COM", "NGOCTRAM8@YAHOO.COM", "AQAAAAIAAYagAAAAEBVghSBs25gKyTg7hCL3eLxrOA+ULkMZYoQXhnXbzWHSbe9kpYYLpBu6d4pKbgHLJg==", "027 5845 3202", "934ca5ab-71b1-4d37-9418-e725941f01d8", "NgocTram8@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "876 Ðăng An Point", "https://placehold.co/250/2D2D2D/ffffff.png?text=Hoàng Việt Nhân", "3993c0c9-f799-489c-8b61-fd9250547ca4", new DateTime(2018, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "DuyKhiem.Trinh@hotmail.com", "Hoàng Việt Nhân", 3, "DUYKHIEM.TRINH@HOTMAIL.COM", "DUYKHIEM.TRINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAEC9FQ7eO/BkvCFn1BpvymYgXaAufQziAvxB4cwtPxh+cVrvoy1qKNEijaW9ToKd6XA==", "024 0631 9404", "68b66e6e-ca2d-4130-8ed0-5e66d81ee7ce", "DuyKhiem.Trinh@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4749 Thượng Thuật Knoll", "https://placehold.co/250/2D2D2D/ffffff.png?text=Phan Vĩnh Toàn", "8224f0fe-5c59-4811-a616-764a67b8d9bc", new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "PhuocAn.To31@gmail.com", "Phan Vĩnh Toàn", 2, "PHUOCAN.TO31@GMAIL.COM", "PHUOCAN.TO31@GMAIL.COM", "AQAAAAIAAYagAAAAEIJesEjE3SAMOlQk2BzWkmSg89uWVTZ0Kf5XMKIv94/T/cJCmNQhsPUDUyxZGLUUYA==", "026 4437 2026", "369e9a86-8946-4674-a1ae-f0c01cce0b83", "PhuocAn.To31@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "763 Gia Bạch Alley", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đào Thế Lực", "2a31df9d-f6df-4725-89b3-082a878f2e2a", new DateTime(2007, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "XuanTuong_Doan43@hotmail.com", "Đào Thế Lực", 3, "XUANTUONG_DOAN43@HOTMAIL.COM", "XUANTUONG_DOAN43@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDbHIvYLNjhszzxVp0PRDAud/t0WIC4z1tzdWBsx+JAYFGGOgB8/aX1TkEY0t6NYmg==", "028 6324 9520", "8d840056-d2b1-438d-9ccd-d4d6bf37664e", "XuanTuong_Doan43@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1125 Thục Anh Well", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đinh Vinh Quốc", "ae2da3c5-4b90-4f85-895f-10c924e9c046", new DateTime(2012, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "XuanHan.Dinh80@hotmail.com", "Đinh Vinh Quốc", "XUANHAN.DINH80@HOTMAIL.COM", "XUANHAN.DINH80@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJiHCmRf55RmKJli22EwPnmo2JbqBUYBWAoHoOGPnYfFvuDcQhFbpgVF71TaGtDQjA==", "0296 5515 6785", "b45ba982-e9f3-4844-a477-c22c4080208f", "XuanHan.Dinh80@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "968 Ánh Dương Trace", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đinh Thụy Uyên", "6fbdac80-3099-4291-8e19-36596aadb607", new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), "LinhChau90@yahoo.com", "Đinh Thụy Uyên", 1, "LINHCHAU90@YAHOO.COM", "LINHCHAU90@YAHOO.COM", "AQAAAAIAAYagAAAAEEqS8BIYBztoBvDQttwoJuBTnWpaObI0kdp7cgmkox3sOvLZxDsS0JSxRDsb9TRyPA==", "022 8897 2727", "985e0122-4bfb-489b-8856-c7b20e10860b", "LinhChau90@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "34707 Minh Châu Tunnel", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trịnh Hải Thanh", "cd63869a-e0b0-4d1b-acba-267e46dc8c45", new DateTime(2006, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), "CongHau27@gmail.com", "Trịnh Hải Thanh", 1, "CONGHAU27@GMAIL.COM", "CONGHAU27@GMAIL.COM", "AQAAAAIAAYagAAAAEGEYE8EL/MPw9nuucso5fJ5vO3t3I+YjIFfOMDyCQe18PTr1PkbP3RzDztE/BjPIiw==", "0209 0774 5017", "adf6bb57-1fc2-4188-99cf-ba7f2d10fbe6", "CongHau27@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0440 Bạch Mai Fords", "https://placehold.co/250/2D2D2D/ffffff.png?text=Lâm Viễn Thông", "8e54c812-63c1-40a3-a2a6-eda03922e58e", new DateTime(2009, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), "TuyetMai.Ho0@gmail.com", "Lâm Viễn Thông", 1, "TUYETMAI.HO0@GMAIL.COM", "TUYETMAI.HO0@GMAIL.COM", "AQAAAAIAAYagAAAAEPvC7nNqh3vICCdAp3MEdyr7ND70SOs9YWSSWEtUejvuKQ561fBcfWE9xiNDweX5Iw==", "020 8588 5467", "fb047354-8abb-49b8-9ed9-593a481426f8", "TuyetMai.Ho0@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3524 Tân Long Lane", "https://placehold.co/250/2D2D2D/ffffff.png?text=Lâm Quang Bửu", "95901e67-ad70-46bf-a0b5-c43895297231", new DateTime(2015, 3, 13, 0, 0, 0, 0, DateTimeKind.Local), "PhuongLoan.Ngo44@yahoo.com", "Lâm Quang Bửu", "PHUONGLOAN.NGO44@YAHOO.COM", "PHUONGLOAN.NGO44@YAHOO.COM", "AQAAAAIAAYagAAAAEBGylPwQSZ+V8h1yyAIjgujj45wp3YRzG8gErM9mlm4L+lagWmrbBIMb7vTeP64pgQ==", "022 3446 5692", "cf23abc7-3809-4f36-9882-123b2f988600", "PhuongLoan.Ngo44@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "51378 Quế Lâm Pike", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đào Thanh Thế", "eef28f60-1b6f-4f2e-b66f-ddc801cfacdf", new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), "LienPhuong_Trinh80@gmail.com", "Đào Thanh Thế", 1, "LIENPHUONG_TRINH80@GMAIL.COM", "LIENPHUONG_TRINH80@GMAIL.COM", "AQAAAAIAAYagAAAAECe0eAXL3P8Kt6CRexRtqeRuq92ovfxu11z4FVLaV5IXG5AWeHANxxXsRIp3l57cNQ==", "0220 8903 3414", "9c199843-e93f-436f-bef3-31d7b183f8c0", "LienPhuong_Trinh80@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8522 An Nam Drives", "https://placehold.co/250/2D2D2D/ffffff.png?text=Tăng Chuẩn Khoa", "bb0c78a3-2254-4201-8532-41ffbf998e09", new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "VietThanh.Bui@gmail.com", "Tăng Chuẩn Khoa", 1, "VIETTHANH.BUI@GMAIL.COM", "VIETTHANH.BUI@GMAIL.COM", "AQAAAAIAAYagAAAAEFbrPbqwW7UgXyDeGP4jzbzor32Vb0uKOP90ve4VF4wcJHPMT3sH/avSPPUL2pzUpw==", "0229 9770 1837", "1e0dba5c-d25e-4000-af57-62c52ca4ad47", "VietThanh.Bui@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3971 Phan Groves", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đặng Phương Linh", "f6acdc27-3add-4e3b-8180-95e1fb964ccd", new DateTime(1995, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "ThanhLoi.Doan64@gmail.com", "Đặng Phương Linh", 2, "THANHLOI.DOAN64@GMAIL.COM", "THANHLOI.DOAN64@GMAIL.COM", "AQAAAAIAAYagAAAAEB7DDF9Pi8K/Ap8fmS7wn0EJu6f2LnK3oafggx1VTeDurEz8UKky5Lc/uet9fOSQVw==", "024 0678 1791", "aef672e9-c1eb-4321-a08b-8a8ad6f1efb8", "ThanhLoi.Doan64@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8551 Hồ Camp", "https://placehold.co/250/2D2D2D/ffffff.png?text=Vương Hiếu Thông", "f2274263-6889-44d8-9cc7-235a62b35d7f", new DateTime(2008, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "VietNgoc16@gmail.com", "Vương Hiếu Thông", 2, "VIETNGOC16@GMAIL.COM", "VIETNGOC16@GMAIL.COM", "AQAAAAIAAYagAAAAEHwlitb9fym85x9jJfNo0dvkOeVgFg8n3Cc2VEP+oCqeJhrPRn1QH1klRQm8FddkOA==", "026 5027 6134", "fe67471f-c243-4354-aa97-c5af408f790f", "VietNgoc16@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "90043 Mộng Quỳnh Club", "https://placehold.co/250/2D2D2D/ffffff.png?text=Hoàng Yên Ðan", "dc0ae96a-7d24-4ac9-b34b-a5e991d7b1d1", new DateTime(2006, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "TuyLoan.Bui40@yahoo.com", "Hoàng Yên Ðan", 1, "TUYLOAN.BUI40@YAHOO.COM", "TUYLOAN.BUI40@YAHOO.COM", "AQAAAAIAAYagAAAAEI6V8D1tE//fWBVa240VxVFciyEf/NQn2bCkZoTS372GZ+alc8QYkFttdDZPYjXxCQ==", "023 7075 6014", "e25c1a64-11f5-46ac-8674-613781119949", "TuyLoan.Bui40@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "77553 Cam Thảo Glen", "https://placehold.co/250/2D2D2D/ffffff.png?text=Phùng Tuyết Hồng", "b95444a4-90b3-4d65-86fb-bdef47191cbf", new DateTime(2005, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "ChiKien44@gmail.com", "Phùng Tuyết Hồng", 1, "CHIKIEN44@GMAIL.COM", "CHIKIEN44@GMAIL.COM", "AQAAAAIAAYagAAAAEEwAOm8zIUj0SWLQQWhcIX2rzHQGzGPbHKwXagCi/1R5+WlVvvpxanCfqJY5Bf11vg==", "020 3016 0696", "db091861-8238-4879-aeda-110629e78a9e", "ChiKien44@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4201 Bùi Spurs", "https://placehold.co/250/2D2D2D/ffffff.png?text=Ngô Ngọc Nhi", "fa77fa67-9821-450c-890b-e4757752ca51", new DateTime(2012, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), "ThienHung17@gmail.com", "Ngô Ngọc Nhi", 1, "THIENHUNG17@GMAIL.COM", "THIENHUNG17@GMAIL.COM", "AQAAAAIAAYagAAAAEK8/9FPI6XsIHoRn5bWZ0GO8J1R0UtYGN71PssVeeSoQZg/khQjHk22kUqoFqC2sOw==", "0249 8388 1878", "edd3770e-c09c-4888-9bdb-8b18a3e368b4", "ThienHung17@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "55089 Hương Chi Dale", "https://placehold.co/250/2D2D2D/ffffff.png?text=Bùi Bình Minh", "7c645f4a-45d6-4980-bd4c-2f8a636c67bb", new DateTime(1999, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "ChienThang_Vu@yahoo.com", "Bùi Bình Minh", 3, "CHIENTHANG_VU@YAHOO.COM", "CHIENTHANG_VU@YAHOO.COM", "AQAAAAIAAYagAAAAEKremyZUzTdCKINlRTOBz4LX4+YTyUAcEj1S1hkW0LHODbyCTbv6ILly0lZR01F5Rg==", "023 3458 9901", "bd1044b1-650b-423c-bfed-163a17f209d5", "ChienThang_Vu@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "68117 Tuyết Nhi Inlet", "https://placehold.co/250/2D2D2D/ffffff.png?text=Hà Diệu Lan", "947c9a02-09d0-4530-ba0e-6e17634e3989", new DateTime(2012, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "PhiHai96@hotmail.com", "Hà Diệu Lan", "PHIHAI96@HOTMAIL.COM", "PHIHAI96@HOTMAIL.COM", "AQAAAAIAAYagAAAAENNBYQj+J6KY7MO+AUuSQWo6FbOQMYTJUtbIAj46W0/XbENKn0R31xjEw/OzxbnVDQ==", "0235 0193 5374", "237135a1-8b1d-4432-98f7-e06557ab8940", "PhiHai96@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9538 Đào Shoal", "https://placehold.co/250/2D2D2D/ffffff.png?text=Ngô Kiều Hạnh", "1541127d-9ae4-49ca-b58f-8064054c5083", new DateTime(1998, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "MyHuong.Duong47@gmail.com", "Ngô Kiều Hạnh", "MYHUONG.DUONG47@GMAIL.COM", "MYHUONG.DUONG47@GMAIL.COM", "AQAAAAIAAYagAAAAEPauJulku59wkgf+NxqppwAQTVn0rT8R+HCgrvujtTwZD9vgvX9Adw0cIKLNJLLO5A==", "0249 5815 6845", "ef3c2997-88d4-4907-8dbb-cc4ccbaf20e0", "MyHuong.Duong47@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "10349 Nguyễn Causeway", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đỗ Hùng Anh", "c1b3e705-9040-4b3a-81d7-519158d5fd57", new DateTime(2009, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), "NgocHoan_Do@yahoo.com", "Đỗ Hùng Anh", "NGOCHOAN_DO@YAHOO.COM", "NGOCHOAN_DO@YAHOO.COM", "AQAAAAIAAYagAAAAEBzQNPfpbzKaolEE4+GjFOXuwrWmKcm+cbP3kA/8r13bPtWU2J+H5iOwqU3be+tOng==", "026 5873 8267", "120987f9-d162-41fc-aef9-b0c0c1aeceee", "NgocHoan_Do@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "855 Hoàng Ford", "https://placehold.co/250/2D2D2D/ffffff.png?text=Lý Ngọc Quang", "955562c2-6dc0-4c62-b5f6-c48866c15fa0", new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), "ThoiNhiem10@gmail.com", "Lý Ngọc Quang", 1, "THOINHIEM10@GMAIL.COM", "THOINHIEM10@GMAIL.COM", "AQAAAAIAAYagAAAAECaev91rMW/yy3aByXcz+dI3nCE7bkuXqQ5QOuz77ryxZANKC8oiHrAYSZlMMhJ+TQ==", "0207 2564 3376", "e1f5185f-fe3d-4b2c-992d-c79f1b5d63bc", "ThoiNhiem10@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0606 Hà Bypass", "https://placehold.co/250/2D2D2D/ffffff.png?text=Tô Quang Lâm", "2261d856-e684-448c-8186-1560627440cd", new DateTime(2001, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "PhuongNga_Vu@yahoo.com", "Tô Quang Lâm", 1, "PHUONGNGA_VU@YAHOO.COM", "PHUONGNGA_VU@YAHOO.COM", "AQAAAAIAAYagAAAAEF+sjqaORYFVPKTC3sOZQOqmSQ65s3SzdJ4EgqOMr9fgcd2sjeVkRA9BIwDxJtesGw==", "0262 9819 1129", "bde58222-994b-4cdf-a1c1-a532a86650a7", "PhuongNga_Vu@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "29065 Kim Thu Ports", "https://placehold.co/250/2D2D2D/ffffff.png?text=Phạm Hiệp Hiền", "b5fcc801-487c-4d72-be85-b235d273b690", new DateTime(2005, 3, 30, 0, 0, 0, 0, DateTimeKind.Local), "UyenTram.Ngo@hotmail.com", "Phạm Hiệp Hiền", 1, "UYENTRAM.NGO@HOTMAIL.COM", "UYENTRAM.NGO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMjuJgaHxaDeha8c/HNVSt/rAawyV6lJaKr181feK2AS1D36XWoqRMlL2GaNNBcxJQ==", "0278 6426 8119", "ac8eace9-8ae4-49c0-bc36-55de9c1511d0", "UyenTram.Ngo@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "209 Như Hồng Tunnel", "https://placehold.co/250/2D2D2D/ffffff.png?text=Tăng Bích Nhã", "a27b8b85-f3c5-4d4a-894e-a57379a8eab1", new DateTime(2004, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "NhuKhang_Duong27@hotmail.com", "Tăng Bích Nhã", 3, "NHUKHANG_DUONG27@HOTMAIL.COM", "NHUKHANG_DUONG27@HOTMAIL.COM", "AQAAAAIAAYagAAAAEByRaenxOBx9SBoamyKDOzT/qpd3V+3KYJ0Dr8tklZhuH44WZEGSkH7vB5UJTb6bIA==", "027 0171 4465", "7ce97d27-c115-495c-9cdf-9f67f401d662", "NhuKhang_Duong27@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4891 Tăng Cape", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trương Kim Lan", "5c008dba-a1dc-4484-8213-4e4f74176da4", new DateTime(2015, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), "LongGiang29@yahoo.com", "Trương Kim Lan", 3, "LONGGIANG29@YAHOO.COM", "LONGGIANG29@YAHOO.COM", "AQAAAAIAAYagAAAAEI6ndBP9Xinjt8yyM4F4/DBUMMPe5rfOsBmdoHESM7QUN3KgD8yLVVd+9Z/hUs0iKQ==", "025 4790 5793", "ba20985e-865e-4e69-ab2f-d4518b631482", "LongGiang29@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "179 Hà Plain", "https://placehold.co/250/2D2D2D/ffffff.png?text=Lâm Thiện Mỹ", "c03fb835-242a-49cc-93fb-f385f13cda36", new DateTime(2005, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "AnhHoa73@yahoo.com", "Lâm Thiện Mỹ", "ANHHOA73@YAHOO.COM", "ANHHOA73@YAHOO.COM", "AQAAAAIAAYagAAAAECNOSo1x11K3Ty3SQKqxVqwXkJt09QpvBkxj/dll6yZDXpHeZ5akqs+2E7lIjaaljA==", "0200 2195 6805", "52ba6a28-0144-4e3e-9b11-654772246714", "AnhHoa73@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2171 Hoàng Flat", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đoàn Trang Tâm", "7abc1f65-cef9-4d10-a06e-519ccf8ec540", new DateTime(2016, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "LocUyen.To6@gmail.com", "Đoàn Trang Tâm", 2, "LOCUYEN.TO6@GMAIL.COM", "LOCUYEN.TO6@GMAIL.COM", "AQAAAAIAAYagAAAAENbaJ+Prt/wle9C0+25FPC0Tx43onQnQvq+ciMrjAWOPCVIcEECmPYaj10/lGQpDJg==", "0258 0649 1627", "f9957e10-50ee-4f98-be3e-f835af70c375", "LocUyen.To6@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0307 Bùi Track", "https://placehold.co/250/2D2D2D/ffffff.png?text=Phạm Kim Thông", "de3de128-8c53-4370-a4d4-78a1059fe451", new DateTime(2013, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "AnhDung.Mai41@yahoo.com", "Phạm Kim Thông", "ANHDUNG.MAI41@YAHOO.COM", "ANHDUNG.MAI41@YAHOO.COM", "AQAAAAIAAYagAAAAEJJwR/Ldel8PnpS1TVmvAraOibNiwvWwDjtgUM8cYWhcl2ChvKODs7tgWwKP7X/Rlg==", "024 7571 6309", "207a01f8-59fe-4aae-b3d3-731e99a504c0", "AnhDung.Mai41@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4252 Việt Trinh Mountain", "https://placehold.co/250/2D2D2D/ffffff.png?text=Ngô Hải Duyên", "f029a707-d75b-4537-8adf-18c3cf19254c", new DateTime(2006, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "DucBinh.Nguyen@gmail.com", "Ngô Hải Duyên", 3, "DUCBINH.NGUYEN@GMAIL.COM", "DUCBINH.NGUYEN@GMAIL.COM", "AQAAAAIAAYagAAAAENS53InkI7j9FzuPUmCDcSxEuEC97YgIvrxo8BMELz5tlWUSsaIUsEoWNaGSQtHPaA==", "023 0860 3355", "6495e9dd-3311-486d-8136-59809aa919f1", "DucBinh.Nguyen@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "641 Dương Lake", "https://placehold.co/250/2D2D2D/ffffff.png?text=Dương Kiều Nguyệt", "caadabd6-3ea5-440c-a33e-aac81bb59041", new DateTime(2011, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "SonGiang_Tran85@hotmail.com", "Dương Kiều Nguyệt", "SONGIANG_TRAN85@HOTMAIL.COM", "SONGIANG_TRAN85@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGZERNNrZLlLNHNPGsFl9dMyXHqFFbleD/KIlZV9nnitQJmV0ZRS81O7YxeAswRRyg==", "028 3982 4104", "7c2edc82-ee63-415a-8c7c-b34eabd6550e", "SonGiang_Tran85@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7919 Vân Tiên Harbor", "https://placehold.co/250/2D2D2D/ffffff.png?text=Phan Thiên Ân", "efe22083-3a47-44f2-a3d2-b5d770357609", new DateTime(2003, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "DinhSang.Ha82@gmail.com", "Phan Thiên Ân", "DINHSANG.HA82@GMAIL.COM", "DINHSANG.HA82@GMAIL.COM", "AQAAAAIAAYagAAAAECxp4Sr6CwgY9pC37ofBBbVEMb/2o/jweGrM46Fpyj7kJgOjQRs96Rl2XF5SYhgvSg==", "023 3137 2161", "c5e29507-2911-45dd-855c-05b83311d52b", "DinhSang.Ha82@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "276 Trần Creek", "https://placehold.co/250/2D2D2D/ffffff.png?text=Mai Vân Trang", "d1b3caf1-60ab-4b9c-866c-69ab100dabe5", new DateTime(1999, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "DiemHang62@yahoo.com", "Mai Vân Trang", 2, "DIEMHANG62@YAHOO.COM", "DIEMHANG62@YAHOO.COM", "AQAAAAIAAYagAAAAECMNa+IgGEfVKW7DXamWQar2cgvioduxmCdW1Rvikvh2AGp/RlMJ807/1f9Z/DAI+w==", "027 5423 2540", "68513326-f3d5-42e7-8b07-d722d95d545e", "DiemHang62@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4624 Hồ Trafficway", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đoàn Hoàng Mỹ", "405c555d-932b-4e4a-a451-e9d407430a47", new DateTime(1996, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "ThuyHang_Tang@yahoo.com", "Đoàn Hoàng Mỹ", 1, "THUYHANG_TANG@YAHOO.COM", "THUYHANG_TANG@YAHOO.COM", "AQAAAAIAAYagAAAAEOrLK6neQRUb+mi16u8rlwt9PIMZszsH2MvVMy/ul8ZUcJBDIIdWcSNDzJ3S2nn5ww==", "023 0315 9431", "f1843586-f422-4da5-8622-c40f6d204b7c", "ThuyHang_Tang@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5118 Tâm Nguyệt Isle", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trịnh Thiên Nga", "fe316f98-0b97-4747-8fa6-1ad80120a459", new DateTime(1998, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), "HuuDat.Nguyen@gmail.com", "Trịnh Thiên Nga", 2, "HUUDAT.NGUYEN@GMAIL.COM", "HUUDAT.NGUYEN@GMAIL.COM", "AQAAAAIAAYagAAAAEPpIhGf0kzhjBcOiSH3WwsJ5W88+6BvBiwZaH8sIFKyx1NRP+tGFGHb5cokA/OTw9w==", "023 6083 7537", "86370ce5-eecc-482d-a85a-33a29726e1e4", "HuuDat.Nguyen@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "262 Vũ Springs", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đào Phương Thủy", "647e9939-e9d6-4c6d-9908-acb2e9e04a21", new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "ThuVan51@hotmail.com", "Đào Phương Thủy", 3, "THUVAN51@HOTMAIL.COM", "THUVAN51@HOTMAIL.COM", "AQAAAAIAAYagAAAAEOk+SZEaBDQCKPYKR/tIWTx3bmd4ve65I5+cbkevf7mZujb8a1GjF2NPW99yeoNIyg==", "0218 9023 1026", "81123917-2b83-4e1a-a241-643c93e2e03b", "ThuVan51@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "80000 Ngô Mountains", "https://placehold.co/250/2D2D2D/ffffff.png?text=Phạm Kỳ Diệu", "64afb052-0b57-48d8-8d61-04f2d7018613", new DateTime(2015, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "VanHanh_Dao@gmail.com", "Phạm Kỳ Diệu", "VANHANH_DAO@GMAIL.COM", "VANHANH_DAO@GMAIL.COM", "AQAAAAIAAYagAAAAEALqWJWgn5Jt2J83d+UFkzjBSkN+dU+Q49LHSWFTyVQceDcrJ7Aq0zB6YVtMSA5RdQ==", "0203 7857 6132", "7073a60d-ac4b-4f71-b9a2-e93195fe98cf", "VanHanh_Dao@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "995 Phan Stravenue", "https://placehold.co/250/2D2D2D/ffffff.png?text=Phạm Ðức Sinh", "bbd68392-8bce-442d-ab31-2409ab6064dc", new DateTime(1995, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "ThieuMai.Ho@hotmail.com", "Phạm Ðức Sinh", 3, "THIEUMAI.HO@HOTMAIL.COM", "THIEUMAI.HO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPguGOAaJSG9NOxGBwr5Rj/RFHR/lnONMbLNEiee3leMH04wA5u7nn7yz9LcisGegA==", "027 4568 6334", "ce002bdd-e75e-42c8-b668-8e786ffb75dc", "ThieuMai.Ho@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "748 Mai Prairie", "https://placehold.co/250/2D2D2D/ffffff.png?text=Nguyễn Thục Ðoan", "11842015-0e58-465a-aa1d-b76897a138d9", new DateTime(2009, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "BichHanh.Bui80@yahoo.com", "Nguyễn Thục Ðoan", 2, "BICHHANH.BUI80@YAHOO.COM", "BICHHANH.BUI80@YAHOO.COM", "AQAAAAIAAYagAAAAENd1vsGNu/faPyGHgEN3ZreceUTqtvseUyTtWcAP9PbZUtkV5AOAF3tlwkeurShg9Q==", "0205 7981 8662", "adb6514c-1642-40e7-800a-01700272a887", "BichHanh.Bui80@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "95463 Lam Ngọc Summit", "https://placehold.co/250/2D2D2D/ffffff.png?text=Hoàng Kim Hương", "787c1c3e-a04b-46ee-ae31-371ae68a194d", new DateTime(2000, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "ToTam47@gmail.com", "Hoàng Kim Hương", 2, "TOTAM47@GMAIL.COM", "TOTAM47@GMAIL.COM", "AQAAAAIAAYagAAAAEGIVWJuCI6psNdGsVkhtfVVOzhK8FVYNHXvcac5xWw23oLr65OoyQwa7C4QKtQMVCw==", "021 2152 9054", "e7ae7663-e67f-4fdc-b801-79715f09eed2", "ToTam47@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "139 Tô Falls", "https://placehold.co/250/2D2D2D/ffffff.png?text=Tô Thanh Vinh", "43e6b76f-d242-46e2-8402-69e3313fb094", new DateTime(2013, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "ThanhHa0@hotmail.com", "Tô Thanh Vinh", 1, "THANHHA0@HOTMAIL.COM", "THANHHA0@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKOwiLS8J0GW422GqAJhPVGkOhmS3P5iQidn4y96/wg6uYDkht6prSQpatWvqKA4GQ==", "027 0263 1605", "668d1c63-bdcc-4806-9e8c-eda1e756a841", "ThanhHa0@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "066 Đào Heights", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đoàn Hải Duyên", "9a0884c5-066e-48ee-bde2-6d9fc6ce4c70", new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), "KimKhuyen97@yahoo.com", "Đoàn Hải Duyên", "KIMKHUYEN97@YAHOO.COM", "KIMKHUYEN97@YAHOO.COM", "AQAAAAIAAYagAAAAEC4xCEU9AXcmu51YXZwvqCKZZMffCWV/tBQ5CUD3Gl2oHssqsZW1gg1jhwuGGDnUxQ==", "0240 7548 1036", "3a4cadf6-3629-4cda-b3fa-c7acb33de13b", "KimKhuyen97@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "12377 Trang Nhã Grove", "https://placehold.co/250/2D2D2D/ffffff.png?text=Lý Viết Nhân", "61b84228-e6e2-4401-bea3-cb832110535d", new DateTime(2005, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "NguyenNhan1@gmail.com", "Lý Viết Nhân", "NGUYENNHAN1@GMAIL.COM", "NGUYENNHAN1@GMAIL.COM", "AQAAAAIAAYagAAAAEBaJ3l6pnPmW817oNRDRuv8T4IhTso5egVo0+B0EdZGcprJhBr5n67TMrH78gIOVlg==", "027 0590 8405", "45f83007-b5a7-48e0-b9c8-d2f7e03e422a", "NguyenNhan1@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8127 Lâm Mews", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trần Linh Nhi", "d0a473a3-916c-49f0-9296-46d06b778806", new DateTime(2009, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "HoaiGiang_Phung@gmail.com", "Trần Linh Nhi", "HOAIGIANG_PHUNG@GMAIL.COM", "HOAIGIANG_PHUNG@GMAIL.COM", "AQAAAAIAAYagAAAAEFdHhlgpYA4Y2yfehJKRiicutaIaPb4cjNtpI/jwHfNUSmq4wPxS4D7ftBSuE30s3A==", "0219 2825 0550", "072081e4-d760-47fc-bebd-20dff312dcca", "HoaiGiang_Phung@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "628 Khả Ái Walk", "https://placehold.co/250/2D2D2D/ffffff.png?text=Lê Minh Phương", "dc602579-9846-4d29-9316-7d2f72b4cdb3", new DateTime(2009, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), "QuangTai_Lam16@yahoo.com", "Lê Minh Phương", 2, "QUANGTAI_LAM16@YAHOO.COM", "QUANGTAI_LAM16@YAHOO.COM", "AQAAAAIAAYagAAAAEC49daoWf5YTikt5a5uy8H6dYs7AanB4QLcAKiOE9eSD181N8jYJx+igyFO1oRJ77w==", "023 4107 9225", "51851b5d-2f60-4cb1-86de-8c346c9bdb02", "QuangTai_Lam16@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8340 Tăng Port", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đoàn Kim Quyên", "6f3e8907-c109-4316-ad37-dff1da2fd2aa", new DateTime(1999, 3, 14, 0, 0, 0, 0, DateTimeKind.Local), "HoangSa.Lam97@yahoo.com", "Đoàn Kim Quyên", 3, "HOANGSA.LAM97@YAHOO.COM", "HOANGSA.LAM97@YAHOO.COM", "AQAAAAIAAYagAAAAEA4KhGt/olJckN00jBNY11ZvuL83wPATAdIG43vdU8nm+2LyMzgklQ/wzZsF1khf2g==", "0291 6005 2822", "14dc6985-bdb9-4e72-947e-2dd040190b86", "HoangSa.Lam97@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "718 Vũ Lane", "https://placehold.co/250/2D2D2D/ffffff.png?text=Dương Bảo Phương", "97a75f85-7c2d-4db0-9453-b318f4e0b03c", new DateTime(2005, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), "TuNguyet.Le@gmail.com", "Dương Bảo Phương", 3, "TUNGUYET.LE@GMAIL.COM", "TUNGUYET.LE@GMAIL.COM", "AQAAAAIAAYagAAAAENm+8df32DEAyCZ4RloDzf5M52NN9/yRvR56WwMBQdTtA8ra42IC26y58ryQYqJr+Q==", "022 6737 2978", "db1c5485-ef08-4ea5-b429-689affbe3a8f", "TuNguyet.Le@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "74576 Tăng Fork", "https://placehold.co/250/2D2D2D/ffffff.png?text=Tăng Cao Sĩ", "df7819d8-4f86-48b8-9ea4-f3fdf12990cb", new DateTime(2004, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "HongThuy91@gmail.com", "Tăng Cao Sĩ", 1, "HONGTHUY91@GMAIL.COM", "HONGTHUY91@GMAIL.COM", "AQAAAAIAAYagAAAAELGB1eMw2FCiq2yGbTrwg1+z+bUMI4V1zq6Ko513L7+CtPiuOMWfgooe/NztpTEQNw==", "0250 4484 7463", "cd6406a4-5331-41cb-9079-98e2c8fd67c2", "HongThuy91@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6355 Vũ Turnpike", "https://placehold.co/250/2D2D2D/ffffff.png?text=Nguyễn Hiền Chung", "4db074f5-3929-4bb0-9879-4cc6620d5c33", new DateTime(1999, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "HongThinh46@gmail.com", "Nguyễn Hiền Chung", 2, "HONGTHINH46@GMAIL.COM", "HONGTHINH46@GMAIL.COM", "AQAAAAIAAYagAAAAEFOzAV6SyOorBXNkjxctgeLezmhI8VR9f+885yuqS5TSnlzaFrbcMBPShu4R09naNA==", "023 0445 9990", "c9968cf5-3639-4830-88b9-c2b17833be8f", "HongThinh46@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "429 Trịnh Way", "https://placehold.co/250/2D2D2D/ffffff.png?text=Dương Kim Thư", "74bc14fb-b92e-4be6-acbe-f42d60201287", new DateTime(2014, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "DucTuong.Phung65@hotmail.com", "Dương Kim Thư", 3, "DUCTUONG.PHUNG65@HOTMAIL.COM", "DUCTUONG.PHUNG65@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHLyldHZ39qnzBnpoF5V+mW8XJ+2zVbQCGMbYPeU8KtVxPj3X75veHZmVjrVUrQMFw==", "025 5786 2613", "710bb9d6-e50e-43a0-8917-e30fd0a98276", "DucTuong.Phung65@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "20024 Phan Branch", "https://placehold.co/250/2D2D2D/ffffff.png?text=Lê Thanh Hảo", "8f0c4dc4-a8a8-41d4-a4dd-2dcdb67678fa", new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "XuanPhuc_Hoang@yahoo.com", "Lê Thanh Hảo", 1, "XUANPHUC_HOANG@YAHOO.COM", "XUANPHUC_HOANG@YAHOO.COM", "AQAAAAIAAYagAAAAEJv5rsrfDauttamEfnxPjRgIJCL5+hHNA0azeb/G/0l2GUDQPjWFHziZVvH7pXNafA==", "0205 0992 6806", "bad0a31a-b8ff-43e3-966c-6554fba5781d", "XuanPhuc_Hoang@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4362 Mộng Long Knolls", "https://placehold.co/250/2D2D2D/ffffff.png?text=Lâm Công Hoán", "e3a2ae6f-3e5b-4a5a-881b-a32bb4507b7a", new DateTime(2008, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "ThucTrinh40@gmail.com", "Lâm Công Hoán", 2, "THUCTRINH40@GMAIL.COM", "THUCTRINH40@GMAIL.COM", "AQAAAAIAAYagAAAAEDBqErD6yDPNCsQggN7Jz3fJ1MrN336zZ8KoaztWVRiCRMm5roqoIGrAVDTMUa1x1A==", "029 8684 2657", "5b3d7a73-b099-4aae-8376-2d6f87237492", "ThucTrinh40@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1075 Lệ Hoa Springs", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đinh Thông Minh", "7691f637-e85b-41bc-b732-e2d32c6d12e0", new DateTime(1995, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "KienVan_Ha@yahoo.com", "Đinh Thông Minh", 1, "KIENVAN_HA@YAHOO.COM", "KIENVAN_HA@YAHOO.COM", "AQAAAAIAAYagAAAAEN+5BEJsTnKF++N0fyqCU5DRHFfFf53z2qzvdOP5bXJL24sBkfNlZiROV77K9hTaNA==", "021 6776 7862", "b5579b39-dc41-4b2d-9111-5711454a5d5a", "KienVan_Ha@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "817 Bùi Place", "https://placehold.co/250/2D2D2D/ffffff.png?text=Hà Chuẩn Khoa", "0711d297-446a-499c-a289-46a71ce1a727", new DateTime(2016, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), "AnNinh.Dao@hotmail.com", "Hà Chuẩn Khoa", 3, "ANNINH.DAO@HOTMAIL.COM", "ANNINH.DAO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJySW3/JJ5Nk6SCWc8M1fJWGXH9BzU3uyF1dASwihTTrL3iQ7o29ExF9Xkfnn246Ig==", "0222 1597 7365", "0f9cea83-f91f-436c-8be1-b8a7f9a89975", "AnNinh.Dao@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "37652 Dương Trafficway", "https://placehold.co/250/2D2D2D/ffffff.png?text=Mai Quang Dũng", "96c48333-cc6b-45c1-8ce2-94ad7c901508", new DateTime(1999, 1, 31, 0, 0, 0, 0, DateTimeKind.Local), "HaiPhuong_Pham65@gmail.com", "Mai Quang Dũng", 2, "HAIPHUONG_PHAM65@GMAIL.COM", "HAIPHUONG_PHAM65@GMAIL.COM", "AQAAAAIAAYagAAAAEMwkM94OrvOJtQR5MsLYo5z1su62IoOTkbuSDNGKIasdvoQ3OaUxB8I4MQOlvgq/9w==", "026 4402 8643", "b5cfe9ad-b31b-4305-b06d-907b916daaf2", "HaiPhuong_Pham65@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "306 Mộng Lâm Station", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trịnh Thu Sinh", "511af072-f287-4312-afb6-c62251fbcce2", new DateTime(2009, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "ThanhYen.Ngo@gmail.com", "Trịnh Thu Sinh", 2, "THANHYEN.NGO@GMAIL.COM", "THANHYEN.NGO@GMAIL.COM", "AQAAAAIAAYagAAAAEJuALieZkZA97aCSW5l55FXfUQEfJVB+wGi6Id6pwkS3odal719rUGLZyw6A3Pj1gg==", "029 0517 4852", "11980ced-7d56-476d-8b7c-3f6a492add91", "ThanhYen.Ngo@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "60054 Phi Long Pines", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đỗ Bạch Yến", "f3414b3e-84b9-43d5-98dc-b29eda44b6ee", new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "TinhNhu_Lam38@yahoo.com", "Đỗ Bạch Yến", 3, "TINHNHU_LAM38@YAHOO.COM", "TINHNHU_LAM38@YAHOO.COM", "AQAAAAIAAYagAAAAELMt2Wjo+7T5er82Ds3oLeze7BrzIhFJnGvHClK6KAc46Wk4hoomWw10nZpKT6vksA==", "025 2201 9332", "5ba9081d-9648-45e2-a87a-f219607f1306", "TinhNhu_Lam38@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "189 Trần Ridge", "https://placehold.co/250/2D2D2D/ffffff.png?text=Lý Trúc Linh", "4feb42bc-c6e7-48fa-a8e9-8cdd9a88b5cc", new DateTime(2005, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "KienVan_Pham@hotmail.com", "Lý Trúc Linh", "KIENVAN_PHAM@HOTMAIL.COM", "KIENVAN_PHAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIkhJctH5p2srz39z86sAzLutAwzNSjeJieWs8zo8G57G6hTeHDhtUB51o4ojCIwrw==", "020 2661 8176", "4ab405d0-3587-49f1-952c-f6b03f4b6df0", "KienVan_Pham@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "18059 Hồ Row", "https://placehold.co/250/2D2D2D/ffffff.png?text=Phạm Danh Nhân", "06e1ff84-d047-4377-9e0e-8fefeecc25a1", new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "BaoKhanh95@hotmail.com", "Phạm Danh Nhân", "BAOKHANH95@HOTMAIL.COM", "BAOKHANH95@HOTMAIL.COM", "AQAAAAIAAYagAAAAELtFkEOJjy6Zqf3IpelBFC7TFd0HZ5yPrVcXPWzmjqZz3qB0F1nuSy5PqdX7nO3xJA==", "026 5368 6943", "d94d504c-5cde-4796-98e5-90ef52e523a9", "BaoKhanh95@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "80793 Vũ Heights", "https://placehold.co/250/2D2D2D/ffffff.png?text=Bùi Vĩnh Thọ", "59a5ee80-91ea-4103-86b0-8e073b028a5b", new DateTime(2017, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "YenLoan42@yahoo.com", "Bùi Vĩnh Thọ", 2, "YENLOAN42@YAHOO.COM", "YENLOAN42@YAHOO.COM", "AQAAAAIAAYagAAAAELApStIYxe90jAvWbC85wuKcBMVHNlI7soYJp/Kug2ZQCYPe7VFzAar6cBqaSq8H/A==", "029 2394 0870", "d2e1737d-7f18-487e-933b-e8a8e13afb2d", "YenLoan42@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "432 Đinh Keys", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trương Uyên Thi", "9c83c675-117a-43fc-9276-05d491a77fe7", new DateTime(2012, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), "MinhHy.Vu68@gmail.com", "Trương Uyên Thi", 2, "MINHHY.VU68@GMAIL.COM", "MINHHY.VU68@GMAIL.COM", "AQAAAAIAAYagAAAAEMIHC5jlu5xPH4thbkDzsPWr727rqWzVLcc671kofb3giX4/pbyLwqAxqiZabkFSMw==", "0293 9726 7588", "73c25cdb-7de8-4cbf-8501-0ee529e8e4e2", "MinhHy.Vu68@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "778 Gia Hiệp Club", "https://placehold.co/250/2D2D2D/ffffff.png?text=Vương Hồng Tâm", "853ad2e7-a446-4a8d-847d-bd2017576186", new DateTime(2009, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "ThanhHieu_Dinh77@gmail.com", "Vương Hồng Tâm", "THANHHIEU_DINH77@GMAIL.COM", "THANHHIEU_DINH77@GMAIL.COM", "AQAAAAIAAYagAAAAENQGWluK4qUsCn7EY/QQBhO6zviBiKYvvkewbTSx1nKQrE6/1jtyuTlOOok9os6PJQ==", "0237 4645 8620", "84a8908d-efc4-4b8f-8b98-6f559751cb5a", "ThanhHieu_Dinh77@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "398 Phạm Park", "https://placehold.co/250/2D2D2D/ffffff.png?text=Tăng Hương Lâm", "5aa5e256-8f47-4c2e-8799-28f96a2936b6", new DateTime(2009, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "ThienTien84@gmail.com", "Tăng Hương Lâm", 2, "THIENTIEN84@GMAIL.COM", "THIENTIEN84@GMAIL.COM", "AQAAAAIAAYagAAAAEEUBujBhksquxx+uZYotMpRPjP1PnvlLD1rFZBdzZgfgJo3gB2r2ToaWizHELFTv2Q==", "025 9774 8614", "cbd8fed9-701b-4e5e-a161-584d9b92ccd0", "ThienTien84@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "74130 Thanh Ðạo Shoals", "https://placehold.co/250/2D2D2D/ffffff.png?text=Hà Thiên Thảo", "3faa1103-fa10-4891-84fe-709026a6869e", new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), "TrungLuc4@yahoo.com", "Hà Thiên Thảo", "TRUNGLUC4@YAHOO.COM", "TRUNGLUC4@YAHOO.COM", "AQAAAAIAAYagAAAAENYENcBgQauxb3T+yPKjsMu6YLR4iCUdVXe1CBKYpVf20EA347RFN4o2vPXaLmRvmA==", "0210 3119 5804", "381ea8cc-20c7-44e7-b3fe-0a988ebc45e1", "TrungLuc4@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8215 Phương Diễm Estate", "https://placehold.co/250/2D2D2D/ffffff.png?text=Tăng Thục Uyên", "fba97e9f-fe9d-4813-8e66-c434b6dcad9e", new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "NgocTru.Trinh@hotmail.com", "Tăng Thục Uyên", "NGOCTRU.TRINH@HOTMAIL.COM", "NGOCTRU.TRINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAEC4Jg9/VX+2+fGd+r3iS/TX0/yisy/uUfX4veGiuMERMDi9tM3YyvkIfKaky00nXNg==", "0244 4662 2785", "d468c206-21ea-4b7b-8f3d-609268daa6a9", "NgocTru.Trinh@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "51796 Tâm Hằng Passage", "https://placehold.co/250/2D2D2D/ffffff.png?text=Lý Ngọc Thơ", "6bd21cb8-0300-4463-8cbd-6214db1075ce", new DateTime(2006, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "DiNhien.Mai@hotmail.com", "Lý Ngọc Thơ", 2, "DINHIEN.MAI@HOTMAIL.COM", "DINHIEN.MAI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEPQsoALyLHQidQAkjUW8WEFRidv9QAIlUEkkjt2pedz3PCYUWlEDlg+s2i6EgTKpw==", "028 9199 2291", "063eda5f-7fbf-487c-bf83-d7bc253a69a2", "DiNhien.Mai@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7953 Cẩm Liên Valleys", "https://placehold.co/250/2D2D2D/ffffff.png?text=Vương Ý Bình", "acb14ce8-dc76-4880-8f3b-13c1e462eb3e", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "KhacKy.Duong52@hotmail.com", "Vương Ý Bình", 1, "KHACKY.DUONG52@HOTMAIL.COM", "KHACKY.DUONG52@HOTMAIL.COM", "AQAAAAIAAYagAAAAEN5yAVRjrSy4FaC73ahSltqtTwxERyKlI2ZcmjhF9An7IVRhkZzgi71kkxR4sumo5w==", "021 0878 6049", "85a286d3-9c35-4754-983e-c58fc11f533e", "KhacKy.Duong52@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6610 Ðắc Trọng Haven", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trần Từ Dung", "c7649108-0906-4f77-a0d7-08352df328d0", new DateTime(2017, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "VanLinh85@hotmail.com", "Trần Từ Dung", 3, "VANLINH85@HOTMAIL.COM", "VANLINH85@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJtc7qGhPFq2Bb39ApcqA+Qjga4xIBHk+1F5HghVWGFes1HJq/3BkR0OcGUkRJ2JNw==", "025 5426 3953", "16a66a5c-e8b6-49b3-8651-48a7f763b2c7", "VanLinh85@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "108 Mai River", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đinh Thụ Nhân", "8753cce0-269a-4abc-adeb-0d323de11948", new DateTime(2005, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "MyTrang73@yahoo.com", "Đinh Thụ Nhân", 1, "MYTRANG73@YAHOO.COM", "MYTRANG73@YAHOO.COM", "AQAAAAIAAYagAAAAECnJnakREDN8Rb5u82KbzponeUy3TUlK6jhIXjcb8wM5DV/EsrBgDRhHm4LsXw0Sew==", "0252 7751 7108", "e3301961-79b7-4fe2-9bfb-e6e03cc73220", "MyTrang73@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "132 Lê Village", "https://placehold.co/250/2D2D2D/ffffff.png?text=Lâm Vân Phi", "60e315cb-9caa-4ee0-bbb7-1f54066e0c3e", new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "TrongViet.Ly@gmail.com", "Lâm Vân Phi", 3, "TRONGVIET.LY@GMAIL.COM", "TRONGVIET.LY@GMAIL.COM", "AQAAAAIAAYagAAAAECijGArxAVG8Pv9tvYIwo+3bbCMfnuXY/chEJWss/TUkWm8WX66bmrgoeDaBGzJtrA==", "024 1830 7021", "57945595-083f-4f95-852a-a120eeaf2f35", "TrongViet.Ly@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "67049 Dương Neck", "https://placehold.co/250/2D2D2D/ffffff.png?text=Nguyễn Thanh Bình", "1b5c7e80-1385-4615-9807-0c580e34cf50", new DateTime(2011, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), "ThaiThao34@yahoo.com", "Nguyễn Thanh Bình", 2, "THAITHAO34@YAHOO.COM", "THAITHAO34@YAHOO.COM", "AQAAAAIAAYagAAAAEHor5Q4ommHyybBBnTOcuKz5evKPPgpyILZ5xVi0kNh6PE0qkSXRCbgWFAa2EchXDQ==", "027 5570 2052", "dc4614fb-7c62-4f2b-8f11-f685043cdcac", "ThaiThao34@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "22161 Kim Sa Islands", "https://placehold.co/250/2D2D2D/ffffff.png?text=Lâm Cát Linh", "04c915d9-4eb5-433a-8c8b-d69996eb81dc", new DateTime(2006, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "KhacViet0@hotmail.com", "Lâm Cát Linh", 2, "KHACVIET0@HOTMAIL.COM", "KHACVIET0@HOTMAIL.COM", "AQAAAAIAAYagAAAAENGeZt1duIz2IaP7ycLzhWskJOqX+DpH5XPtT+rnh2YXNdRVhwDM7tjTp5+/EbLCmA==", "029 3688 8796", "bb54ce1e-b5d8-4591-b4bb-c000753c8bd4", "KhacViet0@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "54038 Trương River", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trịnh Yến Trang", "d2d8ce91-729b-4faf-b37d-c649c73adbbd", new DateTime(1998, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), "NguyenPhong_Ha40@gmail.com", "Trịnh Yến Trang", 1, "NGUYENPHONG_HA40@GMAIL.COM", "NGUYENPHONG_HA40@GMAIL.COM", "AQAAAAIAAYagAAAAEKXF8oTKAzXsvGwR9D7inIB766pG4AAhXZpKYs2LSEfE4CKz8IkCmuYg42Br2eGP0g==", "025 1822 0544", "87261cef-c2c5-4c72-801b-8d8ffec48802", "NguyenPhong_Ha40@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "58882 Thụy Linh Rapids", "https://placehold.co/250/2D2D2D/ffffff.png?text=Tăng Mai Hạ", "21864991-3feb-4283-b3b9-f7019c829fac", new DateTime(2018, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), "ThuyQuynh_Dinh8@gmail.com", "Tăng Mai Hạ", 1, "THUYQUYNH_DINH8@GMAIL.COM", "THUYQUYNH_DINH8@GMAIL.COM", "AQAAAAIAAYagAAAAEEdxUJcYt0w9eTU/0tasXIe8Em37dCjC4d7DP2wsvJJTj8lYnpi+UMjUYXbTSF1+vw==", "0243 2996 9244", "dec4aa64-83c7-42e5-a18e-07068c58347a", "ThuyQuynh_Dinh8@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "18516 Bùi Highway", "https://placehold.co/250/2D2D2D/ffffff.png?text=Hồ Phương Hạnh", "59a9bad0-c162-46f8-815d-bcf3351530ed", new DateTime(2007, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "ThanhCong.Truong86@yahoo.com", "Hồ Phương Hạnh", 3, "THANHCONG.TRUONG86@YAHOO.COM", "THANHCONG.TRUONG86@YAHOO.COM", "AQAAAAIAAYagAAAAEEb8+QsdfQZGtgKBBEa6FvQegUdyM3i5A2Cwxch6NWXXxgiIXt1dGHCfaOWcOQ9Lvg==", "023 4667 5865", "078f28f5-fd59-4e55-aefe-1e5a62d84c1d", "ThanhCong.Truong86@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1699 Phan Estates", "https://placehold.co/250/2D2D2D/ffffff.png?text=Nguyễn Trọng Kiên", "1e1cb95c-5500-4071-82b2-f0ec34992e52", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "ThienTri.Dang@yahoo.com", "Nguyễn Trọng Kiên", 1, "THIENTRI.DANG@YAHOO.COM", "THIENTRI.DANG@YAHOO.COM", "AQAAAAIAAYagAAAAECrYEICKUUfJuwXthkssru/1bqbxDlEakPHViIU2fXXSU0tkPXH5++pXu1gbWr4IjQ==", "0246 3355 0840", "0cf9fae1-1afc-4f2b-95c9-1425a0607a50", "ThienTri.Dang@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "03731 Dương Row", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trần Nguyên Giáp", "fa71279a-6824-4740-b0f0-a6946de090bd", new DateTime(2002, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "ManhHung21@yahoo.com", "Trần Nguyên Giáp", 2, "MANHHUNG21@YAHOO.COM", "MANHHUNG21@YAHOO.COM", "AQAAAAIAAYagAAAAEFG1iPOX39yOX6znD7MrVXMQTur42wLTwcwpjplc18eZArQNO3L0N1CaFeXvso/8Ng==", "0243 0273 0228", "85b7596e-531a-453b-84cf-50ff5101b0d0", "ManhHung21@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5218 Trương Manors", "https://placehold.co/250/2D2D2D/ffffff.png?text=Tô Bảo Vân", "b8e758ff-55c6-47be-849f-8fd09fbc7a85", new DateTime(2012, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "NhatThuong86@yahoo.com", "Tô Bảo Vân", 1, "NHATTHUONG86@YAHOO.COM", "NHATTHUONG86@YAHOO.COM", "AQAAAAIAAYagAAAAELwdcmktBtO8SZRwzSNAPkRb/cWSmRbNnSCfG0S/FaCDJQZ7/WFtDGluhxWTutUK6A==", "0230 2820 6498", "dbdc3dff-2ad1-49ca-abfc-076b0f5256a0", "NhatThuong86@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "129 Đỗ Station", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trương Bách Nhân", "1142751c-3123-41bf-bb45-b3792a4ea0e9", new DateTime(2009, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), "BaoGiang_Vuong@gmail.com", "Trương Bách Nhân", 2, "BAOGIANG_VUONG@GMAIL.COM", "BAOGIANG_VUONG@GMAIL.COM", "AQAAAAIAAYagAAAAEC/wx7le6Zl5LiUL34WU/SRvgawo/RO52NCmZu/xZgFcpsc2y5WCjq/ahchXTjg4yg==", "0240 4735 6151", "8fa383d5-9d6a-4f2b-8f94-efb80d926907", "BaoGiang_Vuong@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "922 Hồ Mill", "https://placehold.co/250/2D2D2D/ffffff.png?text=Hồ Lan Khuê", "cdf11467-1835-43c5-ac0d-88b954a1b4e7", new DateTime(2001, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), "NgocDung_Ly87@yahoo.com", "Hồ Lan Khuê", 3, "NGOCDUNG_LY87@YAHOO.COM", "NGOCDUNG_LY87@YAHOO.COM", "AQAAAAIAAYagAAAAEKXEwYZmWM3hzmWWeVSrP8sJD5w3j8L2SpJziH1Bf2ZGm+vnNztNVIHzm4O1KwzaVg==", "021 4840 6797", "2ed43a52-ff93-4f68-b5d2-d7d634c1ef0a", "NgocDung_Ly87@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "58333 Trần Shoal", "https://placehold.co/250/2D2D2D/ffffff.png?text=Bùi Huyền Ngọc", "ccc9561d-af12-478a-9d7a-ec73b116a696", new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Local), "PhiHung.Dinh@hotmail.com", "Bùi Huyền Ngọc", 1, "PHIHUNG.DINH@HOTMAIL.COM", "PHIHUNG.DINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDaUqiS4lT/U9jHd5y7nutaqZU4dtr8geXXM4RK5ohvePLZDicfbUAk1BVBNReGRqA==", "0265 8679 5175", "c7528d6d-1d49-4ca2-a58d-f7907c8493b8", "PhiHung.Dinh@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "375 Thúy Liễu Trafficway", "https://placehold.co/250/2D2D2D/ffffff.png?text=Mai Thanh Kiều", "131eb96c-9dbb-4d43-a60b-4f138562690a", new DateTime(2005, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), "KimTrang_Dinh98@gmail.com", "Mai Thanh Kiều", "KIMTRANG_DINH98@GMAIL.COM", "KIMTRANG_DINH98@GMAIL.COM", "AQAAAAIAAYagAAAAEF03sfvXW2moEMhnFiU7RLYTXa9oK+c8TKb15cM/lzaKjfDvl8NTqWMi+uNBL+VJiw==", "0221 7013 3025", "e5fa18f6-d17b-425c-b622-8d4e335e6405", "KimTrang_Dinh98@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "874 Duy An Streets", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trương Tuấn Tú", "8ef5c8b6-ca53-409e-b2dc-fa15f69dc563", new DateTime(2006, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "GiangThanh_Ngo@hotmail.com", "Trương Tuấn Tú", 2, "GIANGTHANH_NGO@HOTMAIL.COM", "GIANGTHANH_NGO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBgO8xdpQYnCtrbfRdIHdW/y3Gji+Pd7IWgDUGGcvWc9VGyQ+fuuxdU4wOTAJzAQiA==", "028 7335 8587", "0241535f-710f-4a02-82f8-69b8156f3102", "GiangThanh_Ngo@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "14185 Lê Mountains", "https://placehold.co/250/2D2D2D/ffffff.png?text=Đỗ Bảo Tín", "fc66bad6-70bc-49e4-980f-64ee957f8f9f", new DateTime(2011, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), "NhuLoan19@yahoo.com", "Đỗ Bảo Tín", 1, "NHULOAN19@YAHOO.COM", "NHULOAN19@YAHOO.COM", "AQAAAAIAAYagAAAAEGij7jrCD/WbXf6F6nPlYjXDqWPqNhcXLjEy48JvZocv2v87/VwtLnnVhwVgndYetw==", "028 0164 0778", "eea7f4f4-b4f9-4f65-bbfd-c0eb306de3ca", "NhuLoan19@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "743 Dương Ville", "https://placehold.co/250/2D2D2D/ffffff.png?text=Hoàng Lan Nhi", "e31d4ff1-b545-4511-bdb3-5eca973cbbb9", new DateTime(1997, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "TuanDung.Dao@yahoo.com", "Hoàng Lan Nhi", 2, "TUANDUNG.DAO@YAHOO.COM", "TUANDUNG.DAO@YAHOO.COM", "AQAAAAIAAYagAAAAEM0AvMShRrCjHT1wy50vUUUeqi4ce1ifdqnb6aXClf03Ka98NVf0U5hTZhEZgZzxiA==", "0214 0673 2318", "a7e13e67-21e4-4824-bfd6-948a1a1116d7", "TuanDung.Dao@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "13578 Ðan Quỳnh Mountains", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trần Thu Nguyệt", "e326267e-7e9e-4e91-a5d4-051da6c07486", new DateTime(2004, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), "HongThu93@hotmail.com", "Trần Thu Nguyệt", 3, "HONGTHU93@HOTMAIL.COM", "HONGTHU93@HOTMAIL.COM", "AQAAAAIAAYagAAAAEH2xA4MU9bOFxYTQM/sco0nDQz+Haupz/F343WyDQsyCazdLW/bwVjGC5uliBnnEtg==", "028 6067 6982", "4562b1cd-f11b-46b6-8fcc-e529ecb88966", "HongThu93@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "10202 Bá Tùng Junctions", "https://placehold.co/250/2D2D2D/ffffff.png?text=Tăng Vạn Lý", "e380362d-c0c6-4433-ae9e-6339d7624d40", new DateTime(2005, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), "KimThong41@yahoo.com", "Tăng Vạn Lý", 1, "KIMTHONG41@YAHOO.COM", "KIMTHONG41@YAHOO.COM", "AQAAAAIAAYagAAAAEEkA/2Q39QAogz+0zS344zBF2v2pHNf6FHhPs1aqXqzi0BPOYJeo58E/0g9F9yeQOQ==", "0214 8844 5575", "43cd9e64-1359-4f15-ab4b-145a69c83df7", "KimThong41@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "750 Quang Hùng Mall", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trịnh Cẩm Thúy", "18ccca30-62c9-41ce-b6ef-b86d415923f1", new DateTime(2010, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "KhanhQuyen.Trinh91@gmail.com", "Trịnh Cẩm Thúy", 3, "KHANHQUYEN.TRINH91@GMAIL.COM", "KHANHQUYEN.TRINH91@GMAIL.COM", "AQAAAAIAAYagAAAAEEfE+APsverVEmAw0bu6+GiaODTUeFupd2/oZfGkyy3O1852eiPVcQFvAMGI+tG0Gw==", "026 3324 4847", "d36392b5-b511-4b86-b00f-78867d834c7a", "KhanhQuyen.Trinh91@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "137 Đoàn Plaza", "https://placehold.co/250/2D2D2D/ffffff.png?text=Ngô Liên Hương", "8c2d82f5-d712-4862-97c5-500f2fb3342d", new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "DiemHang83@gmail.com", "Ngô Liên Hương", "DIEMHANG83@GMAIL.COM", "DIEMHANG83@GMAIL.COM", "AQAAAAIAAYagAAAAEKBNow4XQdHQ7GpST5AEQ9Jn9sQNZ6vG+KU7c0GWLPQ3Vg9O49aGA0Mj84I3NGp2Kw==", "0228 7303 8944", "736e0746-0b77-44c4-a4e5-b1c64a9a6aeb", "DiemHang83@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "838 Đỗ Neck", "https://placehold.co/250/2D2D2D/ffffff.png?text=Vương Đức Hòa", "bb079ea7-90e4-4ef0-9d9f-130040272277", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "QuocTrung.Mai@yahoo.com", "Vương Đức Hòa", 3, "QUOCTRUNG.MAI@YAHOO.COM", "QUOCTRUNG.MAI@YAHOO.COM", "AQAAAAIAAYagAAAAEGUyuZdsVKCy4NHsFb69E4UWft2mE5wIh5tGDFAOxZA09QA4ptTHx1VM4s1ZQPbC5w==", "028 8012 5367", "f3821c6c-2950-405b-8d40-6149be80b313", "QuocTrung.Mai@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "70387 Đinh Brook", "https://placehold.co/250/2D2D2D/ffffff.png?text=Ngô Thùy Dương", "753ee6d2-b477-42ea-b3fe-441cf760bbe5", new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "NguyenHong99@hotmail.com", "Ngô Thùy Dương", 1, "NGUYENHONG99@HOTMAIL.COM", "NGUYENHONG99@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFSOsUIWSHeCR0ShrUOUl9HuIjlpJ2SALiixD74bO2/6E4R+Iw7K7X7o6T7bd7HRcQ==", "029 7484 8645", "6904be12-7864-4968-825c-e19c8d3e6fe3", "NguyenHong99@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "275 Hữu Ðạt Neck", "https://placehold.co/250/2D2D2D/ffffff.png?text=Tăng Anh Dũng", "82b17e4a-3860-406f-afce-3042cbaf82fa", new DateTime(2013, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "ThanhDe.To@hotmail.com", "Tăng Anh Dũng", "THANHDE.TO@HOTMAIL.COM", "THANHDE.TO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJF8OS53zWMFlbve3fqahFHulYzVH+IJs1Ky9wiZyLDtvbQm4MJ/7VqbA/8h94nTpA==", "022 3631 1085", "7e78db08-328e-4a24-ae69-6adbba5afa76", "ThanhDe.To@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6394 Duy Khiêm Plaza", "https://placehold.co/250/2D2D2D/ffffff.png?text=Trương Khải Ca", "4d2893eb-e2ad-471e-9335-b83132764c6b", new DateTime(2017, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "MongVan51@gmail.com", "Trương Khải Ca", 1, "MONGVAN51@GMAIL.COM", "MONGVAN51@GMAIL.COM", "AQAAAAIAAYagAAAAEAmGmfc91J+X9X8eZHQ3MxdIs+vAkaI1O8HSTc0Lkye3UVnOXG2Zhd/yyvmNL6KXuA==", "0214 7778 8479", "d4345f80-4ca0-4d75-b09a-d2a23a667fc6", "MongVan51@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "63965 Anh Sơn Harbors", "https://placehold.co/250/2D2D2D/ffffff.png?text=Lâm Nguyên Giáp", "c3926c4a-e077-4449-a2ee-b78575ca632d", new DateTime(2010, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "SaoMai.Ly78@hotmail.com", "Lâm Nguyên Giáp", "SAOMAI.LY78@HOTMAIL.COM", "SAOMAI.LY78@HOTMAIL.COM", "AQAAAAIAAYagAAAAEE0uXyr15+aYRaj0wOYyvWVirCZ+xR9HWbsZsPvZ7d3ajN0ijkqGJRRns5vb08eShQ==", "020 0975 5498", "9e2f9b1e-4b07-41a0-87c2-aafca8f8b9b6", "SaoMai.Ly78@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "938 Duy Khánh Mountains", "https://placehold.co/250/2D2D2D/ffffff.png?text=Nguyễn Huệ Hồng", "dbcdcb05-f674-4bcb-a151-cbda7e5a7708", new DateTime(2005, 7, 9, 0, 0, 0, 0, DateTimeKind.Local), "DongVy.Vuong64@hotmail.com", "Nguyễn Huệ Hồng", "DONGVY.VUONG64@HOTMAIL.COM", "DONGVY.VUONG64@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIzhPtDfC8ac2Ma9f4S89LNwIQpP3RD2vFrsqVQG/VWq4ru7unBC09vVePdHoz//xQ==", "022 2387 8235", "f0d49ab3-ba84-45fc-b545-ce95d6c7e7fd", "DongVy.Vuong64@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "53998 Quốc Trường Ways", "https://placehold.co/250/2D2D2D/ffffff.png?text=Ngô Hải Phương", "5b31e788-6f30-4870-82b2-53f96918ec42", new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "HongViet.Ngo@gmail.com", "Ngô Hải Phương", 3, "HONGVIET.NGO@GMAIL.COM", "HONGVIET.NGO@GMAIL.COM", "AQAAAAIAAYagAAAAEEZ7mTTVhWewMCtqRRUXiLiviM9BI+bc/Bv0yoeJJnBCKWg0sU6jlNMTFu7FjMJkDw==", "028 1335 7350", "2c704d4a-cfe8-405a-a53d-8b76a5a9612a", "HongViet.Ngo@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3414 Nhã Hương Springs", "https://placehold.co/250/2D2D2D/ffffff.png?text=Tăng Thiên Lan", "1a51de30-ea84-4b4f-9b7c-02a5060b40bc", new DateTime(2014, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), "PhuongTrach40@yahoo.com", "Tăng Thiên Lan", "PHUONGTRACH40@YAHOO.COM", "PHUONGTRACH40@YAHOO.COM", "AQAAAAIAAYagAAAAECVZbSSZHKYkJrel4dHDNnG2Pu5VdmgDAAP19FHrlefOtu+ozg/mM2LuW3dJPg6fYQ==", "0281 2461 5376", "b8396338-ebef-4345-babe-7f411ce1d10e", "PhuongTrach40@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "18723 Trần Stream", "https://placehold.co/250/2D2D2D/ffffff.png?text=Hoàng Sỹ Hoàng", "146a0669-afb4-4b37-ab68-6f5274e59633", new DateTime(2006, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), "ThieuLy.Nguyen63@hotmail.com", "Hoàng Sỹ Hoàng", 3, "THIEULY.NGUYEN63@HOTMAIL.COM", "THIEULY.NGUYEN63@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBcpuFOPa1x8MoOiQ9/jz28LlBt6t3wKkc+CeOTwMDRw8iHesMir0GoZYqbP3TgfmQ==", "029 2519 6347", "806567a1-07eb-4738-9a28-351fa1ccbd67", "ThieuLy.Nguyen63@hotmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 4, "Et id odio expedita voluptatum tempore architecto minima.", 94, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 14, 0, 0, 0), "Dolores atque ea eum eos sequi enim assumenda.", 37, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 11, 0, 0, 0), "Error necessitatibus nulla quod cumque inventore ea voluptatum.", 76, new TimeSpan(0, 10, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), 14, "Minima atque dicta ex quia non quia ut.", 12 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Dolorum quibusdam numquam ratione aliquam.", 16, new TimeSpan(0, 9, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 12, 0, 0, 0), "Id facere harum non sed quia laudantium minima velit.", 44, new TimeSpan(0, 11, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 9, 0, 0, 0), "Aliquid debitis quisquam saepe et quidem quisquam labore.", 12, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 10, 0, 0, 0), "Veritatis corporis hic qui.", 47, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 11, 0, 0, 0), "Aut quis est magnam doloribus a cum autem iste.", 36, new TimeSpan(0, 10, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 0, 0, 0), "Ipsa perspiciatis quaerat autem voluptas non vel voluptatum.", 80, new TimeSpan(0, 11, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), "Quo libero non quia qui quasi et.", 66, new TimeSpan(0, 17, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 17, 0, 0, 0), "Quisquam ut sit id unde et.", 23, new TimeSpan(0, 16, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), 16, "Reiciendis magni accusantium voluptatem iure voluptatibus enim ipsa eum.", 40, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Error incidunt velit qui tempore beatae officia quod molestiae.", 65, new TimeSpan(0, 15, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 16, 0, 0, 0), "Similique reiciendis tempore.", 80, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), 6, "Voluptatum eius qui aspernatur aliquam id.", 17 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), "Eum et pariatur et est hic omnis dolores.", 70, new TimeSpan(0, 10, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 18, 0, 0, 0), "Itaque velit ut velit eius facere.", 61, new TimeSpan(0, 17, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 10, 0, 0, 0), "Doloribus officiis impedit quaerat similique.", 1, new TimeSpan(0, 9, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), "Laboriosam laudantium incidunt exercitationem autem rerum.", 45, new TimeSpan(0, 9, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Corrupti sit architecto ea numquam.", 60, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), "Aliquid cumque dolores ut cum.", 89, new TimeSpan(0, 17, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 13, 0, 0, 0), "Qui impedit exercitationem suscipit aut soluta sint id consectetur quos.", 58, new TimeSpan(0, 12, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), "Quod ea velit dolor.", 64, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 17, 0, 0, 0), "Repellendus aut eligendi distinctio aliquid numquam omnis magni sed.", 87, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 13, 0, 0, 0), "Et dicta quia enim et et qui nihil quae.", 97, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), "Animi placeat impedit non placeat repudiandae ab rerum voluptatem.", 29, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 14, 0, 0, 0), "Consequatur et quia deleniti unde dolorem quia voluptatem voluptatem eum.", 41, new TimeSpan(0, 13, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 8, "Dolores possimus ducimus possimus eligendi consequatur.", 85 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), 7, "Eos velit nihil omnis.", 34, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Aut illo facere aut maxime ex est expedita.", 72, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), "Autem earum neque id necessitatibus blanditiis velit similique.", 1, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 12, 0, 0, 0), "Illo quia consequatur nisi et ea numquam alias dolor fugit.", new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), 13, "Eum sapiente ipsam quod ad soluta eos tempora eum.", 51, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), "Omnis quia et et.", 71, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 13, 0, 0, 0), "Soluta aut velit.", 5, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 9, "Cum blanditiis qui cum aliquid ut sed laborum qui.", 80, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 16, 0, 0, 0), "Eaque consequuntur omnis fugiat repellat quisquam expedita qui.", 88, new TimeSpan(0, 15, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 16, 0, 0, 0), "Ea impedit et eos placeat sunt vero quam laudantium magnam.", 34, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 15, 0, 0, 0), "Adipisci dolore ea non fuga.", 87, new TimeSpan(0, 14, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), "Voluptatem quos sapiente sed tempore autem nulla iure enim doloribus.", 6, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 13, 0, 0, 0), "Est vitae quis ea molestias voluptatem repudiandae incidunt sapiente.", 63, new TimeSpan(0, 12, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 18, 0, 0, 0), "Exercitationem est culpa quas iure occaecati laboriosam suscipit.", 4, new TimeSpan(0, 17, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 15, 0, 0, 0), "Dicta laborum quidem non.", 14, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 11, 0, 0, 0), "Assumenda distinctio est ut illum delectus dolor dolorem ratione repellendus.", 87, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 0, 0, 0), "Qui unde illum beatae.", 17, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), "Sed qui ipsa.", 70, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 13, 0, 0, 0), "Provident voluptatem reprehenderit velit rerum id consequatur praesentium ipsam ullam.", 74, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 9, 0, 0, 0), "Ut debitis quia at labore et dolores alias mollitia reiciendis.", 10, new TimeSpan(0, 8, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 18, 0, 0, 0), "Qui quod cumque non eveniet sequi ad.", 65, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 0, 0, 0), "Neque error inventore illo quis qui voluptas placeat pariatur nisi.", 58, new TimeSpan(0, 11, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 9, "Architecto libero sit aut.", 1, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 15, 0, 0, 0), "Non itaque repudiandae optio.", 1, new TimeSpan(0, 14, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 15, 0, 0, 0), "Facilis magni numquam ea dolor pariatur temporibus aut.", new TimeSpan(0, 14, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 12, 0, 0, 0), "Molestiae non non ad ea dolores itaque voluptatem.", 91, new TimeSpan(0, 11, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 6, "Nihil eius minus veritatis enim qui ut temporibus vero quia.", 97, 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), "Nemo soluta ipsa.", 74, new TimeSpan(0, 16, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 18, "Nobis velit animi dignissimos nam exercitationem consequatur nobis.", 20, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Illum natus voluptas aut omnis odio pariatur.", 10, new TimeSpan(0, 15, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 13, 0, 0, 0), "Magni ut earum eligendi tempore.", 58, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 0, 0, 0), "Expedita corporis cupiditate praesentium vitae doloremque quia et rerum dolor.", 1, new TimeSpan(0, 11, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 13, 0, 0, 0), "Qui culpa sit et iusto.", 16, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), "Sunt maxime omnis esse vero est alias.", 92, new TimeSpan(0, 14, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 18, 0, 0, 0), "Necessitatibus provident doloribus.", 30, new TimeSpan(0, 17, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 14, 0, 0, 0), "Et cum vitae.", 67, new TimeSpan(0, 13, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), "Dolorem autem suscipit error.", 75, new TimeSpan(0, 16, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 18, "Voluptas tempora dolores.", 83 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), "Qui alias totam eius natus esse dolor et id.", 7, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), 19, "Incidunt id rerum sed repellendus sed suscipit quos est.", 33, 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 13, 0, 0, 0), "Ea quaerat quod officiis et vel.", 61, new TimeSpan(0, 12, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), "Minus doloremque adipisci eos tempore qui ut sed necessitatibus.", 22, new TimeSpan(0, 14, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 9, 0, 0, 0), "Esse hic quibusdam et qui voluptas officia eveniet.", 67, new TimeSpan(0, 8, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 16, 0, 0, 0), "Et aliquid id quia possimus quas quod dolor ab.", 78, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Voluptatem vero culpa adipisci ut.", 93, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 11, 0, 0, 0), "Porro nesciunt repellendus.", 52, new TimeSpan(0, 10, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 14, 0, 0, 0), "Non omnis et nulla nostrum eos voluptatem voluptates.", 9, new TimeSpan(0, 13, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), "Atque optio nihil.", 25, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Eum porro voluptatem earum velit molestias eligendi a.", 61, new TimeSpan(0, 9, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Sunt consequatur cupiditate incidunt et neque illo.", 26, new TimeSpan(0, 15, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 18, 0, 0, 0), "Fugit tempore voluptatum.", 1, new TimeSpan(0, 17, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 19, "Illo non repellat quia occaecati sint itaque sapiente totam.", 7, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), 13, "Quidem ullam voluptatem et beatae quam molestiae quis dolores.", 84, 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), "Id animi nihil recusandae rerum non quis ullam repellat.", 3, new TimeSpan(0, 8, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 20, "Numquam necessitatibus aut ipsum veritatis sed quaerat odio ratione consequatur.", 30, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), "Cum enim illum ea consequuntur est repellat et enim ratione.", 56, new TimeSpan(0, 16, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 14, 0, 0, 0), "Commodi enim rerum perspiciatis ad quasi magnam quas.", 7, new TimeSpan(0, 13, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 12, 0, 0, 0), "Rerum molestiae dolorem corrupti et consectetur enim culpa repellat natus.", 57, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 12, 0, 0, 0), "Ducimus a est expedita.", 7, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 12, 0, 0, 0), "Repellat pariatur sunt molestiae ut.", 72, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 13, 0, 0, 0), "Non omnis minima voluptatem est odio alias.", 13, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 9, 0, 0, 0), "Quia culpa sit ratione earum id magni.", 87, new TimeSpan(0, 8, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 11, 0, 0, 0), "Ducimus mollitia totam veniam qui quo sapiente alias.", 72, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 16, 0, 0, 0), "Quia itaque et eos vero reiciendis deserunt.", 54, new TimeSpan(0, 15, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 13, 0, 0, 0), "Ut ut vero.", 47, new TimeSpan(0, 12, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 18, "Voluptates voluptatibus minus dolorem qui ut nihil architecto.", 94 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 16, 0, 0, 0), "Molestias placeat aliquid sit aut expedita sint et autem quia.", 99, new TimeSpan(0, 15, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 10, 0, 0, 0), "Quo voluptatem nesciunt nam perferendis adipisci.", 74, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 0, 0, 0), "Dignissimos repudiandae doloribus dicta aspernatur impedit aperiam officiis quia doloremque.", 13, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 10, 0, 0, 0), "Eum id neque quasi exercitationem assumenda tempore temporibus sed.", new TimeSpan(0, 9, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 15, 0, 0, 0), "Quae vel omnis accusamus quidem adipisci porro aut consequatur.", 97, new TimeSpan(0, 14, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), "Et perspiciatis repellendus ut mollitia nostrum.", 73, new TimeSpan(0, 12, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Voluptatum tempora quibusdam quia est.", 65, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 14, 0, 0, 0), "Quo atque tempora aut eius facere minus aperiam rerum iure.", 3, new TimeSpan(0, 13, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Aspernatur velit ut odio neque blanditiis quidem.", 35, new TimeSpan(0, 17, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "In reprehenderit qui.", 3, new TimeSpan(0, 12, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 18, 0, 0, 0), "Et dolor enim iusto libero mollitia dolorem.", 95, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 13, 0, 0, 0), "Quia alias non pariatur iste quas unde voluptas ut suscipit.", 64, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 13, 0, 0, 0), "Error quia deserunt repellendus quibusdam quaerat est exercitationem est nihil.", 35, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 10, 0, 0, 0), "Eos molestiae atque occaecati id cumque.", 97, new TimeSpan(0, 9, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 14, 0, 0, 0), "Hic voluptatem repellendus eos.", 72, new TimeSpan(0, 13, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 18, 0, 0, 0), "Quas explicabo aliquid labore.", 66, new TimeSpan(0, 17, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 14, 0, 0, 0), "Recusandae unde eum rem quo.", 53, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), 9, "Ipsa quam quibusdam dolores natus laborum suscipit aliquam.", 16, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 0, 0, 0), "Sint asperiores aliquam in dignissimos dolores.", 25, new TimeSpan(0, 9, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 17, 0, 0, 0), "Similique voluptatibus eveniet saepe aperiam facilis sapiente fugit qui sed.", 86, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 14, 0, 0, 0), "Quia sit consequatur explicabo sint.", 54, new TimeSpan(0, 13, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), "Quia eos illum ut sunt aut fugit et.", 72, new TimeSpan(0, 17, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, "Doloremque quaerat eos laborum consequatur in facilis maxime.", 63, 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), 20, "Autem iste rerum est aut odit earum blanditiis autem.", 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 15, 0, 0, 0), "Placeat nihil illum distinctio esse optio laboriosam.", 3, new TimeSpan(0, 14, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 15, 0, 0, 0), "Delectus repudiandae voluptatem ut illum veniam.", 89, new TimeSpan(0, 14, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 13, 0, 0, 0), "Vero distinctio qui molestiae est rerum officia accusamus.", 56, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 11, 0, 0, 0), "Optio natus perferendis.", 30, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 14, 0, 0, 0), "Labore sit dolore molestiae quia qui.", 78, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), "Adipisci autem quia ut amet.", 97, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 0, 0, 0), "Vel nesciunt recusandae.", 34, new TimeSpan(0, 17, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 18, 0, 0, 0), "Magnam non rerum repudiandae.", 53, new TimeSpan(0, 17, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 17, 0, 0, 0), "Magni qui mollitia rerum vero ratione sit tempora dolore perferendis.", 64, new TimeSpan(0, 16, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 3, "Ab mollitia in veritatis corrupti vero.", 15, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 11, 0, 0, 0), "In dicta delectus totam facere quaerat voluptatum.", 6, new TimeSpan(0, 10, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 11, 0, 0, 0), "Corrupti officiis commodi cupiditate doloremque aut cupiditate.", 46, new TimeSpan(0, 10, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 12, 0, 0, 0), "Et vero necessitatibus.", 1, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 9, 0, 0, 0), "Aut dolores enim.", 31, new TimeSpan(0, 8, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), "Odio suscipit tenetur laudantium eum dolor velit omnis.", 68, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 14, 0, 0, 0), "Nulla ad voluptatibus architecto.", 98, new TimeSpan(0, 13, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), "Reiciendis cumque quos dolor praesentium nihil autem.", 47, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 7, "Aut sit dolorem.", 48 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 18, 0, 0, 0), "Eos non ut velit consequatur a repellendus dicta accusantium qui.", 67, new TimeSpan(0, 17, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 11, 0, 0, 0), "Incidunt optio quo quasi consequatur mollitia voluptas.", 4, new TimeSpan(0, 10, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Earum facilis ipsum modi quae et sed repellat.", 3, new TimeSpan(0, 12, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 12, 0, 0, 0), "Laudantium dicta eligendi ipsa.", 50, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 11, "Mollitia sint praesentium doloremque.", 55 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 15, 0, 0, 0), "Amet perferendis dolorem magni omnis.", 62, new TimeSpan(0, 14, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 17, 0, 0, 0), "Blanditiis enim vero enim natus.", 100, new TimeSpan(0, 16, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 13, "Cupiditate et repellendus officia dolores cumque sit ducimus assumenda.", 11, 4 });

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
                columns: new[] { "AppointmentDate", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Voluptatem impedit in aut ut voluptatum.", 101, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 12, 0, 0, 0), "Tenetur totam illum rerum.", 25, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), "Amet dolorum aut inventore velit maxime impedit natus natus aut.", 18, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 17, 0, 0, 0), "Dignissimos et alias maxime ut magnam.", 88, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 15, 0, 0, 0), "Dolorem quisquam aut voluptas explicabo eveniet.", 84, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), 11, "Earum rerum rerum nam rerum aliquam voluptas veritatis.", 11 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), 5, "Aut velit aut nam saepe earum dolores.", 84, 2 });

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
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Da liễu", 3, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Thần kinh", 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Da liễu", 3, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Nhi khoa", 5, 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Tim mạch", 2, 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Thần kinh", 4, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Da liễu", 3, 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Tim mạch", 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "About", "Specialization" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Thần kinh", 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Tim mạch", 5 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Nhi khoa", 5, 9 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Thần kinh", 4, 8 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Nhi khoa", 5, 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Da liễu", 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Tim mạch", 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Đa khoa", 1, 9 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Thần kinh", 4, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Da liễu", 3, 10 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Thần kinh", 4, 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Da liễu", 5 });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8680 Tất Hiếu Lights", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20H%E1%BA%A1nh%20San", "d80b52e7-bf44-4270-9046-2bee8ad1cbb7", new DateTime(2016, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "DucChinh_Bui@hotmail.com", "Tăng Hạnh San", "DUCCHINH_BUI@HOTMAIL.COM", "DUCCHINH_BUI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFXFGGkXlU/pUMiFIwnbl0WalPyELbH0RM7cgD+99WTbKiGL2j8dzW6RZsqWufFr3w==", "021 8235 8990", "ddd98b32-49eb-41b2-8cb3-f4f53bba2124", "DucChinh_Bui@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6287 Nguyễn Hill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Qu%E1%BB%91c%20To%E1%BA%A3n", "a477df8e-e6ad-405b-a195-0b014e2c892e", new DateTime(1998, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "MyLoi.Phung99@gmail.com", "Bùi Quốc Toản", 2, "MYLOI.PHUNG99@GMAIL.COM", "MYLOI.PHUNG99@GMAIL.COM", "AQAAAAIAAYagAAAAEIafTr2bhnpcA4emAk5iy3gqN+pFkGgEJ3YWVxbSMoJZWjKRJCOn3eoRbLlFh0lrEw==", "023 7121 4829", "f90d7ef1-3764-4e07-977f-5f587ad4586b", "MyLoi.Phung99@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "16154 Hiền Hòa Road", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20C%E1%BA%A9m%20V%C3%A2n", "1660e132-2f45-42ae-8d32-d323517b50be", new DateTime(2017, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "NgocCam_Bui@yahoo.com", "Lê Cẩm Vân", 3, "NGOCCAM_BUI@YAHOO.COM", "NGOCCAM_BUI@YAHOO.COM", "AQAAAAIAAYagAAAAEAg+EqAmuIiu3NM9cnkLz1bR25x9DPTZM1RyibkuS0k8NjnIPtWz+6LTy1NsE6EWgw==", "0215 1157 8818", "288deedc-6c2a-49fa-a933-32b44b716963", "NgocCam_Bui@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7919 Phan Run", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20H%E1%BA%A1nh%20My", "4a9eaebc-99e3-46c8-9121-8699520e8326", new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "UyenTho_Hoang@gmail.com", "Phùng Hạnh My", 2, "UYENTHO_HOANG@GMAIL.COM", "UYENTHO_HOANG@GMAIL.COM", "AQAAAAIAAYagAAAAEIEUivMWrjrc1hgFQ75REI0UhHoKNoHI6/DbBwzmWdB2RFnFvAV7rS13ic8ScNnOFQ==", "0266 2801 5439", "efc635dd-4e56-4bb8-ad14-e736f92a491d", "UyenTho_Hoang@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9021 Xuân Lâm Orchard", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Tr%E1%BB%8Dng%20H%C3%B9ng", "c18ded68-9885-4e07-8e69-493165ec68a6", new DateTime(2008, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "LinhNhi.Bui@yahoo.com", "Hồ Trọng Hùng", 3, "LINHNHI.BUI@YAHOO.COM", "LINHNHI.BUI@YAHOO.COM", "AQAAAAIAAYagAAAAEKdY7JzojuzDSp64fFlTzfJMUj9PeLDpheKNFFzcRsdsLbPIYnBeX1vT4OyI+aV1xw==", "0206 1575 4682", "6ff0af5a-a4d8-46bc-9694-f145f39c6515", "LinhNhi.Bui@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "13418 Lâm Common", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20H%E1%BA%A1%20B%C4%83ng", "4d079867-4f4e-4009-a6c5-731b46a2c519", new DateTime(2001, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), "KimDan73@yahoo.com", "Ngô Hạ Băng", "KIMDAN73@YAHOO.COM", "KIMDAN73@YAHOO.COM", "AQAAAAIAAYagAAAAEHCpcuJtHXzpHevnXU5L+udZ8AmwBSVMfeuFhaaC4tJ+czmi/Vau3bTkEa18RjBgZA==", "0292 3452 6519", "1a0203d0-9f86-497f-9385-d3ad2700350d", "KimDan73@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6259 Trần Vista", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Vi%E1%BB%87t%20Qu%E1%BB%91c", "6ad46fed-a353-433b-a662-3dbbd1f47758", new DateTime(1998, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), "DinhNgan_Ho@hotmail.com", "Lý Việt Quốc", "DINHNGAN_HO@HOTMAIL.COM", "DINHNGAN_HO@HOTMAIL.COM", "AQAAAAIAAYagAAAAENLD3dp0vPp4M0QQQ1zx7BnTYdrkw5i31sqQDhsNHsLALQp305Ecxzl4zcuPcK9tpA==", "0242 4723 8642", "adcb9248-4249-4058-ae3a-37a3d35876ae", "DinhNgan_Ho@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "75344 Tú Quyên Way", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20Hi%E1%BA%BFu%20H%E1%BA%A1nh", "635f4820-1274-457d-abe1-34424bb80723", new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "HongQuy_Ngo21@gmail.com", "Phan Hiếu Hạnh", 2, "HONGQUY_NGO21@GMAIL.COM", "HONGQUY_NGO21@GMAIL.COM", "AQAAAAIAAYagAAAAEBZ19FiTTpIS5gQT1IUue7avHY0Q6GwBtIaat3y3x8ffMOQgRkE9vgiUOdr5sxMWpw==", "0285 6673 8977", "4669c59f-5b92-4ed8-9fcc-cc9621617050", "HongQuy_Ngo21@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "85209 Tố Nga Haven", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20D%C3%A3%20Lan", "659d9eba-a806-4599-bd24-3c8235a59451", new DateTime(2003, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "VyLan.Duong69@gmail.com", "Lâm Dã Lan", 1, "VYLAN.DUONG69@GMAIL.COM", "VYLAN.DUONG69@GMAIL.COM", "AQAAAAIAAYagAAAAEOAnxFHFJADTIkvq/FsW3ArTJI3wn5QbgpnVxKgPGadPx0XMvqZ4H2mLTHqDQKvZkQ==", "026 7039 9498", "589a21bd-a677-441c-9e82-dab8443eed5f", "VyLan.Duong69@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0750 Ðức Thành Ranch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20L%E1%BB%87%20Thu", "70595fa6-b78d-48db-8043-290095c20d41", new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), "AnhDuong9@yahoo.com", "Trịnh Lệ Thu", "ANHDUONG9@YAHOO.COM", "ANHDUONG9@YAHOO.COM", "AQAAAAIAAYagAAAAEFlTOtiGxfovjqb4H9fdGe/nMBAZjpRfgnczXIzRwzsqk0YtAGIND8ha8uBLuePzIw==", "026 4594 0996", "b0fea022-55d0-4548-bc35-b59f26b3cc3a", "AnhDuong9@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "495 Nhật Nam Ports", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20H%C3%B2a%20L%E1%BA%A1c", "80a6a0a0-b544-42d1-95f9-305e88d7c039", new DateTime(2006, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "NhuHong.Ho61@hotmail.com", "Đặng Hòa Lạc", 1, "NHUHONG.HO61@HOTMAIL.COM", "NHUHONG.HO61@HOTMAIL.COM", "AQAAAAIAAYagAAAAEH47hyT8WEx+OLUuA7GboPs3nyDTrcauisIvkJnoj90oGCN6jk4UkzYKcoWsCrvOkA==", "020 4323 7535", "ee2bb8d1-ecfb-4cae-a3aa-a301cf979b11", "NhuHong.Ho61@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "696 Thuận Phong Pines", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20H%C6%B0%C6%A1ng%20Mai", "61393809-5eda-4b5b-8138-1ba2aadeb201", new DateTime(1997, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "DiemThao.To@yahoo.com", "Hồ Hương Mai", "DIEMTHAO.TO@YAHOO.COM", "DIEMTHAO.TO@YAHOO.COM", "AQAAAAIAAYagAAAAEPkerAKh4lNMYAR7q3PJwcBki3+ltK6OGrVx2cDQFg3QLS7NuUh3DVLbdTytJqiKuQ==", "028 3166 7644", "5e0787d2-c56a-4266-afa1-a79625770da0", "DiemThao.To@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6825 Gia Thịnh Inlet", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Th%C3%A0nh%20Trung", "4e8e0e3d-0b80-4a56-8737-94ec6ec06cbd", new DateTime(2005, 6, 6, 0, 0, 0, 0, DateTimeKind.Local), "DienVy76@hotmail.com", "Phùng Thành Trung", "DIENVY76@HOTMAIL.COM", "DIENVY76@HOTMAIL.COM", "AQAAAAIAAYagAAAAEE3JnY1YNNTLKjznZCCjylCr5uV7caWuoM3OHx2ZPG7e4vR6tspx1+O97mVoZyCI1g==", "0282 9656 6810", "9d856b1d-e0da-4a44-8730-a7e630b88f2e", "DienVy76@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8392 Đoàn Rest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20%C3%90%E1%BB%8Bnh%20L%E1%BB%B1c", "f737f67c-9075-4d95-92c3-185b1839d9db", new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "AiVan_Lam@hotmail.com", "Ngô Ðịnh Lực", 3, "AIVAN_LAM@HOTMAIL.COM", "AIVAN_LAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGMGuhzUA+OFzxx5QY9TKlrYDT3t8PocSMkD0EGIjsaGkxJLEkkmDJsODevZmYNniQ==", "0291 7028 6145", "3589cfef-f406-4a5e-86de-c4e1ef68638b", "AiVan_Lam@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "07095 Lê Walk", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20H%E1%BB%AFu%20To%C3%A0n", "16b5692d-047a-455c-bdb1-9db5c8f3eb3c", new DateTime(2001, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "ThanhVan56@hotmail.com", "Mai Hữu Toàn", "THANHVAN56@HOTMAIL.COM", "THANHVAN56@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBOsYlkEWmsosf5sftr+wLM9tIJDJUSXWBD3HkVtrGBAUxUWpwgrUNa3eg7c3qXTJg==", "023 2566 5693", "99aa0134-527a-4b5b-b4ed-f415813099a8", "ThanhVan56@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7956 Trường Kỳ Summit", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Qu%E1%BB%91c%20B%C3%ACnh", "8eb33af3-35cb-492d-961a-8eed13f8e7c9", new DateTime(2009, 3, 25, 0, 0, 0, 0, DateTimeKind.Local), "KimPhu.Vuong28@gmail.com", "Hồ Quốc Bình", 2, "KIMPHU.VUONG28@GMAIL.COM", "KIMPHU.VUONG28@GMAIL.COM", "AQAAAAIAAYagAAAAEOKOCGxnYHbChRp2/8Dff0HlwQNNLqUvb5PNoCd5FFrz7qLIsh7I8kXZuV+GA850Xg==", "025 0257 0118", "6131eff4-e3c5-4b45-91c5-b6abc8ed1845", "KimPhu.Vuong28@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "23184 Gia Khiêm Vista", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20%C3%90%C4%83ng%20Minh", "7e8af582-16c2-4784-9a10-e25a411b7336", new DateTime(2004, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "XuanLac_Ha18@yahoo.com", "Tăng Ðăng Minh", 3, "XUANLAC_HA18@YAHOO.COM", "XUANLAC_HA18@YAHOO.COM", "AQAAAAIAAYagAAAAEO4fkafM74Py7FBkCRdqRgPodSjzO9ANu7I75PXnVXCoPxvSsRLUSUTvPv7AUzR9WA==", "023 4082 7821", "92c4a9ed-3087-4599-b9f8-5b309212e52e", "XuanLac_Ha18@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "36441 Lâm Rest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Kim%20Loan", "c86a1b17-2f81-4156-a347-3f43520fda76", new DateTime(2005, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), "ThuHong31@hotmail.com", "Vương Kim Loan", 2, "THUHONG31@HOTMAIL.COM", "THUHONG31@HOTMAIL.COM", "AQAAAAIAAYagAAAAEETVXw82H9hcYncnymG+ywk8/eBZvtzYevNqaEGE//9Mit6ySsLIOBYezc2VIXmH/g==", "0217 2928 4480", "8f084f90-0cd9-4818-a340-c3659e6061ac", "ThuHong31@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "484 Mai Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20%C3%81nh%20Xu%C3%A2n", "91f04176-2849-46c2-975d-38b7c8a7b5e6", new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "KienBinh_Doan98@gmail.com", "Phạm Ánh Xuân", 1, "KIENBINH_DOAN98@GMAIL.COM", "KIENBINH_DOAN98@GMAIL.COM", "AQAAAAIAAYagAAAAELp4fbk/pqdjImWgHX3/BeEFX5jUajwbUQXcl35/Z5VECrV7dJn3pShHB/RnkGQBZA==", "024 0504 0014", "cfba6515-f827-4b26-8431-a76b924ab7b3", "KienBinh_Doan98@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2580 Minh Huy Causeway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Tr%E1%BB%8Dng%20Vinh", "1230a53f-d7fb-42f3-9cde-737ce69b9bfd", new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), "HoangMy_Tran@gmail.com", "Tô Trọng Vinh", 2, "HOANGMY_TRAN@GMAIL.COM", "HOANGMY_TRAN@GMAIL.COM", "AQAAAAIAAYagAAAAEC2fbOg9XTdwR4DNK7DKvQEK1vaf83p/GbkpIZb+yJUFL9Tl65LrwTIZ5wYnuQp31w==", "024 0329 0608", "8f3bf570-4c6a-4889-840b-55663d889bb8", "HoangMy_Tran@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4181 Đặng Bridge", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Qu%E1%BB%91c%20%C3%90i%E1%BB%81n", "f96acae6-941f-412e-907f-cfa357fda27b", new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "BachKim_Vuong91@hotmail.com", "Hà Quốc Ðiền", 3, "BACHKIM_VUONG91@HOTMAIL.COM", "BACHKIM_VUONG91@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMKfEIsWuNat3lw7Nm00ecM7iAntRCIlN8AD0Op2gVbl6nqsV4H3xYOqezpwxg8Gcg==", "0231 9790 6519", "7106fdb9-cf0e-4f9e-836e-ed4d34205256", "BachKim_Vuong91@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1463 Đoàn Meadow", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20B%E1%BA%A3o%20Tr%C3%A2n", "f26c2bcb-7952-4429-8a67-8310cac2e9af", new DateTime(2009, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "PhuongPhi.Ngo@yahoo.com", "Lý Bảo Trân", "PHUONGPHI.NGO@YAHOO.COM", "PHUONGPHI.NGO@YAHOO.COM", "AQAAAAIAAYagAAAAEGAOnA3ha3odnibZ+NetqtTiTBjqlhGvTObsik5a6IMNAKojOMvoz3fJZwrC7cc7Lg==", "0252 2382 3564", "6af0175c-ae9e-45fd-a091-40d7ffee4fa6", "PhuongPhi.Ngo@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5750 Diễm Trang Crossing", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20H%E1%BB%93ng%20%C3%90%C4%83ng", "70ef722a-b765-4372-89c5-e75e0b3b8025", new DateTime(2012, 7, 4, 0, 0, 0, 0, DateTimeKind.Local), "HuongXuan31@gmail.com", "Ngô Hồng Ðăng", 1, "HUONGXUAN31@GMAIL.COM", "HUONGXUAN31@GMAIL.COM", "AQAAAAIAAYagAAAAEIFyFdW/z+sHJnTPe3qRFGs/kbGcSUZ7VHSGcBUU8SAg/vpHhHNs7R73AQVePZJBfg==", "026 5636 2785", "a0c6d143-e1ad-4ea6-9fd7-8c84a8c076b6", "HuongXuan31@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7687 Trần Drive", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Thanh%20H%C3%A0o", "2f6a718b-688e-4452-b263-6d0b9c035a5f", new DateTime(2018, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "TuongVy_Nguyen@gmail.com", "Hồ Thanh Hào", "TUONGVY_NGUYEN@GMAIL.COM", "TUONGVY_NGUYEN@GMAIL.COM", "AQAAAAIAAYagAAAAEIdjNe4t4WH3tELp1dT+XoTGkIlBx/De7daMnuJPo6YFrk9DHivccBvyFthu1IxCVQ==", "0221 3112 5135", "448f0f4f-4adf-4fac-877d-fc836d508b67", "TuongVy_Nguyen@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "316 Phú Thọ Mountains", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20An%20C%C6%A1", "052199de-cf4a-409e-ac52-2116cb3e8dd8", new DateTime(2014, 2, 10, 0, 0, 0, 0, DateTimeKind.Local), "BaoLong_Phan@gmail.com", "Trịnh An Cơ", "BAOLONG_PHAN@GMAIL.COM", "BAOLONG_PHAN@GMAIL.COM", "AQAAAAIAAYagAAAAEODhhC7TnF1ABvzFxFnN4DCSf2RpN8lr+qJCZqJG7BbZbAamKixSqkGCIcGxfJEe2Q==", "022 4584 6652", "eba00214-4547-424c-8a94-971e2c088ba7", "BaoLong_Phan@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "750 Hạnh Nhơn Burgs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Gia%20Ngh%E1%BB%8B", "a644c8a0-0966-40dc-acef-a789115a7911", new DateTime(2015, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "HuuLuong90@gmail.com", "Đỗ Gia Nghị", "HUULUONG90@GMAIL.COM", "HUULUONG90@GMAIL.COM", "AQAAAAIAAYagAAAAEHDSO3zlmR3btn9QBpb/MKH8J08JGL3jK+HQlGbjPKgrfddQ5hpXOlx1UmJS359dEA==", "0267 0312 3802", "c2bb8bcd-d405-49a0-988a-457f829a8c58", "HuuLuong90@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5270 Nam Lộc Neck", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Th%E1%BA%A3o%20H%E1%BB%93ng", "39f5ae74-f2c5-4253-9fc2-c35de925ec93", new DateTime(2006, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), "ThieuBao.Do76@hotmail.com", "Lý Thảo Hồng", 3, "THIEUBAO.DO76@HOTMAIL.COM", "THIEUBAO.DO76@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBKrmDygqXMY0Q0Lr5wHGnOrK+7j7Zh4WURRvwWaIOxSCOVfP8M48/2VyzgjF7221g==", "022 5143 4226", "3d140e16-fd4e-413f-8b1c-f55e7370d947", "ThieuBao.Do76@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "17802 Dương Inlet", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20H%E1%BA%A3i%20Qu%C3%A2n", "74839b90-e4f1-48b5-97c1-046c3e5a9a25", new DateTime(2004, 11, 25, 0, 0, 0, 0, DateTimeKind.Local), "HoangSa_Tang@hotmail.com", "Đặng Hải Quân", 3, "HOANGSA_TANG@HOTMAIL.COM", "HOANGSA_TANG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEP9msPGLPD1bQdPGy7PgOmW4OD4cv7aXGbmVhmrCEbD8V5o3wS1HEV0uyhV83vSeCQ==", "0265 7890 6683", "403f87d7-8ddd-481a-98bb-d3a7db37856e", "HoangSa_Tang@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "62705 Đặng Via", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20%C4%90%C3%B4ng%20Nghi", "d5d00a21-b719-462d-8508-f0ba619ca39a", new DateTime(2002, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "PhuongGiang13@hotmail.com", "Đinh Đông Nghi", 3, "PHUONGGIANG13@HOTMAIL.COM", "PHUONGGIANG13@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKPHFu9OMDh8QOVYSYw2ziLEMePtEIlR2FJMDZzUuueqg5TyMqYzdIFXsHHlYn8d6w==", "0252 1964 7152", "7d1ae656-3bae-4b55-9fa7-e87ef7fe94c7", "PhuongGiang13@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "34288 Quang Dũng Valleys", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Th%E1%BB%A5y%20Linh", "8db7ca8d-6565-49be-8096-4b4d008dd4a8", new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "YenAnh.Lam@gmail.com", "Ngô Thụy Linh", 1, "YENANH.LAM@GMAIL.COM", "YENANH.LAM@GMAIL.COM", "AQAAAAIAAYagAAAAEDXdbllbl17pRZEcRACwmaR8NKpYdr0MDUv3SqeLizUyczz5mCLHUzqfASMAI1Tifg==", "0265 3247 6919", "a23dbf80-5b3a-4546-8182-62e0db18af05", "YenAnh.Lam@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5454 Đinh Light", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BA%A7n%20Tr%C6%B0%E1%BB%9Dng%20S%C6%A1n", "8f8d52b1-8419-45f8-876c-93eecdb39745", new DateTime(2002, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), "LanVy_Vuong16@hotmail.com", "Trần Trường Sơn", 3, "LANVY_VUONG16@HOTMAIL.COM", "LANVY_VUONG16@HOTMAIL.COM", "AQAAAAIAAYagAAAAEK3IZ5QH3RMdh8laNWRn8VK7NlQlbXjRjZl32GfSXSE0tKTm6Vxw4k05zty71JmtyA==", "020 8626 2853", "40a6e8d4-da94-4d7a-b145-9965e034a880", "LanVy_Vuong16@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2551 Cao Nguyên Walk", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20B%C3%A1%20K%E1%BB%B3", "5190d55c-03ef-49e2-99ed-918e42e05250", new DateTime(2019, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "ThanhHoa_Ngo62@yahoo.com", "Dương Bá Kỳ", 3, "THANHHOA_NGO62@YAHOO.COM", "THANHHOA_NGO62@YAHOO.COM", "AQAAAAIAAYagAAAAEM/fynN+PPzQ9AuOMkcO0RC59Ei2HPpt5h+E7FqvcZoA3cPBIz/0pNbl0uVRi4FFvw==", "028 5881 9396", "80a99936-6af9-41bd-abc4-ec2b43b525f9", "ThanhHoa_Ngo62@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "224 Tô Cape", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Ph%C3%BA%20B%C3%ACnh", "6e2b9937-43f1-45b6-8ae8-ca855765aff1", new DateTime(2000, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "BaoLong12@hotmail.com", "Tăng Phú Bình", 2, "BAOLONG12@HOTMAIL.COM", "BAOLONG12@HOTMAIL.COM", "AQAAAAIAAYagAAAAEOGcbRJr0FYFrRRB5d8/BJlleSgBuiZE18xMqDHbwnVYOTQDAyfQ+YEsl2Yy0hAmTA==", "021 9399 4042", "4c0d9720-f44f-4405-8819-265f2cccd239", "BaoLong12@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9444 Đoàn Gateway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Thanh%20T%C3%BA", "4b6a2d6e-1ae4-4b82-bdad-223df5af84d2", new DateTime(2002, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "HiepDinh48@hotmail.com", "Đặng Thanh Tú", "HIEPDINH48@HOTMAIL.COM", "HIEPDINH48@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJpIhIQ463f6oDD8B2jMqsUeHsGdtvR+hArxSJLstGVFxenLncs/320lpmWMzJi6iQ==", "0233 3824 5000", "d2d7b446-698c-471b-8fe1-ec802c18b067", "HiepDinh48@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7861 Hải Duyên Ports", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20Thanh%20Xu%C3%A2n", "a6578c2d-4c07-4b6a-8658-5a1296cc7f41", new DateTime(2013, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "BinhThuan38@yahoo.com", "Phan Thanh Xuân", 3, "BINHTHUAN38@YAHOO.COM", "BINHTHUAN38@YAHOO.COM", "AQAAAAIAAYagAAAAEF11fPZ5GSFIhjr8Wo0ZB35mVMYUwTM7FS6MK2JaS27a/LQhZIR20/Enh6JtajZJEw==", "0205 8995 7576", "039cb48a-17fb-4e9d-a583-309c5b0909f9", "BinhThuan38@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "94730 Lâm Inlet", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20%C4%90%E1%BB%A9c%20H%C3%B2a", "e5f6973e-6ed2-48a7-ac1c-79330deaa280", new DateTime(2016, 3, 9, 0, 0, 0, 0, DateTimeKind.Local), "KieuAnh_To9@yahoo.com", "Phan Đức Hòa", 3, "KIEUANH_TO9@YAHOO.COM", "KIEUANH_TO9@YAHOO.COM", "AQAAAAIAAYagAAAAENYZIdWyusvOqQB8/oGwIouqKlogiRaEjV69Yto3EOf4GmSYRNXZopeizagMaW2RNw==", "0253 7894 9135", "5ed4f61e-c56d-42b1-ae94-176760a0411d", "KieuAnh_To9@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1882 Duy Tân Springs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20H%E1%BB%93ng%20L%C4%A9nh", "6345925c-6aa4-421b-9788-073f4d029753", new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), "CamTu40@hotmail.com", "Mai Hồng Lĩnh", "CAMTU40@HOTMAIL.COM", "CAMTU40@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDENbQ+3zqItoWHeeNsZf+8p+oi+OsAqzkcDTefM2x+hCNZYaNdQsPe1pdzP5SFt/g==", "0287 5967 6204", "10b7d46c-1647-4ba8-b339-cd3c070ea947", "CamTu40@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "994 Đào Tunnel", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20H%E1%BB%93ng%20Anh", "5c2ab1da-a111-4197-a2da-630f9f400c81", new DateTime(1995, 2, 6, 0, 0, 0, 0, DateTimeKind.Local), "LocUyen_To16@gmail.com", "Vương Hồng Anh", "LOCUYEN_TO16@GMAIL.COM", "LOCUYEN_TO16@GMAIL.COM", "AQAAAAIAAYagAAAAEPTgwB4fjsr9ryArpz/LulpHFXFB84oadDWDj9ZTjKdbE+TrPwKUiX0afv9h6SkzYA==", "024 7106 5695", "a6ec9db6-88d9-47b5-b30d-a496b1b12eca", "LocUyen_To16@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "909 Hồng Thắm Bypass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Kh%C3%A1nh%20Th%E1%BB%A7y", "6a36cab0-c8b0-449d-90fc-5c41fa63ad16", new DateTime(2003, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "MaiLan_To@hotmail.com", "Hà Khánh Thủy", 2, "MAILAN_TO@HOTMAIL.COM", "MAILAN_TO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFiobNnAviN/a/IQKsEl1Cov2IepSm4kZeOThTH4WSquBFIUeHl6K713eH7VOQ4EYg==", "0252 8966 4353", "a44f1fc0-3a1e-4c66-94fc-f81406b1b46d", "MaiLan_To@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1534 Tô Divide", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20T%C3%BA%20Anh", "6258f98c-073e-4f3c-91ce-29426859943f", new DateTime(2011, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "TuanTrung20@yahoo.com", "Đào Tú Anh", "TUANTRUNG20@YAHOO.COM", "TUANTRUNG20@YAHOO.COM", "AQAAAAIAAYagAAAAEHQLw1t9N6ASD7OOt9BkO4eobyDRPxKCvcLEJjPau9TI9ebkn5nHdz6LcBgdP/asfA==", "028 8038 9518", "c31cc269-ac49-470e-af4d-1376cdc689e4", "TuanTrung20@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1805 Ngô Heights", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Nh%C6%B0%20Tr%C3%A2n", "a10fdb89-a86c-4c34-b66c-ecf57b381739", new DateTime(1996, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), "NgocLy.Truong@hotmail.com", "Phạm Như Trân", "NGOCLY.TRUONG@HOTMAIL.COM", "NGOCLY.TRUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBEVpH3pDBfos88J4NFhpeSA5pNGBsfE32BYByT/wd/gIDLB+IIKBnivk+2ODZu+iQ==", "026 1529 6202", "83af899e-3b82-464f-8334-58268d029081", "NgocLy.Truong@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "077 Quang Huy Overpass", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Nh%E1%BA%ADt%20Quang", "02c96486-62d3-4799-970e-d32cb3ccabe6", new DateTime(2005, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), "YenSon.Duong@gmail.com", "Đỗ Nhật Quang", 2, "YENSON.DUONG@GMAIL.COM", "YENSON.DUONG@GMAIL.COM", "AQAAAAIAAYagAAAAEBVMarUau3GjTfadunwKVtVoUzIB8Ek8UyUruygcRPdVnQDF5EF45LhhJlMnOUqAAg==", "0291 4652 5906", "d878a044-911e-4e3c-afab-bfe7e02a0bbe", "YenSon.Duong@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "26351 Trần Hollow", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Anh%20Khoa", "8b7ac6ed-e798-4516-9540-8dcf9a52ef01", new DateTime(1995, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "KimVuong_Vuong@yahoo.com", "Hà Anh Khoa", "KIMVUONG_VUONG@YAHOO.COM", "KIMVUONG_VUONG@YAHOO.COM", "AQAAAAIAAYagAAAAEH90zsY8UkwqJqpoiaX9XZnRcXXCzBMCaptSQFqDrGBF7Lp+PeDylqEAGwhOgEMMtw==", "024 5290 7257", "e1a92f34-b8d6-4107-b7eb-b0e1d33e0371", "KimVuong_Vuong@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "36620 Trương Coves", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20Minh%20%C3%82n", "d57996cc-28c2-4161-b415-36651b17cc30", new DateTime(2011, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "DuyHung78@hotmail.com", "Hà Minh Ân", 1, "DUYHUNG78@HOTMAIL.COM", "DUYHUNG78@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPt9TYUaJQ+kVBqh7v8AxCjWj8qTlDsqaUktnESvmDbzmEHHL2d1R9l858gTIP+Z/g==", "0206 1902 2354", "1e2bc683-e7f5-4736-8089-d8d58fc939e4", "DuyHung78@hotmail.com" });
        }
    }
}
