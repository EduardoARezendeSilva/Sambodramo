using Sambodramo.CODE.DAL;
using Sambodramo.CODE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sambodramo.CODE.BLL
{
    class LoginBLL
    {
        Conexao conexao = new Conexao();

        public DataTable Login(LoginDTO loginDTO)
        {
            string sql = $"select * from login where email = '{loginDTO.email}' and senha = '{loginDTO.senha}'";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
