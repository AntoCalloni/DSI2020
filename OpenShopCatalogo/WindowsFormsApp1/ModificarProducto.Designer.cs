namespace WindowsFormsApp1
{
    partial class ModificarProducto
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
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.errorProviderStock = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elija el id del producto a modificar:";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(68, 339);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(146, 26);
            this.textBoxStock.TabIndex = 2;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(293, 339);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(150, 26);
            this.textBoxPrecio.TabIndex = 3;
            this.textBoxPrecio.TextChanged += new System.EventHandler(this.TextBoxPrecio_TextChanged);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(662, 386);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(99, 43);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nuevo stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nuevo precio:";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(68, 63);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowTemplate.Height = 28;
            this.dataGridViewProductos.Size = new System.Drawing.Size(580, 228);
            this.dataGridViewProductos.TabIndex = 7;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // errorProviderStock
            // 
            this.errorProviderStock.ContainerControl = this;
            // 
            // errorProviderPrecio
            // 
            this.errorProviderPrecio.ContainerControl = this;
            // 
            // errorProviderProducto
            // 
            this.errorProviderProducto.ContainerControl = this;
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(51, 390);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(99, 34);
            this.buttonAtras.TabIndex = 8;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.label1);
            this.Name = "ModificarProducto";
            this.Text = "ModificarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.ErrorProvider errorProviderStock;
        private System.Windows.Forms.ErrorProvider errorProviderPrecio;
        private System.Windows.Forms.ErrorProvider errorProviderProducto;
        private System.Windows.Forms.Button buttonAtras;
    }
}