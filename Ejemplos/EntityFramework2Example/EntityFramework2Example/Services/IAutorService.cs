
using EntityFramework2Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEFCore.Services
{
    public interface IAutorService
    {
        void AddAutor(Author cancion);
        void DeleteAutor(int CancionId);
        void DeleteAutor(Author cancion);
        List<Author> GetAutores();
        Author GetAutor(int cancionId);
        Author UpdateAutor(Author cancion);
    }
}
