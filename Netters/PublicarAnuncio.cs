using capaDALC;
using capaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Netters
{
    public partial class PublicarAnuncio : Form
    {
        private String nombre;
        private String descripcion;
        private int numHoras;
        private int idUsuario;
        private int idSector;
        ComboBox comboBox1;



        public PublicarAnuncio()
        {
            comboBox1 = new ComboBox();
            Sector s = new Sector();
            List<SECTOR> sec = s.ReadAllSector();
            comboBox1.Location = new Point(597, 217);
            comboBox1.Size = new Size(356, 26);
            comboBox1.Name = "Choice Sector";
            comboBox1.DataSource = sec;
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idsector";
            //this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //MessageBox.Show(sec.ToString());
            //foreach (var a in sec)
            //{
            //    comboBox1.Items.Add(a.Nombre);
            //}
            
            //comboBox1.DataSource = sec;
            //comboBox1.DisplayMember = nombre; // Column Name
            //comboBox1.ValueMember =   // Column Name


            // Adding this ComboBox to the form
            this.Controls.Add(comboBox1);
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PublicarAnuncio_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //publicar
        {
            Anuncio anuncio = new Anuncio();
            anuncio.descripcion = this.descripcion;
            anuncio.nombre = this.nombre;
            anuncio.numhoras = this.numHoras;
            anuncio.idusuario = new Usuario().GetIdUserByName(Global.GlobalUser);
            anuncio.idsector = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            //MessageBox.Show (comboBox1.SelectedValue.ToString());

            //Trace.WriteLine(this.descripcion + this.nombre + this.numHoras + anuncio.idsector);

            if (anuncio.AddAnuncio(anuncio)==true)
            {
                MessageBox.Show("SE ha guardado el anuncio");
            }
            else
            {
                MessageBox.Show("No se guardó el ANUNCIO");
            }




        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            this.nombre = textBox4.Text;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            this.descripcion = textBox4.Text;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.numHoras = Convert.ToInt32(this.textBox1.Text);
            //Como se extrae el valor en NUM
            //this.numHoras = int.Parse(textBox4.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sector s = new Sector();
            IList<SECTOR> sec = s.ReadAllSector();
            Trace.WriteLine(sec.ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
