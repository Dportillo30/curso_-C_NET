using EntityFramework2Example.Contexto;
using EntityFramework2Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEFCore.Services
{
    public class AlbumService : IAlbumService
    {

        private readonly IContextoDB _contextoDB;

        public AlbumService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }


        public void AddAlbum(Album album)
        {

            _contextoDB.Albums.Add(album);

            _contextoDB.SaveChanges();

        }

        public void DeleteAlbum(int albumId)
        {
            var cancion = GetAlbum(albumId);
            DeleteAlbum(cancion);
        }

        public void DeleteAlbum(Album album)
        {
            _contextoDB.Albums.Remove(album);
            _contextoDB.SaveChanges();
        }

        public List<Album> GetAlbumnes()
        {
            return _contextoDB.Albums.Select(x => x).ToList();

        }

        public Album GetAlbum(int albumId)
        {
            return _contextoDB.Albums.Where(x => x.AlbumId == albumId).FirstOrDefault();
        }

        public Album UpdateAlbum(Album album)
        {
            //var cancionaux = GetCancion(cancion.CancionId);

            var AlbumUpdated =  _contextoDB.Albums.Update(album).Entity;
            _contextoDB.SaveChanges();

            return AlbumUpdated;
        }



    }
}
