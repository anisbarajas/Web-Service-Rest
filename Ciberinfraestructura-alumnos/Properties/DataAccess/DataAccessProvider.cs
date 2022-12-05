using Ciberinfraestructura_alumnos.Controllers;
using Ciberinfraestructura_alumnos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ciberinfraestructura_alumnos.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        public List<catalumnos> GetAlumnos()
        {
            return _context.catalumnos.ToList();
        }

        public List<catalumnos> GetAlumno(int id)
        {
            return _context.catalumnos.Where(i => i.id == id).ToList();
        }

        public List<catalumnos> SetAlumno(int id, string nombre)
        {
            _context.catalumnos.Add(new catalumnos() 
            {
                id = id, 
                nombre = nombre
            });
            _context.SaveChanges();
            return _context.catalumnos.ToList();
        }
    }
}
