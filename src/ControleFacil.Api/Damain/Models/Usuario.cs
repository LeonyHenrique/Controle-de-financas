using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ControleFacil.Api.Contract.Usuario;

namespace ControleFacil.Api.Damain.Models
{
    public class Usuario
    {
        [Key] //chave da tabela usuário
        public long Id { get; set; }

        [Required(ErrorMessage = "O campo de E-mail é obrigatório.")]
        public string Email { get; set; } = string.Empty; // cria iniando ela vazia (nula)

        [Required(ErrorMessage = "O campo de Senha é obrigatório.")]
        public string Senha { get; set; } = string.Empty;

        [Required] //obrigatório informar
        public DateTime DataCadastro { get; set;} 
        public DateTime? DataInativacao { get; set; }

    }
}