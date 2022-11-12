
namespace Proyecto
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnlAnuncio1 = new System.Windows.Forms.Panel();
            this.lblAnuncio = new System.Windows.Forms.Label();
            this.pnlAnuncio = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tmrAnuncios = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.CBDeporte = new System.Windows.Forms.ComboBox();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.lstBxTimempoBron = new System.Windows.Forms.ListBox();
            this.lstBxTiempoPlata = new System.Windows.Forms.ListBox();
            this.lstBxTiempoOro = new System.Windows.Forms.ListBox();
            this.lstBxSet2 = new System.Windows.Forms.ListBox();
            this.lstBxSetE1 = new System.Windows.Forms.ListBox();
            this.lstBxPuntoE2 = new System.Windows.Forms.ListBox();
            this.lstBxPuntoE1 = new System.Windows.Forms.ListBox();
            this.lstBxE2 = new System.Windows.Forms.ListBox();
            this.lstBxE1 = new System.Windows.Forms.ListBox();
            this.lstBxEvento = new System.Windows.Forms.ListBox();
            this.lstBxResultados = new System.Windows.Forms.ListBox();
            this.cbxLenguaje = new System.Windows.Forms.CheckBox();
            this.pnlAnuncio1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pnlResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAnuncio1
            // 
            this.pnlAnuncio1.BackColor = System.Drawing.Color.Transparent;
            this.pnlAnuncio1.Controls.Add(this.lblAnuncio);
            this.pnlAnuncio1.Location = new System.Drawing.Point(639, 9);
            this.pnlAnuncio1.Name = "pnlAnuncio1";
            this.pnlAnuncio1.Size = new System.Drawing.Size(185, 429);
            this.pnlAnuncio1.TabIndex = 4;
            this.pnlAnuncio1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAnuncio1_Paint);
            // 
            // lblAnuncio
            // 
            this.lblAnuncio.AutoSize = true;
            this.lblAnuncio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnuncio.Location = new System.Drawing.Point(0, 0);
            this.lblAnuncio.Name = "lblAnuncio";
            this.lblAnuncio.Size = new System.Drawing.Size(0, 13);
            this.lblAnuncio.TabIndex = 0;
            // 
            // pnlAnuncio
            // 
            this.pnlAnuncio.BackColor = System.Drawing.Color.Transparent;
            this.pnlAnuncio.Location = new System.Drawing.Point(12, 12);
            this.pnlAnuncio.Name = "pnlAnuncio";
            this.pnlAnuncio.Size = new System.Drawing.Size(185, 429);
            this.pnlAnuncio.TabIndex = 4;
            // 
            // tmrAnuncios
            // 
            this.tmrAnuncios.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Shotgun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.Location = new System.Drawing.Point(297, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBDeporte
            // 
            this.CBDeporte.FormattingEnabled = true;
            this.CBDeporte.Location = new System.Drawing.Point(313, 519);
            this.CBDeporte.Name = "CBDeporte";
            this.CBDeporte.Size = new System.Drawing.Size(152, 21);
            this.CBDeporte.TabIndex = 13;
            this.CBDeporte.SelectedIndexChanged += new System.EventHandler(this.CBDeporte_SelectedIndexChanged);
            // 
            // pnlResultados
            // 
            this.pnlResultados.BackColor = System.Drawing.Color.Transparent;
            this.pnlResultados.Controls.Add(this.lstBxTimempoBron);
            this.pnlResultados.Controls.Add(this.lstBxTiempoPlata);
            this.pnlResultados.Controls.Add(this.lstBxTiempoOro);
            this.pnlResultados.Controls.Add(this.lstBxSet2);
            this.pnlResultados.Controls.Add(this.lstBxSetE1);
            this.pnlResultados.Controls.Add(this.lstBxPuntoE2);
            this.pnlResultados.Controls.Add(this.lstBxPuntoE1);
            this.pnlResultados.Controls.Add(this.lstBxE2);
            this.pnlResultados.Controls.Add(this.lstBxE1);
            this.pnlResultados.Controls.Add(this.lstBxEvento);
            this.pnlResultados.Controls.Add(this.lstBxResultados);
            this.pnlResultados.Location = new System.Drawing.Point(203, 15);
            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.Size = new System.Drawing.Size(701, 370);
            this.pnlResultados.TabIndex = 16;
            this.pnlResultados.Visible = false;
            this.pnlResultados.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lstBxTimempoBron
            // 
            this.lstBxTimempoBron.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstBxTimempoBron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBxTimempoBron.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBxTimempoBron.FormattingEnabled = true;
            this.lstBxTimempoBron.Location = new System.Drawing.Point(559, 0);
            this.lstBxTimempoBron.Name = "lstBxTimempoBron";
            this.lstBxTimempoBron.Size = new System.Drawing.Size(41, 370);
            this.lstBxTimempoBron.TabIndex = 10;
            // 
            // lstBxTiempoPlata
            // 
            this.lstBxTiempoPlata.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstBxTiempoPlata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBxTiempoPlata.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBxTiempoPlata.FormattingEnabled = true;
            this.lstBxTiempoPlata.Location = new System.Drawing.Point(518, 0);
            this.lstBxTiempoPlata.Name = "lstBxTiempoPlata";
            this.lstBxTiempoPlata.Size = new System.Drawing.Size(41, 370);
            this.lstBxTiempoPlata.TabIndex = 9;
            // 
            // lstBxTiempoOro
            // 
            this.lstBxTiempoOro.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstBxTiempoOro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBxTiempoOro.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBxTiempoOro.FormattingEnabled = true;
            this.lstBxTiempoOro.Location = new System.Drawing.Point(477, 0);
            this.lstBxTiempoOro.Name = "lstBxTiempoOro";
            this.lstBxTiempoOro.Size = new System.Drawing.Size(41, 370);
            this.lstBxTiempoOro.TabIndex = 8;
            // 
            // lstBxSet2
            // 
            this.lstBxSet2.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstBxSet2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBxSet2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBxSet2.FormattingEnabled = true;
            this.lstBxSet2.Location = new System.Drawing.Point(452, 0);
            this.lstBxSet2.Name = "lstBxSet2";
            this.lstBxSet2.Size = new System.Drawing.Size(25, 370);
            this.lstBxSet2.TabIndex = 7;
            this.lstBxSet2.Visible = false;
            // 
            // lstBxSetE1
            // 
            this.lstBxSetE1.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstBxSetE1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBxSetE1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBxSetE1.FormattingEnabled = true;
            this.lstBxSetE1.Location = new System.Drawing.Point(424, 0);
            this.lstBxSetE1.Name = "lstBxSetE1";
            this.lstBxSetE1.Size = new System.Drawing.Size(28, 370);
            this.lstBxSetE1.TabIndex = 6;
            // 
            // lstBxPuntoE2
            // 
            this.lstBxPuntoE2.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstBxPuntoE2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBxPuntoE2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBxPuntoE2.FormattingEnabled = true;
            this.lstBxPuntoE2.Location = new System.Drawing.Point(403, 0);
            this.lstBxPuntoE2.Name = "lstBxPuntoE2";
            this.lstBxPuntoE2.Size = new System.Drawing.Size(21, 370);
            this.lstBxPuntoE2.TabIndex = 5;
            // 
            // lstBxPuntoE1
            // 
            this.lstBxPuntoE1.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstBxPuntoE1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBxPuntoE1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBxPuntoE1.FormattingEnabled = true;
            this.lstBxPuntoE1.Location = new System.Drawing.Point(378, 0);
            this.lstBxPuntoE1.Name = "lstBxPuntoE1";
            this.lstBxPuntoE1.Size = new System.Drawing.Size(25, 370);
            this.lstBxPuntoE1.TabIndex = 4;
            // 
            // lstBxE2
            // 
            this.lstBxE2.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstBxE2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBxE2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBxE2.FormattingEnabled = true;
            this.lstBxE2.Location = new System.Drawing.Point(274, 0);
            this.lstBxE2.Name = "lstBxE2";
            this.lstBxE2.Size = new System.Drawing.Size(104, 370);
            this.lstBxE2.TabIndex = 3;
            // 
            // lstBxE1
            // 
            this.lstBxE1.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstBxE1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBxE1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBxE1.FormattingEnabled = true;
            this.lstBxE1.Location = new System.Drawing.Point(160, 0);
            this.lstBxE1.Name = "lstBxE1";
            this.lstBxE1.Size = new System.Drawing.Size(114, 370);
            this.lstBxE1.TabIndex = 2;
            // 
            // lstBxEvento
            // 
            this.lstBxEvento.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstBxEvento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBxEvento.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBxEvento.FormattingEnabled = true;
            this.lstBxEvento.Location = new System.Drawing.Point(39, 0);
            this.lstBxEvento.Name = "lstBxEvento";
            this.lstBxEvento.Size = new System.Drawing.Size(121, 370);
            this.lstBxEvento.TabIndex = 1;
            // 
            // lstBxResultados
            // 
            this.lstBxResultados.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstBxResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBxResultados.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBxResultados.FormattingEnabled = true;
            this.lstBxResultados.Location = new System.Drawing.Point(0, 0);
            this.lstBxResultados.Name = "lstBxResultados";
            this.lstBxResultados.Size = new System.Drawing.Size(39, 370);
            this.lstBxResultados.TabIndex = 0;
            // 
            // cbxLenguaje
            // 
            this.cbxLenguaje.AutoSize = true;
            this.cbxLenguaje.BackColor = System.Drawing.Color.Transparent;
            this.cbxLenguaje.Location = new System.Drawing.Point(417, 463);
            this.cbxLenguaje.Name = "cbxLenguaje";
            this.cbxLenguaje.Size = new System.Drawing.Size(60, 17);
            this.cbxLenguaje.TabIndex = 17;
            this.cbxLenguaje.Text = "English";
            this.cbxLenguaje.UseVisualStyleBackColor = false;
            this.cbxLenguaje.CheckedChanged += new System.EventHandler(this.cbxLenguaje_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(831, 586);
            this.ControlBox = false;
            this.Controls.Add(this.cbxLenguaje);
            this.Controls.Add(this.CBDeporte);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlAnuncio);
            this.Controls.Add(this.pnlAnuncio1);
            this.Controls.Add(this.pnlResultados);
            this.Name = "Form2";
            this.Text = "CorePoint: Eventos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlAnuncio1.ResumeLayout(false);
            this.pnlAnuncio1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pnlResultados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlAnuncio1;
        private System.Windows.Forms.Panel pnlAnuncio;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer tmrAnuncios;
        private System.Windows.Forms.Label lblAnuncio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CBDeporte;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.ListBox lstBxSet2;
        private System.Windows.Forms.ListBox lstBxSetE1;
        private System.Windows.Forms.ListBox lstBxPuntoE2;
        private System.Windows.Forms.ListBox lstBxPuntoE1;
        private System.Windows.Forms.ListBox lstBxE2;
        private System.Windows.Forms.ListBox lstBxE1;
        private System.Windows.Forms.ListBox lstBxEvento;
        private System.Windows.Forms.ListBox lstBxResultados;
        private System.Windows.Forms.ListBox lstBxTimempoBron;
        private System.Windows.Forms.ListBox lstBxTiempoPlata;
        private System.Windows.Forms.ListBox lstBxTiempoOro;
        private System.Windows.Forms.CheckBox cbxLenguaje;
    }
}