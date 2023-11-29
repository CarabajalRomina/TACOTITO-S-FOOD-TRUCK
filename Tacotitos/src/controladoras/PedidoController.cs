using Tacotitos.BD;
using Tacotitos.src.modelo.pedido;

namespace Tacotitos.src.controladoras
{
    internal class PedidoController
    {
        static PedidoController CntPedido = GetControllerPedido();
        PedidoDAO pedidoDAO = new PedidoDAO();


        #region SINGLETON
        private PedidoController() { }

        public static PedidoController GetControllerPedido()
        {
            if (CntPedido == null)
            {
                CntPedido = new PedidoController();
            }

            return CntPedido;
        }
        #endregion


        public Pedido CrearPedido(int idCliente)
        {
            return pedidoDAO.CrearPedido(idCliente);
        }

        public List<Pedido> GetPedidos()
        {
            return pedidoDAO.GetPedidos();
        }

        public void EditarPedido(int idPedido, int idCliente)
        {
            var pedido = BuscarPedidoPorId(idPedido);
            pedidoDAO.EditarPedido(pedido, idCliente);
        }

        public void EliminarPedido(Pedido pedido)
        {
            pedidoDAO.EliminarPedido(pedido);
        }

        public Pedido BuscarPedidoPorId(int id)
        {
            return pedidoDAO.BuscarPedidoPorId(id);
        }

    }
}
