using Tacotitos.BD.Context;
using Tacotitos.src.modelo.ingrediente;
using Tacotitos.src.modelo.tiposIngredientes;

namespace Tacotitos.BD
{
    internal class IngredienteDAO
    {
        private readonly TacotitosContext _context = TacotitosContext.GetContext();

        public IngredienteDAO() { }

        public bool CrearIngrediente(string nombre, TipoIngrediente tipo, double precio)
        {
            try
            {
                var ingrediente = new Ingrediente
                {
                    Nombre = nombre,
                    IdTipoIngrediente = tipo.Id,
                    Precio = precio,
                    BajaSino = false,
                    CuandoSeCreo = DateTime.Now,
                };

                _context.Ingredientes.Add(ingrediente);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
         
        public bool EditarIngrediente(Ingrediente ingrediente, string nombre,TipoIngrediente tipo, double precio)
        {
            try
            {
                ingrediente.Nombre = nombre;
                ingrediente.IdTipoIngrediente = tipo.Id;
                ingrediente.Precio = precio;
                ingrediente.CuandoSeActualizo = DateTime.Now;

                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
           
        }

        public List<Ingrediente> GetIngredientes()
        {
            return _context.Ingredientes.ToList()
                   .Where(i => i.BajaSino == false)
                   .ToList();
        }

        public Ingrediente BuscarIngredientePorId(int id)
        {
            return _context.Ingredientes.Find(id);
        }

        public bool EliminarIngrediente(Ingrediente ingrediente)
        {
            try
            {
                ingrediente.BajaSino = true;
                ingrediente.CuandoSeElimino = DateTime.Now;
                _context.SaveChanges();
                return true;

            }catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            }
          
        }

        public List<Ingrediente> GetIngredientesSegunTipoIngrediente(int idTipoIngrediente)
        {
            return _context.Ingredientes.ToList()
                   .Where(i => i.BajaSino == false && i.IdTipoIngrediente == idTipoIngrediente)
                   .ToList();
        }
    }
}
