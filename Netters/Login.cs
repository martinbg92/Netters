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
    public partial class Login : Form
    {
        String user;
        String password;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Alta alta = new Alta(this);
            alta.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (new Usuario().Login(this.user, this.password))
            {
                Global.GlobalUser = this.user;
                MainScreen ms = new MainScreen();
                ms.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error en el login");
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.user = textBox1.Text;

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            this.password = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            //Salir
        }
    }
}
