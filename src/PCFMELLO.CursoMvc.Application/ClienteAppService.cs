using PCFMELLO.CursoMvc.Application.Interfaces;
using PCFMELLO.CursoMvc.Domain.Entities;
using PCFMELLO.CursoMvc.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFMELLO.CursoMvc.Application
{
    class ClienteAppService : IClienteAppService
    {
        private readonly ClienteRepository _clienteRepository = new ClienteRepository();

        public Cliente Adicionar(Cliente cliente)
        {
            return _clienteRepository.Adicionar(cliente);
        }

        public Cliente Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }


        public Cliente ObterPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
