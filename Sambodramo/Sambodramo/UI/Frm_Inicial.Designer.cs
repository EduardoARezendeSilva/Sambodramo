namespace Sambodramo.UI
{
    partial class Frm_Inicial
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
            this.btnescola = new System.Windows.Forms.Button();
            this.btndesfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnescola
            // 
            this.btnescola.Location = new System.Drawing.Point(70, 36);
            this.btnescola.Name = "btnescola";
            this.btnescola.Size = new System.Drawing.Size(110, 51);
            this.btnescola.TabIndex = 0;
            this.btnescola.Text = "escola";
            this.btnescola.UseVisualStyleBackColor = true;
            this.btnescola.Click += new System.EventHandler(this.btnescola_Click);
            // 
            // btndesfile
            // 
            this.btndesfile.Location = new System.Drawing.Point(209, 36);
            this.btndesfile.Name = "btndesfile";
            this.btndesfile.Size = new System.Drawing.Size(110, 51);
            this.btndesfile.TabIndex = 1;
            this.btndesfile.Text = "desfile";
            this.btndesfile.UseVisualStyleBackColor = true;
            this.btndesfile.Click += new System.EventHandler(this.btndesfile_Click);
            // 
            // Frm_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 140);
            this.Controls.Add(this.btndesfile);
            this.Controls.Add(this.btnescola);
            this.Name = "Frm_Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnescola;
        private System.Windows.Forms.Button btndesfile;
    }
}