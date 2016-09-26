using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IProcessoAppService: IAppServiceBase<Processo>
    //public interface IFornecedorAppService : IAppServiceBase<Fornecedor>
    {
        IEnumerable<Processo> BuscarPorCnpj(string cnpj);
    }
}
