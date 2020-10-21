using Newtonsoft.Json; 
namespace ProyectoBaseDatosFront.http.client.response{ 

    public class Distrito    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; } 

        [JsonProperty("nombre")]
        public string Nombre { get; set; } 

        [JsonProperty("provincia")]
        public Provincia Provincia { get; set; } 
    }

}