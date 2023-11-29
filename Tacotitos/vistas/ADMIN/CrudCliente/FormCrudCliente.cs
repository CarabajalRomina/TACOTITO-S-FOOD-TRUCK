using Tacotitos.src;
using Tacotitos.src.controladoras;

namespace Tacotitos.vistas.ADMIN.CrudCliente
{
    public partial class FormCrudCliente : Form
    {
        ClienteController CntCliente = ClienteController.GetControllerCliente();
        public FormCrudCliente()
        {
            InitializeComponent();
            ComponentesForm.DesabilitarOHabilitarControles(pnlForm.Controls.OfType<Control>());
            ActualizarDgvCliente();

        }

        #region CRUD
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(CntCliente.CrearCliente(txtNombre.Text, txtApellido.Text, txtDomicilio.Text, txtTelefono.Text))
            {
                MessageBox.Show("EL CLIENTE SE GENERO CORRECTAMENTE");
            }
       
            ResetearCampos();
            ActualizarDgvCliente();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count > 0)
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    if(CntCliente.EditarCliente(Convert.ToInt32(txtId.Text), txtNombre.Text, txtApellido.Text, txtDomicilio.Text, txtTelefono.Text))
                    {
                        MessageBox.Show($"EL CLIENTE {txtApellido} {txtNombre} SE EDITO CORRECTAMENTE");
                    }
                }
            }
            ResetearCampos();
            ComponentesForm.DesactivarOActivarControlesDelPanelForm(pnlForm.Controls.OfType<Control>(), btnNuevo);
            CambiarElEstadoVisibleDeLosBtnGuardarYActualizar();
            ComponentesForm.DesabilitarOHabilitarControles(pnlBotones.Controls.OfType<Button>());
            ActualizarDgvCliente();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ResetearCampos();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (CntCliente.EliminarCliente(Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value)))
            {
                MessageBox.Show("EL CLIENTE SE ELIMINO CORRECTAMENTE");
            }
            ActualizarDgvCliente();
        }
        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ComponentesForm.DesactivarOActivarControlesDelPanelForm(pnlForm.Controls.OfType<Control>(), btnNuevo);
            ComponentesForm.DesabilitarOHabilitarControles(pnlBotones.Controls.OfType<Button>());
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetearCampos();
            ComponentesForm.DesactivarOActivarControlesDelPanelForm(pnlForm.Controls.OfType<Control>(), btnNuevo);
            ComponentesForm.DesabilitarOHabilitarControles(pnlBotones.Controls.OfType<Button>());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ComponentesForm.DesactivarOActivarControlesDelPanelForm(pnlForm.Controls.OfType<Control>(), btnNuevo);
            CambiarElEstadoVisibleDeLosBtnGuardarYActualizar();
            ComponentesForm.DesabilitarOHabilitarControles(pnlBotones.Controls.OfType<Button>());
            CargarFormCliente(Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value));
        }

        private void ResetearCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDomicilio.Text = "";
            txtTelefono.Text = "";
        }

        private void CargarDgvCliente()
        {
            if (CntCliente.GetClientes().Count > 0)
            {
                foreach (var cliente in CntCliente.GetClientes())
                {
                    dgvClientes.Rows.Add(cliente.IdCliente, cliente.Nombre, cliente.Domicilio, cliente.Telefono);
                }
            }

        }

        private void ActualizarDgvCliente()
        {
            dgvClientes.Rows.Clear();
            CargarDgvCliente();
        }

        private void CambiarElEstadoVisibleDeLosBtnGuardarYActualizar()
        {
            ComponentesForm.CambiarEstadoVisibleDeUnControl(btnActualizar);
            ComponentesForm.CambiarEstadoVisibleDeUnControl(btnGuardar);
        }

        private void CargarFormCliente(int id)
        {
            var cliente = CntCliente.BuscarClientePorId(id);

            txtId.Text = cliente.IdCliente.ToString();
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtDomicilio.Text = cliente.Domicilio;
            txtTelefono.Text = cliente.Telefono;
        }

    }
}
