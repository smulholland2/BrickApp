using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace brickapp.Migrations
{
    public partial class AddedStatusToBlogPost1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Post_Blog_BlogId", table: "Post");
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Post",
                nullable: false,
                defaultValue: BrickApp.Models.Status.Active);
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Blog",
                nullable: false,
                defaultValue: BrickApp.Models.Status.Active);
            migrationBuilder.AddForeignKey(
                name: "FK_Post_Blog_BlogId",
                table: "Post",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Post_Blog_BlogId", table: "Post");
            migrationBuilder.DropColumn(name: "Status", table: "Post");
            migrationBuilder.DropColumn(name: "Status", table: "Blog");
            migrationBuilder.AddForeignKey(
                name: "FK_Post_Blog_BlogId",
                table: "Post",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
