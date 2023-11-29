
using Tacotitos.BD.Context;
using Tacotitos.src.modelo.tiposIngredientes;

namespace Tacotitos.BD
{
    internal class TipoIngredienteDAO
    {
        private readonly TacotitosContext _context = TacotitosContext.GetContext();
        public TipoIngredienteDAO() { }

        public bool CrearTipoIngrediente(string nombre, int cantMax)
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
                return true;

            }catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool EditarTipoIngrediente(TipoIngrediente tipo, string nombre, int cantMax) 
        {
            try
            {
                tipo.Nombre = nombre;
                tipo.CantidadMax = cantMax;
                tipo.CuandoSeActualizo = DateTime.Now;

                _context.SaveChanges();
                return true;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
           
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

        public bool EliminarTipoIngrediente(TipoIngrediente tipo)
        {
            try
            {
                tipo.BajaSino = true;
                tipo.CuandoSeElimino = DateTime.Now;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
    }
}
