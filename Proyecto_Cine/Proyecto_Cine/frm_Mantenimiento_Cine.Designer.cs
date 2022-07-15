namespace Proyecto_Cine
{
    partial class frm_Mantenimiento_Cine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Mantenimiento_Cine));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Editar = new System.Windows.Forms.ToolStripLabel();
            this.tsl_Eliminar = new System.Windows.Forms.ToolStripLabel();
            this.dgv_Cines = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cine = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cines)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsl_Editar,
            this.tsl_Eliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(560, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Nuevo";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
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
            // dgv_Cines
            // 
            this.dgv_Cines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cines.Location = new System.Drawing.Point(7, 67);
            this.dgv_Cines.Name = "dgv_Cines";
            this.dgv_Cines.ReadOnly = true;
            this.dgv_Cines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cines.Size = new System.Drawing.Size(546, 210);
            this.dgv_Cines.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cine";
            // 
            // txt_Cine
            // 
            this.txt_Cine.Location = new System.Drawing.Point(213, 35);
            this.txt_Cine.Name = "txt_Cine";
            this.txt_Cine.Size = new System.Drawing.Size(166, 20);
            this.txt_Cine.TabIndex = 5;
            this.txt_Cine.TextChanged += new System.EventHandler(this.txt_Cine_TextChanged);
            // 
            // frm_Mantenimiento_Cine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(560, 281);
            this.Controls.Add(this.txt_Cine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Cines);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Mantenimiento_Cine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento cines";
            this.Load += new System.EventHandler(this.frm_Mantenimiento_Cine_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel tsl_Editar;
        private System.Windows.Forms.ToolStripLabel tsl_Eliminar;
        private System.Windows.Forms.DataGridView dgv_Cines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cine;
    }
}