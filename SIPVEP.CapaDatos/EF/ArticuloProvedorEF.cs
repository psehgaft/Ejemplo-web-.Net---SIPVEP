using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIPVEP.Entidades;

namespace SIPVEP.CapaDatos.EF
{
    public class ArticuloProvedorEF : Base<Articulo_Provedor>
    {
        public ArticuloProvedorEF()
        {
            Contexto = new ModelContainer();
            Contexto.Configuration.ProxyCreationEnabled = false;
        }
    }
}
