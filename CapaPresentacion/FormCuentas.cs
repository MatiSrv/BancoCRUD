using CapaPresentacion.Servicios.Implementacion;
using CapaPresentacion.Servicios.Interfaces;
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
            CargarCboCli();
            BuscarPor();
            cboBuscar.SelectedIndex = 0;
            Habilitar(true);
            LimpiarCampos();
        }

        private void CargarCuentas()
        {
            List<Cuenta> lcuentas = Servicio.Cuentas();

            foreach (Cuenta c in lcuentas)
            {
                dgvCuentas.Rows.Add(c.CodCuenta, c.TipoCuenta, c.Cbu, c.Saldo, c.NombreCli, c.UltimoMovimiento.ToString("d/MM/yyyy"));
            }
        }
        private void CargarCboCli()
        {

            cboCliente.DataSource = Servicio.ListClientes();
            cboCliente.DisplayMember = "NombreCompleto";
            cboCliente.ValueMember = "Id";
        }
        private void BuscarPor()
        {
            if (cboBuscar.SelectedIndex == 0)
            {
                cboBusacarTipoCuenta.Visible = true;
                cboBuscarCli.Visible = false;
                lblDesde.Visible = false;
                lblHasta.Visible = false;
                dtpDesde.Visible = false;
                dtpHasta.Visible = false;
                if (cboBuscar.SelectedIndex == 1)
                {
                    cboBusacarTipoCuenta.Visible = false;
                    cboBuscarCli.Visible = true;
                    lblDesde.Visible = false;
                    lblHasta.Visible = false;
                    dtpDesde.Visible = false;
                    dtpHasta.Visible = false;
                }
                if (cboBuscar.SelectedIndex == 2)
                {
                    cboBusacarTipoCuenta.Visible = false;
                    cboBuscarCli.Visible = false;
                    lblDesde.Visible = true;
                    lblHasta.Visible = true;
                    dtpDesde.Visible = true;
                    dtpHasta.Visible = true;
                }
            }
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
            LimpiarCampos();
            Cuenta c = new Cuenta();
            AbstraerCuenta(c);
            Servicio.AltaCta(c);
            CargarCuentas();

        }
        private void AbstraerCuenta(Cuenta c)
        {
            long cbu;
            double saldo;
            string v;
            string V;
            v = txtCBU.Text;
            V = txtSaldo.Text;
            c.Cbu = Convert.ToInt64(v);
            c.Saldo = Convert.ToDouble(V);
            c.CodTipoCuenta = cboTipoCuenta.SelectedIndex + 1;
            c.UltimoMovimiento = dtpFecha.Value;
            Cliente cliente = (Cliente)cboCliente.SelectedItem;
            c.CodCli = cliente.Id;
        }

      
    }
}
