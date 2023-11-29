using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tacotitos.src.modelo.pedido;

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

        public string TOString()
        {
            return $"Id: {IdCliente}" +
              $"Nombre: {Nombre}" +
              $"Apellido: {Apellido}" +
              $"Nombre completo: {NombreCompleto}" +
              $"Domicilio: {Domicilio}" +
              $"Telefono: {Telefono}";
        }

    }
}
