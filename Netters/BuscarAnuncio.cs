using capaDALC;
using capaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netters
{
    public partial class BuscarAnuncio : Form
    {
        int id = 1;
        
        public BuscarAnuncio()
        {
            InitializeComponent();
            searchFollowAnuncio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // >>

            searchFollowAnuncio();

            

        }
        
        private void searchFollowAnuncio()
        {
            ANUNCIO a = new Anuncio().searchAnuncioById(id);
            id += 1;
            textBox4.Text = a.Nombre.ToString();
            textBox2.Text = a.idsector.ToString();
            textBox3.Text = a.Descripcion.ToString();
            textBox1.Text = a.NumHoras.ToString();
        }

        private void BuscarAnuncio_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
