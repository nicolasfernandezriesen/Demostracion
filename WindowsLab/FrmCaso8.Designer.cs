namespace WindowsLab
{
    partial class FrmCaso8
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
            this.btnLoadPrec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadPrec
            // 
            this.btnLoadPrec.Location = new System.Drawing.Point(241, 215);
            this.btnLoadPrec.Name = "btnLoadPrec";
            this.btnLoadPrec.Size = new System.Drawing.Size(227, 55);
            this.btnLoadPrec.TabIndex = 17;
            this.btnLoadPrec.Text = "Cargar Precio de Productos";
            this.btnLoadPrec.UseVisualStyleBackColor = true;
            this.btnLoadPrec.Click += new System.EventHandler(this.btnLoadPrec_Click);
            // 
            // FrmCaso8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadPrec);
            this.Name = "FrmCaso8";
            this.Text = "FrmCaso8";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoadPrec;
    }
}