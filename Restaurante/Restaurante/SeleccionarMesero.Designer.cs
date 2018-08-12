namespace Restaurante
{
    partial class SeleccionarMesero
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cmbMesero = new System.Windows.Forms.ComboBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtCaja = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1036, 34);
            this.label1.TabIndex = 51;
            this.label1.Text = "Control de Pedidos\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.wave2;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 484);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1032, 87);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(917, 54);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 54);
            this.btnSalir.TabIndex = 53;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(338, 63);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(46, 13);
            this.lblProveedor.TabIndex = 57;
            this.lblProveedor.Text = "N# Caja";
            // 
            // cmbMesero
            // 
            this.cmbMesero.FormattingEnabled = true;
            this.cmbMesero.Location = new System.Drawing.Point(101, 60);
            this.cmbMesero.Name = "cmbMesero";
            this.cmbMesero.Size = new System.Drawing.Size(213, 21);
            this.cmbMesero.TabIndex = 54;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(41, 63);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(42, 13);
            this.lblUnidad.TabIndex = 56;
            this.lblUnidad.Text = "Mesero";
            // 
            // txtCaja
            // 
            this.txtCaja.Location = new System.Drawing.Point(390, 60);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(109, 20);
            this.txtCaja.TabIndex = 58;
            // 
            // SeleccionarMesero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 569);
            this.Controls.Add(this.txtCaja);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.cmbMesero);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionarMesero";
            this.Text = "SeleccionarMesero";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbMesero;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtCaja;
    }
}