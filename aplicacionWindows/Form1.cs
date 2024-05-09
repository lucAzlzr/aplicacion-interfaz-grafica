using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "") 
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;

            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;

            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;           
            else
                txtEdad.BackColor = System.Drawing.SystemColors.Control;

            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;

            if (txtApellido.Text != "" && txtNombre.Text != "" && txtEdad.Text != "" && txtDireccion.Text != "")
                txtResultado.Text = "Apellido y nombre: " + txtApellido.Text + " " + txtNombre.Text + Environment.NewLine + "Edad: " + txtEdad.Text + Environment.NewLine + "Dirección: " + txtDireccion.Text;

        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
