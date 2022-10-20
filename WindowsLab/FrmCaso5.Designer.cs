namespace WindowsLab
{
    partial class FrmCaso5
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
            this.lblNameUser = new System.Windows.Forms.Label();
            this.txtNameUser = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtGeneroUser = new System.Windows.Forms.TextBox();
            this.lblRolUser = new System.Windows.Forms.Label();
            this.txtRolUser = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Location = new System.Drawing.Point(81, 86);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(226, 20);
            this.lblNameUser.TabIndex = 0;
            this.lblNameUser.Text = "Ingrese el nombre del usuario: ";
            // 
            // txtNameUser
            // 
            this.txtNameUser.Location = new System.Drawing.Point(387, 86);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(100, 26);
            this.txtNameUser.TabIndex = 1;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(85, 182);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(200, 20);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Ingrese su genero:  (F o M)";
            // 
            // txtGeneroUser
            // 
            this.txtGeneroUser.Location = new System.Drawing.Point(387, 175);
            this.txtGeneroUser.Name = "txtGeneroUser";
            this.txtGeneroUser.Size = new System.Drawing.Size(100, 26);
            this.txtGeneroUser.TabIndex = 3;
            // 
            // lblRolUser
            // 
            this.lblRolUser.AutoSize = true;
            this.lblRolUser.Location = new System.Drawing.Point(85, 254);
            this.lblRolUser.Name = "lblRolUser";
            this.lblRolUser.Size = new System.Drawing.Size(192, 20);
            this.lblRolUser.TabIndex = 4;
            this.lblRolUser.Text = "Ingrese su tipo de usuario";
            // 
            // txtRolUser
            // 
            this.txtRolUser.Location = new System.Drawing.Point(387, 254);
            this.txtRolUser.Name = "txtRolUser";
            this.txtRolUser.Size = new System.Drawing.Size(100, 26);
            this.txtRolUser.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(272, 327);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(110, 32);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Validar datos ";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmCaso5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtRolUser);
            this.Controls.Add(this.lblRolUser);
            this.Controls.Add(this.txtGeneroUser);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtNameUser);
            this.Controls.Add(this.lblNameUser);
            this.Name = "FrmCaso5";
            this.Text = "FrmCaso5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.TextBox txtNameUser;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtGeneroUser;
        private System.Windows.Forms.Label lblRolUser;
        private System.Windows.Forms.TextBox txtRolUser;
        private System.Windows.Forms.Button btnIngresar;
    }
}