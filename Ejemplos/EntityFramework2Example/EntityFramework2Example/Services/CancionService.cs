using EntityFramework2Example.Contexto;
using EntityFramework2Example.Models;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework2Example.Services
{
    public class CancionService : ICancionService
    {
        private readonly IContextoDB _contextoDB;

        public CancionService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public void AddCancion(Cancion cancion)
        {
            _contextoDB.Canciones.Add(cancion);

             _contextoDB.SaveChanges();
        }

        public void DeleteCancion(Cancion cancion)
        {
            _contextoDB.Canciones.Remove(cancion);
            _contextoDB.SaveChanges();
        }

        public void DeleteCancion(int CancionId)
        {
            var cancion = GetCancion(CancionId);
            DeleteCancion(cancion);
        }

        public List<Cancion> GetCancions()
        {
            return _contextoDB.Canciones.Select(x => x).ToList();
        }

        public Cancion GetCancion(int CancionId)
        {
            return _contextoDB.Canciones.Where(x => x.CancionId == CancionId).FirstOrDefault();
        }

        public Cancion updateCancion(Cancion cancion)
        {
            var cancionUpdated = _contextoDB.Canciones.Update(cancion).Entity;

            _contextoDB.SaveChanges();

            return cancionUpdated;
        }
    }
}
