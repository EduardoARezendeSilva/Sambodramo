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
    class DesfileBLL
    {
        Conexao conexao = new Conexao();
        public void Inserir(DesfileDTO desfileDTO)
        {
            string inserir = $"insert into desfile values (null, '{desfileDTO.samba}', '{desfileDTO.entrada}', {desfileDTO.nota}, {desfileDTO.id_escola})";
            conexao.ExecutarComando(inserir);
        }
        public void Alterar(DesfileDTO desfileDTO)
        {
            string update = $"update desfile set samba_enrredo = '{desfileDTO.samba}', entrada_rua = '{desfileDTO.entrada}', nota = {desfileDTO.nota}, id_escola = {desfileDTO.id_escola} where id_desfile = {desfileDTO.id_desfile}";
            conexao.ExecutarComando(update);
        }
        public void Excluir(DesfileDTO desfileDTO)
        {
            string delete = $"delete from desfile where id_desfile = {desfileDTO.id_desfile}";
            conexao.ExecutarComando(delete);
        }
        public DataTable Listar()
        {
            string sql = "select * from desfile";
            return conexao.ExecutarConsulta(sql);
        }
        public DataTable ListarEscola()
        {
            string sql = "select * from escolas";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
