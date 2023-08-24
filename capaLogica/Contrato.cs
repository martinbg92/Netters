using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLogica
{
    public class Contrato
    {
        public int idcontrato { get; set; }
        public Anuncio idanuncio { get; set; }
        public Usuario idusuario { get; set; }
        public int finalizado { get; set; }

        public Contrato()
        {
            idcontrato = 0;
            idanuncio = new Anuncio();
            idusuario = new Usuario();
            finalizado = 0;

        }
    }
}
