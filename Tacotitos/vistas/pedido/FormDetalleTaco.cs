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
using Tacotitos.src.modelo.detalleIngrediente;
using Tacotitos.src.modelo.taco;

namespace Tacotitos.vistas.pedido
{
    public partial class FormDetalleTaco : Form
    {
        Taco taco;
        int IndexList;

        string NroTaco;
        public FormDetalleTaco(string nroTaco, Taco taco, int index)
        {
            InitializeComponent();
            TACO = taco;
            NROTACO = nroTaco;
            INDEXLIST = index;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditarTaco form = new FormEditarTaco(TACO, INDEXLIST);
            form.ShowDialog();
            Dispose();
           
        }

        private void CargarDgvDetalleIngre()
        {
            foreach (var di in TACO.Ingredientes)
            {
                dgvDetallesIngre.Rows.Add(di.IdIngrediente,di.ingrediente.Nombre, di.ingrediente.tipoIngrediente.Nombre, di.PrecioUnitario);
            }
        }


        private void ActualizarDgvDetalleIngre()
        {
            dgvDetallesIngre.Rows.Clear();
            CargarDgvDetalleIngre();
        }

        private void FormDetalleTaco_Load(object sender, EventArgs e)
        {
            ActualizarDgvDetalleIngre();
            lblPrecio.Text = "$" + TACO.GetPrecioTaco().ToString();
            lblNroTaco.Text = NROTACO;
        }

        #region PROPIEDADES
        public Taco TACO
        {
            get { return taco; }
            set { taco = value; }
        }

        public string NROTACO
        {
            get { return NroTaco; }
            set
            {
                if (value != null)
                {
                    NroTaco = value;
                }

            }
        }

        public int INDEXLIST
        {
            get { return IndexList; }
            set { IndexList = value; }
        }
        #endregion
    }
}
