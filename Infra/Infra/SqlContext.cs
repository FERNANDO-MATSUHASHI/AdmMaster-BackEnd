using Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class SqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AdmMasterDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Cargo>().ToTable("Cargo");
            modelBuilder.Entity<Nivel>().ToTable("Nivel");
            modelBuilder.Entity<Atendimento>().ToTable("Atendimento");
            modelBuilder.Entity<Despesas_Atendimento>().ToTable("Despesas_Atendimento");
            modelBuilder.Entity<Viatura>().ToTable("Viatura");
            modelBuilder.Entity<Tipo_Viatura>().ToTable("Tipo_Viatura");
            modelBuilder.Entity<Veiculo>().ToTable("Veiculo");
            modelBuilder.Entity<Tipo_Veiculo>().ToTable("Tipo_Veiculo");
            modelBuilder.Entity<Tipo_Servico>().ToTable("Tipo_Servico");
            modelBuilder.Entity<Fornecedor>().ToTable("Fornecedor");
            modelBuilder.Entity<Tipo_Combustivel>().ToTable("Tipo_Combustivel");
            modelBuilder.Entity<Manutencao>().ToTable("Manutencao");
            modelBuilder.Entity<Abastecimento>().ToTable("Abastecimento");
            modelBuilder.Entity<Empresa>().ToTable("Empresa");
        }

        public DbSet<Atendimento>? Atendimentos { get; set; }
        public DbSet<Despesas_Atendimento>? DespesasAtendimento { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Veiculo>? Veiculos { get; set; }
        public DbSet<Viatura>? Viaturas { get; set; }
        public DbSet<Tipo_Veiculo>? Tipo_Veiculos { get; set; }
        public DbSet<Tipo_Servico>? Tipo_Servicos { get; set; }
        public DbSet<Cargo>? Cargos { get; set; }
        public DbSet<Nivel>? Niveis { get; set; }
        public DbSet<Tipo_Viatura>? Tipo_Viaturas { get; set; }
        public DbSet<Fornecedor>? Fornecedor { get; set; }
        public DbSet<Tipo_Combustivel>? Tipo_Combustivel { get; set; }
        public DbSet<Manutencao>? Manutencao { get; set; }
        public DbSet<Abastecimento>? Abastecimento { get; set; }
        public DbSet<Empresa>? Empresa { get; set; }
    }
}
