namespace Restaurante
{
    partial class MenuPrincipal
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
            this.btnModuloUsuarios = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModuloProveedores = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModuloComandas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModuloUsuarios
            // 
            this.btnModuloUsuarios.Location = new System.Drawing.Point(804, 72);
            this.btnModuloUsuarios.Name = "btnModuloUsuarios";
            this.btnModuloUsuarios.Size = new System.Drawing.Size(109, 64);
            this.btnModuloUsuarios.TabIndex = 0;
            this.btnModuloUsuarios.Text = "Usuarios";
            this.btnModuloUsuarios.UseVisualStyleBackColor = true;
            this.btnModuloUsuarios.Click += new System.EventHandler(this.btnModuloUsuarios_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1003, 22);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 64);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModuloProveedores
            // 
            this.btnModuloProveedores.Location = new System.Drawing.Point(804, 241);
            this.btnModuloProveedores.Name = "btnModuloProveedores";
            this.btnModuloProveedores.Size = new System.Drawing.Size(109, 64);
            this.btnModuloProveedores.TabIndex = 2;
            this.btnModuloProveedores.Text = "Proveedores";
            this.btnModuloProveedores.UseVisualStyleBackColor = true;
            this.btnModuloProveedores.Click += new System.EventHandler(this.btnModuloProveedores_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "Meseros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModuloComandas
            // 
            this.btnModuloComandas.Location = new System.Drawing.Point(804, 323);
            this.btnModuloComandas.Name = "btnModuloComandas";
            this.btnModuloComandas.Size = new System.Drawing.Size(109, 63);
            this.btnModuloComandas.TabIndex = 4;
            this.btnModuloComandas.Text = "Comandas";
            this.btnModuloComandas.UseVisualStyleBackColor = true;
            this.btnModuloComandas.Click += new System.EventHandler(this.btnModuloComandas_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 563);
            this.Controls.Add(this.btnModuloComandas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModuloProveedores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModuloUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModuloUsuarios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModuloProveedores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModuloComandas;
    }
}