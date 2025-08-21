using System.ComponentModel.DataAnnotations;

namespace InterclassesJogosObaaaa.Models
{
    public class Esporte
    {
        public int EsporteId { get; set; }

        [Required(ErrorMessage = "O nome do esporte é obrigatório.")] // Obriga o usuário a preencher o nome do componente
        [MaxLength(50, ErrorMessage = "O nome do esporte só pode ter até 50 caracteres.")] // Limita o tamanho do nome do componente a 50 caracteres
        [Display(Name = "Insira o nome do Esporte")] // São as palavras que aparecem antes de por qualquer coisa
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe a quantia de jogadores por time.")]
        [Range(1, 25, ErrorMessage = "O número de jogadores deve estar entre 1 e 25.")]
        [Display(Name = "Insira uma quantidade de Jogadores")]
        public int QuantidadeJogadores { get; set; }

    }
}
