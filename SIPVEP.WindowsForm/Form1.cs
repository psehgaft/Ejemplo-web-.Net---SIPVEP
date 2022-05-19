using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIPVEP.CapaLogica;
using SIPVEP.Entidades;

namespace SIPVEP.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var a = new Articulo
            {
                sku = txtSku.Text,
                nombre = txtNombre.Text,
                descripcion = txtDescripcion.Text,
                precio_compra = double.Parse(txtPCompra.Text),
                precio_venta = double.Parse(txtPVenta.Text),
                stock = int.Parse(txtStock.Text)
            };
            try
            {
                var l = new ArticuloLogica();
                a = l.Insertar(a);
                MessageBox.Show("Insertado correctamente: " + a.Id);
                Carga();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Carga();
        }

        private void Carga()
        {
            var l = new ArticuloLogica().Lista();
            gvArticulos.DataSource = l;
        }
    }
}
