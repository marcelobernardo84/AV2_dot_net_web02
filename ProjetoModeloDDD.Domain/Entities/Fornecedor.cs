using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public string cnpj { get; set; }
        public string razaoSocial { get; set; }
        public string inscricaoMunicipal { get; set; }
        public decimal receitaBruta { get; set; }
        //public Endereco endereco { get; set; }

        public int ProdutoId { get; set; }
        public int EnderecoId { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Endereco Endereco { get; set; }

    }
}
