using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winerpest.Cliente
{
    public partial class EliminarCliente : Form
    {
        Conexiones.ConexionEliminar eliminar = new Conexiones.ConexionEliminar();
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gbxNombre.Enabled = false;
            gbxTelefono.Enabled = false;
            gbxID.Enabled = true;
            txtboxId.Text = "";
            txtboxName.Text = "";
            txtboxTelefon.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gbxID.Enabled = false;
            gbxNombre.Enabled = true;
            gbxTelefono.Enabled = false;
            txtboxId.Text = "";
            txtboxName.Text = "";
            txtboxTelefon.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gbxID.Enabled = false;
            gbxNombre.Enabled = false;
            gbxTelefono.Enabled = true;
            txtboxId.Text = "";
            txtboxName.Text = "";
            txtboxTelefon.Text = "";

        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'winnerpetDataSetCliente.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter2.Fill(this.winnerpetDataSetCliente.cliente);

            gbxID.Enabled = false;
            gbxNombre.Enabled = false;
            gbxTelefono.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Opciones_clientes volver = new Opciones_clientes();
            volver.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtboxTelefon.Text == string.Empty)
            {
                MessageBox.Show("Llenar el campo adecuado");
            }
            else
            {
                MessageBox.Show(eliminar.EliminarClienteTelefono((txtboxTelefon.Text)));
                txtboxId.Text = "";
            }
        }

        private void btnEliminarId_Click(object sender, EventArgs e)
        {
            if (txtboxId.Text == string.Empty)
            {
                MessageBox.Show("Llenar el campo adecuado");
            }
            else
            {
                MessageBox.Show(eliminar.EliminarClienteId(Convert.ToInt32(txtboxId.Text)));
                txtboxId.Text = "";
            }
          

        }

        private void btnEliminarName_Click(object sender, EventArgs e)
        {
            if (txtboxName.Text == string.Empty)
            {
                MessageBox.Show("Llenar el campo adecuado");
            }
            else
            {
                MessageBox.Show(eliminar.EliminarClienteNombre((txtboxName.Text)));
                txtboxId.Text = "";
            }
       
        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

