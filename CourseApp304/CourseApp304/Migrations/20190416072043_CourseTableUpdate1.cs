using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseApp304.Migrations
{
    public partial class CourseTableUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Deneme",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deneme",
                table: "Courses");
        }
    }
}
