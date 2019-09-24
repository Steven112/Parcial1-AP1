using Parcial1_AP1.BLL;
using Parcial1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_AP1.UI.Registros
{
    public partial class RegistroDeEvaluacion : Form
    {
        public RegistroDeEvaluacion()
        {
            InitializeComponent();
        }

        private Evaluacion LlenaClase()
        {
            Evaluacion evaluacion = new Evaluacion();

            evaluacion.EvaluacionID = Convert.ToInt32(IDnumericUpDown.Value);
            evaluacion.Fecha = FechadateTimePicker.Value;
            evaluacion.Estudiante = EstudiantetextBox.Text;
            evaluacion.Valor = Convert.ToDecimal(ValortextBox.Text);
            evaluacion.Logrado = Convert.ToDecimal(LogradotextBox.Text);
            decimal total = evaluacion.Valor - evaluacion.Logrado;
            evaluacion.Perdido= evaluacion.Valor / total*10;
            //evaluacion.Pronostico = Convert.ToInt32(PronosticocomboBox.Text);
            

            

            return evaluacion;
        }

        public void LlenaCampo(Evaluacion evaluacion)
        {
            IDnumericUpDown.Value = evaluacion.EvaluacionID;
            FechadateTimePicker.Value = evaluacion.Fecha;
            EstudiantetextBox.Text = evaluacion.Estudiante;
            ValortextBox.Text = Convert.ToString(evaluacion.Valor);
            LogradotextBox.Text = Convert.ToString(evaluacion.Logrado);
            PerdidotextBox.Text = Convert.ToString(evaluacion.Perdido);
            //PronosticocomboBox.Text = Convert.ToString(evaluacion.Pronostico);

            
        }

        private bool ExisteEnBaseDeDatos()
        {
            Evaluacion evaluacion = EvaluacionBLL.Buscar((int)IDnumericUpDown.Value);
            return (evaluacion != null);
        }

        private bool Validar()
        {
            MyerrorProvider.Clear();
            bool paso = true;

            if (EstudiantetextBox.Text == String.Empty)
            {
                MyerrorProvider.SetError(EstudiantetextBox, "No debe quedarse vacio");
                EstudiantetextBox.Focus();
                paso = false;
            }

            if (Convert.ToDecimal(ValortextBox.Text)>31)
            {
                MyerrorProvider.SetError(ValortextBox, "Campo llenado incorrectamente");
                ValortextBox.Focus();
                paso = false;
            }

            if (Convert.ToDecimal(LogradotextBox.Text) > 31)
            {
                MyerrorProvider.SetError(LogradotextBox, "Campo llenado incorrectamente");
                LogradotextBox.Focus();
                paso = false;
            }
            return paso;
        }

        public void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            EstudiantetextBox.Text = string.Empty;
            ValortextBox.Text = "0";
            LogradotextBox.Text = "0";
            PerdidotextBox.Text = "0";
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void RegistroDeEvaluacion_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Evaluacion evaluacion = new Evaluacion();
            bool paso;

            if (!Validar())
                return;
            evaluacion = LlenaClase();

            if (IDnumericUpDown.Value == 0)
            {
                paso = EvaluacionBLL.Guardar(evaluacion);
            }
            else
            {
                if (!ExisteEnBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = EvaluacionBLL.Modificar(evaluacion);

            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Problemas al guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDnumericUpDown.Value);

            Evaluacion evaluacion = new Evaluacion();

            evaluacion = EvaluacionBLL.Buscar(id);

            if (evaluacion != null)
            {
                MessageBox.Show("Registro Encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenaCampo(evaluacion);
            }
            else
            {
                MessageBox.Show("Registro No Encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDnumericUpDown.Value);
            MyerrorProvider.Clear();

            Evaluacion evaluacion = new Evaluacion();

           

            if (EvaluacionBLL.Eliminar(id))
            {
                MessageBox.Show("Registro Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenaCampo(evaluacion);
            }
            else
            {
                MyerrorProvider.SetError(IDnumericUpDown, "No se pudo eliminar el registro");
            }
        }

        private void PerdidotextBox_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
