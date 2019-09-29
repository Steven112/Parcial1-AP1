namespace Parcial1_AP1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.evaluacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroEvaluacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaEvaluacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evaluacionToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // evaluacionToolStripMenuItem
            // 
            this.evaluacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroEvaluacionToolStripMenuItem});
            this.evaluacionToolStripMenuItem.Name = "evaluacionToolStripMenuItem";
            this.evaluacionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.evaluacionToolStripMenuItem.Text = "Registros";
            // 
            // registroEvaluacionToolStripMenuItem
            // 
            this.registroEvaluacionToolStripMenuItem.Name = "registroEvaluacionToolStripMenuItem";
            this.registroEvaluacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroEvaluacionToolStripMenuItem.Text = "Registro Evaluacion";
            this.registroEvaluacionToolStripMenuItem.Click += new System.EventHandler(this.RegistroEvaluacionToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaEvaluacionToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaEvaluacionToolStripMenuItem
            // 
            this.consultaEvaluacionToolStripMenuItem.Name = "consultaEvaluacionToolStripMenuItem";
            this.consultaEvaluacionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultaEvaluacionToolStripMenuItem.Text = "Consulta Evaluacion";
            this.consultaEvaluacionToolStripMenuItem.Click += new System.EventHandler(this.ConsultaEvaluacionToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 253);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem evaluacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroEvaluacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaEvaluacionToolStripMenuItem;
    }
}

