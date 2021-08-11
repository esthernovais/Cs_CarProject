using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_CarProject.Models
{
    public interface ICarroInterface
    {
        IEnumerable<Carros> GetAll();
        Carros Get(string nome);
        bool Add(Carros carro);
        void Remove(string nome);
        bool Update(Carros carro);
    }
}
