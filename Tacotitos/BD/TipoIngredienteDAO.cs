
using Tacotitos.BD.Context;
using Tacotitos.src.modelo.tiposIngredientes;

namespace Tacotitos.BD
{
    internal class TipoIngredienteDAO
    {
        private readonly TacotitosContext _context = TacotitosContext.GetContext();
        public TipoIngredienteDAO() { }

        public void CrearTipoIngrediente(string nombre, int cantMax)
        {
            try
            {
                var tipoIngrediente = new TipoIngrediente
                {
                    Nombre = nombre,
                    CantidadMax = cantMax,
                    BajaSino = false,
                    CuandoSeCreo = DateTime.Now
                };

                _context.TiposIngredientes.Add(tipoIngrediente);
                _context.SaveChanges();

            }catch (Exception ex) { }
        }

        public void EditarTipoIngrediente(TipoIngrediente tipo, string nombre, int cantMax) 
        {
            tipo.Nombre = nombre;
            tipo.CantidadMax = cantMax;
            tipo.CuandoSeActualizo = DateTime.Now;

            _context.SaveChanges();
        }

        public List<TipoIngrediente> GetTiposDeIngredientes()
        {
            return _context.TiposIngredientes.ToList()
                   .Where(i => i.BajaSino == false)
                   .ToList();
        }

        public TipoIngrediente BuscarTipoIngredientePorId(int id)
        {
            return _context.TiposIngredientes.Find(id);
        }

        public void EliminarTipoIngrediente(TipoIngrediente tipo)
        {
            tipo.BajaSino = true;
            tipo.CuandoSeElimino = DateTime.Now;
            _context.SaveChanges();

        }

    }
}
