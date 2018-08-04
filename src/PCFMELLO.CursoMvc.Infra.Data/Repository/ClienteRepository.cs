using PCFMELLO.CursoMvc.Domain.Entities;
using PCFMELLO.CursoMvc.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFMELLO.CursoMvc.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public Cliente ObterPorCpf(string cpf)
        {
            // return Db.Clientes.FirstOrDefault(c => c.CPF == cpf);
            return Buscar(c => c.CPF == cpf).FirstOrDefault();
        }

        public Cliente ObterPorEmail(string email)
        {
            // return Buscar(c => c.Email == email).SingleOrDefault();
            return Buscar(c => c.Email == email).FirstOrDefault();
        }
        
        /* EXEMPLO DE REMOÇÃO/EXCLUSÃO LÓGICA
         * public override void Remover(Guid id)
         * {
         *    Db.Clientes.Find(id).Excluido == true;
         *    SaveChanges();
         * }
         */
    }
}
