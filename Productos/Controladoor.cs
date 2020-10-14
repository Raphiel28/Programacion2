using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocios;

namespace ProyectoGrupal
{
    public partial class frmInicio : Form
    {
        private ServicioProductos servicio;
        private int index;
        private int id;

        public frmInicio()
        {
            servicio = new ServicioProductos();
            index = -1;
            id = 1;
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (index < 0 )
            {
                Agregar(); 
            }
            else
            {
                MessageBox.Show("Dale al boton editar para realizar dicho evento");
            }


        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Debe selecionar para poder editar ");
            }
            else
            {
                Editar();
            }
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }


        private void Agregar() {

            Producto producto = new Producto(id, txtNombre.Text, txtCodigo.Text, txtExistencia.Text , txtVencimiento.Text, txtDescripcion.Text, txtCategoria.Text, txtEstado.Text);
            id++;
            servicio.Agregar(producto);
            LoadData();
            LimpiarDatos();
        }

        private void Editar() {

            Producto producto = new Producto( id ,txtNombre.Text, txtCodigo.Text, txtExistencia.Text, txtVencimiento.Text, txtDescripcion.Text, txtCategoria.Text, txtEstado.Text);

            servicio.Editar(index,producto);

            LoadData();
            LimpiarDatos();
            deseleccionar();
        }

        private void Eliminar() {

            if (index < 0 )
            {
                MessageBox.Show("Debe selecionar algun producto");

            }
            else
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar este producto? ", "Advertencia",MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    servicio.Eliminar(index);
                    LoadData();
                    deseleccionar();
                    LimpiarDatos();
                }
            }
        }
        public void LoadData() 
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = servicio.GetAll();

            dgvProductos.DataSource = bindingSource;
            dgvProductos.ClearSelection();
        
        }

        public void LimpiarDatos() {

                txtNombre.Clear();
                    txtCodigo.Clear();
                        txtExistencia.Clear();
                        txtVencimiento.Clear();
                       txtDescripcion.Clear();
                                    txtCategoria.Clear();
                                        txtEstado.Clear();
        
        
        }
        private void deseleccionar() {
            dgvProductos.ClearSelection();
            index = -1;
        
        }

        public void frmInicio_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;

                txtNombre.Text = dgvProductos.Rows[index].Cells[1].Value.ToString();
                txtCodigo.Text = dgvProductos.Rows[index].Cells[2].Value.ToString();
                txtExistencia.Text = dgvProductos.Rows[index].Cells[3].Value.ToString();
                txtVencimiento.Text = dgvProductos.Rows[index].Cells[4].Value.ToString();
                txtDescripcion.Text = dgvProductos.Rows[index].Cells[5].Value.ToString();
               txtCategoria.Text = dgvProductos.Rows[index].Cells[6].Value.ToString();
               txtEstado.Text  = dgvProductos.Rows[index].Cells[7].Value.ToString();

                

                
            }
            
            

        }

        
        

       
    }
}
