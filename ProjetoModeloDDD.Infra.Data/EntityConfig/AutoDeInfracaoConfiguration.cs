using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    class AutoDeInfracaoConfiguration : EntityTypeConfiguration<AutoDeInfracao>
    {
        public AutoDeInfracaoConfiguration()
        {
            HasKey(a => a.AutoID);

            Property(a => a.CNPJ).IsRequired();

            Property(a => a.Agravante).IsRequired();

            Property(a => a.Atenuante).IsRequired();

            Property(a => a.Gravidade).IsRequired();
        }
    }
}
