using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IAutoDeInfracaoAppService: IAppServiceBase<AutoDeInfracao>
    //public interface IFornecedorAppService : IAppServiceBase<Fornecedor>
    {
        IEnumerable<AutoDeInfracao> BuscarAutos(string cnpj);
    }
}
