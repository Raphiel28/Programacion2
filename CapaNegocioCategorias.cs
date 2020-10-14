using System;

public class CapaNegocioCategorias
{
    int id;
    string nombre;
	public Class1()
	{
         Dictionary<int, Categorias> Registros = new Dictionary<int, Categorias>();

        public void AgregarRegistro(string nombre_c)
        {
            Categorias reg = new Categorias();
            reg.setId(Registros.Count+1);
            reg.setNombre(nombre_c);
            reg.setEstado(true);

            Registros.Add(reg.getId(), reg);
        }

        public ArrayList BuscarRegistro(int id_c)
        {
            ArrayList reg = new ArrayList();

            if (Registros.ContainsKey(id_c) == true)
            {
                reg.Add(Registros[id_c].getId());
                reg.Add(Registros[id_c].getNombre());
                reg.Add(Registros[id_c].getEstado());
            }

            return reg;
        }

        public void ModificarRegistro(int id_c, string nombre_c, bool estado_c)
        {
            if (Registros.ContainsKey(id_c) == true)
            {
                Categorias reg = new Categorias();
                reg.setId(id_c);
                reg.setNombre(nombre_c);
                reg.setEstado(estado_c);

                Registros[id_c] = reg;
            }
        }

        public void EliminarRegistro(int id_c)
        {
            if (Registros.ContainsKey(id_c) == true)
            {
                Registros.Remove(id_c);
            }
        }
    }
	
}
