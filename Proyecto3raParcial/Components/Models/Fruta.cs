namespace Proyecto3raParcial.Components.Models
{
    public class Fruta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Variedad { get; set; }
        public string Calidad { get; set; }
        public string Proveedor { get; set; }

        public ICollection<Envio> Envios { get; set; }
    }
}
