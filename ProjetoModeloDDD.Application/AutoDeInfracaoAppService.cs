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
    public class AutoDeInfracaoAppService : AppServiceBase<AutoDeInfracao>, IAutoDeInfracaoAppService
    {
        private readonly IAutoDeInfracaoService _autoDeInfracaoService;
        public AutoDeInfracaoAppService(IAutoDeInfracaoService AutoDeInfracaoService) : base(AutoDeInfracaoService)
        {
            _autoDeInfracaoService = AutoDeInfracaoService;
        }


        public IEnumerable<AutoDeInfracao> BuscarAutos(string cnpj)
        {
            return _autoDeInfracaoService.ObterAutosDeInfracao();
        }
    }
}
