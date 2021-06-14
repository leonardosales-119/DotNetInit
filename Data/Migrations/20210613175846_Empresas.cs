using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace comeiaT.Data.Migrations
{
    public partial class Empresas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNPJ = table.Column<string>(nullable: true),
                    NOME_FANTASIA = table.Column<string>(nullable: true),
                    TELEFONE = table.Column<string>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true),
                    DATA_DO_CADASTRO = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
