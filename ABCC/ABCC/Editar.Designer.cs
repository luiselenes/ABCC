namespace ABCC
{
    partial class Editar
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.checkdescontinuado = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpbaja = new System.Windows.Forms.DateTimePicker();
            this.dtpalta = new System.Windows.Forms.DateTimePicker();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.cbfamilia = new System.Windows.Forms.ComboBox();
            this.cbclase = new System.Windows.Forms.ComboBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.cbdepartamento = new System.Windows.Forms.ComboBox();
            this.txtsku = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(418, 274);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(126, 38);
            this.btnguardar.TabIndex = 49;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // checkdescontinuado
            // 
            this.checkdescontinuado.AutoSize = true;
            this.checkdescontinuado.Checked = true;
            this.checkdescontinuado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkdescontinuado.Location = new System.Drawing.Point(440, 14);
            this.checkdescontinuado.Name = "checkdescontinuado";
            this.checkdescontinuado.Size = new System.Drawing.Size(120, 20);
            this.checkdescontinuado.TabIndex = 48;
            this.checkdescontinuado.Text = "Descontinuado";
            this.checkdescontinuado.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Fecha Baja";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 46;
            this.label11.Text = "Fecha Alta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Cantidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Familia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Clase:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Departamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Articulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "sku:";
            // 
            // dtpbaja
            // 
            this.dtpbaja.Location = new System.Drawing.Point(92, 297);
            this.dtpbaja.Name = "dtpbaja";
            this.dtpbaja.Size = new System.Drawing.Size(285, 22);
            this.dtpbaja.TabIndex = 36;
            // 
            // dtpalta
            // 
            this.dtpalta.Location = new System.Drawing.Point(92, 269);
            this.dtpalta.Name = "dtpalta";
            this.dtpalta.Size = new System.Drawing.Size(285, 22);
            this.dtpalta.TabIndex = 32;
            this.dtpalta.Value = new System.DateTime(2023, 1, 6, 23, 50, 40, 0);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(300, 214);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(104, 22);
            this.txtcantidad.TabIndex = 35;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(114, 214);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(100, 22);
            this.txtstock.TabIndex = 34;
            // 
            // cbfamilia
            // 
            this.cbfamilia.FormattingEnabled = true;
            this.cbfamilia.Location = new System.Drawing.Point(114, 184);
            this.cbfamilia.Name = "cbfamilia";
            this.cbfamilia.Size = new System.Drawing.Size(290, 24);
            this.cbfamilia.TabIndex = 33;
            // 
            // cbclase
            // 
            this.cbclase.FormattingEnabled = true;
            this.cbclase.Location = new System.Drawing.Point(114, 154);
            this.cbclase.Name = "cbclase";
            this.cbclase.Size = new System.Drawing.Size(290, 24);
            this.cbclase.TabIndex = 31;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(114, 96);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(290, 22);
            this.txtmodelo.TabIndex = 30;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(114, 68);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(290, 22);
            this.txtmarca.TabIndex = 29;
            // 
            // txtarticulo
            // 
            this.txtarticulo.Location = new System.Drawing.Point(114, 40);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(290, 22);
            this.txtarticulo.TabIndex = 28;
            // 
            // cbdepartamento
            // 
            this.cbdepartamento.FormattingEnabled = true;
            this.cbdepartamento.Location = new System.Drawing.Point(114, 124);
            this.cbdepartamento.Name = "cbdepartamento";
            this.cbdepartamento.Size = new System.Drawing.Size(290, 24);
            this.cbdepartamento.TabIndex = 27;
            // 
            // txtsku
            // 
            this.txtsku.Enabled = false;
            this.txtsku.Location = new System.Drawing.Point(114, 12);
            this.txtsku.Name = "txtsku";
            this.txtsku.Size = new System.Drawing.Size(290, 22);
            this.txtsku.TabIndex = 26;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 338);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.checkdescontinuado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpbaja);
            this.Controls.Add(this.dtpalta);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.cbfamilia);
            this.Controls.Add(this.cbclase);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtarticulo);
            this.Controls.Add(this.cbdepartamento);
            this.Controls.Add(this.txtsku);
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.CheckBox checkdescontinuado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpbaja;
        private System.Windows.Forms.DateTimePicker dtpalta;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.ComboBox cbfamilia;
        private System.Windows.Forms.ComboBox cbclase;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.ComboBox cbdepartamento;
        private System.Windows.Forms.TextBox txtsku;
    }
}