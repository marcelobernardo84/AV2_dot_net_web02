﻿using System;
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

        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string municipio { get; set; }
        public string cep { get; set; }
        public string uf { get; set; }
    }
}