using capaDALC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLogica
{
    public class Anuncio
    {
        public int idanuncio { get; set; }
        public String nombre { get; set; }
        public int idsector { get; set; }
        public String descripcion { get; set; }
        public int numhoras { get; set; }
        public int idusuario { get; set; }

        private NettersDBEntities conexion;

        public Anuncio()
        {
            conexion = new NettersDBEntities();
            idanuncio = 0;
            nombre = String.Empty;
            idsector = 0;
            descripcion = String.Empty;
            numhoras = 0;
            idusuario = 0;
        }
        public bool AddAnuncio(Anuncio anuncio)
        {
            try
            {
                ANUNCIO a = new ANUNCIO();
                a.Nombre = anuncio.nombre;
                a.idsector = anuncio.idsector;
                a.Descripcion = anuncio.descripcion;
                a.NumHoras = anuncio.numhoras;
                a.idusuario = anuncio.idusuario;


                conexion.ANUNCIO.Add(a);
                conexion.SaveChanges();
                //Trace.WriteLine("Se ha guardado ANUNCIO en base de datos");

                return true;

            }
            catch (Exception ex)
            {
                Trace.WriteLine("error: " + ex);
                return false;
            }
        }

        public ANUNCIO searchAnuncioById(int id)
        {
            ANUNCIO anuncio = conexion.ANUNCIO
            .Where(b => b.idanuncio == id )
            .FirstOrDefault();

            return anuncio;
        }
        public List<ANUNCIO> GetAnunciosByIdUser(int idUser)
        {
            //List<ANUNCIO> anuncio = conexion.ANUNCIO
            //.Where(b => b.idusuario == idUser)
            //.All<ANUNCIO>;



            List<ANUNCIO> s = new List<ANUNCIO>();
            s = conexion.ANUNCIO.SqlQuery("select * from ANUNCIO WHERE idusuario = " + idUser.ToString()).ToList();
            return s;

        }
    }
}
