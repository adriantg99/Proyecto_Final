using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winerpest.Ventas
{
    public partial class VentasPrincipal : Form
    {
        Ventas.ConexionVentas ConexionVentas = new Ventas.ConexionVentas();
        public VentasPrincipal()
        {
            InitializeComponent();
        }

        private void VentasPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSet5.VENTAS' Puede moverla o quitarla según sea necesario.
            this.vENTASTableAdapter.Fill(this.winnerPetDataSet5.VENTAS);
            gbxCampos.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtClaveProducto.Enabled = false;
            txtClaveVenta.Enabled = false;
            txtImporte.Enabled = false;
            nudCantidad.Enabled = false;
            gbxOpciones.Enabled = true;

        }
        #region radioButton
        private void rbRegistro_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtClaveProducto.Enabled = true;
            txtClaveVenta.Enabled = true;
            txtImporte.Enabled = true;
            nudCantidad.Enabled = true;
            gbxOpciones.Enabled = true;
            gbxCampos.Enabled = true;
        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = true;
            txtClaveProducto.Enabled = true;
            txtClaveVenta.Enabled = true;
            txtImporte.Enabled = true;
            nudCantidad.Enabled = true;
            gbxOpciones.Enabled = true;
            gbxCampos.Enabled = true;
        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = false;
            txtClaveProducto.Enabled = false;
            txtClaveVenta.Enabled = true;
            txtImporte.Enabled = false;
            nudCantidad.Enabled = false;
            gbxOpciones.Enabled = true;
            gbxCampos.Enabled = true;
        }

        #endregion

        #region Buttons
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtClaveProducto.Text == "" || txtClaveVenta.Text == "" || txtImporte.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");

            }
            else if (ConexionVentas.VentaRegistrada(Convert.ToInt32(txtClaveVenta.Text)) == 0)
            {
                MessageBox.Show(ConexionVentas.InsertarVenta(Convert.ToInt32(txtClaveVenta.Text), Convert.ToInt32(txtImporte.Text), Convert.ToInt32(nudCantidad.Value), Convert.ToInt32(txtClaveProducto.Text)));
                ///MessageBox.Show(ConexionGPS.insertar(Convert.ToInt64(txtImei.Text), Convert.ToString(txtLatitud.Text), Convert.ToString(txtLongitud.Text)));
                txtClaveProducto.Text = "";
                txtClaveVenta.Text = "";
                txtImporte.Text = "";
                nudCantidad.Value = 0;

            }
            else
            {
                MessageBox.Show("No se puede registrar este producto, ya existe uno en la base de datos");
            }
        }
        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtClaveVenta.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (ConexionVentas.VentaRegistrada(Convert.ToInt32(txtClaveVenta.Text)) == 1)
            {
                MessageBox.Show(ConexionVentas.EliminarVenta(Convert.ToInt32(txtClaveVenta.Text)));
                txtClaveVenta.Text = "";

            }
            else
            {
                MessageBox.Show("No existe este usuario");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtClaveProducto.Text == ""||txtClaveVenta.Text == "" || txtImporte.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");

            }
            else if (ConexionVentas.VentaRegistrada(Convert.ToInt32(txtClaveVenta.Text)) == 1)
            {
                MessageBox.Show(ConexionVentas.ActualizarVenta(Convert.ToInt32(txtClaveVenta.Text), Convert.ToInt32(txtImporte.Text), Convert.ToInt32(nudCantidad.Value), Convert.ToInt32(txtClaveProducto.Text)));
                ///MessageBox.Show(ConexionGPS.insertar(Convert.ToInt64(txtImei.Text), Convert.ToString(txtLatitud.Text), Convert.ToString(txtLongitud.Text)));
                txtClaveProducto.Text = "";
                txtClaveVenta.Text = "";
                txtImporte.Text = "";
                nudCantidad.Value = 0;

            }
            else
            {
                MessageBox.Show("No se puede registrar este producto, ya existe uno en la base de datos");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
            this.Close();
        }
    }
}
