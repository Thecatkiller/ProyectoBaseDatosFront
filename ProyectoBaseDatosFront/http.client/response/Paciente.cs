using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace ProyectoBaseDatosFront.http.client.response
{

    public class Paciente
    {
        [JsonProperty("codigo")]
        public long Codigo { get; set; }

        [JsonProperty("tipoDocumento")]
        public TipoDocumento TipoDocumento { get; set; }

        [JsonProperty("numeroDocumento")]
        public string NumeroDocumento { get; set; }

        [JsonProperty("nombres")]
        public string Nombres { get; set; }

        [JsonProperty("apellidos")]
        public string Apellidos { get; set; }

        [JsonProperty("fechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [JsonProperty("sexo")]
        public string Sexo { get; set; }

        [JsonProperty("datosContacto")]
        public DatosContacto DatosContacto { get; set; }

        [JsonProperty("usuario")]
        public Usuario Usuario { get; set; }

        [JsonProperty("tipoPersona")]
        public string TipoPersona { get; set; }

        [JsonProperty("grupoSanguineo")]
        public GrupoSanguineo GrupoSanguineo { get; set; }

        [JsonProperty("seguroSocial")]
        public object SeguroSocial { get; set; }

        [JsonProperty("historial")]
        public Historial Historial { get; set; }

        [JsonProperty("contactosEmergencia")]
        public List<ContactosEmergencia> ContactosEmergencia { get; set; }

        public int GetEdad()
        {
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - FechaNacimiento.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (FechaNacimiento.Date > today.AddYears(-age)) age--;

            return age;
        }

    }

}