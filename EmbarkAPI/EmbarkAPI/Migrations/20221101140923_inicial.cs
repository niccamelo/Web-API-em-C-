using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmbarkAPI.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    cep = table.Column<int>(type: "int", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    sobre_nome = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    estado = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id_cliente);
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    id_compra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_compra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nome_cliente = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    quantidade_compra = table.Column<int>(type: "int", nullable: false),
                    destino = table.Column<DateTime>(type: "datetime2", maxLength: 40, nullable: false),
                    valor_compra = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.id_compra);
                });

            migrationBuilder.CreateTable(
                name: "Hospedagem",
                columns: table => new
                {
                    Id_hosp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_hosp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    estado = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    rua = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospedagem", x => x.Id_hosp);
                });

            migrationBuilder.CreateTable(
                name: "Pct_viagem",
                columns: table => new
                {
                    Id_destino = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    preco = table.Column<int>(type: "int", nullable: false),
                    data_da_viagem = table.Column<DateTime>(type: "datetime2", nullable: false),
                    destno = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    veiculo = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pct_viagem", x => x.Id_destino);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Hospedagem");

            migrationBuilder.DropTable(
                name: "Pct_viagem");
        }
    }
}
