using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sambodramo.CODE.DTO
{
    class EscolasDTO
    {
        private int _id;
        private string _nome;
        private string _ano;
        private string _proprietario;

        public int id { get => _id; set => _id = value; }
        public string nome { get => _nome; set => _nome = value; }
        public string ano { get => _ano; set => _ano = value; }
        public string proprietario { get => _proprietario; set => _proprietario = value; }
    }
}
