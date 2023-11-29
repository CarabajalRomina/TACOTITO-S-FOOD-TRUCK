using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tacotitos.src;
using Tacotitos.src.controladoras;
using Tacotitos.src.modelo.detalleIngrediente;
using Tacotitos.src.modelo.ingrediente;
using Tacotitos.src.modelo.taco;
using Tacotitos.src.modelo.tiposIngredientes;

namespace Tacotitos.vistas.pedido
{
    public partial class FormEditarTaco : Form
    {

        Taco taco;
        int IndexList;

        //CONTROLADORAS
        IngredienteController CntIngrediente = IngredienteController.GetControllerIngrediente();
        TacoController CntTaco = TacoController.GetControllerTaco();
        TipoIngredienteController CntTipoIngrediente = TipoIngredienteController.GetControllerTipoIngrediente();


        public FormEditarTaco(Taco tco, int indexList)
        {
            TACO = tco;
            INDEXLIST = indexList;
            InitializeComponent();
            ComponentesForm.CargarComboBox(CntTipoIngrediente.GetTiposIngrediente(), cbbTiposIngredientes);
            cbbTiposIngredientes.SelectedIndex = 0;       
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (TACO.Ingredientes.Count > 0)
            {
                if (CntTaco.ComprobarQueElTacoTengaUnaTortilla((List<DetalleIngrediente>)TACO.Ingredientes))
                {
                    if (CntTaco.ComprobarQueElTacoTengaUnAlimento((List<DetalleIngrediente>)TACO.Ingredientes))
                    {
                        CntTaco.TACOS[INDEXLIST] = TACO;
                        MessageBox.Show("EL TACO SE ACTUALIZO CORRECTAMENTE");
                        Dispose();
                    }
                    else
                    {
                        lblAviso.Text = "EL TACO DEBE CONTENER AL MENOS UN ALIMENTO, POR FAVOR ELIJA UNO";
                    }
                }
                else
                {
                    lblAviso.Text = "EL TACO DEBE CONTENER AL MENOS UNA TORTILLA, POR FAVOR ELIJA UNA";
                }
            }
            else
            {
                lblAviso.Text = "SELECCIONE LOS INGREDIENTES QUE VA A CONTENER SU TACO";
            }
        }



        ///<summary>
        ///Metodo para cerrar el formulario
        ///</summary>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        #region METODOS ACTUALIZAR Y CARGAR DGV INGREDIENTES

        ///<summary>
        ///Carga el data grid view, validando que no se repitan los ingredientes que ya esten dentro de un taco 
        ///</summary>
        private void CargarDgvIngredientes()
        {
            var IdTipoIngrediente = ((TipoIngrediente)cbbTiposIngredientes.SelectedItem).Id;
            if (IdTipoIngrediente > 0)
            {
                if (CntIngrediente.GetIngredientesSegunTipoIngrediente(IdTipoIngrediente).Count > 0)
                {
                    if (CntTaco.GetIngredientesSegunTipoIngredienteEnUnTaco(IdTipoIngrediente, (List<DetalleIngrediente>)TACO.Ingredientes).Count > 0)
                    {
                        foreach (var ingrediente in CntIngrediente.GetIngredientesQueNoEstanDentroDeUnTaco(IdTipoIngrediente, (List<DetalleIngrediente>)TACO.Ingredientes))
                        {
                            dgvIngredientesTaco.Rows.Add(ingrediente.IdIngrediente, ingrediente.Nombre, ingrediente.Precio);
                        }
                    }
                    else
                    {
                        foreach (var ingrediente in CntIngrediente.GetIngredientesSegunTipoIngrediente(IdTipoIngrediente))
                        {
                            dgvIngredientesTaco.Rows.Add(ingrediente.IdIngrediente, ingrediente.Nombre, ingrediente.Precio);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay ingredientes de ese tipo");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de ingrediente");
            }
        }

        ///<summary>
        ///Actualiza el datagrid view 
        ///</summary>
        private void ActualizarDgvIngredientes()
        {
            dgvIngredientesTaco.Rows.Clear();
            CargarDgvIngredientes();
        }
        #endregion

        #region METODOS ACTUALIZAR Y CARGAR DGV DETALLE TACO
        private void CargarDgvDetalleTaco()
        {
            foreach (var di in TACO.Ingredientes)
            {
                dgvDetalleTaco.Rows.Add(di.ingrediente.IdIngrediente, di.ingrediente.Nombre, di.ingrediente.tipoIngrediente.Nombre, di.PrecioUnitario);
            }
        }

        private void ActualizarDgvDetalleTaco()
        {
            dgvDetalleTaco.Rows.Clear();
            CargarDgvDetalleTaco();
        }
        #endregion

        private void FormEditarTaco_Load(object sender, EventArgs e)
        {
            ActualizarDgvDetalleTaco();
            ActualizarDgvIngredientes();
        }


        private void ArmarTaco()
        {
            for (int i = 0; i < dgvIngredientesTaco.SelectedRows.Count; i++)
            {
                var ingrediente = CntIngrediente.BuscarIngredientePorId(Convert.ToInt32(dgvIngredientesTaco.SelectedRows[i].Cells[0].Value));

                if (ingrediente != null)
                {
                    if (CntTaco.GetIngredientesSegunTipoIngredienteEnUnTaco(ingrediente.IdTipoIngrediente, (List<DetalleIngrediente>)TACO.Ingredientes).Count() < CntTipoIngrediente.BuscarTipoIngredienteId(ingrediente.IdTipoIngrediente).CantidadMax)
                    {
                        CntTaco.AgregarDetalleIngreAUnTaco(ingrediente, TACO);
                    }
                    else
                    {
                        lblAviso.Text = $"Ya alcanzo la cantidad maxima de {CntTipoIngrediente.BuscarTipoIngredienteId(ingrediente.IdTipoIngrediente).Nombre}s que puede contener 1 taco";
                    }
                }
            }
        }

        private void EliminarDetalleIngreDeUnTaco()
        {
            for (int i = 0; i < dgvDetalleTaco.SelectedRows.Count; i++)
            {
                CntTaco.EliminarDetalleIngreDeUnTaco(Convert.ToInt32(dgvDetalleTaco.SelectedRows[i].Cells[0].Value), TACO);
            }
        }
        private void pcbAgregar_Click(object sender, EventArgs e)
        {
            if (dgvIngredientesTaco.SelectedRows.Count > 0)
            {
                lblAviso.Text = "";
                ArmarTaco();
                ActualizarDgvDetalleTaco();
                ActualizarDgvIngredientes();
            }
            else
            {
                lblAviso.Text = "Debe seleccionar al menos un ingrediente";
            }
        }

        private void pcbQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalleTaco.SelectedRows.Count > 0)
            {
                lblAviso.Text = "";
                EliminarDetalleIngreDeUnTaco();
                ActualizarDgvDetalleTaco();
                ActualizarDgvIngredientes();
            }
            else
            {
                lblAviso.Text = "Debe seleccionar al menos un ingrediente";
            }
        }

        private void cbbTiposIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CntIngrediente.GetIngredientesSegunTipoIngrediente(((TipoIngrediente)cbbTiposIngredientes.SelectedItem).Id).Count > 0)
            {
                ActualizarDgvIngredientes();
                lblInfo.Text = $"El maximo de {((TipoIngrediente)cbbTiposIngredientes.SelectedItem).Nombre}s que puede agregar a un taco es {((TipoIngrediente)cbbTiposIngredientes.SelectedItem).CantidadMax}";
                lblAviso.Text = "";
            }
        }

        #region PROPIEDADES
        public Taco TACO
        {
            get { return taco; }
            set { if (value != null) { taco = value; } }
        }

        public int INDEXLIST
        {
            get { return IndexList; }
            set { IndexList = value; }
        }
        #endregion
    }
}
