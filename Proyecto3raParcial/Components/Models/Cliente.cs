namespace Proyecto3raParcial.Components.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre_empresa { get; set; }
        public string Pais { get; set; }
        public string Contacto { get; set; }
        public string Requisitos { get; set; }

        public ICollection<Envio> Envios { get; set; }
    }
}
