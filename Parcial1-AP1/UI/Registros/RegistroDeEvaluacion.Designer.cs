namespace Parcial1_AP1.UI.Registros
{
    partial class RegistroDeEvaluacion
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
            this.components = new System.ComponentModel.Container();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EstudiantetextBox = new System.Windows.Forms.TextBox();
            this.CalificacionGroupBox = new System.Windows.Forms.GroupBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValortextBox = new System.Windows.Forms.TextBox();
            this.LogradotextBox = new System.Windows.Forms.TextBox();
            this.PerdidotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PronosticocomboBox = new System.Windows.Forms.ComboBox();
            this.PronosticogroupBox = new System.Windows.Forms.GroupBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            this.CalificacionGroupBox.SuspendLayout();
            this.PronosticogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(66, 10);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.IDnumericUpDown.TabIndex = 0;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(259, 9);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(149, 20);
            this.FechadateTimePicker.TabIndex = 1;
            // 
            // EstudiantetextBox
            // 
            this.EstudiantetextBox.Location = new System.Drawing.Point(111, 43);
            this.EstudiantetextBox.Name = "EstudiantetextBox";
            this.EstudiantetextBox.Size = new System.Drawing.Size(297, 20);
            this.EstudiantetextBox.TabIndex = 2;
            // 
            // CalificacionGroupBox
            // 
            this.CalificacionGroupBox.Controls.Add(this.label3);
            this.CalificacionGroupBox.Controls.Add(this.ValortextBox);
            this.CalificacionGroupBox.Controls.Add(this.LogradotextBox);
            this.CalificacionGroupBox.Controls.Add(this.label4);
            this.CalificacionGroupBox.Controls.Add(this.label5);
            this.CalificacionGroupBox.Controls.Add(this.PerdidotextBox);
            this.CalificacionGroupBox.Location = new System.Drawing.Point(48, 78);
            this.CalificacionGroupBox.Name = "CalificacionGroupBox";
            this.CalificacionGroupBox.Size = new System.Drawing.Size(360, 88);
            this.CalificacionGroupBox.TabIndex = 3;
            this.CalificacionGroupBox.TabStop = false;
            this.CalificacionGroupBox.Text = "Calificacion Tarea y Parcial";
            this.CalificacionGroupBox.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(45, 9);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(21, 13);
            this.IDlabel.TabIndex = 4;
            this.IDlabel.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estudiante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha:";
            // 
            // ValortextBox
            // 
            this.ValortextBox.Location = new System.Drawing.Point(6, 36);
            this.ValortextBox.Name = "ValortextBox";
            this.ValortextBox.Size = new System.Drawing.Size(82, 20);
            this.ValortextBox.TabIndex = 0;
            // 
            // LogradotextBox
            // 
            this.LogradotextBox.Location = new System.Drawing.Point(138, 36);
            this.LogradotextBox.Name = "LogradotextBox";
            this.LogradotextBox.Size = new System.Drawing.Size(82, 20);
            this.LogradotextBox.TabIndex = 7;
            // 
            // PerdidotextBox
            // 
            this.PerdidotextBox.Location = new System.Drawing.Point(272, 36);
            this.PerdidotextBox.Name = "PerdidotextBox";
            this.PerdidotextBox.Size = new System.Drawing.Size(82, 20);
            this.PerdidotextBox.TabIndex = 8;
            this.PerdidotextBox.TextChanged += new System.EventHandler(this.PerdidotextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Logrado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Perdido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pronostico";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // PronosticocomboBox
            // 
            this.PronosticocomboBox.FormattingEnabled = true;
            this.PronosticocomboBox.Items.AddRange(new object[] {
            "Continua",
            "Suspenso",
            "Retirar"});
            this.PronosticocomboBox.Location = new System.Drawing.Point(40, 32);
            this.PronosticocomboBox.Name = "PronosticocomboBox";
            this.PronosticocomboBox.Size = new System.Drawing.Size(297, 21);
            this.PronosticocomboBox.TabIndex = 15;
            // 
            // PronosticogroupBox
            // 
            this.PronosticogroupBox.Controls.Add(this.PronosticocomboBox);
            this.PronosticogroupBox.Controls.Add(this.label6);
            this.PronosticogroupBox.Location = new System.Drawing.Point(48, 184);
            this.PronosticogroupBox.Name = "PronosticogroupBox";
            this.PronosticogroupBox.Size = new System.Drawing.Size(360, 70);
            this.PronosticogroupBox.TabIndex = 16;
            this.PronosticogroupBox.TabStop = false;
            this.PronosticogroupBox.Text = "Como vas deberias:";
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(186, 260);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 35);
            this.Guardarbutton.TabIndex = 17;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(48, 260);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 36);
            this.Nuevobutton.TabIndex = 18;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(333, 260);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 35);
            this.Eliminarbutton.TabIndex = 19;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Parcial1_AP1.Properties.Resources.icons8_borrar_búsqueda_24;
            this.Buscarbutton.Location = new System.Drawing.Point(157, 10);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(50, 23);
            this.Buscarbutton.TabIndex = 20;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RegistroDeEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 313);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.PronosticogroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.CalificacionGroupBox);
            this.Controls.Add(this.EstudiantetextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.IDnumericUpDown);
            this.Name = "RegistroDeEvaluacion";
            this.Text = "RegistroDeEvaluacion";
            this.Load += new System.EventHandler(this.RegistroDeEvaluacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            this.CalificacionGroupBox.ResumeLayout(false);
            this.CalificacionGroupBox.PerformLayout();
            this.PronosticogroupBox.ResumeLayout(false);
            this.PronosticogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox EstudiantetextBox;
        private System.Windows.Forms.GroupBox CalificacionGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValortextBox;
        private System.Windows.Forms.TextBox LogradotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PerdidotextBox;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PronosticocomboBox;
        private System.Windows.Forms.GroupBox PronosticogroupBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
    }
}