using System.ComponentModel.DataAnnotations;

namespace FormulariosConRazorYHTML.Models
{
    public class marcas
    {
        [Key]
        public int id { get; set; }
        
        public string? nombre_marca { get; set; }
        
        public string? estados { get; set; }
    }
}