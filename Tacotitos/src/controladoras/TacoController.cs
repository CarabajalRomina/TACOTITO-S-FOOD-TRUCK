using Tacotitos.BD;
using Tacotitos.src.modelo.detalleIngrediente;
using Tacotitos.src.modelo.ingrediente;
using Tacotitos.src.modelo.taco;

namespace Tacotitos.src.controladoras
{
    internal class TacoController
    {
        private static TacoController CntTaco;
        private List<DetalleIngrediente> ListDetalleIngre = new List<DetalleIngrediente>();

        TacoDAO tacoDAO = new TacoDAO();
        //private List<Ingrediente> ListDetalleIngre = new List<Ingrediente>();
        private List<Taco> Tacos = new List<Taco>();

        #region SINGLETON
        private TacoController() { }

        public static TacoController GetControllerTaco()
        {
            if (CntTaco == null)
            {
                CntTaco = new TacoController();
            }

            return CntTaco;
        }

        #endregion

        #region CRUD
        public Taco CrearTaco(int idPedido)
        {
            return tacoDAO.CrearTaco(idPedido);
        }
        public List<Taco> GetTacos()
        {
            return tacoDAO.GetTacos();
        }

        public void EditarTaco(int idTaco,int idPedido)
        {
            var taco = BuscarTacoPorId(idTaco);
            tacoDAO.EditarTaco(taco, idPedido);
        }

        public void EliminarTaco(Taco taco)
        {
            tacoDAO.EliminarTaco(taco);
        }
        #endregion

        public Taco BuscarTacoPorId(int idTaco)
        {
            return tacoDAO.BuscarTacoPorId(idTaco);
        }
        public List<Ingrediente> GetIngredientesSegunTipoIngredienteEnUnTaco(int idTipoIngrediente, List<DetalleIngrediente> ListDetalleIngre)
        {
            return ListDetalleIngre.FindAll(di => di.ingrediente.IdTipoIngrediente == idTipoIngrediente).Select(di => di.ingrediente).ToList();
        }

        ///<summary>
        ///Agrega un detalle ingrediente a la lista de detalles ingredientes que es un atributo de la cntTaco
        ///</summary>
        public void AgregarDetalleIngredienteALista(Ingrediente ingrediente)
        {
            LISTDETALLEINGRE.Add(new DetalleIngrediente(ingrediente, ingrediente.Precio));
        }

        ///<summary>
        ///Elimina un detalle ingrediente de la lista detalle ingredientes que es un atributo de la cntTaco
        ///</summary>
        public void EliminarDetalleIngredienteDeLista(int idIngrediente)
        {
            var detalleIngrediente = LISTDETALLEINGRE.FirstOrDefault(di => di.ingrediente.IdIngrediente == idIngrediente);
            if (detalleIngrediente != null)
            {
                CntTaco.LISTDETALLEINGRE.Remove(detalleIngrediente);
            }
        }

        public void AgregarDetalleIngreAUnTaco(Ingrediente ingrediente, Taco taco)
        {
            taco.Ingredientes.Add(new DetalleIngrediente(ingrediente, ingrediente.Precio));
        }

        public void EliminarDetalleIngreDeUnTaco(int IdIngrediente, Taco taco)
        {
            var detalleIngrediente = taco.Ingredientes.FirstOrDefault(di => di.ingrediente.IdIngrediente == IdIngrediente);
            if (detalleIngrediente != null)
            {
                taco.Ingredientes.Remove(detalleIngrediente);
            }
        }

        public void AgregarTaco()
        {
            Tacos.Add(new Taco(LISTDETALLEINGRE));
        }

        ///<summary>
        ///Elimina un taco de la lista de tacos del pedido
        ///</summary>
        public void BorrarTaco(Taco taco)
        {
            Tacos.Remove(taco);
        }
        public bool ComprobarQueElTacoTengaUnAlimento(List<DetalleIngrediente> listDetalleIngre)
        {
            return listDetalleIngre.Any(di => di.ingrediente.tipoIngrediente.EsAlimento());
        }

        public bool ComprobarQueElTacoTengaUnaTortilla(List<DetalleIngrediente> listDetalleIngre)
        {
            return listDetalleIngre.Any(di => di.ingrediente.tipoIngrediente.EsTortilla());
        }



        #region PROPIEDADES
        public List<DetalleIngrediente> LISTDETALLEINGRE
        {
            get { return ListDetalleIngre; }
            set
            {
                if(value != null)
                {
                    ListDetalleIngre = value;
                }
            }
        }
        public List<Taco> TACOS
        {
            get { return Tacos; }
            set { if (value != null) { Tacos = value; } }
        }
        #endregion
            
    }
}
