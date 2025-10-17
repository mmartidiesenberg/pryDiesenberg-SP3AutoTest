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
            this.grpRegistro.Location = new System.Drawing.Point(38, 30);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(813, 324);
            this.grpRegistro.TabIndex = 0;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "Registro de Turnos";
            // 
            // txtDominio
            // 
            this.txtDominio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDominio.Location = new System.Drawing.Point(305, 116);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(100, 35);
            this.txtDominio.TabIndex = 7;
            this.txtDominio.TextChanged += new System.EventHandler(this.txtDominio_TextChanged_1);
            this.txtDominio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_KeyPress);
            this.txtDominio.Validating += new System.ComponentModel.CancelEventHandler(this.txtDominio_Validating);
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(305, 246);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(471, 35);
            this.txtTitular.TabIndex = 6;
            // 
            // nrmAñoFab
            // 
            this.nrmAñoFab.Location = new System.Drawing.Point(305, 183);
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
            this.nrmAñoFab.Size = new System.Drawing.Size(96, 35);
            this.nrmAñoFab.TabIndex = 5;
            this.nrmAñoFab.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // mskNumero
            // 
            this.mskNumero.Location = new System.Drawing.Point(305, 51);
            this.mskNumero.Mask = "99999";
            this.mskNumero.Name = "mskNumero";
            this.mskNumero.Size = new System.Drawing.Size(108, 35);
            this.mskNumero.TabIndex = 3;
            this.mskNumero.ValidatingType = typeof(int);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(43, 246);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(81, 29);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // lblAñoFab
            // 
            this.lblAñoFab.AutoSize = true;
            this.lblAñoFab.Location = new System.Drawing.Point(43, 183);
            this.lblAñoFab.Name = "lblAñoFab";
            this.lblAñoFab.Size = new System.Drawing.Size(187, 29);
            this.lblAñoFab.TabIndex = 2;
            this.lblAñoFab.Text = "Año Fabricación";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(43, 119);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(103, 29);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(43, 57);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(204, 29);
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
            this.grpEstadisticas.Location = new System.Drawing.Point(38, 396);
            this.grpEstadisticas.Name = "grpEstadisticas";
            this.grpEstadisticas.Size = new System.Drawing.Size(813, 258);
            this.grpEstadisticas.TabIndex = 0;
            this.grpEstadisticas.TabStop = false;
            this.grpEstadisticas.Text = "Estadísticas";
            // 
            // mskCantTurnos
            // 
            this.mskCantTurnos.Location = new System.Drawing.Point(569, 50);
            this.mskCantTurnos.Mask = "99999";
            this.mskCantTurnos.Name = "mskCantTurnos";
            this.mskCantTurnos.Size = new System.Drawing.Size(100, 35);
            this.mskCantTurnos.TabIndex = 4;
            this.mskCantTurnos.ValidatingType = typeof(int);
            // 
            // mskMasAntiguo
            // 
            this.mskMasAntiguo.Location = new System.Drawing.Point(569, 123);
            this.mskMasAntiguo.Name = "mskMasAntiguo";
            this.mskMasAntiguo.Size = new System.Drawing.Size(100, 35);
            this.mskMasAntiguo.TabIndex = 5;
            // 
            // mskCant6Caracteres
            // 
            this.mskCant6Caracteres.Location = new System.Drawing.Point(569, 198);
            this.mskCant6Caracteres.Name = "mskCant6Caracteres";
            this.mskCant6Caracteres.Size = new System.Drawing.Size(100, 35);
            this.mskCant6Caracteres.TabIndex = 6;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(43, 50);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(225, 29);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad de Turnos";
            // 
            // lblMasAntiguo
            // 
            this.lblMasAntiguo.AutoSize = true;
            this.lblMasAntiguo.Location = new System.Drawing.Point(43, 125);
            this.lblMasAntiguo.Name = "lblMasAntiguo";
            this.lblMasAntiguo.Size = new System.Drawing.Size(233, 29);
            this.lblMasAntiguo.TabIndex = 5;
            this.lblMasAntiguo.Text = "Año del más Antiguo";
            // 
            // lblCant6Caracteres
            // 
            this.lblCant6Caracteres.AutoSize = true;
            this.lblCant6Caracteres.Location = new System.Drawing.Point(43, 198);
            this.lblCant6Caracteres.Name = "lblCant6Caracteres";
            this.lblCant6Caracteres.Size = new System.Drawing.Size(426, 29);
            this.lblCant6Caracteres.TabIndex = 6;
            this.lblCant6Caracteres.Text = "Cantidad con Dominio de 6 Carácteres";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(877, 494);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(156, 60);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(877, 133);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(156, 60);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(877, 40);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(156, 60);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmAutotest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 696);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grpEstadisticas);
            this.Controls.Add(this.grpRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

