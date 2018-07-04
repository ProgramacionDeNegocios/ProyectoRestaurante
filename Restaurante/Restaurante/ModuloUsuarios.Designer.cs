namespace Restaurante
{
    partial class ModuloUsuarios
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgwUsuarios = new System.Windows.Forms.DataGridView();
            this.grpNuevoUsuario = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).BeginInit();
            this.grpNuevoUsuario.SuspendLayout();
            this.grpUsuarios.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(18, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(18, 69);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(18, 113);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(35, 88);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(109, 116);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(192, 21);
            this.cmbDepartamento.TabIndex = 5;
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(35, 119);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 6;
            this.lblDepartamento.Text = "Departamento";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(527, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(109, 85);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(192, 20);
            this.txtClave.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // dgwUsuarios
            // 
            this.dgwUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwUsuarios.Location = new System.Drawing.Point(3, 16);
            this.dgwUsuarios.MultiSelect = false;
            this.dgwUsuarios.Name = "dgwUsuarios";
            this.dgwUsuarios.ReadOnly = true;
            this.dgwUsuarios.Size = new System.Drawing.Size(539, 186);
            this.dgwUsuarios.TabIndex = 12;
            // 
            // grpNuevoUsuario
            // 
            this.grpNuevoUsuario.Controls.Add(this.txtApellido);
            this.grpNuevoUsuario.Controls.Add(this.lblApellido);
            this.grpNuevoUsuario.Controls.Add(this.btnBuscar);
            this.grpNuevoUsuario.Controls.Add(this.txtNombre);
            this.grpNuevoUsuario.Controls.Add(this.txtClave);
            this.grpNuevoUsuario.Controls.Add(this.lblDepartamento);
            this.grpNuevoUsuario.Controls.Add(this.cmbDepartamento);
            this.grpNuevoUsuario.Controls.Add(this.lblClave);
            this.grpNuevoUsuario.Controls.Add(this.lblNombre);
            this.grpNuevoUsuario.Location = new System.Drawing.Point(34, 70);
            this.grpNuevoUsuario.Name = "grpNuevoUsuario";
            this.grpNuevoUsuario.Size = new System.Drawing.Size(431, 163);
            this.grpNuevoUsuario.TabIndex = 13;
            this.grpNuevoUsuario.TabStop = false;
            this.grpNuevoUsuario.Text = "Información del Usuario";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(109, 56);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(192, 20);
            this.txtApellido.TabIndex = 14;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(35, 59);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(330, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 27);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Nuevo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.Controls.Add(this.dgwUsuarios);
            this.grpUsuarios.Location = new System.Drawing.Point(34, 257);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Size = new System.Drawing.Size(545, 205);
            this.grpUsuarios.TabIndex = 14;
            this.grpUsuarios.TabStop = false;
            this.grpUsuarios.Text = "Usuarios en el sistema";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.btnSalir);
            this.pnlTitulo.Location = new System.Drawing.Point(9, 8);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(605, 27);
            this.pnlTitulo.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(486, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 161);
            this.panel1.TabIndex = 16;
            // 
            // ModuloUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.grpUsuarios);
            this.Controls.Add(this.grpNuevoUsuario);
            this.Name = "ModuloUsuarios";
            this.Text = "UsuarioMenu";
            this.Load += new System.EventHandler(this.ModuloUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).EndInit();
            this.grpNuevoUsuario.ResumeLayout(false);
            this.grpNuevoUsuario.PerformLayout();
            this.grpUsuarios.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgwUsuarios;
        private System.Windows.Forms.GroupBox grpNuevoUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpUsuarios;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Panel panel1;
    }
}