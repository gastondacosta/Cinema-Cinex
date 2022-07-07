namespace Proyecto_Cine
{
    partial class frm_PopUp_Reserva_BuscarEmpleado
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
            this.txt_ApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Empleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ApellidoEmpleado
            // 
            this.txt_ApellidoEmpleado.Location = new System.Drawing.Point(114, 14);
            this.txt_ApellidoEmpleado.Name = "txt_ApellidoEmpleado";
            this.txt_ApellidoEmpleado.Size = new System.Drawing.Size(125, 20);
            this.txt_ApellidoEmpleado.TabIndex = 3;
            this.txt_ApellidoEmpleado.TextChanged += new System.EventHandler(this.txt_ApellidoEmpleado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido";
            // 
            // dgv_Empleados
            // 
            this.dgv_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empleados.Location = new System.Drawing.Point(7, 44);
            this.dgv_Empleados.Name = "dgv_Empleados";
            this.dgv_Empleados.ReadOnly = true;
            this.dgv_Empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Empleados.Size = new System.Drawing.Size(306, 150);
            this.dgv_Empleados.TabIndex = 18;
            this.dgv_Empleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Empleados_CellDoubleClick);
            // 
            // frm_PopUp_Reserva_BuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(321, 203);
            this.Controls.Add(this.dgv_Empleados);
            this.Controls.Add(this.txt_ApellidoEmpleado);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PopUp_Reserva_BuscarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PopUp_Reserva_BuscarEmpleado";
            this.Load += new System.EventHandler(this.frm_PopUp_Reserva_BuscarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ApellidoEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Empleados;
    }
}