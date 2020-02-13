namespace Formularios
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pulse el botón del formulario que desea abrir: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Formulario 102A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinFile = "C:\\Users\\Chantal Morales\\Desktop\\Componentes Graficos Vb2\\Componentes Graficos Vb" +
    "2\\SKIN NET 2010 WIN 7\\SkinVS.NET\\Vista2\\Vista2_color7.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}