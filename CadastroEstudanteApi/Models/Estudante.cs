using System.ComponentModel.DataAnnotations;

namespace CadastroEstudanteApi.Models
{
    public class Estudante
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;
    }
}