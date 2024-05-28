using System.Collections.Generic;

namespace EntityFramework2Example.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Nombre { get; set; }

        public List<Cancion> Cancions { get; set; }
    }
}
