using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_Pacientes
{
    public partial class interfaz : Form
    {

        string nombre, apellido, edad, cedula, nacionalidad, telefono, prefijotlf, correo, direccion, sexo, alergia;

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            validacion();
        }

        private void txtTlf_TextChanged(object sender, EventArgs e)
        {
            validacion();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            validacion();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            validacion();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            validacion();
        }

        private void txtAlergia_TextChanged(object sender, EventArgs e)
        {
            validacion();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            validacion();
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            validacion();

        }

        private void validacion() // comprobación de datos proporcionados correctamente
        {
            // validar que no estén vacías
            if (String.IsNullOrEmpty(txtNombres.Text) || String.IsNullOrEmpty(txtApellidos.Text) ||
                String.IsNullOrEmpty(txtEdad.Text) || String.IsNullOrEmpty(txtCedula.Text) ||
                String.IsNullOrEmpty(txtTlf.Text))
            {
                btnGuardar.Enabled = false;
                btnGuardar.BackColor = Color.DarkSlateGray;
            }

            // validación de cajas de texto con su tipo de texto correspondiente
            else if (!txtNombres.Text.All(char.IsLetter) || // validacion nombre
                !txtApellidos.Text.All(char.IsLetter) || // validacion apellido
                !txtEdad.Text.All(char.IsDigit) || // validacion edad
                !txtCedula.Text.All(char.IsDigit) || // validacion cedula
                !txtTlf.Text.All(char.IsDigit) || String.IsNullOrEmpty(txtDireccion.Text) ||
                String.IsNullOrEmpty(txtCorreo.Text)) // validacion telefono
                
            {
                btnGuardar.Enabled = false;
                btnGuardar.BackColor = Color.DarkSlateGray;
            }

            else
            {
                if (rbAlergiaSI.Checked == true && String.IsNullOrEmpty(txtAlergia.Text))
                {
                    btnGuardar.Enabled = false;
                    btnGuardar.BackColor = Color.DarkSlateGray;
                }

                else
                {
                    btnGuardar.Enabled = true;
                    btnGuardar.BackColor = Color.CadetBlue;
                }
            }
        }

        private void limpiar() // limpiar los campos
        {
            txtNombres.ResetText();
            txtApellidos.ResetText();
            txtEdad.ResetText();
            txtCedula.ResetText();
            txtTlf.ResetText();
            txtCorreo.ResetText();
            txtDireccion.ResetText();
            txtAlergia.ResetText();
            rbMasculino.Checked = true;
            rbAlergiaNO.Checked = true;
            selectCedula.SelectedIndex = 0;
            selectTlf.SelectedIndex = 0;
        }

        public interfaz()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectCedula.SelectedIndex = 0;
            selectTlf.SelectedIndex = 0;
        }

        private void rbAlergiaSI_CheckedChanged(object sender, EventArgs e)
        {
            validacion();

            if (rbAlergiaSI.Checked)
            {
                txtAlergia.Enabled = true;
            }

            else
            {
                txtAlergia.Enabled = false;
                txtAlergia.ResetText();
            }
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMasculino.Checked)
            {
                imgMasculino.Visible = true;
                imgFemenino.Visible = false;
            }

            else
            {
                imgMasculino.Visible = false;
                imgFemenino.Visible = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            nombre = txtNombres.Text;
            apellido = txtApellidos.Text;
            edad = txtEdad.Text;
            cedula = txtCedula.Text;
            nacionalidad = selectCedula.Text;
            telefono = txtTlf.Text;
            prefijotlf = selectTlf.Text;
            correo = txtCorreo.Text;
            direccion = txtDireccion.Text;
            alergia = txtAlergia.Text;

            if (rbMasculino.Checked == true)
            {
                sexo = rbMasculino.Text;
            }

            else
            {
                sexo = rbFemenino.Text;
            }

            string mensaje;

            if (rbAlergiaNO.Checked == true)
            {

                mensaje = "Se ha registrado exitosamente a " + nombre + " " + apellido +
                        ", cuya edad es " + edad + " AÑOS" + ", es de género " + sexo +
                        ", es portador de la cédula " + nacionalidad + "-" + cedula +
                        ", su número de teléfono es " + prefijotlf + "-" + telefono +
                        ", su correo es " + correo + ", y reside en " + direccion + ". ¿Desea registrar otro paciente?";
                
            }

            else
            {

                mensaje = "Se ha registrado exitosamente a " + nombre + " " + apellido +
                    ", cuya edad es " + edad + " AÑOS" + ", es de género " + sexo +
                    ", es portador de la cédula " + nacionalidad + "-" + cedula +
                    ", su número de teléfono es " + prefijotlf + "-" + telefono +
                    ", su correo es " + correo + ", reside en " + direccion +
                    ", y tiene alergia a: " + alergia + ". ¿Desea registrar otro paciente?";

            }

            DialogResult repeticion = MessageBox.Show(mensaje, "¡Registro Exitoso!", MessageBoxButtons.YesNo);

            if (repeticion == DialogResult.Yes)
            {
                limpiar();
            }

            else
            {
                this.Dispose();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
