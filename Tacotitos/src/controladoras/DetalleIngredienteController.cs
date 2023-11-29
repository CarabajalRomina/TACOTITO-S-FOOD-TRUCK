using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tacotitos.BD;
using Tacotitos.src.modelo.detalleIngrediente;
using Tacotitos.src.modelo.ingrediente;
using Tacotitos.src.modelo.tiposIngredientes;

namespace Tacotitos.src.controladoras
{
    internal class DetalleIngredienteController
    {
        static DetalleIngredienteController CntDetalleIngrediente = GetControllerDetalleIngrediente();
        DetalleIngredienteDAO detalleIngredienteDAO = new DetalleIngredienteDAO();


        #region SINGLETON
        private DetalleIngredienteController() { }

        public static DetalleIngredienteController GetControllerDetalleIngrediente()
        {
            if (CntDetalleIngrediente == null)
            {
                CntDetalleIngrediente = new DetalleIngredienteController();
            }

            return CntDetalleIngrediente;
        }
        #endregion

        #region CRUD
        public List<DetalleIngrediente> GetDetallesIngredientes()
        {
            return detalleIngredienteDAO.GetDetalleIngredientes();
        }

        public List<DetalleIngrediente> GetDetalleIngredientesEnUnTaco(int idTaco)
        {
            return detalleIngredienteDAO.GetDetalleIngredientesEnUnTaco(idTaco);
        }
        public void CrearDetalleIngrediente(int idTaco, int idIngrediente, double precioUnitario)
        {
            detalleIngredienteDAO.CrearDetalleIngrediente(idTaco,idIngrediente,precioUnitario);
        }

        public void EditarDetalleIngrediente(int idDetalleIngre, int idTaco, int idIngrediente, double precioUnitario)
        {
            if (BuscarDetalleIngredientePorId(idDetalleIngre) != null)
            {
                detalleIngredienteDAO.EditarDetalleIngrediente(BuscarDetalleIngredientePorId(idDetalleIngre), idTaco, idIngrediente, precioUnitario);
            }
        }

        public void EliminarIngrediente(int idDetalle)
        {
            if (BuscarDetalleIngredientePorId(idDetalle) != null)
            {
                detalleIngredienteDAO.EliminarDetalleIngrediente(BuscarDetalleIngredientePorId(idDetalle));
            }
        }
        #endregion

        public DetalleIngrediente BuscarDetalleIngredientePorId(int id)
        {
            return detalleIngredienteDAO.BuscarDetalleIngredientePorId(id);
        }

     

    }
}
