using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tacotitos.src.controladoras;
using Tacotitos.src.modelo.cliente;
using Tacotitos.src.modelo.taco;
using Tacotitos.vistas.pedido;

namespace Tacotitos.vistas
{
    public partial class FormPedido : Form
    {
        TacoController CntTaco = TacoController.GetControllerTaco();
        ClienteController CntCliente = ClienteController.GetControllerCliente();
        PedidoController CntPedido = PedidoController.GetControllerPedido();
        DetalleIngredienteController CntDetalleIngrediente = DetalleIngredienteController.GetControllerDetalleIngrediente();
        public FormPedido()
        {
            InitializeComponent();
            ActualizarDgvPedido();
            lbBuscar.DataSource = CntCliente.GetClientes();
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void CargarDgvPedido()
        {
            if (CntTaco.TACOS.Count > 0)
            {
                var aux = 1;
                foreach (var taco in CntTaco.TACOS)
                {
                    dgvPedidos.Rows.Add(taco, $"TACO {aux}");
                    aux++;
                }
            }
        }

        private void ActualizarDgvPedido()
        {
            dgvPedidos.Rows.Clear();
            CargarDgvPedido();
        }

        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            var pedido = CntPedido.CrearPedido(((Cliente)lbBuscar.SelectedItem).IdCliente);
            foreach (Taco tac in CntTaco.TACOS)
            {
                var taco = CntTaco.CrearTaco(pedido.IdPedido);

                foreach (var detalleIngre in tac.Ingredientes)
                {
                    CntDetalleIngrediente.CrearDetalleIngrediente(taco.IdTaco, detalleIngre.ingrediente.IdIngrediente, detalleIngre.PrecioUnitario);
                }
            }
            MessageBox.Show($"El pedido se registro de {txtBuscar.Text.ToUpper()}, se registro correctamente");
            CntTaco.TACOS.Clear();
            Dispose();
        }

        private void lbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarFormCliente(((Cliente)lbBuscar.SelectedItem).IdCliente);
            txtBuscar.Text = ((Cliente)lbBuscar.SelectedItem).NombreCompleto;
            lbBuscar.Visible = false;
        }

        public void CargarFormCliente(int idCliente)
        {
            if (CntCliente.BuscarClientePorId(idCliente) != null)
            {
                var cliente = CntCliente.BuscarClientePorId(idCliente);
                txtId.Text = cliente.IdCliente.ToString();
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDomicilio.Text = cliente.Domicilio;
                txtTelefono.Text = cliente.Telefono;
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                lbBuscar.Visible = true;
                lbBuscar.DataSource = CntCliente.BuscarClientePorApellidoNombre(txtBuscar.Text);
                lbBuscar.DisplayMember = "NombreCompleto";
            }
            else { lbBuscar.Visible = false; }

        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedidos.Columns[e.ColumnIndex].Name == "DETALLE")
            {
                FormDetalleTaco form = new FormDetalleTaco(dgvPedidos.SelectedRows[0].Cells[1].Value.ToString(), ((Taco)dgvPedidos.SelectedRows[0].Cells["TACO"].Value), dgvPedidos.SelectedRows[0].Index);
                form.ShowDialog();

            }else if(dgvPedidos.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                CntTaco.BorrarTaco(((Taco)dgvPedidos.SelectedRows[0].Cells["TACO"].Value));
                MessageBox.Show($"EL {dgvPedidos.SelectedRows[0].Cells[1].Value} SE ELIMINO CORRECTAMENTE");
                ActualizarDgvPedido();

            }
        }
    }
}
