namespace Proyecto_Cine
{
    partial class frm_Mantenimiento_Funcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Mantenimiento_Funcion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Funciones = new System.Windows.Forms.DataGridView();
            this.cbo_Pelicula = new System.Windows.Forms.ComboBox();
            this.btn_reload = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funciones)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(560, 25);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Nuevo";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel2.Text = "Editar";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel3.Text = "Eliminar";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Película";
            // 
            // dgv_Funciones
            // 
            this.dgv_Funciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Funciones.Location = new System.Drawing.Point(7, 69);
            this.dgv_Funciones.Name = "dgv_Funciones";
            this.dgv_Funciones.ReadOnly = true;
            this.dgv_Funciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Funciones.Size = new System.Drawing.Size(547, 210);
            this.dgv_Funciones.TabIndex = 18;
            this.dgv_Funciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Funciones_CellClick);
            // 
            // cbo_Pelicula
            // 
            this.cbo_Pelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Pelicula.FormattingEnabled = true;
            this.cbo_Pelicula.Location = new System.Drawing.Point(219, 36);
            this.cbo_Pelicula.MaxDropDownItems = 99;
            this.cbo_Pelicula.Name = "cbo_Pelicula";
            this.cbo_Pelicula.Size = new System.Drawing.Size(166, 21);
            this.cbo_Pelicula.TabIndex = 22;
            this.cbo_Pelicula.SelectionChangeCommitted += new System.EventHandler(this.cbo_Pelicula_SelectionChangeCommitted);
            // 
            // btn_reload
            // 
            this.btn_reload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reload.BackgroundImage")));
            this.btn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reload.Location = new System.Drawing.Point(391, 36);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(22, 21);
            this.btn_reload.TabIndex = 23;
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // frm_Mantenimiento_Funcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(560, 281);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.cbo_Pelicula);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Funciones);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Mantenimiento_Funcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Función";
            this.Load += new System.EventHandler(this.frm_Mantenimiento_Funcion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Funciones;
        private System.Windows.Forms.ComboBox cbo_Pelicula;
        private System.Windows.Forms.Button btn_reload;
    }
}