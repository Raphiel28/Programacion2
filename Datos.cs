using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad_Datos
{
    class Datos
    {
      public  int id { get; set; }
       public  string nombre { get; set; }
       public string codigo { get; set; }
        public string stock { get; set; }
        public string fecha_Vencimiento { get; set; }
        public string descripcion { get; set; }
        public string categoria { get; set; }
        public string estado { get; set; }


        public Datos()
        {
            id = 0;
            nombre = "";
            codigo = "";
            stock = "";
            fecha_Vencimiento = "";
            descripcion = "";
            categoria = "";
            estado = "";
        }
        public Datos(int pid, string pnombre, string pcodigo, string pstock, string pfecha_vencimiento, string pdescripcion, string pcategoria, string pestado)
        {
            id = pid;
            nombre = pnombre;
            codigo = pcodigo;
            stock = pstock;
            fecha_Vencimiento = pfecha_vencimiento;
            descripcion = pdescripcion;
            categoria = pcategoria;
            estado = pestado;
        }


    }
}
