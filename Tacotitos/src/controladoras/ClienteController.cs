using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public void CrearCliente(string nombre, string apellido, string domicilio, string telefono)
        {
            clienteDAO.CrearCliente(nombre, apellido, domicilio, telefono);
        }

        public void EditarCliente(int id, string nombre, string apellido, string domicilio, string telefono)
        {
            if (BuscarClientePorId(id) != null)
            {
                clienteDAO.EditarCliente(BuscarClientePorId(id), nombre, apellido, domicilio, telefono);
            }
        }

        public void EliminarCliente(int id)
        {
            if (BuscarClientePorId(id) != null)
            {
                clienteDAO.EliminarCliente(BuscarClientePorId(id));
            }
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
