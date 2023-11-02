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

            modelBuilder.Entity("Domain.Entites.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<int>("km")
                        .HasColumnType("int");

                    b.Property<decimal>("noturno")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("qru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qti")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("usuarioId")
                        .HasColumnType("int");

                    b.Property<decimal>("valor_total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("viaturaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

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

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AtendimentoId");

                    b.ToTable("Despesas_Atendimento", (string)null);
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

                    b.Property<int>("Tipo_VeiculoId")
                        .HasColumnType("int");

                    b.Property<decimal>("valor_km")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("valor_saida")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Tipo_VeiculoId");

                    b.ToTable("Veiculo", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Viatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Tipo_ServicoId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo_ViaturaId")
                        .HasColumnType("int");

                    b.Property<int>("VeiculoId")
                        .HasColumnType("int");

                    b.Property<string>("obs_vtr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Tipo_ServicoId");

                    b.HasIndex("Tipo_ViaturaId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Viatura", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Atendimento", b =>
                {
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
                    b.HasOne("Domain.Entites.Tipo_Veiculo", "Tipo_Veiculo")
                        .WithMany("Veiculos")
                        .HasForeignKey("Tipo_VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo_Veiculo");
                });

            modelBuilder.Entity("Domain.Entites.Viatura", b =>
                {
                    b.HasOne("Domain.Entites.Tipo_Servico", "Tipo_Servico")
                        .WithMany("Viaturas")
                        .HasForeignKey("Tipo_ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entites.Tipo_Viatura", "Tipo_Viatura")
                        .WithMany("Viaturas")
                        .HasForeignKey("Tipo_ViaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entites.Veiculo", "Veiculo")
                        .WithMany("Viaturas")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo_Servico");

                    b.Navigation("Tipo_Viatura");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("Domain.Entites.Cargo", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Domain.Entites.Nivel", b =>
                {
                    b.Navigation("Cargos");
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Servico", b =>
                {
                    b.Navigation("Viaturas");
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

            modelBuilder.Entity("Domain.Entites.Veiculo", b =>
                {
                    b.Navigation("Viaturas");
                });

            modelBuilder.Entity("Domain.Entites.Viatura", b =>
                {
                    b.Navigation("Atendimentos");
                });
#pragma warning restore 612, 618
        }
    }
}
