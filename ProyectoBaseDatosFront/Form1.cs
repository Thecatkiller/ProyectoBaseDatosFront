
using Newtonsoft.Json;
using ProyectoBaseDatosFront.http.client.request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBaseDatosFront.http.client.helper;
using ProyectoBaseDatosFront.http.client.response;
using ProyectoBaseDatosFront.views;

namespace ProyectoBaseDatosFront
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            UsuarioRQ objRq = new UsuarioRQ();
            objRq.usuario = txtUsuario.Text;
            objRq.clave = txtClave.Text;

            ClientApi api = new ClientApi("usuario/validateCredentials");
            try
            {
                Persona p = await api.SendPost<Persona>(objRq);
                MessageBox.Show("Bienvenid(a) " + p.nombres);

                this.Visible = false;
                FrmMain x = new FrmMain();
                x.ShowDialog();

                this.Close();
            }
            catch (JException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
