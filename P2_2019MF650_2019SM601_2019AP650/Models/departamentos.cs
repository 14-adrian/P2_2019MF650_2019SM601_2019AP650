using System.ComponentModel.DataAnnotations;

namespace P2_2019MF650_2019SM601_2019AP650.Models
{
    public class departamentos
    {
        [Key]
        [Display(Name = "ID")]
        public int id_departamento { get; set; }
        [Display(Name = "DEPARTAMENTO")]
        public string? nombre_departamento { get; set; }
    }
}
