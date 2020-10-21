using Newtonsoft.Json; 
namespace ProyectoBaseDatosFront.http.client.response{ 

    public class DatosContacto    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; } 

        [JsonProperty("correo")]
        public string Correo { get; set; } 

        [JsonProperty("celular")]
        public string Celular { get; set; } 

        [JsonProperty("telefonoFijo")]
        public object TelefonoFijo { get; set; } 

        [JsonProperty("direccion")]
        public string Direccion { get; set; } 

        [JsonProperty("distrito")]
        public Distrito Distrito { get; set; } 
    }

}