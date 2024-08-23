using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudDefensa.Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void conexion_Click(object sender, EventArgs e)
        {
            Clases.CConexion objetoConexion = new Clases.CConexion();
            objetoConexion.establecerConexion();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          clientes clientes =new clientes();
            clientes.Show();
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            Empleados empleados =new Empleados();
            empleados.Show();
        }

        private void Inventario_Click(object sender, EventArgs e)
        {
            inventario inventario=new inventario();
            inventario.Show();
        }

        private void marca_Click(object sender, EventArgs e)
        {
            Marca marca =new Marca();
            marca.Show();
        }

        private void Producto_Click(object sender, EventArgs e)
        {
            Producto producto =new Producto();
            producto.Show();
        }

        private void proveedor_Click(object sender, EventArgs e)
        {
            proveedor proveedor =new proveedor();
            proveedor.Show();

        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            Tienda tienda =new Tienda();    
            tienda.Show();
        }

        private void btnTipoProducto_Click(object sender, EventArgs e)
        {
            tipo_producto tipo_Producto =new tipo_producto();
            tipo_Producto.Show();
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            Ubicacion ubicacion =new Ubicacion();
            ubicacion.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            factura factura =new factura(); 
            factura.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            detalle_factura detalle_Factura=new detalle_factura();
            detalle_Factura.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tipo_empleado tipo_empleado=new tipo_empleado();
            tipo_empleado.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            producto_vendedor producto_Vendedor =new producto_vendedor();
            producto_Vendedor.Show();
        }

        private void bdinventarioP_Click(object sender, EventArgs e)
        {
            Invemtario inventario = new Invemtario();
            inventario.Show();
        }

        private void comprasClientes_Click(object sender, EventArgs e)
        {
            comprasPorClientes compras = new comprasPorClientes();
            compras.Show();
        }

        private void bdHistorial_Click(object sender, EventArgs e)
        {
            Historialcs his = new Historialcs();
            his.Show();
        }

        private void bdTop_Click(object sender, EventArgs e)
        {
            top20 top = new top20();
            top.Show();
        }

        private void bdtop20P_Click(object sender, EventArgs e)
        {
            top20ProdutocsXtienda t2 = new top20ProdutocsXtienda();
            t2.Show();
        }

        private void bdtop5tiendas_Click(object sender, EventArgs e)
        {
            Top5Tiendas t5 = new Top5Tiendas();
            t5.Show();
        }

        private void bdcocaPepsi_Click(object sender, EventArgs e)
        {
            coca_mas_pepsi cp = new coca_mas_pepsi();
            cp.Show();
        }

        private void coca_mas_pepsi_Click(object sender, EventArgs e)
        {
            porductoasAdemasLeche pl = new porductoasAdemasLeche();
            pl.Show();
        }
    }
}
