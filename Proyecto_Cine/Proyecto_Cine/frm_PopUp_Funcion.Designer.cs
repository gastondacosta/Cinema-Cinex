namespace Proyecto_Cine
{
    partial class frm_PopUp_Funcion
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
            this.Pelicula = new System.Windows.Forms.Label();
            this.cbo_Cine = new System.Windows.Forms.ComboBox();
            this.lbl_Subtitulo = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_horario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_Pelicula = new System.Windows.Forms.ComboBox();
            this.cbo_Sala = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.dgv_precios = new System.Windows.Forms.DataGridView();
            this.nud_Precio = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_tipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_precios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Precio)).BeginInit();
            this.SuspendLayout();
            // 
            // Pelicula
            // 
            this.Pelicula.AutoSize = true;
            this.Pelicula.Location = new System.Drawing.Point(17, 117);
            this.Pelicula.Name = "Pelicula";
            this.Pelicula.Size = new System.Drawing.Size(46, 13);
            this.Pelicula.TabIndex = 45;
            this.Pelicula.Text = "Película";
            // 
            // cbo_Cine
            // 
            this.cbo_Cine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Cine.FormattingEnabled = true;
            this.cbo_Cine.Location = new System.Drawing.Point(136, 146);
            this.cbo_Cine.Name = "cbo_Cine";
            this.cbo_Cine.Size = new System.Drawing.Size(148, 21);
            this.cbo_Cine.TabIndex = 41;
            this.cbo_Cine.SelectedIndexChanged += new System.EventHandler(this.cbo_Cine_SelectedIndexChanged);
            this.cbo_Cine.SelectionChangeCommitted += new System.EventHandler(this.cbo_Cine_SelectionChangeCommitted);
            this.cbo_Cine.SelectedValueChanged += new System.EventHandler(this.cbo_Cine_SelectedValueChanged);
            // 
            // lbl_Subtitulo
            // 
            this.lbl_Subtitulo.AutoSize = true;
            this.lbl_Subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtitulo.Location = new System.Drawing.Point(91, 14);
            this.lbl_Subtitulo.Name = "lbl_Subtitulo";
            this.lbl_Subtitulo.Size = new System.Drawing.Size(0, 17);
            this.lbl_Subtitulo.TabIndex = 40;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(162, 504);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 39;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Aceptar.Location = new System.Drawing.Point(51, 504);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 38;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Fecha de la función";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha.Location = new System.Drawing.Point(136, 51);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(148, 20);
            this.txt_fecha.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "ID Sala";
            // 
            // txt_horario
            // 
            this.txt_horario.Location = new System.Drawing.Point(136, 82);
            this.txt_horario.Name = "txt_horario";
            this.txt_horario.Size = new System.Drawing.Size(148, 20);
            this.txt_horario.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Horario";
            // 
            // cbo_Pelicula
            // 
            this.cbo_Pelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Pelicula.FormattingEnabled = true;
            this.cbo_Pelicula.Location = new System.Drawing.Point(136, 112);
            this.cbo_Pelicula.Name = "cbo_Pelicula";
            this.cbo_Pelicula.Size = new System.Drawing.Size(148, 21);
            this.cbo_Pelicula.TabIndex = 54;
            // 
            // cbo_Sala
            // 
            this.cbo_Sala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Sala.FormattingEnabled = true;
            this.cbo_Sala.Location = new System.Drawing.Point(136, 177);
            this.cbo_Sala.Name = "cbo_Sala";
            this.cbo_Sala.Size = new System.Drawing.Size(148, 21);
            this.cbo_Sala.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.btn_Agregar);
            this.groupBox1.Controls.Add(this.dgv_precios);
            this.groupBox1.Controls.Add(this.nud_Precio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbo_tipo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 285);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precios";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(46, 94);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 57;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // dgv_precios
            // 
            this.dgv_precios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_precios.Location = new System.Drawing.Point(6, 129);
            this.dgv_precios.Name = "dgv_precios";
            this.dgv_precios.ReadOnly = true;
            this.dgv_precios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_precios.Size = new System.Drawing.Size(274, 147);
            this.dgv_precios.TabIndex = 60;
            // 
            // nud_Precio
            // 
            this.nud_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Precio.Location = new System.Drawing.Point(130, 62);
            this.nud_Precio.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_Precio.Name = "nud_Precio";
            this.nud_Precio.Size = new System.Drawing.Size(148, 20);
            this.nud_Precio.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Precio";
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo.FormattingEnabled = true;
            this.cbo_tipo.Location = new System.Drawing.Point(130, 26);
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Size = new System.Drawing.Size(148, 21);
            this.cbo_tipo.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Tipo";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(156, 94);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 61;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // frm_PopUp_Funcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(301, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbo_Sala);
            this.Controls.Add(this.cbo_Pelicula);
            this.Controls.Add(this.txt_horario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pelicula);
            this.Controls.Add(this.cbo_Cine);
            this.Controls.Add(this.lbl_Subtitulo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PopUp_Funcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PopUp_Funcion";
            this.Load += new System.EventHandler(this.frm_PopUp_Funcion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_precios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Precio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Pelicula;
        private System.Windows.Forms.ComboBox cbo_Cine;
        private System.Windows.Forms.Label lbl_Subtitulo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_horario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Pelicula;
        private System.Windows.Forms.ComboBox cbo_Sala;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nud_Precio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_precios;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}