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
    public class ProcessoAppService : AppServiceBase<Processo>, IProcessoAppService
    {
        private readonly IProcessoService _processoService;
        public ProcessoAppService(IProcessoService ProcessoService) : base(ProcessoService)
        {
            _processoService = ProcessoService;
        }


        public IEnumerable<Processo> BuscarPorCnpj(string cnpj)
        {
            return _processoService.BuscarPorCNPJ(cnpj);
        }
    }
}
