using Tacotitos.BD;
using Tacotitos.src.modelo.detalleIngrediente;
using Tacotitos.src.modelo.ingrediente;
using Tacotitos.src.modelo.tiposIngredientes;

namespace Tacotitos.src.controladoras
{
    internal class IngredienteController
    {
        private static IngredienteController? CntIngrendiente;
        TacoController CntTaco = TacoController.GetControllerTaco();
        IngredienteDAO ingredienteDAO = new IngredienteDAO();


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
            return ingredienteDAO.GetIngredientes();
        }
        public bool CrearIngrediente(string nombre, TipoIngrediente tipo, double precio)
        {
            return ingredienteDAO.CrearIngrediente(nombre, tipo, precio);
        }

        public bool EditarIngrediente(int id, string nombre, TipoIngrediente tipo, double precio)
        {
             return  ingredienteDAO.EditarIngrediente(BuscarIngredientePorId(id), nombre, tipo, precio);
        }

        public bool EliminarIngrediente(int id)
        {
            return ingredienteDAO.EliminarIngrediente(BuscarIngredientePorId(id));
        }
        #endregion

        public Ingrediente BuscarIngredientePorId(int id)
        {
            return ingredienteDAO.BuscarIngredientePorId(id);
        }

        public List<Ingrediente> GetIngredientesSegunTipoIngrediente(int idIngrediente)
        {
            return ingredienteDAO.GetIngredientesSegunTipoIngrediente(idIngrediente);
        }

        public List<Ingrediente> GetIngredientesQueNoEstanDentroDeUnTaco(int idTipoIngrediente, List<DetalleIngrediente> listDetalleIngre)
        {
            return GetIngredientesSegunTipoIngrediente(idTipoIngrediente).Except(CntTaco.GetIngredientesSegunTipoIngredienteEnUnTaco(idTipoIngrediente, listDetalleIngre)).ToList();
        }



    }
}
