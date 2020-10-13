public class DatosCategorias
    {
        //Atributos
        int Id;
        string Nombre;
        bool Estado;

        //Constructor vacio
        public DatosCategorias() {; }

        public DatosCategorias(int id_c, string nombre_c, bool estado_c)
        {
            Id = id_c;
            Nombre = nombre_c;
            Estado = estado_c;
        }

        //Setters
        public void setId(int id_c) { Id = id_c; }
        public void setNombre(string nombre_c) { Nombre = nombre_c; }
        public void setEstado(bool estado_c) { Estado = estado_c; }

        //Getters
        public int getId() { return Id; }
        public string getNombre() { return Nombre; }
        public bool getEstado() { return Estado; }
    }
