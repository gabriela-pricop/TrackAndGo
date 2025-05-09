using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackAndGo.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedLatitudeAndLongitudeLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "PointOfInterests",
                type: "decimal(9,7)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "PointOfInterests",
                type: "decimal(9,7)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Hotels",
                type: "decimal(9,7)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Hotels",
                type: "decimal(9,7)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,6)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "PointOfInterests",
                type: "decimal(9,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,7)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "PointOfInterests",
                type: "decimal(9,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,7)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Hotels",
                type: "decimal(9,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,7)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Hotels",
                type: "decimal(9,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,7)");
        }
    }
}
