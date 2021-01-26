using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendApi.DataAccessLayer.Migrations
{
    public partial class AddingEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(nullable: true),
                    Soyadi = table.Column<string>(nullable: true),
                    Telefonu = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Silindi_mi = table.Column<bool>(nullable: false),
                    Aktif = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
