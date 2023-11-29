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
using Tacotitos.vistas.ADMIN;

namespace Tacotitos.vistas
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
            
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormCrudPrincipal form = new FormCrudPrincipal();
            form.ShowDialog();
        }

        private void btnAdmin_MouseHover(object sender, EventArgs e)
        {
            btnAdmin.FlatStyle = FlatStyle.Flat;

            ComponentesForm.ConfigurarBorde(btnAdmin, Color.SeaGreen, 0, 0, 0, 4);
        }

        private void btnAdmin_MouseLeave(object sender, EventArgs e)
        {
            ComponentesForm.ConfigurarBorde(btnAdmin, Color.LightGreen, 0, 0, 0, 0);
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FormArmarTacos form = new FormArmarTacos();
            form.Show();
        }
    }
}
