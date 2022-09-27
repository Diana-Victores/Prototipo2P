using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;
using FontAwesome.Sharp;
using HotelSanCarloss;

namespace HotelSanCarloss
{
    public partial class MantenimientoHabitacion : Form
    {
       // Capa_Controlador.csControlador cn = new Capa_Controlador.csControlador();
        csControlador cn = new csControlador();

        public MantenimientoHabitacion()
        {
            InitializeComponent();
        }
        public Form actual = new Form();
        public TextBox[] textbox = { };
        public TextBox[] textboxi = { };
        public DataGridView tabla;


        int opcion;
        public void cargar(DataGridView dtabla, TextBox[] text, string BD)
        {
            IconButton[] botongc = { iconButton4, iconButton2, iconButton5 };
            cn.evaluartabla(dtabla);
            cn.inicializargrid(dtabla);
            cn.llenartablainicio(dtabla.Tag.ToString(), dtabla, text);
            cn.evaluartags(text, dtabla, BD);
            cn.desactivar(actual);
            cn.bloqueobtn(botongc);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            {

                bool resultado = crud.InsertProducto(null, textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text);

                if (resultado)
                {
                    DataGridView.Rows.Add(new object[]{ null, textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text, "Modificar",
                    "Eliminar"});
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            actual.Close();
        }

        private void MantenimientoHabitacion_Load(object sender, EventArgs e)
        {

        }
    }

}

 
