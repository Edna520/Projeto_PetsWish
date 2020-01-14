using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Espelho do >>>BANDO DE DADOS<<<
namespace Entity
{
    public class Client
    {
        //Altenticação no banco de daxz\
        [Required (ErrorMessage = "Id não Econtrado")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Inválido")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Nascimento Iválido")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Email Inválido")]
        public string Email{ get; set; }

        [Required(ErrorMessage = "Selha Inválida")]
        public string Senha { get; set; }

    }
}
