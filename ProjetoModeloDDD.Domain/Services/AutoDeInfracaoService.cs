using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Services
{
    public class AutoDeInfracaoService : ServiceBase<AutoDeInfracao>, IAutoDeInfracaoService
    {
        private readonly IAutoDeInfracaoRepository _autoDeInfracaoRepository;

        public AutoDeInfracaoService(IAutoDeInfracaoRepository autoDeInfracaoRepository) : base(autoDeInfracaoRepository)
        {
            _autoDeInfracaoRepository = autoDeInfracaoRepository;
        }

        public IEnumerable<AutoDeInfracao> ObterAutosDeInfracao(IEnumerable<AutoDeInfracao> autos)
        {
            throw new NotImplementedException();
        }
    }
}
