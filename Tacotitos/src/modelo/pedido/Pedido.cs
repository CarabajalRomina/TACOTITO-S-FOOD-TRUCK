using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tacotitos.src.modelo.cliente;
using Tacotitos.src.modelo.taco;

namespace Tacotitos.src.modelo.pedido
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPedido { get; set; }
        public bool BajaSino { get; set; }
        public DateTime CuandoSeElimino { get; set; }
        public DateTime CuandoSeActualizo { get; set; }
        public DateTime CuandoSeCreo { get; set; }
        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        [InverseProperty("Pedidos")]
        public virtual Cliente cliente { get; set; }
        [InverseProperty("pedido")]
        public virtual ICollection<Taco> Tacos { get; set; }


        public Pedido() { }
        public override string ToString()
        {
            return $"Id: {IdPedido}" +
                $"Cliente: {cliente}" +
                $"Tacos: {Tacos}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Pedido otroPedido = (Pedido)obj;

            return ((IdPedido == otroPedido.IdPedido) &&
                (IdCliente == otroPedido.IdCliente) &&
                (BajaSino == otroPedido.BajaSino) &&
                (CuandoSeCreo == otroPedido.CuandoSeCreo));
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IdPedido, IdCliente, BajaSino, CuandoSeCreo);
        }
    }
}
