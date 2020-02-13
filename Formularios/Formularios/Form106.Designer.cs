namespace Formularios
{
    partial class Form106
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form106));
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMultas = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodDoc = new System.Windows.Forms.TextBox();
            this.txtDescp = new System.Windows.Forms.TextBox();
            this.txtCodImp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lbId4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(543, -60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 39);
            this.button4.TabIndex = 53;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 39);
            this.button1.TabIndex = 50;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMultas
            // 
            this.txtMultas.Location = new System.Drawing.Point(671, 253);
            this.txtMultas.Name = "txtMultas";
            this.txtMultas.Size = new System.Drawing.Size(241, 22);
            this.txtMultas.TabIndex = 41;
            this.txtMultas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMultas_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(671, 293);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(241, 22);
            this.txtTotal.TabIndex = 40;
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(671, 215);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(241, 22);
            this.txtInteres.TabIndex = 39;
            this.txtInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInteres_KeyPress);
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(671, 178);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.ReadOnly = true;
            this.txtImpuesto.Size = new System.Drawing.Size(241, 22);
            this.txtImpuesto.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Total Pagado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Multas + Recargos: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Intereses por mora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Impuesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Formulario: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, -24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 22);
            this.textBox2.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, -24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "RUC";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, -70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 22);
            this.textBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, -70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Razon Social";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(173, 74);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.ReadOnly = true;
            this.txtRuc.Size = new System.Drawing.Size(241, 22);
            this.txtRuc.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 56;
            this.label13.Text = "RUC";
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(173, 28);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.ReadOnly = true;
            this.txtRazon.Size = new System.Drawing.Size(241, 22);
            this.txtRazon.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(76, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 54;
            this.label14.Text = "Razon Social";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(510, 74);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(76, 22);
            this.txtMes.TabIndex = 62;
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMes_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(459, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 17);
            this.label15.TabIndex = 61;
            this.label15.Text = "Mes";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(556, 28);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(241, 22);
            this.txtCiudad.TabIndex = 60;
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudad_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(459, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 17);
            this.label16.TabIndex = 59;
            this.label16.Text = "Ciudad";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(660, 74);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(72, 22);
            this.txtAño.TabIndex = 64;
            this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAño_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(621, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 17);
            this.label17.TabIndex = 63;
            this.label17.Text = "Año";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 17);
            this.label8.TabIndex = 65;
            this.label8.Text = "Identificación de la obligación tributaria: ";
            // 
            // txtCodDoc
            // 
            this.txtCodDoc.Location = new System.Drawing.Point(186, 255);
            this.txtCodDoc.Name = "txtCodDoc";
            this.txtCodDoc.Size = new System.Drawing.Size(241, 22);
            this.txtCodDoc.TabIndex = 73;
            // 
            // txtDescp
            // 
            this.txtDescp.Location = new System.Drawing.Point(186, 217);
            this.txtDescp.Name = "txtDescp";
            this.txtDescp.Size = new System.Drawing.Size(241, 22);
            this.txtDescp.TabIndex = 71;
            this.txtDescp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescp_KeyPress);
            // 
            // txtCodImp
            // 
            this.txtCodImp.Location = new System.Drawing.Point(186, 180);
            this.txtCodImp.Name = "txtCodImp";
            this.txtCodImp.ReadOnly = true;
            this.txtCodImp.Size = new System.Drawing.Size(241, 22);
            this.txtCodImp.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 17);
            this.label10.TabIndex = 68;
            this.label10.Text = "Código Documento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 67;
            this.label11.Text = "Descripción";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 17);
            this.label12.TabIndex = 66;
            this.label12.Text = "Código Impuesto";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(489, 377);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(97, 39);
            this.btnPagar.TabIndex = 74;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lbId4
            // 
            this.lbId4.AutoSize = true;
            this.lbId4.Location = new System.Drawing.Point(12, 423);
            this.lbId4.Name = "lbId4";
            this.lbId4.Size = new System.Drawing.Size(0, 17);
            this.lbId4.TabIndex = 75;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 39);
            this.button2.TabIndex = 76;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(846, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 39);
            this.button3.TabIndex = 77;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
            this.skinEngine1.SkinFile = "C:\\Users\\Chantal Morales\\Desktop\\Componentes Graficos Vb2\\Componentes Graficos Vb" +
    "2\\SKIN NET 2010 WIN 7\\SkinVS.NET\\Vista2\\Vista2_color7.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // Form106
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 449);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbId4);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtCodDoc);
            this.Controls.Add(this.txtDescp);
            this.Controls.Add(this.txtCodImp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtRuc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMultas);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form106";
            this.Text = "Form106";
            this.Load += new System.EventHandler(this.Form106_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMultas;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodDoc;
        private System.Windows.Forms.TextBox txtDescp;
        private System.Windows.Forms.TextBox txtCodImp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lbId4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}