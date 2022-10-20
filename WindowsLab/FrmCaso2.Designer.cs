namespace WindowsLab
{
    partial class FrmCaso2
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
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnEdad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(147, 178);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(141, 20);
            this.lblEdad.TabIndex = 0;
            this.lblEdad.Text = "Ingrese su edad = ";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(294, 175);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 26);
            this.txtEdad.TabIndex = 1;
            // 
            // btnEdad
            // 
            this.btnEdad.Location = new System.Drawing.Point(240, 224);
            this.btnEdad.Name = "btnEdad";
            this.btnEdad.Size = new System.Drawing.Size(92, 35);
            this.btnEdad.TabIndex = 2;
            this.btnEdad.Text = "Ingresar edad";
            this.btnEdad.UseVisualStyleBackColor = true;
            this.btnEdad.Click += new System.EventHandler(this.btnEdad_Click);
            // 
            // FrmCaso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Name = "FrmCaso2";
            this.Text = "FrmCaso2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnEdad;
    }
}