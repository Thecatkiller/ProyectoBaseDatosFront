using Newtonsoft.Json;

namespace ProyectoBaseDatosFront.http.client.request
{
    public class PacienteRegisterRQ
    {
        public class TipoDocumentoRQ
        {
            [JsonProperty("codigo")]
            public int Codigo { get; set; }
        }


        [JsonProperty("nombres")]
        public string Nombres { get; set; }

        [JsonProperty("apellidos")]
        public string Apellidos { get; set; }

        [JsonProperty("sexo")]
        public string Sexo { get; set; }

        [JsonProperty("numeroDocumento")]
        public string NumeroDocumento { get; set; }

        [JsonProperty("tipoDocumento")]
        public TipoDocumentoRQ TipoDocumento { get; set; }

        [JsonProperty("fechaNacimiento")]
        public string FechaNacimiento { get; set; }


    }
}
