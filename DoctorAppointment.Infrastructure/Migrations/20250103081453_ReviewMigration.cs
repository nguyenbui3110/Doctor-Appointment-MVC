using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorAppointment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CorrectMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReviewTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Local), 19, "Beatae accusamus vitae.", 8, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 12, 0, 0, 0), "Ut minus odit enim unde et eos.", 24, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), 14, "Accusamus in error.", 55, 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 5, "Pariatur nulla dolorum ducimus.", 46, 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Enim voluptatem doloremque rerum nisi dignissimos est.", 81, new TimeSpan(0, 14, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 14, 0, 0, 0), "Enim quasi et itaque quidem.", 21, new TimeSpan(0, 13, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 9, 0, 0, 0), "Quidem earum itaque ut.", 86, new TimeSpan(0, 8, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 28, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), "Soluta aspernatur iusto officiis repudiandae doloribus tempora qui possimus.", 86, new TimeSpan(0, 15, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 15, 0, 0, 0), "Delectus voluptatem eum voluptatem enim.", 60, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 15, 0, 0, 0), "A mollitia sequi deleniti.", 11, new TimeSpan(0, 14, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), 12, "Minus doloremque ut molestiae corporis nihil.", 87, 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 11, "Sit reprehenderit molestiae dolorum temporibus voluptatibus itaque quaerat harum sequi.", 49, 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), 15, "Cum voluptas eius nihil nostrum consequatur.", 43, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 14, 0, 0, 0), "Dignissimos omnis modi hic.", 45, new TimeSpan(0, 13, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 9, 0, 0, 0), "Est rerum aut doloribus odit ea deserunt voluptates veritatis ut.", 44, new TimeSpan(0, 8, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), "Eos dolor optio deserunt possimus perferendis.", 72, new TimeSpan(0, 9, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 9, 0, 0, 0), "Maxime veniam sit quia ut illum ipsa nihil labore.", 79, new TimeSpan(0, 8, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 0, 0, 0), "Minima facilis ea.", 38, new TimeSpan(0, 11, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Iste non nostrum aut commodi distinctio fuga voluptatibus aliquam.", 13, new TimeSpan(0, 11, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), "Odit porro recusandae eveniet.", 59, new TimeSpan(0, 10, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), "Nesciunt enim repudiandae et.", 42, new TimeSpan(0, 10, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 0, 0, 0), "Aspernatur deleniti sequi cupiditate quia voluptas iure quaerat numquam.", 83, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 13, "Recusandae vitae neque aut facilis eveniet iure sed.", 82, 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 15, 0, 0, 0), "Vel qui accusantium eaque qui nemo nobis.", 87, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), 2, "Consequuntur deserunt veniam quasi in aliquam sint.", 98, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Laborum ut aut minus ea autem.", 17, new TimeSpan(0, 17, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 16, 0, 0, 0), "Architecto dignissimos voluptatem placeat.", 81, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Magni repudiandae assumenda recusandae aut.", 48, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Nesciunt et esse rerum illum aut reiciendis atque est aliquam.", 33, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 11, 0, 0, 0), "Saepe quod aliquid ea et.", 19, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 12, 0, 0, 0), "Tenetur voluptatum qui possimus itaque.", 12, new TimeSpan(0, 11, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), "Adipisci accusantium dolorum assumenda recusandae.", 80, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 12, 0, 0, 0), "Officiis similique est a aut error nemo aut libero.", 7, new TimeSpan(0, 11, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 14, 0, 0, 0), "Repellat repellendus natus vel ad quia esse laudantium quis omnis.", 79, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 5, "Quia odit exercitationem dignissimos et qui quia quod.", 49 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 16, 0, 0, 0), "Quasi minus porro veniam eos sed ut minima omnis.", 78, new TimeSpan(0, 15, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 12, 0, 0, 0), "Quas ut pariatur et vel quasi voluptate aut qui.", 52, new TimeSpan(0, 11, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 13, 0, 0, 0), "Rem quis ut voluptas.", 28, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 14, 0, 0, 0), "Cum odio harum id aperiam et sint.", 94, new TimeSpan(0, 13, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 11, 0, 0, 0), "Voluptatem consequatur molestias.", 22, new TimeSpan(0, 10, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 12, 0, 0, 0), "Voluptas at quam consequatur dolorem ea in.", 41, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 13, 0, 0, 0), "Libero aut autem quia magni consequuntur libero.", 9, new TimeSpan(0, 12, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 14, 0, 0, 0), "Omnis explicabo tenetur fugiat recusandae consequuntur nihil sint sequi.", 29, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 18, 0, 0, 0), "Quia placeat perspiciatis ea nemo consequatur ab magni velit.", 14, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), "Officia rerum nemo cupiditate qui necessitatibus cupiditate enim rem.", 94, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 13, 0, 0, 0), "Cum laudantium ut excepturi autem.", 23, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), "Nisi rerum ut sequi illo quaerat voluptatem non.", 79, new TimeSpan(0, 9, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 9, 0, 0, 0), "Ab culpa repudiandae debitis.", 38, new TimeSpan(0, 8, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Ea optio similique sit rem est sit ex exercitationem voluptas.", 48, new TimeSpan(0, 15, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 12, 0, 0, 0), "Reiciendis eius velit.", 85, new TimeSpan(0, 11, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 13, 0, 0, 0), "Ipsum tempore explicabo molestiae est id et.", 57, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 15, 0, 0, 0), "Est odio dolore eaque delectus aut hic aliquam.", 44, new TimeSpan(0, 14, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 17, 0, 0, 0), "Enim quaerat consequatur aut sapiente nisi sit ut.", 67, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Local), 6, "Sed ipsa eum suscipit aut voluptas qui.", 70, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 16, 0, 0, 0), "Non non aut quasi repellendus.", 26, new TimeSpan(0, 15, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 14, 0, 0, 0), "Cumque eum ut.", 1, new TimeSpan(0, 13, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 14, 0, 0, 0), "Autem omnis omnis explicabo doloribus et autem necessitatibus animi.", 80, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), "Incidunt tempore autem.", 95, new TimeSpan(0, 12, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), 13, "Vero soluta nesciunt qui sed ex.", 15, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Nihil omnis illum magnam velit qui sit incidunt laboriosam praesentium.", 30, new TimeSpan(0, 15, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Qui qui debitis beatae et omnis.", 7, new TimeSpan(0, 13, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, "Rem molestiae molestiae autem facere laboriosam ex.", 56 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 9, 0, 0, 0), "Quos delectus et.", 3, new TimeSpan(0, 8, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 18, "Enim neque exercitationem omnis.", 86, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 12, "Vitae maxime quia qui neque ut nam magnam repudiandae consequatur.", 26, 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 9, "Modi porro facilis minima.", 72 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 15, 0, 0, 0), "Reiciendis unde est itaque et perspiciatis et.", 14, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 16, 0, 0, 0), "Nulla est aspernatur corporis et autem.", 65, new TimeSpan(0, 15, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), 16, "Et ut architecto magni laudantium molestiae vel eos.", 100, 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), "Unde vel deserunt quia optio placeat ab.", 2, new TimeSpan(0, 9, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), 20, "Aut dolor dolor deleniti quia.", 100 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 11, 0, 0, 0), "Ipsum maiores ratione voluptates ut voluptatem cupiditate neque.", 41, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 13, 0, 0, 0), "Quia atque dolores.", 66, new TimeSpan(0, 12, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 18, 0, 0, 0), "Quia qui accusamus earum.", 58, new TimeSpan(0, 17, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 11, 0, 0, 0), "Omnis vitae qui molestias animi architecto.", 96, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 18, 0, 0, 0), "Molestiae excepturi eaque est eligendi veritatis quisquam.", 77, new TimeSpan(0, 17, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 17, 0, 0, 0), "Assumenda fugit laboriosam omnis ab.", 81, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 10, 0, 0, 0), "Qui velit sunt sequi modi sit similique et quae.", 52, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 12, "Qui et eum quaerat reiciendis quam consequatur veritatis necessitatibus.", 18, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 17, 0, 0, 0), "Deleniti nemo exercitationem suscipit repudiandae iure consectetur ex reiciendis aut.", 39, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Local), 13, "Hic at veritatis aut et.", 75, 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 12, 0, 0, 0), "Nesciunt ullam neque temporibus.", 35, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 15, 0, 0, 0), "Quis sapiente maxime consequatur cum quae sapiente nobis soluta fuga.", 44, new TimeSpan(0, 14, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 18, 0, 0, 0), "Quibusdam incidunt animi earum.", 33, new TimeSpan(0, 17, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Et qui nostrum quod voluptatum impedit assumenda.", 70, new TimeSpan(0, 17, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 12, 0, 0, 0), "Amet id totam reprehenderit itaque voluptatem molestias optio fuga et.", 3, new TimeSpan(0, 11, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 13, 0, 0, 0), "Ut iusto eius ad.", 50, new TimeSpan(0, 12, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 8, "Aliquid modi neque omnis possimus accusamus ut voluptatibus aut.", 77, 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), 17, "Quia necessitatibus ratione inventore sed omnis.", 60, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 13, 0, 0, 0), "Voluptatum molestiae quis ex.", 95, new TimeSpan(0, 12, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), 11, "Repellendus molestias voluptatum.", 47 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 14, 0, 0, 0), "Et unde dolorem est et autem expedita.", 34, new TimeSpan(0, 13, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), 7, "Sunt ut est quis maxime dolorem perspiciatis.", 4, 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 14, 0, 0, 0), "Ut et incidunt iste quae est quia doloribus.", 64, new TimeSpan(0, 13, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), 3, "Sapiente repellat rerum laborum hic similique qui harum officiis voluptatum.", 80 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 12, 0, 0, 0), "Sit vel corporis eum minus enim modi.", 45, new TimeSpan(0, 11, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 15, 0, 0, 0), "Natus hic magni.", 65, new TimeSpan(0, 14, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 12, 0, 0, 0), "Numquam possimus ipsam debitis labore.", 2, new TimeSpan(0, 11, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Quia voluptatibus error dolorem iste nemo est.", 19, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 16, 0, 0, 0), "Voluptas totam eaque hic esse ipsum a.", 72, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 18, 0, 0, 0), "Corporis dolore ipsam sit distinctio nesciunt nobis.", 100, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 13, 0, 0, 0), "Aliquam similique illum excepturi labore molestiae culpa.", 94, new TimeSpan(0, 12, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 16, 0, 0, 0), "Corporis nostrum consequatur aliquam vel quia corporis corrupti officia omnis.", 88, new TimeSpan(0, 15, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 12, 0, 0, 0), "Debitis iusto odit unde facilis expedita suscipit quisquam.", 68, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), 15, "Consequuntur quae rerum quia rerum maxime impedit rerum.", 48, 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), 10, "Non quia dolorem quo perspiciatis eius rem et.", 36, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 14, 0, 0, 0), "Voluptas id reprehenderit magnam praesentium alias.", 52, new TimeSpan(0, 13, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 17, 0, 0, 0), "Temporibus provident molestiae debitis voluptatem.", 51, new TimeSpan(0, 16, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 10, 0, 0, 0), "Laudantium debitis unde rerum consectetur illum et.", 62, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 13, 0, 0, 0), "Quis ad ipsa exercitationem architecto et et.", 40, new TimeSpan(0, 12, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), "Eos et praesentium ullam perferendis maxime.", 63, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), 18, "Temporibus quos ipsa magnam.", 19, 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), 8, "Aut quasi eius.", 45, 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 15, 0, 0, 0), "Aut eaque doloribus quod dicta ea vel cumque consectetur eos.", 93, new TimeSpan(0, 14, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Eum commodi id repudiandae fugit quia minus eveniet.", new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 15, 0, 0, 0), "Et incidunt est fugit eius explicabo.", 4, new TimeSpan(0, 14, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 12, 0, 0, 0), "Voluptatem excepturi autem.", 54, new TimeSpan(0, 11, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 17, 0, 0, 0), "Debitis maiores nesciunt ducimus id rerum aspernatur laudantium cumque est.", new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 12, 0, 0, 0), "Fugit rerum magni quisquam corrupti velit.", 29, new TimeSpan(0, 11, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 14, 0, 0, 0), "Delectus nostrum fuga eligendi alias ullam consequuntur vitae dicta enim.", 65, new TimeSpan(0, 13, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 15, 0, 0, 0), "Quia libero ipsa inventore porro aut illum placeat laudantium.", 89, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 11, 0, 0, 0), "Recusandae quisquam dolores.", 26, new TimeSpan(0, 10, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 9, 0, 0, 0), "Vel repudiandae aliquam ad a omnis.", 26, new TimeSpan(0, 8, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 18, 0, 0, 0), "Sunt aliquid libero eveniet delectus sit praesentium aut.", 15, new TimeSpan(0, 17, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 14, 0, 0, 0), "Porro facilis nobis dolor sapiente facere est similique ut neque.", 7, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 9, 0, 0, 0), "Deleniti sit reiciendis labore.", 44, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 10, 0, 0, 0), "Iure dicta dolor reiciendis similique ipsam eum sed.", 49, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 14, 0, 0, 0), "Quis velit fugit minima animi architecto corrupti qui.", 92, new TimeSpan(0, 13, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AppointmentDate", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), "Officiis eius placeat incidunt velit est dicta a.", 38, 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 17, 0, 0, 0), "Et numquam voluptatem eum voluptatibus consequatur voluptate temporibus.", 97, new TimeSpan(0, 16, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 11, 0, 0, 0), "Magnam numquam dignissimos velit eos rerum in qui.", 56, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Corrupti optio assumenda harum officia nesciunt porro possimus rem.", 28, new TimeSpan(0, 10, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 10, 0, 0, 0), "Ea maxime consequatur saepe velit et et et impedit beatae.", 94, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Nobis sunt vel aut delectus blanditiis.", 32, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 16, 0, 0, 0), "Voluptatum non et dolorem.", 8, new TimeSpan(0, 15, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 15, 0, 0, 0), "Ea exercitationem sapiente neque qui.", 54, new TimeSpan(0, 14, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 17, 0, 0, 0), "Non aut quia qui sapiente placeat esse.", 100, new TimeSpan(0, 16, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), "Repellat magni laborum voluptatem.", 71, new TimeSpan(0, 10, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 12, 0, 0, 0), "Commodi occaecati placeat velit illo omnis.", 86, new TimeSpan(0, 11, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 10, 0, 0, 0), "Dignissimos ab autem pariatur nulla libero.", 52, new TimeSpan(0, 9, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 11, 0, 0, 0), "Molestiae quaerat cupiditate.", 28, new TimeSpan(0, 10, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), 4, "Hic aut unde.", 68, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 17, "Ad non eos voluptate accusantium tempore labore.", 76, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 16, 0, 0, 0), "Est qui laboriosam pariatur voluptatum excepturi perspiciatis illo natus doloribus.", 35, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 9, 0, 0, 0), "Enim debitis fugit cumque autem et.", 100, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 16, 0, 0, 0), "Dolorem similique quia non omnis id.", 84, new TimeSpan(0, 15, 0, 0, 0), 3 });

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
                keyValue: 3,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Đa khoa", 1, 10 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Tim mạch", 2, 7 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 6 năm trong lĩnh vực Đa khoa", 6 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Thần kinh", 4, 10 });

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
                columns: new[] { "About", "Specialization" },
                values: new object[] { "Bác sĩ có hơn 8 năm trong lĩnh vực Nhi khoa", 5 });

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
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 5 năm trong lĩnh vực Tim mạch", 5 });

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
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 4 năm trong lĩnh vực Đa khoa", 4 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Đa khoa", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Da liễu", 3, 2 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "About", "Specialization", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 10 năm trong lĩnh vực Da liễu", 3, 10 });

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
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 1 năm trong lĩnh vực Tim mạch", 1 });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "57613 Đỗ Forges", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20H%C3%A0m%20%C3%9D", "91fe7eb1-103e-4849-83bf-959b19508e6c", new DateTime(1995, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), "ThuyVan.Ngo@gmail.com", "Đặng Hàm Ý", 3, "THUYVAN.NGO@GMAIL.COM", "THUYVAN.NGO@GMAIL.COM", "AQAAAAIAAYagAAAAEHvDZrb1WnxbcshHsQktNN3tHdCQunBA1KmEe5w/nOP5t1XLqwudi8c/JyOEt9h1DQ==", "022 6578 7287", "a57ebb80-8ba3-461b-949a-269c82bce47f", "ThuyVan.Ngo@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "916 Hồ Spring", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Ng%E1%BB%8Dc%20Kh%C6%B0%C6%A1ng", "33ab15e8-0b11-403d-8ec1-8763a59af938", new DateTime(2014, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), "ThiNgon.Lam97@hotmail.com", "Hồ Ngọc Khương", "THINGON.LAM97@HOTMAIL.COM", "THINGON.LAM97@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIi2HOocPXtCt2/jfLW/Frj43uBGGux0Zkaqa0KHxUbYmrvpcDpnJF4OH3GgYwOHSQ==", "023 6818 8424", "91b8a5da-afee-4346-bb3f-3de5f3157fc4", "ThiNgon.Lam97@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "31707 Lâm Terrace", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Long%20V%E1%BB%8Bnh", "73feb72d-03f6-4388-b94e-f888e3dd334b", new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "ThyOanh.Duong@hotmail.com", "Phùng Long Vịnh", 2, "THYOANH.DUONG@HOTMAIL.COM", "THYOANH.DUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEBX5bfBLzU79mppxTX9QAKPvy7a5VKnU5ANGvQD6oi316zFaRLXgj73dLiGvFyLZrA==", "026 4636 7653", "dc3becdc-644f-42ba-8358-7f1bad6d62fd", "ThyOanh.Duong@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "54189 Nam Tú Wells", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Ch%E1%BA%A5n%20H%C3%B9ng", "50a46f7a-2970-4e8e-8d61-9f37d69ee41c", new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "PhuongThe15@gmail.com", "Trịnh Chấn Hùng", "PHUONGTHE15@GMAIL.COM", "PHUONGTHE15@GMAIL.COM", "AQAAAAIAAYagAAAAEKneSybsJ3lkPCoKElWXb59a8Z9tvpvPAfZS/TGSnTyvyaHWfmVPR7qMGIkUPZs0uQ==", "025 2759 6048", "e9350bab-be88-46cb-83a1-42935a66e75a", "PhuongThe15@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "29309 Phan Squares", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20L%E1%BA%A1c%20Nh%C3%A2n", "010b096d-78de-49fe-9e99-80d8ccc535da", new DateTime(1999, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "HongQuy_Ha@gmail.com", "Phan Lạc Nhân", 2, "HONGQUY_HA@GMAIL.COM", "HONGQUY_HA@GMAIL.COM", "AQAAAAIAAYagAAAAEJYnCcBEQ9YM5wrGqBVfTAHeTjZZGxKoeDOZ+WTe3w2rLejzszW1TZgGlDWLFR1+nQ==", "0258 5383 0555", "a3f332cb-a341-43a0-9ac1-570642193e49", "HongQuy_Ha@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "40125 Trần Corner", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Ng%E1%BB%8Dc%20Quang", "ee35e780-24b9-4f9c-a864-a55b382a3198", new DateTime(2014, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "BaThinh_Ngo@gmail.com", "Mai Ngọc Quang", 3, "BATHINH_NGO@GMAIL.COM", "BATHINH_NGO@GMAIL.COM", "AQAAAAIAAYagAAAAEFq1YQ/lo0pQHi/jXpRUknmjFbKZPC58pXG+SSGWph4IWHR7/BHGqzmLVc0FezGxtA==", "025 1596 7062", "5c859042-f8fb-4b40-904f-6eb26371af5f", "BaThinh_Ngo@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "70602 Hồng Thu Dam", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Chi%C3%AAu%20Phong", "5f83d8ca-c1b2-43a1-afd2-dd5dd8335d78", new DateTime(2000, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "LeKhanh_Le8@yahoo.com", "Đỗ Chiêu Phong", 3, "LEKHANH_LE8@YAHOO.COM", "LEKHANH_LE8@YAHOO.COM", "AQAAAAIAAYagAAAAEFiUhc6//wqh7LtsRRumxrTUsUSkA1rd1PhjRyKpbzeXVYYPhe2NeDzkiLOsdLn7ZA==", "0296 5451 9151", "58a36404-2376-4be2-b1b6-cde2f74619fe", "LeKhanh_Le8@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "687 Trương Crest", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Uy%E1%BB%83n%20Nh%C3%A3", "3bc92a68-2f2b-4879-b278-ffe1da903fe9", new DateTime(2014, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "LamTruong_Ly95@gmail.com", "Đặng Uyển Nhã", 1, "LAMTRUONG_LY95@GMAIL.COM", "LAMTRUONG_LY95@GMAIL.COM", "AQAAAAIAAYagAAAAEGfMNRqisUtZGBbC3kv6s6yQuKK4PAqCqRx+xsnmh5Eqal3nsH1/K7TXVVazEnA1lQ==", "0227 4079 6830", "ae6e3a8e-00c8-47dc-8bf5-98488c3ee581", "LamTruong_Ly95@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "08184 Hồ Loop", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Th%C3%BAy%20Huy%E1%BB%81n", "a28b33b8-9732-4883-b279-dca7462e3749", new DateTime(2017, 6, 18, 0, 0, 0, 0, DateTimeKind.Local), "LeThanh.Ly22@yahoo.com", "Dương Thúy Huyền", "LETHANH.LY22@YAHOO.COM", "LETHANH.LY22@YAHOO.COM", "AQAAAAIAAYagAAAAEELaOyR4wHsivVWrfDzBgyVQm6BTXKP3iIJmolT9C8Q7bTLPx2ZXkjYTL4AsImLbpQ==", "026 7548 6707", "468c2ea0-f04d-4ed8-b02b-49427c1e45ab", "LeThanh.Ly22@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "86406 Ngọc Sơn Inlet", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20Uy%C3%AAn%20Th%C6%A1", "c112565a-b3ca-4730-9e56-6cc9f4acc5b0", new DateTime(2017, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "HongXuan_Le14@yahoo.com", "Nguyễn Uyên Thơ", 2, "HONGXUAN_LE14@YAHOO.COM", "HONGXUAN_LE14@YAHOO.COM", "AQAAAAIAAYagAAAAEF6lGSTrRSiUwClnbNEzPpbFC7SCaZhrkeH9pZQd922F6EuxWeYBTkq+eqjyinCjUA==", "0273 6655 7622", "facd534b-9453-458d-b8f6-e9dc9d0f453a", "HongXuan_Le14@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "866 Trần Light", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Ng%E1%BB%8Dc%20H%E1%BA%A1nh", "fa54c9b0-f53a-4fb5-94b9-acdc67b1e895", new DateTime(2012, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "HoaiVy93@yahoo.com", "Mai Ngọc Hạnh", 1, "HOAIVY93@YAHOO.COM", "HOAIVY93@YAHOO.COM", "AQAAAAIAAYagAAAAED2ai9Wpy6jm33Vw+dQ+Ap5w2ipBh96BVU+hBmH75cUkQm33EjbjJgNSENAoTVROuw==", "029 5899 6100", "cedf6943-d2f5-40c7-b50e-81ff8316332d", "HoaiVy93@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "03442 Vũ Village", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20Vi%E1%BB%87t%20Long", "4d52a987-7d68-4145-8909-9c14b0fa2abd", new DateTime(2017, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "HamTho40@gmail.com", "Lâm Việt Long", 1, "HAMTHO40@GMAIL.COM", "HAMTHO40@GMAIL.COM", "AQAAAAIAAYagAAAAEOQhVk4flqbLvCeI+TrVAoTBJexDbdI/lazb5qxEPZbTleYcbejwAMSnZR5ZgyNeEQ==", "026 3064 1129", "5076bfd8-150d-4868-9200-648f1f156e1a", "HamTho40@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3795 Đinh Meadows", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Di%E1%BB%85m%20Khu%C3%AA", "f587be16-cc62-4035-b94b-7b5524ac86e4", new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Local), "ThuyLam.Mai0@hotmail.com", "Hoàng Diễm Khuê", 1, "THUYLAM.MAI0@HOTMAIL.COM", "THUYLAM.MAI0@HOTMAIL.COM", "AQAAAAIAAYagAAAAEE3i2jFdxm99YotmjDZh4yaSNa8ogsTT+SHERGQVPgsyYp+NyJXcm+wQJ82Szncrzg==", "0215 6816 2634", "c341130f-1e9d-469c-946f-14e41d9b6415", "ThuyLam.Mai0@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "199 Liên Hoa Walk", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20C%C6%B0%C6%A1ng%20Ngh%E1%BB%8B", "79360594-d2fb-4440-8e49-e82fac53a5ef", new DateTime(2013, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "HuuTai.Mai@hotmail.com", "Hồ Cương Nghị", 1, "HUUTAI.MAI@HOTMAIL.COM", "HUUTAI.MAI@HOTMAIL.COM", "AQAAAAIAAYagAAAAECDpyXB22KwLFWx3vcQMO/oHW9PCqfX2q37+7EXi2FO7LwMF8jhylQd7jveWnYU6bA==", "029 8068 6983", "86f1b554-5fc3-4675-815a-d634067dd2fb", "HuuTai.Mai@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1273 Ðức Trí Center", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Qu%E1%BB%B3nh%20Giang", "8c13a790-c623-4c9c-8a38-e55270634cce", new DateTime(1995, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "HaiMien_Phung@yahoo.com", "Đặng Quỳnh Giang", 1, "HAIMIEN_PHUNG@YAHOO.COM", "HAIMIEN_PHUNG@YAHOO.COM", "AQAAAAIAAYagAAAAEChsvZbExlY+xXfiuCM/rWOCkJ/lOSvj+3UqJB+S1moUfRlpC4lIZbcIFtpO4D3mLw==", "0263 4604 4314", "02dabf38-dd44-4d9b-af61-5a7f9c66beea", "HaiMien_Phung@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "83554 Quang Lâm Glen", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20Duy%20Th%C3%A0nh", "e8037808-ee1b-44e8-a0a0-527e1e4235f9", new DateTime(2014, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "HaiSan.Vuong@gmail.com", "Lâm Duy Thành", 2, "HAISAN.VUONG@GMAIL.COM", "HAISAN.VUONG@GMAIL.COM", "AQAAAAIAAYagAAAAEMlqpxCA8CF+tH3GFx8veQj/cBnhIzDoVWAVzmcGof1lga54oEMxsfuEv420YtrLJw==", "024 6302 3106", "7ac91221-67b0-4f20-85e2-d66fc977af34", "HaiSan.Vuong@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "090 Hoài Nam Junctions", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Nguy%E1%BB%87t%20C%C3%A1t", "cb4c4a31-06c6-48d6-9adc-7204f9fc2506", new DateTime(2008, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), "ThaoNghi.Tran@yahoo.com", "Lý Nguyệt Cát", 1, "THAONGHI.TRAN@YAHOO.COM", "THAONGHI.TRAN@YAHOO.COM", "AQAAAAIAAYagAAAAEJGdAGRk1axcDXGghoSE/Zqv7cQ/+eiiQwKv5v6NxSv+zzIwb22BvpadPD4bEMiSJQ==", "0287 4204 0759", "b48ea56e-f62e-4fc7-a7fc-5ce50414301c", "ThaoNghi.Tran@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2814 Hoàng Landing", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ng%C3%B4%20Di%E1%BB%85m%20Chi", "ab4eb177-b409-4103-b673-fafc4cdd6a67", new DateTime(1999, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), "ThuanPhong.To@hotmail.com", "Ngô Diễm Chi", 2, "THUANPHONG.TO@HOTMAIL.COM", "THUANPHONG.TO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJ6/UXBKgzGYHQxi245lWnvDfCraIjG0k+mq4kmhuL2hLk4d516sVyDMnIzoLEpZMA==", "0255 0596 4120", "99d4f0b8-1901-4283-a1fb-f97bd23c84a2", "ThuanPhong.To@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3321 Trâm Oanh Mission", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20%C3%90%C4%83ng%20Khoa", "be896719-454f-4735-a304-6764fa5203bc", new DateTime(2012, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "AnhHoa.To86@gmail.com", "Mai Ðăng Khoa", 3, "ANHHOA.TO86@GMAIL.COM", "ANHHOA.TO86@GMAIL.COM", "AQAAAAIAAYagAAAAEI05sAaoHfxe3/vih7b23ZuAMJDb5rIB/dtozJeYMVgDI5tR5sAb+fL3iHfr2PVZSw==", "0262 0757 9112", "bd1a543d-186e-42d5-9b0a-f8c1c216c122", "AnhHoa.To86@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "08819 Đông Tuyền Knoll", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Vi%E1%BB%87t%20D%C6%B0%C6%A1ng", "2cc19695-6738-4123-b8ad-ca7b6d9f419d", new DateTime(2002, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), "ThinhCuong41@hotmail.com", "Dương Việt Dương", "THINHCUONG41@HOTMAIL.COM", "THINHCUONG41@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDfhAYlr3q+NxXSMCDGzmQ+0PJ1ngfQJzJG2KyjQAXCTfLmRAFYK8CPIb/JInFSUMw==", "0285 9830 6871", "11b001cc-53c7-48ee-96a6-b8c814e03fe9", "ThinhCuong41@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "73889 Trịnh Port", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Thanh%20Ph%C6%B0%C6%A1ng", "7914206c-b397-4aff-9f99-193324e0d8d0", new DateTime(1995, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "ThuHien24@gmail.com", "Lê Thanh Phương", 1, "THUHIEN24@GMAIL.COM", "THUHIEN24@GMAIL.COM", "AQAAAAIAAYagAAAAEJOQeNYF9fUGAFRH78ANxCirtnT/l6xsk2ej+mF4WOD5Av8Cy90wS6o/gU27R0M9Jg==", "0270 4498 5260", "f21bdde7-c980-4661-9028-cf9d58d656de", "ThuHien24@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "944 Đinh Corners", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Xu%C3%A2n%20Thu", "f39a8b3e-5f87-4682-a250-2dd5272c4eb6", new DateTime(1998, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), "XuanNhi.Ho@gmail.com", "Hồ Xuân Thu", 1, "XUANNHI.HO@GMAIL.COM", "XUANNHI.HO@GMAIL.COM", "AQAAAAIAAYagAAAAEDcJfmCMNIbM78FKG0B4EayU9OA7aN6x3KrlzvFDBHD9INdmaOG7P4rxZGlDFaOADQ==", "020 1258 8566", "c06114ca-1743-4830-8930-703ed70b4ade", "XuanNhi.Ho@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "95102 Bùi Lane", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Nam%20An", "0e4ace2e-e4da-4ffe-b97b-65d2a8c00cc1", new DateTime(1998, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "BaoChau42@gmail.com", "Vương Nam An", 2, "BAOCHAU42@GMAIL.COM", "BAOCHAU42@GMAIL.COM", "AQAAAAIAAYagAAAAEEe+reOrIvRKZVzg3HczeMuve1Tpm/VhoiKQrfZSV77Sw7lck6XPpFPzsRHAzDBtWg==", "029 8243 5486", "6b54d643-e785-4ac4-bc73-d04739c75300", "BaoChau42@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "89631 Mai Branch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20B%E1%BA%A3o%20Duy", "9d43cd47-338f-4b81-86b8-2e77c6be8dbf", new DateTime(2016, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "ManhDung.Pham@yahoo.com", "Dương Bảo Duy", "MANHDUNG.PHAM@YAHOO.COM", "MANHDUNG.PHAM@YAHOO.COM", "AQAAAAIAAYagAAAAEHBMTf/DyzA3xkHYn5vpGQ94BprtJbFppPcEr+mHxmKHhP8Pci31fdzfCcEMG3PAGg==", "024 3564 5768", "dd020200-23a0-4f62-8ef3-82718730e699", "ManhDung.Pham@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "802 Duy Kính Cape", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Th%E1%BA%BF%20Duy%E1%BB%87t", "e1d39de5-5df9-4f45-8f54-f772fccb5e00", new DateTime(2006, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "MinhHieu_Truong91@yahoo.com", "Dương Thế Duyệt", "MINHHIEU_TRUONG91@YAHOO.COM", "MINHHIEU_TRUONG91@YAHOO.COM", "AQAAAAIAAYagAAAAELRdLiYQGLZEOZuf4qQVtxGkSAIQYKSkLE7B/eOcpHrNr+nSxwz8IJcnxsIkXsrxnQ==", "029 2147 9566", "381c67c3-27fc-4fca-b620-a3f692be04d3", "MinhHieu_Truong91@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "91164 Đinh Knolls", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20B%E1%BB%99i%20Linh", "de780f9c-10ea-42a9-857e-06b8ef61db71", new DateTime(1999, 6, 22, 0, 0, 0, 0, DateTimeKind.Local), "QuocBao_Tang36@hotmail.com", "Dương Bội Linh", "QUOCBAO_TANG36@HOTMAIL.COM", "QUOCBAO_TANG36@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMInYrVVId9Un47PhyaJdyXNL4leR2SUP0LiI5Irpz7u7lZez82hwZjCBueraDoi4g==", "0278 7353 8931", "6bd3e500-f317-4912-97eb-6eb49ac655e5", "QuocBao_Tang36@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5721 Vương Islands", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Ho%C3%A0ng%20Th%C3%A1i", "a3c22ace-f13f-4baf-a516-eaa67c4d92fb", new DateTime(2002, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "XuanHan79@hotmail.com", "Vương Hoàng Thái", 1, "XUANHAN79@HOTMAIL.COM", "XUANHAN79@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMty72pDI5oE19qQnQofxEM6YXYi1ZQUjyrM9V+GpnpIF7/4yrMGX/Bq6c524SfZ2Q==", "029 4297 9644", "38ecd3b6-47d9-4f92-9fe6-6d792439b71f", "XuanHan79@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "29800 Hoạ Mi Causeway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Th%E1%BA%BF%20Minh", "ba629dc2-fead-4327-bc6b-0597fb3ac95b", new DateTime(2017, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), "HuuVinh65@hotmail.com", "Phạm Thế Minh", "HUUVINH65@HOTMAIL.COM", "HUUVINH65@HOTMAIL.COM", "AQAAAAIAAYagAAAAEPPUZ+b6zMEjyc9IrfKOpijLfffARI1kKmWAgqTzXw7lyhYEgw9otLVdUm+AcciLNw==", "0236 5376 0373", "bc5b4c18-5236-4ab2-9dc1-7d51d7a298d9", "HuuVinh65@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3761 Mỹ Hạnh Views", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20V%C4%A9nh%20%C3%82n", "f9fda536-1dc2-46ff-afba-55d2e1f35362", new DateTime(1996, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "VietNhan.Le@hotmail.com", "Lý Vĩnh Ân", "VIETNHAN.LE@HOTMAIL.COM", "VIETNHAN.LE@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDia70dJr5g2YrpRVMwXEGyL7rCohENkioNLN/Msir3SgRjezpA9KOfCJJNw878y4A==", "029 5351 8040", "d6ee6f84-98b8-4799-8db6-f9fdb6b11a97", "VietNhan.Le@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "189 Thu Sinh Common", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20Th%C3%A0nh%20Nh%C3%A2n", "00f4ba72-b19d-4ce1-a789-ece37b15cfc6", new DateTime(2006, 1, 3, 0, 0, 0, 0, DateTimeKind.Local), "MinhHuan76@yahoo.com", "Lý Thành Nhân", "MINHHUAN76@YAHOO.COM", "MINHHUAN76@YAHOO.COM", "AQAAAAIAAYagAAAAEJE3dE0dT0B4Xj7kZRwi4zekZ/HXdoaFOPRU3Lsvfc9U89a/9MBKagIgmwcMHqzNvA==", "020 3893 9110", "ed9f6f19-c488-4d7f-b232-6639b801d582", "MinhHuan76@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "434 Vương Prairie", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Ng%E1%BB%8Dc%20Th%C6%A1", "6bc9a4e6-e6b4-4a9d-aefd-393fdb9902e6", new DateTime(1996, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "ThuyLinh13@gmail.com", "Tô Ngọc Thơ", "THUYLINH13@GMAIL.COM", "THUYLINH13@GMAIL.COM", "AQAAAAIAAYagAAAAEI9e/bR1Y/W5+JSxL2lGKkUWygiIupwJdef/mbo9SzaCUpSK8Tr0km0QTMJozl9X8g==", "0252 0270 9579", "4eeddd88-9ef3-4441-b63b-c04a5850ff3b", "ThuyLinh13@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3827 Ðức Huy Passage", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20B%C3%ADch%20Nga", "f213c0be-cc27-43bf-b3e0-74097f550f36", new DateTime(2001, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), "DuyCuong.Dao@hotmail.com", "Hồ Bích Nga", 3, "DUYCUONG.DAO@HOTMAIL.COM", "DUYCUONG.DAO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEEnQBw6O2JY5Rhqjxiaev8sgqMFt26DiumgR5LlnnyL0fhp1li70264JfjWv3YhUig==", "022 1689 1300", "6d74004c-940c-4d0c-88c1-e4c9236dbb25", "DuyCuong.Dao@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "73936 Ðan Khanh Locks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Th%E1%BB%A7y%20Trang", "f420a829-3604-426e-8eb7-30a74a5eb2e3", new DateTime(2015, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "HuyLinh78@hotmail.com", "Phùng Thủy Trang", "HUYLINH78@HOTMAIL.COM", "HUYLINH78@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMFxzIe3ybDh0VM1Efw3C5+Ma+SiRf+ZQsiBIwrLHzOZCuW8fxUlhSEjsN2lfeR8Vg==", "023 6952 4309", "0eb75943-67c8-44a4-818d-ca6e8930a8e4", "HuyLinh78@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6456 Lâm Roads", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Thi%C3%AAn%20L%C6%B0%C6%A1ng", "aaba2862-2a54-4617-8b49-748ee8c628f8", new DateTime(2009, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "NhuHong_Dang1@gmail.com", "Phạm Thiên Lương", 3, "NHUHONG_DANG1@GMAIL.COM", "NHUHONG_DANG1@GMAIL.COM", "AQAAAAIAAYagAAAAEGac6BG7ViMKWr1qtp3x285PJaBODrnfH0YM5wyqJRiLH3rKpp4xdo+55l/Bn9mYkA==", "026 1617 1467", "a3f3bc59-d773-4836-9e96-a37e12ab0535", "NhuHong_Dang1@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4053 Lâm Viaduct", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20B%E1%BA%A1ch%20Kim", "ea32aab3-07f2-43d5-bbb8-b52557b0d905", new DateTime(2018, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "TruongNhan72@yahoo.com", "Nguyễn Bạch Kim", 1, "TRUONGNHAN72@YAHOO.COM", "TRUONGNHAN72@YAHOO.COM", "AQAAAAIAAYagAAAAELQS8RpEV/md2+YlLB1sg6rUR1jV8qN6YeFc5HfBr6fCrU5ckFUB/hUE8kPoWPAtCQ==", "024 2669 1584", "94290bf7-31e2-46df-ac98-51b06eb2ebbe", "TruongNhan72@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "35754 Ái Khanh Springs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20%C3%90%E1%BB%A9c%20Tu%E1%BB%87", "d4ebf12c-668e-4a7b-8eb0-9999f207189e", new DateTime(2014, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), "TienHoat_Mai@hotmail.com", "Đoàn Ðức Tuệ", 3, "TIENHOAT_MAI@HOTMAIL.COM", "TIENHOAT_MAI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEMWJlv1RDp2K13cLmEeuJg9tN0KfYwN5E42b95Epzv55WZK16plA3BbZPfPHP57aNg==", "0246 9242 2565", "f252df73-0b63-4a77-b1ac-53b53f608c4f", "TienHoat_Mai@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "19612 Lâm Loaf", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Qu%E1%BB%91c%20Quang", "3247de65-566f-4f42-a704-729bdadacc07", new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Local), "DieuAi78@yahoo.com", "Dương Quốc Quang", "DIEUAI78@YAHOO.COM", "DIEUAI78@YAHOO.COM", "AQAAAAIAAYagAAAAEFNhDBhSsMDTC7jRgGOlElpxyFBSuct3QRIuzEys5GmBMMmr9DTSJ+4QqX3MWfU86g==", "0236 0161 4229", "b24d5a46-8197-402b-afd1-04d3c513fc30", "DieuAi78@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "288 Kim Thy Grove", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Thanh%20Loan", "cf62e2d2-e435-4646-880e-a22bf7c03619", new DateTime(2003, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), "MinhHuyen_Duong@hotmail.com", "Hồ Thanh Loan", 3, "MINHHUYEN_DUONG@HOTMAIL.COM", "MINHHUYEN_DUONG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFqecBDYmssJZV3wQf/yK3Rn9TqJ0MkWhxarAH4zSlQ2Zm9kIx8NJwRs99A4XOlAeg==", "021 2829 5300", "296a2295-95f8-4d23-8467-034405528743", "MinhHuyen_Duong@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7423 Từ Ân Walks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Phan%20Th%C3%A1i%20Minh", "450aef34-4a2e-486f-a88e-78eb0f05d1ed", new DateTime(2018, 3, 10, 0, 0, 0, 0, DateTimeKind.Local), "HaHai55@hotmail.com", "Phan Thái Minh", 3, "HAHAI55@HOTMAIL.COM", "HAHAI55@HOTMAIL.COM", "AQAAAAIAAYagAAAAENHMdfJksw/7bnSAQkrrzr/ceYxTVp3s2v66RqSWwSutuYtnRVDfkMliZZYwfrPgnQ==", "022 7141 1385", "e33d3fcf-3b18-4b3d-88e1-418b38754426", "HaHai55@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9268 Mỹ Phượng Corners", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20Xu%C3%A2n%20Hoa", "be3fadd4-7207-44ee-abf8-78deb21865c4", new DateTime(2016, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "MinhHuan.Pham10@yahoo.com", "Đào Xuân Hoa", "MINHHUAN.PHAM10@YAHOO.COM", "MINHHUAN.PHAM10@YAHOO.COM", "AQAAAAIAAYagAAAAEA6JH/3O3pzaefZTMqGl+ki7qnIzGxOAREgksb1Ntpad5Z0SIXsim2EIQkhrtXfxXw==", "0238 8749 0125", "29cb7c9b-33ff-482e-86f8-9111235fe65e", "MinhHuan.Pham10@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5397 Đăng Khương Lakes", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Ch%C3%ADnh%20Thu%E1%BA%ADn", "f4865173-e648-4863-908a-b35ebc72e7f1", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "TrongKhanh.Ly40@gmail.com", "Bùi Chính Thuận", 3, "TRONGKHANH.LY40@GMAIL.COM", "TRONGKHANH.LY40@GMAIL.COM", "AQAAAAIAAYagAAAAEGeQ5lAHX2GCow4PHTglNYMdrb3De/PsTlcjTA3REcMXgHg3Evgc+R5axzo4CVx+UA==", "0299 8205 2773", "4478d915-8a28-4e01-9b87-6db389ed9717", "TrongKhanh.Ly40@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9680 Hoàng Ramp", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Kh%E1%BA%AFc%20Tr%E1%BB%8Dng", "d564c3e6-b0d3-4bab-9eb4-d40e948e4eb5", new DateTime(2005, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), "AnhNgoc_Phan@yahoo.com", "Trịnh Khắc Trọng", "ANHNGOC_PHAN@YAHOO.COM", "ANHNGOC_PHAN@YAHOO.COM", "AQAAAAIAAYagAAAAEMp/ZpcIglnUtbDepTyAvFPJroGTkIdr1QGdBUHPR3ikEl8/jEmBSnwM3CSX0Iw7CA==", "026 2163 4031", "01bd5662-53f2-44ae-ac3c-dbb438bbc560", "AnhNgoc_Phan@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "97227 Hải Dương River", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20Ho%C3%A0ng%20Xu%C3%A2n", "f5e84a72-0697-4352-84ce-00539865a249", new DateTime(2012, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "HuongTrang_Tang@gmail.com", "Đặng Hoàng Xuân", 3, "HUONGTRANG_TANG@GMAIL.COM", "HUONGTRANG_TANG@GMAIL.COM", "AQAAAAIAAYagAAAAEHSkC8aPZ/W0hEt2nYiuVZEU+IX4EBD4BisgXTlOj5+Iii0xpMEwa2KThoN0ZtGorQ==", "021 5984 1126", "96abd78d-6169-4a5e-a107-6c1ef4502560", "HuongTrang_Tang@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "992 Bảo Lâm Trail", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Thanh%20B%C3%ACnh", "48573496-3ebe-4c17-8e5c-b90d655b3114", new DateTime(2002, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "ThanhToan_Dao19@yahoo.com", "Dương Thanh Bình", "THANHTOAN_DAO19@YAHOO.COM", "THANHTOAN_DAO19@YAHOO.COM", "AQAAAAIAAYagAAAAEHIuhC/hCVnlP2MI9MCXj+Z8g9NciKUgqhV27dpBVZpwEVO7sN+OtoN/DhtnA7WzaQ==", "027 5908 7725", "08573f2d-2799-4bf7-8401-070ebd2be5be", "ThanhToan_Dao19@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "980 Việt Tuyết Cliffs", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20C%C3%B4ng%20H%E1%BA%ADu", "c5bd2974-c6a4-4204-a151-847050eeafb2", new DateTime(2003, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "QuangTuan.Pham84@hotmail.com", "Tô Công Hậu", 3, "QUANGTUAN.PHAM84@HOTMAIL.COM", "QUANGTUAN.PHAM84@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKJZQu10bplwktwzl5fvgivfU57Uj1kBIGssFwE7OO5sYQNmS9RHoggLPNifs+Zqrw==", "025 6427 7200", "e9327c23-d92f-44eb-91e1-5eb34dbffa64", "QuangTuan.Pham84@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "108 Ngọc Ánh Hill", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20Xu%C3%A2n%20Nam", "403bc39e-902e-4cc1-9d08-3662515f93a7", new DateTime(2015, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), "ChiNam_Truong@yahoo.com", "Lâm Xuân Nam", 2, "CHINAM_TRUONG@YAHOO.COM", "CHINAM_TRUONG@YAHOO.COM", "AQAAAAIAAYagAAAAEPGZ4NIqRFW3pfbnhetbYellvgYskE1Jo+Dn261cMT47vfvf+i3nn4DtalvM+553DQ==", "0239 4849 4273", "518b12ff-88db-4ed7-975e-e4a57e260985", "ChiNam_Truong@yahoo.com" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_DoctorId",
                table: "Reviews",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_PatientId",
                table: "Reviews",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 17, "Voluptatum non voluptate sit omnis.", 81, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 17, 0, 0, 0), "Inventore ducimus vel in laboriosam.", 28, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 15, "Voluptatem odit mollitia ipsum ad odit omnis ab.", 58, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 17, 0, 0, 0), "Consectetur reiciendis in laborum nulla laudantium quo rerum.", 49, new TimeSpan(0, 16, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 16, 0, 0, 0), "Sequi perspiciatis id sit reiciendis itaque natus.", 99, new TimeSpan(0, 15, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), 13, "Beatae reprehenderit quam occaecati eius aut sed accusamus suscipit.", 88, 4 });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), "Est ab consequatur repellat quasi possimus unde totam quidem.", 53, new TimeSpan(0, 14, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 13, 0, 0, 0), "Repellendus perferendis voluptatem.", 70, new TimeSpan(0, 12, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 17, 0, 0, 0), "Sint accusantium accusantium sint magnam aut deserunt.", 2, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 13, 0, 0, 0), "Esse et at.", 88, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), "Nam tempora eligendi unde ad est.", 71, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 18, 0, 0, 0), "Aut tenetur dolorem aut.", 36, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), 7, "Voluptates consequatur fugit et.", 29, 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 11, 0, 0, 0), "Esse omnis nostrum.", 8, new TimeSpan(0, 10, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Local), 6, "Qui quos quas eveniet et aut voluptates.", 20, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 18, 0, 0, 0), "Ut voluptatem et quia.", 18, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 16, "Voluptatem dolor ex deserunt.", 73, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 11, 0, 0, 0), "Non animi ipsa sed maxime voluptatum consequatur sunt.", 70, new TimeSpan(0, 10, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 16, 0, 0, 0), "Voluptate ut ut velit rerum sed voluptatem aspernatur temporibus.", 24, new TimeSpan(0, 15, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Deserunt sed et alias quas occaecati.", 2, new TimeSpan(0, 9, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 17, 0, 0, 0), "Recusandae dicta repellendus itaque.", 53, new TimeSpan(0, 16, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 10, 0, 0, 0), "Totam consectetur in.", 70, new TimeSpan(0, 9, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), "Nostrum aspernatur et voluptatem doloribus reiciendis corporis voluptate.", 12, new TimeSpan(0, 15, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), 14, new TimeSpan(0, 11, 0, 0, 0), "Voluptas laborum sit voluptatem saepe non quis laudantium.", 99, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 17, 0, 0, 0), "Qui aut nihil ab ea quae impedit facere et sed.", 31, new TimeSpan(0, 16, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 12, 0, 0, 0), "Eum perferendis possimus.", 1, new TimeSpan(0, 11, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), 13, "Quia velit id quos optio alias alias vero modi.", 85, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 16, 0, 0, 0), "Magnam magni laudantium.", 19, new TimeSpan(0, 15, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 10, 0, 0, 0), "Excepturi eaque voluptatibus quas.", 26, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 14, 0, 0, 0), "Nobis aut veniam soluta.", 98, new TimeSpan(0, 13, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), 16, "Iure officia officiis non modi perspiciatis ut quam voluptatem.", 29, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 11, 0, 0, 0), "Quia voluptate voluptates modi est nobis ullam beatae consequatur laudantium.", 82, new TimeSpan(0, 10, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 9, 0, 0, 0), "Praesentium nesciunt eum nostrum modi in aut odit voluptatibus aut.", 100, new TimeSpan(0, 8, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 3, new TimeSpan(0, 18, 0, 0, 0), "Voluptatem nesciunt temporibus consequatur officiis dolores et atque.", 86, new TimeSpan(0, 17, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 9, 0, 0, 0), "Nihil quo quasi voluptatem ullam fugiat eum.", 70, new TimeSpan(0, 8, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 15, 0, 0, 0), "Architecto voluptates aliquid et inventore libero ea nulla eum.", 56, new TimeSpan(0, 14, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), 6, "Unde quaerat et qui accusamus.", 96 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 9, 0, 0, 0), "Repellendus a nihil consequatur quis.", 77, new TimeSpan(0, 8, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Aut dolorem ab sunt sapiente.", 32, new TimeSpan(0, 15, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 10, 0, 0, 0), "Et rem ut consequatur nam.", 80, new TimeSpan(0, 9, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 10, 0, 0, 0), "Aut laborum numquam voluptas ea nemo.", 13, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 9, 0, 0, 0), "Asperiores reprehenderit eum necessitatibus.", 18, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Expedita ea ab laudantium sit vel.", 90, new TimeSpan(0, 14, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 17, 0, 0, 0), "Commodi odio aut quaerat alias.", 30, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 13, 0, 0, 0), "Architecto est non in enim architecto.", 4, new TimeSpan(0, 12, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 15, 0, 0, 0), "Neque aperiam sunt est impedit.", 70, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 9, 0, 0, 0), "Delectus maiores dolorem ut voluptas veniam perspiciatis ex ut est.", 66, new TimeSpan(0, 8, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 13, 0, 0, 0), "Error aspernatur facilis consequatur porro eius voluptas eveniet.", 55, new TimeSpan(0, 12, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 11, 0, 0, 0), "Et sed aut ullam.", 62, new TimeSpan(0, 10, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), "Laudantium adipisci ad sed sed ut voluptates mollitia non.", 25, new TimeSpan(0, 14, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Qui explicabo cumque et unde.", 68, new TimeSpan(0, 10, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 10, new TimeSpan(0, 9, 0, 0, 0), "Debitis aut eaque ut.", 45, new TimeSpan(0, 8, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 18, 0, 0, 0), "Et aut atque nostrum quia molestiae.", 15, new TimeSpan(0, 17, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 15, 0, 0, 0), "Et ut porro tempora provident delectus.", 57, new TimeSpan(0, 14, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 16, 0, 0, 0), "Sunt fugit accusamus aperiam quisquam consequatur.", 18, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 10, 0, 0, 0), "Suscipit in fugiat ut nostrum mollitia et vitae aut porro.", 64, new TimeSpan(0, 9, 0, 0, 0), 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 16, 0, 0, 0), "Dolores perferendis deleniti reprehenderit.", 76, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 10, 0, 0, 0), "Et ducimus quaerat.", 43, new TimeSpan(0, 9, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 14, 0, 0, 0), "Autem consequatur non minima alias aliquam.", 90, new TimeSpan(0, 13, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 13, 0, 0, 0), "Maxime non doloribus.", 92, new TimeSpan(0, 12, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Et voluptas voluptatem nemo aspernatur possimus.", 34, new TimeSpan(0, 15, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), 14, "Enim aliquam cumque atque.", 39 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 10, 0, 0, 0), "Nemo consectetur dolorem iusto esse tempore velit iure.", 40, new TimeSpan(0, 9, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 9, "Dolores ex corrupti omnis.", 17, 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Local), 16, "Id veritatis iste amet laboriosam aut debitis voluptatem et soluta.", 33 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 12, 0, 0, 0), "Earum ab non enim voluptatem aut ab quo totam explicabo.", 101, new TimeSpan(0, 11, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), 9, "Veritatis magni occaecati velit dolor rem nemo.", 80, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), 20, "Nesciunt dolores ad.", 13, 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 11, 0, 0, 0), "Facere aut est.", 77, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 14, 0, 0, 0), "Nesciunt iusto nostrum itaque eius ab.", 53, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 9, 0, 0, 0), "Et repudiandae delectus magni rem.", 86, new TimeSpan(0, 8, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, "Qui ut deserunt voluptatem facere excepturi sed doloribus at.", 15 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 14, 0, 0, 0), "Blanditiis quo eum necessitatibus voluptate.", 58, new TimeSpan(0, 13, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 12, 0, 0, 0), "Fugiat nihil ducimus velit quos possimus nobis velit qui.", 22, new TimeSpan(0, 11, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 18, 0, 0, 0), "Minima culpa a atque modi aspernatur aut reprehenderit.", 98, new TimeSpan(0, 17, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 11, 0, 0, 0), "Officia in est dolor sed quos et sint nulla.", 53, new TimeSpan(0, 10, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Nesciunt et aut sed neque nesciunt.", 13, new TimeSpan(0, 14, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 0, 0, 0, DateTimeKind.Local), 5, new TimeSpan(0, 9, 0, 0, 0), "Ad alias id dolores ad.", 9, new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 20, "Velit molestiae aut ipsum possimus nostrum recusandae ipsa modi.", 77, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Qui eum beatae.", 40, new TimeSpan(0, 14, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Repellendus qui soluta impedit illo facilis.", 47, new TimeSpan(0, 10, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 18, 0, 0, 0), "Fugit placeat tempore qui quasi sed.", 63, new TimeSpan(0, 17, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 16, 0, 0, 0), "In voluptatem omnis quia.", 49, new TimeSpan(0, 15, 0, 0, 0), 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 16, 0, 0, 0), "Et nihil porro voluptates eveniet accusantium aspernatur quia.", 42, new TimeSpan(0, 15, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), 18, "Similique voluptatem modi.", 36, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 9, 0, 0, 0), "Asperiores neque eaque quo quos quae accusantium perferendis.", 90, new TimeSpan(0, 8, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 11, 0, 0, 0), "Excepturi beatae non voluptatem.", 21, new TimeSpan(0, 10, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 16, "Optio qui et consequatur voluptatem aut.", 37, 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), 11, "Cupiditate sit aut.", 79, 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), 18, "Dolorum consequatur ducimus vel dicta tenetur.", 46 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 10, 0, 0, 0), "Error est est.", 2, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), 1, new TimeSpan(0, 16, 0, 0, 0), "Debitis aut qui dolorem non.", 97, new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 18, "Molestiae vel provident.", 48, 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), 18, "Aut libero fuga dolorem sunt animi.", 20, 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId" },
                values: new object[] { new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), 5, "Totam rerum in velit id atque.", 101 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 17, 0, 0, 0), "Animi error at.", 96, new TimeSpan(0, 16, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 16, 0, 0, 0), "Ipsam labore reiciendis autem similique totam optio vero temporibus.", 59, new TimeSpan(0, 15, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 14, 0, 0, 0), "Harum enim sint neque.", 56, new TimeSpan(0, 13, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), "Ut deleniti cumque aut rerum.", 32, new TimeSpan(0, 10, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 15, 0, 0, 0), "Pariatur rerum et atque omnis maxime.", 20, new TimeSpan(0, 14, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 9, 0, 0, 0), "Tenetur voluptatum est maiores est.", 59, new TimeSpan(0, 8, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 10, 0, 0, 0), "Quidem dicta voluptatum excepturi velit atque.", 23, new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 15, 0, 0, 0), "Dicta optio nemo repudiandae aliquam autem.", 13, new TimeSpan(0, 14, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Local), 9, "Illum itaque sint similique ea.", 10, 4 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), 7, "Et minus blanditiis placeat quia voluptatibus autem.", 46, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), 2, new TimeSpan(0, 13, 0, 0, 0), "Quisquam laborum ipsa.", 92, new TimeSpan(0, 12, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 13, 0, 0, 0), "Similique dolor ipsum illo ut officiis.", 24, new TimeSpan(0, 12, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 9, 0, 0, 0), "Molestiae iusto dolorem.", 19, new TimeSpan(0, 8, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 14, 0, 0, 0), "Et sint est nihil dolore.", 74, new TimeSpan(0, 13, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 15, 0, 0, 0), "Ad temporibus dolores iste accusantium occaecati recusandae a voluptas.", 67, new TimeSpan(0, 14, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 12, 0, 0, 0), "Voluptas a totam et aut dolore et.", 79, new TimeSpan(0, 11, 0, 0, 0), 0 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 16, 0, 0, 0), "Voluptatem qui dolorem occaecati qui doloribus porro ea.", 30, new TimeSpan(0, 15, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), 5, "Incidunt et amet et nam recusandae est sit culpa.", 38, 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), 13, new TimeSpan(0, 18, 0, 0, 0), "Aut officiis debitis eos.", new TimeSpan(0, 17, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Pariatur repudiandae dolorum nihil aperiam.", new TimeSpan(0, 15, 0, 0, 0), 1 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 17, 0, 0, 0), "Ipsam eos dolores aspernatur est culpa labore et sit.", 64, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 16, 0, 0, 0), "Rem magni expedita facilis.", 66, new TimeSpan(0, 15, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 16, 0, 0, 0), "Voluptatibus recusandae amet quis adipisci.", 96, new TimeSpan(0, 15, 0, 0, 0), 2 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 12, 0, 0, 0), "Ad doloribus aut vitae deserunt quisquam odio omnis quod delectus.", 34, new TimeSpan(0, 11, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), 13, "Consectetur quisquam amet aspernatur.", 89, 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 14, 0, 0, 0), "Non enim eos.", 11, new TimeSpan(0, 13, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), 18, new TimeSpan(0, 10, 0, 0, 0), "Enim nihil voluptas consequatur optio non quo facilis.", 87, new TimeSpan(0, 9, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 15, 0, 0, 0), "Accusantium illo officiis non quam illum at qui error.", 25, new TimeSpan(0, 14, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 11, 0, 0, 0), "Dicta quam facere.", 59, new TimeSpan(0, 10, 0, 0, 0), 4 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 16, 0, 0, 0), "Laboriosam ipsa accusantium.", 6, new TimeSpan(0, 15, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Local), 15, new TimeSpan(0, 11, 0, 0, 0), "Alias inventore at corrupti corrupti cupiditate.", 6, new TimeSpan(0, 10, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 18, 0, 0, 0), "Rem et aut aut voluptates molestiae exercitationem sint.", 41, new TimeSpan(0, 17, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AppointmentDate", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Molestiae vitae cumque earum omnis vel repellat.", 3, 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), 8, new TimeSpan(0, 13, 0, 0, 0), "Quo laborum modi quam repellat eveniet at occaecati.", 20, new TimeSpan(0, 12, 0, 0, 0), 2 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), 16, new TimeSpan(0, 15, 0, 0, 0), "Expedita illo sed temporibus facilis ut ut ipsa temporibus.", 98, new TimeSpan(0, 14, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Local), 9, new TimeSpan(0, 16, 0, 0, 0), "Doloribus quae tempora ut sapiente.", 77, new TimeSpan(0, 15, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), 17, new TimeSpan(0, 9, 0, 0, 0), "Qui dolores aperiam molestiae exercitationem labore consectetur dicta nihil quae.", 50, new TimeSpan(0, 8, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 20, new TimeSpan(0, 12, 0, 0, 0), "Incidunt minus harum numquam.", 12, new TimeSpan(0, 11, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Local), 7, new TimeSpan(0, 17, 0, 0, 0), "Non omnis rerum quia voluptate explicabo impedit quaerat.", 91, new TimeSpan(0, 16, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(0, 9, 0, 0, 0), "Expedita corrupti aspernatur voluptate.", 42, new TimeSpan(0, 8, 0, 0, 0), 1 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Local), 12, new TimeSpan(0, 9, 0, 0, 0), "Commodi porro quia numquam id omnis qui placeat.", 58, new TimeSpan(0, 8, 0, 0, 0), 3 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), 19, new TimeSpan(0, 17, 0, 0, 0), "Voluptatem ex accusantium enim eveniet est voluptatibus.", 4, new TimeSpan(0, 16, 0, 0, 0) });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Local), 4, new TimeSpan(0, 15, 0, 0, 0), "Molestiae sit explicabo dolorem nulla aut sunt modi et.", 32, new TimeSpan(0, 14, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), 6, new TimeSpan(0, 11, 0, 0, 0), "Architecto illo est voluptate.", 19, new TimeSpan(0, 10, 0, 0, 0), 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), 5, "Enim qui est molestias odio.", 59, 3 });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AppointmentDate", "DoctorId", "Notes", "PatientId", "Status" },
                values: new object[] { new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), 13, "Et cum est cum vero et laudantium.", 96, 0 });

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
                columns: new[] { "AppointmentDate", "DoctorId", "EndTime", "Notes", "PatientId", "StartTime", "Status" },
                values: new object[] { new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), 11, new TimeSpan(0, 14, 0, 0, 0), "Qui occaecati suscipit.", 17, new TimeSpan(0, 13, 0, 0, 0), 1 });

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
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Đa khoa", 7 });

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
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 7 năm trong lĩnh vực Tim mạch", 7 });

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
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 2 năm trong lĩnh vực Đa khoa", 2 });

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
                columns: new[] { "About", "YearsOfExperience" },
                values: new object[] { "Bác sĩ có hơn 9 năm trong lĩnh vực Tim mạch", 9 });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "207 Trần Burg", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Tr%C3%BAc%20Lan", "f9492856-b2ee-420a-a309-0ecf7f0bc009", new DateTime(2012, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), "VietKhoa7@gmail.com", "Phùng Trúc Lan", 1, "VIETKHOA7@GMAIL.COM", "VIETKHOA7@GMAIL.COM", "AQAAAAIAAYagAAAAEJdFaWPBBYqW+I4JRoNuDyIuovfnY/s74effimtvoifqdy4kUWiqa7No7pdpG57Obw==", "022 2327 4260", "c1804da0-ca75-4600-8b21-1d3d114af72e", "VietKhoa7@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "39334 Vương Route", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Ng%E1%BB%8Dc%20Loan", "f381d046-6622-493c-8859-03fd828ee7b9", new DateTime(1999, 5, 19, 0, 0, 0, 0, DateTimeKind.Local), "QuangTai.Lam2@hotmail.com", "Mai Ngọc Loan", "QUANGTAI.LAM2@HOTMAIL.COM", "QUANGTAI.LAM2@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHhzcwsQaEcO+mGVKqdhzVEGv27nv/oxy6OlWGrtPb10zWNQMzQAajPnqY9/1deMVw==", "0259 0252 9151", "ea8bf02e-5f4f-4cca-90ad-4db25cc315ab", "QuangTai.Lam2@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "79221 Trịnh Canyon", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Nghi%20Dung", "50bda333-3b82-41ec-90a6-93e162a4f24e", new DateTime(2000, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "DiemHuong_Phan71@hotmail.com", "Hoàng Nghi Dung", 1, "DIEMHUONG_PHAN71@HOTMAIL.COM", "DIEMHUONG_PHAN71@HOTMAIL.COM", "AQAAAAIAAYagAAAAEAU0V1s4GNNsTI7V1ke3YRQgM50FLApq3iORhfTFPHnsmZ33SrlYKHH9MT0VS96xUg==", "023 1252 1205", "63353b47-d19e-4592-ae11-e48387ae403f", "DiemHuong_Phan71@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "980 Vương Triệu Estate", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%C3%A0%20H%E1%BB%93ng%20Linh", "a2d26bfc-6395-4b8c-a680-815c986646a3", new DateTime(2003, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "BinhMinh46@yahoo.com", "Hà Hồng Linh", 1, "BINHMINH46@YAHOO.COM", "BINHMINH46@YAHOO.COM", "AQAAAAIAAYagAAAAEA+mGf8JvFkxTrk+YXLY/DY1as0xjF9yt1SD8Re9VwWSNIhru2bJ+SxFeaGqUpcslw==", "022 7043 9528", "5cc7b44a-7adf-432a-9e82-a54e8f654185", "BinhMinh46@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1313 Vũ Squares", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20%C4%90an%20Th%C6%B0", "870c5385-bb6e-4c54-9f17-ffce9032c2a8", new DateTime(2013, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), "VanSon.Do@hotmail.com", "Trương Đan Thư", "VANSON.DO@HOTMAIL.COM", "VANSON.DO@HOTMAIL.COM", "AQAAAAIAAYagAAAAEODjZNX5PHoEnOs3qVpc1W3q5ZZ6zGRQSl0igKQj1irZCt4LSfxI9bSw8Wi6wX8srg==", "0264 5246 5113", "f47eb50f-8fcd-44c5-95aa-29ee03d976d5", "VanSon.Do@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1718 Phùng Corners", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Tr%C3%AD%20Li%C3%AAn", "eecc7811-8b0b-4d8f-9af2-2f313e31c8a4", new DateTime(2004, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "TuanLinh9@yahoo.com", "Trương Trí Liên", 3, "TUANLINH9@YAHOO.COM", "TUANLINH9@YAHOO.COM", "AQAAAAIAAYagAAAAEHahFQh5hHnfOxtJdX4gU6QeEmDOftDUwT7peEpLOpkRZMm38WIAd7uJTTg3J2If6Q==", "0291 0822 8396", "c7e8ac0a-436d-4f7d-95be-ed7eef4e2dc2", "TuanLinh9@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "02439 Phan Road", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Nguy%C3%AAn%20Nh%C3%A2n", "53221bf3-cd41-4d89-88b4-a7ebe67cb718", new DateTime(2012, 4, 11, 0, 0, 0, 0, DateTimeKind.Local), "CongSinh48@gmail.com", "Mai Nguyên Nhân", 3, "CONGSINH48@GMAIL.COM", "CONGSINH48@GMAIL.COM", "AQAAAAIAAYagAAAAEE6JPlzsw6Yy8/FX5739+Ky3WMLqEmMkOKYSTUnVJ9AJRW+y2V2CZ7kWxcouSTEmzg==", "0263 7706 3024", "bd84235e-61f4-462a-ba7a-38b64769733b", "CongSinh48@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "997 Thục Nhi Shore", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Mai%20Li%C3%AAn", "f39a7e75-5e75-47a3-959d-b96fbbd25941", new DateTime(2014, 6, 26, 0, 0, 0, 0, DateTimeKind.Local), "ThienSinh50@gmail.com", "Vương Mai Liên", "THIENSINH50@GMAIL.COM", "THIENSINH50@GMAIL.COM", "AQAAAAIAAYagAAAAEEBBm7gjS0INgGBv/zugk2t8SSB6bLE/ixObQBlSj5/ybwSWVgOt0eAK1WbXEMjszA==", "027 8500 9712", "10ecb74e-95fc-4b3b-9cb0-d864c5f97d5b", "ThienSinh50@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6918 Chiêu Dương Stravenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Uy%E1%BB%83n%20My", "5930adcf-804b-4b14-be54-397847387f12", new DateTime(1995, 3, 4, 0, 0, 0, 0, DateTimeKind.Local), "HuongLien_Dinh@yahoo.com", "Phùng Uyển My", 1, "HUONGLIEN_DINH@YAHOO.COM", "HUONGLIEN_DINH@YAHOO.COM", "AQAAAAIAAYagAAAAEKXK+dahqoVwjPqwZ3x+IhMIv0pwU3xZNfOp7b3StMgZrswxciEMnYXQyfByX/vl/w==", "0293 8965 8146", "76924c92-9f97-4599-87ae-47082f318588", "HuongLien_Dinh@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7396 Phương An Neck", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%AA%20Duy%20M%E1%BA%A1nh", "61444506-1e77-493c-9afe-5af62bb8a889", new DateTime(2010, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), "KhietLinh_Mai95@hotmail.com", "Lê Duy Mạnh", 3, "KHIETLINH_MAI95@HOTMAIL.COM", "KHIETLINH_MAI95@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFo804Z4cBdtgUhoxXsSc/9LDqG7fnLuXvX21qDorRq9Hh3XkKBhN9dMi0uJphNaIg==", "028 3794 5291", "37d20399-da7a-4b25-accc-5a6c624596e5", "KhietLinh_Mai95@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3327 Đỗ Terrace", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Nh%C3%A3%20Y%E1%BA%BFn", "d4b3b5fa-ad03-4cb6-8039-ee7b93c38ad7", new DateTime(1998, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "ChiNam33@hotmail.com", "Tô Nhã Yến", 2, "CHINAM33@HOTMAIL.COM", "CHINAM33@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFRgk2moW1nnBIzQuY1ghGZyt1mItTtNBxW26A4Fc6hnzYIB6D8m3x7/8wvufUj2LQ==", "026 0753 8048", "46ba98d7-30d7-4755-b698-dcaa8cd36757", "ChiNam33@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "519 Hữu Trác Walk", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%C3%A0o%20Vi%E1%BB%85n%20%C3%90%C3%B4ng", "a305d5cb-bb1f-47a5-9ce3-5a62c81b60bc", new DateTime(2018, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "ThuyKhanh.Ha94@yahoo.com", "Đào Viễn Ðông", 2, "THUYKHANH.HA94@YAHOO.COM", "THUYKHANH.HA94@YAHOO.COM", "AQAAAAIAAYagAAAAED3Rztpw3fLlI99p6+IWS9onMwtrQMUjyHXE3BMCcponlJOS9APM9IbQBMUk0X2Fag==", "0235 6001 1807", "7309c106-4279-420b-8a4d-772d3b8ea2ff", "ThuyKhanh.Ha94@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "46483 Thụy Lâm Ranch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20Thanh%20Thi%C3%AAn", "9a7f8ac2-99fb-4903-8475-19b688f3bda7", new DateTime(2012, 11, 26, 0, 0, 0, 0, DateTimeKind.Local), "LamDong_Ngo@gmail.com", "Đoàn Thanh Thiên", 2, "LAMDONG_NGO@GMAIL.COM", "LAMDONG_NGO@GMAIL.COM", "AQAAAAIAAYagAAAAEPBdL41+t8St1+Lp7k1LFUnkIC5hq2dnR1Uu2itYbd1qpiOj9Ayhy+y9hir8yyu7lg==", "023 1767 0468", "b470eb53-3a1d-4d55-a702-45c7e9281b17", "LamDong_Ngo@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "527 Lê Stravenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Th%C3%BAy%20H%C6%B0%C6%A1ng", "6316611e-febf-4436-aae2-eba9fd001ca7", new DateTime(2000, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "NgocAi_Ngo38@hotmail.com", "Bùi Thúy Hương", 1, "NGOCAI_NGO38@HOTMAIL.COM", "NGOCAI_NGO38@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDNzdc1r1ERqn5ulLjH/CbYafyBPhto9hVHqbPtjV6rKtqYUe9DAgXWwxYSap4llrg==", "023 7123 2539", "c7246b43-adc7-436e-988b-e9f4ba1bb7a7", "NgocAi_Ngo38@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "78654 Thúy Vi Tunnel", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20L%C3%A2m%20%C3%90%E1%BB%93ng", "82f1181f-bede-4896-b02a-a5e1b2192832", new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "ChanPhong.Trinh@gmail.com", "Phùng Lâm Ðồng", 2, "CHANPHONG.TRINH@GMAIL.COM", "CHANPHONG.TRINH@GMAIL.COM", "AQAAAAIAAYagAAAAENna63akdVNbWZ+/0hWQ0QNII1QFmnJ619Pzot52FtwqIrksg6RZZhY7H/IywNlifQ==", "022 9715 9582", "db66b9c0-e917-4a97-9019-5f83f7b4379f", "ChanPhong.Trinh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "408 Quốc Hiền Fall", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Hu%E1%BB%87%20Ph%C6%B0%C6%A1ng", "3eeba0ed-c814-4fe7-894f-d7a732182b5d", new DateTime(1998, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), "TruongHiep4@yahoo.com", "Trịnh Huệ Phương", 2, "TRUONGHIEP4@YAHOO.COM", "TRUONGHIEP4@YAHOO.COM", "AQAAAAIAAYagAAAAENqdOSqrUitj2cfOQ6GBMrBwPWiq2CQnwXBf7LPBp3bm1VxlHO/Gv35ItdKfM2DTYg==", "020 1352 9878", "695f94e9-4cf7-4297-961f-45a7ce7b0d48", "TruongHiep4@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6294 Đoàn Way", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20H%E1%BA%A3i%20Nhi", "02bdd99f-37d2-4031-bc50-6dbef26f511b", new DateTime(1997, 6, 28, 0, 0, 0, 0, DateTimeKind.Local), "KyVo.Duong@yahoo.com", "Hoàng Hải Nhi", "KYVO.DUONG@YAHOO.COM", "KYVO.DUONG@YAHOO.COM", "AQAAAAIAAYagAAAAEIrab99PZ3s6YhKX0ecgRAtkMrQqBG84MIRWDiuFXaMyj74KgazrauD3+n4lntgtbg==", "0281 3348 7823", "795697e2-3775-406c-b691-20dea66376fd", "KyVo.Duong@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "24268 Kỳ Võ Station", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20Ph%C6%B0%C6%A1ng%20Chi", "2324db6e-ba96-46cb-b036-5dd5bf464de5", new DateTime(2005, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), "CongPhung.Ho@gmail.com", "Đỗ Phương Chi", 2, "CONGPHUNG.HO@GMAIL.COM", "CONGPHUNG.HO@GMAIL.COM", "AQAAAAIAAYagAAAAEC6ju0ngMMqmre+dGBGhFds5tjo2KAO9BbNKr9xbqA1HWs4xFss6q0r8JY1frh4wpw==", "0243 1466 0337", "9eb8775b-a85f-4d00-a67d-b1a226117deb", "CongPhung.Ho@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "35386 Trung Việt Groves", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BA%B7ng%20L%E1%BB%87%20Giang", "390b4547-6854-41bd-b76c-9ce9864788c1", new DateTime(2007, 5, 31, 0, 0, 0, 0, DateTimeKind.Local), "GiaHuan15@yahoo.com", "Đặng Lệ Giang", 2, "GIAHUAN15@YAHOO.COM", "GIAHUAN15@YAHOO.COM", "AQAAAAIAAYagAAAAEPlLrc/z57J//e6F/B/HWLksE8HtYz6YX7MJVS3HFsdt5ahGW+VQN36Z356jEzaEbA==", "0271 3085 2726", "fcecc80b-8667-454e-9b14-74cb85f6a8d9", "GiaHuan15@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1804 Phương Trạch Place", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ho%C3%A0ng%20Kim%20Thanh", "33ea0d50-2fe1-495c-8b7e-50be65588c9d", new DateTime(1996, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "SaoMai51@gmail.com", "Hoàng Kim Thanh", 3, "SAOMAI51@GMAIL.COM", "SAOMAI51@GMAIL.COM", "AQAAAAIAAYagAAAAEFLMictn8tHqg3W225U1ZF+ifTd23CrNyenFc/RHED0yTVX75RnH/ypZXHmboALBkg==", "0272 2069 3461", "cfbdd79d-cdc8-4ba8-aac6-e06d721d4f8f", "SaoMai51@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "4103 Đinh Square", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20Nam%20Ninh", "f395daed-04aa-488c-bfce-fe488d10fa35", new DateTime(2005, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "UyenMinh88@yahoo.com", "Nguyễn Nam Ninh", 2, "UYENMINH88@YAHOO.COM", "UYENMINH88@YAHOO.COM", "AQAAAAIAAYagAAAAEA6XiHbKjloNWh3dCXYqhouCLr5C+JYbU03ITaOXYsFalhLXwxvub9cYjk97QvoFsQ==", "021 1908 8701", "35210710-332a-4138-a497-123c2c83a31d", "UyenMinh88@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "118 Tuyết Băng Islands", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Th%C3%A1i%20Nguy%C3%AAn", "8a9d8117-2868-4a0f-81d5-ad68a410b0e0", new DateTime(2000, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "TuongVy.Dinh42@gmail.com", "Trịnh Thái Nguyên", 3, "TUONGVY.DINH42@GMAIL.COM", "TUONGVY.DINH42@GMAIL.COM", "AQAAAAIAAYagAAAAEOtq7GurOn7wVdvCyC4Lrg7VF3k5x2qByPG8q1RVZDnoFZoX0kP4hUaD+TH1qdNgTQ==", "0214 6107 4715", "34bd84bb-574d-42d8-9eaa-e69e6b249b9c", "TuongVy.Dinh42@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "102 Kim Tuyết Lane", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=V%C6%B0%C6%A1ng%20Huy%20Kha", "b8ddea28-7119-402e-bb96-c5d652a34fba", new DateTime(2005, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "XuanHuong37@yahoo.com", "Vương Huy Kha", "XUANHUONG37@YAHOO.COM", "XUANHUONG37@YAHOO.COM", "AQAAAAIAAYagAAAAEBR6j6faFxxhsQ/fpWGCxjREuSAabJRpMQf2fQLXpEDPgKHj+CsjisqVfkHGH8UZcQ==", "022 5464 5091", "c718c729-b793-4d9e-98f1-a07c92c66cb5", "XuanHuong37@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "04339 Viễn Phương Burg", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%C3%B9ng%20Duy%20Ti%E1%BA%BFp", "01a86b70-1446-4c65-abf3-76388ecbd191", new DateTime(1996, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "HungNgoc_Bui@hotmail.com", "Phùng Duy Tiếp", 2, "HUNGNGOC_BUI@HOTMAIL.COM", "HUNGNGOC_BUI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEDqI0ZJUS/c77JaxC74/k6e3cIjAPpOpvQ+h21wKQjzQSZTL/kfaitndj0KB7pMwUw==", "0222 2865 1218", "faf0c5ad-74ff-4d65-82c5-26d5c5f310f0", "HungNgoc_Bui@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "804 Bảo Giang Valleys", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Nguy%E1%BB%85n%20Minh%20Trung", "00082b16-78bb-4589-bc83-692d788572f5", new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "ChiMai41@hotmail.com", "Nguyễn Minh Trung", 2, "CHIMAI41@HOTMAIL.COM", "CHIMAI41@HOTMAIL.COM", "AQAAAAIAAYagAAAAELxQfA/vzDX62seHcoTSjZatpnS++8VAnMWBGDl/5596g5E1kyrcQ9qMrDIw4ylLVg==", "0260 5261 6904", "dbdf2444-959a-4fbf-8f02-2da432511038", "ChiMai41@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7272 Phúc Ðiền Crescent", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Quang%20Tri%E1%BB%81u", "366f885a-553c-44b7-9c38-bbb1f168fee5", new DateTime(2018, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "NhaHong_Tang34@gmail.com", "Tăng Quang Triều", 2, "NHAHONG_TANG34@GMAIL.COM", "NHAHONG_TANG34@GMAIL.COM", "AQAAAAIAAYagAAAAELkqxBsrpo+8k5QL7Bmn9/dfU8YnP35CsjeLPK+O3Qx0xdeZpzsmRS+JnrcKaPDEQw==", "021 0440 0183", "fce42301-a856-48ab-95a7-e82ef80bc963", "NhaHong_Tang34@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "073 Kim Vượng Walks", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20Qu%E1%BA%A3ng%20Th%C3%B4ng", "cf879847-a7eb-45b7-bed6-24170ff211c2", new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "NamThong39@yahoo.com", "Lâm Quảng Thông", "NAMTHONG39@YAHOO.COM", "NAMTHONG39@YAHOO.COM", "AQAAAAIAAYagAAAAEHnla8+C+l1uEDyBDN7Q5ghyKnH6OmthCTT4rP0KNR5tuPHWFtFx4M9ZthxKj7x7Gw==", "0270 8262 0984", "56c8314c-7945-4757-bd43-afebc80af2fc", "NamThong39@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "170 Kim Cương Circles", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Minh%20Tr%C3%AD", "8a5c7560-4734-465d-bbb3-a75897d6cd9f", new DateTime(2011, 12, 26, 0, 0, 0, 0, DateTimeKind.Local), "HoaiBac34@gmail.com", "Tăng Minh Trí", "HOAIBAC34@GMAIL.COM", "HOAIBAC34@GMAIL.COM", "AQAAAAIAAYagAAAAEP7HB7VCFGuzp/696Tb75IOVgeW/6TkU6fYyg4KO7445bZSil0h8czBhfWctiiVm9Q==", "0260 6820 4423", "d3d6c8b0-4250-4776-9499-86cf14e669e0", "HoaiBac34@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "918 Lâm Canyon", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C4%83ng%20Gia%20Kh%C3%A1nh", "c825f53f-17b6-4b26-979a-5c616de391eb", new DateTime(2003, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "KhoiVi.Vuong@gmail.com", "Tăng Gia Khánh", "KHOIVI.VUONG@GMAIL.COM", "KHOIVI.VUONG@GMAIL.COM", "AQAAAAIAAYagAAAAEHxz+sd5i3kkwTiUeyl0dHlakv2fNOlXVl1qhpRUQxWiVqjiTthJ8FlYr5PBGckXuw==", "0249 0167 0546", "acadb231-e6f9-40be-a4ba-7159f78f6ec3", "KhoiVi.Vuong@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "40478 Đặng Expressway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Phi%20%C3%90i%E1%BB%87p", "e38bdd82-874e-4d31-b237-8c93fb83a89a", new DateTime(2004, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "HaNhi.Dinh@hotmail.com", "Trịnh Phi Ðiệp", 2, "HANHI.DINH@HOTMAIL.COM", "HANHI.DINH@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFyCqO1qQXE65lvIcW6eZQpWCDj583vjaawp2o1RCJStCRBjViLALRMeSaIfq14I8A==", "029 9187 4786", "beda3ce2-0164-4a5d-b144-fac4cd193dc1", "HaNhi.Dinh@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9979 Nhật Huy Branch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%BD%20T%C3%B9ng%20Quang", "587c9cdf-d2d5-46e0-9713-c1a990a0dc4a", new DateTime(2006, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "AnhTu_Ho@gmail.com", "Lý Tùng Quang", 2, "ANHTU_HO@GMAIL.COM", "ANHTU_HO@GMAIL.COM", "AQAAAAIAAYagAAAAELATSYVfgm68DF+SM3a0+F7I92bZJhRa5apcWWU8KBI5fdeRjkVQXNEccaYTgbsrRg==", "0239 6584 2911", "fa6d71b9-6ee8-40df-881e-4e8520453c60", "AnhTu_Ho@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "47785 Quang Anh Manor", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20Trung%20Hi%E1%BA%BFu", "5bd5add2-cf5a-4ad9-b773-1218a8c9eda9", new DateTime(1996, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "TuDong_Phung64@hotmail.com", "Bùi Trung Hiếu", "TUDONG_PHUNG64@HOTMAIL.COM", "TUDONG_PHUNG64@HOTMAIL.COM", "AQAAAAIAAYagAAAAELUru/wGPYJ2ODWGneDZRfkPhAZJYnhF0Fde75EsnJgtOT2ueagWrVQFWX0mTmRwMg==", "0253 3098 2615", "2d81723d-354a-4ab0-93d1-d1f1f49df042", "TuDong_Phung64@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3226 Hoàng Shore", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=B%C3%B9i%20%C4%90%C3%B4ng%20Tr%C3%A0", "19d38330-5d51-4948-9220-56d974c3fc54", new DateTime(2014, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), "ThuyHang.Ho@yahoo.com", "Bùi Đông Trà", 1, "THUYHANG.HO@YAHOO.COM", "THUYHANG.HO@YAHOO.COM", "AQAAAAIAAYagAAAAEHjMn20S4dWDSg82DhQMhb6eSRrkB3D2H9WVHm/d5Y3Gmcxl44OBBJOSoRfhACvT2g==", "0255 5915 8423", "a19d0874-9c70-491c-ad79-e35f64e61b37", "ThuyHang.Ho@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "39654 Hạc Cúc Station", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Trung%20L%E1%BB%B1c", "938c260d-8c13-422d-a5f3-ec32865d4c4b", new DateTime(1996, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "DuyKhanh_Dang@gmail.com", "Trịnh Trung Lực", "DUYKHANH_DANG@GMAIL.COM", "DUYKHANH_DANG@GMAIL.COM", "AQAAAAIAAYagAAAAEB/Jo6VwCxfaG+/dJgOtb+cJ20TkbX4LjQMe3SYwKrhEgQEQtdpYFgT3Ioafun46bg==", "0285 4760 7247", "76f1a612-3ea6-46ff-ab98-8c069eca434e", "DuyKhanh_Dang@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "269 Lam Tuyền Camp", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Ph%C3%BAc%20C%C6%B0%E1%BB%9Dng", "91580804-0fec-40eb-af18-d73040004d47", new DateTime(2000, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "BinhNguyen.Vu62@hotmail.com", "Tô Phúc Cường", 2, "BINHNGUYEN.VU62@HOTMAIL.COM", "BINHNGUYEN.VU62@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGnDXzW4KQkcZXSNcdj7kke5fiY26MHmSDptfSZlLc9IsXd9gnZAABL5fBFTu9yZ2g==", "0268 6777 6080", "c8bb8e1a-1226-45e2-be41-dc8cfd7a5733", "BinhNguyen.Vu62@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1432 Xuân Lan Stravenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20Li%C3%AAn%20Ki%E1%BB%87t", "5cdb21a3-9200-4c11-b871-77a5ce7a3492", new DateTime(1999, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "NgocQue.Ly16@hotmail.com", "Hồ Liên Kiệt", "NGOCQUE.LY16@HOTMAIL.COM", "NGOCQUE.LY16@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHdFuOyAFDPiT7NMDABOEcDmMkU3BtDf8swp5SBI72MoDy6lNBeeD4wEFybqNvvN7Q==", "0229 8130 2871", "7b3da495-66cc-4b24-9e4e-9f7e1e49e4ee", "NgocQue.Ly16@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "87346 Hoàng Avenue", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=T%C3%B4%20Thi%20Y%E1%BA%BFn", "5daebea6-690f-4ae7-8a3d-534598c733cd", new DateTime(2005, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), "MaiChi23@hotmail.com", "Tô Thi Yến", 3, "MAICHI23@HOTMAIL.COM", "MAICHI23@HOTMAIL.COM", "AQAAAAIAAYagAAAAEC5lOBo80dowmhe5oh5dxssPNpi8H5awtHzb6laPEz1vFOAkiMVIdaqx7eMYB12T1g==", "020 5042 2538", "4ac16cf3-96c1-4ee6-b1bb-b01d2cd3799b", "MaiChi23@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "296 Trương Plain", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=H%E1%BB%93%20L%E1%BB%99c%20Uy%E1%BB%83n", "8bd75e2e-3889-4e23-b708-515f6fde818b", new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), "LinhLan_Ngo76@yahoo.com", "Hồ Lộc Uyển", "LINHLAN_NGO76@YAHOO.COM", "LINHLAN_NGO76@YAHOO.COM", "AQAAAAIAAYagAAAAEO8sIg64g53UWCQrW+wpKl2eidvo49xPqMPX7iPZmnajDqYrMQCuKSvsIa4IPhdpCw==", "0209 0921 0148", "1143b690-1b92-43de-83fd-7c021afb778d", "LinhLan_Ngo76@yahoo.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "76362 Phan Branch", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=D%C6%B0%C6%A1ng%20Kh%C3%A1nh%20My", "2c2dcf2b-38af-4b12-87c2-b20727ea4d52", new DateTime(1997, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), "DuyHung.Dao44@yahoo.com", "Dương Khánh My", "DUYHUNG.DAO44@YAHOO.COM", "DUYHUNG.DAO44@YAHOO.COM", "AQAAAAIAAYagAAAAELiUBtIelRi2hFtpDnFVxJYq6CpS/uUbu7OWQIG3jpIwt//wl5KbERgR2u/SfLtQDQ==", "0207 0630 2029", "32805932-5f76-4f74-8131-7fc756497a98", "DuyHung.Dao44@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8944 Vương Plain", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Ph%C6%B0%C6%A1ng%20Ng%E1%BB%8Dc", "ada7a9eb-e648-4496-986c-bd7e1df31f10", new DateTime(2017, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), "HuongLan90@gmail.com", "Mai Phương Ngọc", 1, "HUONGLAN90@GMAIL.COM", "HUONGLAN90@GMAIL.COM", "AQAAAAIAAYagAAAAEJDO2fU0EC0TbQQEkU+plzuL43b5VCmw17CLVpXwqfsAzUZjsskQhOoaegxWsAPo9w==", "025 5246 2969", "f35d0ae7-ef10-4e64-a79e-1b80132d3349", "HuongLan90@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "339 Đặng Square", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90o%C3%A0n%20Gia%20Phong", "54e0334f-75f6-4040-aa25-ca55c5502318", new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), "ThuyOanh.Dinh7@gmail.com", "Đoàn Gia Phong", "THUYOANH.DINH7@GMAIL.COM", "THUYOANH.DINH7@GMAIL.COM", "AQAAAAIAAYagAAAAEEzrekwC57Z5F+m1+MttC4tl+ybp1smKEJuFKT/VDMtCyGOaJ0IeKcgMQF8JtPlFHA==", "0247 4918 6350", "8d87cb21-22e0-4767-b4bf-9dfa447cd081", "ThuyOanh.Dinh7@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5040 Anh Ðức Oval", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Ph%E1%BA%A1m%20Phi%20H%C3%B9ng", "8d569cca-a5e7-4062-84b3-7a99dac0153c", new DateTime(2005, 6, 19, 0, 0, 0, 0, DateTimeKind.Local), "KimDuyen_Ha@hotmail.com", "Phạm Phi Hùng", 2, "KIMDUYEN_HA@HOTMAIL.COM", "KIMDUYEN_HA@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKVUPUM+WbzJYBjWfhsdQOau7/0dY+R/PRlUShFOHuaeYbkK2C4evLZ+KBqgUE1Edw==", "023 8525 9845", "112330e3-9692-459f-a2b7-7dac63abf65c", "KimDuyen_Ha@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "29036 Vân Chi Fords", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%E1%BB%8Bnh%20Thu%20Thu%E1%BA%ADn", "70b4c2e8-a877-412a-9fdd-6b1c2c33c4f5", new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "VanMinh_Tang@hotmail.com", "Trịnh Thu Thuận", 2, "VANMINH_TANG@HOTMAIL.COM", "VANMINH_TANG@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKkSvdGskoiBpQPw6BSITy5DQW07Feb2gzdFgae3GVU28qLbW1AcZzcLyA9KpDw05Q==", "0206 0743 2060", "19a74282-7d0c-4b43-aaca-d5674f39133f", "VanMinh_Tang@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "625 Lê Ramp", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90%E1%BB%97%20H%E1%BB%8Da%20Mi", "59a14830-0838-4c7c-ac2c-92febb59cd54", new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), "VanLy_Ly97@gmail.com", "Đỗ Họa Mi", 3, "VANLY_LY97@GMAIL.COM", "VANLY_LY97@GMAIL.COM", "AQAAAAIAAYagAAAAEP+gjyald7A9NUPCx9oElSHdMxec9mvO2lkrtwfPNBal7mZ4QhrHM7K7+UZRJo9Oow==", "024 5562 7611", "26c0bd96-17d3-400b-9e65-cadb6da71df9", "VanLy_Ly97@gmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6229 Tô Freeway", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=L%C3%A2m%20V%C3%A2n%20Ng%E1%BB%8Dc", "15e6f9ff-28ed-4d3f-8428-e2c71cd02599", new DateTime(1996, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "QuangKhai_Dao95@gmail.com", "Lâm Vân Ngọc", 1, "QUANGKHAI_DAO95@GMAIL.COM", "QUANGKHAI_DAO95@GMAIL.COM", "AQAAAAIAAYagAAAAEGUi1eevMzUfS9e54LAJxlWvsu8jhs0lYimsMwDw3z62jcUJZP6J6sjpsb3H5f4LVw==", "020 3641 7968", "64b1dc82-01eb-46c8-9c98-38e8d3fd32b1", "QuangKhai_Dao95@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "107 Anh Vũ Ports", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=%C4%90inh%20Kh%E1%BA%AFc%20Vi%E1%BB%87t", "a36c9cf3-7bcd-4826-ad64-9984ab8f4bdf", new DateTime(2001, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "MocMien_Dao51@hotmail.com", "Đinh Khắc Việt", 3, "MOCMIEN_DAO51@HOTMAIL.COM", "MOCMIEN_DAO51@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFiZDN2HQwrteKvE8HFrgD6fd1vtXMMzsZbUa1FXloGsoQJwKMMaY7+BLFVpF+38Ag==", "029 4627 6927", "5ca28de0-e055-4c00-9c3f-4239bfc1ad45", "MocMien_Dao51@hotmail.com" });

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
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6297 Nhã Khanh Pines", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Tr%C6%B0%C6%A1ng%20Thanh%20T%C3%B9ng", "6d0d583d-ce52-4461-a485-7a9b05c69e3e", new DateTime(2011, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), "MongThi98@gmail.com", "Trương Thanh Tùng", "MONGTHI98@GMAIL.COM", "MONGTHI98@GMAIL.COM", "AQAAAAIAAYagAAAAEO5rMvWK+elbQ4m1dhqmIpUYGf6oJ45e6vt8rF72T7DpTAnOb7RTQU4GspTIKFDvjA==", "026 0710 6205", "63ce09ad-1ed1-4266-8543-bd38bd77b70c", "MongThi98@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Address", "AvatarUrl", "ConcurrencyStamp", "DateOfBirth", "Email", "FullName", "Gender", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "024 Đinh Dam", "https://via.placeholder.com/250x250/cccccc/9c9c9c.png?text=Mai%20Phi%20Khanh", "564def9b-ae6e-4222-b950-b13b443657af", new DateTime(1997, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), "VinhDieu75@yahoo.com", "Mai Phi Khanh", 3, "VINHDIEU75@YAHOO.COM", "VINHDIEU75@YAHOO.COM", "AQAAAAIAAYagAAAAEBPHwvZFW3Y8viWMVdpbUtKVAkNqgGW59hO8y1L990TK1dDiL88InLSHUGuUN6H1ag==", "0274 4423 2234", "f21e4501-cad4-4fe0-aeb0-44750507ccc3", "VinhDieu75@yahoo.com" });
        }
    }
}
