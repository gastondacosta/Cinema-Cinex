namespace Proyecto_Cine
{
    partial class frm_Mantenimiento_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Mantenimiento_Cliente));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsl_Nuevo = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Editar = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Eliminar = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_Nuevo,
            this.tsl_Editar,
            this.tsl_Eliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(565, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsl_Nuevo
            // 
            this.tsl_Nuevo.Name = "tsl_Nuevo";
            this.tsl_Nuevo.Size = new System.Drawing.Size(42, 22);
            this.tsl_Nuevo.Text = "Nuevo";
            this.tsl_Nuevo.Click += new System.EventHandler(this.tsl_Nuevo_Click);
            // 
            // tsl_Editar
            // 
            this.tsl_Editar.Name = "tsl_Editar";
            this.tsl_Editar.Size = new System.Drawing.Size(37, 22);
            this.tsl_Editar.Text = "Editar";
            this.tsl_Editar.Click += new System.EventHandler(this.tsl_Editar_Click);
            // 
            // tsl_Eliminar
            // 
            this.tsl_Eliminar.Name = "tsl_Eliminar";
            this.tsl_Eliminar.Size = new System.Drawing.Size(50, 22);
            this.tsl_Eliminar.Text = "Eliminar";
            this.tsl_Eliminar.Click += new System.EventHandler(this.tsl_Eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI";
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(216, 28);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(166, 20);
            this.txt_Dni.TabIndex = 2;
            this.txt_Dni.TextChanged += new System.EventHandler(this.txt_Dni_TextChanged);
            this.txt_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dni_KeyPress);
            // 
            // dgv_Cliente
            // 
            this.dgv_Cliente.AllowUserToAddRows = false;
            this.dgv_Cliente.AllowUserToDeleteRows = false;
            this.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cliente.Location = new System.Drawing.Point(12, 53);
            this.dgv_Cliente.Name = "dgv_Cliente";
            this.dgv_Cliente.ReadOnly = true;
            this.dgv_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cliente.Size = new System.Drawing.Size(543, 230);
            this.dgv_Cliente.TabIndex = 3;
            this.dgv_Cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Cliente_CellClick);
            // 
            // frm_Mantenimiento_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(565, 286);
            this.Controls.Add(this.dgv_Cliente);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Mantenimiento_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Cliente";
            this.Load += new System.EventHandler(this.frm_Mantenimiento_Cliente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsl_Nuevo;
        private System.Windows.Forms.ToolStripLabel tsl_Editar;
        private System.Windows.Forms.ToolStripLabel tsl_Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.DataGridView dgv_Cliente;
    }
}