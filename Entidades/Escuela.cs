namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre
        {
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public Curso[] Cursos { get; set; }

        // public Escuela(string nombre, int año, TiposEscuela tipo, string Pais, string Ciudad)
        // {
        //      this.nombre = nombre;
        //      AñoDeCreacion = año;
        //      TiposEscuela = tipo;
        //      this.Pais = Pais;
        //      this.Ciudad = Ciudad;
        // }
        //EL CODIGO DE ARRIBA Y ABAJO SON SIMILARES PERO NO IGUALES, ES DECIR QUE TIENEN LA MISMA
        //LOGICA Y PROPOSITO
        public Escuela(string nombre, int año, TiposEscuela tipo, string pais, string ciudad) => (Nombre, AñoDeCreacion, TipoEscuela, Pais, Ciudad) = (nombre, año, tipo, pais, ciudad);

        public override string ToString() => ($"Name: {nombre}, Type: {TipoEscuela}, \nCountry: {Pais}, City: {Ciudad}");
    }
}