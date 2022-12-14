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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void mantenimientoHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoHabitacion form = new MantenimientoHabitacion();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoTipoHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoHabitacion form = new MantenimientoHabitacion();
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoTipoCamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManteniminetoTipoCama form = new ManteniminetoTipoCama();
            form.MdiParent = this;
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
