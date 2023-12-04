﻿// <auto-generated />
using System;
using Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(SqlContext))]
    partial class SqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entites.Abastecimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("data_abastecimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("fornecedorId")
                        .HasColumnType("int");

                    b.Property<int>("gerenteId")
                        .HasColumnType("int");

                    b.Property<int>("tipo_combustivelId")
                        .HasColumnType("int");

                    b.Property<decimal?>("valor_total_abastecimento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("valor_unid_abastecimento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("viaturaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("fornecedorId");

                    b.HasIndex("tipo_combustivelId");

                    b.HasIndex("viaturaId");

                    b.ToTable("Abastecimento", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Tipo_ServicoId")
                        .HasColumnType("int");

                    b.Property<int?>("Tipo_VeiculoId")
                        .HasColumnType("int");

                    b.Property<decimal>("adicionais")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("ativo")
                        .HasColumnType("bit");

                    b.Property<bool?>("cancelado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("em_analise")
                        .HasColumnType("bit");

                    b.Property<int>("gerenteId")
                        .HasColumnType("int");

                    b.Property<decimal?>("hospedagem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("km")
                        .HasColumnType("int");

                    b.Property<bool?>("noturno")
                        .HasColumnType("bit");

                    b.Property<string>("obs_adicionais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("obs_hora_parada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("patins")
                        .HasColumnType("bit");

                    b.Property<decimal?>("pedagio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("qru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("qtd_hora_parada")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("qtd_pedagio")
                        .HasColumnType("int");

                    b.Property<string>("qth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("ris")
                        .HasColumnType("bit");

                    b.Property<bool?>("rodaExtra")
                        .HasColumnType("bit");

                    b.Property<int>("tipoServicoId")
                        .HasColumnType("int");

                    b.Property<int>("tipoVeiculoId")
                        .HasColumnType("int");

                    b.Property<int>("usuarioId")
                        .HasColumnType("int");

                    b.Property<decimal>("valor_total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("viaturaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Tipo_ServicoId");

                    b.HasIndex("Tipo_VeiculoId");

                    b.HasIndex("usuarioId");

                    b.HasIndex("viaturaId");

                    b.ToTable("Atendimento", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nivelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("nivelId");

                    b.ToTable("Cargo", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Despesas_Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AtendimentoId")
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gerenteId")
                        .HasColumnType("int");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AtendimentoId");

                    b.ToTable("Despesas_Atendimento", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("cep")
                        .HasColumnType("int");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gerenteId")
                        .HasColumnType("int");

                    b.Property<string>("nome_fantasia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<string>("razao_social")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Fornecedor", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Manutencao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("descricao_manutencao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gerenteId")
                        .HasColumnType("int");

                    b.Property<string>("nome_manutencao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("valor_total_manutencao")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("viaturaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("viaturaId");

                    b.ToTable("Manutencao", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Nivel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nivel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Nivel", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Combustivel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("nome_combustivel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipo_Combustivel", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipo_Servico", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipo_Veiculo", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Viatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipo_Viatura", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ativo")
                        .HasColumnType("bit");

                    b.Property<int>("cargoId")
                        .HasColumnType("int");

                    b.Property<int>("cep")
                        .HasColumnType("int");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("comissao")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("criado_em")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("data_nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("gerenteId")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<string>("rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("cargoId");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Tipo_ServicoId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo_VeiculoId")
                        .HasColumnType("int");

                    b.Property<decimal>("adicional_noturno")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("hora_parada")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("patins")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ris")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("rodaExtra")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("valor_km")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("valor_saida")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("viaturaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Tipo_ServicoId");

                    b.HasIndex("Tipo_VeiculoId");

                    b.HasIndex("viaturaId");

                    b.ToTable("Veiculo", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Viatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Tipo_ViaturaId")
                        .HasColumnType("int");

                    b.Property<string>("obs_vtr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Tipo_ViaturaId");

                    b.ToTable("Viatura", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Abastecimento", b =>
                {
                    b.HasOne("Domain.Entites.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.HasOne("Domain.Entites.Fornecedor", "Fornecedor")
                        .WithMany("Abastecimentos")
                        .HasForeignKey("fornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entites.Tipo_Combustivel", "Tipo_Combustivel")
                        .WithMany("Abastecimento")
                        .HasForeignKey("tipo_combustivelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entites.Viatura", "Viatura")
                        .WithMany()
                        .HasForeignKey("viaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");

                    b.Navigation("Tipo_Combustivel");

                    b.Navigation("Usuario");

                    b.Navigation("Viatura");
                });

            modelBuilder.Entity("Domain.Entites.Atendimento", b =>
                {
                    b.HasOne("Domain.Entites.Tipo_Servico", "Tipo_Servico")
                        .WithMany("Atendimentos")
                        .HasForeignKey("Tipo_ServicoId");

                    b.HasOne("Domain.Entites.Tipo_Veiculo", "Tipo_Veiculo")
                        .WithMany()
                        .HasForeignKey("Tipo_VeiculoId");

                    b.HasOne("Domain.Entites.Usuario", "Usuario")
                        .WithMany("Atendimentos")
                        .HasForeignKey("usuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entites.Viatura", "Viatura")
                        .WithMany("Atendimentos")
                        .HasForeignKey("viaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo_Servico");

                    b.Navigation("Tipo_Veiculo");

                    b.Navigation("Usuario");

                    b.Navigation("Viatura");
                });

            modelBuilder.Entity("Domain.Entites.Cargo", b =>
                {
                    b.HasOne("Domain.Entites.Nivel", "Nivel")
                        .WithMany("Cargos")
                        .HasForeignKey("nivelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nivel");
                });

            modelBuilder.Entity("Domain.Entites.Despesas_Atendimento", b =>
                {
                    b.HasOne("Domain.Entites.Atendimento", "Atendimento")
                        .WithMany()
                        .HasForeignKey("AtendimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atendimento");
                });

            modelBuilder.Entity("Domain.Entites.Fornecedor", b =>
                {
                    b.HasOne("Domain.Entites.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entites.Manutencao", b =>
                {
                    b.HasOne("Domain.Entites.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.HasOne("Domain.Entites.Viatura", "Viatura")
                        .WithMany()
                        .HasForeignKey("viaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");

                    b.Navigation("Viatura");
                });

            modelBuilder.Entity("Domain.Entites.Usuario", b =>
                {
                    b.HasOne("Domain.Entites.Cargo", "Cargo")
                        .WithMany("Usuarios")
                        .HasForeignKey("cargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("Domain.Entites.Veiculo", b =>
                {
                    b.HasOne("Domain.Entites.Tipo_Servico", "Tipo_Servico")
                        .WithMany("Veiculos")
                        .HasForeignKey("Tipo_ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entites.Tipo_Veiculo", "Tipo_Veiculo")
                        .WithMany("Veiculos")
                        .HasForeignKey("Tipo_VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entites.Viatura", "Viaturas")
                        .WithMany("Veiculos")
                        .HasForeignKey("viaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo_Servico");

                    b.Navigation("Tipo_Veiculo");

                    b.Navigation("Viaturas");
                });

            modelBuilder.Entity("Domain.Entites.Viatura", b =>
                {
                    b.HasOne("Domain.Entites.Tipo_Viatura", "Tipo_Viatura")
                        .WithMany("Viaturas")
                        .HasForeignKey("Tipo_ViaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo_Viatura");
                });

            modelBuilder.Entity("Domain.Entites.Cargo", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Domain.Entites.Fornecedor", b =>
                {
                    b.Navigation("Abastecimentos");
                });

            modelBuilder.Entity("Domain.Entites.Nivel", b =>
                {
                    b.Navigation("Cargos");
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Combustivel", b =>
                {
                    b.Navigation("Abastecimento");
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Servico", b =>
                {
                    b.Navigation("Atendimentos");

                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Veiculo", b =>
                {
                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Viatura", b =>
                {
                    b.Navigation("Viaturas");
                });

            modelBuilder.Entity("Domain.Entites.Usuario", b =>
                {
                    b.Navigation("Atendimentos");
                });

            modelBuilder.Entity("Domain.Entites.Viatura", b =>
                {
                    b.Navigation("Atendimentos");

                    b.Navigation("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
