using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSanCarloss
{
    public partial class MDI_Conetnedor : Form
    {
        public MDI_Conetnedor()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manteniminetoHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoHabitacion form = new MantenimientoHabitacion();
            form.MdiParent = this;
            form.Show();
        }

        private void manteniminetoTipoHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoTipoHabitacion form = new MantenimientoTipoHabitacion();
            form.MdiParent = this;
            form.Show();
        }

        private void manteniminetoTipoCamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManteniminetoTipoCama form = new ManteniminetoTipoCama();
            form.MdiParent = this;
            form.Show();
        }
    }
}
