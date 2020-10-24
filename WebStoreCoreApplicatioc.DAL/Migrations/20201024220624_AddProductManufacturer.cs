﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStoreCoreApplicatioc.DAL.Migrations
{
    public partial class AddProductManufacturer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Products");
        }
    }
}
