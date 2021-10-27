namespace Sambodramo.UI
{
    partial class Frm_Desfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdEscolas = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblProprietario = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.txtProprietario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEscola = new System.Windows.Forms.Label();
            this.cboEscola = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEscolas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEscolas
            // 
            this.grdEscolas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEscolas.Location = new System.Drawing.Point(21, 170);
            this.grdEscolas.Name = "grdEscolas";
            this.grdEscolas.Size = new System.Drawing.Size(598, 272);
            this.grdEscolas.TabIndex = 20;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(361, 114);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(176, 114);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 23);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(21, 114);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 23);
            this.btnInserir.TabIndex = 14;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // lblProprietario
            // 
            this.lblProprietario.AutoSize = true;
            this.lblProprietario.Location = new System.Drawing.Point(356, 26);
            this.lblProprietario.Name = "lblProprietario";
            this.lblProprietario.Size = new System.Drawing.Size(105, 13);
            this.lblProprietario.TabIndex = 19;
            this.lblProprietario.Text = "Nome do propreitario";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(173, 26);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(132, 13);
            this.lblAno.TabIndex = 18;
            this.lblAno.Text = "Ano da ultima participação";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(18, 26);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(84, 13);
            this.lbl_Nome.TabIndex = 16;
            this.lbl_Nome.Text = "Nome da escola";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(176, 45);
            this.txtAno.Mask = "0000";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 12;
            this.txtAno.ValidatingType = typeof(System.DateTime);
            // 
            // txtProprietario
            // 
            this.txtProprietario.Location = new System.Drawing.Point(359, 45);
            this.txtProprietario.Name = "txtProprietario";
            this.txtProprietario.Size = new System.Drawing.Size(100, 20);
            this.txtProprietario.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 11;
            // 
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Location = new System.Drawing.Point(506, 26);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(88, 13);
            this.lblEscola.TabIndex = 21;
            this.lblEscola.Text = "Escola de samba";
            // 
            // cboEscola
            // 
            this.cboEscola.FormattingEnabled = true;
            this.cboEscola.Location = new System.Drawing.Point(509, 45);
            this.cboEscola.Name = "cboEscola";
            this.cboEscola.Size = new System.Drawing.Size(102, 21);
            this.cboEscola.TabIndex = 22;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(509, 114);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Frm_Desfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 474);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cboEscola);
            this.Controls.Add(this.lblEscola);
            this.Controls.Add(this.grdEscolas);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblProprietario);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtProprietario);
            this.Controls.Add(this.txtNome);
            this.Name = "Frm_Desfile";
            this.Text = "Frm_Desfile";
            ((System.ComponentModel.ISupportInitialize)(this.grdEscolas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEscolas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblProprietario;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.MaskedTextBox txtAno;
        private System.Windows.Forms.TextBox txtProprietario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEscola;
        private System.Windows.Forms.ComboBox cboEscola;
        private System.Windows.Forms.Button btnLimpar;
    }
}