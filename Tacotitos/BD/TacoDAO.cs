
using Tacotitos.BD.Context;
using Tacotitos.src.modelo.taco;

namespace Tacotitos.BD
{
    internal class TacoDAO
    {
        private readonly TacotitosContext _context = TacotitosContext.GetContext();

        public TacoDAO() { }

        public Taco CrearTaco(int idPedido)
        {
            Taco? taco;
            try
            {
                taco = new Taco
                {
                    IdPedido = idPedido,
                    BajaSino = false,
                    CuandoSeCreo = DateTime.Now,
                };

                _context.Tacos.Add(taco);
                _context.SaveChanges();

            }
            catch (Exception ex) { taco = null; }
            return taco;
        }

        public void EditarTaco(Taco taco, int idPedido)
        {
            taco.IdPedido = idPedido;
            taco.CuandoSeActualizo = DateTime.Now;

            _context.SaveChanges();
        }

        public List<Taco> GetTacos()
        {
            return _context.Tacos.ToList()
                   .Where(i => i.BajaSino == false)
                   .ToList();
        }

        public List<Taco> GetTacosDeUnPedido(int idPedido)
        {
            return _context.Tacos.ToList()
                  .Where(i => i.BajaSino == false && i.IdPedido == idPedido)
                  .ToList();
        }

        public Taco BuscarTacoPorId(int id)
        {
            return _context.Tacos.Find(id);
        }

        public void EliminarTaco(Taco taco)
        {
            taco.BajaSino = true;
            taco.CuandoSeElimino = DateTime.Now;
            _context.SaveChanges();
        }

    }
}
