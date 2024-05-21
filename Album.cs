using System.ComponentModel.DataAnnotations;

namespace Lab14
{
    public class Album : Cancion
    {
        [Required(ErrorMessage = "El Titulo del album es Requerido")]
        public string TituloAlbum { get; set; }

        [Required(ErrorMessage = "El Artista del album es Requerido")]
        public string ArtistaAlbum { get; set; }
        public string Canciones { get; set; }
        public string FechaPublicacion { get; set; }

        public Album()
        {
            TituloAlbum = string.Empty;
            ArtistaAlbum = string.Empty;
            Canciones = string.Empty;
            FechaPublicacion = string.Empty;
        }
    }
}
