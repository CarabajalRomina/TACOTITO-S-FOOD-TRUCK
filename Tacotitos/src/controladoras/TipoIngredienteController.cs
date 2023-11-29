using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tacotitos.BD;
using Tacotitos.src.modelo.tiposIngredientes;

namespace Tacotitos.src.controladoras
{
    internal class TipoIngredienteController
    {
        private static TipoIngredienteController CntTipoIngrendiente;
        TipoIngredienteDAO TipoIngredienteBd = new TipoIngredienteDAO();

        #region SINGLETON
        private TipoIngredienteController() { }

        public static TipoIngredienteController GetControllerTipoIngrediente()
        {
            if (CntTipoIngrendiente == null)
            {
                CntTipoIngrendiente = new TipoIngredienteController();
            }

            return CntTipoIngrendiente;
        }
        #endregion

        #region CRUD
        public List<TipoIngrediente> GetTiposIngrediente()
        {
            return TipoIngredienteBd.GetTiposDeIngredientes();
        }

        public void CrearTipoIngrediente(string nombre, int cantMax)
        {
            TipoIngredienteBd.CrearTipoIngrediente(ValidarCampos.NormalizarString(nombre), cantMax);
        }

        public void EditarTipoIngrediente(int id, string nombre, int cantMax)
        {
            var tipo = BuscarTipoIngredienteId(id);
            TipoIngredienteBd.EditarTipoIngrediente(tipo, nombre, cantMax);
        }

        public void EliminarTipoIngrediente(int id)
        {
            var tipo = BuscarTipoIngredienteId(id);
            TipoIngredienteBd.EliminarTipoIngrediente(tipo);
        }


        #endregion

        public TipoIngrediente BuscarTipoIngredienteId(int id)
        {
            return TipoIngredienteBd.BuscarTipoIngredientePorId(id);
        }


    }
}
