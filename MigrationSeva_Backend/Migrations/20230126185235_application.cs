using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationSeva_Backend.Migrations
{
    public partial class application : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblapplication",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phoneno = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    Dob = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Pincode = table.Column<string>(nullable: true),
                    PlacetoMigrate = table.Column<string>(nullable: true),
                    PurposetoMigrate = table.Column<string>(nullable: true),
                    AadharNumber = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    RemarksByPolice = table.Column<string>(nullable: true),
                    DateofApplied = table.Column<string>(nullable: true),
                    DateofAdminStatus = table.Column<string>(nullable: true),
                    DateofPoliceStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblapplication", x => x.ApplicationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblapplication");
        }
    }
}
