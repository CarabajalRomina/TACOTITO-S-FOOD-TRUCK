using Tacotitos.src;
using Tacotitos.src.controladoras;
using Tacotitos.src.modelo.tiposIngredientes;

namespace Tacotitos.vistas
{
    public partial class FormArmarTacos : Form
    {
        IngredienteController CntIngrediente = IngredienteController.GetControllerIngrediente();
        TipoIngredienteController CntTipoIngrediente = TipoIngredienteController.GetControllerTipoIngrediente();
        TacoController CntTaco = TacoController.GetControllerTaco();

        public FormArmarTacos()
        {
            InitializeComponent();
            if (CntTipoIngrediente.GetTiposIngrediente().Count > 0)
            {
                ComponentesForm.CargarComboBox(CntTipoIngrediente.GetTiposIngrediente(), cbbTiposIngredientes);
            }
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dgvIngredientesTaco_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Maneja el evento EditingControlShowing para permitir cambios en la celda mientras se edita
            TextBox textBox = e.Control as TextBox;
            if (textBox != null)
            {
                textBox.KeyPress -= TextBox_KeyPress;
                textBox.KeyPress += TextBox_KeyPress;
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void VerificarSiElNumeroEsMayorAlNumMax(int valorCelda)
        {
            if (cbbTiposIngredientes.SelectedIndex != -1)
            {
                int valorMax = ((TipoIngrediente)cbbTiposIngredientes.SelectedItem).CantidadMax;


                if (valorCelda >= valorMax)
                {
                    // dgvIngredientesTaco.SelectedCells[0].Value = valorMax;
                    dgvIngredientesTaco.SelectedRows[0].Cells[3].Value = valorMax.ToString();
                }
            }
        }

        public void CargarDgvIngredientesTaco()
        {
            var IdTipoIngrediente = ((TipoIngrediente)cbbTiposIngredientes.SelectedItem).Id;
            if (IdTipoIngrediente > 0)
            {
                if (CntIngrediente.GetIngredientesSegunTipoIngrediente(IdTipoIngrediente).Count > 0)
                {
                    if (CntTaco.GetIngredientesSegunTipoIngredienteEnUnTaco(IdTipoIngrediente, CntTaco.LISTDETALLEINGRE).Count > 0)
                    {
                        foreach (var ingrediente in CntIngrediente.GetIngredientesQueNoEstanDentroDeUnTaco(IdTipoIngrediente, CntTaco.LISTDETALLEINGRE))
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
        }

        public void ActualizarDgvIngredientesTaco()
        {
            dgvIngredientesTaco.Rows.Clear();

            CargarDgvIngredientesTaco();
        }

        private void cbbTiposIngredientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CntIngrediente.GetIngredientesSegunTipoIngrediente(((TipoIngrediente)cbbTiposIngredientes.SelectedItem).Id).Count > 0)
            {
                ActualizarDgvIngredientesTaco();
                lblInfo.Text = $"El maximo de {((TipoIngrediente)cbbTiposIngredientes.SelectedItem).Nombre}s que puede agregar a un taco es {((TipoIngrediente)cbbTiposIngredientes.SelectedItem).CantidadMax}";
                lblAviso.Text = "";
            }
        }

        private void pcbAgregar_Click(object sender, EventArgs e)
        {

            if (dgvIngredientesTaco.SelectedRows.Count > 0)
            {
                lblAviso.Text = "";
                ArmarTaco();
                ActualizarDgvTaco();
                ActualizarDgvIngredientesTaco();
            }
            else
            {
                lblAviso.Text = "Debe seleccionar al menos un ingrediente";
            }
        }
        private void pcbQuitar_Click(object sender, EventArgs e)
        {
            if (dgvTaco.SelectedRows.Count > 0)
            {
                lblAviso.Text = "";
                EliminarIngredienteDelTaco();
                ActualizarDgvTaco();
                ActualizarDgvIngredientesTaco();
            }
            else
            {
                lblAviso.Text = "Debe seleccionar al menos un ingrediente";
            }
        }

        private void ArmarTaco()
        {
            for (int i = 0; i < dgvIngredientesTaco.SelectedRows.Count; i++)
            {
                var ingrediente = CntIngrediente.BuscarIngredientePorId(Convert.ToInt32(dgvIngredientesTaco.SelectedRows[i].Cells[0].Value));

                if (ingrediente != null)
                {
                    if (CntTaco.GetIngredientesSegunTipoIngredienteEnUnTaco(ingrediente.IdTipoIngrediente, CntTaco.LISTDETALLEINGRE).Count() < CntTipoIngrediente.BuscarTipoIngredienteId(ingrediente.IdTipoIngrediente).CantidadMax)
                    {
                        CntTaco.AgregarDetalleIngredienteALista(ingrediente);
                    }
                    else
                    {
                        lblAviso.Text = $"Ya alcanzo la cantidad maxima de {CntTipoIngrediente.BuscarTipoIngredienteId(ingrediente.IdTipoIngrediente).Nombre}s que puede contener 1 taco";
                    }
                }
            }
        }

        private void EliminarIngredienteDelTaco()
        {
            for (int i = 0; i < dgvTaco.SelectedRows.Count; i++)
            {
                CntTaco.EliminarDetalleIngredienteDeLista(Convert.ToInt32(dgvTaco.SelectedRows[i].Cells[0].Value));
            }
        }

        private void CargarDgvTaco()
        {
            if (CntTaco.LISTDETALLEINGRE.Count > 0)
            {
                foreach (var detalleingre in CntTaco.LISTDETALLEINGRE)
                {
                    dgvTaco.Rows.Add(detalleingre.ingrediente.IdIngrediente, detalleingre.ingrediente.Nombre, detalleingre.PrecioUnitario, CntTipoIngrediente.BuscarTipoIngredienteId(detalleingre.ingrediente.IdTipoIngrediente));
                }
            }
        }

        private void ActualizarDgvTaco()
        {
            dgvTaco.Rows.Clear();
            CargarDgvTaco();
        }

        private void pcbPedido_Click(object sender, EventArgs e)
        {
            FormPedido form = new FormPedido();
            form.Show();
        }

        private void btnAgregarAPedido_Click(object sender, EventArgs e)
        {
            if (CntTaco.LISTDETALLEINGRE.Count > 0)
            {
                if (CntTaco.ComprobarQueElTacoTengaUnaTortilla(CntTaco.LISTDETALLEINGRE))
                {
                    if (CntTaco.ComprobarQueElTacoTengaUnAlimento(CntTaco.LISTDETALLEINGRE))
                    {
                        CntTaco.AgregarTaco();
                        MessageBox.Show("El taco se agrego a su pedido");
                        CntTaco.LISTDETALLEINGRE.Clear();
                        ActualizarDgvTaco();
                        ActualizarDgvIngredientesTaco();
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
    }
}
