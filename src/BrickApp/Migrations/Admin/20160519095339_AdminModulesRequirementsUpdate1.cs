using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace brickapp.Migrations.Admin
{
    public partial class AdminModulesRequirementsUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Message_TeamMember_SenderTeamMemberId", table: "Message");
            migrationBuilder.AlterColumn<string>(
                name: "Task",
                table: "TeamTask",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "User",
                table: "Notification",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Messsage",
                table: "Notification",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "SenderTeamMemberId",
                table: "Message",
                nullable: false);
            migrationBuilder.AddForeignKey(
                name: "FK_Message_TeamMember_SenderTeamMemberId",
                table: "Message",
                column: "SenderTeamMemberId",
                principalTable: "TeamMember",
                principalColumn: "TeamMemberId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Message_TeamMember_SenderTeamMemberId", table: "Message");
            migrationBuilder.AlterColumn<string>(
                name: "Task",
                table: "TeamTask",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "User",
                table: "Notification",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Messsage",
                table: "Notification",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "SenderTeamMemberId",
                table: "Message",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Message_TeamMember_SenderTeamMemberId",
                table: "Message",
                column: "SenderTeamMemberId",
                principalTable: "TeamMember",
                principalColumn: "TeamMemberId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
