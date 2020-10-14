using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Entidad_Datos;


namespace CapaNegociosProductos
{
    public class CapaNegociosProducto
    {
        Dictionary<int, DatosProducto> Registros = new Dictionary<int, DatosProducto>();

        public void AgregarProducto(string nombre_p, string codigo_p, string stock_p, string fecha_vencimiento_p, string descripcion_p, string categoria_p, bool estado_p)
        {
            DatosProducto ObjDatos = new DatosProducto();

            ObjDatos.id = Registros.Count + 1;
            ObjDatos.nombre = nombre_p;
            ObjDatos.codigo = codigo_p;
            ObjDatos.stock = stock_p;
            ObjDatos.fecha_Vencimiento = fecha_vencimiento_p;
            ObjDatos.descripcion = descripcion_p;
            ObjDatos.categoria = categoria_p;
            ObjDatos.estado = estado_p;

            Registros.Add(ObjDatos.id, ObjDatos);
        }

        public ArrayList BuscarProducto(int id)
        {
            ArrayList ObjDatos = new ArrayList();

            if (Registros.ContainsKey(id) == true)
            {
                ObjDatos.Add(Registros[id].id);
                ObjDatos.Add(Registros[id].nombre);
                ObjDatos.Add(Registros[id].codigo);
                ObjDatos.Add(Registros[id].stock);
                ObjDatos.Add(Registros[id].fecha_Vencimiento);
                ObjDatos.Add(Registros[id].categoria);
                ObjDatos.Add(Registros[id].categoria);
                ObjDatos.Add(Registros[id].estado);
            }

            return ObjDatos;
        }

        public void ModificarProducto(int id, string nombre_p, string codigo_p, string stock_p, string fecha_vencimiento_p, string descripcion_p, string categoria_p, bool estado_p)
        {
            if (Registros.ContainsKey(id) == true)
            {
                DatosProducto ObjDatos = new DatosProducto();
                ObjDatos.id = id;
                ObjDatos.nombre = nombre_p;
                ObjDatos.codigo = codigo_p;
                ObjDatos.stock = stock_p;
                ObjDatos.fecha_Vencimiento = fecha_vencimiento_p;
                ObjDatos.descripcion = descripcion_p;
                ObjDatos.categoria = categoria_p;
                ObjDatos.estado = estado_p;

                Registros[id] = ObjDatos;
            }
        }

        public void EliminarProducto(int id)
        {
            if (Registros.ContainsKey(id) == true)
            {
                Registros.Remove(id);
            }
        }
    }
}
