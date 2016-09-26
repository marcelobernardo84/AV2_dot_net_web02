using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Processo
    {
        public int ProcessoID { get; set; }
        public string CNPJ { get; set; }
        public string RelatoFiscalizacao { get; set; }
        public DateTime DataRelato { get; set; }
        public string FiscalResponsavel { get; set; }


    }
}
