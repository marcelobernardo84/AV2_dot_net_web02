using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class AutoDeInfracaoViewModel
    {
        [Key]
        public int AutoId { get; set; }

        [Display(Name = "Gravidade*")]
        [Required(ErrorMessage = "Preencha o campo Gravidade")]
        [MaxLength(200, ErrorMessage = "Máximo de {0} caracteres.")]
        public int gravidade { get; set; }

        [Display(Name = "Atenuante*")]
        [Required(ErrorMessage = "Preencha o campo Atenuante")]
        [MaxLength(11, ErrorMessage = "Máximo de {0} caracteres.")]
        public bool agravante { get; set; }

        [Display(Name = "Agravante*")]
        [Required(ErrorMessage = "Preencha o campo Agravante")]
        public bool atenuante { get; set; }

    }
}