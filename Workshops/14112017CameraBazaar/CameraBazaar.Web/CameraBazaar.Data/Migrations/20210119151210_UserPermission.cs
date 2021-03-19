using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CameraBazaar.Data.Migrations
{
    public partial class UserPermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resolution",
                table: "Cameras");

            migrationBuilder.RenameColumn(
                name: "MaxShutterSpeed",
                table: "Cameras",
                newName: "MaxShutterSPeed");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Cameras",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AddColumn<string>(
                name: "VideoResolution",
                table: "Cameras",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsBanned",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoResolution",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "IsBanned",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "MaxShutterSPeed",
                table: "Cameras",
                newName: "MaxShutterSpeed");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Cameras",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Resolution",
                table: "Cameras",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }
    }
}
