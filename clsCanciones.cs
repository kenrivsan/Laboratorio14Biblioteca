namespace Laboratorio14Biblioteca
{
    public class clsCanciones
    {
        public string Nombre {get; set;}
        public string Artista { get; set;}
        public decimal Duracion { get; set;}

        public clsCanciones()
        {
            Nombre = string.Empty;
            Artista = string.Empty;
            Duracion = 0;
        }

    }
}
