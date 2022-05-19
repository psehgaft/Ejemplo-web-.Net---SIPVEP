using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using SIPVEP.CapaDatos.EF;
using SIPVEP.Entidades;

namespace SIPVEP.CapaLogica
{
    public class ArticuloLogica
    {
        private readonly ArticuloEF _contexto;

        public ArticuloLogica()
        {
            _contexto = new ArticuloEF();
        }

        public Articulo Insertar(Articulo entidad)
        {
            if(entidad.sku == string.Empty || entidad.sku.Length == 0)
                throw new Exception("Código de barras no es opcional");
            if(_contexto.BuscarPrimero(x => x.sku == entidad.sku) != null)
                throw new Exception("Código de barras previamente registrado con el nombre: "+ entidad.nombre);
            if(entidad.nombre.Length < 5 || entidad.nombre.Length > 50)
                throw new Exception("El nombre debe estar formado entre 5 y 50 caracteres");
            if (entidad.descripcion.Length > 200)
                throw new Exception("La descripción es de máxomo 200 caracteres");
            if(entidad.precio_compra <= 0)
                throw new Exception("El precio de compra debe ser mayor a 0");
            if(entidad.precio_venta < entidad.precio_compra *  1.05)
                throw new Exception("El precio de venta debe ser por lo mens 5% superior que el precio de compra");
            if (entidad.stock <= 0)
                throw new Exception("La cantidad debe ser mayor a 0");

            return _contexto.Agregar(entidad);
        }

        public Articulo Modificar(Articulo entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("ID no es opcional");
            if (entidad.sku == string.Empty || entidad.sku.Length == 0)
                throw new Exception("Código de barras no es opcional");
            var a = _contexto.BuscarPrimero(x => x.Id == entidad.Id);
            if (a == null)
                throw new Exception("ID no existe");
            if (entidad.nombre.Length < 5 || entidad.nombre.Length > 50)
                throw new Exception("El nombre debe estar formado entre 5 y 50 caracteres");
            if (entidad.descripcion.Length > 200)
                throw new Exception("La descripción es de máxomo 200 caracteres");
            if (entidad.precio_compra <= 0)
                throw new Exception("El precio de compra debe ser mayor a 0");
            if (entidad.precio_venta < entidad.precio_compra * 1.05)
                throw new Exception("El precio de venta debe ser por lo mens 5% superior que el precio de compra");
            if (entidad.stock != a.stock)
                throw new Exception("La cantidad no puede ser modificada");
            return _contexto.Modificar(entidad);
        }

        public Articulo Merma(int Id, int merma)
        {
            if (Id == 0)
                throw new Exception("ID no es opcional");
            var a = _contexto.BuscarPrimero(x => x.Id == Id);
            if (a == null)
                throw new Exception("ID no existe");
            if(a.stock <= 0)
                throw new Exception("El articulo debe tener existencias superiores a 0");
            if(merma > a.stock)
                throw new Exception("La cantidad de merma no debe dejar las existencias del producto menores a 0");
            a.stock -= merma;
            return _contexto.Modificar(a);
        }

        public Articulo AumentaExistencias(int Id, int aumento)
        {
            if (Id == 0)
                throw new Exception("ID no es opcional");
            var a = _contexto.BuscarPrimero(x => x.Id == Id);
            if (a == null)
                throw new Exception("ID no existe");
            if (a.stock < 0)
                throw new Exception("El articulo debe tener existencias superiores a 0");
            if (aumento <= 0)
                throw new Exception("La cantidad de aumento debe ser superior a 0");
            a.stock += aumento;
            return _contexto.Modificar(a);
        }
        public int Eliminar(Articulo entidad)
        {
            return _contexto.Eliminar(entidad);
        }

        public IEnumerable<Articulo> Lista()
        {
            return _contexto.Listar();
        }

        public Articulo BuscarArticulo(int id)
        {
            return _contexto.BuscarPrimero(x => x.Id == id);
        }
    }
}
