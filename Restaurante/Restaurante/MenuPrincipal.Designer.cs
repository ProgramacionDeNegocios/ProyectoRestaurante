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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Pedidos = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInsumos = new System.Windows.Forms.Button();
            this.btnTipoUnidad = new System.Windows.Forms.Button();
            this.btnAreas = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModuloUsuarios
            // 
            this.btnModuloUsuarios.Location = new System.Drawing.Point(128, 3);
            this.btnModuloUsuarios.Name = "btnModuloUsuarios";
            this.btnModuloUsuarios.Size = new System.Drawing.Size(109, 64);
            this.btnModuloUsuarios.TabIndex = 0;
            this.btnModuloUsuarios.Text = "Usuarios";
            this.btnModuloUsuarios.UseVisualStyleBackColor = true;
            this.btnModuloUsuarios.Click += new System.EventHandler(this.btnModuloUsuarios_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1037, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 28);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModuloProveedores
            // 
            this.btnModuloProveedores.Location = new System.Drawing.Point(261, 19);
            this.btnModuloProveedores.Name = "btnModuloProveedores";
            this.btnModuloProveedores.Size = new System.Drawing.Size(109, 64);
            this.btnModuloProveedores.TabIndex = 2;
            this.btnModuloProveedores.Text = "Proveedores";
            this.btnModuloProveedores.UseVisualStyleBackColor = true;
            this.btnModuloProveedores.Click += new System.EventHandler(this.btnModuloProveedores_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "Meseros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(33, 125);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 370);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Pedidos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Pedidos
            // 
            this.Pedidos.Location = new System.Drawing.Point(22, 21);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(109, 64);
            this.Pedidos.TabIndex = 5;
            this.Pedidos.Text = "Inventario";
            this.Pedidos.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(950, 344);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Seguridad";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnModuloUsuarios);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 71);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Roles";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnInsumos
            // 
            this.btnInsumos.Location = new System.Drawing.Point(376, 19);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Size = new System.Drawing.Size(109, 64);
            this.btnInsumos.TabIndex = 5;
            this.btnInsumos.Text = "Insumos";
            this.btnInsumos.UseVisualStyleBackColor = true;
            this.btnInsumos.Click += new System.EventHandler(this.btnInsumos_Click);
            // 
            // btnTipoUnidad
            // 
            this.btnTipoUnidad.Location = new System.Drawing.Point(491, 19);
            this.btnTipoUnidad.Name = "btnTipoUnidad";
            this.btnTipoUnidad.Size = new System.Drawing.Size(109, 64);
            this.btnTipoUnidad.TabIndex = 6;
            this.btnTipoUnidad.Text = "Unidades";
            this.btnTipoUnidad.UseVisualStyleBackColor = true;
            this.btnTipoUnidad.Click += new System.EventHandler(this.btnTipoUnidad_Click);
            // 
            // btnAreas
            // 
            this.btnAreas.Location = new System.Drawing.Point(615, 19);
            this.btnAreas.Name = "btnAreas";
            this.btnAreas.Size = new System.Drawing.Size(109, 64);
            this.btnAreas.TabIndex = 7;
            this.btnAreas.Text = "Areas";
            this.btnAreas.UseVisualStyleBackColor = true;
            this.btnAreas.Click += new System.EventHandler(this.btnAreas_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 563);
            this.Controls.Add(this.btnAreas);
            this.Controls.Add(this.btnTipoUnidad);
            this.Controls.Add(this.btnInsumos);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModuloProveedores);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModuloUsuarios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModuloProveedores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Pedidos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Button btnTipoUnidad;
        private System.Windows.Forms.Button btnAreas;
    }
}