using System.ComponentModel.DataAnnotations;

namespace FormulariosConRazorYHTML.Models
{
    public class marcas
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        
        [Display(Name = "Nombre de la Marca")]
        public string? nombre_marca { get; set; }
        
        [Display(Name = "Estado")]
        public string? estados { get; set; }
    }
}