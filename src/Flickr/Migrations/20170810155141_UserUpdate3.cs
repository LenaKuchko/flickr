using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flickr.Migrations
{
    public partial class UserUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_AspNetUsers_ApplicationUserId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_ApplicationUserId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Photos");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_AspNetUsers_UserId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_UserId",
                table: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Photos",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Photos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ApplicationUserId",
                table: "Photos",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_AspNetUsers_ApplicationUserId",
                table: "Photos",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
