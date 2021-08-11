using System;
using System.Collections.Generic;

namespace CS_CarProject.Models
{
    public class CarroRepositorio: ICarroInterface
    {
        private List<Carros> carros = new List<Carros>();
        private int _nextId = 1;

        public CarroRepositorio()
        {
            Add(new Carros
            {
                id = 1,
                Nome = "Volkswagen Saveiro",
                Km = 18,
                Cilindros = 8,
                Cavalor = 130,
                Peso = 3450,
                Aceleracao = 12,
                Ano = "1978-01-02",
                Origem = "USA"
            });  
            Add(new Carros
            {   
                id = 2,
                Nome = "Volkswagen Gol",
                Km = 19,
                Cilindros = 7,
                Cavalor = 139,
                Peso = 3458,
                Aceleracao = 9,
                Ano = "1994-05-01",
                Origem = "USA"
            });
            Add(new Carros
            {
                id = 3,
                Nome = "Fiat Uno",
                Km = 15,
                Cilindros = 5,
                Cavalor = 139,
                Peso = 2900,
                Aceleracao = 12,
                Ano = "1984-01-02",
                Origem = "BR"
            });
            Add(new Carros 
            {   
                id = 4,
                Nome = "Ford Ranger",
                Km = 24,
                Cilindros = 8,
                Cavalor = 130,
                Peso = 2910,
                Aceleracao = 12,
                Ano = "1995-01-02",
                Origem = "CN"
            });
            Add(new Carros 
            {   
                id = 5,
                Nome = "Toyota Corolla",
                Km = 19,
                Cilindros = 10,
                Cavalor = 120,
                Peso = 2983,
                Aceleracao = 12,
                Ano = "1978-04-02",
                Origem = "JP"
            });
            Add(new Carros
            {
                id = 6,
                Nome = "Volkswagen Saveiro",
                Km = 18,
                Cilindros = 8,
                Cavalor = 130,
                Peso = 3450,
                Aceleracao = 12,
                Ano = "1978-01-02",
                Origem = "USA"
            });
            Add(new Carros
            {   
                id = 7,
                Nome = "Honda Civic",
                Km = 20,
                Cilindros = 13,
                Cavalor = 13,
                Peso = 3504,
                Aceleracao = 12,
                Ano = "1994-01-02",
                Origem = "USA"
            });

        }

   

        public IEnumerable<Carros> GetAll()
        {
            return carros;
        }
        public Carros Get(int id)
        {
            return carros.Find(s => s.id == id);
        }
        public bool Add(Carros carros)
        {
            bool addResult = false;
            if (carros == null)
            {
                return addResult;
            }

            int index = carros.FindIndex(s => carros.id == carros.id);
            if (index == -1)
            {
                carros.Add(carros);
                addResult = true;
                return addResult;
            }
            else
            {
                return addResult;
            }
        }
        public void Remove(int id)
        {
            carros.RemoveAll(s => s.id == id);
        }
        public bool Update(Carros carros)
        {
            if (carros == null)
            {
                throw new ArgumentNullException("carros");
            }
            int index = carros.FindIndex(s => carros.id == carros.id);
            if (index == -1)
            {
                return false;
            }
            carros.RemoveAt(index);
            carros.Add(carros);
            return true;
        }

        public Carros Get(string nome)
        {
            throw new NotImplementedException();
        }

        public void Remove(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
