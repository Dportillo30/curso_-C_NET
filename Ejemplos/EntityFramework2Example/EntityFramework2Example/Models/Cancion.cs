using System;

namespace EntityFramework2Example.Models
{
    public class Cancion
    {
        public int CancionId { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public TimeSpan Duracion { get; set; }

        public Album Album { get; set; }
        public int AlbumId { get; set; }

        public Author Author { get; set; }
        public int AuthorId {get;set;}
    }
}
