using CapaPresentacion.Servicios.Implementacion;
using CapaPresentacion.Servicios.Interfaces;
using DataBanco.Dominio;

namespace CapaPresentacion
{

    public partial class FormClientes : Form
    {
        private bool Editar;
        Cliente clienteselct;
        
        public FormClientes()
        {
            InitializeComponent();
            Servicio = new Servicio();
            clienteselct = new Cliente();
            txtID.Enabled = false;


        }
        private IServicio Servicio;
        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
            HabilitarCampos(false);
            txtID.Enabled = false;
        }

        private void CargarClientes()
        {
            dgvClientes.Rows.Clear();
            List<Cliente> lClientes = Servicio.ListClientes();

            foreach (Cliente c in lClientes)
            {
                dgvClientes.Rows.Add(c.Id, c.Nombre, c.Apellido, c.Dni);
            }
        }
   
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtNombre.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos(false);
        }
        private void HabilitarCampos(bool v)
        {
            txtApellido.Enabled = v;
            txtDNI.Enabled = v;
            txtNombre.Enabled = v;
            btnAceptar.Enabled = v;
            btnCancelar.Enabled = v;

            btnAgregarCli.Enabled = !v;
            btnEditar.Enabled = !v;
            btnEliminar.Enabled = !v;
        }

        private void btnAgregarCli_Click(object sender, EventArgs e)
        {
            Editar = false;
            txtDNI.Enabled = true;
            HabilitarCampos(true);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;




            if (dgvClientes.SelectedRows.Count > 0)
            {
                HabilitarCampos(true);
                txtDNI.Enabled = false;
                txtID.Enabled = false;
                txtID.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                txtDNI.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            }
            else
                MessageBox.Show("Debe Seleccionar un cliente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvClientes.SelectedRows.Count > 0)
            {
                try
                {
                    int dni = Convert.ToInt32(dgvClientes.CurrentRow.Cells[3].Value.ToString());
                    int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
                    if (!Servicio.TieneCuentas(id))
                    {
                        Servicio.BajaCliente(dni);
                        CargarClientes();
                        MessageBox.Show("Cuenta eliminada con exito");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("El cliente aun posee cuentas activas, por favor, primero elimine dichas cuenta");
                }
            }
            else
                MessageBox.Show("Debe Seleccionar un cliente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                if (Editar == false)
                    try
                    {
                        clienteselct = new Cliente();
                        clienteselct.Nombre = txtNombre.Text;
                        clienteselct.Apellido = txtApellido.Text;
                        clienteselct.Dni = Convert.ToInt32(txtDNI.Text);

                        Servicio.AltaCli(clienteselct);
                        CargarClientes();
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error >:O" + ex.Message);
                    }

                if (Editar == true)
                {
                    try
                    {
                        clienteselct = new Cliente();
                        clienteselct.Id = Convert.ToInt32(txtID.Text);
                        clienteselct.Nombre = txtNombre.Text;
                        clienteselct.Apellido = txtApellido.Text;
                        clienteselct.Dni = Convert.ToInt32(txtDNI.Text);

                        Servicio.Modificacion(clienteselct);
                        CargarClientes();
                        LimpiarCampos();
                        HabilitarCampos(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error >:O" + ex.Message);
                    }
                


                }
            }
        }



        /*
         ------------------------------------------------------------------------------------------
        -----------------------------------------VALIDACIONES---------------------------------------
        ------------------------------------------------------------------------------------------
         */

        private bool Validacion()
        {
            if (txtApellido.Text == String.Empty)
            {
                MessageBox.Show("El cliente debe tener un apellido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(txtDNI.Text == String.Empty)
            {
                MessageBox.Show("El cliente debe tener un numero de DNI", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }
            if (txtNombre.Text == String.Empty) {
                MessageBox.Show("El cliente debe tener un nombre", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)||char.IsControl(e.KeyChar)||char.IsSeparator(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) )
            {
                return;
            }
            e.Handled = true;
        }
    }


}
