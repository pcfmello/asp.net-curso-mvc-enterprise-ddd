
using System;
using System.Collections.Generic;

namespace PCFMELLO.CursoMvc.Domain.Entities
{
    public class Cliente
    {
        public Cliente()
        {
            ClienteId = Guid.NewGuid(); // Cria um Guid ID na criação da instância. Deve ser criado manualmente.
            Enderecos = new List<Endereco>(); // Necessário para quando eu quiser adicionar um endereço, eu não precise instanciar essa coleção.
        }

        public Guid ClienteId { get; set; } // GUID - Globally Unique Identifier (Garante não ter ids iguais na base de dados)

        public string Nome { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; } // virtual => Indica que eu posso sobrescrever. Necessário para o funcionamento do Lazy Loading, mesmo já habilitado por padrão.

    }
}
