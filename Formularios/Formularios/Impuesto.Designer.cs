namespace Formularios
{
    partial class Impuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impuesto));
            this.label1 = new System.Windows.Forms.Label();
            this.lbImpuesto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbId3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIT = new System.Windows.Forms.TextBox();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Su renta imponible es: ";
            // 
            // lbImpuesto
            // 
            this.lbImpuesto.AutoSize = true;
            this.lbImpuesto.Location = new System.Drawing.Point(237, 133);
            this.lbImpuesto.Name = "lbImpuesto";
            this.lbImpuesto.Size = new System.Drawing.Size(0, 17);
            this.lbImpuesto.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pasar al Formulario 106";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbId3
            // 
            this.lbId3.AutoSize = true;
            this.lbId3.Location = new System.Drawing.Point(31, 243);
            this.lbId3.Name = "lbId3";
            this.lbId3.Size = new System.Drawing.Size(0, 17);
            this.lbId3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingresos Totales: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gastos Totales: ";
            // 
            // txtIT
            // 
            this.txtIT.Location = new System.Drawing.Point(211, 40);
            this.txtIT.Name = "txtIT";
            this.txtIT.ReadOnly = true;
            this.txtIT.Size = new System.Drawing.Size(191, 22);
            this.txtIT.TabIndex = 7;
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(211, 77);
            this.txtGT.Name = "txtGT";
            this.txtGT.ReadOnly = true;
            this.txtGT.Size = new System.Drawing.Size(191, 22);
            this.txtGT.TabIndex = 8;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinFile = "C:\\Users\\Chantal Morales\\Desktop\\Componentes Graficos Vb2\\Componentes Graficos Vb" +
    "2\\SKIN NET 2010 WIN 7\\SkinVS.NET\\Vista2\\Vista2_color7.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // Impuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 273);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.txtIT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbId3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbImpuesto);
            this.Controls.Add(this.label1);
            this.Name = "Impuesto";
            this.Text = "Impuesto";
            this.Load += new System.EventHandler(this.Impuesto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbImpuesto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbId3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIT;
        private System.Windows.Forms.TextBox txtGT;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}