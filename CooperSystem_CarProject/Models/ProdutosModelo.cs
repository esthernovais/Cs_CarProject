using System;

namespace CS_CarProject.Models
{
    public class Carros
    {
        public string Nome { get; set; }
        public double Km { get; set; }
        public int Cilindros { get; set; }
        public int Cavalor { get; set; }
        public double Peso { get; set; }
        public int Aceleracao { get; set; }
        public string Ano { get; set; }
        public string Origem { get; set; }
    }
    public class Marca 
    {
        public string Nome { get; set; }
        public string Origem { get; set; }
    }

}
