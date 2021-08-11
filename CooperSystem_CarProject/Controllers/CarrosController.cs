using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using CS_CarProject.Models;


namespace CS_CarProject.Controllers
{
    public class CarrosController : ApiController
    {
        public IEnumerable<Carros> Get(string nome)
        {
            if (nome == "" || nome == null)
                return null;
                throw new ArgumentException(
                    "O nome informado é inválido.");
        }
    }
}
