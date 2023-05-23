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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.grp_Form_Peliculas = new System.Windows.Forms.GroupBox();
            this.img_Inicio = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new MaterialSkin.Controls.MaterialLabel();
            this.enviar_Datos = new MaterialSkin.Controls.MaterialButton();
            this.genero_Pelicula = new MaterialSkin.Controls.MaterialComboBox();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.url_Imagen = new MaterialSkin.Controls.MaterialTextBox();
            this.duracion_Pelicula = new MaterialSkin.Controls.MaterialTextBox();
            this.nombre_Pelicula = new MaterialSkin.Controls.MaterialTextBox();
            this.horario_Pelicula = new MaterialSkin.Controls.MaterialComboBox();
            this.grp_Form_Peliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Inicio)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Form_Peliculas
            // 
            this.grp_Form_Peliculas.Controls.Add(this.horario_Pelicula);
            this.grp_Form_Peliculas.Controls.Add(this.img_Inicio);
            this.grp_Form_Peliculas.Controls.Add(this.lbl_Titulo);
            this.grp_Form_Peliculas.Controls.Add(this.enviar_Datos);
            this.grp_Form_Peliculas.Controls.Add(this.genero_Pelicula);
            this.grp_Form_Peliculas.Controls.Add(this.materialDrawer1);
            this.grp_Form_Peliculas.Controls.Add(this.url_Imagen);
            this.grp_Form_Peliculas.Controls.Add(this.duracion_Pelicula);
            this.grp_Form_Peliculas.Controls.Add(this.nombre_Pelicula);
            this.grp_Form_Peliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Form_Peliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Form_Peliculas.Location = new System.Drawing.Point(0, 0);
            this.grp_Form_Peliculas.Name = "grp_Form_Peliculas";
            this.grp_Form_Peliculas.Size = new System.Drawing.Size(824, 511);
            this.grp_Form_Peliculas.TabIndex = 1;
            this.grp_Form_Peliculas.TabStop = false;
            // 
            // img_Inicio
            // 
            this.img_Inicio.Image = global::Cine_Forms.Properties.Resources.casa;
            this.img_Inicio.Location = new System.Drawing.Point(12, 12);
            this.img_Inicio.Name = "img_Inicio";
            this.img_Inicio.Size = new System.Drawing.Size(100, 100);
            this.img_Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Inicio.TabIndex = 19;
            this.img_Inicio.TabStop = false;
            this.img_Inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Depth = 0;
            this.lbl_Titulo.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Titulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lbl_Titulo.Location = new System.Drawing.Point(210, 34);
            this.lbl_Titulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(402, 41);
            this.lbl_Titulo.TabIndex = 18;
            this.lbl_Titulo.Text = "Datos de la nueva pelicula:";
            // 
            // enviar_Datos
            // 
            this.enviar_Datos.AutoSize = false;
            this.enviar_Datos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enviar_Datos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.enviar_Datos.Depth = 0;
            this.enviar_Datos.HighEmphasis = true;
            this.enviar_Datos.Icon = null;
            this.enviar_Datos.Location = new System.Drawing.Point(332, 441);
            this.enviar_Datos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.enviar_Datos.MouseState = MaterialSkin.MouseState.HOVER;
            this.enviar_Datos.Name = "enviar_Datos";
            this.enviar_Datos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.enviar_Datos.Size = new System.Drawing.Size(173, 41);
            this.enviar_Datos.TabIndex = 17;
            this.enviar_Datos.Text = "Guardar";
            this.enviar_Datos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.enviar_Datos.UseAccentColor = false;
            this.enviar_Datos.UseVisualStyleBackColor = true;
            this.enviar_Datos.Click += new System.EventHandler(this.enviar_Datos_Click);
            // 
            // genero_Pelicula
            // 
            this.genero_Pelicula.AutoResize = false;
            this.genero_Pelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.genero_Pelicula.Depth = 0;
            this.genero_Pelicula.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.genero_Pelicula.DropDownHeight = 174;
            this.genero_Pelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genero_Pelicula.DropDownWidth = 121;
            this.genero_Pelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.genero_Pelicula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.genero_Pelicula.FormattingEnabled = true;
            this.genero_Pelicula.Hint = "Género";
            this.genero_Pelicula.IntegralHeight = false;
            this.genero_Pelicula.ItemHeight = 43;
            this.genero_Pelicula.Items.AddRange(new object[] {
            "",
            "Terror",
            "Infantil",
            "Suspenso",
            "Comedia",
            "Accion"});
            this.genero_Pelicula.Location = new System.Drawing.Point(251, 371);
            this.genero_Pelicula.MaxDropDownItems = 4;
            this.genero_Pelicula.MouseState = MaterialSkin.MouseState.OUT;
            this.genero_Pelicula.Name = "genero_Pelicula";
            this.genero_Pelicula.Size = new System.Drawing.Size(325, 49);
            this.genero_Pelicula.StartIndex = 0;
            this.genero_Pelicula.TabIndex = 16;
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-250, 207);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer1.TabIndex = 15;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // url_Imagen
            // 
            this.url_Imagen.AnimateReadOnly = false;
            this.url_Imagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.url_Imagen.Depth = 0;
            this.url_Imagen.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.url_Imagen.Hint = "URL de la imagen";
            this.url_Imagen.LeadingIcon = null;
            this.url_Imagen.Location = new System.Drawing.Point(250, 304);
            this.url_Imagen.MaxLength = 50;
            this.url_Imagen.MouseState = MaterialSkin.MouseState.OUT;
            this.url_Imagen.Multiline = false;
            this.url_Imagen.Name = "url_Imagen";
            this.url_Imagen.Size = new System.Drawing.Size(325, 50);
            this.url_Imagen.TabIndex = 13;
            this.url_Imagen.Text = "";
            this.url_Imagen.TrailingIcon = null;
            // 
            // duracion_Pelicula
            // 
            this.duracion_Pelicula.AnimateReadOnly = false;
            this.duracion_Pelicula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.duracion_Pelicula.Depth = 0;
            this.duracion_Pelicula.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.duracion_Pelicula.Hint = "Duración (minutos)";
            this.duracion_Pelicula.LeadingIcon = null;
            this.duracion_Pelicula.Location = new System.Drawing.Point(250, 178);
            this.duracion_Pelicula.MaxLength = 50;
            this.duracion_Pelicula.MouseState = MaterialSkin.MouseState.OUT;
            this.duracion_Pelicula.Multiline = false;
            this.duracion_Pelicula.Name = "duracion_Pelicula";
            this.duracion_Pelicula.Size = new System.Drawing.Size(326, 50);
            this.duracion_Pelicula.TabIndex = 12;
            this.duracion_Pelicula.Text = "";
            this.duracion_Pelicula.TrailingIcon = null;
            // 
            // nombre_Pelicula
            // 
            this.nombre_Pelicula.AnimateReadOnly = false;
            this.nombre_Pelicula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre_Pelicula.Depth = 0;
            this.nombre_Pelicula.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nombre_Pelicula.Hint = "Nombre";
            this.nombre_Pelicula.LeadingIcon = null;
            this.nombre_Pelicula.Location = new System.Drawing.Point(250, 111);
            this.nombre_Pelicula.MaxLength = 50;
            this.nombre_Pelicula.MouseState = MaterialSkin.MouseState.OUT;
            this.nombre_Pelicula.Multiline = false;
            this.nombre_Pelicula.Name = "nombre_Pelicula";
            this.nombre_Pelicula.Size = new System.Drawing.Size(325, 50);
            this.nombre_Pelicula.TabIndex = 11;
            this.nombre_Pelicula.Text = "";
            this.nombre_Pelicula.TrailingIcon = null;
            // 
            // horario_Pelicula
            // 
            this.horario_Pelicula.AutoResize = false;
            this.horario_Pelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.horario_Pelicula.Depth = 0;
            this.horario_Pelicula.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.horario_Pelicula.DropDownHeight = 174;
            this.horario_Pelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.horario_Pelicula.DropDownWidth = 121;
            this.horario_Pelicula.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.horario_Pelicula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.horario_Pelicula.FormattingEnabled = true;
            this.horario_Pelicula.Hint = "Horario";
            this.horario_Pelicula.IntegralHeight = false;
            this.horario_Pelicula.ItemHeight = 43;
            this.horario_Pelicula.Items.AddRange(new object[] {
            "",
            "6:00 (P.M)",
            "6:30 (P.M)",
            "8:00 (P.M)",
            "8:30 (P.M)",
            "10:00 (P.M)"});
            this.horario_Pelicula.Location = new System.Drawing.Point(250, 241);
            this.horario_Pelicula.MaxDropDownItems = 4;
            this.horario_Pelicula.MouseState = MaterialSkin.MouseState.OUT;
            this.horario_Pelicula.Name = "horario_Pelicula";
            this.horario_Pelicula.Size = new System.Drawing.Size(326, 49);
            this.horario_Pelicula.StartIndex = 0;
            this.horario_Pelicula.TabIndex = 20;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 511);
            this.Controls.Add(this.grp_Form_Peliculas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva pelicula";
            this.grp_Form_Peliculas.ResumeLayout(false);
            this.grp_Form_Peliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Inicio)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox grp_Form_Peliculas;
        private MaterialSkin.Controls.MaterialTextBox nombre_Pelicula;
        private MaterialSkin.Controls.MaterialTextBox url_Imagen;
        private MaterialSkin.Controls.MaterialTextBox duracion_Pelicula;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialComboBox genero_Pelicula;
        private MaterialSkin.Controls.MaterialLabel lbl_Titulo;
        private MaterialSkin.Controls.MaterialButton enviar_Datos;
        private System.Windows.Forms.PictureBox img_Inicio;
        private MaterialSkin.Controls.MaterialComboBox horario_Pelicula;
    }
}