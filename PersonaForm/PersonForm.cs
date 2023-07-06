using PersonaForm.ENTITIES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaForm
{
    public partial class PersonForm : Form
    {
        Persona[] persona;
        private int cont = 0;
        public PersonForm()
        {
            InitializeComponent();
            persona = new Persona[4];
            MessageBox.Show("Este registro solo guarda 4 personas en Memoria.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Guardarbutton2_Click(object sender, EventArgs e)
        {

            if (!Validar()) //verifico que todo los campos esten llenos
                return;
           
            MyerrorProvider1.Clear(); //Limpio el errorProvider para que no se vean errores en pantalla
            
            //Pasamos a cargar la clase 
            Persona person = new Persona();
            person = LlenaClase();

            try
            {
                if(cont < 4)
                {
                    this.persona[cont] = person; //Paso a guardar la persona en el arreglo
                    cont++; //Le sumo otro al contador
                    MessageBox.Show("Guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); // Limpios los campos en pantalla
                }
                           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
               
            }
           


        }

        private Persona LlenaClase()
        {
            Persona p = new Persona();

            p.Id = cont;
            p.Nombre = NombretextBox1.Text;
            p.Direccion = DirecciontextBox2.Text;
            p.Telefono = telefonomaskedTextBox1.Text;

            return p;
        }

        private void LlenaCampos (Persona p)
        {
            IDnumericUpDown1.Value = Convert.ToInt32(p.Id);
            NombretextBox1.Text = p.Nombre;
            DirecciontextBox2.Text = p.Direccion;
            telefonomaskedTextBox1.Text = p.Telefono;
        }

        private void LimpiarCampos()
        {
            MyerrorProvider1.Clear();
            IDnumericUpDown1.Value = 0;
            NombretextBox1.Text = String.Empty;
            DirecciontextBox2.Text = String.Empty;
            telefonomaskedTextBox1.Text = String.Empty;
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider1.Clear();

            if (Convert.ToInt32(IDnumericUpDown1.Value) > 0)
            {
                MyerrorProvider1.SetError(IDnumericUpDown1, "Este campo debe ser 0 para poder guardar el registro.");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NombretextBox1.Text))
            {
                MyerrorProvider1.SetError(NombretextBox1, "Este campo no puede estar vacio");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DirecciontextBox2.Text))
            {
                MyerrorProvider1.SetError(DirecciontextBox2, "Este campo no puede estar vacio");
                paso = false;
            }

            if (telefonomaskedTextBox1.Text.Count() < 10)
            {
                MyerrorProvider1.SetError(telefonomaskedTextBox1, "Este campo debe ser llenado con 10 digitos.");
                paso = false;
            }

            return paso; 
        }

        private void Cancelarbutton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Buscarbutton3_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(IDnumericUpDown1.Value);

            try
            {
                if(persona[Id] == null)
                {
                    MessageBox.Show("Error en referencia Nula");
                    LimpiarCampos();
                    return;
                }
                else
                {
                    NombretextBox1.Text = this.persona[Id].Nombre;
                    DirecciontextBox2.Text = this.persona[Id].Direccion;
                    telefonomaskedTextBox1.Text = this.persona[Id].Telefono;
                }
              
            }
            catch (Exception error)
            {
                MessageBox.Show("Error:" + error.Message);
                
            }
           
        }
    }
}
