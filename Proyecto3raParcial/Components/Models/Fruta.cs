using System.ComponentModel.DataAnnotations;

namespace Proyecto3raParcial.Components.Models
{
    public class Fruta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El número de serie es obligatorio")]
        [MaxLength(5, ErrorMessage = "El número de serie no puede tener más de 5 caracteres")]
        public string NumeroSerie { get; set; }

        [Required(ErrorMessage = "La fecha de registro es obligatoria")]
        public DateTime FechaRegistro { get; set; }

        public virtual ICollection<Envio> Envios { get; set; } = new List<Envio>();
    }
}
