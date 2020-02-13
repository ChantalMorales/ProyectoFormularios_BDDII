namespace Formularios
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(210, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(210, 130);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '#';
            this.txtPasswd.Size = new System.Drawing.Size(180, 22);
            this.txtPasswd.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(205, 193);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(126, 45);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Iniciar Sesión ";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinFile = "C:\\Users\\Chantal Morales\\Desktop\\Componentes Graficos Vb2\\Componentes Graficos Vb" +
    "2\\SKIN NET 2010 WIN 7\\SkinVS.NET\\Vista2\\Vista2_color7.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 309);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Button btnlogin;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

