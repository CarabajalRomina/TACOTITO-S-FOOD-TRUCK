
using Tacotitos.BD;
using Tacotitos.src.modelo.cliente;

namespace Tacotitos.src.controladoras
{
    internal class ClienteController
    {
        static ClienteController CntCliente = GetControllerCliente();

        ClienteDAO clienteDAO = new ClienteDAO();

        #region SINGLETON
        private ClienteController() { }

        public static ClienteController GetControllerCliente()
        {
            if (CntCliente == null)
            {
                CntCliente = new ClienteController();
            }

            return CntCliente;
        }
        #endregion

        #region CRUD
        public List<Cliente> GetClientes()
        {
            return clienteDAO.GetClientes();
        }
        public bool CrearCliente(string nombre, string apellido, string domicilio, string telefono)
        {
           return clienteDAO.CrearCliente(nombre, apellido, domicilio, telefono);
        }

        public bool EditarCliente(int id, string nombre, string apellido, string domicilio, string telefono)
        {
            return clienteDAO.EditarCliente(BuscarClientePorId(id), nombre, apellido, domicilio, telefono);
        }

        public bool EliminarCliente(int id)
        {     
          return clienteDAO.EliminarCliente(BuscarClientePorId(id));    
        }
        #endregion

        public Cliente BuscarClientePorId(int id)
        {
            return clienteDAO.BuscarClientePorId(id);
        }


        public List<Cliente> BuscarClientePorApellidoNombre(string nombreCompleto)
        {
            return clienteDAO.BuscarClientePorApellidoNombre(nombreCompleto);
        }
    }
}
