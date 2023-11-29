using Tacotitos.BD.Context;
using Tacotitos.src.modelo.detalleIngrediente;

namespace Tacotitos.BD
{
    internal class DetalleIngredienteDAO
    {
        private readonly TacotitosContext _context = TacotitosContext.GetContext();

        public DetalleIngredienteDAO() { }

        public DetalleIngrediente CrearDetalleIngrediente(int idTaco, int idIngrediente, double precioUnitario)
        {
            DetalleIngrediente? detalleIngre;
            try
            {
                detalleIngre = new DetalleIngrediente
                {
                    IdTaco = idTaco,
                    IdIngrediente = idIngrediente,
                    PrecioUnitario = precioUnitario,
                    BajaSino = false,
                    CuandoSeCreo = DateTime.Now,
                };

                _context.DetallesIngredientes.Add(detalleIngre);
                _context.SaveChanges();

            }
            catch (Exception ex) { detalleIngre = null; }
            return detalleIngre;
        }

        public void EditarDetalleIngrediente(DetalleIngrediente detalleIngre, int idTaco, int idIngrediente, double precioUnitario)
        {
            detalleIngre.IdTaco = idTaco;
            detalleIngre.IdIngrediente = idIngrediente;
            detalleIngre.PrecioUnitario = precioUnitario;
            detalleIngre.CuandoSeActualizo = DateTime.Now;

            _context.SaveChanges();
        }

        public List<DetalleIngrediente> GetDetalleIngredientes()
        {
            return _context.DetallesIngredientes.ToList()
                   .Where(i => i.BajaSino == false)
                   .ToList();
        }

        public List<DetalleIngrediente> GetDetalleIngredientesEnUnTaco(int idTaco)
        {
            return _context.DetallesIngredientes.ToList()
                   .Where(i => i.BajaSino == false && i.IdTaco == idTaco)
                   .ToList();
        }

        public DetalleIngrediente BuscarDetalleIngredientePorId(int id)
        {
            return _context.DetallesIngredientes.Find(id);
        }

        public void EliminarDetalleIngrediente(DetalleIngrediente detalleIngre)
        {
            detalleIngre.BajaSino = true;
            detalleIngre.CuandoSeElimino = DateTime.Now;
            _context.SaveChanges();
        }
    }
}
