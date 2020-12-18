using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winerpest.Facturas
{
    public partial class Facturas : Form
    {
        ConexionFacturas ConexionFactura = new ConexionFacturas();
        public Facturas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtClaveCliente.Text==""||txtCveFact.Text==""||txtCVEVEnta.Text==""||txtIva.Text==""||txtSubtotal.Text==""||txtTotal.Text=="")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (ConexionFactura.facturaRegistrada((txtCveFact.Text)) == 0)
            {
                MessageBox.Show(ConexionFactura.insertarFactura((txtCveFact.Text), Convert.ToInt32(txtSubtotal.Text), Convert.ToInt32(txtIva.Text),Convert.ToInt32(txtTotal.Text),Convert.ToInt32(txtCVEVEnta.Text),Convert.ToInt32(txtClaveCliente.Text)));
                txtClaveCliente.Text = "";
                txtCveFact.Text = "";
                txtCVEVEnta.Text = "";
                txtIva.Text = "";
                txtSubtotal.Text = "";
                txtTotal.Text = "";

            }
            else
            {
                MessageBox.Show("No se puede registrar esta Factura, ya existe uno en la base de datos");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtClaveCliente.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (ConexionFactura.facturaRegistrada((txtCveFact.Text)) == 1)
            {
                MessageBox.Show(ConexionFactura.eliminarFactura(txtCveFact.Text));
                txtClaveCliente.Text = "";
                txtCveFact.Text = "";
                txtCVEVEnta.Text = "";
                txtIva.Text = "";
                txtSubtotal.Text = "";
                txtTotal.Text = "";

            }
            else
            {
                MessageBox.Show("No se puede registrar esta Factura, ya existe uno en la base de datos");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtClaveCliente.Text == "" || txtCveFact.Text == "" || txtCVEVEnta.Text == "" || txtIva.Text == "" || txtSubtotal.Text == "" || txtTotal.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (ConexionFactura.facturaRegistrada((txtCveFact.Text)) == 1)
            {
                MessageBox.Show(ConexionFactura.ActualizarFactura((txtCveFact.Text), Convert.ToInt32(txtSubtotal.Text), Convert.ToInt32(txtIva.Text), Convert.ToInt32(txtTotal.Text), Convert.ToInt32(txtCVEVEnta.Text), Convert.ToInt32(txtClaveCliente.Text)));
                txtClaveCliente.Text = "";
                txtCveFact.Text = "";
                txtCVEVEnta.Text = "";
                txtIva.Text = "";
                txtSubtotal.Text = "";
                txtTotal.Text = "";

            }
            else
            {
                MessageBox.Show("No se puede registrar esta Factura, ya existe uno en la base de datos");
            }
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSet6.FACTURA' Puede moverla o quitarla según sea necesario.
            this.fACTURATableAdapter.Fill(this.winnerPetDataSet6.FACTURA);
            gbxCampos.Enabled = false;
            gbxOpciones.Enabled = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 Principal = new Form1();
            Principal.Visible = true;
            this.Close();
        }

        private void rbRegistro_CheckedChanged(object sender, EventArgs e)
        {
            gbxOpciones.Enabled = true;
            gbxCampos.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtClaveCliente.Enabled = true;
            txtCVEVEnta.Enabled = true;
            txtIva.Enabled = true;
            txtSubtotal.Enabled = true;
            txtTotal.Enabled = true;

        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            gbxCampos.Enabled = true;
            gbxOpciones.Enabled = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = false;
            txtClaveCliente.Enabled = false;
            txtCVEVEnta.Enabled = false;
            txtIva.Enabled = false;
            txtSubtotal.Enabled = false;
            txtTotal.Enabled = false;

        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            gbxCampos.Enabled = true;
            gbxOpciones.Enabled = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = true;
            txtClaveCliente.Enabled = true;
            txtCVEVEnta.Enabled = true;
            txtIva.Enabled = true;
            txtSubtotal.Enabled = true;
            txtTotal.Enabled = true;
        }
    }
}
