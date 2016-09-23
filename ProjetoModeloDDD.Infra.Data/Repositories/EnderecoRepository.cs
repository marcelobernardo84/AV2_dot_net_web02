using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        public IEnumerable<Endereco> BuscarPorCep(string cep)
        {
            return Db.Enderecos.Where(p => p.cep == cep);
        }

        public IEnumerable<Endereco> BuscarPorLogradouro(string logradouro)
        {
            return Db.Enderecos.Where(p => p.logradouro == logradouro);
        }
    }
}
