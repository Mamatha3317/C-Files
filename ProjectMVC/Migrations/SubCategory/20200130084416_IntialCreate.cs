using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectMVC.Migrations.SubCategory
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Sub_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cid = table.Column<int>(nullable: false),
                    Cname = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Sub_name = table.Column<string>(nullable: true),
                    GST = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Sub_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}
