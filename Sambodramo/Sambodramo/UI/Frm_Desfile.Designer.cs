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
            this.grdDesfile = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSambaEnrredo = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtSambaEnrredo = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblEscola = new System.Windows.Forms.Label();
            this.cboEscola = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDesfile)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDesfile
            // 
            this.grdDesfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDesfile.Location = new System.Drawing.Point(21, 170);
            this.grdDesfile.Name = "grdDesfile";
            this.grdDesfile.Size = new System.Drawing.Size(598, 272);
            this.grdDesfile.TabIndex = 20;
            this.grdDesfile.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDesfile_CellClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(361, 114);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(204, 114);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 23);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(21, 114);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 23);
            this.btnInserir.TabIndex = 14;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(201, 26);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(77, 13);
            this.lblEntrada.TabIndex = 19;
            this.lblEntrada.Text = "Entrada na rua";
            // 
            // lblSambaEnrredo
            // 
            this.lblSambaEnrredo.AutoSize = true;
            this.lblSambaEnrredo.Location = new System.Drawing.Point(18, 26);
            this.lblSambaEnrredo.Name = "lblSambaEnrredo";
            this.lblSambaEnrredo.Size = new System.Drawing.Size(77, 13);
            this.lblSambaEnrredo.TabIndex = 18;
            this.lblSambaEnrredo.Text = "SambaEnrredo";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(358, 26);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(78, 13);
            this.lblNota.TabIndex = 16;
            this.lblNota.Text = "Nota do desfile";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(204, 42);
            this.txtEntrada.Mask = "00/00/0000";
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 12;
            this.txtEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // txtSambaEnrredo
            // 
            this.txtSambaEnrredo.Location = new System.Drawing.Point(21, 42);
            this.txtSambaEnrredo.Name = "txtSambaEnrredo";
            this.txtSambaEnrredo.Size = new System.Drawing.Size(100, 20);
            this.txtSambaEnrredo.TabIndex = 13;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(361, 42);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 11;
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
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
            this.cboEscola.Location = new System.Drawing.Point(509, 41);
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
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Frm_Desfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 474);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cboEscola);
            this.Controls.Add(this.lblEscola);
            this.Controls.Add(this.grdDesfile);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblSambaEnrredo);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.txtSambaEnrredo);
            this.Controls.Add(this.txtNota);
            this.Name = "Frm_Desfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Desfile";
            ((System.ComponentModel.ISupportInitialize)(this.grdDesfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDesfile;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSambaEnrredo;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.MaskedTextBox txtEntrada;
        private System.Windows.Forms.TextBox txtSambaEnrredo;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblEscola;
        private System.Windows.Forms.ComboBox cboEscola;
        private System.Windows.Forms.Button btnLimpar;
    }
}