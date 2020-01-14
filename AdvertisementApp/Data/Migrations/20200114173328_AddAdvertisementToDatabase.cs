using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvertisementApp.Data.Migrations
{
    public partial class AddAdvertisementToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertisement",
                columns: table => new
                {
                    AdvertisementId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertisementTitle = table.Column<string>(nullable: false),
                    AdvertisementPrice = table.Column<int>(nullable: false),
                    AdvertisementContactNumber = table.Column<int>(nullable: false),
                    AdvertisementLocation = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisement", x => x.AdvertisementId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisement");
        }
    }
}
