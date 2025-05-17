namespace Proyecto3raParcial.Components.Models
{
    public class Envio
    {
        public int Id { get; set; }
        public int FrutaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha_embarque { get; set; }
        public decimal Cantidad_kg { get; set; }
        public string Destino { get; set; }
        public string Estado { get; set; }
        public string Documentacion { get; set; }

        public Fruta Fruta { get; set; }
        public Cliente Cliente { get; set; }
    }
}
