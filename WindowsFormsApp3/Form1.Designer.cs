
namespace WindowsFormsApp3
{
    partial class Form1
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
         this.label1 = new System.Windows.Forms.Label();
         this.rBCamion = new System.Windows.Forms.RadioButton();
         this.rBFurgon = new System.Windows.Forms.RadioButton();
         this.label2 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.txtCapacidad = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.numPaquetesC = new System.Windows.Forms.NumericUpDown();
         this.numPaquetesB = new System.Windows.Forms.NumericUpDown();
         this.label12 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.btnVerLista = new System.Windows.Forms.Button();
         this.label8 = new System.Windows.Forms.Label();
         this.lBMultados = new System.Windows.Forms.ListBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.label10 = new System.Windows.Forms.Label();
         this.numMin = new System.Windows.Forms.NumericUpDown();
         this.label9 = new System.Windows.Forms.Label();
         this.numHr = new System.Windows.Forms.NumericUpDown();
         this.label6 = new System.Windows.Forms.Label();
         this.rBHabiles = new System.Windows.Forms.RadioButton();
         this.rBEspeciales = new System.Windows.Forms.RadioButton();
         this.label7 = new System.Windows.Forms.Label();
         this.txtDias = new System.Windows.Forms.TextBox();
         this.numPaquetesA = new System.Windows.Forms.NumericUpDown();
         this.label5 = new System.Windows.Forms.Label();
         this.txtPatente = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.btnAgregar = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numPaquetesC)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numPaquetesB)).BeginInit();
         this.groupBox2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numHr)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numPaquetesA)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.SystemColors.Control;
         this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
         this.label1.Location = new System.Drawing.Point(282, 23);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(118, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Empresa de transportes";
         // 
         // rBCamion
         // 
         this.rBCamion.AutoSize = true;
         this.rBCamion.Location = new System.Drawing.Point(18, 97);
         this.rBCamion.Name = "rBCamion";
         this.rBCamion.Size = new System.Drawing.Size(60, 17);
         this.rBCamion.TabIndex = 1;
         this.rBCamion.TabStop = true;
         this.rBCamion.Text = "Camión";
         this.rBCamion.UseVisualStyleBackColor = true;
         // 
         // rBFurgon
         // 
         this.rBFurgon.AutoSize = true;
         this.rBFurgon.Location = new System.Drawing.Point(18, 74);
         this.rBFurgon.Name = "rBFurgon";
         this.rBFurgon.Size = new System.Drawing.Size(58, 17);
         this.rBFurgon.TabIndex = 2;
         this.rBFurgon.TabStop = true;
         this.rBFurgon.Text = "Furgón";
         this.rBFurgon.UseVisualStyleBackColor = true;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(15, 48);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(51, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = ":Vehiculo";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.txtCapacidad);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.numPaquetesC);
         this.groupBox1.Controls.Add(this.numPaquetesB);
         this.groupBox1.Controls.Add(this.label12);
         this.groupBox1.Controls.Add(this.label11);
         this.groupBox1.Controls.Add(this.btnVerLista);
         this.groupBox1.Controls.Add(this.label8);
         this.groupBox1.Controls.Add(this.lBMultados);
         this.groupBox1.Controls.Add(this.groupBox2);
         this.groupBox1.Controls.Add(this.numPaquetesA);
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.txtPatente);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.btnAgregar);
         this.groupBox1.Controls.Add(this.rBCamion);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.rBFurgon);
         this.groupBox1.Location = new System.Drawing.Point(12, 39);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(794, 359);
         this.groupBox1.TabIndex = 4;
         this.groupBox1.TabStop = false;
         // 
         // txtCapacidad
         // 
         this.txtCapacidad.Location = new System.Drawing.Point(65, 178);
         this.txtCapacidad.Name = "txtCapacidad";
         this.txtCapacidad.Size = new System.Drawing.Size(77, 20);
         this.txtCapacidad.TabIndex = 23;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(8, 181);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(58, 13);
         this.label4.TabIndex = 22;
         this.label4.Text = "Capacidad";
         // 
         // numPaquetesC
         // 
         this.numPaquetesC.Location = new System.Drawing.Point(135, 291);
         this.numPaquetesC.Name = "numPaquetesC";
         this.numPaquetesC.Size = new System.Drawing.Size(65, 20);
         this.numPaquetesC.TabIndex = 21;
         // 
         // numPaquetesB
         // 
         this.numPaquetesB.Location = new System.Drawing.Point(135, 253);
         this.numPaquetesB.Name = "numPaquetesB";
         this.numPaquetesB.Size = new System.Drawing.Size(65, 20);
         this.numPaquetesB.TabIndex = 20;
         // 
         // label12
         // 
         this.label12.AutoSize = true;
         this.label12.Location = new System.Drawing.Point(15, 298);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(82, 13);
         this.label12.TabIndex = 19;
         this.label12.Text = "Paquetes tipo C";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(15, 260);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(82, 13);
         this.label11.TabIndex = 18;
         this.label11.Text = "Paquetes tipo B";
         // 
         // btnVerLista
         // 
         this.btnVerLista.Location = new System.Drawing.Point(608, 280);
         this.btnVerLista.Name = "btnVerLista";
         this.btnVerLista.Size = new System.Drawing.Size(145, 49);
         this.btnVerLista.TabIndex = 17;
         this.btnVerLista.Text = "Ver lista";
         this.btnVerLista.UseVisualStyleBackColor = true;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(619, 30);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(98, 13);
         this.label8.TabIndex = 16;
         this.label8.Text = "Vehiculos multados";
         // 
         // lBMultados
         // 
         this.lBMultados.FormattingEnabled = true;
         this.lBMultados.Location = new System.Drawing.Point(578, 48);
         this.lBMultados.Name = "lBMultados";
         this.lBMultados.Size = new System.Drawing.Size(195, 225);
         this.lBMultados.TabIndex = 15;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.label10);
         this.groupBox2.Controls.Add(this.numMin);
         this.groupBox2.Controls.Add(this.label9);
         this.groupBox2.Controls.Add(this.numHr);
         this.groupBox2.Controls.Add(this.label6);
         this.groupBox2.Controls.Add(this.rBHabiles);
         this.groupBox2.Controls.Add(this.rBEspeciales);
         this.groupBox2.Controls.Add(this.label7);
         this.groupBox2.Controls.Add(this.txtDias);
         this.groupBox2.Location = new System.Drawing.Point(251, 30);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(218, 217);
         this.groupBox2.TabIndex = 14;
         this.groupBox2.TabStop = false;
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(106, 176);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(23, 13);
         this.label10.TabIndex = 21;
         this.label10.Text = "min";
         // 
         // numMin
         // 
         this.numMin.Location = new System.Drawing.Point(135, 173);
         this.numMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
         this.numMin.Name = "numMin";
         this.numMin.Size = new System.Drawing.Size(42, 20);
         this.numMin.TabIndex = 18;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(6, 176);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(16, 13);
         this.label9.TabIndex = 20;
         this.label9.Text = "hr";
         // 
         // numHr
         // 
         this.numHr.Location = new System.Drawing.Point(35, 174);
         this.numHr.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
         this.numHr.Name = "numHr";
         this.numHr.Size = new System.Drawing.Size(48, 20);
         this.numHr.TabIndex = 19;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(6, 125);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(41, 13);
         this.label6.TabIndex = 17;
         this.label6.Text = "Horario";
         // 
         // rBHabiles
         // 
         this.rBHabiles.AutoSize = true;
         this.rBHabiles.Location = new System.Drawing.Point(19, 81);
         this.rBHabiles.Name = "rBHabiles";
         this.rBHabiles.Size = new System.Drawing.Size(107, 17);
         this.rBHabiles.TabIndex = 15;
         this.rBHabiles.TabStop = true;
         this.rBHabiles.Text = "Lunes a sabado  ";
         this.rBHabiles.UseVisualStyleBackColor = true;
         // 
         // rBEspeciales
         // 
         this.rBEspeciales.AutoSize = true;
         this.rBEspeciales.Location = new System.Drawing.Point(19, 49);
         this.rBEspeciales.Name = "rBEspeciales";
         this.rBEspeciales.Size = new System.Drawing.Size(111, 17);
         this.rBEspeciales.TabIndex = 16;
         this.rBEspeciales.TabStop = true;
         this.rBEspeciales.Text = "Domingo o feriado";
         this.rBEspeciales.UseVisualStyleBackColor = true;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(6, 16);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(23, 13);
         this.label7.TabIndex = 6;
         this.label7.Text = "Dia";
         // 
         // txtDias
         // 
         this.txtDias.Location = new System.Drawing.Point(35, 13);
         this.txtDias.Name = "txtDias";
         this.txtDias.Size = new System.Drawing.Size(124, 20);
         this.txtDias.TabIndex = 13;
         // 
         // numPaquetesA
         // 
         this.numPaquetesA.Location = new System.Drawing.Point(135, 217);
         this.numPaquetesA.Name = "numPaquetesA";
         this.numPaquetesA.Size = new System.Drawing.Size(65, 20);
         this.numPaquetesA.TabIndex = 12;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(15, 224);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(82, 13);
         this.label5.TabIndex = 10;
         this.label5.Text = "Paquetes tipo A";
         // 
         // txtPatente
         // 
         this.txtPatente.Location = new System.Drawing.Point(65, 142);
         this.txtPatente.Name = "txtPatente";
         this.txtPatente.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.txtPatente.Size = new System.Drawing.Size(141, 20);
         this.txtPatente.TabIndex = 7;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(15, 145);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(44, 13);
         this.label3.TabIndex = 6;
         this.label3.Text = "Patente";
         // 
         // btnAgregar
         // 
         this.btnAgregar.Location = new System.Drawing.Point(273, 280);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(149, 49);
         this.btnAgregar.TabIndex = 5;
         this.btnAgregar.Text = "Agregar vehiculo";
         this.btnAgregar.UseVisualStyleBackColor = true;
         this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(818, 434);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
         this.Text = "Form1";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numPaquetesC)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numPaquetesB)).EndInit();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numHr)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numPaquetesA)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBCamion;
        private System.Windows.Forms.RadioButton rBFurgon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lBMultados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rBHabiles;
        private System.Windows.Forms.RadioButton rBEspeciales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.NumericUpDown numPaquetesA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVerLista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numHr;
        private System.Windows.Forms.NumericUpDown numPaquetesC;
        private System.Windows.Forms.NumericUpDown numPaquetesB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label label4;
    }
}

