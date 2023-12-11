namespace BarbieQ.Models.ViewModels
{
    public class VerProductosViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int  CantidadEnExistencia { get; set; }
        public decimal Precio { get; set; }
        public string Ingredientes { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public IEnumerable<ProductosModel> Productos { get; set; } = null!;
        public string FechaModificacion { get; set; } = null!;
        public string FechaModificacionAlternative { get; set; } = null!;
    }



}
