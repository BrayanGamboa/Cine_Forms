namespace Cine_Forms
{
    partial class Usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.datos_Pelicula1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.duracion_pelicula = new System.Windows.Forms.Label();
            this.genero_pelicula = new System.Windows.Forms.Label();
            this.Nombre_peli = new System.Windows.Forms.Label();
            this.img_pelicula = new System.Windows.Forms.PictureBox();
            this.datos_Pelicula1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_pelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datos_Pelicula1
            // 
            this.datos_Pelicula1.Controls.Add(this.button1);
            this.datos_Pelicula1.Controls.Add(this.duracion_pelicula);
            this.datos_Pelicula1.Controls.Add(this.genero_pelicula);
            this.datos_Pelicula1.Controls.Add(this.Nombre_peli);
            this.datos_Pelicula1.Controls.Add(this.img_pelicula);
            this.datos_Pelicula1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datos_Pelicula1.Location = new System.Drawing.Point(39, 64);
            this.datos_Pelicula1.Name = "datos_Pelicula1";
            this.datos_Pelicula1.Size = new System.Drawing.Size(164, 218);
            this.datos_Pelicula1.TabIndex = 1;
            this.datos_Pelicula1.TabStop = false;
            this.datos_Pelicula1.Text = "Pelicula 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reservar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // duracion_pelicula
            // 
            this.duracion_pelicula.AutoSize = true;
            this.duracion_pelicula.Location = new System.Drawing.Point(6, 155);
            this.duracion_pelicula.Name = "duracion_pelicula";
            this.duracion_pelicula.Size = new System.Drawing.Size(77, 20);
            this.duracion_pelicula.TabIndex = 4;
            this.duracion_pelicula.Text = "Duración:";
            // 
            // genero_pelicula
            // 
            this.genero_pelicula.AutoSize = true;
            this.genero_pelicula.Location = new System.Drawing.Point(6, 135);
            this.genero_pelicula.Name = "genero_pelicula";
            this.genero_pelicula.Size = new System.Drawing.Size(67, 20);
            this.genero_pelicula.TabIndex = 3;
            this.genero_pelicula.Text = "Género:";
            // 
            // Nombre_peli
            // 
            this.Nombre_peli.AutoSize = true;
            this.Nombre_peli.Location = new System.Drawing.Point(6, 115);
            this.Nombre_peli.Name = "Nombre_peli";
            this.Nombre_peli.Size = new System.Drawing.Size(69, 20);
            this.Nombre_peli.TabIndex = 2;
            this.Nombre_peli.Text = "Nombre:";
            // 
            // img_pelicula
            // 
            this.img_pelicula.Location = new System.Drawing.Point(6, 25);
            this.img_pelicula.Name = "img_pelicula";
            this.img_pelicula.Size = new System.Drawing.Size(152, 74);
            this.img_pelicula.TabIndex = 0;
            this.img_pelicula.TabStop = false;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datos_Pelicula1);
            this.Controls.Add(this.label1);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.datos_Pelicula1.ResumeLayout(false);
            this.datos_Pelicula1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_pelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox datos_Pelicula1;
        private System.Windows.Forms.Label Nombre_peli;
        private System.Windows.Forms.PictureBox img_pelicula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label duracion_pelicula;
        private System.Windows.Forms.Label genero_pelicula;
    }
}