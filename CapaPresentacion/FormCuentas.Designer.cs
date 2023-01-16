namespace CapaPresentacion
{
    partial class FormCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCuentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCuentas = new System.Windows.Forms.Label();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.cCodCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCBU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUltimoMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarCta = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.txtCBU = new System.Windows.Forms.TextBox();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblCBU = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.UltimoMov = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.cboBusacarTipoCuenta = new System.Windows.Forms.ComboBox();
            this.cboBuscarCli = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(852, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuentas.Location = new System.Drawing.Point(23, 40);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(147, 20);
            this.lblCuentas.TabIndex = 1;
            this.lblCuentas.Text = "Listado de Cuentas";
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodCuenta,
            this.cTipoCuenta,
            this.cCBU,
            this.cSaldo,
            this.cCliente,
            this.cUltimoMov});
            this.dgvCuentas.EnableHeadersVisualStyles = false;
            this.dgvCuentas.GridColor = System.Drawing.Color.White;
            this.dgvCuentas.Location = new System.Drawing.Point(12, 158);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCuentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuentas.RowTemplate.Height = 25;
            this.dgvCuentas.Size = new System.Drawing.Size(745, 402);
            this.dgvCuentas.TabIndex = 2;
            this.dgvCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_CellContentClick);
            // 
            // cCodCuenta
            // 
            this.cCodCuenta.HeaderText = "ID Cuenta";
            this.cCodCuenta.Name = "cCodCuenta";
            this.cCodCuenta.ReadOnly = true;
            this.cCodCuenta.Width = 53;
            // 
            // cTipoCuenta
            // 
            this.cTipoCuenta.HeaderText = "Tipo de Cuenta";
            this.cTipoCuenta.Name = "cTipoCuenta";
            this.cTipoCuenta.ReadOnly = true;
            this.cTipoCuenta.Width = 150;
            // 
            // cCBU
            // 
            this.cCBU.HeaderText = "CBU";
            this.cCBU.Name = "cCBU";
            this.cCBU.ReadOnly = true;
            this.cCBU.Width = 200;
            // 
            // cSaldo
            // 
            this.cSaldo.HeaderText = "Saldo";
            this.cSaldo.Name = "cSaldo";
            this.cSaldo.ReadOnly = true;
            // 
            // cCliente
            // 
            this.cCliente.HeaderText = "Cliente";
            this.cCliente.Name = "cCliente";
            this.cCliente.ReadOnly = true;
            // 
            // cUltimoMov
            // 
            this.cUltimoMov.HeaderText = "Ultimo Movimiento";
            this.cUltimoMov.Name = "cUltimoMov";
            this.cUltimoMov.ReadOnly = true;
            // 
            // btnAgregarCta
            // 
            this.btnAgregarCta.Location = new System.Drawing.Point(36, 566);
            this.btnAgregarCta.Name = "btnAgregarCta";
            this.btnAgregarCta.Size = new System.Drawing.Size(104, 36);
            this.btnAgregarCta.TabIndex = 3;
            this.btnAgregarCta.Text = "Agregar";
            this.btnAgregarCta.UseVisualStyleBackColor = true;
            this.btnAgregarCta.Click += new System.EventHandler(this.btnAgregarCta_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(160, 567);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 36);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(633, 567);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 36);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(763, 199);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(71, 15);
            this.lblTipoCuenta.TabIndex = 7;
            this.lblTipoCuenta.Text = "Tipo Cuenta";
            // 
            // txtCBU
            // 
            this.txtCBU.Location = new System.Drawing.Point(841, 252);
            this.txtCBU.Name = "txtCBU";
            this.txtCBU.Size = new System.Drawing.Size(217, 23);
            this.txtCBU.TabIndex = 8;
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Items.AddRange(new object[] {
            "Caja de Ahorro",
            "Cuenta Corriente",
            "Cuenta Sueldo\t\t"});
            this.cboTipoCuenta.Location = new System.Drawing.Point(841, 196);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(217, 23);
            this.cboTipoCuenta.TabIndex = 9;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(841, 306);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(217, 23);
            this.txtSaldo.TabIndex = 10;
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(841, 363);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(217, 23);
            this.cboCliente.TabIndex = 11;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(841, 419);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(217, 23);
            this.dtpFecha.TabIndex = 12;
            // 
            // lblCBU
            // 
            this.lblCBU.AutoSize = true;
            this.lblCBU.Location = new System.Drawing.Point(804, 255);
            this.lblCBU.Name = "lblCBU";
            this.lblCBU.Size = new System.Drawing.Size(30, 15);
            this.lblCBU.TabIndex = 13;
            this.lblCBU.Text = "CBU";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(798, 309);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(36, 15);
            this.lblSaldo.TabIndex = 14;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(791, 366);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 15;
            this.lblCliente.Text = "Cliente";
            // 
            // UltimoMov
            // 
            this.UltimoMov.AutoSize = true;
            this.UltimoMov.Location = new System.Drawing.Point(763, 412);
            this.UltimoMov.Name = "UltimoMov";
            this.UltimoMov.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UltimoMov.Size = new System.Drawing.Size(72, 30);
            this.UltimoMov.TabIndex = 16;
            this.UltimoMov.Text = "Ultimo \r\nMovimiento";
            this.UltimoMov.Click += new System.EventHandler(this.UltimoMov_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(787, 481);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(271, 36);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.Location = new System.Drawing.Point(23, 104);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(85, 18);
            this.lblBuscar.TabIndex = 18;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // cboBuscar
            // 
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "Tipo de Cuenta",
            "Cliente\t",
            "Fecha de Movimientos"});
            this.cboBuscar.Location = new System.Drawing.Point(114, 104);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(127, 23);
            this.cboBuscar.TabIndex = 20;
            // 
            // cboBusacarTipoCuenta
            // 
            this.cboBusacarTipoCuenta.FormattingEnabled = true;
            this.cboBusacarTipoCuenta.Location = new System.Drawing.Point(265, 104);
            this.cboBusacarTipoCuenta.Name = "cboBusacarTipoCuenta";
            this.cboBusacarTipoCuenta.Size = new System.Drawing.Size(127, 23);
            this.cboBusacarTipoCuenta.TabIndex = 21;
            // 
            // cboBuscarCli
            // 
            this.cboBuscarCli.FormattingEnabled = true;
            this.cboBuscarCli.Location = new System.Drawing.Point(412, 104);
            this.cboBuscarCli.Name = "cboBuscarCli";
            this.cboBuscarCli.Size = new System.Drawing.Size(127, 23);
            this.cboBuscarCli.TabIndex = 22;
            this.cboBuscarCli.Visible = false;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(289, 92);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(39, 15);
            this.lblDesde.TabIndex = 23;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(291, 123);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(37, 15);
            this.lblHasta.TabIndex = 24;
            this.lblHasta.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(355, 85);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(217, 23);
            this.dtpDesde.TabIndex = 25;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(355, 117);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(217, 23);
            this.dtpHasta.TabIndex = 26;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(633, 92);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 46);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(983, 277);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 28;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // FormCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.cboBuscarCli);
            this.Controls.Add(this.cboBusacarTipoCuenta);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.UltimoMov);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblCBU);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.cboTipoCuenta);
            this.Controls.Add(this.txtCBU);
            this.Controls.Add(this.lblTipoCuenta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarCta);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.lblCuentas);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCuentas";
            this.Text = "FormCuentas";
            this.Load += new System.EventHandler(this.FormCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCuentas;
        private DataGridView dgvCuentas;
        private Button btnAgregarCta;
        private Button btnEliminar;
        private Button btnCancelar;
        private Label lblTipoCuenta;
        private TextBox txtCBU;
        private ComboBox cboTipoCuenta;
        private TextBox txtSaldo;
        private ComboBox cboCliente;
        private DateTimePicker dtpFecha;
        private Label lblCBU;
        private Label lblSaldo;
        private Label lblCliente;
        private Label UltimoMov;
        private Button btnAgregar;
        private Label lblBuscar;
        private ComboBox cboBuscar;
        private ComboBox cboBusacarTipoCuenta;
        private ComboBox cboBuscarCli;
        private Label lblDesde;
        private Label lblHasta;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn cCodCuenta;
        private DataGridViewTextBoxColumn cTipoCuenta;
        private DataGridViewTextBoxColumn cCBU;
        private DataGridViewTextBoxColumn cSaldo;
        private DataGridViewTextBoxColumn cCliente;
        private DataGridViewTextBoxColumn cUltimoMov;
        private Button btnGenerar;
    }
}