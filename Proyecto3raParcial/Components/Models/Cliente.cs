using System.ComponentModel.DataAnnotations;
using Proyecto3raParcial.Components.Models;

public class Cliente
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El destino es obligatorio")]
    public string Destino { get; set; }

    [Required(ErrorMessage = "El correo es obligatorio")]
    [EmailAddress(ErrorMessage = "El correo no es válido")]
    public string Correo { get; set; }

    [Required(ErrorMessage = "El teléfono es obligatorio")]
    [Phone(ErrorMessage = "El número de teléfono no es válido")]
    [StringLength(10, ErrorMessage = "El teléfono debe tener 10 dígitos", MinimumLength = 10)]
    public string Telefono { get; set; }

    public virtual ICollection<Envio> Envios { get; set; } = new List<Envio>();
}

