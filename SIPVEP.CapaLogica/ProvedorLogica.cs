using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SIPVEP.CapaDatos.EF;
using SIPVEP.Entidades;

namespace SIPVEP.CapaLogica
{
   public  class ProvedorLogica
   {
       private readonly ProvedorEF _contexto;

       public ProvedorLogica()
       {
           _contexto = new ProvedorEF();
       }

       public Provedor Insertar(Provedor entidad)
       {
           if(entidad.rfc.Length < 12 || entidad.rfc.Length > 13)
               throw new Exception("El RFC debe estar formado de 12 o 13 caracteres");
           if(entidad.razon_social.Length < 10 || entidad.razon_social.Length > 100)
               throw new Exception("La Razón Social debe contener entre 10 y 50 caracteres");
           if(entidad.direccion_fiscal.Length < 10 || entidad.direccion_fiscal.Length > 100)
               throw new Exception("La Dirección Fiscal debe contener entre 10 y 100 caracteres");
           if(entidad.cp_fiscal.Length != 5)
               throw new Exception("El CP debe contener 5 dígitos");
           if(entidad.ciudad_fiscal.Length == 0 || entidad.ciudad_fiscal.Length>30)
               throw new Exception("La ciudad tiene máximo 30 caracteres");
           if(entidad.estado_fiscal.Length == 0 || entidad.estado_fiscal.Length > 30)
               throw new Exception("El estado tiene máximo 30 caracteres");
           if(entidad.nombre_alias.Length == 0 || entidad.nombre_alias.Length>10)
               throw new Exception("El Alias tiene máximo 10 caracteres");
           if(!Regex.IsMatch(entidad.correo_fiscal, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
               throw new Exception("El correo fiscal debe contener una estructura de correo bien formada");
           if(entidad.telefono.Length != 10)
               throw new Exception("Teléfono debe contener 10 dígitos");
           if (entidad.correo_contacto.Length > 0 && !Regex.IsMatch(entidad.correo_contacto, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
               throw new Exception("El correo de contacto debe contener una estructura de correo bien formada");

            return _contexto.Agregar(entidad);
       }
   }
}
