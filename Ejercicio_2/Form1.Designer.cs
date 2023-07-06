namespace Ejercicio_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCompetidores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComenzarTorneo = new System.Windows.Forms.Button();
            this.btnAgregarCompetidor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEdad = new System.Windows.Forms.NumericUpDown();
            this.txtClub = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // listCompetidores
            // 
            this.listCompetidores.FormattingEnabled = true;
            this.listCompetidores.ItemHeight = 15;
            this.listCompetidores.Location = new System.Drawing.Point(469, 72);
            this.listCompetidores.Name = "listCompetidores";
            this.listCompetidores.Size = new System.Drawing.Size(310, 334);
            this.listCompetidores.TabIndex = 0;
            this.listCompetidores.SelectedIndexChanged += new System.EventHandler(this.listCompetidores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(469, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado Competidores";
            // 
            // btnComenzarTorneo
            // 
            this.btnComenzarTorneo.Location = new System.Drawing.Point(121, 312);
            this.btnComenzarTorneo.Name = "btnComenzarTorneo";
            this.btnComenzarTorneo.Size = new System.Drawing.Size(144, 48);
            this.btnComenzarTorneo.TabIndex = 2;
            this.btnComenzarTorneo.Text = "Comenzar Torneo";
            this.btnComenzarTorneo.UseVisualStyleBackColor = true;
            this.btnComenzarTorneo.Click += new System.EventHandler(this.btnComenzarTorneo_Click);
            // 
            // btnAgregarCompetidor
            // 
            this.btnAgregarCompetidor.Location = new System.Drawing.Point(87, 178);
            this.btnAgregarCompetidor.Name = "btnAgregarCompetidor";
            this.btnAgregarCompetidor.Size = new System.Drawing.Size(144, 29);
            this.btnAgregarCompetidor.TabIndex = 3;
            this.btnAgregarCompetidor.Text = "Agregar Competidor";
            this.btnAgregarCompetidor.UseVisualStyleBackColor = true;
            this.btnAgregarCompetidor.Click += new System.EventHandler(this.btnAgregarCompetidor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Club";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.txtClub);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAgregarCompetidor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 240);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Competidor";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(109, 69);
            this.txtEdad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 23);
            this.txtEdad.TabIndex = 9;
            this.txtEdad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtClub
            // 
            this.txtClub.Location = new System.Drawing.Point(109, 112);
            this.txtClub.Name = "txtClub";
            this.txtClub.Size = new System.Drawing.Size(100, 23);
            this.txtClub.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnComenzarTorneo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCompetidores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listCompetidores;
        private Label label1;
        private Button btnComenzarTorneo;
        private Button btnAgregarCompetidor;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private NumericUpDown txtEdad;
        private TextBox txtClub;
        private TextBox txtNombre;
    }
}