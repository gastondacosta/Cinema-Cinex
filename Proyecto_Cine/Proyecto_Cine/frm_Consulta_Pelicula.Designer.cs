namespace Proyecto_Cine
{
    partial class frm_Consulta_Pelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Consulta_Pelicula));
            this.dgv_Pelicula = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_GeneroPelicula = new System.Windows.Forms.ComboBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Pelicula
            // 
            this.dgv_Pelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pelicula.Location = new System.Drawing.Point(7, 57);
            this.dgv_Pelicula.Name = "dgv_Pelicula";
            this.dgv_Pelicula.ReadOnly = true;
            this.dgv_Pelicula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Pelicula.Size = new System.Drawing.Size(528, 150);
            this.dgv_Pelicula.TabIndex = 11;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(290, 22);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 10;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Género";
            // 
            // cbo_GeneroPelicula
            // 
            this.cbo_GeneroPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_GeneroPelicula.FormattingEnabled = true;
            this.cbo_GeneroPelicula.Location = new System.Drawing.Point(149, 23);
            this.cbo_GeneroPelicula.Name = "cbo_GeneroPelicula";
            this.cbo_GeneroPelicula.Size = new System.Drawing.Size(134, 21);
            this.cbo_GeneroPelicula.TabIndex = 8;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(369, 22);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 12;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // frm_Consulta_Pelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 216);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.dgv_Pelicula);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_GeneroPelicula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Consulta_Pelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar por película";
            this.Load += new System.EventHandler(this.frm_Consulta_Pelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Pelicula;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_GeneroPelicula;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}