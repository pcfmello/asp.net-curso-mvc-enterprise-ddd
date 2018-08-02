
using System;

namespace PCFMELLO.CursoMvc.Domain.Entities
{
    public class Endereco
    {
        public Endereco()
        {
            EnderecoId = Guid.NewGuid(); // Cria um Guid ID na criação da instância. Deve ser criado manualmente.
        }

        public Guid EnderecoId { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        /* Relacionamento entre as classes */
        public Guid ClienteId { get; set; } // FK de Cliente - Definição do tipo da classe - Coluna no BD
        public virtual Cliente Cliente { get; set; } // Necessário para o Entity Framework, em memória, fazer o relacionamento.  virtual => Indica que eu posso sobrescrever. Necessário para o funcionamento do Lazy Loading, mesmo já habilitado por padrão.
        /* Relacionamento entre as classes */

    }
}
