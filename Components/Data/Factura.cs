using blazroe.Components.Data;

public class Factura
{
    public int Id { get; set; }
    public string NombreCliente { get; set; } = string.Empty;
    public DateTime Fecha { get; set; } = DateTime.Now;
    public List<Articulo> Articulos { get; set; } = new List<Articulo>();
    public decimal Total => Articulos.Sum(articulo => articulo.Precio);

    
    public bool Archivada { get; set; } = false; // Por defecto no esta archivada
}