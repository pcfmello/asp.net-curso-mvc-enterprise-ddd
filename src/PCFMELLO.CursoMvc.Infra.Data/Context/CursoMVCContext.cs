
using PCFMELLO.CursoMvc.Domain.Entities;
using PCFMELLO.CursoMvc.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PCFMELLO.CursoMvc.Infra.Data.Context
{
    public class CursoMVCContext : DbContext
    {
        public CursoMVCContext()
            : base("DefaultConnection") // Deve passar a connectionString para o DbContext pois essa classe o herdou (WebConfig do Presentation)
        {

        }

        // Declara as classes que o EF vai gerenciar
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        // Configurações executadas na criação da base de dados pelo EF
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Desabilitar o pluralize e/ou definição automática de nomes de tabelas pelo EF no plural
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Desabilita a remoção em cascata dos dados das tabelas
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // Configura os ids como chaves primárias nas tabelas
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id") // Quando atributo == nomeTabela + "Id"
                .Configure(p => p.IsKey()); // Configura como primaryKey

            // Configura as colunas do tipo "string" a serem declaradas com "varchar" nas tabelas
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            // Configura as colunas do tipo "string" a terem tamanhos de 100 caracteres nas tabelas
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            // Configuração do Fluente API
            modelBuilder.Configurations.Add(new ClienteConfig()); // Sobrescreve a configuração anterior/acima (genérica)
            modelBuilder.Configurations.Add(new EnderecoConfig()); // Sobrescreve a configuração anterior/acima (genérica)

            base.OnModelCreating(modelBuilder);
        }

    }
}
