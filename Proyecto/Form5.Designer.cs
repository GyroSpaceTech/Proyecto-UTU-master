namespace Proyecto
{
    partial class Form5
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lsBxIntegrantesEquipo = new System.Windows.Forms.ListBox();
            this.pnlAnuncio = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tmrAnuncios = new System.Windows.Forms.Timer(this.components);
            this.cbxLenguaje = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Deportes";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(181, 111);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Equipo/Selección";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lsBxIntegrantesEquipo
            // 
            this.lsBxIntegrantesEquipo.FormattingEnabled = true;
            this.lsBxIntegrantesEquipo.Location = new System.Drawing.Point(318, 25);
            this.lsBxIntegrantesEquipo.Name = "lsBxIntegrantesEquipo";
            this.lsBxIntegrantesEquipo.Size = new System.Drawing.Size(150, 290);
            this.lsBxIntegrantesEquipo.TabIndex = 2;
            // 
            // pnlAnuncio
            // 
            this.pnlAnuncio.BackColor = System.Drawing.Color.Transparent;
            this.pnlAnuncio.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAnuncio.Location = new System.Drawing.Point(461, 0);
            this.pnlAnuncio.Name = "pnlAnuncio";
            this.pnlAnuncio.Size = new System.Drawing.Size(185, 407);
            this.pnlAnuncio.TabIndex = 5;
            this.pnlAnuncio.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAnuncio_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Shotgun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.Location = new System.Drawing.Point(36, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Shotgun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button2.Location = new System.Drawing.Point(36, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxLenguaje
            // 
            this.cbxLenguaje.AutoSize = true;
            this.cbxLenguaje.BackColor = System.Drawing.Color.Transparent;
            this.cbxLenguaje.Location = new System.Drawing.Point(304, 2);
            this.cbxLenguaje.Name = "cbxLenguaje";
            this.cbxLenguaje.Size = new System.Drawing.Size(60, 17);
            this.cbxLenguaje.TabIndex = 15;
            this.cbxLenguaje.Text = "English";
            this.cbxLenguaje.UseVisualStyleBackColor = false;
            this.cbxLenguaje.CheckedChanged += new System.EventHandler(this.cbxLenguaje_CheckedChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(646, 407);
            this.Controls.Add(this.cbxLenguaje);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlAnuncio);
            this.Controls.Add(this.lsBxIntegrantesEquipo);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox lsBxIntegrantesEquipo;
        private System.Windows.Forms.Panel pnlAnuncio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer tmrAnuncios;
        private System.Windows.Forms.CheckBox cbxLenguaje;
    }
}