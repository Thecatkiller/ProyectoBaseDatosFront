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
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
        }

        private async void FrmPaciente_Load(object sender, EventArgs e)
        {
           
            ClientApi api = new ClientApi("paciente");
            List<Paciente> pacientes = await api.SendGet<List<Paciente>>();

            pacientes.ForEach(x =>
                dgvPacientes.Rows.Add(
                    x.Codigo,
                    x.Nombres,
                    x.Apellidos,
                    x.TipoDocumento.Nombre + "-" + x.NumeroDocumento,
                    x.Sexo,
                    x.GrupoSanguineo?.Nombre,
                    x.GetEdad(),
                    x.DatosContacto?.Correo,
                    x.DatosContacto?.Celular
                    )
            );
        }
    }
}
