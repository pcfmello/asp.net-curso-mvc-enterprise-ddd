using PCFMELLO.CursoMvc.Application.Interfaces;
using PCFMELLO.CursoMvc.Domain.Entities;
using PCFMELLO.CursoMvc.Infra.Data.Repository;
using System;
using System.Collections.Generic;

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
            return _clienteRepository.Atualizar(cliente);
        }


        public Cliente ObterPorCpf(string cpf)
        {
            return _clienteRepository.ObterPorCpf(cpf);
        }

        public Cliente ObterPorEmail(string email)
        {
            return _clienteRepository.ObterPorEmail(email);
        }

        public Cliente ObterPorId(Guid id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _clienteRepository.Remover(id);
        }

        public void Dispose()
        {
            _clienteRepository.Dispose(); // Repositório será destruido
            GC.SuppressFinalize(this); // Garbage Collector vai suprimir essa classe de cliente
        }
    }
}
