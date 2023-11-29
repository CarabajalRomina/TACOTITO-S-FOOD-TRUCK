using Tacotitos.BD;
using Tacotitos.src.modelo.tiposIngredientes;

namespace Tacotitos.src.controladoras
{
    internal class TipoIngredienteController
    {
        private static TipoIngredienteController CntTipoIngrendiente;
        TipoIngredienteDAO tipoIngredienteDAO = new TipoIngredienteDAO();

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
            return tipoIngredienteDAO.GetTiposDeIngredientes();
        }

        public bool CrearTipoIngrediente(string nombre, int cantMax)
        {
            return tipoIngredienteDAO.CrearTipoIngrediente(ValidarCampos.NormalizarString(nombre), cantMax);
        }

        public bool EditarTipoIngrediente(int id, string nombre, int cantMax)
        {
            var tipo = BuscarTipoIngredienteId(id);
            return tipoIngredienteDAO.EditarTipoIngrediente(tipo, nombre, cantMax);
        }

        public bool EliminarTipoIngrediente(int id)
        {
            var tipo = BuscarTipoIngredienteId(id);
            return tipoIngredienteDAO.EliminarTipoIngrediente(tipo);
        }


        #endregion

        public TipoIngrediente BuscarTipoIngredienteId(int id)
        {
            return tipoIngredienteDAO.BuscarTipoIngredientePorId(id);
        }


    }
}
