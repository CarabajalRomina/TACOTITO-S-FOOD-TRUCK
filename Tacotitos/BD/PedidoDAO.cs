using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tacotitos.BD.Context;
using Tacotitos.src.modelo.cliente;
using Tacotitos.src.modelo.ingrediente;
using Tacotitos.src.modelo.pedido;
using Tacotitos.src.modelo.tiposIngredientes;

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
            catch (Exception ex) { pedido = null; }
            return pedido;
        }

        public void EditarPedido(Pedido pedido,int idCliente)
        {
            pedido.IdCliente = idCliente;         
            pedido.CuandoSeActualizo = DateTime.Now;

            _context.SaveChanges();
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

        public void EliminarPedido(Pedido pedido)
        {
            pedido.BajaSino = true;
            pedido.CuandoSeElimino = DateTime.Now;
            _context.SaveChanges();
        }

    }
}
