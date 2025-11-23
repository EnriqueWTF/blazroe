
namespace blazroe.Components.Data
{
    public class Articulo
    {
        public int Id { get; set; } // id para mysqlitee
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }

   
        public int FacturaId { get; set; }
    }
}