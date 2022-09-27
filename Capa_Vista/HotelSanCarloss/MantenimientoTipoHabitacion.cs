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
    public partial class MantenimientoTipoHabitacion : Form
    {
        public MantenimientoTipoHabitacion()
        {
            InitializeComponent();
        }

        public Form actual = new Form();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
    
}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
          
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Capa_Controlador.clscontrolador crud = new Capa_Controlador.clscontrolador();
            bool resultado = crud.TipoHabitacion(null,
                                                 textBox1.Text,
                                                 textBox2.Text,
                                                 textBox3.Text);

            if (resultado)
            {
                dataGridView1.Rows.Add(new object[]{ null, textBox1.Text, textBox2.Text, textBox3.Text, "Modificar",
                    "Eliminar"});
            }
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            actual.Close();
        }
    }
}
