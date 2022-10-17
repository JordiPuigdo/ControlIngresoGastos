using System.ComponentModel.DataAnnotations;

namespace ControlIngresoGastos.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(120)]
        [Display(Name ="Nombre Categoria")]
        public String NombreCategoria { get; set; }
        [Required]
        [MaxLength(120)]
        [Display(Name = "Tipo")]
        public String Tipo{ get; set; } //IN Ingreso GA Gasto

        [Required]
        public bool Estado { get; set; }

    }
}
