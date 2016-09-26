using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ProcessoService : ServiceBase<Processo>, IProcessoService
    {
        private readonly IProcessoRepository _processoRepository;

        public ProcessoService(IProcessoRepository processoRepository) : base(processoRepository)
        {
            _processoRepository = processoRepository;
        }

        public IEnumerable<Processo> BuscarPorID(int id)
        {
            return _processoRepository.BuscarPorID(id);
        }
    }
}
