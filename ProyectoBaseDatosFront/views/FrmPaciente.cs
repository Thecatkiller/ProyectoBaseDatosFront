using ProyectoBaseDatosFront.http.client.helper;
using ProyectoBaseDatosFront.http.client.request;
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
        private List<Paciente> Pacientes;

        public FrmPaciente()
        {
            InitializeComponent();
        }

        private async void FrmPaciente_Load(object sender, EventArgs e)
        {
            await LoadPacientes();
            await LoadTiposDocumento();
        }



        private async Task LoadPacientes()
        {
            ClientApi api = new ClientApi("paciente");
            List<Paciente> pacientes = Pacientes = await api.SendGet<List<Paciente>>();

            dgvPacientes.Rows.Clear();
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


        private async Task LoadTiposDocumento()
        {
            ClientApi api = new ClientApi("tipo-documento");
            List<TipoDocumento> tipoDocumentos = await api.SendGet<List<TipoDocumento>>();
            tipoDocumentos.ForEach(x => cboTipoDocumento.Items.Add(x));
        }

        private async Task<bool> RegistrarPaciente()
        {

            if (cboSexo.SelectedIndex >= 0 && cboTipoDocumento.SelectedIndex >= 0)
            {
                try
                {
                    ClientApi api = new ClientApi("paciente");

                    PacienteRegisterRQ paciente = new PacienteRegisterRQ();
                    paciente.Nombres = txtNombres.Text;
                    paciente.Apellidos = txtApellidos.Text;
                    paciente.Sexo = cboSexo.SelectedItem.ToString();
                    paciente.NumeroDocumento = txtNumDoc.Text;
                    paciente.TipoDocumento = new PacienteRegisterRQ.TipoDocumentoRQ()
                    {
                        Codigo = ((TipoDocumento)cboTipoDocumento.SelectedItem).Codigo
                    };
                    paciente.FechaNacimiento = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                    await api.SendPost<long>(paciente);
                    return true;
                }
                catch (JException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return false;

        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (await RegistrarPaciente())
            {
                await LoadPacientes();
            }

        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var row = dgvPacientes.Rows[e.RowIndex];
                var codigo = row.Cells[0].Value;

                if (Pacientes != null)
                {
                    var p = Pacientes.Where(x => x.Codigo == (long)codigo).FirstOrDefault();
                    FrmFactoresRiesgoPaciente frm = new FrmFactoresRiesgoPaciente(p);
                    frm.ShowDialog();
                }

            }

        }
    }
}
