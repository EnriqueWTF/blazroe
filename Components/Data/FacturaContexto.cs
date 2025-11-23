using blazroe.Components.Data;       
using Microsoft.EntityFrameworkCore; 

namespace blazroe.Components.Data
{
  
    public class FacturaContexto : DbContext
    {
      
        public FacturaContexto(DbContextOptions<FacturaContexto> options)
            : base(options)
        {
        }

     
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
    }
}