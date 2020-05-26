using Microsoft.EntityFrameworkCore.Migrations;

namespace Project3.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LinkMediaPerson",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkMediaPerson", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    path = table.Column<string>(nullable: true),
                    place = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    LinkMediaPersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Media_LinkMediaPerson_LinkMediaPersonId",
                        column: x => x.LinkMediaPersonId,
                        principalTable: "LinkMediaPerson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    LinkMediaPersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_LinkMediaPerson_LinkMediaPersonId",
                        column: x => x.LinkMediaPersonId,
                        principalTable: "LinkMediaPerson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Media_LinkMediaPersonId",
                table: "Media",
                column: "LinkMediaPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_LinkMediaPersonId",
                table: "Person",
                column: "LinkMediaPersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "LinkMediaPerson");
        }
    }
}
