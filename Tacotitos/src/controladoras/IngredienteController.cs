using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tacotitos.BD;
using Tacotitos.src.interfaces;
using Tacotitos.src.modelo.detalleIngrediente;
using Tacotitos.src.modelo.ingrediente;
using Tacotitos.src.modelo.tiposIngredientes;

namespace Tacotitos.src.controladoras
{
    internal class IngredienteController
    {
        private static IngredienteController? CntIngrendiente;
        TacoController CntTaco = TacoController.GetControllerTaco();
        IngredienteDAO IngredienteBd = new IngredienteDAO();


        #region SINGLETON
        private IngredienteController() { }

        public static IngredienteController GetControllerIngrediente()
        {
            if (CntIngrendiente == null)
            {
                CntIngrendiente = new IngredienteController();
            }

            return CntIngrendiente;
        }
        #endregion


        #region CRUD
        public List<Ingrediente> GetIngredientes()
        {
            return IngredienteBd.GetIngredientes();
        }
        public void CrearIngrediente(string nombre, TipoIngrediente tipo, double precio)
        {
            IngredienteBd.CrearIngrediente(nombre, tipo, precio);
        }

        public void EditarIngrediente(int id, string nombre, TipoIngrediente tipo, double precio)
        {
            if(BuscarIngredientePorId(id)!= null)
            {
                IngredienteBd.EditarIngrediente(BuscarIngredientePorId(id), nombre, tipo, precio);
            }
        }

        public void EliminarIngrediente(int id)
        {
            if (BuscarIngredientePorId(id) != null)
            {
                IngredienteBd.EliminarIngrediente(BuscarIngredientePorId(id));
            }
        }
        #endregion

        public Ingrediente BuscarIngredientePorId(int id)
        {
            return IngredienteBd.BuscarIngredientePorId(id);
        }

        public List<Ingrediente> GetIngredientesSegunTipoIngrediente(int idIngrediente)
        {
            return IngredienteBd.GetIngredientesSegunTipoIngrediente(idIngrediente);
        }

        public List<Ingrediente> GetIngredientesQueNoEstanDentroDeUnTaco(int idTipoIngrediente, List<DetalleIngrediente> listDetalleIngre)
        {
            return GetIngredientesSegunTipoIngrediente(idTipoIngrediente).Except(CntTaco.GetIngredientesSegunTipoIngredienteEnUnTaco(idTipoIngrediente, listDetalleIngre)).ToList();
        }



    }
}
