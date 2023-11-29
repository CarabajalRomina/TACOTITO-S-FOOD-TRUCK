using Tacotitos.src;
using Tacotitos.src.controladoras;
using Tacotitos.src.modelo.tiposIngredientes;

namespace Tacotitos.vistas.ADMIN.CrudIngrediente
{
    public partial class FormCrudIngrediente : Form
    {
        IngredienteController CntIngrediente = IngredienteController.GetControllerIngrediente();
        TipoIngredienteController CntTipoIngrediente = TipoIngredienteController.GetControllerTipoIngrediente();

        public FormCrudIngrediente()
        {
            InitializeComponent();
            ComponentesForm.DesabilitarOHabilitarControles(pnlForm.Controls.OfType<Control>());
            ActualizarDgvIngrediente();
            if (CntTipoIngrediente.GetTiposIngrediente() != null)
            {
                ComponentesForm.CargarComboBox(CntTipoIngrediente.GetTiposIngrediente(), cbbTipo);
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ComponentesForm.DesactivarOActivarControlesDelPanelForm(pnlForm.Controls.OfType<Control>(), btnNuevo);
            ComponentesForm.DesabilitarOHabilitarControles(pnlBotones.Controls.OfType<Button>());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ComponentesForm.DesactivarOActivarControlesDelPanelForm(pnlForm.Controls.OfType<Control>(), btnNuevo);
            CambiarElEstadoVisibleDeLosBtnGuardarYActualizar();
            ComponentesForm.DesabilitarOHabilitarControles(pnlBotones.Controls.OfType<Button>());
            CargarFormIngrediente(Convert.ToInt32(dgvIngredientes.SelectedRows[0].Cells[0].Value));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvIngredientes.Rows.Count > 0)
            {
                if (dgvIngredientes.SelectedRows.Count > 0)
                {
                    if(CntIngrediente.EditarIngrediente(Convert.ToInt32(txtId.Text), txtNombre.Text, (TipoIngrediente)cbbTipo.SelectedItem, Convert.ToDouble(nduPrecio.Value)))
                    {
                        MessageBox.Show("EL INGREDIENTE SE ACTUALIZO CORRECTAMENTE");
                    }
                }
            }
            ResetearCampos();
            ComponentesForm.DesactivarOActivarControlesDelPanelForm(pnlForm.Controls.OfType<Control>(), btnNuevo);
            CambiarElEstadoVisibleDeLosBtnGuardarYActualizar();
            ComponentesForm.DesabilitarOHabilitarControles(pnlBotones.Controls.OfType<Button>());
            ActualizarDgvIngrediente();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(CntIngrediente.CrearIngrediente(txtNombre.Text, (TipoIngrediente)cbbTipo.SelectedItem, Convert.ToDouble(nduPrecio.Value)))
            {
                MessageBox.Show($"EL INGREDIENTE {txtNombre.Text} SE CREO CORRECTAMENTE");
            }
            ResetearCampos();
            ActualizarDgvIngrediente();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (CntIngrediente.EliminarIngrediente(Convert.ToInt32(dgvIngredientes.SelectedRows[0].Cells[0].Value)))
            {
                MessageBox.Show("EL INGREDIENTE SE ELIMINO CORRECTAMENTE");
            }
            ActualizarDgvIngrediente();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetearCampos();
            ComponentesForm.DesactivarOActivarControlesDelPanelForm(pnlForm.Controls.OfType<Control>(), btnNuevo);
            ComponentesForm.DesabilitarOHabilitarControles(pnlBotones.Controls.OfType<Button>());
        }


        private void ResetearCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            cbbTipo.SelectedIndex = -1;
            nduPrecio.Value = 0;
        }

        private void CargarDgvIngredientes()
        {
            if (CntIngrediente.GetIngredientes().Count > 0)
            {
                foreach (var ingrediente in CntIngrediente.GetIngredientes())
                {
                    dgvIngredientes.Rows.Add(ingrediente.IdIngrediente, ingrediente.Nombre, CntTipoIngrediente.BuscarTipoIngredienteId(ingrediente.IdTipoIngrediente), ingrediente.Precio);
                }
            }
        }

        private void ActualizarDgvIngrediente()
        {
            dgvIngredientes.Rows.Clear();
            CargarDgvIngredientes();
        }

        private void CargarFormIngrediente(int id)
        {
            var ingrediente = CntIngrediente.BuscarIngredientePorId(id);

            txtId.Text = ingrediente.IdIngrediente.ToString();
            txtNombre.Text = ingrediente.Nombre;
            cbbTipo.SelectedItem = CntTipoIngrediente.BuscarTipoIngredienteId(ingrediente.IdTipoIngrediente);
            nduPrecio.Value = Convert.ToDecimal(ingrediente.Precio);
        }

        private void CambiarElEstadoVisibleDeLosBtnGuardarYActualizar()
        {
            ComponentesForm.CambiarEstadoVisibleDeUnControl(btnActualizar);
            ComponentesForm.CambiarEstadoVisibleDeUnControl(btnGuardar);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ResetearCampos();
        }
    }
}
