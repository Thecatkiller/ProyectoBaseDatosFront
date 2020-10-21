using Newtonsoft.Json; 
namespace ProyectoBaseDatosFront.http.client.response{ 

    public class TipoDocumento    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; } 

        [JsonProperty("nombre")]
        public string Nombre { get; set; } 
    }

}