using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;

namespace CapaVista
{
    public partial class Form1 : Form
    {
        MantenimientoDatosCategorias M_Categorias = new MantenimientoDatosCategorias();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Obtienes el dato nombre de la interfaz, y le das el formato de string
            string nombre = txtNombre.Text;

            try
            {
                //Envias el dato a la funcion correspondiente
                M_Categorias.AgregarRegistro(nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            try
            {
                ArrayList datos = M_Categorias.BuscarRegistro(id);
                txtNombre.Text = (string)datos[1];
                if ((bool)datos[2] == true) { rdbActivo.Checked = true; }
                else { rdbInactivo.Checked = true; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string nombre = txtNombre.Text;
            bool estado = true;
            if (rdbActivo.Checked == true) { estado = true; }
            else { estado = false; }

            try
            {
                M_Categorias.ModificarRegistro(id, nombre, estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            try
            {
                M_Categorias.EliminarRegistro(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}