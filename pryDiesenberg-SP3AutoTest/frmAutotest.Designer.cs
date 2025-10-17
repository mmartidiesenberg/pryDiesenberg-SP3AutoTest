namespace pryDiesenberg_SP3AutoTest
{
    partial class frmAutotest
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutotest));
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.nrmAñoFab = new System.Windows.Forms.NumericUpDown();
            this.mskNumero = new System.Windows.Forms.MaskedTextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblAñoFab = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.grpEstadisticas = new System.Windows.Forms.GroupBox();
            this.mskCantTurnos = new System.Windows.Forms.MaskedTextBox();
            this.mskMasAntiguo = new System.Windows.Forms.MaskedTextBox();
            this.mskCant6Caracteres = new System.Windows.Forms.MaskedTextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblMasAntiguo = new System.Windows.Forms.Label();
            this.lblCant6Caracteres = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grpRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrmAñoFab)).BeginInit();
            this.grpEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegistro
            // 
            this.grpRegistro.Controls.Add(this.txtDominio);
            this.grpRegistro.Controls.Add(this.txtTitular);
            this.grpRegistro.Controls.Add(this.nrmAñoFab);
            this.grpRegistro.Controls.Add(this.mskNumero);
            this.grpRegistro.Controls.Add(this.lblTitular);
            this.grpRegistro.Controls.Add(this.lblAñoFab);
            this.grpRegistro.Controls.Add(this.lblDominio);
            this.grpRegistro.Controls.Add(this.lblNumero);
            this.grpRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegistro.Location = new System.Drawing.Point(19, 16);
            this.grpRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRegistro.Size = new System.Drawing.Size(406, 168);
            this.grpRegistro.TabIndex = 0;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "Registro de Turnos";
            // 
            // txtDominio
            // 
            this.txtDominio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDominio.Location = new System.Drawing.Point(152, 62);
            this.txtDominio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(52, 21);
            this.txtDominio.TabIndex = 2;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(152, 128);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(238, 21);
            this.txtTitular.TabIndex = 4;
            this.txtTitular.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitular_Validating);
            // 
            // nrmAñoFab
            // 
            this.nrmAñoFab.Location = new System.Drawing.Point(152, 95);
            this.nrmAñoFab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nrmAñoFab.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.nrmAñoFab.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.nrmAñoFab.Name = "nrmAñoFab";
            this.nrmAñoFab.Size = new System.Drawing.Size(48, 21);
            this.nrmAñoFab.TabIndex = 3;
            this.nrmAñoFab.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // mskNumero
            // 
            this.mskNumero.Location = new System.Drawing.Point(152, 27);
            this.mskNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskNumero.Mask = "99999";
            this.mskNumero.Name = "mskNumero";
            this.mskNumero.Size = new System.Drawing.Size(56, 21);
            this.mskNumero.TabIndex = 1;
            this.mskNumero.ValidatingType = typeof(int);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(22, 128);
            this.lblTitular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(41, 15);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // lblAñoFab
            // 
            this.lblAñoFab.AutoSize = true;
            this.lblAñoFab.Location = new System.Drawing.Point(22, 95);
            this.lblAñoFab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAñoFab.Name = "lblAñoFab";
            this.lblAñoFab.Size = new System.Drawing.Size(95, 15);
            this.lblAñoFab.TabIndex = 2;
            this.lblAñoFab.Text = "Año Fabricación";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(22, 62);
            this.lblDominio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(54, 15);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(22, 30);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(104, 15);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número de Turno";
            // 
            // grpEstadisticas
            // 
            this.grpEstadisticas.Controls.Add(this.mskCantTurnos);
            this.grpEstadisticas.Controls.Add(this.mskMasAntiguo);
            this.grpEstadisticas.Controls.Add(this.mskCant6Caracteres);
            this.grpEstadisticas.Controls.Add(this.lblCantidad);
            this.grpEstadisticas.Controls.Add(this.lblMasAntiguo);
            this.grpEstadisticas.Controls.Add(this.lblCant6Caracteres);
            this.grpEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEstadisticas.Location = new System.Drawing.Point(19, 206);
            this.grpEstadisticas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEstadisticas.Name = "grpEstadisticas";
            this.grpEstadisticas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEstadisticas.Size = new System.Drawing.Size(406, 134);
            this.grpEstadisticas.TabIndex = 0;
            this.grpEstadisticas.TabStop = false;
            this.grpEstadisticas.Text = "Estadísticas";
            // 
            // mskCantTurnos
            // 
            this.mskCantTurnos.Location = new System.Drawing.Point(284, 26);
            this.mskCantTurnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskCantTurnos.Mask = "99999";
            this.mskCantTurnos.Name = "mskCantTurnos";
            this.mskCantTurnos.Size = new System.Drawing.Size(52, 21);
            this.mskCantTurnos.TabIndex = 5;
            this.mskCantTurnos.ValidatingType = typeof(int);
            // 
            // mskMasAntiguo
            // 
            this.mskMasAntiguo.Location = new System.Drawing.Point(284, 64);
            this.mskMasAntiguo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskMasAntiguo.Name = "mskMasAntiguo";
            this.mskMasAntiguo.Size = new System.Drawing.Size(52, 21);
            this.mskMasAntiguo.TabIndex = 6;
            // 
            // mskCant6Caracteres
            // 
            this.mskCant6Caracteres.Location = new System.Drawing.Point(284, 103);
            this.mskCant6Caracteres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskCant6Caracteres.Name = "mskCant6Caracteres";
            this.mskCant6Caracteres.Size = new System.Drawing.Size(52, 21);
            this.mskCant6Caracteres.TabIndex = 7;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(22, 26);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(114, 15);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad de Turnos";
            // 
            // lblMasAntiguo
            // 
            this.lblMasAntiguo.AutoSize = true;
            this.lblMasAntiguo.Location = new System.Drawing.Point(22, 65);
            this.lblMasAntiguo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMasAntiguo.Name = "lblMasAntiguo";
            this.lblMasAntiguo.Size = new System.Drawing.Size(119, 15);
            this.lblMasAntiguo.TabIndex = 5;
            this.lblMasAntiguo.Text = "Año del más Antiguo";
            // 
            // lblCant6Caracteres
            // 
            this.lblCant6Caracteres.AutoSize = true;
            this.lblCant6Caracteres.Location = new System.Drawing.Point(22, 103);
            this.lblCant6Caracteres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCant6Caracteres.Name = "lblCant6Caracteres";
            this.lblCant6Caracteres.Size = new System.Drawing.Size(218, 15);
            this.lblCant6Caracteres.TabIndex = 6;
            this.lblCant6Caracteres.Text = "Cantidad con Dominio de 6 Carácteres";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(438, 257);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 31);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(438, 69);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 31);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(438, 21);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(78, 31);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // frmAutotest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 362);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grpEstadisticas);
            this.Controls.Add(this.grpRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAutotest";
            this.Text = "Auto Test";
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrmAñoFab)).EndInit();
            this.grpEstadisticas.ResumeLayout(false);
            this.grpEstadisticas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.GroupBox grpEstadisticas;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblAñoFab;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblMasAntiguo;
        private System.Windows.Forms.Label lblCant6Caracteres;
        private System.Windows.Forms.MaskedTextBox mskNumero;
        private System.Windows.Forms.MaskedTextBox mskCantTurnos;
        private System.Windows.Forms.MaskedTextBox mskMasAntiguo;
        private System.Windows.Forms.MaskedTextBox mskCant6Caracteres;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.NumericUpDown nrmAñoFab;
        private System.Windows.Forms.TextBox txtDominio;
    }
}

