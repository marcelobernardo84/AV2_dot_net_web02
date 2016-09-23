using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application
{
    public class EnderecoAppService : AppServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoAppService(IEnderecoService EnderecoService) : base(EnderecoService)
        {
            _enderecoService = EnderecoService;
        }

        public IEnumerable<Endereco> BuscarPorCep(string cep)
        {
            return _enderecoService.BuscarPorCep(cep);
        }

        public IEnumerable<Endereco> BuscarPorLogradouro(string logradouro)
        {
            return _enderecoService.BuscarPorLogradouro(logradouro);
        }
    }
}
