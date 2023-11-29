using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tacotitos.src.modelo.detalleIngrediente;
using Tacotitos.src.modelo.pedido;

namespace Tacotitos.src.modelo.taco
{
    public class Taco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTaco { get; set; }
        public bool BajaSino { get; set; }
        public DateTime CuandoSeElimino { get; set; }
        public DateTime CuandoSeActualizo { get; set; }
        public DateTime CuandoSeCreo { get; set; }
        [InverseProperty("taco")]
        public virtual ICollection<DetalleIngrediente> Ingredientes{ get; set; }

        public int IdPedido { get; set; }
        [ForeignKey("IdPedido")]
        [InverseProperty("Tacos")]
        public virtual Pedido pedido { get; set; }



        public Taco() 
        {
        }
        public Taco(List<DetalleIngrediente> ingredientes)
        {
            Ingredientes = new List<DetalleIngrediente>(ingredientes);
        }

        public double GetPrecioTaco()
        {
            double precio = 0;
            foreach (var ingrediente in Ingredientes)
            {
                precio += ingrediente.PrecioUnitario;
            }
            return precio;
        }

        public override string ToString()
        {
            return $"Id: {IdTaco}" +
                $"Ingredientes: {Ingredientes}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Taco otroTaco = (Taco)obj;
            return ((IdTaco == otroTaco.IdTaco) &&
                (IdPedido == otroTaco.IdPedido) &&
                (BajaSino == otroTaco.BajaSino) &&
                (CuandoSeCreo == otroTaco.CuandoSeCreo));
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IdTaco,IdPedido, BajaSino, CuandoSeCreo);
        }
    }
}
