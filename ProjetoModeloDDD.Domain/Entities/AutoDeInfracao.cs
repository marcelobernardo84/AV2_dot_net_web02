using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class AutoDeInfracao
    {
        public const double penaBase = 500;
        public const double valorUfir = 3;
        public const double coeficienteMulta = 120000;
     


        public int AutoID {get; set;}
        public string CNPJ { get; set;}
        public string RazaoSocial { get; set; }
        public double ReceitaBruta { get; set; }
        public DateTime DataRelato { get; set; }
        public string Relato { get; set; }
        public int Gravidade { get; set; }
        public bool Atenuante { get; set; }
        public bool Agravante { get; set; }
        public double Multa()
        {
            //M = PB + [(RB – R$120.000,00)*0,10) + R$120.000,00]*[UFIR*(Ag+At)*G]
            double valorAt = 1;
            int valorAg = 0;
            if (Atenuante)
            {
                valorAt = 0.33;
            }
            if (Agravante)
            {
                valorAg = 1;
            }
            return penaBase + ((ReceitaBruta - coeficienteMulta) * 0.10) + coeficienteMulta * valorUfir * valorAt * valorAg * Gravidade;
        }
 
        
    }
}
