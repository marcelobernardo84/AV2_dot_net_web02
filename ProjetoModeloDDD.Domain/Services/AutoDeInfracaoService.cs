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

        public AutoDeInfracaoService(IAutoDeInfracaoRepository AutoDeInfracaoRepository) : base(AutoDeInfracaoRepository)
        {
            _autoDeInfracaoRepository = AutoDeInfracaoRepository;
        }

        public IEnumerable<AutoDeInfracao> ObterAutosDeInfracao()
        {
            throw new NotImplementedException();
        }
    }
}
