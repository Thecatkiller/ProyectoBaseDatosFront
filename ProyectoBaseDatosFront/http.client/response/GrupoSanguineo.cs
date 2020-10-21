using Newtonsoft.Json; 
namespace ProyectoBaseDatosFront.http.client.response{ 

    public class GrupoSanguineo    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; } 

        [JsonProperty("nombre")]
        public string Nombre { get; set; } 
    }

}