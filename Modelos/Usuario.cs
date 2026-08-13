using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O Nome deve ter entre 3 e 255 caracteres.")]
        public string Nome { get; set; }

        [StringLength(255, MinimumLength = 3, ErrorMessage = "O Nickname deve ter entre 3 e 255 caracteres.")]
        public string Nickname { get; set; }
        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = "É necessário criar uma senha.")]
        public string Senha { get; set; }
    }
}
