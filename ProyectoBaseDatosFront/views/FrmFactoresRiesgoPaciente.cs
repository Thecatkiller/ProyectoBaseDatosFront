using ProyectoBaseDatosFront.http.client.helper;
using ProyectoBaseDatosFront.http.client.response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBaseDatosFront.views
{
    public partial class FrmFactoresRiesgoPaciente : Form
    {
        private readonly Paciente paciente;
        public FrmFactoresRiesgoPaciente(Paciente paciente)
        {
            this.paciente = paciente;
            InitializeComponent();
        }

        private async void FrmFactoresRiesgoPaciente_Load(object sender, EventArgs e)
        {
            ShowPacienteData();
            ClientApi api = new ClientApi("factor-riesgo");
            List<FactorRiesgo> factorRiesgos = await api.SendGet<List<FactorRiesgo>>();

            factorRiesgos.ForEach(x =>
            {
                string presenta = "-";
                string comentario = "";
                Nullable<DateTime> fechaRegistro = null;
                var factorFound = paciente.Historial?.FactoresRiesgo?
                 .Where(f => f.FactorRiesgo.Codigo == x.Codigo)
                 .FirstOrDefault();

                if (factorFound != null)
                {
                    presenta = "SI";
                    comentario = factorFound.Comentario;
                    fechaRegistro = factorFound.FechaRegistro;
                }

                dgvFactorRiesgoPaciente.Rows.Add(x.Codigo, x.Nombre, presenta, comentario, fechaRegistro);
            });



        }


        private void ShowPacienteData()
        {
            txtNombres.Text = paciente.Nombres;
            txtApellidos.Text = paciente.Apellidos;
        }
    }
}
