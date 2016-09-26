using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProcessoViewModel
    {
        [Key]
        public int ProcessoId { get; set; }

        [Display(Name = "CNPJ do Fornecedor*")]
        [Required(ErrorMessage = "Preencha o campo CNPJ.")]
        [MaxLength(18, ErrorMessage = "Máximo de {0} caracteres.")]
        public string CNPJ { get; set; }

        [Display(Name = "Relato*")]
        [Required(ErrorMessage = "Preencha o campo Relato")]
        [MaxLength(200, ErrorMessage = "Máximo de {0} caracteres.")]
        public string relato { get; set; }

        [Display(Name = "Data do Relato*")]
        [Required(ErrorMessage = "Preencha o campo Data do Relato")]
        [MaxLength(11, ErrorMessage = "Máximo de {0} caracteres.")]
        public string dataRelato { get; set; }

        [Display(Name = "Fiscal Responsavel*")]
        [Required(ErrorMessage = "Preencha o campo Fiscal Responsavel")]
        public string fiscalResponsavel { get; set; }
       
    }
}