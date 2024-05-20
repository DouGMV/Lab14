using Lab14;

public class Biblioteca
{
    private List<Album> albums;

    public Biblioteca()
    {
        albums = new List<Album>();
    }

    public void IngresarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void EditarAlbum(string tituloAlbum, Album nuevoAlbum)
    {
        var albumExistente = albums.Find(album => album.NombreCancion == tituloAlbum);
        if (albumExistente != null)
        {
            albumExistente.TituloAlbum = nuevoAlbum.TituloAlbum;
            albumExistente.ArtistaAlbum = nuevoAlbum.ArtistaAlbum;
            albumExistente.Canciones = nuevoAlbum.Canciones;
            albumExistente.FechaPublicacion = nuevoAlbum.FechaPublicacion;
        }
        else
        {
            Console.WriteLine("El álbum no existe en la biblioteca.");
        }
    }

    public List<Album> ObtenerAlbums()
    {
        return albums;
    }

    public List<Album> ObtenerAlbumsPorArtista(string nombreArtista)
    {
        return albums.FindAll(album => album.ArtistaAlbum == nombreArtista);
    }

    public Album ObtenerAlbumPorTitulo(string tituloAlbum)
    {
        return albums.FirstOrDefault(album => album.TituloAlbum == tituloAlbum) ?? new Album();
    }
}
