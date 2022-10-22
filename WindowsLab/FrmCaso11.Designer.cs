namespace WindowsLab
{
    partial class FrmCaso11
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMediaMayor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(106, 106);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 67);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Cargar Provincias";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(325, 106);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(143, 67);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Mostrar";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar Temp media x Prov";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMediaMayor
            // 
            this.btnMediaMayor.Location = new System.Drawing.Point(325, 239);
            this.btnMediaMayor.Name = "btnMediaMayor";
            this.btnMediaMayor.Size = new System.Drawing.Size(143, 72);
            this.btnMediaMayor.TabIndex = 3;
            this.btnMediaMayor.Text = "Mostrar Prov Temp media mayor";
            this.btnMediaMayor.UseVisualStyleBackColor = true;
            this.btnMediaMayor.Click += new System.EventHandler(this.btnMediaMayor_Click);
            // 
            // FrmCaso11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMediaMayor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmCaso11";
            this.Text = "FrmCaso11cs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMediaMayor;
    }
}