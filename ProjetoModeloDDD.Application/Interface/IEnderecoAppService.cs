﻿using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IEnderecoAppService : IAppServiceBase<Endereco>
    {
        IEnumerable<Endereco> BuscarPorCep(string cep);
        IEnumerable<Endereco> BuscarPorLogradouro(string logradouro);
    }
}