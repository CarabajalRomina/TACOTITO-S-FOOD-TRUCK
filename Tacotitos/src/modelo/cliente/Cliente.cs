using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tacotitos.src.modelo.detalleIngrediente;
using Tacotitos.src.modelo.ingrediente;
using Tacotitos.src.modelo.pedido;
using Tacotitos.src.modelo.taco;

namespace Tacotitos.src.modelo.cliente
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }
        [MaxLength(20)]
        public string Nombre { get; set; }
        [MaxLength(25)]
        public string Apellido { get; set; }
        [MaxLength(50)]
        public string NombreCompleto { get; set; }
        [MaxLength(100)]
        public string Domicilio { get; set; }
        [MaxLength(15)]
        public string Telefono { get; set; }
        public bool BajaSino { get; set; }
        public DateTime CuandoSeElimino { get; set; }
        public DateTime CuandoSeActualizo { get; set; }
        public DateTime CuandoSeCreo { get; set; }

        [InverseProperty("cliente")]
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override string ToString()
        {
            return NombreCompleto;
         
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Cliente otroCliente = (Cliente)obj;
            return ((IdCliente == otroCliente.IdCliente) &&
                (NombreCompleto == otroCliente.NombreCompleto) &&
                (BajaSino == otroCliente.BajaSino) &&
            (CuandoSeCreo == otroCliente.CuandoSeCreo));
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IdCliente, NombreCompleto, BajaSino, CuandoSeCreo);
        }

    }
}
