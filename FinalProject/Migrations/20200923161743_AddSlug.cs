﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class AddSlug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Companies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Companies");
        }
    }
}
