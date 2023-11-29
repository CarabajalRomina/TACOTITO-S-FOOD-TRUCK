
using Tacotitos.BD.Context;
using Tacotitos.src.modelo.pedido;

namespace Tacotitos.BD
{
    internal class PedidoDAO
    {
        private readonly TacotitosContext _context = TacotitosContext.GetContext();

        public PedidoDAO() { }

        public Pedido CrearPedido(int idCliente)
        {
            Pedido? pedido;
            try
            {
                pedido = new Pedido
                {
                    IdCliente = idCliente,
                    BajaSino = false,
                    CuandoSeCreo = DateTime.Now,
                }; 

                _context.Pedidos.Add(pedido);
                _context.SaveChanges();
               
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                pedido = null; 
            }
            return pedido;
        }

        public bool EditarPedido(Pedido pedido,int idCliente)
        {
            try
            {
                pedido.IdCliente = idCliente;
                pedido.CuandoSeActualizo = DateTime.Now;

                _context.SaveChanges();
                return true;

            }catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }

        public List<Pedido> GetPedidos()
        {
            return _context.Pedidos.ToList()
                   .Where(i => i.BajaSino == false)
                   .ToList();
        }

        public Pedido BuscarPedidoPorId(int id)
        {
            return _context.Pedidos.Find(id);
        }

        public bool EliminarPedido(Pedido pedido)
        {
            try
            {
                pedido.BajaSino = true;
                pedido.CuandoSeElimino = DateTime.Now;
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
          
        }

    }
}
