using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sambodramo.CODE.DAL;
using Sambodramo.CODE.DTO;

namespace Sambodramo.CODE.BLL
{
    class EscolasBLL
    {
        Conexao conexao = new Conexao();
        public void Inserir(EscolasDTO escolasDTO)
        {
            string inserir = $"insert into escolas values (null, '{escolasDTO.nome}', '{escolasDTO.ano}', '{escolasDTO.proprietario}')";
            conexao.ExecutarComando(inserir);
        }
        public void Alterar(EscolasDTO escolasDTO)
        {
            string update = $"update escolas set nome_escola = '{escolasDTO.nome}', ano_ult_part = '{escolasDTO.ano}', nome_proprietario = '{escolasDTO.proprietario}' where id_escola = {escolasDTO.id}";
            conexao.ExecutarComando(update);
        }
        public void Excluir(EscolasDTO escolasDTO)
        {
            string delete = $"delete from escolas where id_escola = {escolasDTO.id}";
            conexao.ExecutarComando(delete);
        }
        public DataTable Listar() 
        {
            string sql = "select * from escolas";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
