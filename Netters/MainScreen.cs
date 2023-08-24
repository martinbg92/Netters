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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PublicarAnuncio pa = new PublicarAnuncio();
            pa.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuscarAnuncio pa = new BuscarAnuncio();
            pa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarAnuncio pa = new ModificarAnuncio();
            pa.Show();
            this.Hide();
        }
    }
}
