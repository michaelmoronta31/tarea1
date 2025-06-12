namespace Inversiones_moronta.models
{
    public class Inversion
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Activo { get; set; } 
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public decimal PrecioCompra { get; set; }
    }
}
