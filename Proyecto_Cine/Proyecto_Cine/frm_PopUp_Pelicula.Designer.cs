namespace Proyecto_Cine
{
    partial class frm_PopUp_Pelicula
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
            this.cbo_Genero = new System.Windows.Forms.ComboBox();
            this.txt_Sinopsis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Subtitulo = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_fechadeEstreno = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_pais = new System.Windows.Forms.ComboBox();
            this.cbo_Censura = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Duracion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbo_Genero
            // 
            this.cbo_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Genero.FormattingEnabled = true;
            this.cbo_Genero.Location = new System.Drawing.Point(136, 108);
            this.cbo_Genero.Name = "cbo_Genero";
            this.cbo_Genero.Size = new System.Drawing.Size(148, 21);
            this.cbo_Genero.TabIndex = 44;
            // 
            // txt_Sinopsis
            // 
            this.txt_Sinopsis.Location = new System.Drawing.Point(69, 260);
            this.txt_Sinopsis.Multiline = true;
            this.txt_Sinopsis.Name = "txt_Sinopsis";
            this.txt_Sinopsis.Size = new System.Drawing.Size(215, 85);
            this.txt_Sinopsis.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Sinópsis";
            // 
            // lbl_Subtitulo
            // 
            this.lbl_Subtitulo.AutoSize = true;
            this.lbl_Subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtitulo.Location = new System.Drawing.Point(94, 15);
            this.lbl_Subtitulo.Name = "lbl_Subtitulo";
            this.lbl_Subtitulo.Size = new System.Drawing.Size(0, 17);
            this.lbl_Subtitulo.TabIndex = 41;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(167, 353);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 40;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Aceptar.Location = new System.Drawing.Point(56, 353);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 39;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_fechadeEstreno
            // 
            this.txt_fechadeEstreno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fechadeEstreno.Location = new System.Drawing.Point(136, 230);
            this.txt_fechadeEstreno.Name = "txt_fechadeEstreno";
            this.txt_fechadeEstreno.Size = new System.Drawing.Size(148, 20);
            this.txt_fechadeEstreno.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "País";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fecha de estreno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Género";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(136, 75);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(148, 20);
            this.txt_Nombre.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Título(*)";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(136, 41);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(148, 20);
            this.txt_ID.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID";
            // 
            // cbo_pais
            // 
            this.cbo_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_pais.FormattingEnabled = true;
            this.cbo_pais.Location = new System.Drawing.Point(136, 140);
            this.cbo_pais.Name = "cbo_pais";
            this.cbo_pais.Size = new System.Drawing.Size(148, 21);
            this.cbo_pais.TabIndex = 45;
            // 
            // cbo_Censura
            // 
            this.cbo_Censura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Censura.FormattingEnabled = true;
            this.cbo_Censura.Location = new System.Drawing.Point(136, 170);
            this.cbo_Censura.Name = "cbo_Censura";
            this.cbo_Censura.Size = new System.Drawing.Size(148, 21);
            this.cbo_Censura.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Censura";
            // 
            // txt_Duracion
            // 
            this.txt_Duracion.Location = new System.Drawing.Point(136, 200);
            this.txt_Duracion.Name = "txt_Duracion";
            this.txt_Duracion.Size = new System.Drawing.Size(148, 20);
            this.txt_Duracion.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Duración(*)";
            // 
            // frm_PopUp_Pelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(301, 386);
            this.Controls.Add(this.txt_Duracion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbo_Censura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_pais);
            this.Controls.Add(this.cbo_Genero);
            this.Controls.Add(this.txt_Sinopsis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Subtitulo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_fechadeEstreno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PopUp_Pelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PopUp_Pelicula";
            this.Load += new System.EventHandler(this.frm_PopUp_Pelicula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Genero;
        private System.Windows.Forms.TextBox txt_Sinopsis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Subtitulo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.DateTimePicker txt_fechadeEstreno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_pais;
        private System.Windows.Forms.ComboBox cbo_Censura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Duracion;
        private System.Windows.Forms.Label label8;
    }
}