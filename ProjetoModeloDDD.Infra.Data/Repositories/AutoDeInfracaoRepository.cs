using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class AutoDeInfracaoRepository : RepositoryBase<AutoDeInfracao>, IAutoDeInfracaoRepository
    {
       public IEnumerable<AutoDeInfracao> BuscarPorID(int id)
        {
            return Db.AutosDeInfracao.Where(a => a.AutoID == id);
        }
    }

  }
