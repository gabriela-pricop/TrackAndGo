﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackAndGo.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedAddressToPointOfInterest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "PointOfInterests",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "PointOfInterests");
        }
    }
}
