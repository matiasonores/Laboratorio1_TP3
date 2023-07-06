namespace Ejercicio_2
{
    partial class RondasModal
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
            this.lbPodio = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelGanadores = new System.Windows.Forms.Label();
            this.labelRonda = new System.Windows.Forms.Label();
            this.btnSalirRondas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPodio
            // 
            this.lbPodio.FormattingEnabled = true;
            this.lbPodio.ItemHeight = 15;
            this.lbPodio.Location = new System.Drawing.Point(259, 88);
            this.lbPodio.Name = "lbPodio";
            this.lbPodio.Size = new System.Drawing.Size(482, 124);
            this.lbPodio.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Comenzar Ronda: 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ronda: ";
            // 
            // LabelGanadores
            // 
            this.LabelGanadores.AutoSize = true;
            this.LabelGanadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelGanadores.Location = new System.Drawing.Point(259, 48);
            this.LabelGanadores.Name = "LabelGanadores";
            this.LabelGanadores.Size = new System.Drawing.Size(144, 21);
            this.LabelGanadores.TabIndex = 3;
            this.LabelGanadores.Text = "Ganadores Ronda";
            // 
            // labelRonda
            // 
            this.labelRonda.AutoSize = true;
            this.labelRonda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRonda.Location = new System.Drawing.Point(97, 61);
            this.labelRonda.Name = "labelRonda";
            this.labelRonda.Size = new System.Drawing.Size(19, 21);
            this.labelRonda.TabIndex = 4;
            this.labelRonda.Text = "0";
            // 
            // btnSalirRondas
            // 
            this.btnSalirRondas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalirRondas.Enabled = false;
            this.btnSalirRondas.Location = new System.Drawing.Point(44, 179);
            this.btnSalirRondas.Name = "btnSalirRondas";
            this.btnSalirRondas.Size = new System.Drawing.Size(156, 33);
            this.btnSalirRondas.TabIndex = 5;
            this.btnSalirRondas.Text = "Salir";
            this.btnSalirRondas.UseVisualStyleBackColor = true;
            // 
            // RondasModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 239);
            this.Controls.Add(this.btnSalirRondas);
            this.Controls.Add(this.labelRonda);
            this.Controls.Add(this.LabelGanadores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbPodio);
            this.Name = "RondasModal";
            this.Text = "RondasModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ListBox listBox1;
        private Button button1;
        private Label label1;
        private Label LabelGanadores;
        public Label labelRonda;
        public ListBox lbPodio;
        private Button btnSalirRondas;
    }
}