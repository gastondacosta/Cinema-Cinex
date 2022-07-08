namespace Proyecto_Cine
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasPorClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.películasPorGéneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.películaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Archivo,
            this.consultasToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_Archivo
            // 
            this.tsm_Archivo.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Archivo.Image")));
            this.tsm_Archivo.Name = "tsm_Archivo";
            this.tsm_Archivo.Size = new System.Drawing.Size(76, 20);
            this.tsm_Archivo.Text = "Archivo";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem,
            this.reservasPorClientesToolStripMenuItem,
            this.películasPorGéneroToolStripMenuItem});
            this.consultasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasToolStripMenuItem.Image")));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.reservasToolStripMenuItem.Text = "Reservas por empleados";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // reservasPorClientesToolStripMenuItem
            // 
            this.reservasPorClientesToolStripMenuItem.Name = "reservasPorClientesToolStripMenuItem";
            this.reservasPorClientesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.reservasPorClientesToolStripMenuItem.Text = "Reservas por clientes";
            this.reservasPorClientesToolStripMenuItem.Click += new System.EventHandler(this.reservasPorClientesToolStripMenuItem_Click);
            // 
            // películasPorGéneroToolStripMenuItem
            // 
            this.películasPorGéneroToolStripMenuItem.Name = "películasPorGéneroToolStripMenuItem";
            this.películasPorGéneroToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.películasPorGéneroToolStripMenuItem.Text = "Películas por género";
            this.películasPorGéneroToolStripMenuItem.Click += new System.EventHandler(this.películasPorGéneroToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.cinesToolStripMenuItem,
            this.salaToolStripMenuItem,
            this.películaToolStripMenuItem,
            this.funciónToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientosToolStripMenuItem.Image")));
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // cinesToolStripMenuItem
            // 
            this.cinesToolStripMenuItem.Name = "cinesToolStripMenuItem";
            this.cinesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.cinesToolStripMenuItem.Text = "Cines";
            this.cinesToolStripMenuItem.Click += new System.EventHandler(this.cinesToolStripMenuItem_Click);
            // 
            // salaToolStripMenuItem
            // 
            this.salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            this.salaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.salaToolStripMenuItem.Text = "Sala";
            this.salaToolStripMenuItem.Click += new System.EventHandler(this.salaToolStripMenuItem_Click);
            // 
            // películaToolStripMenuItem
            // 
            this.películaToolStripMenuItem.Name = "películaToolStripMenuItem";
            this.películaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.películaToolStripMenuItem.Text = "Película";
            this.películaToolStripMenuItem.Click += new System.EventHandler(this.películaToolStripMenuItem_Click);
            // 
            // funciónToolStripMenuItem
            // 
            this.funciónToolStripMenuItem.Name = "funciónToolStripMenuItem";
            this.funciónToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.funciónToolStripMenuItem.Text = "Función";
            this.funciónToolStripMenuItem.Click += new System.EventHandler(this.funciónToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem1});
            this.procesosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("procesosToolStripMenuItem.Image")));
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reservasToolStripMenuItem1
            // 
            this.reservasToolStripMenuItem1.Name = "reservasToolStripMenuItem1";
            this.reservasToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.reservasToolStripMenuItem1.Text = "Reservas";
            this.reservasToolStripMenuItem1.Click += new System.EventHandler(this.reservasToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(739, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(739, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cine  Moviex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasPorClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem películasPorGéneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem películaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsm_Archivo;
    }
}

