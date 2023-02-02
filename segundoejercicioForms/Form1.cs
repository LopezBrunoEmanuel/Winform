using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundoejercicioForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtbApellido.Text == "")
                txtbApellido.BackColor = Color.Red;
            else
                txtbApellido.BackColor = System.Drawing.SystemColors.Control;

            if (txtbNombre.Text == "")
                txtbNombre.BackColor = Color.Red;
            else
                txtbNombre.BackColor = System.Drawing.SystemColors.Control;

            if (numEdad.Text == "")
                numEdad.BackColor = Color.Red;
            else
                numEdad.BackColor = System.Drawing.SystemColors.Control;

            if (txtbDireccion.Text == "")
                txtbDireccion.BackColor = Color.Red;
            else
                txtbDireccion.BackColor = System.Drawing.SystemColors.Control;

            string apellido = txtbApellido.Text;
            string nombre = txtbNombre.Text;
            string edad = numEdad.Text;
            string direccion = txtbDireccion.Text;
            txtbResultado.Text = "Apeliido y Nombre:  " + apellido.ToUpper() + " , " + nombre.ToUpper() + 
                Environment.NewLine + " Edad:  " + edad +
                Environment.NewLine + " Dirección: " + direccion.ToUpper();
            
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
