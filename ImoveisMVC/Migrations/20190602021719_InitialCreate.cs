using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImoveisMVC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imovel",
                columns: table => new
                {
                    IdImovel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DscImovel = table.Column<string>(maxLength: 100, nullable: false),
                    VlrImovel = table.Column<decimal>(nullable: false),
                    NumQrtImovel = table.Column<int>(nullable: false),
                    NumVagImovel = table.Column<int>(nullable: false),
                    TipImovel = table.Column<string>(maxLength: 1, nullable: false),
                    RuaImovel = table.Column<string>(maxLength: 100, nullable: false),
                    BroImovel = table.Column<string>(maxLength: 30, nullable: false),
                    CddImovel = table.Column<string>(maxLength: 30, nullable: false),
                    UFImovel = table.Column<string>(maxLength: 2, nullable: false),
                    CEPImovel = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imovel", x => x.IdImovel);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imovel");
        }
    }
}
