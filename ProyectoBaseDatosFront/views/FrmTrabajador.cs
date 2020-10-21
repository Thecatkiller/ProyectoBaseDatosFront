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
    public partial class FrmTrabajador : Form
    {
        public FrmTrabajador()
        {
            InitializeComponent();
        }

        private async void FrmTrabajador_Load(object sender, EventArgs e)
        {

            try
            {
                ClientApi api = new ClientApi("trabajador");
                List<Trabajador> trabajadores = await api.SendGet<List<Trabajador>>();

                foreach (var t in trabajadores)
                {
                    dgvTrabajadores.Rows.Add(t.codigo, t.tipoDocumento.Nombre, t.numeroDocumento);
                }
            }
            catch (JException ex)
            {
                MessageBox.Show(ex.message);
            }


        }
    }
}
