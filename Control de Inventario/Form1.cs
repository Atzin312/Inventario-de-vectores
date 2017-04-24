using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Inventario
{
    public partial class Form1 : Form
    {
        Inventario inventario = new Inventario();
        Producto producto;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            inventario.Agregar(producto = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text)));
            txtCodigo.Clear(); txtNombre.Clear(); txtCantidad.Clear(); txtCosto.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Producto busqueda = inventario.Buscar(Convert.ToInt32(txtBuscar.Text));

            if (busqueda != null)
            {
                txtCodigo.Text = Convert.ToString(busqueda.regresarCodigo());
                txtNombre.Text = Convert.ToString(busqueda.regresarNombre());
                txtCantidad.Text = Convert.ToString(busqueda.regresarCantidad());
                txtCosto.Text = Convert.ToString(busqueda.regresarCosto());
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            inventario.Insertar(producto = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text)),Convert.ToInt32(txtInsertar.Text));
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = inventario.Reporte();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inventario.Eliminar(Convert.ToInt32(txtEliminar.Text));
        }
    }
}
