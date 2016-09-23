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

        [Required(ErrorMessage = "Preencha o campo Sobrenome.")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres.")]
        public string cnpj { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-Mail.")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres.")]        
        public string razaoSocial { get; set; }

        public string inscricaoMunicipal { get; set; }
        public decimal receitaBruta { get; set; }
        public Endereco endereco { get; set; }
    }
}