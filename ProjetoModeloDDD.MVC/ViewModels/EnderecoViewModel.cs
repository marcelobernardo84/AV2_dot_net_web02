using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public int EnderecoId { get; set; }

        [Display(Name = "Logradouro*")]
        [Required(ErrorMessage = "Preencha o campo Logradouro.")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Logradouro { get; set; }

        [Display(Name = "Numero*")]
        [Required(ErrorMessage = "Preencha o campo Numero.")]
        [MaxLength(50, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Numero { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Complemento { get; set; }

        [Display(Name = "Bairro*")]
        [Required(ErrorMessage = "Preencha o campo Bairro.")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Bairro { get; set; }

        [Display(Name = "Municipio*")]
        [Required(ErrorMessage = "Preencha o campo Municipio.")]
        [MaxLength(200, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Municipio { get; set; }

        [Display(Name = "CEP*")]
        [Required(ErrorMessage = "Preencha o campo CEP.")]
        [MaxLength(200, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Cep { get; set; }
        public string Uf { get; set; }
    }
}