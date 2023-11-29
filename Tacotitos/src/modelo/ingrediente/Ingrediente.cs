using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tacotitos.src.interfaces;
using Tacotitos.src.modelo.detalleIngrediente;
using Tacotitos.src.modelo.tiposIngredientes;

namespace Tacotitos.src.modelo.ingrediente
{
    public class Ingrediente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdIngrediente { get; set; }
        [MaxLength(20)]
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public bool BajaSino { get; set; }

        public DateTime CuandoSeElimino { get; set; }
        public DateTime CuandoSeActualizo { get; set; }
        public DateTime CuandoSeCreo { get; set; }
        public int IdTipoIngrediente { get; set; }
        [ForeignKey("IdTipoIngrediente")]
        [InverseProperty("Ingredientes")]
        public virtual TipoIngrediente tipoIngrediente { get; set; }

        [InverseProperty("ingrediente")]
        public virtual ICollection<DetalleIngrediente> DetalleIngrediente {  get; set; }


        public override string ToString()
        {
            return $"ID: {IdIngrediente}" +
                $"Nombre: {Nombre}" +
                $"Precio: {Precio}" +
                $"Tipo de ingrediente: {tipoIngrediente}";
        }


    }
}
