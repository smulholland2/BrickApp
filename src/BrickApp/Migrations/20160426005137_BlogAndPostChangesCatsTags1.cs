using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace brickapp.Migrations
{
    public partial class BlogAndPostChangesCatsTags1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Post_Blog_BlogId", table: "Post");
            migrationBuilder.DropColumn(name: "Url", table: "Blog");
            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Post",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Blog",
                nullable: true);
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
            migrationBuilder.DropColumn(name: "Tags", table: "Post");
            migrationBuilder.DropColumn(name: "Category", table: "Blog");
            migrationBuilder.AddColumn<int>(
                name: "Url",
                table: "Blog",
                nullable: false,
                defaultValue: 0);
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
