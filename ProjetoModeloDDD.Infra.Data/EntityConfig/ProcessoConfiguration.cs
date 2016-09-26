using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    class ProcessoConfiguration : EntityTypeConfiguration<Processo>
    {
        public ProcessoConfiguration()
        {
            HasKey(p => p.ProcessoID);

            Property(p => p.CNPJ).IsRequired();

            Property(p => p.RelatoFiscalizacao).IsRequired().HasMaxLength(150);

            Property(p => p.DataRelato).IsRequired();

            Property(p => p.FiscalResponsavel).IsRequired();
        }
    }
}
