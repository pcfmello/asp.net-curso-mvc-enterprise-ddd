
using PCFMELLO.CursoMvc.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PCFMELLO.CursoMvc.Infra.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(c => c.EnderecoId); // Define que a chave primária é o ClienteId
            // HasKey(c => new { c.EnderecoId, c.Numero }); Define uma chave composta

            Property(c => c.Logradouro)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(10);

            Property(c => c.Bairro)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.CEP)
                .IsRequired()
                .HasMaxLength(8);

            Property(c => c.Complemento)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Estado)
                .IsRequired()
                .HasMaxLength(2);

            // Definindo o relacionamento
            // HasOptional
            HasRequired(e => e.Cliente) // relacionamento requerido com a tabela Cliente
                .WithMany(c => c.Enderecos) // onde tem uma lista de endereços
                .HasForeignKey(e => e.ClienteId); // chave primária que faz o relacionamento

            ToTable("Enderecos");
        }
    }
}
