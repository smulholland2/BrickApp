using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace brickapp.Migrations.Admin
{
    public partial class AdminModulesAdd1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    NotificationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Messsage = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.NotificationId);
                });
            migrationBuilder.CreateTable(
                name: "TeamTask",
                columns: table => new
                {
                    TeamTaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Task = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamTask", x => x.TeamTaskId);
                });
            migrationBuilder.CreateTable(
                name: "Warning",
                columns: table => new
                {
                    WarningId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Message = table.Column<string>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    WarningDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warning", x => x.WarningId);
                });
            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateSent = table.Column<DateTime>(nullable: false),
                    SenderTeamMemberId = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.MessageId);
                });
            migrationBuilder.CreateTable(
                name: "TeamMember",
                columns: table => new
                {
                    TeamMemberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Avatar = table.Column<string>(nullable: true),
                    MemberName = table.Column<string>(nullable: false),
                    MessageMessageId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    TeamTaskTeamTaskId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMember", x => x.TeamMemberId);
                    table.ForeignKey(
                        name: "FK_TeamMember_Message_MessageMessageId",
                        column: x => x.MessageMessageId,
                        principalTable: "Message",
                        principalColumn: "MessageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamMember_TeamTask_TeamTaskTeamTaskId",
                        column: x => x.TeamTaskTeamTaskId,
                        principalTable: "TeamTask",
                        principalColumn: "TeamTaskId",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.AddForeignKey(
                name: "FK_Message_TeamMember_SenderTeamMemberId",
                table: "Message",
                column: "SenderTeamMemberId",
                principalTable: "TeamMember",
                principalColumn: "TeamMemberId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_TeamMember_Message_MessageMessageId", table: "TeamMember");
            migrationBuilder.DropTable("Notification");
            migrationBuilder.DropTable("Warning");
            migrationBuilder.DropTable("Message");
            migrationBuilder.DropTable("TeamMember");
            migrationBuilder.DropTable("TeamTask");
        }
    }
}
