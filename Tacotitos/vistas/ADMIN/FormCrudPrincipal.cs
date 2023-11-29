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
using Tacotitos.vistas.ADMIN.CrudCliente;
using Tacotitos.vistas.ADMIN.CrudIngrediente;
using Tacotitos.vistas.ADMIN.CrudTipoIngrediente;

namespace Tacotitos.vistas.ADMIN
{
    public partial class FormCrudPrincipal : Form
    {
        Form activeForm;

        public FormCrudPrincipal()
        {
            InitializeComponent();
            ComponentesForm.ConfigurarBorde(pnlSuperior2, Color.SeaGreen, 0, 0, 0, 3);
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void CargarForm(Form childForm)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(childForm);
            pnlContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnTipoIngrediente_Click(object sender, EventArgs e)
        {
            CargarForm(new FormCrudTipoIngrediente());
        }

        private void btnIngrediente_Click(object sender, EventArgs e)
        {
            CargarForm(new FormCrudIngrediente());
        }

        private void btnClientr_Click(object sender, EventArgs e)
        {
            CargarForm(new FormCrudCliente());
        }
    }
}
