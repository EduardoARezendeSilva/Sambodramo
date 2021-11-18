using Sambodramo.CODE.BLL;
using Sambodramo.CODE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sambodramo.UI
{
    public partial class Frm_Login : Form
    {
        LoginDTO loginDTO = new LoginDTO();
        LoginBLL loginBLL = new LoginBLL();
        Frm_Inicial frmInicial = new Frm_Inicial();

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" || txtSenha.Text != "" )
            {
                loginDTO.email = txtEmail.Text;
                loginDTO.senha = txtSenha.Text;

                DataTable dt = loginBLL.Login(loginDTO);

                if (dt.Rows.Count > 0)
                {
                    frmInicial.Show();
                    frmInicial.Text = $"Inicial - {dt.Rows[0].ItemArray[1].ToString()}";
                    frmInicial.usuario = dt.Rows[0].ItemArray[1].ToString();
                }
                else
                {
                    MessageBox.Show("Dados Para login invalido!!!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!!");
            }
        }

        private void lnkSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtEmail.Text != "")
            {
                loginDTO.email = txtEmail.Text;

                DataTable dt = loginBLL.Senha(loginDTO);

                if (dt.Rows.Count > 0)
                {
                    var cliente = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential("11900555@aluno.cotemig.com.br", "kujsarwredhowfhd"),
                        EnableSsl = true
                    };

                    cliente.Send("11900555@aluno.cotemig.com.br", dt.Rows[0].ItemArray[2].ToString(), "Recupera senha", $"Sua senha e: {dt.Rows[0].ItemArray[3].ToString()}");

                    MessageBox.Show("Email enviado com sucesso", "Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Dados Para login invalido!!!");
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo email para recuperar a senha!!!");
            }
        }
    }
}
