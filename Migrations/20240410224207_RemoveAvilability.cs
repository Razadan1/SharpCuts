using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desktop.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAvilability : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Barbers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Availability",
                table: "Barbers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
