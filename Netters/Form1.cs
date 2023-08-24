using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaLogica;
using capaDALC;

namespace Netters
{
    public partial class Form1 : Form
    {
        Sector s = new Sector();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //AGREGAR

            s.nombre = "Test";

            if(s.addSector()==true){
                MessageBox.Show("Por fin añadimos");
            }
            else {
                MessageBox.Show("Me cago en la ostia!!");
            }


            //ELIMINAR
            //try
            //{
            //    s.idsector = 5;
            //    if (s.delSector()==true)
            //    {
            //        MessageBox.Show("Eliminado!!");
            //
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("No se pudo eliminar!");
            //}
            //ACTUALIZAR
        }
    }
}
