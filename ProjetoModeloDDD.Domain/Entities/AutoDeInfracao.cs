using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class AutoDeInfracao
    {
        public int AutoID {get; set;}
        public string CNPJ { get; set;}
        public string RazaoSocial { get; set; }
        public decimal ReceitaBruta { get; set; }
        public DateTime DataRelato { get; set; }
        public string Relato { get; set; }
        public int Gravidade { get; set; }
        public bool Atenuante { get; set; }
        public bool Agravante { get; set; }
        
    }
}
