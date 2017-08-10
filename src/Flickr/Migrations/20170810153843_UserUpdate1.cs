using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flickr.Migrations
{
    public partial class UserUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_AspNetUsers_UserId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_UserId",
                table: "Photos");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Photos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Photos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserId",
                table: "Photos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_AspNetUsers_UserId",
                table: "Photos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
