using capaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Netters
{
    public partial class Alta : Form
    {
        private String name;
        private String password;
        private String dni;
        private String email;
        private String address;
        private String postalCode;
        private float saldo;


        Login m_login;
        public Alta(Login login)
        {
            InitializeComponent();
            m_login = login;
        }
        private void Alta_Load(object sender, EventArgs e)
        {

        }
        private void Alta_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Volver
        {
            m_login.Show();
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.name = textBox1.Text;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            this.password = textBox2.Text;
        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            this.dni = textBox3.Text;
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            this.email = textBox6.Text;
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            this.address = textBox5.Text;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            this.postalCode = textBox4.Text;
        }
        private void button1_Click(object sender, EventArgs e) // registrarse btn
        {
            Usuario user = new Usuario();
            user.nombre = this.name;
            user.dni = this.dni;
            user.direccion = this.address;
            user.pass = this.password;
            


            if (user.AddUsuario(user) == true)
            {
                MessageBox.Show("Por fin añadimos");
            }
            else
            {
                MessageBox.Show("Me cago en la ostia!!");
            }
            this.saldo = 0;
            Trace.WriteLine("name: " + this.name + "... password: " + this.password + this.postalCode + this.email + this.dni + this.address);
        }
    }
}
