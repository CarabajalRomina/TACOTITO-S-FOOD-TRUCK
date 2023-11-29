
using System.Linq.Expressions;
using Tacotitos.BD.Context;
using Tacotitos.src.modelo.cliente;

namespace Tacotitos.BD
{
    internal class ClienteDAO
    {
        private readonly TacotitosContext _context = TacotitosContext.GetContext();


        public ClienteDAO() { }

        public bool CrearCliente(string nombre, string apellido, string domicilio, string telefono)
        {
            try
            {
                var cliente = new Cliente
                {
                    Nombre = nombre,
                    Apellido  = apellido,
                    Domicilio = domicilio,
                    Telefono = telefono,
                    NombreCompleto = apellido + " "+ nombre,
                    BajaSino = false,
                    CuandoSeCreo = DateTime.Now,
                };

                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false; 
            }
        }

        public bool EditarCliente(Cliente cliente, string nombre, string apellido, string domicilio, string telefono)
        {
            try
            {
                cliente.Nombre = nombre;
                cliente.Apellido = apellido;
                cliente.NombreCompleto = apellido + " " + nombre;
                cliente.Domicilio = domicilio;
                cliente.Telefono = telefono;
                cliente.CuandoSeActualizo = DateTime.Now;

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<Cliente> GetClientes()
        {
            return _context.Clientes.ToList()
                   .Where(i => i.BajaSino == false)
                   .ToList();
        }

        public Cliente BuscarClientePorId(int id)
        {
            return _context.Clientes.Find(id);
        }

        public bool EliminarCliente(Cliente cliente)
        {
            try
            {
                cliente.BajaSino = true;
                cliente.CuandoSeElimino = DateTime.Now;
                _context.SaveChanges();
                return true;
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public List<Cliente> BuscarClientePorApellidoNombre(string nombreCompleto)
        {
            return _context.Clientes
                .Where(c => c.Nombre.Contains(nombreCompleto))
                .ToList();
        }
    }
}
