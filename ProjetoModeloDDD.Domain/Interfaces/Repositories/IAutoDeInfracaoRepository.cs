using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositories
{
    public interface IAutoDeInfracaoRepository : IRepositoryBase<AutoDeInfracao>
    {
        IEnumerable<AutoDeInfracao> BuscarPorID(int id);
    }
}
