using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrackAndGo.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedInterestTypeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointOfInterests_InterestTypes_InterestTypeId",
                table: "PointOfInterests");

            migrationBuilder.DropTable(
                name: "InterestTypes");

            migrationBuilder.DropIndex(
                name: "IX_PointOfInterests_InterestTypeId",
                table: "PointOfInterests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InterestTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "InterestTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Monastery" },
                    { 2, "Hiking" },
                    { 3, "Sight-seeing" },
                    { 4, "Fortress" },
                    { 5, "Castle" },
                    { 6, "Winery" },
                    { 7, "Caving" },
                    { 8, "Nature reserve" },
                    { 9, "Entertainment" },
                    { 10, "Museum" },
                    { 11, "Farm" },
                    { 12, "Zoo" },
                    { 13, "Lake" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PointOfInterests_InterestTypeId",
                table: "PointOfInterests",
                column: "InterestTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PointOfInterests_InterestTypes_InterestTypeId",
                table: "PointOfInterests",
                column: "InterestTypeId",
                principalTable: "InterestTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
