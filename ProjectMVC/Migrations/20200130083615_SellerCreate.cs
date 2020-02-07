using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectMVC.Migrations
{
    public partial class SellerCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Sname = table.Column<string>(nullable: false),
                    Companyname = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Semail = table.Column<string>(nullable: true),
                    Spassword = table.Column<string>(nullable: true),
                    Saddress = table.Column<string>(nullable: true),
                    Contactno = table.Column<int>(nullable: false),
                    Sid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Sname);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
