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
         listCompetidores = new ListBox();
         label1 = new Label();
         btnComenzarTorneo = new Button();
         btnAgregarCompetidor = new Button();
         label2 = new Label();
         label3 = new Label();
         label4 = new Label();
         groupBox1 = new GroupBox();
         txtEdad = new NumericUpDown();
         txtClub = new TextBox();
         txtNombre = new TextBox();
         groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)txtEdad).BeginInit();
         SuspendLayout();
         // 
         // listCompetidores
         // 
         listCompetidores.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
         listCompetidores.FormattingEnabled = true;
         listCompetidores.ItemHeight = 28;
         listCompetidores.Location = new Point(469, 72);
         listCompetidores.Name = "listCompetidores";
         listCompetidores.Size = new Size(310, 312);
         listCompetidores.TabIndex = 0;
         listCompetidores.SelectedIndexChanged += listCompetidores_SelectedIndexChanged;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
         label1.Location = new Point(469, 29);
         label1.Name = "label1";
         label1.Size = new Size(176, 21);
         label1.TabIndex = 1;
         label1.Text = "Listado Competidores";
         // 
         // btnComenzarTorneo
         // 
         btnComenzarTorneo.Location = new Point(121, 312);
         btnComenzarTorneo.Name = "btnComenzarTorneo";
         btnComenzarTorneo.Size = new Size(144, 48);
         btnComenzarTorneo.TabIndex = 2;
         btnComenzarTorneo.Text = "Comenzar Torneo";
         btnComenzarTorneo.UseVisualStyleBackColor = true;
         btnComenzarTorneo.Click += btnComenzarTorneo_Click;
         // 
         // btnAgregarCompetidor
         // 
         btnAgregarCompetidor.Location = new Point(87, 178);
         btnAgregarCompetidor.Name = "btnAgregarCompetidor";
         btnAgregarCompetidor.Size = new Size(144, 29);
         btnAgregarCompetidor.TabIndex = 3;
         btnAgregarCompetidor.Text = "Agregar Competidor";
         btnAgregarCompetidor.UseVisualStyleBackColor = true;
         btnAgregarCompetidor.Click += btnAgregarCompetidor_Click;
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(27, 33);
         label2.Name = "label2";
         label2.Size = new Size(51, 15);
         label2.TabIndex = 4;
         label2.Text = "Nombre";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new Point(27, 71);
         label3.Name = "label3";
         label3.Size = new Size(33, 15);
         label3.TabIndex = 5;
         label3.Text = "Edad";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Location = new Point(28, 115);
         label4.Name = "label4";
         label4.Size = new Size(32, 15);
         label4.TabIndex = 6;
         label4.Text = "Club";
         // 
         // groupBox1
         // 
         groupBox1.Controls.Add(txtEdad);
         groupBox1.Controls.Add(txtClub);
         groupBox1.Controls.Add(txtNombre);
         groupBox1.Controls.Add(label2);
         groupBox1.Controls.Add(btnAgregarCompetidor);
         groupBox1.Controls.Add(label4);
         groupBox1.Controls.Add(label3);
         groupBox1.Location = new Point(12, 29);
         groupBox1.Name = "groupBox1";
         groupBox1.Size = new Size(354, 240);
         groupBox1.TabIndex = 7;
         groupBox1.TabStop = false;
         groupBox1.Text = "Agregar Competidor";
         // 
         // txtEdad
         // 
         txtEdad.Location = new Point(109, 69);
         txtEdad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
         txtEdad.Name = "txtEdad";
         txtEdad.Size = new Size(100, 23);
         txtEdad.TabIndex = 9;
         txtEdad.Value = new decimal(new int[] { 1, 0, 0, 0 });
         // 
         // txtClub
         // 
         txtClub.Location = new Point(109, 112);
         txtClub.Name = "txtClub";
         txtClub.Size = new Size(100, 23);
         txtClub.TabIndex = 8;
         // 
         // txtNombre
         // 
         txtNombre.Location = new Point(109, 30);
         txtNombre.Name = "txtNombre";
         txtNombre.Size = new Size(100, 23);
         txtNombre.TabIndex = 7;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(791, 411);
         Controls.Add(groupBox1);
         Controls.Add(btnComenzarTorneo);
         Controls.Add(label1);
         Controls.Add(listCompetidores);
         Name = "Form1";
         Text = "Form1";
         groupBox1.ResumeLayout(false);
         groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)txtEdad).EndInit();
         ResumeLayout(false);
         PerformLayout();
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