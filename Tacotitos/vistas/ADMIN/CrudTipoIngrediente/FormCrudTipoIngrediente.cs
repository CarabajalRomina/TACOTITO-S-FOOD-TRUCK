
using Tacotitos.src;
using Tacotitos.src.controladoras;

namespace Tacotitos.vistas.ADMIN.CrudTipoIngrediente
{
    public partial class FormCrudTipoIngrediente : Form
    {
        TipoIngredienteController CntTipoIngrediente = TipoIngredienteController.GetControllerTipoIngrediente();
        public FormCrudTipoIngrediente()
        {
            InitializeComponent();
            EstilosForm();
            btnActualizar.Visible = false;
            ComponentesForm.DesabilitarOHabilitarControles(pnlForm.Controls.OfType<Control>());
            ActualizarDgvTipoIngrediente();
        }

        private void EstilosForm()
        {
            ComponentesForm.ConfigurarBorde(pnlForm, Color.AliceBlue, 1, 1, 1, 1);
        }



        #region CRUD
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CntTipoIngrediente.CrearTipoIngrediente(txtNombre.Text, Convert.ToInt32(nduCantMax.Value));
            ResetearCampos();
            ActualizarDgvTipoIngrediente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ComponentesForm.DesactivarOActivarControlesDelPanelForm(pnlForm.Controls.OfType<Control>(), btnNuevo);
            ComponentesForm.DesabilitarOHabilitarControles(pnlBotones.Controls.OfType<Button>());
            CambiarElEstadoVisibleDeLosBtnGuardarYActualizar();
            CargarFormTipoIngrediente(Convert.ToInt32(dgvTiposIngrediente.SelectedRows[0].Cells[0].Value));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvTiposIngrediente.Rows.Count > 0)
            {
                if (dgvTiposIngrediente.SelectedRows.Count > 0)
                {
                    CntTipoIngrediente.EditarTipoIngrediente(Convert.ToInt32(txtId.Text), txtNombre.Text, Convert.ToInt32(nduCantMax.Value));
                }
            }
            ResetearCampos();
            ComponentesForm.DesactivarOActivarControlesDelPanelForm(pnlForm.Controls.OfType<Control>(), btnNuevo);
            CambiarElEstadoVisibleDeLosBtnGuardarYActualizar();
            ComponentesForm.DesabilitarOHabilitarControles(pnlBotones.Controls.OfType<Button>());
            ActualizarDgvTipoIngrediente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTiposIngrediente.Rows.Count > 0)
            {
                if (dgvTiposIngrediente.SelectedRows.Count > 0)
                {
                    CntTipoIngrediente.EliminarTipoIngrediente(Convert.ToInt32(dgvTiposIngrediente.SelectedRows[0].Cells[0].Value));
                }
            }
            ActualizarDgvTipoIngrediente();
        }

        #endregion


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ComponentesForm.DesactivarOActivarControlesDelPanelForm(pnlForm.Controls.OfType<Control>(), btnNuevo);
            ComponentesForm.DesabilitarOHabilitarControles(pnlBotones.Controls.OfType<Button>());
        }

        private void ResetearCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            nduCantMax.Value = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetearCampos();
            ComponentesForm.DesactivarOActivarControlesDelPanelForm(pnlForm.Controls.OfType<Control>(), btnNuevo);
            ComponentesForm.DesabilitarOHabilitarControles(pnlBotones.Controls.OfType<Button>());
            CambiarElEstadoVisibleDeLosBtnGuardarYActualizar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ResetearCampos();
        }

        public void CargarDgvTipoIngrediente()
        {
            foreach (var tipo in CntTipoIngrediente.GetTiposIngrediente())
            {
                dgvTiposIngrediente.Rows.Add(tipo.Id, tipo.Nombre, tipo.CantidadMax);
            }
        }

        private void ActualizarDgvTipoIngrediente()
        {
            dgvTiposIngrediente.Rows.Clear();
            CargarDgvTipoIngrediente();
        }

        private void CargarFormTipoIngrediente(int id)
        {
            var tipoIngrediente = CntTipoIngrediente.BuscarTipoIngredienteId(id);

            txtId.Text = tipoIngrediente.Id.ToString();
            txtNombre.Text = tipoIngrediente.Nombre;
            nduCantMax.Value = tipoIngrediente.CantidadMax;
        }

        private void CambiarElEstadoVisibleDeLosBtnGuardarYActualizar()
        {
            ComponentesForm.CambiarEstadoVisibleDeUnControl(btnActualizar);
            ComponentesForm.CambiarEstadoVisibleDeUnControl(btnGuardar);
        }



    }
}
