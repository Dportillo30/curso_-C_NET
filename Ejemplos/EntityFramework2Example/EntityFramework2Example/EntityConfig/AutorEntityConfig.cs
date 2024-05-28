
using EntityFramework2Example.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEFCore.EntityConfig
{
    public class AutorEntityConfig
    {

        public static void SetAutorEntityConfig(EntityTypeBuilder<Author> entityBuilder)
        {
            entityBuilder.HasKey(x => x.AuthorId);
            entityBuilder.Property(x => x.Nombre).IsRequired();
           
        }


    }
}
