using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tacotitos.src.modelo.ingrediente;
using Tacotitos.src.modelo.taco;

namespace Tacotitos.src.modelo.detalleIngrediente
{
    public class DetalleIngrediente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDetalle { get; set; }
        public double PrecioUnitario { get; set; }
        public bool BajaSino { get; set; }
        public DateTime CuandoSeElimino { get; set; }
        public DateTime CuandoSeActualizo { get; set; }
        public DateTime CuandoSeCreo { get; set; }
        public int IdIngrediente { get; set; }
        [ForeignKey("IdIngrediente")]
        [InverseProperty("DetalleIngrediente")]
        public virtual Ingrediente ingrediente { get; set; }
        public int IdTaco { get; set; }
        [ForeignKey("IdTaco")]
        [InverseProperty("Ingredientes")]
        public virtual Taco taco { get; set; }
     

        public DetalleIngrediente() { }
        public DetalleIngrediente(Ingrediente ingre, double precioUnitario)
        {
            IdIngrediente = ingre.IdIngrediente;
            ingrediente = ingre;
            PrecioUnitario = precioUnitario;
        }

        public override string ToString()
        {
            return $"Id: {IdDetalle}" + "\n" +
                $"Ingrediente: {ingrediente}" + "\n" +
                $"Precio: {PrecioUnitario}";
        }
    }
}
