using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Chat.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Channels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    IsAdmin = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChannelUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ChannelId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChannelUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChannelUsers_Channels_ChannelId",
                        column: x => x.ChannelId,
                        principalTable: "Channels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChannelUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrivateMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    UserSentId = table.Column<int>(type: "integer", nullable: false),
                    UserReceivedId = table.Column<int>(type: "integer", nullable: false),
                    TimeSent = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrivateMessages_Users_UserReceivedId",
                        column: x => x.UserReceivedId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrivateMessages_Users_UserSentId",
                        column: x => x.UserSentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MessagesInTheChannel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    ChannelUserId = table.Column<int>(type: "integer", nullable: false),
                    TimeSent = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ChannelId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessagesInTheChannel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessagesInTheChannel_ChannelUsers_ChannelUserId",
                        column: x => x.ChannelUserId,
                        principalTable: "ChannelUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MessagesInTheChannel_Channels_ChannelId",
                        column: x => x.ChannelId,
                        principalTable: "Channels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MessagesInTheChannel_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Da van se zalin malo" },
                    { 2, "Goz" },
                    { 3, "Parizzz" },
                    { 4, "Girls" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "Password" },
                values: new object[,]
                {
                    { 1, "luce@pmf.st", true, "1234" },
                    { 2, "ana@fesb.hr", false, "12345" },
                    { 3, "paula@fesb.hr", false, "lucijalucija" },
                    { 4, "josip@fesb.hr", false, "4321" },
                    { 5, "jurin@efst.hr", false, "01.12." },
                    { 6, "gabi@fesb.hr", false, "fesb" },
                    { 7, "nada@mefst.hr", false, "sokol" }
                });

            migrationBuilder.InsertData(
                table: "ChannelUsers",
                columns: new[] { "Id", "ChannelId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 3 },
                    { 3, 1, 6 },
                    { 4, 2, 1 },
                    { 5, 2, 3 },
                    { 6, 2, 5 },
                    { 7, 3, 1 },
                    { 8, 3, 2 },
                    { 9, 3, 3 },
                    { 10, 3, 6 },
                    { 11, 4, 1 },
                    { 12, 4, 3 },
                    { 13, 4, 7 }
                });

            migrationBuilder.InsertData(
                table: "PrivateMessages",
                columns: new[] { "Id", "Content", "TimeSent", "UserReceivedId", "UserSentId" },
                values: new object[,]
                {
                    { 1, "Sretan rodendan sunce Voli  te puuuuno", new DateTime(2017, 6, 23, 0, 0, 10, 0, DateTimeKind.Utc), 3, 1 },
                    { 2, "hvala tii", new DateTime(2017, 6, 23, 0, 1, 10, 0, DateTimeKind.Utc), 1, 3 },
                    { 3, "Sretan rockas Love you", new DateTime(2017, 7, 24, 0, 0, 10, 0, DateTimeKind.Utc), 1, 3 },
                    { 4, "Hvala tiiii", new DateTime(2017, 6, 23, 0, 0, 10, 0, DateTimeKind.Utc), 3, 1 },
                    { 5, "Opet me zaustavila policija", new DateTime(2023, 8, 27, 2, 7, 10, 0, DateTimeKind.Utc), 1, 4 },
                    { 6, "Naplatili su mi kaznu zbog registracije", new DateTime(2023, 8, 27, 2, 7, 30, 0, DateTimeKind.Utc), 1, 4 },
                    { 7, "Nemoj me zezat", new DateTime(2023, 8, 27, 2, 31, 10, 0, DateTimeKind.Utc), 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "MessagesInTheChannel",
                columns: new[] { "Id", "ChannelId", "ChannelUserId", "Content", "TimeSent", "UserId" },
                values: new object[,]
                {
                    { 1, null, 1, "Fun fact", new DateTime(2023, 11, 10, 22, 18, 10, 0, DateTimeKind.Utc), null },
                    { 2, null, 1, "Pukla mi je cizme", new DateTime(2023, 11, 10, 22, 18, 10, 0, DateTimeKind.Utc), null },
                    { 3, null, 1, "", new DateTime(2023, 11, 10, 22, 18, 10, 0, DateTimeKind.Utc), null },
                    { 4, null, 1, "Josip je dozivia tu svadu", new DateTime(2023, 11, 10, 22, 18, 10, 0, DateTimeKind.Utc), null },
                    { 5, null, 1, "Al kupuje mi nove", new DateTime(2023, 11, 10, 22, 18, 10, 0, DateTimeKind.Utc), null },
                    { 6, null, 2, "bro", new DateTime(2023, 11, 10, 22, 21, 10, 0, DateTimeKind.Utc), null },
                    { 7, null, 2, "kako ih je pukla", new DateTime(2023, 11, 10, 22, 21, 10, 0, DateTimeKind.Utc), null },
                    { 8, null, 3, "STA", new DateTime(2023, 11, 10, 22, 35, 10, 0, DateTimeKind.Utc), null },
                    { 9, null, 4, "Jel iko od vas auto", new DateTime(2023, 4, 16, 10, 10, 10, 0, DateTimeKind.Utc), null },
                    { 10, null, 6, "Ja vas mogu skupit", new DateTime(2023, 4, 16, 10, 12, 10, 0, DateTimeKind.Utc), null },
                    { 11, null, 5, "ma ja cu ic", new DateTime(2023, 4, 16, 10, 13, 10, 0, DateTimeKind.Utc), null },
                    { 12, null, 5, "ne kasni mi se", new DateTime(2023, 4, 16, 10, 13, 10, 0, DateTimeKind.Utc), null },
                    { 13, null, 6, "Nece ti nista bit ako jednom zakasnis", new DateTime(2023, 4, 16, 10, 13, 30, 0, DateTimeKind.Utc), null },
                    { 14, null, 5, "ma ne zelin kasnit", new DateTime(2023, 4, 16, 10, 14, 10, 0, DateTimeKind.Utc), null },
                    { 15, null, 4, "Kad me kupis", new DateTime(2023, 4, 16, 10, 14, 10, 0, DateTimeKind.Utc), null },
                    { 16, null, 9, "kakav nan je apartman", new DateTime(2022, 10, 1, 14, 13, 10, 0, DateTimeKind.Utc), null },
                    { 17, null, 9, "i luci se ugasia mob", new DateTime(2022, 10, 1, 14, 13, 18, 0, DateTimeKind.Utc), null },
                    { 18, null, 8, "Standardno", new DateTime(2022, 10, 1, 14, 14, 10, 0, DateTimeKind.Utc), null },
                    { 19, null, 10, "predobro je", new DateTime(2022, 10, 1, 14, 16, 10, 0, DateTimeKind.Utc), null },
                    { 20, null, 10, "ima masu prostpra", new DateTime(2022, 10, 1, 14, 16, 23, 0, DateTimeKind.Utc), null },
                    { 21, null, 12, "jel mogu napisat", new DateTime(2023, 8, 15, 20, 0, 10, 0, DateTimeKind.Utc), null },
                    { 22, null, 12, "pala je na thirst trap", new DateTime(2023, 8, 15, 20, 0, 10, 0, DateTimeKind.Utc), null },
                    { 23, null, 11, "Zato ne smin lajkat sliku", new DateTime(2023, 8, 15, 20, 1, 10, 0, DateTimeKind.Utc), null },
                    { 24, null, 11, "I pisi sta oces", new DateTime(2023, 8, 15, 20, 2, 10, 0, DateTimeKind.Utc), null },
                    { 25, null, 12, "hvala", new DateTime(2023, 8, 15, 20, 3, 10, 0, DateTimeKind.Utc), null },
                    { 26, null, 11, "Al ces mi poslat sta odg", new DateTime(2023, 8, 15, 20, 4, 10, 0, DateTimeKind.Utc), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChannelUsers_ChannelId",
                table: "ChannelUsers",
                column: "ChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_ChannelUsers_UserId",
                table: "ChannelUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MessagesInTheChannel_ChannelId",
                table: "MessagesInTheChannel",
                column: "ChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_MessagesInTheChannel_ChannelUserId",
                table: "MessagesInTheChannel",
                column: "ChannelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MessagesInTheChannel_UserId",
                table: "MessagesInTheChannel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMessages_UserReceivedId",
                table: "PrivateMessages",
                column: "UserReceivedId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMessages_UserSentId",
                table: "PrivateMessages",
                column: "UserSentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessagesInTheChannel");

            migrationBuilder.DropTable(
                name: "PrivateMessages");

            migrationBuilder.DropTable(
                name: "ChannelUsers");

            migrationBuilder.DropTable(
                name: "Channels");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
