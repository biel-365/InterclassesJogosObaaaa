using System.ComponentModel.DataAnnotations;

namespace InterclassesJogosObaaaa.Models
{
    public class Jogador
    {
        public string? JogadorId { get; set; }

        [Required(ErrorMessage = "Informe o nome do jogador.")]
        [MaxLength(50, ErrorMessage = "O nome do jogador só pode ter até 50 caracteres.")]
        [Display(Name = "Insira o nome do Jogador")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe o número da camisa.")]
        [Display(Name = "Insira o número que terá a camisa")]
        [MaxLength(50, ErrorMessage = "O número do time só pode ter até 50 caracteres.")]
        [Range(1, 999, ErrorMessage = "Escolha de 1 a 999.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Informe a posição do jogador.")]
        [Display(Name = "Insira a posição do Jogador")]
        [MaxLength(50, ErrorMessage = "A posição do jogador só pode ter até 50 caracteres.")]
        public int Posicao { get; set; }

        [Display(Name = "Nome do Time")]
        public Time? Time { get; set; } // Relacionamento com a tabela Time
        public int TimeId { get; set; } // Chave estrangeira para a tabela Time

    }
}