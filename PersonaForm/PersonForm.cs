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
      //  Persona[] persona;
        List<Persona> listaPersona;
        private int cont = 0;
        public PersonForm()
        {
            InitializeComponent();
            FiltrocomboBox1.SelectedIndex = 0;
            //persona = new Persona[4];
            listaPersona = new List<Persona>(); 
           // MessageBox.Show("Este registro solo guarda 4 personas en Memoria.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                listaPersona.Add(person);
                cont++;
                MessageBox.Show("Guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); // Limpios los campos en pantalla
                                      
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
            p.Birthday = BirthdaydateTimePicker1.Value;
            p.Age = Convert.ToInt32(AgetextBox1.Text);

            return p;
        }

        private void LlenaCampos (Persona p)
        {
            IDnumericUpDown1.Value = Convert.ToInt32(p.Id);
            NombretextBox1.Text = p.Nombre;
            DirecciontextBox2.Text = p.Direccion;
            telefonomaskedTextBox1.Text = p.Telefono;
            BirthdaydateTimePicker1.Value = p.Birthday;
            AgetextBox1.Text = p.Age.ToString();
        }

        private void LimpiarCampos()
        {
            MyerrorProvider1.Clear();
            IDnumericUpDown1.Value = 0;
            NombretextBox1.Text = String.Empty;
            DirecciontextBox2.Text = String.Empty;
            telefonomaskedTextBox1.Text = String.Empty;
            BirthdaydateTimePicker1.Value = DateTime.Now;
            AgetextBox1.Text = string.Empty;
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
            int id = Convert.ToInt32(IDnumericUpDown1.Value);
           
            try
            {

                var list = listaPersona.Where(p => p.Id == id).ToList();

                foreach (var item in list)
                {
                    if(item.Id == id)
                    {
                        LlenaCampos(item);
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error:" + error.Message);
                
            }
           
        }

        private void BirthdaydateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CalcularEdad();
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CalcularEdad();
            }
        }

        private void CalcularEdad()
        {
            int edad = Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(BirthdaydateTimePicker1.Value.Year);

            AgetextBox1.Text = edad.ToString();
        }

        private void Consultarbutton1_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void consulta()
        {
            try
            {
                int opcion = FiltrocomboBox1.SelectedIndex;
                List<Persona> lista = new List<Persona>();


                switch (opcion)
                {
                    case 0:
                        MostrarConsulta(listaPersona);
                        break;
                    case 1:
                        lista = listaPersona.Where(p => p.Nombre.Contains(CriteriotextBox1.Text)).ToList();
                        MostrarConsulta(lista);
                        break;
                    case 2:
                        lista = listaPersona.Where(p => p.Telefono.Contains(CriteriotextBox1.Text)).ToList();
                        MostrarConsulta(lista);
                        break;
                }
            }
            catch (Exception)
            {

               
            }
        }

        private void MostrarConsulta(List<Persona> lista)
        {
            ConsultadataGridView1.DataSource = null;
            ConsultadataGridView1.DataSource = lista;
        }

        private void CriteriotextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = getId();

            var lista = listaPersona.Where(i => i.Id == ID).ToList();

            foreach (var item in lista)
            {
                if(item.Id == ID)
                {
                    LlenaCampos(item);
                }
            }
        }

        private int getId()
        {
            int id = Convert.ToInt32(ConsultadataGridView1.CurrentRow.Cells[0].Value);

            return id;
        }
    }
}
