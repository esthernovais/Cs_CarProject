using System;
using System.Collections.Generic;

namespace CS_CarProject.Models
{
    public static class SistemaCarros
    {
        public static List<Carros> ObterCarros()
        {
            List<Carros> dados =
                new List<Carros>();

            dados.Add(new Carros()
            {
                Nome = "Volkswagen Saveiro",
                Km = 18,
                Cilindros = 8,
                Cavalor = 130,
                Peso = 3450,
                Aceleracao = 12,
                Ano = "1978-01-02",
                Origem = "USA"
            });

            dados.Add(new Carros()
            {
                Nome = "Volkswagen Gol",
                Km = 19,
                Cilindros = 7,
                Cavalor = 139,
                Peso = 3458,
                Aceleracao = 9,
                Ano = "1994-05-01",
                Origem = "USA"
            });

            dados.Add(new Carros()
            {
                Nome = "Fiat Uno",
                Km = 15,
                Cilindros = 5,
                Cavalor = 139,
                Peso = 2900,
                Aceleracao = 12,
                Ano = "1984-01-02",
                Origem = "BR"
            });

            dados.Add(new Carros()
            {
                Nome = "Ford Ranger",
                Km = 24,
                Cilindros = 8,
                Cavalor = 130,
                Peso = 2910,
                Aceleracao = 12,
                Ano = "1995-01-02",
                Origem = "CN"
            });

            dados.Add(new Carros()
            {
                Nome = "Toyota Corolla",
                Km = 19,
                Cilindros = 10,
                Cavalor = 120,
                Peso = 2983,
                Aceleracao = 12,
                Ano = "1978-04-02",
                Origem = "JP"
            });

            dados.Add(new Carros()
            {
                Nome = "Volkswagen Saveiro",
                Km = 18,
                Cilindros = 8,
                Cavalor = 130,
                Peso = 3450,
                Aceleracao = 12,
                Ano = "1978-01-02",
                Origem = "USA"
            });

            dados.Add(new Carros()
            {
                Nome = "Honda Civic",
                Km = 20,
                Cilindros = 13,
                Cavalor = 13,
                Peso = 3504,
                Aceleracao = 12,
                Ano = "1994-01-02",
                Origem = "USA"
            });


            return dados;
        }

        public static List<Marca> ObterMarca()
        {
            List<Marca> dados =
                new List<Marca>();

            dados.Add(new Marca()
            {
                Nome = "Volkswagen",
                Origem = "USA"
            });

            dados.Add(new Marca()
            {
                Nome = "Fiat",
                Origem = "BR"
            });

            dados.Add(new Marca()
            {
                Nome = "Ford",
                Origem = "CN"
            });

            dados.Add(new Marca()
            {
                Nome = "Honda",
                Origem = "USA"
            });

            dados.Add(new Marca()
            {
                Nome = "Toyota",
                Origem = "JP"
            });

            return dados;
        }
    }
}