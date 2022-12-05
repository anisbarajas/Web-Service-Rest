using Ciberinfraestructura_alumnos.Models;
using System.Collections.Generic;

namespace Ciberinfraestructura_alumnos.DataAccess
{
    public interface IDataAccessProvider
    {

        List<catalumnos> GetAlumnos();
        List<catalumnos> GetAlumno(int id);
        List<catalumnos> SetAlumno(int id, string nombre);
    }
}
