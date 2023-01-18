using CapaPresentacion.Servicios.Implementacion;
using CapaPresentacion.Servicios.Interfaces;
using DataBanco.Datos.Interfaces;
using DataBanco.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormCuentas : Form
    {
        public FormCuentas()
        {
            InitializeComponent();
            Servicio = new Servicio();

        }
        private IServicio Servicio;
        private bool Editar;

        private void FormCuentas_Load(object sender, EventArgs e)
        {
            CargarCuentas();
            CargarCboCli(cboCliente);
            CargarCboCli(cboBuscarCli);
            Habilitar(true);
            LimpiarCampos();
            IniciarFiltros();
        }

        private void CargarCuentas()
        {
            dgvCuentas.Rows.Clear();
            List<Cuenta> lcuentas = Servicio.Cuentas();

            foreach (Cuenta c in lcuentas)
            {
                dgvCuentas.Rows.Add(c.CodCuenta, c.TipoCuenta, c.Cbu, c.Saldo, c.NombreCli, c.UltimoMovimiento.ToString("d/MM/yyyy"));
            }
        }
        private void CargarCboCli(ComboBox comboBox)
        {

            comboBox.DataSource = Servicio.ListClientes();
            comboBox.DisplayMember = "NombreCompleto";
            comboBox.ValueMember = "Id";
        }
       
       
        private void Habilitar(bool v)
        {
            btnAgregarCta.Enabled = v;

            btnEliminar.Enabled = v;

            btnCancelar.Enabled = !v;
            txtCBU.Enabled = !v;
            txtSaldo.Enabled = !v;
            cboCliente.Enabled = !v;
            cboTipoCuenta.Enabled = !v;
            dtpFecha.Enabled = !v;
            btnAgregar.Enabled = !v;
            btnGenerar.Enabled = !v;
        }
        private void LimpiarCampos()
        {
            txtCBU.Clear();
            txtSaldo.Clear();
            cboCliente.SelectedIndex = 0;
            cboTipoCuenta.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Today;
        }
        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UltimoMov_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCta_Click(object sender, EventArgs e)
        {
            Habilitar(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            LimpiarCampos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
           
            Cuenta c = new Cuenta();
            AbstraerCuenta(c);
            Servicio.AltaCta(c);
            CargarCuentas();
            LimpiarCampos();
        }
        private void AbstraerCuenta(Cuenta c)
        {
            long cbu;
            double saldo;

            cbu = Convert.ToInt64(txtCBU.Text);
            saldo = Convert.ToDouble(txtSaldo.Text);
            c.Cbu = cbu;
            c.Saldo = saldo;
            c.CodTipoCuenta = cboTipoCuenta.SelectedIndex + 1;
            c.UltimoMovimiento = dtpFecha.Value;
            Cliente cliente = (Cliente)cboCliente.SelectedItem;
            c.CodCli = cliente.Id;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count > 0)
            {
                int cod = Convert.ToInt32(dgvCuentas.CurrentRow.Cells[0].Value);
                Servicio.BajaCuenta(cod);
                CargarCuentas();
            }
            else
                MessageBox.Show("Debe Seleccionar una cuenta", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var number = string.Concat(Enumerable.Range(0, 15).Select(x => random.Next(0, 10)));
            txtCBU.Clear();
            txtCBU.Text = number;
        }

        private void cboBuscar_TextChanged(object sender, EventArgs e)
        {
                if (cboBuscar.Text == "Tipo de Cuenta")
                {
                    cboBuscarTipoCuenta.Visible = true;
                    cboBuscarCli.Visible = false;
                    lblDesde.Visible = false;
                    lblHasta.Visible = false;
                    dtpDesde.Visible = false;
                    dtpHasta.Visible = false;
                }
                if (cboBuscar.Text == "Cliente")
                {
                    cboBuscarCli.Visible = true;
                    cboBuscarTipoCuenta.Visible = false;
                    lblDesde.Visible = false;
                    lblHasta.Visible = false;
                    dtpDesde.Visible = false;
                    dtpHasta.Visible = false;
                }
                if (cboBuscar.Text == "Fecha de Movimientos")
                {

                    lblDesde.Visible = true;
                    lblHasta.Visible = true;
                    dtpDesde.Visible = true;
                    dtpHasta.Visible = true;
                    cboBuscarTipoCuenta.Visible = false;
                    cboBuscarCli.Visible = false;
                }
           
        }
        private void IniciarFiltros()
        {
            cboBuscarCli.Visible = false;
            cboBuscarTipoCuenta.Visible = false;
            lblDesde.Visible = false;
            lblHasta.Visible = false;
            dtpDesde.Visible = false;
            dtpHasta.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboBuscar.Text == "Tipo de Cuenta")
            {
                string tc = cboBuscarTipoCuenta.Text;
                dgvCuentas.Rows.Clear();
                List <Cuenta> lcuentas = Servicio.Cargar_CuentasTC(tc);
                foreach (Cuenta c in lcuentas)
                {
                    dgvCuentas.Rows.Add(c.CodCuenta, c.TipoCuenta, c.Cbu, c.Saldo, c.NombreCli, c.UltimoMovimiento.ToString("d/MM/yyyy"));
                }
            }
            if (cboBuscar.Text == "Cliente")
            {
                dgvCuentas.Rows.Clear();


                Cliente cli = (Cliente)cboBuscarCli.SelectedItem;
                List<Cuenta> lcuentas = Servicio.Cargar_CuentasCLI(cli.Dni);
                foreach (Cuenta c in lcuentas)
                {
                    dgvCuentas.Rows.Add(c.CodCuenta, c.TipoCuenta, c.Cbu, c.Saldo, c.NombreCli, c.UltimoMovimiento.ToString("d/MM/yyyy"));
                }
            }
            if (cboBuscar.Text == "Fecha de Movimientos")
            {
                dgvCuentas.Rows.Clear();

                DateTime desde = dtpDesde.Value;
                DateTime hasta = dtpHasta.Value;

                List<Cuenta> lcuentas = Servicio.Cargar_CuentasFEC(desde, hasta);
                foreach (Cuenta c in lcuentas)
                {
                    dgvCuentas.Rows.Add(c.CodCuenta, c.TipoCuenta, c.Cbu, c.Saldo, c.NombreCli, c.UltimoMovimiento.ToString("d/MM/yyyy"));
                }
            }
        }

        private void LimpiarFiltro_Click(object sender, EventArgs e)
        {
            dgvCuentas.Rows.Clear();
            CargarCuentas();
        }
    }
    
}
