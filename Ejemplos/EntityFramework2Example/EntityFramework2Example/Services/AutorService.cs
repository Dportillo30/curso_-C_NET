using EntityFramework2Example.Contexto;
using EntityFramework2Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEFCore.Services
{
    public class AutorService : IAutorService
    {

        private readonly IContextoDB _contextoDB;

        public AutorService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public void AddAutor(Author cancion)
        {
            _contextoDB.Authors.Add(cancion);

            _contextoDB.SaveChanges();

        }

        public void DeleteAutor(int CancionId)
        {
            var cancion = GetAutor(CancionId);
            DeleteAutor(cancion);
        }

        public void DeleteAutor(Author cancion)
        {
            _contextoDB.Authors.Remove(cancion);
            _contextoDB.SaveChanges();
        }

        public List<Author> GetAutores()
        {
            return _contextoDB.Authors.Select(x => x).ToList();

        }

        public Author GetAutor(int autorId)
        {
            return _contextoDB.Authors.Where(x => x.AuthorId == autorId).FirstOrDefault();
        }

        public Author UpdateAutor(Author autor)
        {
            //var cancionaux = GetCancion(cancion.CancionId);

            var cancionUpdated =  _contextoDB.Authors.Update(autor).Entity;
            _contextoDB.SaveChanges();

            return cancionUpdated;
        }



    }
}
