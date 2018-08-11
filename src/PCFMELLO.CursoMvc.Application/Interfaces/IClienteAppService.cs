using PCFMELLO.CursoMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFMELLO.CursoMvc.Application.Interfaces
{
    interface IClienteAppService : IDisposable
    {

        Cliente Adicionar(Cliente cliente);

        Cliente ObterPorCpf(string cpf);

        Cliente ObterPorEmail(string email);

        Cliente ObterPorId(Guid id);

        IEnumerable<Cliente> ObterTodos();

        Cliente Atualizar(Cliente cliente);

        void Remover(Guid id);

    }
}
