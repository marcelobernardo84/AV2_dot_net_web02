using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IEnderecoService : IServiceBase<Endereco>
    {
        IEnumerable<Endereco> BuscarPorCep(string cep);
        IEnumerable<Endereco> BuscarPorLogradouro(string logradouro);
    }
}
