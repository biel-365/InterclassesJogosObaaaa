using System.ComponentModel.DataAnnotations;

namespace InterclassesJogosObaaaa.Models
{
    public class Time
    {
        public int TimeId { get; set; } // ID do Time, chave primária da tabela
        [Required(ErrorMessage = "O nome do time é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O nome do time só pode ter até 50 caracteres.")]
        [Display(Name = "Insira o nome do Time")]
        public string? Nome { get; set; }

        // Relacionamento entre Models (Tabelas de Banco de Dados)
        // Chave Estrangeira ↓
        [Display(Name = "Nome do Time")]
        public int EsporteId { get; set; } // Vincular o campo ID da tabela
        public Esporte? Esporte { get; set; } // Vincular o objeto relacionado ao ID acima
    }
}
