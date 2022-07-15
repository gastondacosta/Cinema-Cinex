namespace Proyecto_Cine
{
    partial class frm_PopUp_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PopUp_Empleado));
            this.cbo_Modalidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Subtitulo = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_fechadeInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_tipoEmpleado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.lbl_Contra = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Sueldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbo_Modalidad
            // 
            this.cbo_Modalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Modalidad.FormattingEnabled = true;
            this.cbo_Modalidad.Location = new System.Drawing.Point(136, 175);
            this.cbo_Modalidad.Name = "cbo_Modalidad";
            this.cbo_Modalidad.Size = new System.Drawing.Size(148, 21);
            this.cbo_Modalidad.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Modalidad";
            // 
            // lbl_Subtitulo
            // 
            this.lbl_Subtitulo.AutoSize = true;
            this.lbl_Subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtitulo.Location = new System.Drawing.Point(94, 21);
            this.lbl_Subtitulo.Name = "lbl_Subtitulo";
            this.lbl_Subtitulo.Size = new System.Drawing.Size(0, 17);
            this.lbl_Subtitulo.TabIndex = 60;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(167, 343);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 59;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Aceptar.Location = new System.Drawing.Point(56, 343);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 58;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_fechadeInicio
            // 
            this.txt_fechadeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fechadeInicio.Location = new System.Drawing.Point(136, 236);
            this.txt_fechadeInicio.Name = "txt_fechadeInicio";
            this.txt_fechadeInicio.Size = new System.Drawing.Size(148, 20);
            this.txt_fechadeInicio.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Sueldo(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Fecha de inicio";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(136, 81);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(148, 20);
            this.txt_Nombre.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nombre(*)";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(136, 48);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(148, 20);
            this.txt_ID.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "ID";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(136, 114);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(148, 20);
            this.txt_Apellido.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Apellido(*)";
            // 
            // cbo_tipoEmpleado
            // 
            this.cbo_tipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipoEmpleado.FormattingEnabled = true;
            this.cbo_tipoEmpleado.Location = new System.Drawing.Point(136, 204);
            this.cbo_tipoEmpleado.Name = "cbo_tipoEmpleado";
            this.cbo_tipoEmpleado.Size = new System.Drawing.Size(148, 21);
            this.cbo_tipoEmpleado.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Tipo de empleado";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(136, 301);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(148, 20);
            this.txt_Contraseña.TabIndex = 77;
            this.txt_Contraseña.UseSystemPasswordChar = true;
            // 
            // lbl_Contra
            // 
            this.lbl_Contra.AutoSize = true;
            this.lbl_Contra.Location = new System.Drawing.Point(17, 305);
            this.lbl_Contra.Name = "lbl_Contra";
            this.lbl_Contra.Size = new System.Drawing.Size(71, 13);
            this.lbl_Contra.TabIndex = 76;
            this.lbl_Contra.Text = "Contraseña(*)";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(136, 268);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(148, 20);
            this.txt_Usuario.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Usuario(*)";
            // 
            // txt_Sueldo
            // 
            this.txt_Sueldo.Location = new System.Drawing.Point(136, 144);
            this.txt_Sueldo.Name = "txt_Sueldo";
            this.txt_Sueldo.Size = new System.Drawing.Size(148, 20);
            this.txt_Sueldo.TabIndex = 78;
            // 
            // frm_PopUp_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(301, 383);
            this.Controls.Add(this.txt_Sueldo);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.lbl_Contra);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbo_tipoEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_Modalidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Subtitulo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_fechadeInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_PopUp_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PopUp_Empleado";
            this.Load += new System.EventHandler(this.frm_PopUp_Empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbo_Modalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Subtitulo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.DateTimePicker txt_fechadeInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_tipoEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Sueldo;
        public System.Windows.Forms.TextBox txt_Contraseña;
        public System.Windows.Forms.Label lbl_Contra;
    }
}