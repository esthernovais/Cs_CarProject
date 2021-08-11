using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using CS_CarProject.Models;


namespace CS_CarProject.Controller
{
    public class CarrossController : ApiController
    {
        static readonly ICarroInterface carroRepositorio = new CarroRepositorio();
        public HttpResponseMessage GetAllCarros()
        {
            List<Carros> listaCarros = carroRepositorio.GetAll().ToList();
            return Request.CreateResponse<List<Carros>>(HttpStatusCode.OK, listaCarros);
        }
        public HttpResponseMessage GetCarros(string nome)
        {
            Carros carros = carroRepositorio.Get(nome);
            if (carros == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Carro não localizado para o Id informado");
            }
            else
            {
                return Request.CreateResponse<Carros>(HttpStatusCode.OK, carros);
            }
        }
        public IEnumerable<Carros> GetCarrosPorOrigem(int origem)
        {
            return carroRepositorio.GetAll().Where(
                e => string.Equals(e.Origem.ToString(), origem.ToString(), StringComparison.OrdinalIgnoreCase));
        }
        public HttpResponseMessage PostCarro(Carros carros)
        {
            bool result = CarroRepositorio.Add(carros);
            if (result)
            {
                var response = Request.CreateResponse<Carros>(HttpStatusCode.Created, carros);
                string uri = Url.Link("DefaultApi", new { id = carros.id });
                response.Headers.Location = new Uri(uri);
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Carro não foi incluído com sucesso");
            }
        }
        public HttpResponseMessage PutCarro(int id, Carros carros)
        {
            carros.id = id;
            if (!CarroRepositorio.Update(carros))
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
              "Não foi possível atualizar o Carro para o id informado");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }
        public HttpResponseMessage DeleteCarro(string nome)
        {
            carroRepositorio.Remove(nome);
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}
