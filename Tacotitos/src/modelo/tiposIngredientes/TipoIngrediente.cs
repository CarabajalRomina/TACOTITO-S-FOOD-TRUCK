using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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


        public TipoIngrediente() { }
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

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            TipoIngrediente otroTipo = (TipoIngrediente)obj;
            return ((Id == otroTipo.Id) &&
                (Nombre == otroTipo.Nombre) &&
                (CantidadMax == otroTipo.CantidadMax) &&
                (BajaSino == otroTipo.BajaSino) &&
                (CuandoSeCreo == otroTipo.CuandoSeCreo));
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id,Nombre, CantidadMax,BajaSino,CuandoSeCreo);
        }

    }
}
