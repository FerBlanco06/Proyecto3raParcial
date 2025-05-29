using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Proyecto3raParcial.Components.Models
{
    public class Envio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El destino es obligatorio")]
        public string Destino { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un cliente")]
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        [Required(ErrorMessage = "Debe seleccionar al menos una fruta")]
        public virtual ICollection<Fruta> Frutas { get; set; } = new HashSet<Fruta>();
    }
}
