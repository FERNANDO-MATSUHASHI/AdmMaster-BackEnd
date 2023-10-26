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

                    b.Property<string>("qru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qti")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("valor_total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Atendimento", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Cargo", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Nivel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CargoId")
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nivel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.ToTable("Nivel", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ViaturaId")
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ViaturaId");

                    b.ToTable("Tipo_Servico", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("VeiculoId")
                        .HasColumnType("int");

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

                    b.HasIndex("VeiculoId");

                    b.ToTable("Tipo_Veiculo", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Viatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ViaturaId")
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ViaturaId");

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

                    b.Property<int>("cep")
                        .HasColumnType("int");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("comissao")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("criado_em")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("data_nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gerenteId")
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

                    b.HasIndex("cpf")
                        .IsUnique();

                    b.HasIndex("email")
                        .IsUnique();

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ViaturaId")
                        .HasColumnType("int");

                    b.Property<decimal>("valor_km")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("valor_saida")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ViaturaId");

                    b.ToTable("Veiculo", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Viatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AtendimentoId")
                        .HasColumnType("int");

                    b.Property<string>("obs_vtr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AtendimentoId");

                    b.ToTable("Viatura", (string)null);
                });

            modelBuilder.Entity("Domain.Entites.Cargo", b =>
                {
                    b.HasOne("Domain.Entites.Usuario", null)
                        .WithMany("Cargos")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Domain.Entites.Nivel", b =>
                {
                    b.HasOne("Domain.Entites.Cargo", null)
                        .WithMany("Niveis")
                        .HasForeignKey("CargoId");
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Servico", b =>
                {
                    b.HasOne("Domain.Entites.Viatura", null)
                        .WithMany("Tipo_Servicos")
                        .HasForeignKey("ViaturaId");
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Veiculo", b =>
                {
                    b.HasOne("Domain.Entites.Veiculo", null)
                        .WithMany("Tipo_Veiculos")
                        .HasForeignKey("VeiculoId");
                });

            modelBuilder.Entity("Domain.Entites.Tipo_Viatura", b =>
                {
                    b.HasOne("Domain.Entites.Viatura", null)
                        .WithMany("Tipo_Viaturas")
                        .HasForeignKey("ViaturaId");
                });

            modelBuilder.Entity("Domain.Entites.Veiculo", b =>
                {
                    b.HasOne("Domain.Entites.Viatura", null)
                        .WithMany("Veiculos")
                        .HasForeignKey("ViaturaId");
                });

            modelBuilder.Entity("Domain.Entites.Viatura", b =>
                {
                    b.HasOne("Domain.Entites.Atendimento", null)
                        .WithMany("Viaturas")
                        .HasForeignKey("AtendimentoId");
                });

            modelBuilder.Entity("Domain.Entites.Atendimento", b =>
                {
                    b.Navigation("Viaturas");
                });

            modelBuilder.Entity("Domain.Entites.Cargo", b =>
                {
                    b.Navigation("Niveis");
                });

            modelBuilder.Entity("Domain.Entites.Usuario", b =>
                {
                    b.Navigation("Cargos");
                });

            modelBuilder.Entity("Domain.Entites.Veiculo", b =>
                {
                    b.Navigation("Tipo_Veiculos");
                });

            modelBuilder.Entity("Domain.Entites.Viatura", b =>
                {
                    b.Navigation("Tipo_Servicos");

                    b.Navigation("Tipo_Viaturas");

                    b.Navigation("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
