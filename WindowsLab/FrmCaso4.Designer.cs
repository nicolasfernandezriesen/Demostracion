namespace WindowsLab
{
    partial class FrmCaso4
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
            this.lblOpcion = new System.Windows.Forms.Label();
            this.btnAreaRectangulo = new System.Windows.Forms.Button();
            this.btnAreaCirculo = new System.Windows.Forms.Button();
            this.btnAreaTrapecio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(283, 117);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(160, 20);
            this.lblOpcion.TabIndex = 0;
            this.lblOpcion.Text = "Sleccione una opcion";
            // 
            // btnAreaRectangulo
            // 
            this.btnAreaRectangulo.Location = new System.Drawing.Point(27, 195);
            this.btnAreaRectangulo.Name = "btnAreaRectangulo";
            this.btnAreaRectangulo.Size = new System.Drawing.Size(156, 77);
            this.btnAreaRectangulo.TabIndex = 1;
            this.btnAreaRectangulo.Text = "Calcular area de un Rectangulo";
            this.btnAreaRectangulo.UseVisualStyleBackColor = true;
            this.btnAreaRectangulo.Click += new System.EventHandler(this.btnAreaRectangulo_Click);
            // 
            // btnAreaCirculo
            // 
            this.btnAreaCirculo.Location = new System.Drawing.Point(269, 195);
            this.btnAreaCirculo.Name = "btnAreaCirculo";
            this.btnAreaCirculo.Size = new System.Drawing.Size(158, 77);
            this.btnAreaCirculo.TabIndex = 2;
            this.btnAreaCirculo.Text = "Clcular area de un circulo";
            this.btnAreaCirculo.UseVisualStyleBackColor = true;
            this.btnAreaCirculo.Click += new System.EventHandler(this.btnAreaCirculo_Click);
            // 
            // btnAreaTrapecio
            // 
            this.btnAreaTrapecio.Location = new System.Drawing.Point(508, 195);
            this.btnAreaTrapecio.Name = "btnAreaTrapecio";
            this.btnAreaTrapecio.Size = new System.Drawing.Size(163, 77);
            this.btnAreaTrapecio.TabIndex = 3;
            this.btnAreaTrapecio.Text = "Calcular area de un trapecio";
            this.btnAreaTrapecio.UseVisualStyleBackColor = true;
            this.btnAreaTrapecio.Click += new System.EventHandler(this.btnAreaTrapecio_Click);
            // 
            // FrmCaso4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAreaTrapecio);
            this.Controls.Add(this.btnAreaCirculo);
            this.Controls.Add(this.btnAreaRectangulo);
            this.Controls.Add(this.lblOpcion);
            this.Name = "FrmCaso4";
            this.Text = "FrmCaso4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Button btnAreaRectangulo;
        private System.Windows.Forms.Button btnAreaCirculo;
        private System.Windows.Forms.Button btnAreaTrapecio;
    }
}