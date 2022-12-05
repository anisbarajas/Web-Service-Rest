using Ciberinfraestructura_alumnos.DataAccess;
using Ciberinfraestructura_alumnos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Ciberinfraestructura_alumnos.Controllers
{
    [Route("api/[controller]")]
    public class catalumnosController : ControllerBase
    {
        private readonly IDataAccessProvider dataAccessProvider;    

        public catalumnosController(IDataAccessProvider dataAccessProvider)
        {
            this.dataAccessProvider = dataAccessProvider;
        }
        
        [HttpGet]
        public IEnumerable<catalumnos> Get()
        {
            return dataAccessProvider.GetAlumnos();
        }

        [HttpGet("{id:int}")]
        public IEnumerable<catalumnos> Get(int id)
        {
            return dataAccessProvider.GetAlumno(id);
        }

        [HttpPost]
        public IEnumerable<catalumnos> Set(int id, string nombre)
        {
            return dataAccessProvider.SetAlumno(id, nombre);
        }

    }
}