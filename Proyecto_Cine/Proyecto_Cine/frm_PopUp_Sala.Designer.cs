namespace Proyecto_Cine
{
    partial class frm_PopUp_Sala
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
            this.lbl_Subtitulo = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Cine = new System.Windows.Forms.ComboBox();
            this.nud_Butacas = new System.Windows.Forms.NumericUpDown();
            this.nud_Filas = new System.Windows.Forms.NumericUpDown();
            this.nud_Columnas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_idsala = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Butacas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Filas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Columnas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Subtitulo
            // 
            this.lbl_Subtitulo.AutoSize = true;
            this.lbl_Subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtitulo.Location = new System.Drawing.Point(99, 13);
            this.lbl_Subtitulo.Name = "lbl_Subtitulo";
            this.lbl_Subtitulo.Size = new System.Drawing.Size(0, 17);
            this.lbl_Subtitulo.TabIndex = 26;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(162, 217);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 25;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Aceptar.Location = new System.Drawing.Point(51, 217);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 24;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Número de columnas(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Número de filas(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Número de butacas(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cine";
            // 
            // cbo_Cine
            // 
            this.cbo_Cine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Cine.FormattingEnabled = true;
            this.cbo_Cine.Location = new System.Drawing.Point(136, 79);
            this.cbo_Cine.Name = "cbo_Cine";
            this.cbo_Cine.Size = new System.Drawing.Size(148, 21);
            this.cbo_Cine.TabIndex = 27;
            this.cbo_Cine.SelectedIndexChanged += new System.EventHandler(this.cbo_Cine_SelectedIndexChanged);
            this.cbo_Cine.SelectionChangeCommitted += new System.EventHandler(this.cbo_Cine_SelectionChangeCommitted);
            this.cbo_Cine.SelectedValueChanged += new System.EventHandler(this.cbo_Cine_SelectedValueChanged);
            // 
            // nud_Butacas
            // 
            this.nud_Butacas.Location = new System.Drawing.Point(136, 113);
            this.nud_Butacas.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nud_Butacas.Name = "nud_Butacas";
            this.nud_Butacas.Size = new System.Drawing.Size(148, 20);
            this.nud_Butacas.TabIndex = 28;
            // 
            // nud_Filas
            // 
            this.nud_Filas.Location = new System.Drawing.Point(136, 146);
            this.nud_Filas.Name = "nud_Filas";
            this.nud_Filas.Size = new System.Drawing.Size(148, 20);
            this.nud_Filas.TabIndex = 29;
            // 
            // nud_Columnas
            // 
            this.nud_Columnas.Location = new System.Drawing.Point(136, 178);
            this.nud_Columnas.Name = "nud_Columnas";
            this.nud_Columnas.Size = new System.Drawing.Size(148, 20);
            this.nud_Columnas.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "ID Sala";
            // 
            // txt_idsala
            // 
            this.txt_idsala.Location = new System.Drawing.Point(136, 46);
            this.txt_idsala.Name = "txt_idsala";
            this.txt_idsala.ReadOnly = true;
            this.txt_idsala.Size = new System.Drawing.Size(148, 20);
            this.txt_idsala.TabIndex = 33;
            // 
            // frm_PopUp_Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(301, 255);
            this.Controls.Add(this.txt_idsala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nud_Columnas);
            this.Controls.Add(this.nud_Filas);
            this.Controls.Add(this.nud_Butacas);
            this.Controls.Add(this.cbo_Cine);
            this.Controls.Add(this.lbl_Subtitulo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PopUp_Sala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PopUp_Sala";
            this.Load += new System.EventHandler(this.frm_PopUp_Sala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Butacas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Filas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Columnas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Subtitulo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Cine;
        private System.Windows.Forms.NumericUpDown nud_Butacas;
        private System.Windows.Forms.NumericUpDown nud_Filas;
        private System.Windows.Forms.NumericUpDown nud_Columnas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_idsala;
    }
}