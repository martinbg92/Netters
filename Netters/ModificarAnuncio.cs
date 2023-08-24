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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Netters
{
    public partial class ModificarAnuncio : Form
    {
        private ComboBox comboBox1;
        private List<int> idAnuncios;
        private int index;
        public ModificarAnuncio()
        {
            InitializeComponent();

            Anuncio anun = new Anuncio();
            index = 1;
            idAnuncios = new List<int>();

            List<ANUNCIO> listAnuncios = anun.GetAnunciosByIdUser(new Usuario().GetIdUserByName(Global.GlobalUser));

            

            foreach (var anuncio in listAnuncios)
            {
                //MessageBox.Show(anuncio.idanuncio.ToString());
                idAnuncios.Add(int.Parse(anuncio.idanuncio.ToString()));
                

            }
                        
            comboBox1 = new ComboBox();
            Sector s = new Sector();
            List<SECTOR> sec = s.ReadAllSector();
            comboBox1.Location = new Point(312, 97);
            comboBox1.Size = new Size(176, 26);
            comboBox1.Name = "Choice Sector";
            comboBox1.DataSource = sec;
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idsector";
            this.Controls.Add(comboBox1);
            searchFollowAnuncio();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchFollowAnuncio();
        }

        private void searchFollowAnuncio()
        {
            ANUNCIO a = new Anuncio().searchAnuncioById(this.idAnuncios[index]);
            index += 1;
            textBox4.Text = a.Nombre.ToString();
            comboBox1.Text = a.idsector.ToString();
            textBox3.Text = a.Descripcion.ToString();
            textBox1.Text = a.NumHoras.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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
