using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cantina143.Models
{
    [Table("Fornecedores")]
    public class Fornecedores
    {
        [Column("Id")]
        [Display(Name = "Código do Fornecedor")]
        public int Id { get; set; }

        [Column("RazaoSocial")]
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; } = string.Empty;

        [Column("Cnpj")]
        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; } = string.Empty;

    }
}

