namespace Laboratorio14Biblioteca
{
    public class clsAlbunmes : clsCanciones
    {
        public string Titulo { get; set; }
        public string listadoCanciones { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public clsAlbunmes()
        {
            Titulo = string.Empty;
            listadoCanciones = string.Empty;
            FechaPublicacion = DateTime.Now;
        }
    }
}
