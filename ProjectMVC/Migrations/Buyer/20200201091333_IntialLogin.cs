using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectMVC.Migrations.Buyer
{
    public partial class IntialLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Buyers",
                table: "Buyers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Buyers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Buyers");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Buyers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Buyers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Buyers");

            migrationBuilder.AddColumn<int>(
                name: "Bid",
                table: "Buyers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Baddress",
                table: "Buyers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bmail",
                table: "Buyers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bname",
                table: "Buyers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bpassword",
                table: "Buyers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Buyers",
                table: "Buyers",
                column: "Bid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Buyers",
                table: "Buyers");

            migrationBuilder.DropColumn(
                name: "Bid",
                table: "Buyers");

            migrationBuilder.DropColumn(
                name: "Baddress",
                table: "Buyers");

            migrationBuilder.DropColumn(
                name: "Bmail",
                table: "Buyers");

            migrationBuilder.DropColumn(
                name: "Bname",
                table: "Buyers");

            migrationBuilder.DropColumn(
                name: "Bpassword",
                table: "Buyers");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Buyers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Buyers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Buyers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Buyers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Buyers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Buyers",
                table: "Buyers",
                column: "Id");
        }
    }
}
