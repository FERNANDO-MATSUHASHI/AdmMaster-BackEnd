using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atendimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    qru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    km = table.Column<int>(type: "int", nullable: false),
                    valor_total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    data_nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    criado_em = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cep = table.Column<int>(type: "int", nullable: false),
                    rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numero = table.Column<int>(type: "int", nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ativo = table.Column<bool>(type: "bit", nullable: false),
                    comissao = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    gerenteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Viatura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sigla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    obs_vtr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtendimentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viatura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Viatura_Atendimento_AtendimentoId",
                        column: x => x.AtendimentoId,
                        principalTable: "Atendimento",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cargo_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViaturaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Servico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tipo_Servico_Viatura_ViaturaId",
                        column: x => x.ViaturaId,
                        principalTable: "Viatura",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Viatura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViaturaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Viatura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tipo_Viatura_Viatura_ViaturaId",
                        column: x => x.ViaturaId,
                        principalTable: "Viatura",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valor_saida = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valor_km = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ViaturaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculo_Viatura_ViaturaId",
                        column: x => x.ViaturaId,
                        principalTable: "Viatura",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Nivel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nivel = table.Column<int>(type: "int", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nivel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nivel_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Veiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeiculoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Veiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tipo_Veiculo_Veiculo_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_UsuarioId",
                table: "Cargo",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Nivel_CargoId",
                table: "Nivel",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Servico_ViaturaId",
                table: "Tipo_Servico",
                column: "ViaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Veiculo_VeiculoId",
                table: "Tipo_Veiculo",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_Viatura_ViaturaId",
                table: "Tipo_Viatura",
                column: "ViaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_cpf",
                table: "Usuario",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_email",
                table: "Usuario",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_ViaturaId",
                table: "Veiculo",
                column: "ViaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Viatura_AtendimentoId",
                table: "Viatura",
                column: "AtendimentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nivel");

            migrationBuilder.DropTable(
                name: "Tipo_Servico");

            migrationBuilder.DropTable(
                name: "Tipo_Veiculo");

            migrationBuilder.DropTable(
                name: "Tipo_Viatura");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Viatura");

            migrationBuilder.DropTable(
                name: "Atendimento");
        }
    }
}
