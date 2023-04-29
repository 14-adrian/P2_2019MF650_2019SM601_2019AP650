using System.ComponentModel.DataAnnotations;

namespace P2_2019MF650_2019SM601_2019AP650.Models
{
    public class generos
    {
        [Key]
        [Display(Name = "ID")]
        public int id_generos { get; set; }
        [Display(Name = "GENERO")]
        public string? nombre_genero { get; set; }
    }
}
