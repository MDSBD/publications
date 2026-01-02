using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace publications.Migrations
{
    /// <inheritdoc />
    public partial class addcherch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Idchercheurs",
                table: "Publications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idchercheurs",
                table: "Publications");
        }
    }
}
