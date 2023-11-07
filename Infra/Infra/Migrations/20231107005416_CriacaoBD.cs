using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nivel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nivel = table.Column<int>(type: "int", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nivel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Servico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Veiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Veiculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Viatura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Viatura", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nivelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cargo_Nivel_nivelId",
                        column: x => x.nivelId,
                        principalTable: "Nivel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Viatura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sigla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    obs_vtr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_ViaturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viatura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Viatura_Tipo_Viatura_Tipo_ViaturaId",
                        column: x => x.Tipo_ViaturaId,
                        principalTable: "Tipo_Viatura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    gerenteId = table.Column<int>(type: "int", nullable: true),
                    cargoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Cargo_cargoId",
                        column: x => x.cargoId,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valor_saida = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valor_km = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    adicional_noturno = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    hora_parada = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_ServicoId = table.Column<int>(type: "int", nullable: false),
                    Tipo_VeiculoId = table.Column<int>(type: "int", nullable: false),
                    viaturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculo_Tipo_Servico_Tipo_ServicoId",
                        column: x => x.Tipo_ServicoId,
                        principalTable: "Tipo_Servico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Veiculo_Tipo_Veiculo_Tipo_VeiculoId",
                        column: x => x.Tipo_VeiculoId,
                        principalTable: "Tipo_Veiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Veiculo_Viatura_viaturaId",
                        column: x => x.viaturaId,
                        principalTable: "Viatura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Atendimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    qru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    km = table.Column<int>(type: "int", nullable: true),
                    noturno = table.Column<bool>(type: "bit", nullable: true),
                    qtd_hora_parada = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    obs_hora_parada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hospedagem = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    qtd_pedagio = table.Column<int>(type: "int", nullable: true),
                    pedagio = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    valor_total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    em_analise = table.Column<bool>(type: "bit", nullable: true),
                    viaturaId = table.Column<int>(type: "int", nullable: false),
                    usuarioId = table.Column<int>(type: "int", nullable: false),
                    tipoVeiculoId = table.Column<int>(type: "int", nullable: false),
                    Tipo_VeiculoId = table.Column<int>(type: "int", nullable: true),
                    tipoServicoId = table.Column<int>(type: "int", nullable: false),
                    Tipo_ServicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atendimento_Tipo_Servico_Tipo_ServicoId",
                        column: x => x.Tipo_ServicoId,
                        principalTable: "Tipo_Servico",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Atendimento_Tipo_Veiculo_Tipo_VeiculoId",
                        column: x => x.Tipo_VeiculoId,
                        principalTable: "Tipo_Veiculo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Atendimento_Usuario_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atendimento_Viatura_viaturaId",
                        column: x => x.viaturaId,
                        principalTable: "Viatura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Despesas_Atendimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtendimentoId = table.Column<int>(type: "int", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despesas_Atendimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Despesas_Atendimento_Atendimento_AtendimentoId",
                        column: x => x.AtendimentoId,
                        principalTable: "Atendimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_Tipo_ServicoId",
                table: "Atendimento",
                column: "Tipo_ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_Tipo_VeiculoId",
                table: "Atendimento",
                column: "Tipo_VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_usuarioId",
                table: "Atendimento",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_viaturaId",
                table: "Atendimento",
                column: "viaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_nivelId",
                table: "Cargo",
                column: "nivelId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesas_Atendimento_AtendimentoId",
                table: "Despesas_Atendimento",
                column: "AtendimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_cargoId",
                table: "Usuario",
                column: "cargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_Tipo_ServicoId",
                table: "Veiculo",
                column: "Tipo_ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_Tipo_VeiculoId",
                table: "Veiculo",
                column: "Tipo_VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_viaturaId",
                table: "Veiculo",
                column: "viaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Viatura_Tipo_ViaturaId",
                table: "Viatura",
                column: "Tipo_ViaturaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Despesas_Atendimento");

            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "Atendimento");

            migrationBuilder.DropTable(
                name: "Tipo_Servico");

            migrationBuilder.DropTable(
                name: "Tipo_Veiculo");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Viatura");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Tipo_Viatura");

            migrationBuilder.DropTable(
                name: "Nivel");
        }
    }
}
