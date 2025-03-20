using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cantina143.Models
{
    [Table("Alimentos")]

    public class Alimentos
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Descricao")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; } = string.Empty;

        [Column("PrecoUnidade")]
        [Display(Name = "Preço Unitário")]
        public double PrecoUnidade { get; set; }


        [Column("QtdEstoque")]
        [Display(Name = "Quantidade do Estoque")]
        public int QtdEstoque { get; set; }


        [Column("Validade")]
        [Display(Name = "Validade")]
        public string Validade { get; set; } = string.Empty;

        [Column("Restricao")]
        [Display(Name = "Restrição")]
        public string Restricao { get; set; } = string.Empty;
    }
}
