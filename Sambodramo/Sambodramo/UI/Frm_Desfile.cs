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

namespace Sambodramo.UI
{
    public partial class Frm_Desfile : Form
    {
        DesfileBLL desfileBLL = new DesfileBLL();
        DesfileDTO desfileDTO = new DesfileDTO();
        public Frm_Desfile()
        {
            InitializeComponent();
            listar();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            desfileDTO.samba = txtSambaEnrredo.Text;
            desfileDTO.entrada = txtEntrada.Text.Substring(6, 4) + txtEntrada.Text.Substring(2, 4) + txtEntrada.Text.Substring(0, 2);
            desfileDTO.nota = txtNota.Text;
            desfileDTO.id_escola = int.Parse(cboEscola.SelectedValue.ToString());
            desfileBLL.Inserir(desfileDTO);
            listar();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            desfileDTO.id_desfile = int.Parse(txtSambaEnrredo.Tag.ToString());
            desfileDTO.samba = txtSambaEnrredo.Text;
            desfileDTO.entrada = txtEntrada.Text.Substring(6, 4) + txtEntrada.Text.Substring(2, 4) + txtEntrada.Text.Substring(0, 2);
            desfileDTO.nota = txtNota.Text;
            desfileDTO.id_escola = int.Parse(cboEscola.SelectedValue.ToString());
            desfileBLL.Alterar(desfileDTO);
            listar();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            desfileDTO.id_desfile = int.Parse(txtSambaEnrredo.Tag.ToString());
            desfileBLL.Excluir(desfileDTO);
            listar();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void grddesfile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtSambaEnrredo.Tag = grdDesfile.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSambaEnrredo.Text = grdDesfile.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEntrada.Text = grdDesfile.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNota.Text = grdDesfile.Rows[e.RowIndex].Cells[3].Value.ToString();
                cboEscola.SelectedValue = grdDesfile.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
        public void limpar()
        {
            txtSambaEnrredo.Tag = "";
            txtSambaEnrredo.Text = "";
            txtEntrada.Text = "";
            txtNota.Text = "";
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            buscaescola();
        }
        public void listar()
        {
            limpar();
            grdDesfile.DataSource = desfileBLL.Listar();
        }
        public void buscaescola()
        {

            cboEscola.DataSource = desfileBLL.ListarEscola();

            cboEscola.ValueMember = "id_escola";

            cboEscola.DisplayMember = "nome_escola";

            cboEscola.SelectedIndex = -1;

        }
    }
}
