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

namespace Parcial1_AP1.UI.Consultas
{
    public partial class ConsultaEvaluacion : Form
    {
        public ConsultaEvaluacion()
        {
            InitializeComponent();
        }

        private void ConsultaEvaluacion_Load(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Evaluacion>();
            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (filtro.SelectedIndex)
                {
                    case 0:
                        listado = EvaluacionBLL.GetList(p => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = EvaluacionBLL.GetList(p => p.EvaluacionID == id);
                        break;

                }
                listado = listado.Where(c => c.Fecha.Date >= DesdeTimePicker1.Value.Date && c.Fecha.Date <= HastadataTimer.Value.Date).ToList();

            }
            else
            {
                listado = EvaluacionBLL.GetList(p => true);
            }

            MydataGridView.DataSource = null;
            MydataGridView.DataSource = listado;
        }
    }
}
