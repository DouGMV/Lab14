﻿using System.ComponentModel.DataAnnotations;

namespace Lab14
{
    public class Cancion
    {
        [Required(ErrorMessage = "El Nombre del artista de la cancion es Requerido")]
        public string NombreCancion { get; set; }

        [Required(ErrorMessage = "El Artista de la cancion es Requerido")]
        public string ArtistaCancion { get; set; }
        [Required(ErrorMessage = "La duración de la cancion es Requerido")]
        public string Duracion { get; set; }

        public Cancion()
        {
            NombreCancion = string.Empty;
            ArtistaCancion = string.Empty;
            Duracion = string.Empty;
        }
    }
}
