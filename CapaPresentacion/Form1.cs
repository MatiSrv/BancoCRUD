using DataBanco.Datos;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (HelperDB.GetInstance().Logeo(txtUsuario.Text, txtContrase�a.Text)==-1)
            {
                MessageBox.Show("CONTRASE�A INCORRECTA");
            }
            else
            {
                Main frm = new Main();
                this.Hide();
                frm.ShowDialog();
                frm.StartPosition = FormStartPosition.CenterScreen;
                
            }
        }
    }
}