namespace Proyecto
{
    partial class Form4
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
            this.tmrAnuncios = new System.Windows.Forms.Timer(this.components);
            this.pnlAnuncio2 = new System.Windows.Forms.Panel();
            this.pnlAnuncio1 = new System.Windows.Forms.Panel();
            this.ChkdDeportes = new System.Windows.Forms.CheckedListBox();
            this.ChkdEventos = new System.Windows.Forms.CheckedListBox();
            this.ChkdEquipos = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblEquipos = new System.Windows.Forms.Label();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlAnuncio2
            // 
            this.pnlAnuncio2.BackColor = System.Drawing.Color.Transparent;
            this.pnlAnuncio2.Location = new System.Drawing.Point(12, 21);
            this.pnlAnuncio2.Name = "pnlAnuncio2";
            this.pnlAnuncio2.Size = new System.Drawing.Size(185, 429);
            this.pnlAnuncio2.TabIndex = 3;
            // 
            // pnlAnuncio1
            // 
            this.pnlAnuncio1.BackColor = System.Drawing.Color.Transparent;
            this.pnlAnuncio1.Location = new System.Drawing.Point(603, 21);
            this.pnlAnuncio1.Name = "pnlAnuncio1";
            this.pnlAnuncio1.Size = new System.Drawing.Size(185, 429);
            this.pnlAnuncio1.TabIndex = 4;
            // 
            // ChkdDeportes
            // 
            this.ChkdDeportes.BackColor = System.Drawing.Color.Gainsboro;
            this.ChkdDeportes.FormattingEnabled = true;
            this.ChkdDeportes.Location = new System.Drawing.Point(220, 36);
            this.ChkdDeportes.Name = "ChkdDeportes";
            this.ChkdDeportes.Size = new System.Drawing.Size(106, 409);
            this.ChkdDeportes.TabIndex = 5;
            // 
            // ChkdEventos
            // 
            this.ChkdEventos.BackColor = System.Drawing.Color.Gainsboro;
            this.ChkdEventos.FormattingEnabled = true;
            this.ChkdEventos.Location = new System.Drawing.Point(344, 36);
            this.ChkdEventos.Name = "ChkdEventos";
            this.ChkdEventos.Size = new System.Drawing.Size(106, 409);
            this.ChkdEventos.TabIndex = 6;
            // 
            // ChkdEquipos
            // 
            this.ChkdEquipos.BackColor = System.Drawing.Color.Gainsboro;
            this.ChkdEquipos.FormattingEnabled = true;
            this.ChkdEquipos.Location = new System.Drawing.Point(476, 36);
            this.ChkdEquipos.Name = "ChkdEquipos";
            this.ChkdEquipos.Size = new System.Drawing.Size(106, 409);
            this.ChkdEquipos.TabIndex = 7;
            this.ChkdEquipos.SelectedIndexChanged += new System.EventHandler(this.ChkdEquipos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Shotgun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(216, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Deportes";
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.BackColor = System.Drawing.Color.Transparent;
            this.lblEvento.Font = new System.Drawing.Font("Shotgun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblEvento.Location = new System.Drawing.Point(351, 7);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(88, 20);
            this.lblEvento.TabIndex = 9;
            this.lblEvento.Text = "Evento";
            // 
            // lblEquipos
            // 
            this.lblEquipos.AutoSize = true;
            this.lblEquipos.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipos.Font = new System.Drawing.Font("Shotgun", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipos.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblEquipos.Location = new System.Drawing.Point(476, 7);
            this.lblEquipos.Name = "lblEquipos";
            this.lblEquipos.Size = new System.Drawing.Size(101, 21);
            this.lblEquipos.TabIndex = 10;
            this.lblEquipos.Text = "Equipos";
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Location = new System.Drawing.Point(381, 463);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(35, 13);
            this.lblGuardar.TabIndex = 11;
            this.lblGuardar.Text = "label2";
            this.lblGuardar.Click += new System.EventHandler(this.lblGuardar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.lblGuardar);
            this.Controls.Add(this.lblEquipos);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChkdEquipos);
            this.Controls.Add(this.ChkdEventos);
            this.Controls.Add(this.ChkdDeportes);
            this.Controls.Add(this.pnlAnuncio1);
            this.Controls.Add(this.pnlAnuncio2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrAnuncios;
        private System.Windows.Forms.Panel pnlAnuncio2;
        private System.Windows.Forms.Panel pnlAnuncio1;
        private System.Windows.Forms.CheckedListBox ChkdDeportes;
        private System.Windows.Forms.CheckedListBox ChkdEventos;
        private System.Windows.Forms.CheckedListBox ChkdEquipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblEquipos;
        private System.Windows.Forms.Label lblGuardar;
    }
}