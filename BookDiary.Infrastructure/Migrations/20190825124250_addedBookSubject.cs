using Microsoft.EntityFrameworkCore.Migrations;

namespace BookDiary.Infrastructure.Migrations
{
    public partial class addedBookSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Books");
        }
    }
}
