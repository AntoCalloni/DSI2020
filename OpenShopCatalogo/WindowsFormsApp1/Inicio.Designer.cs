namespace WindowsFormsApp1
{
    partial class Inicio
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
            this.buttonRegistrarVendedor = new System.Windows.Forms.Button();
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.labelOpenShop = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegistrarVendedor
            // 
            this.buttonRegistrarVendedor.Location = new System.Drawing.Point(478, 201);
            this.buttonRegistrarVendedor.Name = "buttonRegistrarVendedor";
            this.buttonRegistrarVendedor.Size = new System.Drawing.Size(105, 48);
            this.buttonRegistrarVendedor.TabIndex = 0;
            this.buttonRegistrarVendedor.Text = "Registrarse";
            this.buttonRegistrarVendedor.UseVisualStyleBackColor = true;
            this.buttonRegistrarVendedor.Click += new System.EventHandler(this.buttonRegistrarVendedor_Click);
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.Location = new System.Drawing.Point(221, 201);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(124, 48);
            this.buttonIniciarSesion.TabIndex = 1;
            this.buttonIniciarSesion.Text = "Iniciar Sesion";
            this.buttonIniciarSesion.UseVisualStyleBackColor = true;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // labelOpenShop
            // 
            this.labelOpenShop.AutoSize = true;
            this.labelOpenShop.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenShop.Location = new System.Drawing.Point(249, 95);
            this.labelOpenShop.Name = "labelOpenShop";
            this.labelOpenShop.Size = new System.Drawing.Size(302, 28);
            this.labelOpenShop.TabIndex = 2;
            this.labelOpenShop.Text = "OpenShop - Vendedores";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(52, 305);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(84, 31);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.labelOpenShop);
            this.Controls.Add(this.buttonIniciarSesion);
            this.Controls.Add(this.buttonRegistrarVendedor);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrarVendedor;
        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.Label labelOpenShop;
        private System.Windows.Forms.Button buttonSalir;
    }
}