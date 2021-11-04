using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sambodramo.CODE.DTO;
using Sambodramo.CODE.BLL;

namespace Sambodramo
{
    public partial class Frm_Escolas : Form
    {
        EscolasBLL escolasBLL = new EscolasBLL();
        EscolasDTO escolasDTO = new EscolasDTO();
        public Frm_Escolas()
        {
            InitializeComponent();
            listar();
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            escolasDTO.nome = txtNome.Text;
            escolasDTO.ano = txtAno.Text;
            escolasDTO.proprietario = txtProprietario.Text;

            escolasBLL.Inserir(escolasDTO);
            listar();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            escolasDTO.id = int.Parse(txtNome.Tag.ToString());
            escolasDTO.nome = txtNome.Text;
            escolasDTO.ano = txtAno.Text;
            escolasDTO.proprietario = txtProprietario.Text;

            escolasBLL.Alterar(escolasDTO);
            listar();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            escolasDTO.id = int.Parse(txtNome.Tag.ToString());

            escolasBLL.Excluir(escolasDTO);
            listar();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void grdEscolas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNome.Tag = grdEscolas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = grdEscolas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAno.Text = grdEscolas.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtProprietario.Text = grdEscolas.Rows[e.RowIndex].Cells[3].Value.ToString();
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
        public void limpar()
        {
            txtNome.Tag = "";
            txtNome.Text = "";
            txtAno.Text = "";
            txtProprietario.Text = "";
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }
        public void listar()
        {
            limpar();
            grdEscolas.DataSource = escolasBLL.Listar();
        }
    }
}
