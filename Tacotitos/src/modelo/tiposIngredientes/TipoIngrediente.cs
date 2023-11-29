using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tacotitos.src.modelo.ingrediente;

namespace Tacotitos.src.modelo.tiposIngredientes
{
    public class TipoIngrediente
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadMax { get; set; }
        public bool BajaSino { get; set; }
        public DateTime CuandoSeElimino { get; set; }
        public DateTime CuandoSeActualizo { get; set; }
        public DateTime CuandoSeCreo { get; set; }
        [InverseProperty("tipoIngrediente")]
        public virtual ICollection<Ingrediente> Ingredientes { get; set; }


        public bool EsAlimento()
        {
            return Nombre.Contains("Alimento");
        }

        public bool EsTortilla()
        {
            return Nombre.Contains("Tortilla");
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
