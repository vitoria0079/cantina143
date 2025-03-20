using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cantina143.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }


        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; } = string.Empty;


        [Column("CPF")]
        [Display(Name = "CPF")]
        public int CPF { get; set; }


        [Column("Restricao")]
        [Display(Name = "Restrição")]
        public string Restricao { get; set; } = string.Empty;
    }

}
