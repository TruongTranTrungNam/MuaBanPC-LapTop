using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MuaBanPC_LapTop.Migrations
{
    public partial class themanh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayMua",
                table: "DonHang");

            migrationBuilder.AlterColumn<string>(
                name: "TenSP",
                table: "DonHang",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CauHinh",
                table: "DonHang",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "DonHang",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CauHinh",
                table: "DonHang");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "DonHang");

            migrationBuilder.AlterColumn<string>(
                name: "TenSP",
                table: "DonHang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayMua",
                table: "DonHang",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
