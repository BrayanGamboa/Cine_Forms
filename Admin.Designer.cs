namespace Cine_Forms
{
    partial class Admin
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
            this.lbl_Admin = new System.Windows.Forms.Label();
            this.grp_Form_Peliculas = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.enviar_Datos = new System.Windows.Forms.Button();
            this.url_Imagen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genero_Pelicula = new System.Windows.Forms.TextBox();
            this.duracion_Pelicula = new System.Windows.Forms.TextBox();
            this.nombre_Pelicula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.horario_Pelicula = new System.Windows.Forms.TextBox();
            this.grp_Form_Peliculas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Admin
            // 
            this.lbl_Admin.AutoSize = true;
            this.lbl_Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin.Location = new System.Drawing.Point(0, 0);
            this.lbl_Admin.Name = "lbl_Admin";
            this.lbl_Admin.Size = new System.Drawing.Size(205, 35);
            this.lbl_Admin.TabIndex = 0;
            this.lbl_Admin.Text = "Administrador";
            // 
            // grp_Form_Peliculas
            // 
            this.grp_Form_Peliculas.Controls.Add(this.horario_Pelicula);
            this.grp_Form_Peliculas.Controls.Add(this.label5);
            this.grp_Form_Peliculas.Controls.Add(this.enviar_Datos);
            this.grp_Form_Peliculas.Controls.Add(this.url_Imagen);
            this.grp_Form_Peliculas.Controls.Add(this.label4);
            this.grp_Form_Peliculas.Controls.Add(this.genero_Pelicula);
            this.grp_Form_Peliculas.Controls.Add(this.duracion_Pelicula);
            this.grp_Form_Peliculas.Controls.Add(this.nombre_Pelicula);
            this.grp_Form_Peliculas.Controls.Add(this.label3);
            this.grp_Form_Peliculas.Controls.Add(this.label2);
            this.grp_Form_Peliculas.Controls.Add(this.label1);
            this.grp_Form_Peliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Form_Peliculas.Location = new System.Drawing.Point(84, 61);
            this.grp_Form_Peliculas.Name = "grp_Form_Peliculas";
            this.grp_Form_Peliculas.Size = new System.Drawing.Size(582, 377);
            this.grp_Form_Peliculas.TabIndex = 1;
            this.grp_Form_Peliculas.TabStop = false;
            this.grp_Form_Peliculas.Text = "Datos de la pelicula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Horario de la Pelicula:";
            // 
            // enviar_Datos
            // 
            this.enviar_Datos.Location = new System.Drawing.Point(226, 319);
            this.enviar_Datos.Name = "enviar_Datos";
            this.enviar_Datos.Size = new System.Drawing.Size(183, 52);
            this.enviar_Datos.TabIndex = 8;
            this.enviar_Datos.Text = "Guardar Datos";
            this.enviar_Datos.UseVisualStyleBackColor = true;
            this.enviar_Datos.Click += new System.EventHandler(this.enviar_Datos_Click);
            // 
            // url_Imagen
            // 
            this.url_Imagen.Location = new System.Drawing.Point(203, 253);
            this.url_Imagen.Name = "url_Imagen";
            this.url_Imagen.Size = new System.Drawing.Size(325, 26);
            this.url_Imagen.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "URL de la Imagen";
            // 
            // genero_Pelicula
            // 
            this.genero_Pelicula.Location = new System.Drawing.Point(203, 161);
            this.genero_Pelicula.Name = "genero_Pelicula";
            this.genero_Pelicula.Size = new System.Drawing.Size(325, 26);
            this.genero_Pelicula.TabIndex = 5;
            // 
            // duracion_Pelicula
            // 
            this.duracion_Pelicula.Location = new System.Drawing.Point(203, 103);
            this.duracion_Pelicula.Name = "duracion_Pelicula";
            this.duracion_Pelicula.Size = new System.Drawing.Size(325, 26);
            this.duracion_Pelicula.TabIndex = 4;
            // 
            // nombre_Pelicula
            // 
            this.nombre_Pelicula.Location = new System.Drawing.Point(203, 50);
            this.nombre_Pelicula.Name = "nombre_Pelicula";
            this.nombre_Pelicula.Size = new System.Drawing.Size(325, 26);
            this.nombre_Pelicula.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Género de la Pelicula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duración de la Pelicula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la Pelicula:";
            // 
            // horario_Pelicula
            // 
            this.horario_Pelicula.Location = new System.Drawing.Point(203, 207);
            this.horario_Pelicula.Name = "horario_Pelicula";
            this.horario_Pelicula.Size = new System.Drawing.Size(325, 26);
            this.horario_Pelicula.TabIndex = 10;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_Form_Peliculas);
            this.Controls.Add(this.lbl_Admin);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.grp_Form_Peliculas.ResumeLayout(false);
            this.grp_Form_Peliculas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Admin;
        private System.Windows.Forms.GroupBox grp_Form_Peliculas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genero_Pelicula;
        private System.Windows.Forms.TextBox duracion_Pelicula;
        private System.Windows.Forms.TextBox nombre_Pelicula;
        private System.Windows.Forms.TextBox url_Imagen;
        private System.Windows.Forms.Button enviar_Datos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox horario_Pelicula;
    }
}