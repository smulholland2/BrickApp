using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace brickapp.Migrations
{
    public partial class GalleryFKey1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Post_Blog_BlogId", table: "Post");
            migrationBuilder.AddColumn<int>(
                name: "GalleryId",
                table: "GalleryContent",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddForeignKey(
                name: "FK_GalleryContent_Gallery_GalleryId",
                table: "GalleryContent",
                column: "GalleryId",
                principalTable: "Gallery",
                principalColumn: "GalleryId",
                onDelete: ReferentialAction.Cascade);
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
            migrationBuilder.DropForeignKey(name: "FK_GalleryContent_Gallery_GalleryId", table: "GalleryContent");
            migrationBuilder.DropForeignKey(name: "FK_Post_Blog_BlogId", table: "Post");
            migrationBuilder.DropColumn(name: "GalleryId", table: "GalleryContent");
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
