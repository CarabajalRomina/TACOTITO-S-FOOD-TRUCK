using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tacotitos.src
{
    internal static class ComponentesForm
    {
        public static void CargarComboBox<T>(List<T> list, ComboBox cb)
        {
            foreach (var item in list)
            {
                cb.Items.Add(item);
            }
        }

        public static void ConfigurarBorde(Control cnt, Color colorBorde, int left, int top, int right, int buttom)
        {
            cnt.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, cnt.ClientRectangle,
                    colorBorde, left, ButtonBorderStyle.Solid,
                    colorBorde, top, ButtonBorderStyle.Solid,
                    colorBorde, right, ButtonBorderStyle.Solid,
                    colorBorde, buttom, ButtonBorderStyle.Solid);
            };
        }

        public static void DesabilitarOHabilitarControles(IEnumerable<Control> cnts)
        {
            if (cnts != null)
            {
                foreach (var cnt in cnts)
                {
                    cnt.Enabled = !cnt.Enabled;
                }
            }
        }

        public static void DesactivarOActivarControlesDelPanelForm(IEnumerable<Control> cnts, Control cnt)
        {
            DesabilitarOHabilitarControles(cnts);
            DesabilitarOHabilitarControl(cnt);
        }

        public static void DesabilitarOHabilitarControl(Control cnt)
        {
            cnt.Enabled = !cnt.Enabled;
        }

        public static void CargarDataGridView<T>(DataGridView Dgv, List<T> list)
        {
            foreach(var item in list)
            {
                Dgv.Rows.Add(item);
            }
        }

        public static void CambiarEstadoVisibleDeUnControl(Control cnt)
        {
            cnt.Visible = !cnt.Visible;
        }

    }
}
