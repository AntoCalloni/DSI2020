namespace WindowsFormsApp1
{
    partial class AgregarProducto
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxImagen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderStock = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderImagen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNombreCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTipoProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoProducto = new System.Windows.Forms.ComboBox();
            this.buttonAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombreCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTipoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complete los datos del producto:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(332, 115);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(307, 26);
            this.textBoxNombre.TabIndex = 3;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.TextBoxNombre_TextChanged);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(332, 179);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(307, 26);
            this.textBoxPrecio.TabIndex = 5;
            this.textBoxPrecio.TextChanged += new System.EventHandler(this.TextBoxPrecio_TextChanged);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(332, 211);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(307, 26);
            this.textBoxDescripcion.TabIndex = 6;
            this.textBoxDescripcion.TextChanged += new System.EventHandler(this.TextBoxDescripcion_TextChanged);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(332, 243);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(307, 26);
            this.textBoxStock.TabIndex = 7;
            this.textBoxStock.TextChanged += new System.EventHandler(this.TextBoxStock_TextChanged);
            // 
            // textBoxImagen
            // 
            this.textBoxImagen.Location = new System.Drawing.Point(332, 275);
            this.textBoxImagen.Name = "textBoxImagen";
            this.textBoxImagen.Size = new System.Drawing.Size(307, 26);
            this.textBoxImagen.TabIndex = 8;
            this.textBoxImagen.TextChanged += new System.EventHandler(this.TextBoxImagen_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descripcion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Stock:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Imagen:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nombre tipo de producto:";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(673, 390);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(103, 39);
            this.buttonAgregar.TabIndex = 19;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // errorProviderMarca
            // 
            this.errorProviderMarca.ContainerControl = this;
            // 
            // errorProviderPrecio
            // 
            this.errorProviderPrecio.ContainerControl = this;
            // 
            // errorProviderDescripcion
            // 
            this.errorProviderDescripcion.ContainerControl = this;
            // 
            // errorProviderStock
            // 
            this.errorProviderStock.ContainerControl = this;
            // 
            // errorProviderImagen
            // 
            this.errorProviderImagen.ContainerControl = this;
            // 
            // errorProviderNombreCategoria
            // 
            this.errorProviderNombreCategoria.ContainerControl = this;
            // 
            // errorProviderTipoProducto
            // 
            this.errorProviderTipoProducto.ContainerControl = this;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(332, 145);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(307, 28);
            this.comboBoxMarca.TabIndex = 20;
            this.comboBoxMarca.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarca_SelectedIndexChanged);
            this.comboBoxMarca.TextChanged += new System.EventHandler(this.comboBoxMarca_TextChanged);
            // 
            // comboBoxTipoProducto
            // 
            this.comboBoxTipoProducto.FormattingEnabled = true;
            this.comboBoxTipoProducto.Location = new System.Drawing.Point(332, 311);
            this.comboBoxTipoProducto.Name = "comboBoxTipoProducto";
            this.comboBoxTipoProducto.Size = new System.Drawing.Size(307, 28);
            this.comboBoxTipoProducto.TabIndex = 22;
            this.comboBoxTipoProducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoProducto_SelectedIndexChanged);
            this.comboBoxTipoProducto.TextChanged += new System.EventHandler(this.comboBoxTipoProducto_TextChanged);
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(34, 390);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(103, 39);
            this.buttonAtras.TabIndex = 23;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtrás_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 477);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.comboBoxTipoProducto);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxImagen);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombreCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTipoProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxImagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.ErrorProvider errorProviderMarca;
        private System.Windows.Forms.ErrorProvider errorProviderPrecio;
        private System.Windows.Forms.ErrorProvider errorProviderDescripcion;
        private System.Windows.Forms.ErrorProvider errorProviderStock;
        private System.Windows.Forms.ErrorProvider errorProviderImagen;
        private System.Windows.Forms.ErrorProvider errorProviderNombreCategoria;
        private System.Windows.Forms.ErrorProvider errorProviderTipoProducto;
        private System.Windows.Forms.ComboBox comboBoxTipoProducto;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Button buttonAtras;
    }
}