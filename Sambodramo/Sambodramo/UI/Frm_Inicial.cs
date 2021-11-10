using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sambodramo.UI
{
    public partial class Frm_Inicial : Form
    {
        public string usuario;
        public Frm_Inicial()
        {
            InitializeComponent();
        }

        private void btnescola_Click(object sender, EventArgs e)
        {
            Frm_Escolas frm_Escolas = new Frm_Escolas();
            frm_Escolas.Show();
            frm_Escolas.Text = $"Escolas - {usuario}";
        }

        private void btndesfile_Click(object sender, EventArgs e)
        {
            Frm_Desfile frm_Desfile = new Frm_Desfile();
            frm_Desfile.Show();
            frm_Desfile.Text = $"Desfile - {usuario}";
        }
    }
}
