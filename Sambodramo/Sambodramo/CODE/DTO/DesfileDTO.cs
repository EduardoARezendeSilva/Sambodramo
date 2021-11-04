using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sambodramo.CODE.DTO
{
    class DesfileDTO
    {
        private int _id_desfile;
        private string _samba;
        private string _entrata;
        private string _entrada;
        private int _id_escola;
        public int id_desfile { get => _id_desfile; set => _id_desfile = value; }
        public string samba { get => _samba; set => _samba = value; }
        public string entrada { get => _entrada; set => _entrada = value; }
        public string nota { get => _entrata; set => _entrata = value; }
        public int id_escola { get => _id_escola; set => _id_escola = value; }
    }
}
