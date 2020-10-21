using Newtonsoft.Json; 
namespace ProyectoBaseDatosFront.http.client.response{ 

    public class ContactosEmergencia    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; } 

        [JsonProperty("nombres")]
        public string Nombres { get; set; } 

        [JsonProperty("apellidos")]
        public string Apellidos { get; set; } 

        [JsonProperty("celular")]
        public string Celular { get; set; } 

        [JsonProperty("telefono")]
        public object Telefono { get; set; } 

        [JsonProperty("correo")]
        public string Correo { get; set; } 

        [JsonProperty("fechaNacimiento")]
        public object FechaNacimiento { get; set; } 

        [JsonProperty("gradoParentesco")]
        public string GradoParentesco { get; set; } 
    }

}