using System.ComponentModel.DataAnnotations;

namespace P2_2019MF650_2019SM601_2019AP650.Models
{
    public class casos_reportados
    {
        [Key]
        [Display(Name = "ID")]
        public int id_casos_reportados { get; set; }
        [Display(Name = "ID DEL DEPARTAMENTO")]
        public int departamento_id { get; set; }
        [Display(Name = "ID DEL GENERO")]
        public int genero_id { get; set; }
        [Display(Name = "CASOS CONFIRMADOS")]
        public int casos_confirmados { get; set; }
        [Display(Name = "RECUPERADOS")]
        public int recuperados { get; set; }
        [Display(Name = "FALLECIDOS")]
        public int fallecidos { get; set; }
    }
}
