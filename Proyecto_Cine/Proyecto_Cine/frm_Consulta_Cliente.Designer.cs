namespace Proyecto_Cine
{
    partial class frm_Consulta_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Consulta_Cliente));
            this.dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Detalle = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Cliente
            // 
            this.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cliente.Location = new System.Drawing.Point(7, 57);
            this.dgv_Cliente.Name = "dgv_Cliente";
            this.dgv_Cliente.ReadOnly = true;
            this.dgv_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cliente.Size = new System.Drawing.Size(344, 150);
            this.dgv_Cliente.TabIndex = 7;
            this.dgv_Cliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Cliente_CellDoubleClick);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(255, 21);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 6;
            this.btn_Buscar.Text = "Limpiar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DNI Cliente";
            // 
            // dgv_Detalle
            // 
            this.dgv_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detalle.Location = new System.Drawing.Point(7, 237);
            this.dgv_Detalle.Name = "dgv_Detalle";
            this.dgv_Detalle.ReadOnly = true;
            this.dgv_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Detalle.Size = new System.Drawing.Size(344, 150);
            this.dgv_Detalle.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Detalle";
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Location = new System.Drawing.Point(97, 23);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(152, 20);
            this.txt_Cliente.TabIndex = 10;
            this.txt_Cliente.TextChanged += new System.EventHandler(this.txt_Cliente_TextChanged);
            // 
            // frm_Consulta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(358, 393);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Detalle);
            this.Controls.Add(this.dgv_Cliente);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Consulta_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar reserva por cliente";
            this.Load += new System.EventHandler(this.frm_Consulta_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Cliente;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Detalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Cliente;
    }
}