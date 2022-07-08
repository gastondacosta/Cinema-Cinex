namespace Proyecto_Cine
{
    partial class frm_Consulta_Empleado
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
            this.cbo_Empleado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dgv_Empleado = new System.Windows.Forms.DataGridView();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.dgv_Detalle = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_Empleado
            // 
            this.cbo_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Empleado.FormattingEnabled = true;
            this.cbo_Empleado.Location = new System.Drawing.Point(70, 23);
            this.cbo_Empleado.Name = "cbo_Empleado";
            this.cbo_Empleado.Size = new System.Drawing.Size(124, 21);
            this.cbo_Empleado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleado";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(197, 22);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dgv_Empleado
            // 
            this.dgv_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empleado.Location = new System.Drawing.Point(7, 57);
            this.dgv_Empleado.Name = "dgv_Empleado";
            this.dgv_Empleado.ReadOnly = true;
            this.dgv_Empleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Empleado.Size = new System.Drawing.Size(344, 150);
            this.dgv_Empleado.TabIndex = 3;
            this.dgv_Empleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Empleado_CellDoubleClick);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(276, 22);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 4;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // dgv_Detalle
            // 
            this.dgv_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detalle.Location = new System.Drawing.Point(7, 235);
            this.dgv_Detalle.Name = "dgv_Detalle";
            this.dgv_Detalle.ReadOnly = true;
            this.dgv_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Detalle.Size = new System.Drawing.Size(344, 150);
            this.dgv_Detalle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Detalle";
            // 
            // frm_Consulta_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(358, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Detalle);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.dgv_Empleado);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Empleado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Consulta_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta reserva por empleado";
            this.Load += new System.EventHandler(this.frm_Consulta_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Empleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dgv_Empleado;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.DataGridView dgv_Detalle;
        private System.Windows.Forms.Label label2;
    }
}