using EntityFramework2Example.Models;
using System.Collections.Generic;

namespace EntityFramework2Example.Services
{
    public interface ICancionService
    {
        void AddCancion(Cancion cancion);

        void DeleteCancion(Cancion cancion);

        void DeleteCancion(int CancionId);

        List<Cancion> GetCancions();

        Cancion GetCancion(int CancionId);

        Cancion updateCancion(Cancion cancion);
    }
}
