using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using capaDALC;

namespace capaLogica
{
    public class Sector
    {
        public int idsector { get; set; }
        public string nombre { get; set; }
        private NettersDBEntities conexion;

        public Sector()
        {
            //idsector = 0;
            nombre = "holaMundo";
            conexion = new NettersDBEntities();

            
        }
        public bool addSector() {
            try{
                SECTOR s = new SECTOR();
                s.Nombre = this.nombre;
            
                
                conexion.SECTOR.Add(s);
                conexion.SaveChanges();
                return true;
            }
            catch (Exception ex) {
                Trace.WriteLine("error: " + ex);
                return false;
            }
        }

        public bool delSector() {
            try
            {
                conexion.SECTOR.Remove(conexion.SECTOR.Find(this.idsector));
                conexion.SaveChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public List<SECTOR> ReadAllSector()
        {


            IList<SECTOR> s = new List<SECTOR>();
            s = conexion.SECTOR.SqlQuery("select * from SECTOR").ToList();
            return (List<SECTOR>)s;

        }
        
    }
}
