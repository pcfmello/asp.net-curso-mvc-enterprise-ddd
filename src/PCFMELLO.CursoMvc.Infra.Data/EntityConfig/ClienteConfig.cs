
using PCFMELLO.CursoMvc.Domain.Entities;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace PCFMELLO.CursoMvc.Infra.Data.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        // Configuração do Fluent API - Faz o mapeamento da classe (Cliente)

        public ClienteConfig()
        {
            HasKey(c => c.ClienteId); // Define que a chave primária é o ClienteId
            // HasKey(c => new { c.ClienteId, c.CPF }); Define uma chave composta

            Property(c => c.Nome)
                .IsRequired()
                // .HasColumnName("STR_Nm")
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength() // Tamanho fixo
                .HasColumnAnnotation("Index",
                    new IndexAnnotation(
                        new System.ComponentModel.DataAnnotations.Schema.IndexAttribute() { IsUnique = true } // Indice de busca
                    )
                ); 

            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.Ativo)
                .IsRequired();

            ToTable("Clientes");
        }
    }
}
