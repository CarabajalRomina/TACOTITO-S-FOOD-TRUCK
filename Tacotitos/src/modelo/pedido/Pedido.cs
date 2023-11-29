using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public override string ToString()
        {
            return $"Id: {IdPedido}" +
                $"Cliente: {cliente}" +
                $"Tacos: {Tacos}";
        }
    }
}
