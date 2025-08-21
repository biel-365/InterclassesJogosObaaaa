using System.ComponentModel.DataAnnotations;

namespace InterclassesJogosObaaaa.Models
{
    public class Campeonato
    {
        public int CampeonatoId { get; set; }

        [Required(ErrorMessage = "O nome do campeonato é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O nome do campeonato só pode ter até 50 caracteres.")]
        [Display(Name = "Insira o nome do campeonato do Jogador")]

        public string? Nome { get; set; }

        // Relacionamento Campeonato X Esporte
        [Display(Name = "Nome do Esporte")]
        public int EsporteId { get; set; }
        public Esporte? Esporte { get; set; }

    }
}
