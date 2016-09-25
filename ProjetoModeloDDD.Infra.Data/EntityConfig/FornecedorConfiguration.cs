using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfiguration()
        {
            HasKey(p => p.FornecedorId);
            Property(p => p.cnpj).IsRequired().HasMaxLength(20);
            //HasRequired(p => p.Produto).WithMany().HasForeignKey(p => p.ProdutoId);
            HasRequired(p => p.Endereco).WithMany().HasForeignKey(p => p.EnderecoId);
        }
    }
}
