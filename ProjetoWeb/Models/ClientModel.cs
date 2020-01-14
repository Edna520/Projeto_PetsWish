using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoWeb.Models
{
    public class ClientModel
    {
        [Required(ErrorMessage = "Id não Econtrado")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Inválido")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Nascimento Iválido")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Email Inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Selha Inválida")]
        public string Senha { get; set; }

    }
}