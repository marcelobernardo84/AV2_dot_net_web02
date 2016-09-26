using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class FornecedorViewModel
    {   
        [Key]
        public int FornecedorId { get; set; }

        [Display(Name = "CNPJ do Fornecedor*")]
        [Required(ErrorMessage = "Preencha o campo CNPJ.")]
        [MaxLength(18, ErrorMessage = "Máximo de {0} caracteres.")]        
        public string cnpj { get; set; }

        [Display(Name ="Razão Social*")]
        [Required(ErrorMessage = "Preencha o campo Razão Social.")]
        [MaxLength(200, ErrorMessage = "Máximo de {0} caracteres.")]       
        public string razaoSocial { get; set; }

        [Display(Name = "Inscrição Municipal")]
        [MaxLength(11, ErrorMessage = "Máximo de {0} caracteres.")]
        public string inscricaoMunicipal { get; set; }

        [Display(Name = "Receita Bruta*")]
        public decimal receitaBruta { get; set; }
        public EnderecoViewModel endereco { get; set; }
    }
}