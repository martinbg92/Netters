using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using capaDALC;

namespace capaLogica
{
    public class Usuario
    {
        public int idusuario { get; set; }
        public String nombre { get; set; }
        public String dni { get; set; }
        public String direccion { get; set; }
        public String pass { get; set; }
        public int saldo { get; set; }

        private NettersDBEntities conexion;

        public Usuario()
        {
            conexion = new NettersDBEntities();
            idusuario = 0;
            nombre = String.Empty;
            dni = String.Empty;
            direccion = String.Empty;
            pass = String.Empty;
            saldo = 0;
        }
        public bool AddUsuario(Usuario user)
        {
            try
            {
                USUARIO s = new USUARIO();
                s.Saldo = 0;
                s.Direccion = user.direccion;
                s.Dni = user.dni;
                s.Pass = user.pass;
                s.Apellidos = "un apellido";
                s.Nombre = user.nombre;
                

                conexion.USUARIO.Add(s);
                conexion.SaveChanges();
                Trace.WriteLine("Se ha guardado en base de datos");
                return true;

            }
            catch (Exception ex)
            {
                Trace.WriteLine("error: " + ex);
                return false;
            }
        }

        public bool Login(String user, String pass)
        {

            var userLogued = conexion.USUARIO
            .Where(b => b.Nombre == user &&
                        b.Pass == pass)
            .FirstOrDefault();


            if (userLogued!=null)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public int GetIdUserByName(String name)
        {
            var userName = conexion.USUARIO
            .Where(b => b.Nombre == name)
            .FirstOrDefault();


            if (userName != null)
            {
                return userName.idusuario;
            }
            else
            {
                return -1;
            }
        }
    }
}
