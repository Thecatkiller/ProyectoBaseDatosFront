using Newtonsoft.Json; 
namespace ProyectoBaseDatosFront.http.client.response{ 

    public class Usuario    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; } 

        [JsonProperty("usuario")]
        public string User { get; set; } 

        [JsonProperty("activo")]
        public bool Activo { get; set; } 
    }

}