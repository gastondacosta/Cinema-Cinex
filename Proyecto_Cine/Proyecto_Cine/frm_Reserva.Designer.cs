namespace Proyecto_Cine
{
    partial class frm_Reserva
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_BuscarDniCliente = new System.Windows.Forms.Button();
            this.txt_DniCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NombreEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BuscarEmpleado = new System.Windows.Forms.Button();
            this.txt_CodigoEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Butacas = new System.Windows.Forms.DataGridView();
            this.txt_Sala = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_Funcion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_Peli = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_Cine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_TipoE = new System.Windows.Forms.ComboBox();
            this.dgv_Detalle = new System.Windows.Forms.DataGridView();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_PrecioFinal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Butacas)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_NombreCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_BuscarDniCliente);
            this.groupBox1.Controls.Add(this.txt_DniCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_NombreEmpleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_BuscarEmpleado);
            this.groupBox1.Controls.Add(this.txt_CodigoEmpleado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(412, 61);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.ReadOnly = true;
            this.txt_NombreCliente.Size = new System.Drawing.Size(125, 21);
            this.txt_NombreCliente.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre cliente";
            // 
            // btn_BuscarDniCliente
            // 
            this.btn_BuscarDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarDniCliente.Location = new System.Drawing.Point(250, 60);
            this.btn_BuscarDniCliente.Name = "btn_BuscarDniCliente";
            this.btn_BuscarDniCliente.Size = new System.Drawing.Size(30, 20);
            this.btn_BuscarDniCliente.TabIndex = 7;
            this.btn_BuscarDniCliente.Text = "...";
            this.btn_BuscarDniCliente.UseVisualStyleBackColor = true;
            this.btn_BuscarDniCliente.Click += new System.EventHandler(this.btn_BuscarDniCliente_Click);
            // 
            // txt_DniCliente
            // 
            this.txt_DniCliente.Location = new System.Drawing.Point(119, 60);
            this.txt_DniCliente.Name = "txt_DniCliente";
            this.txt_DniCliente.ReadOnly = true;
            this.txt_DniCliente.Size = new System.Drawing.Size(125, 21);
            this.txt_DniCliente.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID Cliente";
            // 
            // txt_NombreEmpleado
            // 
            this.txt_NombreEmpleado.Location = new System.Drawing.Point(412, 29);
            this.txt_NombreEmpleado.Name = "txt_NombreEmpleado";
            this.txt_NombreEmpleado.ReadOnly = true;
            this.txt_NombreEmpleado.Size = new System.Drawing.Size(125, 21);
            this.txt_NombreEmpleado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre empleado";
            // 
            // btn_BuscarEmpleado
            // 
            this.btn_BuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarEmpleado.Location = new System.Drawing.Point(250, 28);
            this.btn_BuscarEmpleado.Name = "btn_BuscarEmpleado";
            this.btn_BuscarEmpleado.Size = new System.Drawing.Size(30, 20);
            this.btn_BuscarEmpleado.TabIndex = 2;
            this.btn_BuscarEmpleado.Text = "...";
            this.btn_BuscarEmpleado.UseVisualStyleBackColor = true;
            this.btn_BuscarEmpleado.Click += new System.EventHandler(this.btn_BuscarEmpleado_Click);
            // 
            // txt_CodigoEmpleado
            // 
            this.txt_CodigoEmpleado.Location = new System.Drawing.Point(119, 28);
            this.txt_CodigoEmpleado.Name = "txt_CodigoEmpleado";
            this.txt_CodigoEmpleado.ReadOnly = true;
            this.txt_CodigoEmpleado.Size = new System.Drawing.Size(125, 21);
            this.txt_CodigoEmpleado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código empleado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Butacas);
            this.groupBox2.Controls.Add(this.txt_Sala);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbo_Funcion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbo_Peli);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbo_Cine);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Reserva";
            // 
            // dgv_Butacas
            // 
            this.dgv_Butacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Butacas.Location = new System.Drawing.Point(261, 14);
            this.dgv_Butacas.Name = "dgv_Butacas";
            this.dgv_Butacas.ReadOnly = true;
            this.dgv_Butacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Butacas.Size = new System.Drawing.Size(284, 150);
            this.dgv_Butacas.TabIndex = 17;
            // 
            // txt_Sala
            // 
            this.txt_Sala.Location = new System.Drawing.Point(94, 132);
            this.txt_Sala.Name = "txt_Sala";
            this.txt_Sala.ReadOnly = true;
            this.txt_Sala.Size = new System.Drawing.Size(150, 21);
            this.txt_Sala.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sala";
            // 
            // cbo_Funcion
            // 
            this.cbo_Funcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Funcion.FormattingEnabled = true;
            this.cbo_Funcion.Location = new System.Drawing.Point(94, 98);
            this.cbo_Funcion.Name = "cbo_Funcion";
            this.cbo_Funcion.Size = new System.Drawing.Size(150, 23);
            this.cbo_Funcion.TabIndex = 15;
            this.cbo_Funcion.SelectedIndexChanged += new System.EventHandler(this.cbo_Funcion_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Función";
            // 
            // cbo_Peli
            // 
            this.cbo_Peli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Peli.FormattingEnabled = true;
            this.cbo_Peli.Location = new System.Drawing.Point(94, 64);
            this.cbo_Peli.Name = "cbo_Peli";
            this.cbo_Peli.Size = new System.Drawing.Size(150, 23);
            this.cbo_Peli.TabIndex = 13;
            this.cbo_Peli.SelectedIndexChanged += new System.EventHandler(this.cbo_Peli_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Película";
            // 
            // cbo_Cine
            // 
            this.cbo_Cine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Cine.FormattingEnabled = true;
            this.cbo_Cine.Location = new System.Drawing.Point(94, 30);
            this.cbo_Cine.Name = "cbo_Cine";
            this.cbo_Cine.Size = new System.Drawing.Size(150, 23);
            this.cbo_Cine.TabIndex = 11;
            this.cbo_Cine.SelectedIndexChanged += new System.EventHandler(this.cbo_Cine_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cine";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Precio);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbo_TipoE);
            this.groupBox3.Controls.Add(this.dgv_Detalle);
            this.groupBox3.Controls.Add(this.btn_Eliminar);
            this.groupBox3.Controls.Add(this.btn_Agregar);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 202);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(293, 16);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.ReadOnly = true;
            this.txt_Precio.Size = new System.Drawing.Size(97, 21);
            this.txt_Precio.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Precio";
            // 
            // cbo_TipoE
            // 
            this.cbo_TipoE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TipoE.FormattingEnabled = true;
            this.cbo_TipoE.Location = new System.Drawing.Point(100, 15);
            this.cbo_TipoE.Name = "cbo_TipoE";
            this.cbo_TipoE.Size = new System.Drawing.Size(141, 23);
            this.cbo_TipoE.TabIndex = 18;
            this.cbo_TipoE.SelectedIndexChanged += new System.EventHandler(this.cbo_TipoE_SelectedIndexChanged);
            // 
            // dgv_Detalle
            // 
            this.dgv_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detalle.Location = new System.Drawing.Point(6, 43);
            this.dgv_Detalle.Name = "dgv_Detalle";
            this.dgv_Detalle.ReadOnly = true;
            this.dgv_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Detalle.Size = new System.Drawing.Size(539, 153);
            this.dgv_Detalle.TabIndex = 18;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(459, 16);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(52, 21);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(401, 16);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(52, 21);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tipo entrada";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Aceptar.Location = new System.Drawing.Point(173, 550);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 11;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(306, 550);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Precio final";
            // 
            // txt_PrecioFinal
            // 
            this.txt_PrecioFinal.Location = new System.Drawing.Point(251, 515);
            this.txt_PrecioFinal.Name = "txt_PrecioFinal";
            this.txt_PrecioFinal.ReadOnly = true;
            this.txt_PrecioFinal.Size = new System.Drawing.Size(130, 20);
            this.txt_PrecioFinal.TabIndex = 20;
            // 
            // frm_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(575, 587);
            this.Controls.Add(this.txt_PrecioFinal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.frm_Reserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Butacas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_BuscarDniCliente;
        private System.Windows.Forms.TextBox txt_DniCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NombreEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BuscarEmpleado;
        private System.Windows.Forms.TextBox txt_CodigoEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Butacas;
        private System.Windows.Forms.TextBox txt_Sala;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_Funcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_Peli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_Cine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv_Detalle;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.ComboBox cbo_TipoE;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_PrecioFinal;
    }
}